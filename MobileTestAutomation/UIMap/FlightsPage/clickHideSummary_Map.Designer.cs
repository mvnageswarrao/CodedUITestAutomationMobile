﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.FlightsPage.clickHideSummary_MapClasses
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
    public partial class clickHideSummary_Map:logWriter
    {
        public void clickHideSummary_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIHideSummaryHyperlink = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIBookPane.UIHideSummaryHyperlink;
            #endregion
            try
            {
                Mouse.Click(uIHideSummaryHyperlink, new Point(692, 10));
                WriteLogs("PASS : \"Hide Summary\" is Clicked.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT Click \"Hide Summary\".");
                WriteLogs("--------" + ex.Message.ToString());
            }           
        }
        
        #region Properties
        public UIHttpmobstagingvillapWindow UIHttpmobstagingvillapWindow
        {
            get
            {
                if ((this.mUIHttpmobstagingvillapWindow == null))
                {
                    this.mUIHttpmobstagingvillapWindow = new UIHttpmobstagingvillapWindow();
                }
                return this.mUIHttpmobstagingvillapWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpmobstagingvillapWindow mUIHttpmobstagingvillapWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttpmobstagingvillapWindow : BrowserWindow
    {
        
        public UIHttpmobstagingvillapWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpmobstagingvillapDocument UIHttpmobstagingvillapDocument
        {
            get
            {
                if ((this.mUIHttpmobstagingvillapDocument == null))
                {
                    this.mUIHttpmobstagingvillapDocument = new UIHttpmobstagingvillapDocument(this);
                }
                return this.mUIHttpmobstagingvillapDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpmobstagingvillapDocument mUIHttpmobstagingvillapDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttpmobstagingvillapDocument : HtmlDocument
    {
        
        public UIHttpmobstagingvillapDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        #region Properties
        public UIBookPane UIBookPane
        {
            get
            {
                if ((this.mUIBookPane == null))
                {
                    this.mUIBookPane = new UIBookPane(this);
                }
                return this.mUIBookPane;
            }
        }
        #endregion
        
        #region Fields
        private UIBookPane mUIBookPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBookPane : HtmlDiv
    {
        
        public UIBookPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "book";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Yes", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"book\"";
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIHideSummaryHyperlink
        {
            get
            {
                if ((this.mUIHideSummaryHyperlink == null))
                {
                    this.mUIHideSummaryHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIHideSummaryHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "\r\n Hide Summary", PropertyExpressionOperator.Contains));
                    this.mUIHideSummaryHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIHideSummaryHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "javascript://";
                    this.mUIHideSummaryHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "view-summary";
                    this.mUIHideSummaryHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"view-summary\" href=\"javascript://";
                    this.mUIHideSummaryHyperlink.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
                    #endregion
                }
                return this.mUIHideSummaryHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIHideSummaryHyperlink;
        #endregion
    }
}
