﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.GroupDetailsPage.clickScrollArrow_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class clickScrollArrow_Map
    {   /// <summary>
        /// clickScrollArrow_Method - Use 'clickScrollArrow_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void clickScrollArrow_Method()
        {
            #region Variable Declarations
            HtmlScrollBar uIItemScrollBar = this.UIVillaPlusBookingInteWindow.UIVillaPlusBookingDocument.UIItemScrollBar;
            #endregion

            Mouse.MoveScrollWheel(uIItemScrollBar,150);

            //Mouse.MoveScrollWheel(uIItemScrollBar,5);
            Mouse.Click(uIItemScrollBar);

            // Verify that the 'Exists' property of scroll bar equals 'True'
            //Assert.AreEqual(this.clickScrollArrow_MethodExpectedValues.UIItemScrollBarExists, uIItemScrollBar.Exists);
        }
        
        #region Properties
        public virtual clickScrollArrow_MethodExpectedValues clickScrollArrow_MethodExpectedValues
        {
            get
            {
                if ((this.mclickScrollArrow_MethodExpectedValues == null))
                {
                    this.mclickScrollArrow_MethodExpectedValues = new clickScrollArrow_MethodExpectedValues();
                }
                return this.mclickScrollArrow_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusBookingInteWindow UIVillaPlusBookingInteWindow
        {
            get
            {
                if ((this.mUIVillaPlusBookingInteWindow == null))
                {
                    this.mUIVillaPlusBookingInteWindow = new UIVillaPlusBookingInteWindow();
                }
                return this.mUIVillaPlusBookingInteWindow;
            }
        }
        #endregion
        
        #region Fields
        private clickScrollArrow_MethodExpectedValues mclickScrollArrow_MethodExpectedValues;
        
        private UIVillaPlusBookingInteWindow mUIVillaPlusBookingInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'clickScrollArrow_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class clickScrollArrow_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Exists' property of scroll bar equals 'True'
        /// </summary>
        public bool UIItemScrollBarExists = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaPlusBookingInteWindow : BrowserWindow
    {
        
        public UIVillaPlusBookingInteWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus | Booking");
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion
        }

        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusBookingDocument UIVillaPlusBookingDocument
        {
            get
            {
                if ((this.mUIVillaPlusBookingDocument == null))
                {
                    this.mUIVillaPlusBookingDocument = new UIVillaPlusBookingDocument(this);
                }
                return this.mUIVillaPlusBookingDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusBookingDocument mUIVillaPlusBookingDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaPlusBookingDocument : HtmlDocument
    {
        
        public UIVillaPlusBookingDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Booking");
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion
        }

        #region Properties
        public HtmlScrollBar UIItemScrollBar
        {
            get
            {
                if ((this.mUIItemScrollBar == null))
                {
                    this.mUIItemScrollBar = new HtmlScrollBar(this);
                    #region Search Criteria
                    this.mUIItemScrollBar.SearchProperties[HtmlScrollBar.PropertyNames.Orientation] = "Vertical";
                    this.mUIItemScrollBar.WindowTitles.Add("Villa Plus | Booking");
                    this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                    #endregion
                }
                return this.mUIItemScrollBar;
            }
        }
        #endregion
        
        #region Fields
        private HtmlScrollBar mUIItemScrollBar;
        #endregion
    }
}
