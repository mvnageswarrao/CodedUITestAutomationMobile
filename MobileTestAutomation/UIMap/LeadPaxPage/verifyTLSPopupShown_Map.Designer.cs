﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.LeadPaxPage.verifyTLSPopupShown_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using MobileTestAutomation.Utility;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class verifyTLSPopupShown_Map:logWriter
    {
        public bool verifyTLSPopupShown_Method()
        {
            #region Variable Declarations
            HtmlDiv uIGrpDetailsPopUpPane = this.UIVillaPlusBookingTermWindow.UIVillaPlusBookingTermDocument.UIGrpDetailsPopUpPane;
            #endregion
            Boolean IsTLSOpened = false;
            string TxtFrmPage = uIGrpDetailsPopUpPane.InnerText.Trim();
            string ExpTxt = "Complete Your Booking";
            try
            {
                IsTLSOpened = uIGrpDetailsPopUpPane.TryFind();
                StringAssert.Contains(TxtFrmPage, ExpTxt);
                WriteLogs("INFO : \"TLS Popup\" is Opened. : VERIFICATION");
            }
            catch (Exception)
            {
                IsTLSOpened = false;
                WriteLogs("INFO : \"TLS Popup\" is Not Opened.");
            }
            return IsTLSOpened;
        }
        
        #region Properties
        public virtual verifyTLSPopupShown_MethodExpectedValues verifyTLSPopupShown_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTLSPopupShown_MethodExpectedValues == null))
                {
                    this.mverifyTLSPopupShown_MethodExpectedValues = new verifyTLSPopupShown_MethodExpectedValues();
                }
                return this.mverifyTLSPopupShown_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusBookingTermWindow UIVillaPlusBookingTermWindow
        {
            get
            {
                if ((this.mUIVillaPlusBookingTermWindow == null))
                {
                    this.mUIVillaPlusBookingTermWindow = new UIVillaPlusBookingTermWindow();
                }
                return this.mUIVillaPlusBookingTermWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyTLSPopupShown_MethodExpectedValues mverifyTLSPopupShown_MethodExpectedValues;
        
        private UIVillaPlusBookingTermWindow mUIVillaPlusBookingTermWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTLSPopupShown_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class verifyTLSPopupShown_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'GrpDetailsPopUp' pane contains ' 
        ///
        ///
        ///Complete Your Booking
        ///
        ///
        ///
        ///
        ///We have noticed that in order to continue with your booking, you need to update the security settings on your internet browser.
        ///
        ///
        ///Don't worry. we are here to help! By following step by step instructions on the next page you will able to switch it on.
        ///
        ///
        ///Alternatively, you can click on the pay by phone button and complete your holiday booking.
        ///
        ///
        ///
        ///
        ///
        ///
        /// In order to update your internet browser security,Please Complete the following steps
        ///
        ///Step:1
        ///
        ///Click on Settings and then go to Internet Options 
        /// 
        ///
        ///Step:2
        ///
        ///Click on the Advanced Tab (i.e. Highlighted with red) within the Internet Options window.
        /// 
        ///
        ///Step:3
        ///
        ///Scroll down in the “Advanced Tab” and select “TLS 1.1” and “TLS 1.2”  window.
        /// 
        ///
        ///Step:4
        ///
        ///Click on “Apply” in the Internet Options tab. 
        /// 
        ///
        ///Step:5
        ///
        ///Your browser security is now up to date and you can complete your booking
        ///
        ///Step:6
        ///
        ///Your booking can be completed by Clicking the "Pay Online" Button below'
        /// </summary>
        public string UIGrpDetailsPopUpPaneDisplayText = @" 


Complete Your Booking




We have noticed that in order to continue with your booking, you need to update the security settings on your internet browser.


Don't worry. we are here to help! By following step by step instructions on the next page you will able to switch it on.


Alternatively, you can click on the pay by phone button and complete your holiday booking.






 In order to update your internet browser security,Please Complete the following steps

Step:1

Click on Settings and then go to Internet Options 
 

Step:2

Click on the Advanced Tab (i.e. Highlighted with red) within the Internet Options window.
 

Step:3

Scroll down in the “Advanced Tab” and select “TLS 1.1” and “TLS 1.2”  window.
 

Step:4

Click on “Apply” in the Internet Options tab. 
 

Step:5

Your browser security is now up to date and you can complete your booking

Step:6

Your booking can be completed by Clicking the ""Pay Online"" Button below";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIVillaPlusBookingTermWindow : BrowserWindow
    {
        
        public UIVillaPlusBookingTermWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus | Booking Terms and Conditions");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusBookingTermDocument UIVillaPlusBookingTermDocument
        {
            get
            {
                if ((this.mUIVillaPlusBookingTermDocument == null))
                {
                    this.mUIVillaPlusBookingTermDocument = new UIVillaPlusBookingTermDocument(this);
                }
                return this.mUIVillaPlusBookingTermDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusBookingTermDocument mUIVillaPlusBookingTermDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIVillaPlusBookingTermDocument : HtmlDocument
    {
        
        public UIVillaPlusBookingTermDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking-terms-and-conditions", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking-terms-and-conditions", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Booking Terms and Conditions");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIGrpDetailsPopUpPane
        {
            get
            {
                if ((this.mUIGrpDetailsPopUpPane == null))
                {
                    this.mUIGrpDetailsPopUpPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIGrpDetailsPopUpPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "GrpDetailsPopUp";
                    this.mUIGrpDetailsPopUpPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Complete Your Booking", PropertyExpressionOperator.Contains));
                    this.mUIGrpDetailsPopUpPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "infoBoxContent lightbox grpdetailsdocked-top";
                    this.mUIGrpDetailsPopUpPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"infoBoxContent lightbox grpdetailsdocked-top\" id=\"GrpDetailsPopUp\" data-in" +
                        "fobox=\"info-default\"";
                    this.mUIGrpDetailsPopUpPane.WindowTitles.Add("Villa Plus | Booking Terms and Conditions");
                    #endregion
                }
                return this.mUIGrpDetailsPopUpPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIGrpDetailsPopUpPane;
        #endregion
    }
}
