using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;
using MobileTestAutomation.UIMap.Generic.EnterURL_MapClasses;
using MobileTestAutomation.UIMap.HomePage.verifyIncompleteBkgPopupDisplay_MapClasses;
using MobileTestAutomation.UIMap.HomePage.clickNOFrmIncomBkgPopup_MapClasses;
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
using MobileTestAutomation.UIMap.SearchResultsPage.clickABTAFrmFooter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickATOLFrmFooter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickExitToDesktop_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickZolvlink_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.verifySRCAirport_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickFilterBy_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickScrollFrmFilters_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickApplyFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickClearFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickPlusForFilter_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickFilterName_MapClasses;
using MobileTestAutomation.UIMap.SearchResultsPage.clickChkBoxFrmFilters_MapClasses;

namespace MobileTestAutomation.Utility
{
    public class InitiateSearchPage
    {
        private openBrowser_Map OpenBrowser = null;
        private EnterURL_Map EnterURL = null;
        private verifyIncompleteBkgPopupDisplay_Map verifyIncompleteBkgPopupDisplay = null;
        private clickNOFrmIncomBkgPopup_Map clickNOFrmIncomBkgPopup = null;
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
		private verifySRCAirport_Map verifySRCAirport = null;
        private verifySearchCriteriaDisplay_Map verifySearchCriteriaDisplay = null;
        private clickVillaNameLink_Map clickVillaNameLink = null;
        private verifyProductPagedisplay_Map verifyProductPagedisplay = null;
        private clickMoreInfoBtn_Map clickMoreInfoBtn = null;
        private clickBackSearchLayer_Map clickBackSearchLayer = null;
        private clickBackFrmPrdctPage_Map clickBackFrmPrdctPage = null;
        private clickShowMoreResultsBtn_Map clickShowMoreResultsBtn = null;
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
        private clickPlusForFilter_Map clickPlusForFilter = null;
        private clickFilterName_Map clickFilterName = null;
        private clickScrollFrmFilters_Map clickScrollFrmFilters = null;
        private clickChkBoxFrmFilters_Map clickChkBoxFrmFilters = null;
        private clickABTAFrmFooter_Map clickABTAFrmFooter = null;
        private clickATOLFrmFooter_Map clickATOLFrmFooter = null;
        private clickExitToDesktop_Map clickExitToDesktop = null;
        private clickZolvlink_Map clickZolvlink = null;

        public InitiateSearchPage()
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
                    verifySRCAirport.UIYoursearchfound7VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
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
        public clickScrollFrmFilters_Map clickScrollFrmFilters_obj
        {
            get
            {
                if (clickScrollFrmFilters == null)
                {
                    clickScrollFrmFilters = new clickScrollFrmFilters_Map();
                    clickScrollFrmFilters.UIYoursearchfound37VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickScrollFrmFilters;
            }
        }
        public clickChkBoxFrmFilters_Map clickChkBoxFrmFilters_obj
        {
            get
            {
                if (clickChkBoxFrmFilters == null)
                {
                    clickChkBoxFrmFilters = new clickChkBoxFrmFilters_Map();
                    clickChkBoxFrmFilters.UIYoursearchfound1VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickChkBoxFrmFilters;
            }
        }
        public clickABTAFrmFooter_Map clickABTAFrmFooter_obj
        {
            get
            {
                if (clickABTAFrmFooter == null)
                {
                    clickABTAFrmFooter = new clickABTAFrmFooter_Map();
                    clickABTAFrmFooter.UIYoursearchfound11VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickABTAFrmFooter;
            }
        }
        public clickATOLFrmFooter_Map clickATOLFrmFooter_obj
        {
            get
            {
                if (clickATOLFrmFooter == null)
                {
                    clickATOLFrmFooter = new clickATOLFrmFooter_Map();
                    clickATOLFrmFooter.UIYoursearchfound11VilWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickATOLFrmFooter;
            }
        }
        public clickExitToDesktop_Map clickExitToDesktop_obj
        {
            get
            {
                if (clickExitToDesktop == null)
                {
                    clickExitToDesktop = new clickExitToDesktop_Map();
                    clickExitToDesktop.UIYoursearchfound1VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickExitToDesktop;
            }
        }
        public clickZolvlink_Map clickZolvlink_obj
        {
            get
            {
                if (clickZolvlink == null)
                {
                    clickZolvlink = new clickZolvlink_Map();
                    clickZolvlink.UIYoursearchfound1VillWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickZolvlink;
            }
        }




        
    }
}
