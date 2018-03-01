﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.SearchResultsPage.clickSortBy_MapClasses
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
    public partial class clickSortBy_Map:logWriter
    {
        
        /// <summary>
        /// clickSortBy_Method
        /// </summary>
        public void clickSortBy_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uISortbyHyperlink = this.UIYoursearchfound20VilWindow.UIYoursearchfound20VilDocument.UINavfilterCustom.UISortbyHyperlink;
            #endregion
            try
            {
                // Click 'Sort by' link
                Mouse.Click(uISortbyHyperlink, new Point(47, 6));
                WriteLogs("PASS : Clicked \"Sort By\" Option from Search Results Page.");
            }
            catch(Exception ex)
            {
                WriteLogs("FAIL : Could NOT click \"Sort By\" Option from Search Results Page. "+ex.Message);
            }
        }
        
        #region Properties
        public UIYoursearchfound20VilWindow UIYoursearchfound20VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound20VilWindow == null))
                {
                    this.mUIYoursearchfound20VilWindow = new UIYoursearchfound20VilWindow();
                }
                return this.mUIYoursearchfound20VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound20VilWindow mUIYoursearchfound20VilWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound20VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound20VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 20 Villa holidays;");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound20VilDocument UIYoursearchfound20VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound20VilDocument == null))
                {
                    this.mUIYoursearchfound20VilDocument = new UIYoursearchfound20VilDocument(this);
                }
                return this.mUIYoursearchfound20VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound20VilDocument mUIYoursearchfound20VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound20VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound20VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/search/searchresult", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/search/searchresult", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 20 Villa holidays;");
            #endregion
        }
        
        #region Properties
        public UINavfilterCustom UINavfilterCustom
        {
            get
            {
                if ((this.mUINavfilterCustom == null))
                {
                    this.mUINavfilterCustom = new UINavfilterCustom(this);
                }
                return this.mUINavfilterCustom;
            }
        }
        #endregion
        
        #region Fields
        private UINavfilterCustom mUINavfilterCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UINavfilterCustom : HtmlCustom
    {
        
        public UINavfilterCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "nav-filter";
            this.FilterProperties["ControlDefinition"] = "id=\"nav-filter\"";
            this.WindowTitles.Add("Your search found 20 Villa holidays;");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UISortbyHyperlink
        {
            get
            {
                if ((this.mUISortbyHyperlink == null))
                {
                    this.mUISortbyHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUISortbyHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Sort by ";
                    this.mUISortbyHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/search/searchresult", PropertyExpressionOperator.Contains));
                    this.mUISortbyHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/search/searchresult#", PropertyExpressionOperator.Contains));
                    this.mUISortbyHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"#\"";
                    this.mUISortbyHyperlink.WindowTitles.Add("Your search found 20 Villa holidays;");
                    #endregion
                }
                return this.mUISortbyHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUISortbyHyperlink;
        #endregion
    }
}
