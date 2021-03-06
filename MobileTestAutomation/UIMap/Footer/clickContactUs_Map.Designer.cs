﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.Footer.clickContactUs_MapClasses
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
    public partial class clickContactUs_Map:logWriter
    {
        
        /// <summary>
        /// clickContactus_Method
        /// </summary>
        public void clickContactus_Method()
        {
            #region Variable Declarations
            HtmlCustom uIPanelfooterCustom = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIPanelfooterCustom;
            HtmlHyperlink uIContactusHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIPanelfooterCustom.UIContactusHyperlink;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
          //  Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'panel-footer' custom control at (149, 196)
           // Mouse.Hover(uIPanelfooterCustom, new Point(149, 196));

            // Reset flag to ensure that play back stops if there is an error.
            //Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Contact us' link
            Mouse.Click(uIContactusHyperlink, new Point(54, 24));
            string checkurl = this.UIVillaHolidaysThatYouWindow.Uri.ToString();
            if (checkurl.Contains("contact-us"))
            {
                WriteLogs(checkurl + " URL opened Succssefully " + checkurl + ":Pass");

            }
            else
            {
                WriteLogs(" Search URL NOT opened:Fail ");
            }
            this.UIVillaHolidaysThatYouWindow.Back();
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
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Holidays That You’ll Love More | Villa Plus";
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Holidays That You’ll Love More | Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://m.villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIPanelfooterCustom UIPanelfooterCustom
        {
            get
            {
                if ((this.mUIPanelfooterCustom == null))
                {
                    this.mUIPanelfooterCustom = new UIPanelfooterCustom(this);
                }
                return this.mUIPanelfooterCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIPanelfooterCustom mUIPanelfooterCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIPanelfooterCustom : HtmlCustom
    {
        
        public UIPanelfooterCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression("TagName", "SECTION", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression("Id", "panel-footer", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.Name] = "";
            this.FilterProperties["Class"] = "";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "id=\"panel-footer\"", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("TagInstance", "3", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIContactusHyperlink
        {
            get
            {
                if ((this.mUIContactusHyperlink == null))
                {
                    this.mUIContactusHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIContactusHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIContactusHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIContactusHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIContactusHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Contact us";
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/contact-us";
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://m.villaplus.com/contact-us";
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/contact-us\"";
                    this.mUIContactusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIContactusHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIContactusHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIContactusHyperlink;
        #endregion
    }
}
