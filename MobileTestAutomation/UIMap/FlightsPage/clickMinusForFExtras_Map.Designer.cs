﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.FlightsPage.clickMinusForFExtras_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class clickMinusForFExtras_Map
    {
        
        /// <summary>
        /// clickMinusForFExtras_Method
        /// </summary>
        public void clickMinusForFExtras_Method()
        {
            #region Variable Declarations
            HtmlSpan uIItemPane = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIItem4xCheckinBags20kPane.UIItemPane;
            #endregion

            // Click '-' pane
            Mouse.Click(uIItemPane, new Point(11, 14));
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
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/updateFlight");
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
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/updateFlight");
            #endregion
        }
        
        #region Properties
        public UIItem4xCheckinBags20kPane UIItem4xCheckinBags20kPane
        {
            get
            {
                if ((this.mUIItem4xCheckinBags20kPane == null))
                {
                    this.mUIItem4xCheckinBags20kPane = new UIItem4xCheckinBags20kPane(this);
                }
                return this.mUIItem4xCheckinBags20kPane;
            }
        }
        #endregion
        
        #region Fields
        private UIItem4xCheckinBags20kPane mUIItem4xCheckinBags20kPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem4xCheckinBags20kPane : HtmlDiv
    {
        
        public UIItem4xCheckinBags20kPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "minus-plus vExtras vExtras_", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/updateFlight");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "-";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "icon-minus";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"icon-minus\"";
                    this.mUIItemPane.WindowTitles.Add("http://mobstaging.villaplus.com/booking/updateFlight");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIItemPane;
        #endregion
    }
}
