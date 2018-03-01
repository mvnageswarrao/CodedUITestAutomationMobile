﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.FlightsPage.selectFlightChckBox_MapClasses
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
    public partial class selectFlightChckBox_Map : logWriter
    {
        
        /// <summary>
        /// selectFlightChckBox_Method - Use 'selectFlightChckBox_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectFlightChckBox_MethodNew(string strURL)
        {
            #region Variable Declarations
            HtmlCheckBox uIChk_flight_2CheckBox = this.UIVillaPlusAmendFlightWindow.UIVillaPlusAmendFlightDocument.UIChk_flight_2CheckBox;
            #endregion
            HtmlDiv flightresult = new HtmlDiv(this.UIVillaPlusAmendFlightWindow.UIVillaPlusAmendFlightDocument);
            flightresult.SearchProperties["class"] = "flight-result";
            HtmlDiv flightItem = new HtmlDiv(flightresult);
            flightItem.SearchProperties["class"] = "flight-item";
            HtmlCustom Flightrow = new HtmlCustom(flightItem);
            Flightrow.SearchProperties["TagName"] = "SECTION";
            Flightrow.SearchProperties.Add(new PropertyExpression("Id", "sec_", PropertyExpressionOperator.Contains));
            Flightrow.FilterProperties["Class"] = "tblAmendFlightDetails";
            Flightrow.FilterProperties.Add(new PropertyExpression("ControlDefinition", "class=\"tblAmendFlightDetails\"", PropertyExpressionOperator.Contains));
            string FlightInfo = string.Empty;
            delayExecution(strURL);

            UITestControlCollection ui = Flightrow.FindMatchingControls();
            int Count = ui.Count;

            try
            {
                if (Count > 1)
                {
                    int randomnum = 0;
                    int i = 0;
                    foreach (HtmlCustom custbox in ui)
                    {
                        if (i == randomnum)
                        {
                            Mouse.Click(custbox);
                            //chkbox.SetFocus();
                            //chkbox.Checked = true;
                            WriteLogs("PASS : Selected \"Flight\" Check Box.");
                            FlightInfo = custbox.InnerText.Replace("\r\n", "");
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could NOT Select \"Flight\" Check Box.");
                WriteLogs("--------" + ex.Message.ToString());
            }

        }

        #region Properties
        public virtual selectFlightChckBox_MethodParams selectFlightChckBox_MethodParams
        {
            get
            {
                if ((this.mselectFlightChckBox_MethodParams == null))
                {
                    this.mselectFlightChckBox_MethodParams = new selectFlightChckBox_MethodParams();
                }
                return this.mselectFlightChckBox_MethodParams;
            }
        }
        
        public UIVillaPlusAmendFlightWindow UIVillaPlusAmendFlightWindow
        {
            get
            {
                if ((this.mUIVillaPlusAmendFlightWindow == null))
                {
                    this.mUIVillaPlusAmendFlightWindow = new UIVillaPlusAmendFlightWindow();
                }
                return this.mUIVillaPlusAmendFlightWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectFlightChckBox_MethodParams mselectFlightChckBox_MethodParams;
        
        private UIVillaPlusAmendFlightWindow mUIVillaPlusAmendFlightWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectFlightChckBox_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class selectFlightChckBox_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'chk_flight_2' check box
        /// </summary>
        public bool UIChk_flight_2CheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIVillaPlusAmendFlightWindow : BrowserWindow
    {
        
        public UIVillaPlusAmendFlightWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus | Amend Flights");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusAmendFlightDocument UIVillaPlusAmendFlightDocument
        {
            get
            {
                if ((this.mUIVillaPlusAmendFlightDocument == null))
                {
                    this.mUIVillaPlusAmendFlightDocument = new UIVillaPlusAmendFlightDocument(this);
                }
                return this.mUIVillaPlusAmendFlightDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusAmendFlightDocument mUIVillaPlusAmendFlightDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIVillaPlusAmendFlightDocument : HtmlDocument
    {
        
        public UIVillaPlusAmendFlightDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "amendFlightBody";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/amendflight", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/amendflight", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Amend Flights");
            #endregion
        }
        
        #region Properties
        public HtmlCheckBox UIChk_flight_1CheckBox
        {
            get
            {
                if ((this.mUIChk_flight_1CheckBox == null))
                {
                    this.mUIChk_flight_1CheckBox = new HtmlCheckBox(this);
                    #region Search Criteria
                    this.mUIChk_flight_1CheckBox.SearchProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.Name, "chk_flight_", PropertyExpressionOperator.Contains));
                    this.mUIChk_flight_1CheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Value] = "on";
                    this.mUIChk_flight_1CheckBox.FilterProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.ControlDefinition, "type=\"checkbox\" data", PropertyExpressionOperator.Contains));
                    this.mUIChk_flight_1CheckBox.WindowTitles.Add("Villa Plus | Amend Flights");
                    #endregion
                }
                return this.mUIChk_flight_1CheckBox;
            }
        }
        
        public HtmlCheckBox UIChk_flight_2CheckBox
        {
            get
            {
                if ((this.mUIChk_flight_2CheckBox == null))
                {
                    this.mUIChk_flight_2CheckBox = new HtmlCheckBox(this);
                    #region Search Criteria
                    this.mUIChk_flight_2CheckBox.SearchProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.Name, "chk_flight_", PropertyExpressionOperator.Contains));
                    this.mUIChk_flight_2CheckBox.FilterProperties.Add(new PropertyExpression(HtmlCheckBox.PropertyNames.ControlDefinition, "type=\"checkbox\" data", PropertyExpressionOperator.Contains));
                    this.mUIChk_flight_2CheckBox.WindowTitles.Add("Villa Plus | Amend Flights");
                    #endregion
                }
                return this.mUIChk_flight_2CheckBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCheckBox mUIChk_flight_1CheckBox;
        
        private HtmlCheckBox mUIChk_flight_2CheckBox;
        #endregion
    }
}
