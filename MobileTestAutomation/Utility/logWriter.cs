using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Diagnostics;

namespace MobileTestAutomation.Utility
{
    public interface ILogWriter
    {
        void WriteLogs(string Status);
        void takeImage(string imageName);
    }
    public class logWriter : ILogWriter
    {
        public logWriter()
        {

        }

        public void WriteLogs(string Status)
        {
            string logfileName = "";
            StackTrace stackTrace = new StackTrace();           // get call stack
            StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)

            // write call stack method names
            foreach (StackFrame stackFrame in stackFrames)
            {
                if (stackFrame.GetMethod().Name == "InvokeMethod")
                {
                    break;
                }
                else
                {
                    logfileName = stackFrame.GetMethod().Name;
                }
            }
            logfileName = logfileName + "_" + DateTime.Now.ToString("dd-MM-yyyy");

            string strAppPath = ConfigurationManager.AppSettings["resultPath"].ToString();

            if (Status.Contains("PASS"))
            {
                FileInfo f = new FileInfo(strAppPath + logfileName + "_PASS.txt");
                StreamWriter w = f.AppendText();
                w.WriteLine(Status);
                w.Close();
            }
            else if (Status.Contains("FAIL"))
            {
                FileInfo f = new FileInfo(strAppPath + logfileName + "_FAIL.txt");
                StreamWriter w = f.AppendText();
                w.WriteLine(Status);
                w.Close();
            }
            else if (Status.Contains("INFO"))
            {
                FileInfo f = new FileInfo(strAppPath + logfileName + "_PASS.txt");
                StreamWriter w = f.AppendText();
                w.WriteLine(Status);
                w.Close();
            }
            else
            {
                FileInfo f1 = new FileInfo(strAppPath + logfileName + "_PASS.txt");
                StreamWriter w1 = f1.AppendText();
                FileInfo f2 = new FileInfo(strAppPath + logfileName + "_FAIL.txt");
                StreamWriter w2 = f2.AppendText();
                w1.WriteLine(Status);
                w1.Close();
                w2.WriteLine(Status);
                w2.Close();
            }
        }

        public void takeImage(string imageName)
        {
            string imgfileName = "";
            StackTrace stackTrace = new StackTrace();           // get call stack
            StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)

            // write call stack method names
            foreach (StackFrame stackFrame in stackFrames)
            {
                if (stackFrame.GetMethod().Name == "InvokeMethod")
                {
                    break;
                }
                else
                {
                    imgfileName = stackFrame.GetMethod().Name;
                }
            }
            imgfileName = imgfileName + "_" + DateTime.Now.ToString("dd-MM-yyyy");

            string strAppPath = ConfigurationManager.AppSettings["resultPath"].ToString();
            //strAppPath = "@"+strAppPath;
            System.Drawing.Image im = UITestControl.Desktop.CaptureImage();
            im.Save(@strAppPath + imgfileName + "-" + imageName + ".png");
        }

        public void delayExecution(string strURL)
        {
            int waitTime = 0;

            if (strURL.Contains("rup1"))
            {
                waitTime = 10000;
            }
            else if (strURL.Contains("mobstaging") || strURL.Contains("tab"))
            {
                waitTime = 5000;
            }
            else if (strURL.Contains("gld") || strURL.Contains("glt"))
            {
                waitTime = 10000;
            }
            else if (strURL.Contains("www"))
            {
                waitTime = 5000;
            }
            else if (strURL.Contains("m"))
            {
                waitTime = 5000;
            }
            else
            {
                waitTime = 0;
            }
            Playback.Wait(waitTime);
        }
    }
}

    //public class DBlogWriter : ILogWriter
    //{
    //    public DBlogWriter()
    //    {

    //    }

    //    public void WriteLogs(string Status)
    //    {
    //        //Logic to wrire into Databaae
    //    }

    //    public void takeImage(string imageName)
    //    {
    //        //Logic to wrire into Databaae
    //    }
    //}

    