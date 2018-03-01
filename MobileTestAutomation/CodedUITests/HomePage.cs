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

namespace MobileTestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class HomePage:logWriter
    {
        public HomePage()
        {
        }

        [TestMethod]
        public void MobileHomePageVerification()
        {

//            string strURL = ("http://m.villaplus.com");
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();

             
            InitiateHomePage runscript = new InitiateHomePage();
            WriteLogs("########## START ########## Home Page : " + DateTime.Now.ToString() + "##########");

            runscript.OpenBrowser_Obj.OpenBrowser_Method();
            runscript.EnterURL_Obj.EnterURL_Method(strURL);
            runscript.clickMenuLink_obj.clickMenuLink_Method();
            runscript.clickHeadSearchLink_obj.clickHeadSearchLink_Method();
            runscript.clickHeaderLogo_obj.clickHeaderLogo_Method(strURL);
            //runscript.clickAbta_obj.clickAbta_Method();
            //runscript.clickAtollink_obj.clickAtollink_Method();
            //runscript.clickZolv_obj.clickZolvLink_Method();  
            //runscript.clickDesktopLink_obj.clickDesktopLink_Method();
            //runscript.verfiyYearImg_obj.verfiyYearImg_Method();
            //runscript.verifyFooterText_obj.verifyFooterText_Method();
            //runscript.VerfiyBannerImages_obj.VerfiyBannerImages_Method();
            //runscript.verifyHomePageText_obj.verifyHomePageText_Method();
            //runscript.clickSearchButton_Obj.ClickSearchButton_Method();
            //runscript.ClickBrowserVillaButton_obj.ClickBrowserVillaButton_Method();
            //runscript.clickBrowseDestination_obj.clickBrowseDestination_Method();
            //runscript.EnterURL_Obj.EnterURL_Method(strURL);
            //runscript.ClickUsefullinkplus_obj.ClickUsefullinkplus_Method();
           // WaitForReadyLevel(500);
            //runscript.clickUsefullinkMinus_obj.clickUsefullinkMinus_Method();
           // runscript.clickwhyvp_obj.clickwhyvp_Method();
            //runscript.clickFaqLink_obj.clickFaqLink_Method();
            //runscript.ClickUsefullinkplus_obj.ClickUsefullinkplus_Method();
           // runscript.clickContactus_obj.clickContactus_Method(); 
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

        
        }

        private void WaitForReadyLevel(int p)
        {
            throw new NotImplementedException();
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
