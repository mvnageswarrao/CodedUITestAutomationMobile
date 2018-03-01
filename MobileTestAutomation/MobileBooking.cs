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
    public class MobileBooking:logWriter
    {
        public MobileBooking()
        {
        }

        [TestMethod]
        public void MobileBookingFlowVerification()
        {
            #region Home & Search Page
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            WriteLogs("########## START ########## Search Results Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            InitiateMobileBooking runscript = new InitiateMobileBooking();
            string sqlQuery = string.Empty;

            Boolean IsZeroVillasinSRPage = false;
            string selectedDuration = string.Empty;
            DateTime SelectableDate = new DateTime();
            string TempSelectedDate = string.Empty;
            string SelectedCenter = string.Empty;
            string centerCode = string.Empty;
            int NumofAdultsSelected = 0;
            int NumofChildSelected = 0;
            int NumofInfantsSelected = 0;
            string SelectedArrport = string.Empty;
            runscript.OpenBrowser_Obj.OpenBrowser_Method();
            runscript.EnterURL_Obj.EnterURL_Method(strURL);
            Boolean isIncomBkgPopupOpened = runscript.verifyIncompleteBkgPopupDisplay_obj.verifyIncompleteBkgPopupDisplay_Method();
            if (isIncomBkgPopupOpened == true)
            {
                runscript.clickNOFrmIncomBkgPopup_obj.clickNOFrmIncomBkgPopup_Method();
            }

            do
            {
                if (IsZeroVillasinSRPage == true)
                {
                    runscript.clickSearchIconFrmHeader_obj.clickSearchIconFrmHeader_Method();
                }
                else
                {
                    runscript.clickOpenSearchPage_obj.clickOpenSearchPage_Method(strURL);
                }
                //Keyboard.SendKeys("{ControlKey down}{PageDown}");

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
                string EndDate = ConfigurationManager.AppSettings["SeasonEndDate"].ToString();

                //DateTime StartDate = System.DateTime.Today;
                string StartDate = System.DateTime.Now.ToString("MM/dd/yyyy");
                List<string> DatesList = new List<String>();
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='" + EndDate + "'";
                //sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='07-25-2020'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    DatesList.Add(dataReader["WeekStart"].ToString());
                }
                int NumofDatesAvaial = DatesList.Count;
                Random rnd1 = new Random();
                int SelectableDateindex = rnd1.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                Boolean iscalexists = runscript.verifyCalenderOpend_obj.verifyifcalalreadyopened_Method(DefaultSelectedDate, Destdefaultselection, SelectedCenter, DatesList);
                if (iscalexists == false)
                {
                    runscript.clickCalenderIcon_obj.clickCalenderIcon_Method();
                }
                string dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                #region To be used this block of CODE when next click issue is solved
                //Boolean slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                //while (slctnextfrmCal == true)
                //{
                //    //Boolean IsHoverNextAvaialable = runscript.clickNextArrowFrmCalender_obj.IsHoverNextAvail_Method();
                //    //if (IsHoverNextAvaialable == true)
                //    //{
                //    //    runscript.clickNextArrowFrmCalender_obj.clickNextArrowFrmCalender_Method();
                //    //}
                //    //else
                //    //{
                //    //runscript.dragCal_obj.dragCal_Method();
                //    //    runscript.selectDateFrmCalender_obj.DragingCalControl_Method();
                //    runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method();
                //    //}
                //    //runscript.clickNextArrowThrice_obj.clickNextArrowThrice_Method();
                //    dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                //    slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                //}
                #endregion
                
               //runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method();
               runscript.selectDateFrmCalender_obj.TempselectDateFrmCalender_Method();
               TempSelectedDate = runscript.clickCalenderIcon_obj.GetTempSelectedDate_Method();


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
                do
                {
                    SelectedArrport = runscript.selectDepAirport_obj.selectDepAirport_Method(DefaultAirport, ArrportNameList);
                } while (SelectedArrport == "");
                runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
                runscript.verifySRPagedisplay_obj.verifySRPagedisplay_Method();
                IsZeroVillasinSRPage = runscript.verifySRPagedisplay_obj.IsZEROVillasInSRPage_Method();
            } while (IsZeroVillasinSRPage == true);
            #endregion

            #region Search Results Page
            int selectedDurationForQuery = Convert.ToInt32(selectedDuration.Replace("nights", ""));
            //string SelectedDateForQuery = SelectableDate.ToString("dd/mm/yyyy");
            //int index = SelectedDateForQuery.IndexOf(' ');
            //SelectedDateForQuery = SelectedDateForQuery.Remove(index);
            string SelectedDateForQuery = TempSelectedDate;
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
            //**T0 Be Activated when Next Click Issue Solved***// runscript.verifySearchCriteriaDisplay_obj.verifySearchCriteriaDisplay_Method(VillaCount,NumofAdultsSelected, NumofChildSelected, NumofInfantsSelected, SelectableDate, selectedDuration, SelectedArrport);
            runscript.clickBookVillaAndFlightsBtn_obj.clickBookVillaAndFlightsBtn_Method(strURL);
            #endregion

            #region Flights Page
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            string FlightDetailsfromPage = runscript.verifyDftFlightDetails_obj.verifyDftFlightDetails_Method(strURL);
            runscript.verifyDftFExtras_obj.verifyDftFExtras_Method();
            runscript.VerifyATOL_obj.VerifyATOL_Method();
            runscript.verifyVillanFlightsTotal_obj.verifyVillanFlightsTotal_Method();
            runscript.verifyADWTextonFlightsPage_obj.verifyADWTextonFlightsPage_Method();
            runscript.clickViewSummary_obj.clickViewSummary_Method();
            runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
            runscript.clickHideSummary_obj.clickHideSummary_Method();
            runscript.clickEditFlightsBtn_obj.clickEditFlightsBtn_Method();
            runscript.verifyAmndFltsPageOpened_obj.verifyAmndFltsPageOpened_Method();
            runscript.clickChangeDepAirportBtn_obj.clickChangeDepAirportBtn_Method();
            runscript.selectChngDepAirport_obj.selectChngDepAirport_Method();
            runscript.selectChngArrAirport_obj.selectChngArrAirport_Method();
            runscript.clickConfirmBtn_obj.clickConfirmBtn_Method();
            runscript.selectFlightChckBox_obj.selectFlightChckBox_Method(strURL);
            runscript.clickSelectFlightBtn_obj.clickSelectFlightBtn_Method(strURL);
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            runscript.verifyDftFlightDetails_obj.verifyDftFlightDetails_Method(strURL);

            runscript.clickScrollArrow_obj.clickScrollArrow_Method();
            runscript.clickContinueBtn_obj.clickContinueBtn_Method(strURL);
            Boolean IsHoldItemsDisplayed = runscript.verifyHoldItemsPopupdisplay_obj.verifyHoldItemsPopupdisplay_Method();
            Boolean IscheckinPopDisplayed = runscript.IsCheckInBagspopShown_obj.IsCheckInBagspopShown_Method();

            if (IscheckinPopDisplayed == true)
            {
                runscript.clickYesfromCheckInPop_obj.clickYesfromCheckInPop_Method();
            }

            if (IsHoldItemsDisplayed == true)
            {
                runscript.clickYesFrmHoldPopup_obj.clickYesFrmHoldPopup_Method();
            }
            runscript.verifyGrpDtlsPgeOpened_obj.verifyGrpDtlsPgeOpened_Method();
            #endregion

            #region Group Details Page
            runscript.enterPaxDetails_obj.enterPaxDetails_Method();
            HtmlEdit LNameCtrl = runscript.enterPaxDetails_obj.LNameControl_Method();
            runscript.clickScrollArrowGD_obj.clickScrollArrowGD_Method();
            runscript.clickContinueBtnFrmGDPage_obj.clickContinueBtnFrmGDPage_Method(strURL, LNameCtrl);
            Boolean IsitDBLBooking = runscript.verifyDblBookingpopup_obj.verifyDblBookingpopup_Method();
            if(IsitDBLBooking==true)
            {
                runscript.clickNOFrmDblBkngPPup_obj.clickNOFrmDblBkngPPup_Method();
            }
            Boolean IsTrvINSPopupDisplayed = runscript.verifyTravelInsPopupDisplayed_obj.verifyTravelInsPopupDisplayed_Method();
            if (IsTrvINSPopupDisplayed == true)
            {
                runscript.clickIAgreeFrmTravINSPopup_obj.clickIAgreeFrmTravINSPopup_Method(strURL);
            }
            #endregion

            #region Extras Page
            runscript.verifyExtrasPageDisplayed_obj.verifyExtrasPageDisplayed_Method();
            runscript.clickContinueFrmExtrasPage_obj.clickContinueFrmExtrasPage_Method();
            #endregion 

            #region LeadPax Page
            runscript.verifyLeadPaxPageOpened_obj.verifyLeadPaxPageOpened_Method();
            runscript.EnterPostCode_obj.EnterPostCode_Method();
            runscript.clickLookupAddressBtn_obj.clickLookupAddressBtn_Method();
            runscript.enterPhoneData_obj.enterPhoneData_Method();
            runscript.clickContinueBtnFrmLeadPax_obj.clickContinueBtnFrmLeadPax_Method();
            runscript.verifyTermsnCondsPageOpened_obj.verifyTermsnCondsPageOpened_Method();
            runscript.clickIAgreeFrmTermsPage_obj.clickIAgreeFrmTermsPage_Method();
            Boolean IsTLSOpened = runscript.verifyTLSPopupShown_obj.verifyTLSPopupShown_Method();
            if (IsTLSOpened == true)
            {
                runscript.clickContinueFrmPopup_obj.clickContinueFrmPopup_Method();
                runscript.clickPayOnlineFrmTLS_obj.clickPayOnlineFrmTLS_Method();
            }
            #endregion

            #region Payment Page
            runscript.verifyPaymentPageOpened_obj.verifyPaymentPageOpened_Method();
            HtmlComboBox uICreditCardSelectedCaComboBox = runscript.selectCardType_obj.getCardType_Method();
            string cardTypes = ConfigurationManager.AppSettings["CardTypes"].ToString();
            string[] CardTypeArr = cardTypes.Split(',');
            int length = CardTypeArr.Length;
            Random rnd = new Random();
            int index = rnd.Next(0, length);
            string SelectableCard = CardTypeArr[index].ToString().Trim();
            string cardDetails = ConfigurationManager.AppSettings[SelectableCard].ToString();
            string[] cardDetailsArr = cardDetails.Split(',');
            for (int j = 1; j < uICreditCardSelectedCaComboBox.ItemCount; j++)
            {
                uICreditCardSelectedCaComboBox.SelectedIndex = j;
                if (uICreditCardSelectedCaComboBox.SelectedItem.StartsWith(cardDetailsArr[0]))
                {
                    break;
                }
            }
            //Mouse.MoveScrollWheel(uICreditCardSelectedCaComboBox, -25);
            Keyboard.SendKeys("{END}");
            runscript.enterCardNum_obj.enterCardNum_Method(cardDetailsArr[1]);
            runscript.selectExpiryYr_obj.selectExpiryYr_Method();
            runscript.selectExpiryMnth_obj.selectExpiryMnth_Method();
            runscript.enterCVV_obj.enterCVV_Method(cardDetailsArr[2]);
            runscript.clickPayBtn_obj.clickPayBtn_Method();
            Boolean IsErrShown = runscript.verifyErrShownonPayPage_obj.verifyErrShownonPayPage_Method();
            if (IsErrShown == true)
            {
                runscript.clickPayByPhoneBtn_obj.clickPayByPhoneBtn_Method();
            }
            else
            {

            }
            
            runscript.verifyThankUPageOpened_obj.verifyThankUPageOpened_Method();
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
