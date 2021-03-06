﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.Footer.clickZolvLink_MapClasses
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
    public partial class clickZolvLink_Map:logWriter
    {
        
        /// <summary>
        /// clickZolvLink_Method
        /// </summary>
        public void clickZolvLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIDesignedbyZOLVHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDesignedbyZOLVHyperlink;
            #endregion

            // Click 'Designed by ZOLV' link
            Mouse.Click(uIDesignedbyZOLVHyperlink, new Point(76, 7));
            string checkurl = uIDesignedbyZOLVHyperlink.Href.ToString();
            if (checkurl.Contains("zolv"))
            {
                WriteLogs(checkurl + " URL opened Succssefully :Pass");

            }
            else
            {
                WriteLogs(" Search URL NOT opened:Fail ");
            }
            Playback.Wait(1000);
            Keyboard.SendKeys("^W");

        }
        
        #region Properties
        public UIVillaHolidaysThatYouWindow UIVillaHolidaysThatYouWindow
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouWindow == null))
                {
                    this.mUIVillaHolidaysThatYouWindow = new UIVillaHolidaysThatYouWindow();
                }
                return this.mUIVillaHolidaysThatYouWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Holidays That You’ll Love More | Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHolidaysThatYouDocument UIVillaHolidaysThatYouDocument
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouDocument == null))
                {
                    this.mUIVillaHolidaysThatYouDocument = new UIVillaHolidaysThatYouDocument(this);
                }
                return this.mUIVillaHolidaysThatYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouDocument mUIVillaHolidaysThatYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouDocument : HtmlDocument
    {
        
        public UIVillaHolidaysThatYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Holidays That You’ll Love More | Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://m.villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIDesignedbyZOLVHyperlink
        {
            get
            {
                if ((this.mUIDesignedbyZOLVHyperlink == null))
                {
                    this.mUIDesignedbyZOLVHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIDesignedbyZOLVHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "";
                    this.mUIDesignedbyZOLVHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = "";
                    this.mUIDesignedbyZOLVHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Target, "_blank", PropertyExpressionOperator.Contains));
                    this.mUIDesignedbyZOLVHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "Designed by ZOLV", PropertyExpressionOperator.Contains));
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/";
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "";
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "http://www.zolv.com/", PropertyExpressionOperator.Contains));
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "zolv";
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "class=\"zolv\" href=\"http://www.zolv.com/\"", PropertyExpressionOperator.Contains));
                    this.mUIDesignedbyZOLVHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "14";
                    this.mUIDesignedbyZOLVHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIDesignedbyZOLVHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIDesignedbyZOLVHyperlink;
        #endregion
    }
}
