﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.FlightsPage.IsCheckInBagspopShown_MapClasses
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
    public partial class IsCheckInBagspopShown_Map:logWriter
    {
        
        /// <summary>
        /// IsCheckInBagspopShown_Method - Use 'IsCheckInBagspopShown_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Boolean IsCheckInBagspopShown_Method()
        {
            #region Variable Declarations
            HtmlDiv uIConfBoxPane = this.UIVillaPlusBookingInteWindow.UIVillaPlusBookingDocument.UIConfBoxPane;
            #endregion

            Boolean IscheckinBagpopShown = false;
            try
            {
                // Verify that the 'Id' property of 'confBox' pane equals 'confBox'
                Assert.AreEqual(this.IsCheckInBagspopShown_MethodExpectedValues.UIConfBoxPaneId, uIConfBoxPane.Id);
                IscheckinBagpopShown = uIConfBoxPane.TryFind();
                WriteLogs("INFO : \"Check-In Bags\" Popup displayed.");
            }
            catch (Exception ex)
            {
                WriteLogs("INFO : \"Check-In Bags\" Popup is NOT displayed.");
                WriteLogs("--------" + ex.Message.ToString());
            }
            return IscheckinBagpopShown;
        }
        
        #region Properties
        public virtual IsCheckInBagspopShown_MethodExpectedValues IsCheckInBagspopShown_MethodExpectedValues
        {
            get
            {
                if ((this.mIsCheckInBagspopShown_MethodExpectedValues == null))
                {
                    this.mIsCheckInBagspopShown_MethodExpectedValues = new IsCheckInBagspopShown_MethodExpectedValues();
                }
                return this.mIsCheckInBagspopShown_MethodExpectedValues;
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
        private IsCheckInBagspopShown_MethodExpectedValues mIsCheckInBagspopShown_MethodExpectedValues;
        
        private UIVillaPlusBookingInteWindow mUIVillaPlusBookingInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'IsCheckInBagspopShown_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class IsCheckInBagspopShown_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Id' property of 'confBox' pane equals 'confBox'
        /// </summary>
        public string UIConfBoxPaneId = "confBox";
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Booking");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIConfBoxPane
        {
            get
            {
                if ((this.mUIConfBoxPane == null))
                {
                    this.mUIConfBoxPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIConfBoxPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "confBox";
                    this.mUIConfBoxPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIConfBoxPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Check-in Bags", PropertyExpressionOperator.Contains));
                    this.mUIConfBoxPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "infoBoxContent lightbox";
                    this.mUIConfBoxPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"infoBoxContent lightbox\"", PropertyExpressionOperator.Contains));
                    this.mUIConfBoxPane.WindowTitles.Add("Villa Plus | Booking");
                    #endregion
                }
                return this.mUIConfBoxPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIConfBoxPane;
        #endregion
    }
}
