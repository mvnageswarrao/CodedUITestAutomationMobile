using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;
using MobileTestAutomation.UIMap.Generic.EnterURL_MapClasses ;
using MobileTestAutomation.UIMap.HomePage.ClickSearchButton_MapClasses;
using MobileTestAutomation.UIMap.HomePage.ClickBrowserVillaButton_MapClasses;
using MobileTestAutomation.UIMap.HomePage.clickBrowseDestination_MapClasses;
using MobileTestAutomation.UIMap.Footer.ClickUsefullinkplus_MapClasses;
using MobileTestAutomation.UIMap.HomePage.clickwhyvp_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickFaqLink_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickContactUs_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickUsefullinkMinus_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickAbta_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickAtollink_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickZolvLink_MapClasses;
using MobileTestAutomation.UIMap.Footer.clickDesktopLink_MapClasses;
using MobileTestAutomation.UIMap.Footer.verfiyYearImg_MapClasses;
using MobileTestAutomation.UIMap.Footer.verifyFooterText_MapClasses;
using MobileTestAutomation.UIMap.HomePage.VerfiyBannerImages_MapClasses;
using MobileTestAutomation.UIMap.HomePage.verifyHomePageText_MapClasses;
using MobileTestAutomation.UIMap.Header.clickMenuLink_MapClasses;
using MobileTestAutomation.UIMap.Header.clickHeadSearchLink_MapClasses;
using MobileTestAutomation.UIMap.Header.clickHeaderLogo_MapClasses;

namespace MobileTestAutomation.Utility
{

    public class InitiateHomePage
    {

        private openBrowser_Map OpenBrowser = null;
        private EnterURL_Map EnterURL = null;
        private ClickSearchButton_Map ClickSearchButton = null;
        private ClickBrowserVillaButton_Map ClickBrowserVillaButton = null;
        private clickBrowseDestination_Map clickBrowseDestination = null;
        private ClickUsefullinkplus_Map ClickUsefullinkplus = null;
        private clickwhyvp_Map clickwhyvp = null;
        private clickFaqLink_Map clickFaqLink = null;
        private clickContactUs_Map clickContactus = null;
        private clickUsefullinkMinus_Map clickUsefullinkMinus = null;
        private clickAbta_Map clickAbta = null;
        private clickAtollink_Map clickAtollink = null;
        private clickZolvLink_Map clickZolv = null;
        private clickDesktopLink_Map clickDesktoplink = null;
        private verfiyYearImg_Map verfiyYearImg = null;
        private verifyFooterText_Map verifyFooterText = null;
        private VerfiyBannerImages_Map VerfiyBannerImages = null;
        private verifyHomePageText_Map verifyHomePageText = null;
        private clickMenuLink_Map clickMenuLink = null;
        private clickHeadSearchLink_Map clickHeadSearchLink = null;
        private clickHeaderLogo_Map clickHeaderLogo = null;


        public InitiateHomePage()
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

        public ClickSearchButton_Map clickSearchButton_Obj
        {
            get
            {
                if (ClickSearchButton == null)
                {
                    ClickSearchButton = new ClickSearchButton_Map();
                    ClickSearchButton.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return ClickSearchButton;
            }

        }

        public ClickBrowserVillaButton_Map ClickBrowserVillaButton_obj
        {
            get
            {
                if (ClickBrowserVillaButton == null)
                {
                    ClickBrowserVillaButton = new ClickBrowserVillaButton_Map();
                    ClickBrowserVillaButton.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return ClickBrowserVillaButton;
            }

        }

        public clickBrowseDestination_Map clickBrowseDestination_obj
        {
            get
            {
                if (clickBrowseDestination == null)
                {
                    clickBrowseDestination = new clickBrowseDestination_Map();
                    clickBrowseDestination.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return clickBrowseDestination;
            }
        }

        public ClickUsefullinkplus_Map ClickUsefullinkplus_obj
        {
            get
            {
                if (ClickUsefullinkplus == null)
                {
                    ClickUsefullinkplus = new ClickUsefullinkplus_Map();
                    ClickUsefullinkplus.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return ClickUsefullinkplus;
            }
        }

        public clickwhyvp_Map clickwhyvp_obj
        {
            get
            {
                if (clickwhyvp == null)
                {
                    clickwhyvp = new clickwhyvp_Map();
                    clickwhyvp.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return clickwhyvp;
            }
        }


        public clickFaqLink_Map clickFaqLink_obj
        {
            get
            {
                if (clickFaqLink == null)
                {
                    clickFaqLink = new clickFaqLink_Map();
                    clickFaqLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickFaqLink;
            }
        }

        public clickContactUs_Map clickContactus_obj
        {
            get
            {
                if (clickContactus == null)
                {
                    clickContactus = new clickContactUs_Map();
                    clickContactus.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickContactus;
            }

        }

        public clickUsefullinkMinus_Map clickUsefullinkMinus_obj
        {
            get
            {
                if (clickUsefullinkMinus == null)
                {
                    clickUsefullinkMinus = new clickUsefullinkMinus_Map();
                    clickUsefullinkMinus.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickUsefullinkMinus;
            }
        }

        public clickAbta_Map clickAbta_obj
        {
            get
            {
                if (clickAbta == null)
                {
                    clickAbta = new clickAbta_Map();
                    clickAbta.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickAbta;
            }

        }

        public clickAtollink_Map clickAtollink_obj
        {
            get
            {
                if (clickAtollink == null)
                {
                    clickAtollink = new clickAtollink_Map();
                    clickAtollink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickAtollink;
            }
        }

        public clickZolvLink_Map clickZolv_obj
        {
            get
            {
                if (clickZolv == null)
                {
                    clickZolv = new clickZolvLink_Map();
                    clickZolv.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return clickZolv;
            }
        }

        public clickDesktopLink_Map clickDesktopLink_obj
        {
            get
            {
                if (clickDesktoplink == null)
                {
                    clickDesktoplink = new clickDesktopLink_Map();
                    clickDesktoplink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickDesktoplink;
            }
        }

        public verfiyYearImg_Map verfiyYearImg_obj
        {
            get
            {
                if (verfiyYearImg == null)
                {
                    verfiyYearImg = new verfiyYearImg_Map();
                    verfiyYearImg.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verfiyYearImg;
            }
        }

        public verifyFooterText_Map verifyFooterText_obj
        {
            get
            {
                if (verifyFooterText == null)
                {
                    verifyFooterText = new verifyFooterText_Map();
                    verifyFooterText.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyFooterText;
            }
        }

        public VerfiyBannerImages_Map VerfiyBannerImages_obj
        {
            get
            {
                if (VerfiyBannerImages == null)
                {
                    VerfiyBannerImages = new VerfiyBannerImages_Map();
                    VerfiyBannerImages.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);

                }
                return VerfiyBannerImages;
            }
        }

        public verifyHomePageText_Map verifyHomePageText_obj
        {
            get
            {
                if (verifyHomePageText == null)
                {
                    verifyHomePageText = new verifyHomePageText_Map();
                    verifyHomePageText.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return verifyHomePageText;
                            }
        }

        public clickMenuLink_Map clickMenuLink_obj
        {
            get
            {
                if (clickMenuLink == null)
                {
                    clickMenuLink = new clickMenuLink_Map();
                    clickMenuLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                }
                return clickMenuLink;
            }
        }

        public clickHeadSearchLink_Map clickHeadSearchLink_obj
        {
            get
            {
                if (clickHeadSearchLink == null)
                {
                    clickHeadSearchLink = new clickHeadSearchLink_Map();
                    clickHeadSearchLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UINewTabWindowsInterneWindow);
                                    }
                return clickHeadSearchLink;
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
    
    }
    }