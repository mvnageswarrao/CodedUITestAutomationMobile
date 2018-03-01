using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace MobileTestAutomation.Utility
{
    class pdfCheck:logWriter
    {
        public pdfCheck()
        {
        }

        public void WriteExpBDetailsFrmPDFtoTxt(string BookingRef, string LeadFullNAME, string flttypeSupptxt, string PDFretdate, string PDFdepdate, string PDFDeport, string PDFDeptime, string PDFArrport, string PDFArrtime, decimal TotalPRICE, decimal DEPOSIT)
        {
            string strAppPath = ConfigurationManager.AppSettings["PDFtoTxtFilePath"].ToString();
            string Datetimeformats = Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd").ToString();
            //string todayDate = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd hh mm").ToString();
            //string[] AllfileNames = Directory.GetFileSystemEntries(PDFFileFolderPath, todayDate + "_E*.pdf");
            string ExpBkgDetailsfileName = "Expected_" + Datetimeformats + "_" + BookingRef + ".txt";
            FileInfo Expfile = new FileInfo(strAppPath + ExpBkgDetailsfileName);
            StreamWriter w = Expfile.AppendText();
            w.WriteLine(BookingRef);
            w.WriteLine(LeadFullNAME);
            w.WriteLine(flttypeSupptxt);
            w.WriteLine(PDFretdate);
            w.WriteLine(PDFdepdate);
            w.WriteLine(PDFDeport);
            w.WriteLine(PDFDeptime);
            w.WriteLine(PDFArrport);
            w.WriteLine(PDFArrtime);
            w.WriteLine(TotalPRICE);
            w.WriteLine(DEPOSIT);
            w.Close();
            WriteLogs("PASS : Expected Booking Details File has been created @given path.");

            string[] Isfileexists = Directory.GetFiles(strAppPath, "BookingRef_IDs_" + Datetimeformats + "*.txt", SearchOption.TopDirectoryOnly);

            if (Isfileexists.Length.Equals(0))
            {
                string Datetimeformat = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd hh mm").ToString();
                string BookingReffilename = "BookingRef_IDs_" + Datetimeformat + ".txt";
                //Boolean isfileexists = Directory.Exists(strAppPath + "BookingRef_IDs_*.txt");
                //isfileexists = File.Exists(strAppPath + "BookingRef_IDs_*.txt");
                FileInfo RefNumList = new FileInfo(strAppPath + BookingReffilename);
                StreamWriter SW = RefNumList.AppendText();
                SW.WriteLine(BookingRef);
                SW.Close();
                WriteLogs("PASS : List of Booking ref File has been created @given path.");
            }
            else
            {
                int filecount = Isfileexists.Count();
                FileInfo RefNumsfile = new FileInfo(Isfileexists[filecount - 1]);
                StreamWriter Swr = RefNumsfile.AppendText();
                Swr.WriteLine(BookingRef);
                Swr.Close();
                WriteLogs("PASS : List of Booking ref File has been Updated @given path.");
            }
        }

        public void ConvertAllPDFstoTXT()
        {
            string PDFFileFolderPath = ConfigurationManager.AppSettings["BookingPDFFilePath"].ToString();
            string ToDateformat = Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd").ToString();
            string strAppPath = ConfigurationManager.AppSettings["PDFtoTxtFilePath"].ToString();
            string[] AllfileNames = Directory.GetFileSystemEntries(PDFFileFolderPath, ToDateformat + "*_E*.pdf");

            //List<string[]> list = new List<string[]>();
            //StreamReader sr = new StreamReader(strAppPath + "BookingRef_IDs_" + ToDateformat + ".txt");
            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    string[] array = line.Split(' ');
            //    list.Add(array);
            //}

            //foreach (string item in list)
            //{
            //    string name = item[0];
            //    string no1 = item[1];
            //    string no1 = item[2];
            //    //you can convert to int if oyu like:
            //    int intNo1 = int.Parse(item[0]);
            //}

            foreach (var PDFFilePath in AllfileNames)
            {
                PDDocument PDF = PDDocument.load(PDFFilePath);
                PDFTextStripper stripper = new PDFTextStripper();
                string text = stripper.getText(PDF);
                PDF.close();
                string logfileName = PDFFilePath.Trim() + ".txt";
                string[] logfileNameARR = logfileName.Split('\\');
                string PDFFileName = logfileNameARR[3];
                string[] PDFFileNamearr = PDFFileName.Split('_');
                PDFFileName = PDFFileNamearr[1];

                FileStream fs = new FileStream(strAppPath + "Actual_" + ToDateformat + "_" + PDFFileName, FileMode.Create);
                StreamWriter w = new StreamWriter(fs);
                w.WriteLine(text);
                w.Close();
            }
        }

        public void VerifyAllPDFs()
        {
            string TxtFilesPath = ConfigurationManager.AppSettings["PDFtoTxtFilePath"].ToString();
            string ToDateformat = Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd").ToString();
            string[] ExpFiles = Directory.GetFileSystemEntries(TxtFilesPath, "Expected_" + ToDateformat + "_*.txt");
            //var directory = new DirectoryInfo(strAppPath);
            //var smf_log_name = directory.GetFiles("*.txt").OrderByDescending(f => f.LastWriteTime).First();
            foreach (var file in ExpFiles)
            {
                string[] ExpFileNameArr = file.Split('\\');
                int underscoreindex = ExpFileNameArr[3].Trim().LastIndexOf('_');
                string ExpFileRef = ExpFileNameArr[3].Remove(0, underscoreindex + 1);
                int firstdotindex = ExpFileRef.IndexOf('.');
                ExpFileRef = ExpFileRef.Remove(firstdotindex).Trim();
                string ExpFileName = "Expected_" + ToDateformat + "_" + ExpFileRef + ".txt";
                string ActFileName = "Actual_" + ToDateformat + "_" + ExpFileRef + ".pdf.txt";

                bool isActFileExists = File.Exists(TxtFilesPath + ActFileName);
                bool isExpFileExists = File.Exists(TxtFilesPath + ExpFileName);
                if (isActFileExists == true && isExpFileExists == true)
                {
                    string[] AlllinesFrmActFile = File.ReadAllLines(TxtFilesPath + ActFileName);
                    Boolean found = false;
                    foreach (string line in File.ReadLines(TxtFilesPath + ExpFileName))
                    {
                        foreach (string lineact in File.ReadLines(TxtFilesPath + ActFileName))
                        {
                            if (lineact.Contains(line))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found == true)
                        {
                            WriteLogs("PASS : Text \"" + line + "\" Found in Booking PDF.");
                            found = false;
                        }
                        else
                        {
                            WriteLogs("FAIL : Text \"" + line + "\" Could Not Found in Booking PDF.");
                        }
                    }
                }

                //if (isExpFileExists == true && isActFileExists == true)
                //{
                //    //string ActFile = Directory.GetFileSystemEntries(TxtFilesPath, "Abc_*.txt");
                //    foreach (string line in File.ReadLines(TxtFilesPath + ExpFileName))
                //    {
                //        for (int i = 0; i <= Convert.ToInt32(AlllinesFrmActFile.Length.ToString()); i++)
                //        {
                //            //if (line.Contains(AlllinesFrmActFile[i]))
                //            if (AlllinesFrmActFile[i].Contains(line))
                //            {
                //                WriteLogs("PASS : " + line + " Found in Booking PDF.");
                //                pass = true;
                //                break;
                //            }
                //        }
                //        if (!pass)
                //        {
                //            WriteLogs("FAIL : " + line + " Could Not Found in Booking PDF.");
                //        }
                //    }
                // }
                //else
                //{
                //    if (isExpFileExists != true)
                //    {
                //        WriteLogs("FAIL : " + ExpFileName + " - File Could Not Found in Specified Folder.");
                //    }
                //    else if (isActFileExists!=true)
                //    {
                //        WriteLogs("FAIL : " + ActFileName + " - File Could Not Found in Specified Folder.");
                //    }
                //}
            }
        }

    }
}
