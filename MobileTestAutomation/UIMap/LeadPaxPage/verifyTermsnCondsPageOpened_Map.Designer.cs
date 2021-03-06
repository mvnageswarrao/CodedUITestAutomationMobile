﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.LeadPaxPage.verifyTermsnCondsPageOpened_MapClasses
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
    public partial class verifyTermsnCondsPageOpened_Map:logWriter
    {
        public void verifyTermsnCondsPageOpened_Method()
        {
            #region Variable Declarations
            HtmlDiv uITermsConditionsPane = this.UIVillaPlusBookingTermWindow.UIVillaPlusBookingTermDocument.UITermsConditionsPane;
            #endregion
            try
            {
                Boolean isTermsOpened = uITermsConditionsPane.TryFind();
                if (isTermsOpened == true)
                {
                    Assert.AreEqual(this.verifyTermsnCondsPageOpened_MethodExpectedValues.UITermsConditionsPaneInnerText.Trim(), uITermsConditionsPane.InnerText.Trim());
                }
                WriteLogs("PASS : \"Terms & Conditions\" Page is Opened.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT open \"Terms & Conditions\" Page.");
                WriteLogs("--------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyTermsnCondsPageOpened_MethodExpectedValues verifyTermsnCondsPageOpened_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTermsnCondsPageOpened_MethodExpectedValues == null))
                {
                    this.mverifyTermsnCondsPageOpened_MethodExpectedValues = new verifyTermsnCondsPageOpened_MethodExpectedValues();
                }
                return this.mverifyTermsnCondsPageOpened_MethodExpectedValues;
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
        private verifyTermsnCondsPageOpened_MethodExpectedValues mverifyTermsnCondsPageOpened_MethodExpectedValues;
        
        private UIVillaPlusBookingTermWindow mUIVillaPlusBookingTermWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTermsnCondsPageOpened_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyTermsnCondsPageOpened_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Terms & Conditions' pane equals 'Terms & Conditions'
        /// </summary>
        public string UITermsConditionsPaneInnerText = "Terms & Conditions";
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
        public HtmlDiv UITermsConditionsPane
        {
            get
            {
                if ((this.mUITermsConditionsPane == null))
                {
                    this.mUITermsConditionsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUITermsConditionsPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Terms & Conditions ";
                    this.mUITermsConditionsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "docked-top";
                    this.mUITermsConditionsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"docked-top\"";
                    this.mUITermsConditionsPane.WindowTitles.Add("Villa Plus | Booking Terms and Conditions");
                    #endregion
                }
                return this.mUITermsConditionsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUITermsConditionsPane;
        #endregion
    }
}
