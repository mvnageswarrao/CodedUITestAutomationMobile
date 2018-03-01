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
using MobileTestAutomation.Utility;
using System.Data.SqlClient;



namespace MobileTestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class SearchPage:logWriter
    {
        public SearchPage()
        {
        }

        [TestMethod]
        public void MobileSearchPageVerification()
        {

          string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            
            WriteLogs("########## START ########## Search Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            InitiateSearchPage runscript = new InitiateSearchPage();

            runscript.OpenBrowser_Obj.OpenBrowser_Method();
            runscript.EnterURL_Obj.EnterURL_Method(strURL);
            runscript.clickOpenSearchPage_obj.clickOpenSearchPage_Method(strURL);
            runscript.clickHeaderLogo_obj.clickHeaderLogo_Method();
            runscript.clickBackFromHeader_obj.clickBackFromHeader_Method();
            runscript.clickSearchIconFrmHeader_obj.clickSearchIconFrmHeader_Method();
            string Destdefaultselection = runscript.clickDestinationResortVilla_obj.DfltDestination_Method();
            string DefaultSelectedDate = runscript.clickCalenderIcon_obj.GetDefaultSelectedDate_Method();
            runscript.clickDestinationResortVilla_obj.clickDestinationResortVilla_Method();
            runscript.verifyCenternamesPopulated_obj.verifyCenternamesPopulated_Method();
            DateTime SelectableDate = new DateTime();
            string SelectedDate = string.Empty;
            List<string> centreNameList = new List<string>();
            string SelectedDuration = string.Empty;
            string sqlQuery = "SELECT centreName  from  dbo.TblCentre";
            dataReader = getData.getData(sqlQuery);
            while (dataReader.Read())
            {
                centreNameList.Add(dataReader["centreName"].ToString());
            }

            string SelectedCenter = runscript.selectingDestinationFrmSearch_obj.selectingDestinationFrmSearch_Method(centreNameList, Destdefaultselection);
            string centerCode = string.Empty;
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
                Boolean IsHoverNextAvaialable = runscript.clickNextArrowFrmCalender_obj.IsHoverNextAvail_Method();
                if (IsHoverNextAvaialable == true)
                {
                    runscript.clickNextArrowFrmCalender_obj.clickNextArrowFrmCalender_Method();
                }
                else
                {
                    runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method();
                }
                //runscript.clickNextArrowThrice_obj.clickNextArrowThrice_Method();
                dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
            }

            //runscript.clickPlusFrDuration_obj.clickPlusFrDuration_Method();
            //runscript.clickMinusFrDuration_obj.clickMinusFrDuration_Method();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    

            //*********Verifying Duration Plus and Minus Icons Disablity functionality*********//
            runscript.clickPlusFrDuration_obj.verifyPlusFrDurationDisabled_Method();
            runscript.clickMinusFrDuration_obj.verifyMinusFrDurationDisabled_Method();
            string selectedDuration = runscript.clickPlusFrDuration_obj.selectDuration_Method();
            
            //*********Verifying Adults, Child and Infants Plus and Minus Icons Disablity functionality*********//
            runscript.clickPlusIconforAdults_obj.verifyPlusFrAdultsDisabled_Method();
            runscript.clickPlusiconforChild_obj.verifyPlusFrChildDisabled_Method();
            runscript.clickPlusIconforInfants_obj.verifyPlusFrInfantsDisabled_Method();
            runscript.clickMinusfrAdults_obj.verifyMinusFrAdultsDisabled_Method();
            runscript.clickMinusFrChild_obj.verifyMinusFrChildDisabled_Method();
            runscript.clickMinusFrInfants_obj.verifyMinusFrInfantsDisabled_Method();

            //*********Verifying Minimum Occupacy check*********//
            int NumofChildSelected = 0;
            int NumofAdultsSelected = 0;
            int NumofInfantsSelected = 0;
            
            //List<object> returnvalues = runscript.clickPlusIconforAdults_obj.getDefaultAdultsSelected();
            NumofAdultsSelected = runscript.clickMinusfrAdults_obj.clickMinusfrsingleAdults_Method();
            NumofChildSelected = runscript.clickMinusFrChild_obj.clickMinusFrZeroChild_Method();
            NumofInfantsSelected = runscript.clickMinusFrInfants_obj.clickMinusFrZeroInfants_Method();
            runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
            runscript.verifyValErrwithSingleAdult_obj.verifyValErrwithSingleAdult_Method();

            //*********Verifying More Infants than Adults check*********//
            int DefaultAdults = runscript.clickPlusIconforAdults_obj.getDefaultAdultsSelected();
            NumofInfantsSelected = runscript.clickPlusIconforInfants_obj.clickPlusIconforMoreInfantsthanAdults_Method(DefaultAdults);
            runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
            runscript.verifyValErrMoreInfantsthanAdults_obj.verifyValErrMoreInfantsthanAdults_Method();

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
            runscript.clickPlusIconforInfants_obj.clickPlusIconforInfants_Method(NumofAdultsSelected);
            //runscript.clickMinusFrInfants_obj.clickMinusFrInfants_Method();
            List<string> ArrportNameList = new List<string>();
            sqlQuery = "select AirportName from dbo.Airports where GroupID !=0 or ParentID !=0 and CentreCode not like 'XX'";
            dataReader = getData.getData(sqlQuery);
            while (dataReader.Read())
            {
                ArrportNameList.Add(dataReader["AirportName"].ToString());
            }
            string DefaultAirport = runscript.clickDepAirportBox_obj.clickDepAirportBox_Method();
            string SelectedArrport = runscript.selectDepAirport_obj.selectDepAirport_Method(DefaultAirport,ArrportNameList);
            runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
            runscript.verifySRPagedisplay_obj.verifySRPagedisplay_Method();
            //runscript.verifyHoneTagDestinationResortVilla_obj.verifyHoneTagDestinationResortVilla_Method();
            //runscript.verifyDestResVillaListing_obj.verifyDestResVillaListing_Method();
            //runscript.enterDestnameSearchLayer_obj.enterDestnameSearchLayer_Method();
            //runscript.clickCentreName_obj.clickCentreName_Method();
        
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
