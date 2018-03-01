namespace MobileTestAutomation.UIMap.ExtrasPage.verifyHelpIconVillaExtras_MapClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using MobileTestAutomation.Utility;


    public partial class verifyHelpIconVillaExtras_Map : logWriter
    {

        string verifyStarterPackText = "Our Starter pack is designed to provide basic necessities and sufficient food for a light snack. Included are items such as milk, bread, tea and coffee, juice, pasta, tomato pasta sauce, mineral water and a bottle of wine. Matches and washing up liquid are also included. In all villas a small supply of toilet rolls is automatically supplied, these items can vary from destination to destination, and are subject to availability. The Starter packs are sufficient for 1-5.";
        string verifyCotsText = "Travel cots and linen provided. Linen is supplied. Should any person in your party have allergies to washing substances, please bring your own.";
        string verifyHighChairtext = "High chairs are provided at no extra charge for package holidays, however there is a charge if booking a villa rental only. Our high chairs all meet EU standards.";
        string verifyZBedtext = "If required this is a camp style bed and is suitable for children up to the age of 15 years.";
        string verifyChildGatestext = "Childgates are like stairgates and can be used on some stairways and doorways in your chosen villa depending on the width and/or gradient of walls etc. Childgates can be requested although it is your responsibility to install them in the villa.";
        string verifyRemovablePoolFencetext = "Removable Pool Fences|If you have ordered an optional pool safety fence in a villa where this facility is available, we will endeavour to have it installed prior to your arrival. Occasionally local conditions may not make this possible and a pool fence may be installed after you have arrived - but still on the same day. On very rare occasions it may be installed the following day. Pool fences have gates that are either lockable and/or fitted with a latch or some form of closing mechanism. Gates should never be left open or propped open at any time.&lt;br/>&lt;br/>Where pool fences are installed, we will always endeavour to ensure that the installation has been performed with reasonable skill and care. This does not negate your responsibility to ensure that this facility is suitable and safe for use during your occupation of the villa. You will not be charged for any accidental damage caused to either the pool fence or gate but it is a condition of booking that you must report any damage, Failing or concern to our local resort office immediately.&lt;br/>&lt;br/>Should a problem arise with your villa prior to arrival, we will offer you an alternative villa, if we are not able to provide that villa with some form of pool fence or alarm, you are entitled to cancel your holiday and receive a full refund of all monies paid. Should a problem arise with your villa during your stay that requires you to have to move to an alternative villa, we will do our best to provide you with a villa that has a gated / fenced pool, or an alarm, but under these extremely rare circumstances this may not be possible.";
        /// <summary>
        /// ClickHelpIconVillaExtras_Method
        /// </summary>
        /// 
        string expectedHeader = "";

        public HtmlImage ClickHelpIconcounts_Method()
        {
            #region Variable Declarations
            HtmlImage uIClickhereforinformatImage = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIPanVillaExtrasCustom.UIClickhereforinformatImage;
            #endregion
            return uIClickhereforinformatImage;
        }

        public void ClickHelpIconVillaExtras_Method(HtmlImage TotalControls)
        {
            //Click 'click here for information' image
            Mouse.Click(TotalControls);
        }
        /// <summary>
        /// verifyVillaExtrasHeaderText_Method - Use 'verifyVillaExtrasHeaderText_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyVillaExtrasHeaderText_Method()
        {
            #region Variable Declarations
            HtmlCustom uIStarterPackCustom = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIHolidayExtrasCustom1.UIStarterPackCustom;
            #endregion

            string VillaExtraNamePage = uIStarterPackCustom.InnerText;
            string verifyVillaExtraHeader = string.Empty;
            verifyVillaExtraHeader = VillaExtraNamePage;
            expectedHeader = getExpectedVillaExtrasName(verifyVillaExtraHeader);
            try
            {
                StringAssert.Equals(verifyVillaExtraHeader, expectedHeader);
                WriteLogs("PASS : Villa Extras Heading is Matched - " + verifyVillaExtraHeader);
            }
            catch (Exception ex)
            {
                WriteLogs("PASS : Villa Extras Heading is not Matched - " + verifyVillaExtraHeader);
                WriteLogs("------" + ex.Message.ToString());
            }
        }

        public string getExpectedVillaExtrasName(string verifyVillaExtraHeader)
        {
            string expectedHeader = string.Empty;
            switch (verifyVillaExtraHeader)
            {
                case "Starter Pack": expectedHeader = "Starter Pack";
                    break;
                case "Cots": expectedHeader = "Cots";
                    break;
                case "Child Gates": expectedHeader = "Child Gates";
                    break;
                case "Z-Beds": expectedHeader = "Z-Beds";
                    break;
                case "Removable Pool Fence": expectedHeader = "Removable pool Fence";
                    break;
                case "High Chairs": expectedHeader = "High Chairs";
                    break;
                default:
                    break;
            }
            return expectedHeader;
        }

        public void verifyVillaExtrasText_Method()
        {
            #region Variable Declarations
            HtmlCustom uIOurStarterpackisdesiCustom2 = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIHolidayExtrasCustom1.UIOurStarterpackisdesiCustom2;
            #endregion
            string villaExtrasText = string.Empty;
            villaExtrasText = uIOurStarterpackisdesiCustom2.InnerText;

            string exptext = getExpectedVillaExtrasTexts(expectedHeader);
            try
            {
                StringAssert.Equals(villaExtrasText, exptext);
                WriteLogs("PASS : Text displayed on the webpage is matched" + exptext);
            }
            catch (Exception ex)
            {
                WriteLogs("PASS : Text displayed on the webpage is not matched" + exptext);
                WriteLogs("-----" + ex.Message.ToString());
            }
        }

        public string getExpectedVillaExtrasTexts(string expectedHeader)
        {
            string expectedTexts = string.Empty;
            switch (expectedHeader)
            {
                case "Starter Pack": expectedTexts = verifyStarterPackText;
                    break;
                case "Cots": expectedTexts = verifyCotsText;
                    break;
                case "Child Gates": expectedTexts = verifyChildGatestext;
                    break;
                case "Z-Beds": expectedTexts = verifyZBedtext;
                    break;
                case "Removable Pool Fence": expectedTexts = verifyRemovablePoolFencetext;
                    break;
                case "High Chairs": expectedTexts = verifyHighChairtext;
                    break;
                default:
                    break;
            }
            return expectedTexts;
        }

        public void ClickClosebuttonHelpIcon_Method()
        {
            #region Variable Declarations
            HtmlImage uIClosedialogImage1 = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIClosedialogImage1;
            #endregion

            HtmlDocument closeBut = new HtmlDocument(this.UIHolidayExtrasVillaPlWindow);
            HtmlDiv IdenCloseButt = new HtmlDiv(closeBut);
            IdenCloseButt.SearchProperties[HtmlDiv.PropertyNames.Class] = "infoBoxContent lightbox";
            HtmlImage clickClose = new HtmlImage(IdenCloseButt);
            clickClose.SearchProperties[HtmlImage.PropertyNames.Id] = "btnCloseInfoBox";

            var clickaction = clickClose.BoundingRectangle;
            Point clickCloseT = new Point();
            clickCloseT = new Point(clickaction.X, clickaction.Y);

            try
            {
                Mouse.Move(clickCloseT);
                Mouse.Click(clickCloseT);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
