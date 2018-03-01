using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using MobileTestAutomation.Utility;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Data;
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;

namespace MobileTestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class SearchResultsPage:logWriter
    {
        public SearchResultsPage()
        {
        }

        [TestMethod]
        public void MobileSearchResultsPageVerification()
        {
            #region Home & Search Page
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString();
            string DBSelectionMode = ConfigurationManager.AppSettings["DBSelectionMode"].ToString();


            WriteLogs("########## START ########## Search Results Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            InitiateSearchPage runscript = new InitiateSearchPage();
            string sqlQuery = string.Empty;
            string InitialCatalog = string.Empty;

            Boolean IsZeroVillasinSRPage = false;
            string selectedDuration = string.Empty;
            DateTime SelectableDate = new DateTime();
            string SelectedCenter = string.Empty;
            string centerCode = string.Empty;
            int NumofAdultsSelected = 0;
            int NumofChildSelected = 0;
            int NumofInfantsSelected = 0;
            string SelectedArrport = string.Empty;
            if (DBSelectionMode == "Auto")
            {
                InitialCatalog = openBrowser_Map.ChooseDB(strURL);
            }
            else if (DBSelectionMode == "Manual")
            {
                InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            }
            runscript.OpenBrowser_Obj.OpenBrowser_Method();
            runscript.EnterURL_Obj.EnterURL_Method(strURL);
            Boolean isIncomBkgPopupOpened = runscript.verifyIncompleteBkgPopupDisplay_obj.verifyIncompleteBkgPopupDisplay_Method();
            if (isIncomBkgPopupOpened == true)
            {
                runscript.clickNOFrmIncomBkgPopup_obj.clickNOFrmIncomBkgPopup_Method();
            }
            #region Not To Be Used
            //sqlQuery = "exec dbo.QAsp_CalculateVillaPrice @villaName=N'Taganana',@departureDate =N'03-28-2017',@weeks=1";
            ////sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='" + EndDate + "'";

            //dataReader = getData.getData(sqlQuery);
            //if (dataReader.HasRows)
            //{
            //    Console.WriteLine(dataReader.FieldCount.ToString());
            //    while (dataReader.Read())
            //    {
            //        if (dataReader[0] == null)
            //        {
            //            Console.WriteLine("Null");
            //        }
            //        else
            //        {
            //            Console.WriteLine(dataReader[13].ToString());
            //        }
            //        dataReader.NextResult();

            //    }
            //}


            //while (dataReader.Read())
            //{
            //    try
            //    {
            //        dataReader.NextResult();
            //        //string a = dataReader["FlightDiscountUK"].ToString();
            //        string VillaName = dataReader[1].ToString();
            //        //dataReader.NextResult();
            //        //dataReader.NextResult();
            //        //dataReader.NextResult();
            //        //dataReader.NextResult();
            //        int tempVOPriceFromDB = Convert.ToInt32(dataReader[0].ToString());
            //    }
            //    catch (Exception ex)
            //    {
            //        ex.Message.ToString();
            //    }
            //}
            #endregion
            runscript.clickHeaderLogo_obj.verifyHeaderLogo_Method(strURL);
            runscript.clickHeaderLogo_obj.clickHeaderLogo_Method(strURL);
            runscript.clickHeaderLogo_obj.verifyAllHeaderCtrls(strURL);
            do
            {
                if (IsZeroVillasinSRPage == true)
                {
                    runscript.clickSearchIconFrmHeader_obj.clickSearchIconFrmHeader_Method(strURL);
                }
                else
                {
                    runscript.clickOpenSearchPage_obj.clickOpenSearchPage_Method(strURL);
                }
                //runscript.clickHeaderLogo_obj.verifyHeaderLogo_Method(strURL);
                string Destdefaultselection = runscript.clickDestinationResortVilla_obj.DfltDestination_Method(strURL);
                string DefaultSelectedDate = runscript.clickCalenderIcon_obj.GetDefaultSelectedDate_Method();
                runscript.clickDestinationResortVilla_obj.clickDestinationResortVilla_Method();
                runscript.verifyCenternamesPopulated_obj.verifyCenternamesPopulated_Method();
                List<string> centreNameList = new List<string>();
                sqlQuery = "SELECT centreName  from  dbo.TblCentre";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    centreNameList.Add(dataReader["centreName"].ToString());
                }
                SelectedCenter = runscript.selectingDestinationFrmSearch_obj.selectingDestinationFrmSearch_Method(centreNameList, Destdefaultselection);
                sqlQuery = "SELECT Centre  from  dbo.TblCentre where CentreName = '" + SelectedCenter + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    centerCode = dataReader["Centre"].ToString();
                }
                int MinOccupancy = 0;
                int MaxOccupancy = 0;
                sqlQuery = "Select  Min(Minoccupancy), Max(MaxOccupancy) from tblvilla where Centre = '" + centerCode + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    MinOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MaxOccupancy = Convert.ToInt32(dataReader[1].ToString());
                }
                string EndDate = ConfigurationManager.AppSettings["SeasonEndDate"].ToString();
                string StartDate = System.DateTime.Now.ToString("MM/dd/yyyy");
                List<string> DatesList = new List<String>();
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='" + EndDate + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    DatesList.Add(dataReader["WeekStart"].ToString());
                }
                int NumofDatesAvaial = DatesList.Count;
                Random rnd = new Random();
                int SelectableDateindex = rnd.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                Boolean iscalexists = runscript.verifyCalenderOpend_obj.verifyifcalalreadyopened_Method(DefaultSelectedDate, Destdefaultselection, SelectedCenter, DatesList);
                if (iscalexists == false)
                {
                    runscript.clickCalenderIcon_obj.clickCalenderIcon_Method();
                }
                string dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                Tuple<int,bool,bool> slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                while (slctnextfrmCal.Item2== true) 
                {                   
                    runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method(slctnextfrmCal.Item1);
                    dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                    slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                }
                while(slctnextfrmCal.Item3 == true)
                {
                    runscript.clickPrevArrowFrmCalender_obj.clickPrevArrowFrmCalender_Method(slctnextfrmCal.Item1);
                    dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                    slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                }

                //*********Verifying Duration Plus and Minus Icons Disablity functionality*********//
                runscript.clickPlusFrDuration_obj.verifyPlusFrDurationDisabled_Method();
                runscript.clickMinusFrDuration_obj.verifyMinusFrDurationDisabled_Method();
                selectedDuration = runscript.clickPlusFrDuration_obj.selectDuration_Method();

                //*********Verifying Minimum Occupacy check*********//
                List<object> returnvalues = runscript.clickPlusIconforAdults_obj.clickPlusIconforAdults_Method(MaxOccupancy);
                if (Convert.ToBoolean(returnvalues[1]) == true)
                {
                    NumofAdultsSelected = runscript.clickMinusfrAdults_obj.clickMinusfrAdults_Method(Convert.ToInt32(returnvalues[0]));
                }
                else
                {
                    NumofAdultsSelected = Convert.ToInt32(returnvalues[0]);
                }
                returnvalues = runscript.clickPlusiconforChild_obj.clickPlusiconforChild_Method(MaxOccupancy);
                if (Convert.ToBoolean(returnvalues[1]) == true)
                {
                    NumofChildSelected = runscript.clickMinusFrChild_obj.clickMinusFrChild_Method(Convert.ToInt32(returnvalues[0]));
                }
                else
                {
                    NumofChildSelected = Convert.ToInt32(returnvalues[0]);
                }
                List<object> returnvaluesForInfants = runscript.clickPlusIconforInfants_obj.clickPlusIconforInfants_Method(NumofAdultsSelected);
                if (Convert.ToBoolean(returnvaluesForInfants[0]) == true)
                {
                    NumofInfantsSelected = runscript.clickMinusFrInfants_obj.clickMinusFrInfants_Method(NumofAdultsSelected);
                }
                else
                {
                    NumofInfantsSelected = Convert.ToInt32(returnvaluesForInfants[1]);
                }
                List<string> ArrportNameList = new List<string>();
                sqlQuery = "select AirportName from dbo.Airports where GroupID !=0 or ParentID !=0 and CentreCode not like 'XX'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    ArrportNameList.Add(dataReader["AirportName"].ToString());
                }
                string DefaultAirport = runscript.clickDepAirportBox_obj.clickDepAirportBox_Method();
                do
                {
                    SelectedArrport = runscript.selectDepAirport_obj.selectDepAirport_Method(DefaultAirport, ArrportNameList);
                } while (SelectedArrport == "");
                runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
                runscript.verifySRPagedisplay_obj.verifySRPagedisplay_Method();
                //runscript.clickSearchIconFrmHeader_obj.clickSearchIconFrmHeader_Method(strURL);
                //runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
                IsZeroVillasinSRPage = runscript.verifySRPagedisplay_obj.IsZEROVillasInSRPage_Method();
            } while (IsZeroVillasinSRPage == true);
            #endregion

            #region Search Results Page
            runscript.clickHeaderLogo_obj.verifyHeaderLogo_Method(strURL);
            runscript.clickHeaderLogo_obj.clickHeaderLogo_Method(strURL);
            runscript.clickHeaderLogo_obj.verifyHeaderLogo_Method(strURL);
            runscript.clickHeaderLogo_obj.verifyAllHeaderCtrls(strURL);

            int selectedDurationForQuery = Convert.ToInt32(selectedDuration.Replace("nights",""));
            string SelectedDateForQuery = SelectableDate.ToString("MM/dd/yyyy");
            int villaCount = 0;
            Dictionary<string, string> objDestValuesFrmDB = new Dictionary<string, string>();
            Dictionary<string, string> objResortValuesFrmDB = new Dictionary<string, string>();
            Dictionary<string, string> objVillaTypeValuesFrmDB = new Dictionary<string, string>();
            Dictionary<string, string> objBedRoomValuesFrmDB = new Dictionary<string, string>();
            Dictionary<string, string> objVillaDetailValuesFrmDB = new Dictionary<string, string>();
            
            if (SelectedCenter == "ANY")
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + selectedDurationForQuery + ",'','" + SelectedDateForQuery + "',20," + NumofAdultsSelected + "," + NumofChildSelected + ",'ANY'";
                while (dataReader.Read())
                {
                    villaCount = Convert.ToInt32(dataReader[0].ToString());

                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objDestValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                    if (!objDestValuesFrmDB.ContainsKey(dataReader[1].ToString()))
                    {
                        objDestValuesFrmDB.Add(dataReader[1].ToString(), dataReader[2].ToString());
                    }
                    else
                    {
                        objDestValuesFrmDB[dataReader[1].ToString()] += Convert.ToInt32(dataReader[2]);
                    }
                }
                while (dataReader.Read())
                {
                    objResortValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objBedRoomValuesFrmDB.Add(dataReader[0].ToString().Trim(), dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objVillaTypeValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                }
            }
            else
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + selectedDurationForQuery + "," + "'" + centerCode + "','" + SelectedDateForQuery + "',20," + NumofAdultsSelected + "," + NumofChildSelected + ",'ANY'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    villaCount = Convert.ToInt32(dataReader[0].ToString());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objResortValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objVillaDetailValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Closed to Beach//
                    objVillaDetailValuesFrmDB.Add("Walk to beach", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Closed to Restaurent//
                    objVillaDetailValuesFrmDB.Add("Walk to shops & restaurants", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Air con/heating//
                    if (!objVillaDetailValuesFrmDB.ContainsKey("Air con/heating"))
                    {
                        objVillaDetailValuesFrmDB.Add("Air con/heating", dataReader[1].ToString().Trim());
                    }
                    else
                    {
                        int ix = Convert.ToInt32(dataReader[1]);
                        int iy = Convert.ToInt32(objVillaDetailValuesFrmDB["Air con/heating"]);
                        objVillaDetailValuesFrmDB["Air con/heating"] = (ix + iy).ToString().Trim();
                    }
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Has Pool Heating//
                    objVillaDetailValuesFrmDB.Add("Pool Heating", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Gated Pools//
                    objVillaDetailValuesFrmDB.Add("Gated Pools", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Quality IDs//
                    objVillaDetailValuesFrmDB.Add(dataReader[0].ToString().Trim(), dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Has Wifi//
                    objVillaDetailValuesFrmDB.Add("Wi-fi", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Removable Pool Fences//
                    objVillaDetailValuesFrmDB.Add("Pool Fence", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objBedRoomValuesFrmDB.Add(dataReader[0].ToString().Trim(), dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Greater Selusion//
                    objVillaDetailValuesFrmDB.Add("Greater seclusion", dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    objVillaTypeValuesFrmDB.Add(dataReader[1].ToString().Trim(), dataReader[2].ToString().Trim());
                }
            }
            runscript.verifySearchCriteriaDisplay_obj.verifySearchCriteriaDisplay_Method(villaCount, NumofAdultsSelected, NumofChildSelected, NumofInfantsSelected, SelectableDate, selectedDuration, SelectedArrport);
            runscript.clickFilterBy_obj.clickFilterBy_Method();
            runscript.clickFilterName_obj.clickFilterName_Method(objDestValuesFrmDB, objResortValuesFrmDB, objBedRoomValuesFrmDB, objVillaTypeValuesFrmDB, objVillaDetailValuesFrmDB);
            runscript.clickFilterBy_obj.clickFilterBy_Method();

            runscript.clickSortBy_obj.clickSortBy_Method();
            runscript.selectSortOption_obj.selectSortOption_Method();
            runscript.clickApplySort_obj.clickApplySort_Method();

            string Villaname = runscript.clickVillaNameLink_obj.clickVillaNameLink_Method();
            runscript.verifyProductPagedisplay_obj.verifyProductPagedisplay_Method(Villaname, strURL);
            runscript.clickBackFrmPrdctPage_obj.clickBackFrmPrdctPage_Method();
            runscript.clickMoreInfoBtn_obj.clickMoreInfoBtn_Method();
            runscript.clickBackFrmPrdctPage_obj.clickBackFrmPrdctPage_Method();
            runscript.clickOnVillaImage_obj.clickOnVillaImage_Method();
            
            runscript.clickBookVillaAndFlightsBtn_obj.clickBookVillaAndFlightsBtn_Method(strURL);
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            runscript.clickBackFrmFlightsPage_obj.clickBackFrmFlightsPage_Method();
            runscript.clickBookVillaOnlyBtn_obj.clickBookVillaOnlyBtn_Method();
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            runscript.clickBackFrmFlightsPage_obj.clickBackFrmFlightsPage_Method();
            if(villaCount > 10)
            {
                Boolean isShowMoreexits = runscript.clickShowMoreResultsBtn_obj.verifyShowMoreResultsBtndisplay_Method();
                do
                {
                    runscript.clickShowMoreResultsBtn_obj.clickShowMoreResultsBtn_Method();
                } while (isShowMoreexits == false);
            }
            List<int> VillaIDs;
            List<string> VillaDetailsList = new List<string>();
            //List<string> VOPriceList = new List<string>();
            string VOPriceFromDB = string.Empty;
            string VillanameFromDB = string.Empty;

            VillaIDs = runscript.clickHeaderLogo_obj.getVillaID(strURL);
            foreach (int VillaID in VillaIDs)
            {
                //Getting Villa detils from DB for Each Villa shown on SR Page//
                sqlQuery = "Select Detail From TblVillaOverview where VillaID=" + VillaID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    VillaDetailsList.Add(dataReader["Detail"].ToString());
                }

                //getting VO Price for all Villas from Search Results page//
                sqlQuery = "select ShortName from TblVilla where ID =" + VillaID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    VillanameFromDB = dataReader["ShortName"].ToString().Trim();
                }
                sqlQuery = "exec dbo.QAsp_CalculateVillaPrice @villaName=N\'" + VillanameFromDB + "\',@departureDate =N\'" + SelectedDateForQuery + "\',@weeks=" + (Convert.ToInt32(selectedDurationForQuery) / 7);
                DataSet datasetReader = getData.getdatafrmdtset(sqlQuery);
                VOPriceFromDB = datasetReader.Tables[3].Rows[0][13].ToString();
                runscript.clickHeaderLogo_obj.verifyVillaDetailsNPrices(strURL, VillaDetailsList, VillaID, VOPriceFromDB);

                #region Calculating PK Prices//
                //Get Supplier Code//
                if (Platform.Contains("Live"))
                {
                    sqlQuery = "select FAB_ResponseXml from FABLOG_Live.dbo.FABXmlLog  where RequestType like '%Search%' order by FAB_ResponseTimeStamp";
                }
                else
                {
                    sqlQuery = "select FAB_ResponseXml from FABLOG_Test.dbo.FABXmlLog  where RequestType like '%Search%' order by FAB_ResponseTimeStamp";
                }
                datasetReader = getData.getdatafrmdtset(sqlQuery);
                string FABResponseXML = datasetReader.Tables[0].Rows[0][0].ToString();
                //Get Supplier from FABResponseXML//
                //Get No of Adults selected//
                //Get No of Child selected//
                //Get No of Infants selected//
                //Get Infant Price from DB //
                //Get Final VO Price from DB //
                //Get Child Reduction from DB //
                //Get Basic Cost from DB //
                //Get Baggage Cost from DB //
                //Get Card Charge from DB //
                //Get Fab Charge from DB //
                //Get Other Cost from DB //
                //Now do the Actual Calculation//
                #endregion
            }
            runscript.clickUsefulLinksHeading_obj.clickUsefulLinksHeading_Method();
            runscript.clickAllusefulLinks_obj.clickAllusefulLinks_Method();
            runscript.clickABTAFrmFooter_obj.clickABTAFrmFooter_Method();
            runscript.clickABTAFrmFooter_obj.verifyABTAPage_Method();
            runscript.clickATOLFrmFooter_obj.clickATOLFrmFooter_Method();
            runscript.clickATOLFrmFooter_obj.verifyATOLPage_Method();
            runscript.clickExitToDesktop_obj.clickExitToDesktop_Method();
            runscript.clickExitToDesktop_obj.verifyDesktopSitePage_Method();
            runscript.clickZolvlink_obj.clickZolvlink_Method();
            runscript.clickZolvlink_obj.verifyZolvSitePage_Method();
            runscript.clickATOLFrmFooter_obj.clickNverifySocialLinks_Method();
            #endregion
        }


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
