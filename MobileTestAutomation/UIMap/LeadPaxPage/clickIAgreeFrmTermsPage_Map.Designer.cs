﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.LeadPaxPage.clickIAgreeFrmTermsPage_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class clickIAgreeFrmTermsPage_Map:logWriter
    {
        public void clickIAgreeFrmTermsPage_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIIAgreeHyperlink = this.UIVillaPlusBookingTermWindow.UIVillaPlusBookingTermDocument.UIIAgreeHyperlink;
            #endregion
            try
            {
                Mouse.Click(uIIAgreeHyperlink, new Point(684, 17));
                WriteLogs("PASS : Clicked \"I Agree\" Button For Booking Conditions.  : VERIFICATION");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT Click \"I Agree\" Button.");
                WriteLogs("--------" + ex.Message.ToString());
            }
        }
        
        #region Properties
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
        private UIVillaPlusBookingTermWindow mUIVillaPlusBookingTermWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
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
        public HtmlHyperlink UIIAgreeHyperlink
        {
            get
            {
                if ((this.mUIIAgreeHyperlink == null))
                {
                    this.mUIIAgreeHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIIAgreeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "btnTermsContinue";
                    this.mUIIAgreeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "I Agree";
                    this.mUIIAgreeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/booking-terms-and-conditions";
                    this.mUIIAgreeHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/booking-terms-and-conditions", PropertyExpressionOperator.Contains));
                    this.mUIIAgreeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "btn bg-green";
                    this.mUIIAgreeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"btn bg-green\" id=\"btnTermsContinu";
                    this.mUIIAgreeHyperlink.WindowTitles.Add("Villa Plus | Booking Terms and Conditions");
                    #endregion
                }
                return this.mUIIAgreeHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIIAgreeHyperlink;
        #endregion
    }
}
