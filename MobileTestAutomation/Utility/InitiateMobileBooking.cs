using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;
using MobileTestAutomation.UIMap.Generic.EnterURL_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickOpenSearchPage_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickSearchIconFrmHeader_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickDestinationResortVilla_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyHoneTagDestinationResortVilla_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyDestResVillaListing_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.enterDestnameSearchLayer_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickCentreName_MapClasses;
using MobileTestAutomation.UIMap.Header.clickHeaderLogo_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickBackFromHeader_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyCenternamesPopulated_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.selectingDestinationFrmSearch_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickNextArrowFrmCalender_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickPrevArrowFrmCalender_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickCalenderIcon_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyCalenderOpend_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.selectDateFrmCalender_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickPlusFrDuration_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickMinusFrDuration_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickPlusIconforAdults_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickPlusiconforChild_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickPlusIconforInfants_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickDepAirportBox_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.selectDepAirport_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickSearchButton_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifySRPagedisplay_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickMinusfrAdults_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickMinusFrChild_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickMinusFrInfants_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyValErrwithSingleAdult_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.verifyValErrMoreInfantsthanAdults_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickNextArrowTwice_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.clickNextArrowThrice_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.dragCal_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifySearchCriteriaDisplay_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickVillaNameLink_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifyProductPagedisplay_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickMoreInfoBtn_MapClasses;
using MobileTestAutomation.UIMap.SearchPage.SearchHeader.clickBackSearchLayer_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickBackFrmPrdctPage_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickShowMoreResultsBtn_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickBookVillaAndFlightsBtn_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifySRCAirport_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifyFlightsPageOpened_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickBookVillaOnlyBtn_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickBackFrmFlightsPage_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickOnVillaImage_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickUsefulLinksHeading_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickAllusefulLinks_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickSortBy_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.selectSortOption_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickApplySort_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.getVilladetailsBlock_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickFilterBy_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickApplyFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickClearFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickPlusForFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickFilterName_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifyVillaName_MapClasses;
using MobileTestAutomation.UIMap.HomePage.verifyIncompleteBkgPopupDisplay_MapClasses;
using MobileTestAutomation.UIMap.HomePage.clickNOFrmIncomBkgPopup_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickContinueBtn_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyDftFlightDetails_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyDftFExtras_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyFExtrasDetails_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickPlusForFExtras_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickMinusForFExtras_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyHoldItemsPopupdisplay_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickYesFrmHoldPopup_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyGrpDtlsPgeOpened_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.IsCheckInBagspopShown_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickYesfromCheckInPop_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.VerifyATOL_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyVillanFlightsTotal_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyADWTextonFlightsPage_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickViewSummary_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyViewSummaryOpened_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickHideSummary_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickEditFlightsBtn_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyAmndFltsPageOpened_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickChangeDepAirportBtn_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickConfirmBtn_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.clickSelectFlightBtn_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.selectChngDepAirport_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.selectChngArrAirport_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.selectFlightChckBox_MapClasses;
using MobileTestAutomation.UIMap.FlightsPage.verifyTotalPriceOnFlightsPage_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickScrollArrow_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickScrollArrowGD_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.enterPaxDetails_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickContinueBtnFrmGDPage_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.verifyDblBookingpopup_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickNOFrmDblBkngPPup_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.verifyTravelInsPopupDisplayed_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickIAgreeFrmTravINSPopup_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.verifyExtrasPageDisplayed_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.selectInsurance_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.selectAirportAssistance_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.selectWheelChair_MapClasses;
using MobileTestAutomation.UIMap.GroupDetailsPage.clickYesBtnFrmMobilityPopup_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickScrollFrmExtras_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickContinueFrmExtrasPage_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyLeadPaxPageOpened_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyYourFltPgeShown_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickLaterBtn_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyVillaExtrasAvailable_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyVillaExtrasMinus_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickVillaExtrasAdded_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickVillaExtrasAll_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyHelpIconVillaExtras_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarHireTextMessage_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarsCategory_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickAddCarHireButton_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.clickRemoveButton_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarHireCategory_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarFeatures_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarConfirm_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyCarSelection_MapClasses;
using MobileTestAutomation.UIMap.ExtrasPage.verifyTransferSection_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.EnterPostCode_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickLookupAddressBtn_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.VerifyPostCodeErrPopup_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickOKFrmPostCodeErrPopup_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.enterAddressManually_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.enterPhoneData_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickContinueBtnFrmLeadPax_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.verifyTermsnCondsPageOpened_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickIAgreeFrmTermsPage_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.verifyTLSPopupShown_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickContinueFrmPopup_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickPayOnlineFrmTLS_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.clickPayByPhoneFrmTLS_MapClasses;
using MobileTestAutomation.UIMap.LeadPaxPage.verifyPaymentPageOpened_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.selectCardType_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.enterCardNum_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.selectStartMnth_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.selectStartYr_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.selectExpiryMnth_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.selectExpiryYr_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.enterCVV_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickPayBtn_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.verifyErrShownonPayPage_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickScrollPay_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickPayByPhoneBtn_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.enter3DPwd_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickSubmitBtnFrm3D_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickSubmitBtnVISAFrm3D_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.clickCancellinkFrm3D_MapClasses;
using MobileTestAutomation.UIMap.PaymentPage.verifyThankUPageOpened_MapClasses;


namespace MobileTestAutomation.Utility
{
    public class InitiateMobileBooking
    {
        private openBrowser_Map OpenBrowser = null;
        private EnterURL_Map EnterURL = null;
        private clickOpenSearchPage_Map clickOpenSearchPage = null;
        private clickSearchIconFrmHeader_Map clickSearchIconFrmHeader = null;
        private clickDestinationResortVilla_Map clickDestinationResortVilla = null;
        private verifyHoneTagDestinationResortVilla_Map verifyHoneTagDestinationResortVilla = null;
        private verifyDestResVillaListing_Map verifyDestResVillaListing = null;
        private enterDestnameSearchLayer_Map enterDestnameSearchLayer = null;
        private clickCentreName_Map clickCentreName = null;
        private clickHeaderLogo_Map clickHeaderLogo = null;
        private clickBackFromHeader_Map clickBackFromHeader = null;
        private verifyCenternamesPopulated_Map verifyCenternamesPopulated = null;
        private selectingDestinationFrmSearch_Map selectingDestinationFrmSearch = null;
        private clickNextArrowFrmCalender_Map clickNextArrowFrmCalender = null;
        private clickPrevArrowFrmCalender_Map clickPrevArrowFrmCalender = null;
        private clickCalenderIcon_Map clickCalenderIcon = null;
        private selectDateFrmCalender_Map selectDateFrmCalender = null;
        private verifyCalenderOpend_Map verifyCalenderOpend = null;
        private clickPlusFrDuration_Map clickPlusFrDuration = null;
        private clickMinusFrDuration_Map clickMinusFrDuration = null;
        private clickPlusIconforAdults_Map clickPlusIconforAdults = null;
        private clickPlusiconforChild_Map clickPlusiconforChild = null;
        private clickPlusIconforInfants_Map clickPlusIconforInfants = null;
        private clickDepAirportBox_Map clickDepAirportBox = null;
        private selectDepAirport_Map selectDepAirport = null;
        private clickSearchButton_Map clickSearchButton = null;
        private verifySRPagedisplay_Map verifySRPagedisplay = null;
        private clickMinusfrAdults_Map clickMinusfrAdults = null;
        private clickMinusFrChild_Map clickMinusFrChild = null;
        private clickMinusFrInfants_Map clickMinusFrInfants = null;
        private verifyValErrwithSingleAdult_Map verifyValErrwithSingleAdult = null;
        private verifyValErrMoreInfantsthanAdults_Map verifyValErrMoreInfantsthanAdults = null;
        private clickNextArrowTwice_Map clickNextArrowTwice = null;
        private clickNextArrowThrice_Map clickNextArrowThrice = null;
        private dragCal_Map dragCal = null;
        private verifySearchCriteriaDisplay_Map verifySearchCriteriaDisplay = null;
        private clickVillaNameLink_Map clickVillaNameLink = null;
        private verifyProductPagedisplay_Map verifyProductPagedisplay = null;
        private clickMoreInfoBtn_Map clickMoreInfoBtn = null;
        private clickBackSearchLayer_Map clickBackSearchLayer = null;
        private clickBackFrmPrdctPage_Map clickBackFrmPrdctPage = null;
        private clickShowMoreResultsBtn_Map clickShowMoreResultsBtn = null;
		private verifySRCAirport_Map verifySRCAirport = null;
        private clickBookVillaAndFlightsBtn_Map clickBookVillaAndFlightsBtn = null;
        private verifyFlightsPageOpened_Map verifyFlightsPageOpened = null;
        private clickBookVillaOnlyBtn_Map clickBookVillaOnlyBtn = null;
        private clickBackFrmFlightsPage_Map clickBackFrmFlightsPage = null;
        private clickOnVillaImage_Map clickOnVillaImage = null;
        private clickUsefulLinksHeading_Map clickUsefulLinksHeading = null;
        private clickAllusefulLinks_Map clickAllusefulLinks = null;
        private clickSortBy_Map clickSortBy = null;
        private selectSortOption_Map selectSortOption = null;
        private clickApplySort_Map clickApplySort = null;
        private getVilladetailsBlock_Map getVilladetailsBlock = null;
        private clickFilterBy_Map clickFilterBy = null;
        private clickApplyFilter_Map clickApplyFilter = null;
        private clickClearFilter_Map clickClearFilter = null;
		private verifyVillaName_Map verifyVillaName = null;
        private clickPlusForFilter_Map clickPlusForFilter = null;
        private clickFilterName_Map clickFilterName = null;
        private verifyIncompleteBkgPopupDisplay_Map verifyIncompleteBkgPopupDisplay = null;
        private clickNOFrmIncomBkgPopup_Map clickNOFrmIncomBkgPopup = null;
        private verifyDftFlightDetails_Map verifyDftFlightDetails = null;
        private verifyDftFExtras_Map verifyDftFExtras = null;
        private verifyFExtrasDetails_Map verifyFExtrasDetails = null;
        private clickPlusForFExtras_Map clickPlusForFExtras = null;
        private clickMinusForFExtras_Map clickMinusForFExtras = null;
        private VerifyATOL_Map VerifyATOL = null;
        private verifyVillanFlightsTotal_Map verifyVillanFlightsTotal = null;
        private verifyADWTextonFlightsPage_Map verifyADWTextonFlightsPage = null;
        private clickViewSummary_Map clickViewSummary = null;
        private verifyViewSummaryOpened_Map verifyViewSummaryOpened = null;
        private clickHideSummary_Map clickHideSummary = null;
        private clickEditFlightsBtn_Map clickEditFlightsBtn = null;
        private verifyAmndFltsPageOpened_Map verifyAmndFltsPageOpened = null;
        private clickChangeDepAirportBtn_Map clickChangeDepAirportBtn = null;
        private clickConfirmBtn_Map clickConfirmBtn = null;
        private clickSelectFlightBtn_Map clickSelectFlightBtn = null;
        private selectChngArrAirport_Map selectChngArrAirport = null;
        private selectChngDepAirport_Map selectChngDepAirport = null;
        private selectFlightChckBox_Map selectFlightChckBox = null;
        private verifyTotalPriceOnFlightsPage_Map verifyTotalPriceOnFlightsPage = null;
        private clickContinueBtn_Map clickContinueBtn = null;
        private verifyHoldItemsPopupdisplay_Map verifyHoldItemsPopupdisplay = null;
        private IsCheckInBagspopShown_Map IsCheckInBagspopShown = null;
        private clickYesfromCheckInPop_Map clickYesfromCheckInPop = null;
        private clickYesFrmHoldPopup_Map clickYesFrmHoldPopup = null;
        private verifyGrpDtlsPgeOpened_Map verifyGrpDtlsPgeOpened = null;
        private enterPaxDetails_Map enterPaxDetails = null;
        private clickContinueBtnFrmGDPage_Map clickContinueBtnFrmGDPage = null;
        private verifyDblBookingpopup_Map verifyDblBookingpopup = null;
        private clickNOFrmDblBkngPPup_Map clickNOFrmDblBkngPPup = null;
        private verifyTravelInsPopupDisplayed_Map verifyTravelInsPopupDisplayed = null;
        private clickIAgreeFrmTravINSPopup_Map clickIAgreeFrmTravINSPopup = null;
        private verifyExtrasPageDisplayed_Map verifyExtrasPageDisplayed = null;
        private clickScrollFrmExtras_Map clickScrollFrmExtras = null;
        private clickContinueFrmExtrasPage_Map clickContinueFrmExtrasPage = null;
        private verifyYourFltPgeShown_Map verifyYourFltPgeShown = null;
        private clickLaterBtn_Map clickLaterBtn = null;
        private clickYesBtnFrmMobilityPopup_Map clickYesBtnFrmMobilityPopup = null;
        private verifyLeadPaxPageOpened_Map verifyLeadPaxPageOpened = null;
        private clickScrollArrow_Map clickScrollArrow = null;
        private clickScrollArrowGD_Map clickScrollArrowGD = null;
		private verifyVillaExtrasMinus_Map verifyVillaExtrasMinus = null;
        private clickVillaExtrasAdded_Map clickVillaExtrasAdded = null;
        private clickVillaExtrasAll_Map clickVillaExtrasAll = null;
        private verifyHelpIconVillaExtras_Map verifyHelpIconVillaExtras = null;
        private verifyCarHireTextMessage_Map verifyCarHireTextMessage = null;
        private verifyCarsCategory_Map verifyCarsCategory = null;
        private clickAddCarHireButton_Map clickAddCarHireButton = null;
        private clickRemoveButton_Map clickRemoveButton = null;
        private verifyCarHireCategory_Map verifyCarHireCategory = null;
        private verifyCarFeatures_Map verifyCarFeatures = null;
        private verifyCarConfirm_Map verifyCarConfirm = null;
        private verifyCarSelection_Map verifyCarSelection = null;
        private verifyTransferSection_Map verifyTransferSection = null;
        private selectInsurance_Map selectInsurance = null;
        private selectAirportAssistance_Map selectAirportAssistance = null;
        private selectWheelChair_Map selectWheelChair = null;
        private EnterPostCode_Map EnterPostCode = null;
        private clickLookupAddressBtn_Map clickLookupAddressBtn = null;
        private VerifyPostCodeErrPopup_Map VerifyPostCodeErrPopup;
        private clickOKFrmPostCodeErrPopup_Map clickOKFrmPostCodeErrPopup;
        private enterAddressManually_Map enterAddressManually;
        private enterPhoneData_Map enterPhoneData = null;
        private clickContinueBtnFrmLeadPax_Map clickContinueBtnFrmLeadPax = null;
        private verifyTermsnCondsPageOpened_Map verifyTermsnCondsPageOpened = null;
        private clickIAgreeFrmTermsPage_Map clickIAgreeFrmTermsPage = null;
        private verifyTLSPopupShown_Map verifyTLSPopupShown = null;
        private clickContinueFrmPopup_Map clickContinueFrmPopup = null;
        private clickPayOnlineFrmTLS_Map clickPayOnlineFrmTLS = null;
        private clickPayByPhoneFrmTLS_Map clickPayByPhoneFrmTLS = null;
        private verifyPaymentPageOpened_Map verifyPaymentPageOpened = null;
        private selectCardType_Map selectCardType = null;
        private enterCardNum_Map enterCardNum = null;
        private selectStartMnth_Map selectStartMnth = null;
        private selectStartYr_Map selectStartYr = null;
        private selectExpiryMnth_Map selectExpiryMnth = null;
        private selectExpiryYr_Map selectExpiryYr = null;
        private enterCVV_Map enterCVV = null;
        private clickScrollPay_Map clickScrollPay = null;
        private clickPayBtn_Map clickPayBtn = null;
        private verifyErrShownonPayPage_Map verifyErrShownonPayPage = null;
        private clickPayByPhoneBtn_Map clickPayByPhoneBtn = null;
        private enter3DPwd_Map enter3DPwd = null;
        private clickSubmitBtnFrm3D_Map clickSubmitBtnFrm3D = null;
        private clickSubmitBtnVISAFrm3D_Map clickSubmitBtnVISAFrm3D = null;
        private clickCancellinkFrm3D_Map clickCancellinkFrm3D = null;
        private verifyThankUPageOpened_Map verifyThankUPageOpened = null;
        private verifyVillaExtrasAvailable_Map verifyVillaExtrasAvailable = null;
        //private clickContinueFrmExtrasPage_Map clickContinueFrmExtrasPage = null;
        //private verifyLeadPaxPageOpened_Map verifyLeadPaxPageOpened = null;
        //private clickScrollArrow_Map clickScrollArrow = null;
       // private clickScrollArrowGD_Map clickScrollArrowGD = null;
        //private verifyVillaExtrasMinus_Map verifyVillaExtrasMinus = null;
        //private clickVillaExtrasAdded_Map clickVillaExtrasAdded = null;
        //private clickVillaExtrasAll_Map clickVillaExtrasAll = null;
        //private verifyHelpIconVillaExtras_Map verifyHelpIconVillaExtras = null;
        //private verifyCarHireTextMessage_Map verifyCarHireTextMessage = null;
        //private verifyCarsCategory_Map verifyCarsCategory = null;
        //private clickAddCarHireButton_Map clickAddCarHireButton = null;
        //private clickRemoveButton_Map clickRemoveButton = null;
        //private verifyCarHireCategory_Map verifyCarHireCategory = null;
        //private verifyCarFeatures_Map verifyCarFeatures = null;
        //private verifyCarConfirm_Map verifyCarConfirm = null;
        //private verifyCarSelection_Map verifyCarSelection = null;
        //private verifyTransferSection_Map verifyTransferSection = null;
               


        public InitiateMobileBooking()
        {
            OpenBrowser = new openBrowser_Map();
        }
        public openBrowser_Map OpenBrowser_Obj
        {
            get { return OpenBrowser; }
            set { OpenBrowser = value; }
        }
        public EnterURL_Map EnterURL_Obj
        {
            get
            {
                if (EnterURL == null)
                {
                    EnterURL = new EnterURL_Map();
                    EnterURL.UINewTabWindowsInterneWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return EnterURL;
            }
        }
        public clickOpenSearchPage_Map clickOpenSearchPage_obj
        {
            get
            {
                if (clickOpenSearchPage == null)
                {
                    clickOpenSearchPage = new clickOpenSearchPage_Map();
                    clickOpenSearchPage.UIVillaHolidays2016ThaWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickOpenSearchPage;
            }

        }
        public clickSearchIconFrmHeader_Map clickSearchIconFrmHeader_obj
        {
            get
            {
                if (clickSearchIconFrmHeader == null)
                {
                    clickSearchIconFrmHeader = new clickSearchIconFrmHeader_Map();
                    clickSearchIconFrmHeader.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSearchIconFrmHeader;
            }

        }
        public clickDestinationResortVilla_Map clickDestinationResortVilla_obj
        {
            get
            {
                if (clickDestinationResortVilla == null)
                {
                    clickDestinationResortVilla = new clickDestinationResortVilla_Map();
                    clickDestinationResortVilla.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickDestinationResortVilla;
            }
        }
        public verifyHoneTagDestinationResortVilla_Map verifyHoneTagDestinationResortVilla_obj
        {
            get
            {
                if (verifyHoneTagDestinationResortVilla == null)
                {
                    verifyHoneTagDestinationResortVilla = new verifyHoneTagDestinationResortVilla_Map();
                    verifyHoneTagDestinationResortVilla.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return verifyHoneTagDestinationResortVilla;
            }
        }
        public verifyDestResVillaListing_Map verifyDestResVillaListing_obj
        {
            get
            {
                if (verifyDestResVillaListing == null)
                {
                    verifyDestResVillaListing = new verifyDestResVillaListing_Map();
                    verifyDestResVillaListing.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyDestResVillaListing;
            }
        }
        public enterDestnameSearchLayer_Map enterDestnameSearchLayer_obj
        {
            get
            {
                if (enterDestnameSearchLayer == null)
                {
                    enterDestnameSearchLayer = new enterDestnameSearchLayer_Map();
                    enterDestnameSearchLayer.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterDestnameSearchLayer;
            }
        }
        public clickCentreName_Map clickCentreName_obj
        {
            get
            {
                if (clickCentreName == null)
                {
                    clickCentreName = new clickCentreName_Map();
                    clickCentreName.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickCentreName;
            }
        }
        public clickHeaderLogo_Map clickHeaderLogo_obj
        {
            get
            {
                if (clickHeaderLogo == null)
                {
                    clickHeaderLogo = new clickHeaderLogo_Map();
                    clickHeaderLogo.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickHeaderLogo;
            }
        }
        //public clickBackSearchLayer_Map clickBackSearchLayer_obj
        //{
        //    get
        //    {
        //        if (clickBackSearchLayer == null)
        //        {
        //            clickBackSearchLayer = new clickBackSearchLayer_Map();
        //            clickBackSearchLayer.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
        //        }
        //        return clickBackSearchLayer;
        //    }
        //}
        public clickBackFromHeader_Map clickBackFromHeader_obj
        {
            get
            {
                if (clickBackFromHeader == null)
                {
                    clickBackFromHeader = new clickBackFromHeader_Map();
                    clickBackFromHeader.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBackFromHeader;
            }
        }
        public verifyCenternamesPopulated_Map verifyCenternamesPopulated_obj
        {
            get
            {
                if (verifyCenternamesPopulated == null)
                {
                    verifyCenternamesPopulated = new verifyCenternamesPopulated_Map();
                    verifyCenternamesPopulated.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCenternamesPopulated;
            }
        }
        public selectingDestinationFrmSearch_Map selectingDestinationFrmSearch_obj
        {
            get
            {
                if (selectingDestinationFrmSearch == null)
                {
                    selectingDestinationFrmSearch = new selectingDestinationFrmSearch_Map();
                    selectingDestinationFrmSearch.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectingDestinationFrmSearch;
            }
        }
        public clickCalenderIcon_Map clickCalenderIcon_obj
        {
            get
            {
                if (clickCalenderIcon == null)
                {
                    clickCalenderIcon = new clickCalenderIcon_Map();
                    clickCalenderIcon.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickCalenderIcon;
            }
        }
		public verifyVillaName_Map verifyVillaName_obj
        {
            get
            {
                if (verifyVillaName == null)
                {
                    verifyVillaName = new verifyVillaName_Map();
                    verifyVillaName.UIYoursearchfound8VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyVillaName;
            }
        }
        public verifyCalenderOpend_Map verifyCalenderOpend_obj
        {
            get
            {
                if (verifyCalenderOpend == null)
                {
                    verifyCalenderOpend = new verifyCalenderOpend_Map();
                    verifyCalenderOpend.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCalenderOpend;
            }
        }
        public clickNextArrowFrmCalender_Map clickNextArrowFrmCalender_obj
        {
            get
            {
                if (clickNextArrowFrmCalender == null)
                {
                    clickNextArrowFrmCalender = new clickNextArrowFrmCalender_Map();
                    clickNextArrowFrmCalender.UISearchVillaPlusInterWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickNextArrowFrmCalender;
            }
        }
        public clickPrevArrowFrmCalender_Map clickPrevArrowFrmCalender_obj
        {
            get
            {
                if (clickPrevArrowFrmCalender == null)
                {
                    clickPrevArrowFrmCalender = new clickPrevArrowFrmCalender_Map();
                    clickPrevArrowFrmCalender.UISearchVillaPlusInterWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPrevArrowFrmCalender;
            }
        }
        public clickNextArrowTwice_Map clickNextArrowTwice_obj
        {
            get
            {
                if (clickNextArrowTwice == null)
                {
                    clickNextArrowTwice = new clickNextArrowTwice_Map();
                    clickNextArrowTwice.UISearchVillaPlusInterWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickNextArrowTwice;
            }
        }
        public clickNextArrowThrice_Map clickNextArrowThrice_obj
        {
            get
            {
                if (clickNextArrowThrice == null)
                {
                    clickNextArrowThrice = new clickNextArrowThrice_Map();
                    clickNextArrowThrice.UISearchVillaPlusInterWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickNextArrowThrice;
            }
        }
        public selectDateFrmCalender_Map selectDateFrmCalender_obj
        {
            get
            {
                if (selectDateFrmCalender == null)
                {
                    selectDateFrmCalender = new selectDateFrmCalender_Map();
                    selectDateFrmCalender.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectDateFrmCalender;
            }
        }
        public clickPlusFrDuration_Map clickPlusFrDuration_obj
        {
            get
            {
                if (clickPlusFrDuration == null)
                {
                    clickPlusFrDuration = new clickPlusFrDuration_Map();
                    clickPlusFrDuration.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusFrDuration;
            }
        }
        public clickMinusFrDuration_Map clickMinusFrDuration_obj
        {
            get
            {
                if (clickMinusFrDuration == null)
                {
                    clickMinusFrDuration = new clickMinusFrDuration_Map();
                    clickMinusFrDuration.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMinusFrDuration;
            }
        }
        public clickPlusIconforAdults_Map clickPlusIconforAdults_obj
        {
            get
            {
                if (clickPlusIconforAdults == null)
                {
                    clickPlusIconforAdults = new clickPlusIconforAdults_Map();
                    clickPlusIconforAdults.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusIconforAdults;
            }
        }
        public clickMinusfrAdults_Map clickMinusfrAdults_obj
        {
            get
            {
                if (clickMinusfrAdults == null)
                {
                    clickMinusfrAdults = new clickMinusfrAdults_Map();
                    clickMinusfrAdults.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMinusfrAdults;
            }
        }
        public clickMinusFrChild_Map clickMinusFrChild_obj
        {
            get
            {
                if (clickMinusFrChild == null)
                {
                    clickMinusFrChild = new clickMinusFrChild_Map();
                    clickMinusFrChild.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMinusFrChild;
            }
        }
        public clickMinusFrInfants_Map clickMinusFrInfants_obj
        {
            get
            {
                if (clickMinusFrInfants == null)
                {
                    clickMinusFrInfants = new clickMinusFrInfants_Map();
                    clickMinusFrInfants.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMinusFrInfants;
            }
        }
        public clickPlusiconforChild_Map clickPlusiconforChild_obj
        {
            get
            {
                if (clickPlusiconforChild == null)
                {
                    clickPlusiconforChild = new clickPlusiconforChild_Map();
                    clickPlusiconforChild.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusiconforChild;
            }
        }
        public clickPlusIconforInfants_Map clickPlusIconforInfants_obj
        {
            get
            {
                if (clickPlusIconforInfants == null)
                {
                    clickPlusIconforInfants = new clickPlusIconforInfants_Map();
                    clickPlusIconforInfants.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusIconforInfants;
            }
        }
        public clickDepAirportBox_Map clickDepAirportBox_obj
        {
            get
            {
                if (clickDepAirportBox == null)
                {
                    clickDepAirportBox = new clickDepAirportBox_Map();
                    clickDepAirportBox.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickDepAirportBox;
            }
        }
        public selectDepAirport_Map selectDepAirport_obj
        {
            get
            {
                if (selectDepAirport == null)
                {
                    selectDepAirport = new selectDepAirport_Map();
                    selectDepAirport.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectDepAirport;
            }
        }
        public verifyValErrwithSingleAdult_Map verifyValErrwithSingleAdult_obj
        {
            get
            {
                if (verifyValErrwithSingleAdult == null)
                {
                    verifyValErrwithSingleAdult = new verifyValErrwithSingleAdult_Map();
                    verifyValErrwithSingleAdult.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyValErrwithSingleAdult;
            }
        }
        public verifyValErrMoreInfantsthanAdults_Map verifyValErrMoreInfantsthanAdults_obj
        {
            get
            {
                if (verifyValErrMoreInfantsthanAdults == null)
                {
                    verifyValErrMoreInfantsthanAdults = new verifyValErrMoreInfantsthanAdults_Map();
                    verifyValErrMoreInfantsthanAdults.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyValErrMoreInfantsthanAdults;
            }
        }
        public clickSearchButton_Map clickSearchButton_obj
        {
            get
            {
                if (clickSearchButton == null)
                {
                    clickSearchButton = new clickSearchButton_Map();
                    clickSearchButton.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSearchButton;
            }
        }
        public verifySRPagedisplay_Map verifySRPagedisplay_obj
        {
            get
            {
                if (verifySRPagedisplay == null)
                {
                    verifySRPagedisplay = new verifySRPagedisplay_Map();
                    verifySRPagedisplay.UIYoursearchfound6VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifySRPagedisplay;
            }
        }
        public verifySRCAirport_Map verifySRCAirport_obj
        {
            get
            {
                if (verifySRCAirport == null)
                {
                    verifySRCAirport = new verifySRCAirport_Map();
                    verifySRCAirport.UIYoursearchfound1VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifySRCAirport;
            }
        }
        public dragCal_Map dragCal_obj
        {
            get
            {
                if (dragCal == null)
                {
                    dragCal = new dragCal_Map();
                    dragCal.UISearchVillaPlusInterWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return dragCal;
            }
        }
        public verifySearchCriteriaDisplay_Map verifySearchCriteriaDisplay_obj
        {
            get
            {
                if (verifySearchCriteriaDisplay == null)
                {
                    verifySearchCriteriaDisplay = new verifySearchCriteriaDisplay_Map();
                    verifySearchCriteriaDisplay.UIYoursearchfound5VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifySearchCriteriaDisplay;
            }
        }
        public clickVillaNameLink_Map clickVillaNameLink_obj
        {
            get
            {
                if (clickVillaNameLink == null)
                {
                    clickVillaNameLink = new clickVillaNameLink_Map();
                    clickVillaNameLink.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickVillaNameLink;
            }
        }
        public verifyProductPagedisplay_Map verifyProductPagedisplay_obj
        {
            get
            {
                if (verifyProductPagedisplay == null)
                {
                    verifyProductPagedisplay = new verifyProductPagedisplay_Map();
                    verifyProductPagedisplay.UIVillaVerdialesInFrigWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyProductPagedisplay;
            }
        }
        public clickMoreInfoBtn_Map clickMoreInfoBtn_obj
        {
            get
            {
                if (clickMoreInfoBtn == null)
                {
                    clickMoreInfoBtn = new clickMoreInfoBtn_Map();
                    clickMoreInfoBtn.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMoreInfoBtn;
            }
        }
        public clickBackSearchLayer_Map clickBackSearchLayer_obj
        {
            get
            {
                if (clickBackSearchLayer == null)
                {
                    clickBackSearchLayer = new clickBackSearchLayer_Map();
                    clickBackSearchLayer.UISearchVillaPlusWindoWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBackSearchLayer;
            }
        }
        public clickBackFrmPrdctPage_Map clickBackFrmPrdctPage_obj
        {
            get
            {
                if (clickBackFrmPrdctPage == null)
                {
                    clickBackFrmPrdctPage = new clickBackFrmPrdctPage_Map();
                    clickBackFrmPrdctPage.UIVillaCeciliaInGuadalWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBackFrmPrdctPage;
            }
        }
        public clickShowMoreResultsBtn_Map clickShowMoreResultsBtn_obj
        {
            get
            {
                if (clickShowMoreResultsBtn == null)
                {
                    clickShowMoreResultsBtn = new clickShowMoreResultsBtn_Map();
                    clickShowMoreResultsBtn.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickShowMoreResultsBtn;
            }
        }
        public clickBookVillaAndFlightsBtn_Map clickBookVillaAndFlightsBtn_obj
        {
            get
            {
                if (clickBookVillaAndFlightsBtn == null)
                {
                    clickBookVillaAndFlightsBtn = new clickBookVillaAndFlightsBtn_Map();
                    clickBookVillaAndFlightsBtn.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBookVillaAndFlightsBtn;
            }
        }
        public verifyFlightsPageOpened_Map verifyFlightsPageOpened_obj
        {
            get
            {
                if (verifyFlightsPageOpened == null)
                {
                    verifyFlightsPageOpened = new verifyFlightsPageOpened_Map();
                    verifyFlightsPageOpened.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyFlightsPageOpened;
            }
        }
        public clickBookVillaOnlyBtn_Map clickBookVillaOnlyBtn_obj
        {
            get
            {
                if (clickBookVillaOnlyBtn == null)
                {
                    clickBookVillaOnlyBtn = new clickBookVillaOnlyBtn_Map();
                    clickBookVillaOnlyBtn.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBookVillaOnlyBtn;
            }
        }
        public clickBackFrmFlightsPage_Map clickBackFrmFlightsPage_obj
        {
            get
            {
                if (clickBackFrmFlightsPage == null)
                {
                    clickBackFrmFlightsPage = new clickBackFrmFlightsPage_Map();
                    clickBackFrmFlightsPage.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickBackFrmFlightsPage;
            }
        }
        public clickOnVillaImage_Map clickOnVillaImage_obj
        {
            get
            {
                if (clickOnVillaImage == null)
                {
                    clickOnVillaImage = new clickOnVillaImage_Map();
                    clickOnVillaImage.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickOnVillaImage;
            }
        }
        public clickUsefulLinksHeading_Map clickUsefulLinksHeading_obj
        {
            get
            {
                if (clickUsefulLinksHeading == null)
                {
                    clickUsefulLinksHeading = new clickUsefulLinksHeading_Map();
                    clickUsefulLinksHeading.UIYoursearchfound97VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickUsefulLinksHeading;
            }
        }
        public clickAllusefulLinks_Map clickAllusefulLinks_obj
        {
            get
            {
                if (clickAllusefulLinks == null)
                {
                    clickAllusefulLinks = new clickAllusefulLinks_Map();
                    clickAllusefulLinks.UIYoursearchfound82VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickAllusefulLinks;
            }
        }
        public clickSortBy_Map clickSortBy_obj
        {
            get
            {
                if (clickSortBy == null)
                {
                    clickSortBy = new clickSortBy_Map();
                    clickSortBy.UIYoursearchfound20VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSortBy;
            }
        }
        public selectSortOption_Map selectSortOption_obj
        {
            get
            {
                if (selectSortOption == null)
                {
                    selectSortOption = new selectSortOption_Map();
                    selectSortOption.UIYoursearchfound18VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectSortOption;
            }
        }
        public clickApplySort_Map clickApplySort_obj
        {
            get
            {
                if (clickApplySort == null)
                {
                    clickApplySort = new clickApplySort_Map();
                    clickApplySort.UIYoursearchfound20VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickApplySort;
            }
        }
        public getVilladetailsBlock_Map getVilladetailsBlock_obj
        {
            get
            {
                if (getVilladetailsBlock == null)
                {
                    getVilladetailsBlock = new getVilladetailsBlock_Map();
                    getVilladetailsBlock.UIYoursearchfound2VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return getVilladetailsBlock;
            }
        }
        public clickFilterBy_Map clickFilterBy_obj
        {
            get
            {
                if (clickFilterBy == null)
                {
                    clickFilterBy = new clickFilterBy_Map();
                    clickFilterBy.UIYoursearchfound20VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickFilterBy;
            }
        }
        public clickApplyFilter_Map clickApplyFilter_obj
        {
            get
            {
                if (clickApplyFilter == null)
                {
                    clickApplyFilter = new clickApplyFilter_Map();
                    clickApplyFilter.UIYoursearchfound20VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickApplyFilter;
            }
        }
        public clickClearFilter_Map clickClearFilter_obj
        {
            get
            {
                if (clickClearFilter == null)
                {
                    clickClearFilter = new clickClearFilter_Map();
                    clickClearFilter.UIYoursearchfound18VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickClearFilter;
            }
        }
        public clickPlusForFilter_Map clickPlusForFilter_obj
        {
            get
            {
                if (clickPlusForFilter == null)
                {
                    clickPlusForFilter = new clickPlusForFilter_Map();
                    clickPlusForFilter.UIYoursearchfound4VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusForFilter;
            }
        }
        public clickFilterName_Map clickFilterName_obj
        {
            get
            {
                if (clickFilterName == null)
                {
                    clickFilterName = new clickFilterName_Map();
                    clickFilterName.UIYoursearchfound24VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickFilterName;
            }
        }
        public verifyIncompleteBkgPopupDisplay_Map verifyIncompleteBkgPopupDisplay_obj
        {
            get
            {
                if (verifyIncompleteBkgPopupDisplay == null)
                {
                    verifyIncompleteBkgPopupDisplay = new verifyIncompleteBkgPopupDisplay_Map();
                    verifyIncompleteBkgPopupDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyIncompleteBkgPopupDisplay;
            }
        }
        public clickNOFrmIncomBkgPopup_Map clickNOFrmIncomBkgPopup_obj
        {
            get
            {
                if (clickNOFrmIncomBkgPopup == null)
                {
                    clickNOFrmIncomBkgPopup = new clickNOFrmIncomBkgPopup_Map();
                    clickNOFrmIncomBkgPopup.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickNOFrmIncomBkgPopup;
            }
        }
        public clickContinueBtn_Map clickContinueBtn_obj
        {
            get
            {
                if (clickContinueBtn == null)
                {
                    clickContinueBtn = new clickContinueBtn_Map();
                    clickContinueBtn.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContinueBtn;
            }
        }
        public verifyDftFlightDetails_Map verifyDftFlightDetails_obj
        {
            get
            {
                if (verifyDftFlightDetails == null)
                {
                    verifyDftFlightDetails = new verifyDftFlightDetails_Map();
                    verifyDftFlightDetails.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyDftFlightDetails;
            }
        }
        public verifyDftFExtras_Map verifyDftFExtras_obj
        {
            get
            {
                if (verifyDftFExtras == null)
                {
                    verifyDftFExtras = new verifyDftFExtras_Map();
                    verifyDftFExtras.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyDftFExtras;
            }
        }
        public verifyFExtrasDetails_Map verifyFExtrasDetails_obj
        {
            get
            {
                if (verifyFExtrasDetails == null)
                {
                    verifyFExtrasDetails = new verifyFExtrasDetails_Map();
                    verifyFExtrasDetails.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyFExtrasDetails;
            }
        }
        public clickPlusForFExtras_Map clickPlusForFExtras_obj
        {
            get
            {
                if (clickPlusForFExtras == null)
                {
                    clickPlusForFExtras = new clickPlusForFExtras_Map();
                    clickPlusForFExtras.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPlusForFExtras;
            }
        }
        public clickMinusForFExtras_Map clickMinusForFExtras_obj
        {
            get
            {
                if (clickMinusForFExtras == null)
                {
                    clickMinusForFExtras = new clickMinusForFExtras_Map();
                    clickMinusForFExtras.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMinusForFExtras;
            }
        }
        public VerifyATOL_Map VerifyATOL_obj
        {
            get
            {
                if (VerifyATOL == null)
                {
                    VerifyATOL = new VerifyATOL_Map();
                    VerifyATOL.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return VerifyATOL;
            }
        }
        public verifyVillanFlightsTotal_Map verifyVillanFlightsTotal_obj
        {
            get
            {
                if (verifyVillanFlightsTotal == null)
                {
                    verifyVillanFlightsTotal = new verifyVillanFlightsTotal_Map();
                    verifyVillanFlightsTotal.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyVillanFlightsTotal;
            }
        }
        public verifyADWTextonFlightsPage_Map verifyADWTextonFlightsPage_obj
        {
            get
            {
                if (verifyADWTextonFlightsPage == null)
                {
                    verifyADWTextonFlightsPage = new verifyADWTextonFlightsPage_Map();
                    verifyADWTextonFlightsPage.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyADWTextonFlightsPage;
            }
        }
        public clickViewSummary_Map clickViewSummary_obj
        {
            get
            {
                if (clickViewSummary == null)
                {
                    clickViewSummary = new clickViewSummary_Map();
                    clickViewSummary.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickViewSummary;
            }
        }
        public verifyViewSummaryOpened_Map verifyViewSummaryOpened_obj
        {
            get
            {
                if (verifyViewSummaryOpened == null)
                {
                    verifyViewSummaryOpened = new verifyViewSummaryOpened_Map();
                    verifyViewSummaryOpened.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyViewSummaryOpened;
            }
        }
        public clickHideSummary_Map clickHideSummary_obj
        {
            get
            {
                if (clickHideSummary == null)
                {
                    clickHideSummary = new clickHideSummary_Map();
                    clickHideSummary.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickHideSummary;
            }
        }
        public clickEditFlightsBtn_Map clickEditFlightsBtn_obj
        {
            get
            {
                if (clickEditFlightsBtn == null)
                {
                    clickEditFlightsBtn = new clickEditFlightsBtn_Map();
                    clickEditFlightsBtn.UIHttpmobstagingvillapWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickEditFlightsBtn;
            }
        }
        public verifyAmndFltsPageOpened_Map verifyAmndFltsPageOpened_obj
        {
            get
            {
                if (verifyAmndFltsPageOpened == null)
                {
                    verifyAmndFltsPageOpened = new verifyAmndFltsPageOpened_Map();
                    verifyAmndFltsPageOpened.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyAmndFltsPageOpened;
            }
        }
        public clickChangeDepAirportBtn_Map clickChangeDepAirportBtn_obj
        {
            get
            {
                if (clickChangeDepAirportBtn == null)
                {
                    clickChangeDepAirportBtn = new clickChangeDepAirportBtn_Map();
                    clickChangeDepAirportBtn.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickChangeDepAirportBtn;
            }
        }
        public clickConfirmBtn_Map clickConfirmBtn_obj
        {
            get
            {
                if (clickConfirmBtn == null)
                {
                    clickConfirmBtn = new clickConfirmBtn_Map();
                    clickConfirmBtn.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickConfirmBtn;
            }
        }
        public clickSelectFlightBtn_Map clickSelectFlightBtn_obj
        {
            get
            {
                if (clickSelectFlightBtn == null)
                {
                    clickSelectFlightBtn = new clickSelectFlightBtn_Map();
                    clickSelectFlightBtn.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSelectFlightBtn;
            }
        }
        public selectChngArrAirport_Map selectChngArrAirport_obj
        {
            get
            {
                if (selectChngArrAirport == null)
                {
                    selectChngArrAirport = new selectChngArrAirport_Map();
                    selectChngArrAirport.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectChngArrAirport;
            }
        }
        public selectChngDepAirport_Map selectChngDepAirport_obj
        {
            get
            {
                if (selectChngDepAirport == null)
                {
                    selectChngDepAirport = new selectChngDepAirport_Map();
                    selectChngDepAirport.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectChngDepAirport;
            }
        }
        public selectFlightChckBox_Map selectFlightChckBox_obj
        {
            get
            {
                if (selectFlightChckBox == null)
                {
                    selectFlightChckBox = new selectFlightChckBox_Map();
                    selectFlightChckBox.UIVillaPlusAmendFlightWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectFlightChckBox;
            }
        }
        public verifyTotalPriceOnFlightsPage_Map verifyTotalPriceOnFlightsPage_obj
        {
            get
            {
                if (verifyTotalPriceOnFlightsPage == null)
                {
                    verifyTotalPriceOnFlightsPage = new verifyTotalPriceOnFlightsPage_Map();
                    verifyTotalPriceOnFlightsPage.UIHttpsmvillapluscomboWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyTotalPriceOnFlightsPage;
            }
        }
        public verifyHoldItemsPopupdisplay_Map verifyHoldItemsPopupdisplay_obj
        {
            get
            {
                if (verifyHoldItemsPopupdisplay == null)
                {
                    verifyHoldItemsPopupdisplay = new verifyHoldItemsPopupdisplay_Map();
                    verifyHoldItemsPopupdisplay.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyHoldItemsPopupdisplay;
            }
        }
        public IsCheckInBagspopShown_Map IsCheckInBagspopShown_obj
        {
            get
            {
                if (IsCheckInBagspopShown == null)
                {
                    IsCheckInBagspopShown = new IsCheckInBagspopShown_Map();
                    IsCheckInBagspopShown.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return IsCheckInBagspopShown;
            }
        }
        public clickYesfromCheckInPop_Map clickYesfromCheckInPop_obj
        {
            get
            {
                if (clickYesfromCheckInPop == null)
                {
                    clickYesfromCheckInPop = new clickYesfromCheckInPop_Map();
                    clickYesfromCheckInPop.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickYesfromCheckInPop;
            }
        }
        public clickYesFrmHoldPopup_Map clickYesFrmHoldPopup_obj
        {
            get
            {
                if (clickYesFrmHoldPopup == null)
                {
                    clickYesFrmHoldPopup = new clickYesFrmHoldPopup_Map();
                    clickYesFrmHoldPopup.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickYesFrmHoldPopup;
            }
        }
        public clickYesBtnFrmMobilityPopup_Map clickYesBtnFrmMobilityPopup_obj
        {
            get
            {
                if (clickYesBtnFrmMobilityPopup == null)
                {
                    clickYesBtnFrmMobilityPopup = new clickYesBtnFrmMobilityPopup_Map();
                    clickYesBtnFrmMobilityPopup.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickYesBtnFrmMobilityPopup;
            }
        }
        public verifyGrpDtlsPgeOpened_Map verifyGrpDtlsPgeOpened_obj
        {
            get
            {
                if (verifyGrpDtlsPgeOpened == null)
                {
                    verifyGrpDtlsPgeOpened = new verifyGrpDtlsPgeOpened_Map();
                    verifyGrpDtlsPgeOpened.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyGrpDtlsPgeOpened;
            }
        }
        public enterPaxDetails_Map enterPaxDetails_obj
        {
            get
            {
                if (enterPaxDetails == null)
                {
                    enterPaxDetails = new enterPaxDetails_Map();
                    enterPaxDetails.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterPaxDetails;
            }
        }
        public clickScrollArrowGD_Map clickScrollArrowGD_obj
        {
            get
            {
                if (clickScrollArrowGD == null)
                {
                    clickScrollArrowGD = new clickScrollArrowGD_Map();
                    clickScrollArrowGD.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickScrollArrowGD;
            }
        }
        public clickContinueBtnFrmGDPage_Map clickContinueBtnFrmGDPage_obj
        {
            get
            {
                if (clickContinueBtnFrmGDPage == null)
                {
                    clickContinueBtnFrmGDPage = new clickContinueBtnFrmGDPage_Map();
                    clickContinueBtnFrmGDPage.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContinueBtnFrmGDPage;
            }
        }
        public verifyDblBookingpopup_Map verifyDblBookingpopup_obj
        {
            get
            {
                if (verifyDblBookingpopup == null)
                {
                    verifyDblBookingpopup = new verifyDblBookingpopup_Map();
                    verifyDblBookingpopup.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyDblBookingpopup;
            }
        }
        public clickNOFrmDblBkngPPup_Map clickNOFrmDblBkngPPup_obj
        {
            get
            {
                if (clickNOFrmDblBkngPPup == null)
                {
                    clickNOFrmDblBkngPPup = new clickNOFrmDblBkngPPup_Map();
                    clickNOFrmDblBkngPPup.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickNOFrmDblBkngPPup;
            }
        }
        public selectInsurance_Map selectInsurance_obj
        {
            get
            {
                if (selectInsurance == null)
                {
                    selectInsurance = new selectInsurance_Map();
                    selectInsurance.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectInsurance;
            }
        }
        public selectAirportAssistance_Map selectAirportAssistance_obj
        {
            get
            {
                if (selectAirportAssistance == null)
                {
                    selectAirportAssistance = new selectAirportAssistance_Map();
                    selectAirportAssistance.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectAirportAssistance;
            }
        }
        public selectWheelChair_Map selectWheelChair_obj
        {
            get
            {
                if (selectWheelChair == null)
                {
                    selectWheelChair = new selectWheelChair_Map();
                    selectWheelChair.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectWheelChair;
            }
        }
        public verifyTravelInsPopupDisplayed_Map verifyTravelInsPopupDisplayed_obj
        {
            get
            {
                if (verifyTravelInsPopupDisplayed == null)
                {
                    verifyTravelInsPopupDisplayed = new verifyTravelInsPopupDisplayed_Map();
                    verifyTravelInsPopupDisplayed.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyTravelInsPopupDisplayed;
            }
        }
        public clickIAgreeFrmTravINSPopup_Map clickIAgreeFrmTravINSPopup_obj
        {
            get
            {
                if (clickIAgreeFrmTravINSPopup == null)
                {
                    clickIAgreeFrmTravINSPopup = new clickIAgreeFrmTravINSPopup_Map();
                    clickIAgreeFrmTravINSPopup.UIVillaPlusGroupDetailWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickIAgreeFrmTravINSPopup;
            }
        }
        public verifyExtrasPageDisplayed_Map verifyExtrasPageDisplayed_obj
        {
            get
            {
                if (verifyExtrasPageDisplayed == null)
                {
                    verifyExtrasPageDisplayed = new verifyExtrasPageDisplayed_Map();
                    verifyExtrasPageDisplayed.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyExtrasPageDisplayed;
            }
        }
        public clickScrollFrmExtras_Map clickScrollFrmExtras_obj
        {
            get
            {
                if (clickScrollFrmExtras == null)
                {
                    clickScrollFrmExtras = new clickScrollFrmExtras_Map();
                    clickScrollFrmExtras.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickScrollFrmExtras;
            }
        }
        public clickContinueFrmExtrasPage_Map clickContinueFrmExtrasPage_obj
        {
            get
            {
                if (clickContinueFrmExtrasPage == null)
                {
                    clickContinueFrmExtrasPage = new clickContinueFrmExtrasPage_Map();
                    clickContinueFrmExtrasPage.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContinueFrmExtrasPage;
            }
        }
        public verifyYourFltPgeShown_Map verifyYourFltPgeShown_obj
        {
            get
            {
                if (verifyYourFltPgeShown == null)
                {
                    verifyYourFltPgeShown = new verifyYourFltPgeShown_Map();
                    verifyYourFltPgeShown.UIVillaPlusCustomerFliWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyYourFltPgeShown;
            }
        }
        public clickLaterBtn_Map clickLaterBtn_obj
        {
            get
            {
                if (clickLaterBtn == null)
                {
                    clickLaterBtn = new clickLaterBtn_Map();
                    clickLaterBtn.UIVillaPlusCustomerFliWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickLaterBtn;
            }
        }
        public clickScrollArrow_Map clickScrollArrow_obj
        {
            get
            {
                if (clickScrollArrow == null)
                {
                    clickScrollArrow = new clickScrollArrow_Map();
                    clickScrollArrow.UIVillaPlusBookingInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickScrollArrow;
            }
        }
        public verifyLeadPaxPageOpened_Map verifyLeadPaxPageOpened_obj
        {
            get
            {
                if (verifyLeadPaxPageOpened == null)
                {
                    verifyLeadPaxPageOpened = new verifyLeadPaxPageOpened_Map();
                    verifyLeadPaxPageOpened.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyLeadPaxPageOpened;
            }
        }
        public EnterPostCode_Map EnterPostCode_obj
        {
            get
            {
                if (EnterPostCode == null)
                {
                    EnterPostCode = new EnterPostCode_Map();
                    EnterPostCode.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return EnterPostCode;
            }
        }
        public clickLookupAddressBtn_Map clickLookupAddressBtn_obj
        {
            get
            {
                if (clickLookupAddressBtn == null)
                {
                    clickLookupAddressBtn = new clickLookupAddressBtn_Map();
                    clickLookupAddressBtn.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickLookupAddressBtn;
            }
        }
        public VerifyPostCodeErrPopup_Map VerifyPostCodeErrPopup_Obj
        {
            get
            {
                if(VerifyPostCodeErrPopup == null)
                {
                    VerifyPostCodeErrPopup = new VerifyPostCodeErrPopup_Map();
                    VerifyPostCodeErrPopup.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return VerifyPostCodeErrPopup;
            }

        }
        public clickOKFrmPostCodeErrPopup_Map clickOKFrmPostCodeErrPopup_Obj
        {
            get
            {
                if (clickOKFrmPostCodeErrPopup == null)
                {
                    clickOKFrmPostCodeErrPopup = new clickOKFrmPostCodeErrPopup_Map();
                    clickOKFrmPostCodeErrPopup.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickOKFrmPostCodeErrPopup;
            }

        }
        public enterAddressManually_Map enterAddressManually_Obj
        {
            get
            {
                if (enterAddressManually == null)
                {
                    enterAddressManually = new enterAddressManually_Map();
                    enterAddressManually.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterAddressManually;
            }

        }
        public enterPhoneData_Map enterPhoneData_obj
        {
            get
            {
                if (enterPhoneData == null)
                {
                    enterPhoneData = new enterPhoneData_Map();
                    enterPhoneData.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterPhoneData;
            }
        }
        public clickContinueBtnFrmLeadPax_Map clickContinueBtnFrmLeadPax_obj
        {
            get
            {
                if (clickContinueBtnFrmLeadPax == null)
                {
                    clickContinueBtnFrmLeadPax = new clickContinueBtnFrmLeadPax_Map();
                    clickContinueBtnFrmLeadPax.UIVillaPlusLeadPassengWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContinueBtnFrmLeadPax;
            }
        }
        public verifyTermsnCondsPageOpened_Map verifyTermsnCondsPageOpened_obj
        {
            get
            {
                if (verifyTermsnCondsPageOpened == null)
                {
                    verifyTermsnCondsPageOpened = new verifyTermsnCondsPageOpened_Map();
                    verifyTermsnCondsPageOpened.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyTermsnCondsPageOpened;
            }
        }
        public clickIAgreeFrmTermsPage_Map clickIAgreeFrmTermsPage_obj
        {
            get
            {
                if (clickIAgreeFrmTermsPage == null)
                {
                    clickIAgreeFrmTermsPage = new clickIAgreeFrmTermsPage_Map();
                    clickIAgreeFrmTermsPage.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickIAgreeFrmTermsPage;
            }
        }
        public verifyTLSPopupShown_Map verifyTLSPopupShown_obj
        {
            get
            {
                if (verifyTLSPopupShown == null)
                {
                    verifyTLSPopupShown = new verifyTLSPopupShown_Map();
                    verifyTLSPopupShown.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyTLSPopupShown;
            }
        }
        public clickContinueFrmPopup_Map clickContinueFrmPopup_obj
        {
            get
            {
                if (clickContinueFrmPopup == null)
                {
                    clickContinueFrmPopup = new clickContinueFrmPopup_Map();
                    clickContinueFrmPopup.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContinueFrmPopup;
            }
        }
        public clickPayOnlineFrmTLS_Map clickPayOnlineFrmTLS_obj
        {
            get
            {
                if (clickPayOnlineFrmTLS == null)
                {
                    clickPayOnlineFrmTLS = new clickPayOnlineFrmTLS_Map();
                    clickPayOnlineFrmTLS.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPayOnlineFrmTLS;
            }
        }
        public clickPayByPhoneFrmTLS_Map clickPayByPhoneFrmTLS_obj
        {
            get
            {
                if (clickPayByPhoneFrmTLS == null)
                {
                    clickPayByPhoneFrmTLS = new clickPayByPhoneFrmTLS_Map();
                    clickPayByPhoneFrmTLS.UIVillaPlusBookingTermWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPayByPhoneFrmTLS;
            }
        }
        public verifyPaymentPageOpened_Map verifyPaymentPageOpened_obj
        {
            get
            {
                if (verifyPaymentPageOpened == null)
                {
                    verifyPaymentPageOpened = new verifyPaymentPageOpened_Map();
                    verifyPaymentPageOpened.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyPaymentPageOpened;
            }
        }
        public selectCardType_Map selectCardType_obj
        {
            get
            {
                if (selectCardType == null)
                {
                    selectCardType = new selectCardType_Map();
                    selectCardType.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectCardType;
            }
        }
        public enterCardNum_Map enterCardNum_obj
        {
            get
            {
                if (enterCardNum == null)
                {
                    enterCardNum = new enterCardNum_Map();
                    enterCardNum.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterCardNum;
            }
        }
        public selectStartMnth_Map selectStartMnth_obj
        {
            get
            {
                if (selectStartMnth == null)
                {
                    selectStartMnth = new selectStartMnth_Map();
                    selectStartMnth.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectStartMnth;
            }
        }
        public selectStartYr_Map selectStartYr_obj
        {
            get
            {
                if (selectStartYr == null)
                {
                    selectStartYr = new selectStartYr_Map();
                    selectStartYr.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectStartYr;
            }
        }
        public selectExpiryMnth_Map selectExpiryMnth_obj
        {
            get
            {
                if (selectExpiryMnth == null)
                {
                    selectExpiryMnth = new selectExpiryMnth_Map();
                    selectExpiryMnth.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectExpiryMnth;
            }
        }
        public selectExpiryYr_Map selectExpiryYr_obj
        {
            get
            {
                if (selectExpiryYr == null)
                {
                    selectExpiryYr = new selectExpiryYr_Map();
                    selectExpiryYr.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return selectExpiryYr;
            }
        }
        public enterCVV_Map enterCVV_obj
        {
            get
            {
                if (enterCVV == null)
                {
                    enterCVV = new enterCVV_Map();
                    enterCVV.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enterCVV;
            }
        }
        public clickScrollPay_Map clickScrollPay_obj
        {
            get
            {
                if (clickScrollPay == null)
                {
                    clickScrollPay = new clickScrollPay_Map();
                    clickScrollPay.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickScrollPay;
            }
        }
        public clickPayBtn_Map clickPayBtn_obj
        {
            get
            {
                if (clickPayBtn == null)
                {
                    clickPayBtn = new clickPayBtn_Map();
                    clickPayBtn.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPayBtn;
            }
        }
        public verifyErrShownonPayPage_Map verifyErrShownonPayPage_obj
        {
            get
            {
                if (verifyErrShownonPayPage == null)
                {
                    verifyErrShownonPayPage = new verifyErrShownonPayPage_Map();
                    verifyErrShownonPayPage.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyErrShownonPayPage;
            }
        }
        public clickPayByPhoneBtn_Map clickPayByPhoneBtn_obj
        {
            get
            {
                if (clickPayByPhoneBtn == null)
                {
                    clickPayByPhoneBtn = new clickPayByPhoneBtn_Map();
                    clickPayByPhoneBtn.UIVillaPlusPaymentInteWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickPayByPhoneBtn;
            }
        }
        public enter3DPwd_Map enter3DPwd_obj
        {
            get
            {
                if (enter3DPwd == null)
                {
                    enter3DPwd = new enter3DPwd_Map();
                    enter3DPwd.UIMasterCardSecureCodeWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return enter3DPwd;
            }
        }
        public clickSubmitBtnVISAFrm3D_Map clickSubmitBtnVISAFrm3D_obj
        {
            get
            {
                if (clickSubmitBtnVISAFrm3D == null)
                {
                    clickSubmitBtnVISAFrm3D = new clickSubmitBtnVISAFrm3D_Map();
                    clickSubmitBtnVISAFrm3D.UIVerifiedbyVISAInternWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSubmitBtnVISAFrm3D;
            }
        }
        public clickSubmitBtnFrm3D_Map clickSubmitBtnFrm3D_obj
        {
            get
            {
                if (clickSubmitBtnFrm3D == null)
                {
                    clickSubmitBtnFrm3D = new clickSubmitBtnFrm3D_Map();
                    clickSubmitBtnFrm3D.UIMasterCardSecureCodeWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickSubmitBtnFrm3D;
            }
        }
        public clickCancellinkFrm3D_Map clickCancellinkFrm3D_obj
        {
            get
            {
                if (clickCancellinkFrm3D == null)
                {
                    clickCancellinkFrm3D = new clickCancellinkFrm3D_Map();
                    clickCancellinkFrm3D.UIMasterCardSecureCodeWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickCancellinkFrm3D;
            }
        }
        public verifyThankUPageOpened_Map verifyThankUPageOpened_obj
        {
            get
            {
                if (verifyThankUPageOpened == null)
                {
                    verifyThankUPageOpened = new verifyThankUPageOpened_Map();
                    verifyThankUPageOpened.UIVillaPlusThankYouIntWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyThankUPageOpened;
            }
        }
        public verifyVillaExtrasAvailable_Map verifyVillaExtrasAvailable_obj
        {
            get
            {
                if (verifyVillaExtrasAvailable == null)
                {
                    verifyVillaExtrasAvailable = new verifyVillaExtrasAvailable_Map();
                    verifyVillaExtrasAvailable.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyVillaExtrasAvailable;
            }
        }
        public clickVillaExtrasAll_Map clickVillaExtrasAll_obj
        {
            get
            {
                if (clickVillaExtrasAll == null)
                {
                    clickVillaExtrasAll = new clickVillaExtrasAll_Map();
                    clickVillaExtrasAll.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickVillaExtrasAll;
            }
        }
        public clickVillaExtrasAdded_Map clickVillaExtrasAdded_obj
        {
            get
            {
                if (clickVillaExtrasAdded == null)
                {
                    clickVillaExtrasAdded = new clickVillaExtrasAdded_Map();
                    clickVillaExtrasAdded.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickVillaExtrasAdded;
            }
        }
        public verifyVillaExtrasMinus_Map verifyVillaExtrasMinus_obj
        {
            get
            {
                if (verifyVillaExtrasMinus == null)
                {
                    verifyVillaExtrasMinus = new verifyVillaExtrasMinus_Map();
                    verifyVillaExtrasMinus.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyVillaExtrasMinus;
            }
        }
        public verifyHelpIconVillaExtras_Map verifyHelpIconVillaExtras_obj
        {
            get
            {
                if (verifyHelpIconVillaExtras == null)
                {
                    verifyHelpIconVillaExtras = new verifyHelpIconVillaExtras_Map();
                    verifyHelpIconVillaExtras.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyHelpIconVillaExtras;
            }
        }
        public verifyCarHireTextMessage_Map verifyCarHireTextMessage_obj
        {
            get
            {
                if (verifyCarHireTextMessage == null)
                {
                    verifyCarHireTextMessage = new verifyCarHireTextMessage_Map();
                    verifyCarHireTextMessage.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarHireTextMessage;
            }
        }
        public verifyCarsCategory_Map verifyCarsCategory_obj
        {
            get
            {
                if (verifyCarsCategory == null)
                {
                    verifyCarsCategory = new verifyCarsCategory_Map();
                    verifyCarsCategory.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarsCategory;
            }
        }
        public clickAddCarHireButton_Map clickAddCarHireButton_obj
        {
            get
            {
                if (clickAddCarHireButton == null)
                {
                    clickAddCarHireButton = new clickAddCarHireButton_Map();
                    clickAddCarHireButton.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickAddCarHireButton;
            }
        }
        public clickRemoveButton_Map clickRemoveButton_obj
        {
            get
            {
                if (clickRemoveButton == null)
                {
                    clickRemoveButton = new clickRemoveButton_Map();
                    clickRemoveButton.UIHttpmobstaging1villaWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickRemoveButton;
            }
        }
        public verifyCarHireCategory_Map verifyCarHireCategory_obj
        {
            get
            {
                if (verifyCarHireCategory == null)
                {
                    verifyCarHireCategory = new verifyCarHireCategory_Map();
                    verifyCarHireCategory.UIHttpmobstaging1villaWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarHireCategory;
            }
        }
        public verifyCarFeatures_Map verifyCarFeatures_obj
        {
            get
            {
                if (verifyCarFeatures == null)
                {
                    verifyCarFeatures = new verifyCarFeatures_Map();
                    verifyCarFeatures.UIHttpsmvillapluscomboWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarFeatures;
            }
        }
        public verifyCarConfirm_Map verifyCarConfirm_obj
        {
            get
            {
                if (verifyCarConfirm == null)
                {
                    verifyCarConfirm = new verifyCarConfirm_Map();
                    verifyCarConfirm.UIHttpmobstaging1villaWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarConfirm;
            }
        }
        public verifyCarSelection_Map verifyCarSelection_obj
        {
            get
            {
                if (verifyCarSelection == null)
                {
                    verifyCarSelection = new verifyCarSelection_Map();
                    verifyCarSelection.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyCarSelection;
            }
        }
        public verifyTransferSection_Map verifyTransferSection_obj
        {
            get
            {
                if (verifyTransferSection == null)
                {
                    verifyTransferSection = new verifyTransferSection_Map();
                    verifyTransferSection.UIHolidayExtrasVillaPlWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyTransferSection;
            }
        }
    }
}
