﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.SearchResultsPage.verifyFlightsPageOpened_MapClasses
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
    public partial class verifyFlightsPageOpened_Map:logWriter
    {
        
        /// <summary>
        /// verifyFlightsPageOpened_Method - Use 'verifyFlightsPageOpened_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyFlightsPageOpened_Method(string strURL)
        {
            #region Variable Declarations
            HtmlCustom uIItemCustom = this.UIVillaPlusBookingInteWindow.UIVillaPlusBookingDocument.UIBookPane.UIItemCustom;
            UIBookPane UIBookPane = this.UIVillaPlusBookingInteWindow.UIVillaPlusBookingDocument.UIBookPane;
            #endregion

            delayExecution(strURL);
            uIItemCustom.WaitForControlExist();

            string ExpTxt1 = "Villa & FlightDetails";
            string ExpTxt2 = "Would you like to add flights?";
            string ActTxt = UIBookPane.InnerText;
            ActTxt = ActTxt.Replace("\r\n", string.Empty);

            try
            {
                if (ActTxt.Contains(ExpTxt1))
                {
                    WriteLogs("PASS : \"Flights\" Page For \"Package Booking\" is opened Successfully. : VERIFICATION");
                }
                else if (ActTxt.Contains(ExpTxt2))
                {
                    WriteLogs("PASS : \"Flights\" Page For \"Villa Only Booking\" is opened Successfully.");
                }
             }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT open \"Flights\" Page.");
                WriteLogs("--------" + ex.Message.ToString());
            }
        }

        public string getBookingID(string strURL)
        {
            delayExecution(strURL);
            string str = string.Empty;
            string bookingID = string.Empty;
            int count = 0;
            do
            {
                try
                {
                    str = this.UIVillaPlusBookingInteWindow.UIVillaPlusBookingDocument.GetProperty("OuterHtml").ToString();
                    string regexBookingId = @"<input[\s]+[^>]*?id[\s]?=[\s""']+(BookingId)[\s""'][\s]+type[\s]?=[\s""']+(hidden)[\s""']+value[\s]?=[\s""']+(.*?)[""']+.*?>";
                    Regex exBookingId = new Regex(regexBookingId, RegexOptions.IgnoreCase);
                    string bookingIDstrtmp = exBookingId.Match(str).Value.Trim().ToString();
                    string[] bookidarr = bookingIDstrtmp.Split('=');
                    bookingID = bookidarr[3];
                    bookingID = bookingID.TrimStart('"');
                    bookingID = bookingID.Remove(bookingID.Length - 2);
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    count = count + 1;
                }
            } while (bookingID == "" && count <= 5);

            if (bookingID == "")
            {
                WriteLogs("FAIL : Could not find BookingID From HS Page.");
                takeImage("BookingID_HSPage.");
            }

            return bookingID;
        }

        #region Properties
        public virtual verifyFlightsPageOpened_MethodExpectedValues verifyFlightsPageOpened_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyFlightsPageOpened_MethodExpectedValues == null))
                {
                    this.mverifyFlightsPageOpened_MethodExpectedValues = new verifyFlightsPageOpened_MethodExpectedValues();
                }
                return this.mverifyFlightsPageOpened_MethodExpectedValues;
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
        private verifyFlightsPageOpened_MethodExpectedValues mverifyFlightsPageOpened_MethodExpectedValues;
        
        private UIVillaPlusBookingInteWindow mUIVillaPlusBookingInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyFlightsPageOpened_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyFlightsPageOpened_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of custom control equals '1. Flights'
        /// </summary>
        public string UIItemCustomInnerText = "1. Flights";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaPlusBookingInteWindow : BrowserWindow
    {
        
        public UIVillaPlusBookingInteWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus | Booking", PropertyExpressionOperator.Contains));
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus | Booking", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Booking");
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIBookPane : HtmlDiv
    {
        
        public UIBookPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "book";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "1. Flights", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"book\"";
            this.WindowTitles.Add("Villa Plus | Booking");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties["TagName"] = "A";
                    this.mUIItemCustom.FilterProperties["Class"] = "bg-orange first";
                    this.mUIItemCustom.FilterProperties["ControlDefinition"] = "class=\"bg-orange first\"";
                    this.mUIItemCustom.WindowTitles.Add("Villa Plus | Booking");
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIItemCustom;
        #endregion
    }
}
