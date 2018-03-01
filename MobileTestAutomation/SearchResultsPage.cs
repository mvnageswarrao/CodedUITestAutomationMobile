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
            WriteLogs("########## START ########## Search Results Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            InitiateSearchPage runscript = new InitiateSearchPage();
            string sqlQuery = string.Empty;
            Boolean IsZeroVillasinSRPage = false;
            string selectedDuration = string.Empty;
            DateTime SelectableDate = new DateTime();
            string SelectedCenter = string.Empty;
            string centerCode = string.Empty;
            int NumofAdultsSelected = 0;
            int NumofChildSelected = 0;
            int NumofInfantsSelected = 0;
            string SelectedArrport = string.Empty;
            runscript.OpenBrowser_Obj.OpenBrowser_Method();
            runscript.EnterURL_Obj.EnterURL_Method(strURL);
            do
            {
                runscript.clickOpenSearchPage_obj.clickOpenSearchPage_Method(strURL);
                string Destdefaultselection = runscript.clickDestinationResortVilla_obj.DfltDestination_Method();
                string DefaultSelectedDate = runscript.clickCalenderIcon_obj.GetDefaultSelectedDate_Method();
                runscript.clickDestinationResortVilla_obj.clickDestinationResortVilla_Method();
                runscript.verifyCenternamesPopulated_obj.verifyCenternamesPopulated_Method();
                List<string> centreNameList = new List<string>();
                sqlQuery = "SELECT centreName  from  dbo.TblCentre";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    centreNameList.Add(dataReader["centreName"].ToString());
                }
                SelectedCenter = runscript.selectingDestinationFrmSearch_obj.selectingDestinationFrmSearch_Method(centreNameList, Destdefaultselection);
                sqlQuery = "SELECT Centre  from  dbo.TblCentre where CentreName = '" + SelectedCenter + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    centerCode = dataReader["Centre"].ToString();
                }
                int MinOccupancy = 0;
                int MaxOccupancy = 0;
                sqlQuery = "Select  Min(Minoccupancy), Max(MaxOccupancy) from tblvilla where Centre = '" + centerCode + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    MinOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MaxOccupancy = Convert.ToInt32(dataReader[1].ToString());
                }
                DateTime StartDate = System.DateTime.Today;
                List<string> DatesList = new List<String>();
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='02/07/2016'";
                dataReader = getData.getData(sqlQuery);
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
                Boolean slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                while (slctnextfrmCal == true)
                {
                    //Boolean IsHoverNextAvaialable = runscript.clickNextArrowFrmCalender_obj.IsHoverNextAvail_Method();
                    //if (IsHoverNextAvaialable == true)
                    //{
                    //    runscript.clickNextArrowFrmCalender_obj.clickNextArrowFrmCalender_Method();
                    //}
                    //else
                    //{
                    //runscript.dragCal_obj.dragCal_Method();
                    //    runscript.selectDateFrmCalender_obj.DragingCalControl_Method();
                    runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method();
                    //}
                    //runscript.clickNextArrowThrice_obj.clickNextArrowThrice_Method();
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
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    ArrportNameList.Add(dataReader["AirportName"].ToString());
                }
                string DefaultAirport = runscript.clickDepAirportBox_obj.clickDepAirportBox_Method();
                SelectedArrport = runscript.selectDepAirport_obj.selectDepAirport_Method(DefaultAirport, ArrportNameList);
                runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
                runscript.verifySRPagedisplay_obj.verifySRPagedisplay_Method();
                IsZeroVillasinSRPage = runscript.verifySRPagedisplay_obj.IsZEROVillasInSRPage_Method();
            } while (IsZeroVillasinSRPage == true);
            #endregion

            #region Search Results Page
            int selectedDurationForQuery = Convert.ToInt32(selectedDuration.Replace("nights",""));
            string SelectedDateForQuery = SelectableDate.ToString();
            int index = SelectedDateForQuery.IndexOf(' ');
            SelectedDateForQuery = SelectedDateForQuery.Remove(index);
            int VillaCount = 0;
            if (SelectedCenter == "ANY")
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + selectedDurationForQuery + ",'','" + SelectedDateForQuery + "',20," + NumofAdultsSelected + "," + NumofChildSelected + ",'ANY'";
                while (dataReader.Read())
                {
                    VillaCount = Convert.ToInt32(dataReader[0].ToString());
                }
            }
            else
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + selectedDurationForQuery + "," + "'" + centerCode + "','" + SelectedDateForQuery + "',20," + NumofAdultsSelected + "," + NumofChildSelected + ",'ANY'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    VillaCount = Convert.ToInt32(dataReader[0].ToString());
                }
            }
            runscript.verifySearchCriteriaDisplay_obj.verifySearchCriteriaDisplay_Method(VillaCount,NumofAdultsSelected, NumofChildSelected, NumofInfantsSelected, SelectableDate, selectedDuration, SelectedArrport);
            string Villaname = runscript.clickVillaNameLink_obj.clickVillaNameLink_Method();
            runscript.verifyProductPagedisplay_obj.verifyProductPagedisplay_Method(Villaname);
            runscript.clickBackFrmPrdctPage_obj.clickBackFrmPrdctPage_Method();
            runscript.clickMoreInfoBtn_obj.clickMoreInfoBtn_Method();
            runscript.clickBackFrmPrdctPage_obj.clickBackFrmPrdctPage_Method();
            runscript.clickOnVillaImage_obj.clickOnVillaImage_Method();

            runscript.clickUsefulLinksHeading_obj.clickUsefulLinksHeading_Method();
            runscript.clickAllusefulLinks_obj.clickAllusefulLinks_Method();
            runscript.clickBookVillaAndFlightsBtn_obj.clickBookVillaAndFlightsBtn_Method(strURL);
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            runscript.clickBackFrmFlightsPage_obj.clickBackFrmFlightsPage_Method();
            runscript.clickBookVillaOnlyBtn_obj.clickBookVillaOnlyBtn_Method();
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            runscript.clickBackFrmFlightsPage_obj.clickBackFrmFlightsPage_Method();
            if(VillaCount>10)
            {
                runscript.clickShowMoreResultsBtn_obj.verifyShowMoreResultsBtndisplay_Method();
                runscript.clickShowMoreResultsBtn_obj.clickShowMoreResultsBtn_Method();
            }
            runscript.clickSortBy_obj.clickSortBy_Method();
            runscript.selectSortOption_obj.selectSortOption_Method();
            runscript.clickApplySort_obj.clickApplySort_Method();
            List<object> VillaDetailsLst = new List<object>();
            VillaDetailsLst = runscript.getVilladetailsBlock_obj.getVilladetailsBlock_Method();

            runscript.clickFilterBy_obj.clickFilterBy_Method();
            //runscript.clickFilterName_obj.clickFilterName_Method();
            runscript.clickPlusForFilter_obj.clickPlusForFilter_Method();
            runscript.clickClearFilter_obj.clickClearFilter_Method();
            runscript.clickPlusForFilter_obj.clickPlusForFilter_Method();
            runscript.clickApplyFilter_obj.clickApplyFilter_Method();
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
