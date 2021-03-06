﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.GroupDetailsPage.verifyExtrasPageDisplayed_MapClasses
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
    public partial class verifyExtrasPageDisplayed_Map:logWriter
    {
        
        /// <summary>
        /// verifyExtrasPageDisplayed_Method - Use 'verifyExtrasPageDisplayed_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyExtrasPageDisplayed_Method()
        {
            #region Variable Declarations
            HtmlCustom uIPanVillaExtrasCustom = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIPanVillaExtrasCustom;
            #endregion
            try
            {
                StringAssert.Contains(uIPanVillaExtrasCustom.InnerText, this.verifyExtrasPageDisplayed_MethodExpectedValues.UIPanVillaExtrasCustomInnerText);
                WriteLogs("PASS : Extra Page is Opened. : VERIFICATION");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could Not Open Extra Page." + ex.ToString());
            }
        }
        
        #region Properties
        public virtual verifyExtrasPageDisplayed_MethodExpectedValues verifyExtrasPageDisplayed_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyExtrasPageDisplayed_MethodExpectedValues == null))
                {
                    this.mverifyExtrasPageDisplayed_MethodExpectedValues = new verifyExtrasPageDisplayed_MethodExpectedValues();
                }
                return this.mverifyExtrasPageDisplayed_MethodExpectedValues;
            }
        }
        
        public UIHolidayExtrasVillaPlWindow UIHolidayExtrasVillaPlWindow
        {
            get
            {
                if ((this.mUIHolidayExtrasVillaPlWindow == null))
                {
                    this.mUIHolidayExtrasVillaPlWindow = new UIHolidayExtrasVillaPlWindow();
                }
                return this.mUIHolidayExtrasVillaPlWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyExtrasPageDisplayed_MethodExpectedValues mverifyExtrasPageDisplayed_MethodExpectedValues;
        
        private UIHolidayExtrasVillaPlWindow mUIHolidayExtrasVillaPlWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyExtrasPageDisplayed_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyExtrasPageDisplayed_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'panVillaExtras' custom control contains 'Villa Extras'
        /// </summary>
        public string UIPanVillaExtrasCustomInnerText = "Villa Extras";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHolidayExtrasVillaPlWindow : BrowserWindow
    {
        
        public UIHolidayExtrasVillaPlWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Holiday Extras | Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Holiday Extras | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHolidayExtrasVillaPlDocument UIHolidayExtrasVillaPlDocument
        {
            get
            {
                if ((this.mUIHolidayExtrasVillaPlDocument == null))
                {
                    this.mUIHolidayExtrasVillaPlDocument = new UIHolidayExtrasVillaPlDocument(this);
                }
                return this.mUIHolidayExtrasVillaPlDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHolidayExtrasVillaPlDocument mUIHolidayExtrasVillaPlDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHolidayExtrasVillaPlDocument : HtmlDocument
    {
        
        public UIHolidayExtrasVillaPlDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Holiday Extras | Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/Extras/ShowExtras", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/Extras/ShowExtras", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Holiday Extras | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIPanVillaExtrasCustom
        {
            get
            {
                if ((this.mUIPanVillaExtrasCustom == null))
                {
                    this.mUIPanVillaExtrasCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIPanVillaExtrasCustom.SearchProperties["TagName"] = "SECTION";
                    this.mUIPanVillaExtrasCustom.SearchProperties["Id"] = "panVillaExtras";
                    this.mUIPanVillaExtrasCustom.FilterProperties["Class"] = "booking-step";
                    this.mUIPanVillaExtrasCustom.FilterProperties["ControlDefinition"] = "class=\"booking-step\" id=\"panVillaExtras\"";
                    this.mUIPanVillaExtrasCustom.WindowTitles.Add("Holiday Extras | Villa Plus");
                    #endregion
                }
                return this.mUIPanVillaExtrasCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIPanVillaExtrasCustom;
        #endregion
    }
}
