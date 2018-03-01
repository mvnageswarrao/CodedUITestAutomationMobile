using System;
using System.Collections;
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
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;

namespace MobileTestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class VO_MobileBooking:logWriter
    {
        public VO_MobileBooking()
        {
        }

        [TestMethod]
        public void MobileBooking_VO()
        {
            #region Home & Search Page

            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string DBSelectionMode = ConfigurationManager.AppSettings["DBSelectionMode"].ToString();
            WriteLogs("########## START ########## Booking : on " + strURL + " " + DateTime.Now.ToString() + "##########");
            string BookingType = "VO";
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            InitiateMobileBooking runscript = new InitiateMobileBooking();
            pdfCheck verifyPDF = new pdfCheck();
            string sqlQuery = string.Empty;
            string InitialCatalog = string.Empty;

            Boolean IsZeroVillasinSRPage = false;
            string selectedDuration = string.Empty;
            DateTime SelectableDate = new DateTime();
            string TempSelectedDate = string.Empty;
            string SelectedCenter = string.Empty;
            string centerCode = string.Empty;
            int NumofAdultsSelected = 0;
			int numOfPax = 0;
            string selectYear = string.Empty;
            List<string> villaExtras = new List<String>();
            int NumofChildSelected = 0;
            int NumofInfantsSelected = 0;
			 string AirportName = string.Empty;
            string selectDate = string.Empty;
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
//runscript.OpenBrowser_Obj.locate();
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
                    runscript.clickSearchIconFrmHeader_obj.clickSearchIconFrmHeader_Method(strURL);
                }
                else
                {
                    runscript.clickOpenSearchPage_obj.clickOpenSearchPage_Method(strURL);
                }
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
                Random rnd1 = new Random();
                int SelectableDateindex = rnd1.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                string ModSelectableDate = SelectableDate.ToString("MM/dd/yyyy");
                Boolean iscalexists = runscript.verifyCalenderOpend_obj.verifyifcalalreadyopened_Method(DefaultSelectedDate, Destdefaultselection, SelectedCenter, DatesList);
                if (iscalexists == false)
                {
                    runscript.clickCalenderIcon_obj.clickCalenderIcon_Method();
                }
                string dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                Tuple<int, bool, bool> slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                while (slctnextfrmCal.Item2 == true)
                {
                    runscript.clickNextArrowTwice_obj.clickNextArrowTwice_Method(slctnextfrmCal.Item1);
                    dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                    slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                }
                while (slctnextfrmCal.Item3 == true)
                {
                    runscript.clickPrevArrowFrmCalender_obj.clickPrevArrowFrmCalender_Method(slctnextfrmCal.Item1);
                    dfultslctdMonYear = runscript.verifyCalenderOpend_obj.verifyCalenderOpend_Method();
                    slctnextfrmCal = runscript.selectDateFrmCalender_obj.selectDateFrmCalender_Method(SelectableDate, dfultslctdMonYear);
                }
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
				numOfPax = NumofAdultsSelected + NumofChildSelected;
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
                WriteLogs("PASS : Selected Search Criteria (" + SelectedCenter + ", " + ModSelectableDate + ", " + selectedDuration + ", " + NumofAdultsSelected + " Adults, " + NumofChildSelected + " Child, " + NumofInfantsSelected + " Infants, " + SelectedArrport + " ) Successfully. : VERIFICATION");
                runscript.clickSearchButton_obj.clickSearchButton_Method(strURL);
                runscript.verifySRPagedisplay_obj.verifySRPagedisplay_Method();
                IsZeroVillasinSRPage = runscript.verifySRPagedisplay_obj.IsZEROVillasInSRPage_Method();
            } while (IsZeroVillasinSRPage == true);
            #endregion

            #region Search Results Page
            AirportName = runscript.verifySRCAirport_obj.verifySRCAirport_Method();
            int selectedDurationForQuery = Convert.ToInt32(selectedDuration.Replace("nights", ""));
            string SelectedDateForQuery = SelectableDate.ToString("MM/dd/yyyy");
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
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    VillaCount = Convert.ToInt32(dataReader[0].ToString());
                }
            }
            runscript.verifySearchCriteriaDisplay_obj.verifySearchCriteriaDisplay_Method(VillaCount, NumofAdultsSelected, NumofChildSelected, NumofInfantsSelected, SelectableDate, selectedDuration, SelectedArrport);
			string VillaName = runscript.verifyVillaName_obj.verifyVillaName_Method();
            runscript.clickBookVillaOnlyBtn_obj.clickBookVillaOnlyBtn_Method();
            #endregion

            #region Flights Page
            runscript.verifyFlightsPageOpened_obj.verifyFlightsPageOpened_Method(strURL);
            string BookingID = string.Empty;
            do
            {
                BookingID = runscript.verifyFlightsPageOpened_obj.getBookingID(strURL).Trim();
            } while (BookingID == "");
            string FlightDetailsfromPage = "";
            string ATOLTxtFrmFltsPage = "";
            WriteLogs("---------- START ---------- Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "----------");
            runscript.clickViewSummary_obj.clickViewSummary_Method();
            runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
            runscript.clickHideSummary_obj.clickHideSummary_Method();
            runscript.verifyADWTextonFlightsPage_obj.verifyADWTextonFlightsPage_Method();
            runscript.clickContinueBtn_obj.clickContinueBtn_Method(strURL);
            #endregion

            #region Group Details Page
            runscript.verifyGrpDtlsPgeOpened_obj.verifyGrpDtlsPgeOpened_Method();
            runscript.clickViewSummary_obj.clickViewSummary_Method();
            runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
            string TempFExtra = "";
            //runscript.verifyViewSummaryOpened_obj.verifyFltSectioninViewSummaryFrmGDPge_Method(TempFExtra);
            runscript.clickHideSummary_obj.clickHideSummary_Method();
            runscript.enterPaxDetails_obj.enterPaxDetails_Method();
            bool IsInsuranceSelected = runscript.selectInsurance_obj.selectInsurance_Method();
            bool IsAirportAssistanceSelected = runscript.selectAirportAssistance_obj.selectAirportAssistance_Method();
            bool IsWheelChairSelected = runscript.selectWheelChair_obj.selectWheelChair_Method();

            HtmlEdit LNameCtrl = runscript.enterPaxDetails_obj.LNameControl_Method();
            runscript.clickScrollArrowGD_obj.clickScrollArrowGD_Method();
            runscript.clickContinueBtnFrmGDPage_obj.clickContinueBtnFrmGDPage_Method(strURL, LNameCtrl);
            Boolean IsitDBLBooking = runscript.verifyDblBookingpopup_obj.verifyDblBookingpopup_Method();
            if (IsitDBLBooking == true)
            {
                runscript.clickNOFrmDblBkngPPup_obj.clickNOFrmDblBkngPPup_Method();
            }
            Boolean IsMobilityPopupOpened = runscript.clickYesBtnFrmMobilityPopup_obj.verifyMobilitypopupDisplay_Method();
            if (IsMobilityPopupOpened == true)
            {
                runscript.clickYesBtnFrmMobilityPopup_obj.clickYesBtnFrmMobilityPopup_Method();
            }
            Boolean IsTrvINSPopupDisplayed = runscript.verifyTravelInsPopupDisplayed_obj.verifyTravelInsPopupDisplayed_Method(IsInsuranceSelected);
            if (IsTrvINSPopupDisplayed == true)
            {
                runscript.clickIAgreeFrmTravINSPopup_obj.clickIAgreeFrmTravINSPopup_Method(strURL);
            }
            #endregion

            #region Extras Page
            string VExtrasDetailsFrmPge = string.Empty;
            string ADWDetailsFrmPge = string.Empty;
            runscript.verifyExtrasPageDisplayed_obj.verifyExtrasPageDisplayed_Method();
            //Getting Invoice Description of Villa Extras
            sqlQuery = "select invoicedesc from Booking.ExtraBooked where type = 'v' and LineID =(select id from Booking.VillaPack where BookID = '" + BookingID + "')";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                villaExtras.Add(dataReader["invoicedesc"].ToString());
            }   
            //Checking & Cliking on the Villa Extras.
            runscript.verifyVillaExtrasAvailable_obj.verifyVillaExtrasAvailable_Method(villaExtras);
            runscript.clickVillaExtrasAll_obj.clickVillaExtrasAll_Method(numOfPax);
            HtmlImage IconControl = runscript.verifyHelpIconVillaExtras_obj.ClickHelpIconcounts_Method();
            UITestControlCollection controls = IconControl.FindMatchingControls();

            foreach (HtmlImage TotalControls in controls)
            {
                runscript.verifyHelpIconVillaExtras_obj.ClickHelpIconVillaExtras_Method(TotalControls);
                runscript.verifyHelpIconVillaExtras_obj.verifyVillaExtrasHeaderText_Method();
                runscript.verifyHelpIconVillaExtras_obj.verifyVillaExtrasText_Method();
                runscript.verifyHelpIconVillaExtras_obj.ClickClosebuttonHelpIcon_Method();
            }   
            //Checking Car Hire Category
            String CarHireCategory = string.Empty;
            sqlQuery = "select Requirements from dbo.TblCarRequirements where ID = (select carreqid from TblVilla where FullName = '" + VillaName + " ' )";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                CarHireCategory = (dataReader["Requirements"].ToString());
            }
            runscript.verifyCarHireTextMessage_obj.verifyCarHireTextMessage_Method(VillaName, CarHireCategory);
            //Select Centre
            string CentreName = string.Empty;
            sqlQuery = "select Centre from TblVilla where FullName = '" + VillaName + "' ";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                CentreName = (dataReader["Centre"].ToString());
            }   
            //Select Airport
            string AirportCodeName = string.Empty;
            sqlQuery = "select AirportCode from dbo.Airports where AirportName = '%" + AirportName + "%' ";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                AirportCodeName = (dataReader["AirportCode"].ToString());
            }

            if (AirportCodeName != null)
            {
                List<string> ResortID = new List<string>();
                string sqlQuery0 = "select ResortID from TblVilla where FullName like '%" + VillaName + "%'";
                dataReader = getData.getData(sqlQuery0, InitialCatalog);
                while (dataReader.Read())
                {
                    ResortID.Add(dataReader["ResortID"].ToString());
                }
                int tblResortID = Convert.ToInt32(ResortID[0]);
                sqlQuery = "select ResortPreferredAirport from tblresort where ID =" + tblResortID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    AirportCodeName = (dataReader["ResortPreferredAirport"].ToString());
                }
            }
           
            string SelectYear = SelectableDate.ToString("yyyy");
            selectDate = SelectableDate.ToString("yyyy/MM/dd");

            //Select Transfer Description & Price
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            sqlQuery = "select TT.Description, TR.Price from dbo.TransferRates TR inner join  TransferTypes TT on TR.Type = TT.TransType and TR.Airportcode=TT.AirPortCode inner join tblvilla v on v.TransferCode = TR.TransCode  where TT.Available = '1' and v. FullName like '" + VillaName.Replace("'", "''") + "' and TR. AirportCode = '" + AirportCodeName + "'  and '" + selectDate + "' between TR.StartDate and TR.EndDate";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                dictionary.Add(dataReader[0].ToString(), dataReader[1].ToString());
            }
            //System.Threading.Thread.Sleep(10000);
            runscript.verifyCarsCategory_obj.verifyCarsCategory_Method(CentreName, AirportName, SelectYear, selectDate, InitialCatalog);
            runscript.clickAddCarHireButton_obj.clickAddCarHireButton_Method();
            string selectedCar = runscript.verifyCarHireCategory_obj.verifyCarHireCategory_Method(CentreName, AirportName, SelectYear, selectDate, InitialCatalog);
            runscript.verifyCarFeatures_obj.verifyCarFeatures_Method();
            runscript.verifyCarConfirm_obj.verifyCarConfirm_Method(NumofAdultsSelected);
            string CarHireDetailsFrmPge = runscript.verifyCarSelection_obj.verifyCarSelection_Method(selectedCar);
            string TransferDetailsFrmPge = runscript.verifyTransferSection_obj.verifyTransferSection_Method(dictionary);

            //runscript.verifyExtrasPageDisplayed_obj.verifyExtrasPageDisplayed_Method();
            //Need to get below details once those are selected on Extras page and pass those to below method.
            //string VExtrasDetailsFrmPge = string.Empty;
            //string CarHireDetailsFrmPge = string.Empty;
            //string TransferDetailsFrmPge = string.Empty;
            //string ADWDetailsFrmPge = string.Empty;

           // runscript.clickViewSummary_obj.clickViewSummary_Method();
            //runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
            //runscript.clickHideSummary_obj.clickHideSummary_Method();
           // runscript.clickScrollFrmExtras_obj.clickScrollFrmExtras_Method();
            runscript.clickContinueFrmExtrasPage_obj.clickContinueFrmExtrasPage_Method();
            bool IsPageExists = runscript.verifyYourFltPgeShown_obj.verifyYourFltPgeShown_Method();
            if(IsPageExists == true)
            {
               runscript.clickLaterBtn_obj.clickLaterBtn_Method();
            }
            #endregion 

            #region LeadPax Page
            runscript.verifyLeadPaxPageOpened_obj.verifyLeadPaxPageOpened_Method();
            runscript.clickViewSummary_obj.clickViewSummary_Method();
            runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
            runscript.verifyViewSummaryOpened_obj.verifyViewSummaryFrmLeadPaxPge_Method(VExtrasDetailsFrmPge, CarHireDetailsFrmPge, TransferDetailsFrmPge, ADWDetailsFrmPge);
            runscript.clickHideSummary_obj.clickHideSummary_Method();
            runscript.EnterPostCode_obj.EnterPostCode_Method();
            runscript.clickLookupAddressBtn_obj.clickLookupAddressBtn_Method();
            bool isPostCodeErrPopupShown = runscript.VerifyPostCodeErrPopup_Obj.VerifyPostCodeErrPopup_Method();
            if (isPostCodeErrPopupShown == true)
            {
                runscript.clickOKFrmPostCodeErrPopup_Obj.clickOKFrmPostCodeErrPopup_Method();
                //runscript.enterAddressManually_Obj.enterAddressManually_Method();
                runscript.enterAddressManually_Obj.enterStreet_Method();
                runscript.enterAddressManually_Obj.enterTownCity_Method();
                runscript.enterAddressManually_Obj.enterPostCodeManually_Method();
                runscript.enterPhoneData_obj.enterPhoneDataWhilePCErr_Method();
            }
            else
            {
                runscript.enterPhoneData_obj.enterPhoneData_Method();
            }
            string LeadPaxDetailsFrmPge = string.Empty;
            string OtherPaxDetailsFrmPge = string.Empty;
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
            delayExecution(strURL);
            Boolean isPayOnlinepageOpened = runscript.verifyPaymentPageOpened_obj.verifyPaymentPageOpened_Method();
            if (isPayOnlinepageOpened == true)
            {
                runscript.clickViewSummary_obj.clickViewSummary_Method();
                runscript.verifyViewSummaryOpened_obj.verifyViewSummaryOpened_Method();
                Tuple<string, string> PaxInfo = runscript.verifyViewSummaryOpened_obj.verifyViewSummaryFrmPaymentPge_Method(LeadPaxDetailsFrmPge, OtherPaxDetailsFrmPge);
                LeadPaxDetailsFrmPge = PaxInfo.Item1;
                OtherPaxDetailsFrmPge = PaxInfo.Item2;
                runscript.clickHideSummary_obj.clickHideSummary_Method();
                string cardToBeUsed = ConfigurationManager.AppSettings["CardsToBeUsed"].ToString();

                string cardTypes = string.Empty;
                if (cardToBeUsed == "New")
                {
                    cardTypes = ConfigurationManager.AppSettings["CardTypes_New"].ToString();
                }
                else
                {
                    cardTypes = ConfigurationManager.AppSettings["CardTypes"].ToString();
                }
                HtmlComboBox uICreditCardSelectedCaComboBox = runscript.selectCardType_obj.getCardType_Method();

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
                    //if (uICreditCardSelectedCaComboBox.SelectedItem.StartsWith(cardDetailsArr[0]))
                        if (uICreditCardSelectedCaComboBox.SelectedItem.StartsWith("Visa"))
                        {
                            break;
                    }
                }
                string selectedCard = uICreditCardSelectedCaComboBox.SelectedItem.Trim();
                string[] arrselectedCard = selectedCard.Split('(');
                WriteLogs("PASS : \"" + arrselectedCard[0].Trim() + "\" is Selected as Card Type. : VERIFICATION");
                Keyboard.SendKeys("{PGDN}");
                runscript.enterCardNum_obj.enterCardNum_Method(cardDetailsArr[1]);
                if (arrselectedCard[0].Trim().Contains("Maestro"))
                {
                    runscript.selectStartYr_obj.selectStartYr_Method();
                    runscript.selectStartMnth_obj.selectStartMnth_Method();
                }
                runscript.selectExpiryYr_obj.selectExpiryYr_Method();
                runscript.selectExpiryMnth_obj.selectExpiryMnth_Method();
                HtmlEdit uICreditCardSecurityCoEdit = runscript.enterCVV_obj.enterCVV_Method(cardDetailsArr[2]);
                HtmlInputButton PayButton = runscript.clickPayBtn_obj.clickPayBtn_Method(uICreditCardSecurityCoEdit);
                Boolean IsErrShown = runscript.verifyErrShownonPayPage_obj.verifyErrShownonPayPage_Method();
                if (IsErrShown == true)
                {
                    runscript.clickScrollPay_obj.clickScrollPay_Method();
                    runscript.clickPayByPhoneBtn_obj.clickPayByPhoneBtn_Method(PayButton);
                }
                else
                {
                    if (!arrselectedCard[0].Trim().Equals("Amex"))
                    {

                        runscript.enter3DPwd_obj.enter3DPwd_Method(cardDetailsArr[3]);

                        if (arrselectedCard[0].Trim() == "Visa")
                        {
                            runscript.clickSubmitBtnVISAFrm3D_obj.clickSubmitBtnVISAFrm3D_Method();
                        }
                        else
                        {
                            runscript.clickSubmitBtnFrm3D_obj.clickSubmitBtnFrm3D_Method();
                        }
                        IsErrShown = runscript.verifyErrShownonPayPage_obj.verifyErrShownonPayPage_Method();
                        if (IsErrShown == true)
                        {
                            runscript.clickScrollPay_obj.clickScrollPay_Method();
                            runscript.clickPayByPhoneBtn_obj.clickPayByPhoneBtn_Method(PayButton);
                        }
                    }
                }
            }
            delayExecution(strURL);
            #endregion

            #region Thank You Page
            runscript.verifyThankUPageOpened_obj.verifyThankUPageOpened_Method();
            runscript.verifyThankUPageOpened_obj.VerifyAllSectionsInThankYouPage_Method(BookingType, FlightDetailsfromPage, ATOLTxtFrmFltsPage, TempFExtra, VExtrasDetailsFrmPge, CarHireDetailsFrmPge, TransferDetailsFrmPge, ADWDetailsFrmPge, LeadPaxDetailsFrmPge, OtherPaxDetailsFrmPge);
            #endregion

            #region Verifying DB details After Booking - With Email Queuing OFF
            //*****Verification of DB Updates after completion of Booking*****//
            string EMAILQueuing = ConfigurationManager.AppSettings["EMAILQueuing"].ToString();
            string Ref = string.Empty;
            double CCRatePhone = 0;
            double CCRateWeb = 0;
            double ApplCCRate = 0;
            string BKBookingStage = string.Empty;
            string BKStatus = string.Empty;
            string WSStatus = string.Empty;
            string WsSender = string.Empty;
            string MailStatus = string.Empty;
            string ATOLStatus = string.Empty;
            string BookingConVersion = string.Empty;
            string UsefulInfoVersion = string.Empty;
            string HealthSafetyVersion = string.Empty;
            string WebTOUVersion = string.Empty;
            string BookingTerms = string.Empty;
            string WheelChairAsst = string.Empty;
            string InsDocsbyPost = string.Empty;
            string AlertMsg = string.Empty;
            if (EMAILQueuing == "OFF")
            {
                int Bookid = 0;
                string LineType = string.Empty;
                string VPStatus = string.Empty;
                string VPBookingStage = string.Empty;
                sqlQuery = "SELECT Bookid,LineType,Status,BookingStage FROM booking.villapack  WHERE BookId= " + BookingID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    Bookid = Convert.ToInt32(dataReader[0].ToString());
                    LineType = dataReader[1].ToString();
                    VPStatus = dataReader[2].ToString();
                    VPBookingStage = dataReader[3].ToString();
                }
                sqlQuery = "SELECT Ref,CCRatePhone,CCRateWeb,ApplCCRate,BookingStage,Status,WSStatus,WsSender,MailStatus,ATOLStatus,BookingConVersion,UsefulInfoVersion,HealthSafetyVersion,WebTOUVersion,BookingTerms,WheelChairAsst,AlertMessage FROM Booking.Bookings WHERE BookId=" + BookingID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    Ref = dataReader[0].ToString();
                    CCRatePhone = Convert.ToDouble(dataReader[1].ToString());
                    CCRateWeb = Convert.ToDouble(dataReader[2].ToString());
                    ApplCCRate = Convert.ToDouble(dataReader[3].ToString());
                    BKBookingStage = dataReader[4].ToString();
                    BKStatus = dataReader[5].ToString();
                    WSStatus = dataReader[6].ToString();
                    WsSender = dataReader[7].ToString();
                    MailStatus = dataReader[8].ToString();
                    ATOLStatus = dataReader[9].ToString();
                    BookingConVersion = dataReader[10].ToString();
                    UsefulInfoVersion = dataReader[11].ToString();
                    HealthSafetyVersion = dataReader[12].ToString();
                    WebTOUVersion = dataReader[13].ToString();
                    BookingTerms = dataReader[14].ToString();
                    WheelChairAsst = dataReader[15].ToString();
                    AlertMsg = dataReader[16].ToString();
                    //InsDocsbyPost = Convert.ToInt32(dataReader[16].ToString());
                }
                Hashtable hashtable = new Hashtable();
                hashtable.Add("LineType", LineType);
                hashtable.Add("VPStatus", VPStatus);
                hashtable.Add("VPBookingStage", VPBookingStage);
                hashtable.Add("ApplCCRate", ApplCCRate);
                hashtable.Add("BKBookingStage", BKBookingStage);
                hashtable.Add("BKStatus", BKStatus);
                hashtable.Add("WSStatus", WSStatus);
                hashtable.Add("WsSender", WsSender);
                hashtable.Add("MailStatus", MailStatus);
                hashtable.Add("ATOLStatus", ATOLStatus);
                hashtable.Add("BookingTerms", BookingTerms);
                hashtable.Add("WheelChairAsst", WheelChairAsst);
                hashtable.Add("AlertMessage", AlertMsg);
                double ExpectedApplCCRate = 0;

                if (isPayOnlinepageOpened == true && IsWheelChairSelected == false && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }
                else
                {
                    ExpectedApplCCRate = 0.020;
                }
                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-On");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", "PDF Mail");
                Exphashtable.Add("ATOLStatus", "Yes");
                Exphashtable.Add("BookingTerms", "True");
                Exphashtable.Add("WheelChairAsst", "False");
                Exphashtable.Add("AlertMessage", "");
                foreach (string key in hashtable.Keys)
                {
                    if (hashtable[key].ToString().Trim().Equals(Exphashtable[key].ToString().Trim()))
                    {
                        WriteLogs("PASS : " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else if (VPBookingStage == "Costing" && BKBookingStage == "Costing")
                    {
                        WriteLogs("INFO : Pay Online Was not Avaialable Booking Done using Phone button, so " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else
                    {
                        WriteLogs("FAIL : " + key + " is Not as Expected, it should be " + Exphashtable[key].ToString());
                    }
                }
            }
            #endregion

            #region DBVerification After Booking - With Email Queuing ON
            else
            {
                //*****Verification of DB Updates after completion of Booking*****//
                int Bookid = 0;
                string LineType = string.Empty;
                string VPStatus = string.Empty;
                string VPBookingStage = string.Empty;
                sqlQuery = "SELECT Bookid,LineType,Status,BookingStage FROM booking.villapack  WHERE BookId= " + BookingID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    Bookid = Convert.ToInt32(dataReader[0].ToString());
                    LineType = dataReader[1].ToString();
                    VPStatus = dataReader[2].ToString();
                    VPBookingStage = dataReader[3].ToString();
                }
                sqlQuery = "SELECT Ref,CCRatePhone,CCRateWeb,ApplCCRate,BookingStage,Status,WSStatus,WsSender,MailStatus,ATOLStatus,BookingConVersion,UsefulInfoVersion,HealthSafetyVersion,WebTOUVersion,BookingTerms,WheelChairAsst,AlertMessage FROM Booking.Bookings WHERE BookId=" + BookingID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    Ref = dataReader[0].ToString().Trim();
                    CCRatePhone = Convert.ToDouble(dataReader[1].ToString());
                    CCRateWeb = Convert.ToDouble(dataReader[2].ToString());
                    ApplCCRate = Convert.ToDouble(dataReader[3].ToString());
                    BKBookingStage = dataReader[4].ToString();
                    BKStatus = dataReader[5].ToString();
                    WSStatus = dataReader[6].ToString();
                    WsSender = dataReader[7].ToString();
                    MailStatus = dataReader[8].ToString();
                    ATOLStatus = dataReader[9].ToString();
                    BookingConVersion = dataReader[10].ToString();
                    UsefulInfoVersion = dataReader[11].ToString();
                    HealthSafetyVersion = dataReader[12].ToString();
                    WebTOUVersion = dataReader[13].ToString();
                    BookingTerms = dataReader[14].ToString();
                    WheelChairAsst = dataReader[15].ToString();
                    AlertMsg = dataReader[16].ToString();
                }
                Boolean MSMQMailStatus = false;
                Boolean BookingPDF = false;
                string ATOLPDF = string.Empty;
                Boolean WheelChairPDF = false;
                Boolean VPInsurance = false;
                Boolean BOAlert = false;
                Boolean InfoMailsentToCust = false;
                Boolean IsDataSentBacktoMSMQ = false;
                sqlQuery = "SELECT MailStatus,BookingPDF,ATOLPDF,WheelChairPDF,VPInsurance,BOAlert,InfoMailsentToCust,IsDataSentBacktoMSMQ from msmqemailrecords where Bookingid=" + BookingID;
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    MSMQMailStatus = Convert.ToBoolean(dataReader[0]);
                    BookingPDF = Convert.ToBoolean(dataReader[1].ToString());
                    ATOLPDF = dataReader[2].ToString();
                    WheelChairPDF = Convert.ToBoolean(dataReader[3].ToString());
                    VPInsurance = Convert.ToBoolean(dataReader[4].ToString());
                    BOAlert = Convert.ToBoolean(dataReader[5].ToString());
                    InfoMailsentToCust = Convert.ToBoolean(dataReader[6].ToString());
                    IsDataSentBacktoMSMQ = Convert.ToBoolean(dataReader[7].ToString());
                }
                Hashtable hashtable = new Hashtable();
                hashtable.Add("LineType", LineType);
                hashtable.Add("VPStatus", VPStatus);
                hashtable.Add("VPBookingStage", VPBookingStage);
                hashtable.Add("ApplCCRate", ApplCCRate);
                hashtable.Add("BKBookingStage", BKBookingStage);
                hashtable.Add("BKStatus", BKStatus);
                hashtable.Add("WSStatus", WSStatus);
                hashtable.Add("WsSender", WsSender);
                hashtable.Add("MailStatus", MailStatus);
                hashtable.Add("ATOLStatus", ATOLStatus);
                hashtable.Add("BookingTerms", BookingTerms);
                hashtable.Add("WheelChairAsst", WheelChairAsst);
                hashtable.Add("MSMQMailStatus", MSMQMailStatus);
                hashtable.Add("BookingPDF", BookingPDF);
                hashtable.Add("ATOLPDF", ATOLPDF);
                hashtable.Add("WheelChairPDF", WheelChairPDF);
                hashtable.Add("VPInsurance", VPInsurance);
                hashtable.Add("BOAlert", BOAlert);
                hashtable.Add("InfoMailsentToCust", InfoMailsentToCust);
                hashtable.Add("IsDataSentBacktoMSMQ", IsDataSentBacktoMSMQ);
                hashtable.Add("AlertMessage", AlertMsg);
                double ExpectedApplCCRate = 0;
                if (isPayOnlinepageOpened == true && IsWheelChairSelected == false && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }
                else
                {
                    ExpectedApplCCRate = 0.020;
                }
                string ExpMailStatus = string.Empty;
                string ExpATOLStatus = string.Empty;
                ExpMailStatus = "Queued";
                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-On");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", ExpMailStatus);
                Exphashtable.Add("ATOLStatus", "Queued");
                Exphashtable.Add("BookingTerms", "True");
                Exphashtable.Add("WheelChairAsst", "False");
                Exphashtable.Add("AlertMessage", "");
                Exphashtable.Add("MSMQMailStatus", "True");
                Exphashtable.Add("BookingPDF", "True");
                Exphashtable.Add("ATOLPDF", "Yes");
                Exphashtable.Add("WheelChairPDF", "False");
                Exphashtable.Add("VPInsurance", "False");
                Exphashtable.Add("BOAlert", "False");
                Exphashtable.Add("InfoMailsentToCust", "False");
                Exphashtable.Add("IsDataSentBacktoMSMQ", "False");
                foreach (string key in hashtable.Keys)
                {
                    if (hashtable[key].ToString().Trim().Equals(Exphashtable[key].ToString().Trim()))
                    {
                        WriteLogs("PASS : " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else if (VPBookingStage == "Costing" && BKBookingStage == "Costing")
                    {
                        WriteLogs("INFO : Pay Online Was not Avaialable Booking Done using Phone button, so " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else
                    {
                        WriteLogs("FAIL : " + key + " is Not as Expected, it should be " + Exphashtable[key].ToString());
                    }
                }
            }
            #endregion

            #region PDF Verification
            //verifyPDF.WriteExpBDetailsFrmPDFtoTxt(Ref.Trim(), LeadFullName, flttypeSupptxt, PDFretdate, PDFdepdate, PDFDeport, PDFDeptime, PDFArrport, PDFArrtime, TotalPrice, Deposit);

            WriteLogs("########## END ########## Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "##########" + '\n' + '\n' + '\n');
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
