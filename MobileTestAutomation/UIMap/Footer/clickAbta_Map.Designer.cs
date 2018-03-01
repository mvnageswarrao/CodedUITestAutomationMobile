﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.Footer.clickAbta_MapClasses
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
    public partial class clickAbta_Map:logWriter
    {
        
        /// <summary>
        /// clickAbta_Method
        /// </summary>
        public void clickAbta_Method()
        {
            #region Variable Declarations
            HtmlImage uIABTAImage = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIFooterlinksPane.UIABTAImage;
            #endregion

            // Click 'ABTA' image
            Mouse.Click(uIABTAImage, new Point(82, 95));

            string checkurl = uIABTAImage.Href.ToString();

            if (checkurl.Contains("abta"))
            {
                WriteLogs(checkurl + " URL opened Succssefully " + checkurl + ":Pass");
            }
            else
            {
                WriteLogs(" Search URL NOT opened:Fail ");
            }
            //this.UIVillaHolidaysThatYouWindow.Back();
            Playback.Wait(1000);
            Keyboard.SendKeys("^W");
            //Keyboard.SendKeys("%{c}");
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
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "| Villa Plus", PropertyExpressionOperator.Contains));
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
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIFooterlinksPane UIFooterlinksPane
        {
            get
            {
                if ((this.mUIFooterlinksPane == null))
                {
                    this.mUIFooterlinksPane = new UIFooterlinksPane(this);
                }
                return this.mUIFooterlinksPane;
            }
        }
        #endregion
        
        #region Fields
        private UIFooterlinksPane mUIFooterlinksPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIFooterlinksPane : HtmlDiv
    {
        
        public UIFooterlinksPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "footer-links";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Book with confidence", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "bg-blue secure";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"bg-blue secure\" id=\"footer-links\"", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIABTAImage
        {
            get
            {
                if ((this.mUIABTAImage == null))
                {
                    this.mUIABTAImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIABTAImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Alt, "ABTA", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/content/images/abta-logo.svg", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, ".villaplus.com/content/images/abta-logo.svg", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.LinkAbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Href, "http://www.abta.com/", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "alt=\"ABTA\" src=\"/content/images/abta-log", PropertyExpressionOperator.Contains));
                    this.mUIABTAImage.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIABTAImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIABTAImage;
        #endregion
    }
}
