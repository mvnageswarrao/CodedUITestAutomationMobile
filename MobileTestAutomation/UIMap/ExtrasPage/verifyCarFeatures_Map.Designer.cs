﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.ExtrasPage.verifyCarFeatures_MapClasses
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


    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class verifyCarFeatures_Map : logWriter
    {

        /// <summary>
        /// verifyCarFeatures_Method - Use 'verifyCarFeatures_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyCarFeatures_Method()
        {
            #region Variable Declarations
            HtmlCustom uIItemCustom = this.UIHttpsmvillapluscomboWindow.UIHttpsmvillapluscomboDocument.UICaroption_1Custom.UIItemCustom;
            #endregion

            //Selecting the Child Seat Combobox
            HtmlCustom section1 = new HtmlCustom(UIHttpsmvillapluscomboWindow.UIHttpsmvillapluscomboDocument);
            section1.SearchProperties[HtmlCustom.PropertyNames.Id] = "caroption_1";
            HtmlDiv div1 = new HtmlDiv(section1);
            div1.SearchProperties["class"] = "carHireOptions nest";
            // HtmlCustom li1 = new HtmlCustom(div1);
            HtmlComboBox child = new HtmlComboBox(div1);
            child.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlChildSeat1";
            if (child.Exists)
            {
                child.SelectedIndex = (1);
                WriteLogs("PASS : Add Car Hire Section - Child Seat is selected");
            }
            //Selecting the From To Combobox
            HtmlComboBox collectFrom = new HtmlComboBox(div1);
            collectFrom.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlCollectFrom1";
            if (collectFrom.Exists)
            {
                collectFrom.SelectedIndex = (0);
                WriteLogs("PASS : Add Car Hire Section - Collect From is selected");
            }
            //Selecting the Return To Combobox
            HtmlComboBox ReturnTo = new HtmlComboBox(div1);
            ReturnTo.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlReturnTo1";
            if (ReturnTo.Exists)
            {
                ReturnTo.SelectedIndex = (0);
                WriteLogs("PASS : Add Car Hire Section - Return To is selected");
            }
            //Selecting the Driver Combobox
            HtmlComboBox driver = new HtmlComboBox(div1);
            driver.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddlDriver1";
            if (driver.Exists)
            {
                driver.SelectedIndex = (1);
                WriteLogs("PASS : Add Car Hire Section - Driver To is selected.");
            }
        }

        #region Properties
        public virtual verifyCarFeatures_MethodExpectedValues verifyCarFeatures_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyCarFeatures_MethodExpectedValues == null))
                {
                    this.mverifyCarFeatures_MethodExpectedValues = new verifyCarFeatures_MethodExpectedValues();
                }
                return this.mverifyCarFeatures_MethodExpectedValues;
            }
        }

        public UIHttpsmvillapluscomboWindow UIHttpsmvillapluscomboWindow
        {
            get
            {
                if ((this.mUIHttpsmvillapluscomboWindow == null))
                {
                    this.mUIHttpsmvillapluscomboWindow = new UIHttpsmvillapluscomboWindow();
                }
                return this.mUIHttpsmvillapluscomboWindow;
            }
        }
        #endregion

        #region Fields
        private verifyCarFeatures_MethodExpectedValues mverifyCarFeatures_MethodExpectedValues;

        private UIHttpsmvillapluscomboWindow mUIHttpsmvillapluscomboWindow;
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'verifyCarFeatures_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifyCarFeatures_MethodExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of custom control contains 'Child Seat (Payable locally)   Please Select  1 x €25.00  2 x €25.00  
        ///Collect From   Airport - FREE Villa - £60.00 extra 
        ///Return To   Airport - FREE Villa - £60.00 extra 
        ///DriverPlease select Aa Aa Hhh Testhhh '
        /// </summary>
        public string UIItemCustomInnerText = "Child Seat (Payable locally)   Please Select  1 x €25.00  2 x €25.00  \r\nCollect F" +
            "rom   Airport - FREE Villa - £60.00 extra \r\nReturn To   Airport - FREE Villa - £" +
            "60.00 extra \r\nDriverPlease select Aa Aa Hhh Testhhh ";
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHttpsmvillapluscomboWindow : BrowserWindow
    {

        public UIHttpsmvillapluscomboWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            #endregion
        }

        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }

        #region Properties
        public UIHttpsmvillapluscomboDocument UIHttpsmvillapluscomboDocument
        {
            get
            {
                if ((this.mUIHttpsmvillapluscomboDocument == null))
                {
                    this.mUIHttpsmvillapluscomboDocument = new UIHttpsmvillapluscomboDocument(this);
                }
                return this.mUIHttpsmvillapluscomboDocument;
            }
        }
        #endregion

        #region Fields
        private UIHttpsmvillapluscomboDocument mUIHttpsmvillapluscomboDocument;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHttpsmvillapluscomboDocument : HtmlDocument
    {

        public UIHttpsmvillapluscomboDocument(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/Extras/AddAmendCarHire", PropertyExpressionOperator.Contains));
            #endregion
        }

        #region Properties
        public UICaroption_1Custom UICaroption_1Custom
        {
            get
            {
                if ((this.mUICaroption_1Custom == null))
                {
                    this.mUICaroption_1Custom = new UICaroption_1Custom(this);
                }
                return this.mUICaroption_1Custom;
            }
        }
        #endregion

        #region Fields
        private UICaroption_1Custom mUICaroption_1Custom;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UICaroption_1Custom : HtmlCustom
    {

        public UICaroption_1Custom(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression("TagName", "SECTION", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression("Id", "caroption_1", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("Class", "panCarHireDetail active", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "class=\"panCarHireDetail active\" ", PropertyExpressionOperator.Contains));
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
                    this.mUIItemCustom.SearchProperties.Add(new PropertyExpression("TagName", "UL", PropertyExpressionOperator.Contains));
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
