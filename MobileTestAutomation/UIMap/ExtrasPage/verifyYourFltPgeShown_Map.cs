namespace MobileTestAutomation.UIMap.ExtrasPage.verifyYourFltPgeShown_MapClasses
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

    public partial class verifyYourFltPgeShown_Map
    {
        public bool verifyYourFltPgeShown_Method()
        {
            #region Variable Declarations
            HtmlDiv uIYourFlightPane = this.UIVillaPlusCustomerFliWindow.UIVillaPlusCustomerFliDocument.UIFrmSaveCustFlightCustom.UIYourFlightPane;
            #endregion
            bool IsPageExists = false;
            try
            {
                IsPageExists = uIYourFlightPane.Exists;
                Assert.AreEqual(this.verifyYourFltPgeShown_MethodExpectedValues.UIYourFlightPaneInnerText, uIYourFlightPane.InnerText);
                WriteLogs("PASS : \"Your Flight\" Page is Opened.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT Open \"Your Flight\".");
                WriteLogs("--------" + ex.Message.ToString());
            }
            return IsPageExists;
        }
    }
}
