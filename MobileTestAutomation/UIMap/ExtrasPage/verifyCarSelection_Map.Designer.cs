﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.ExtrasPage.verifyCarSelection_MapClasses
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
    public partial class verifyCarSelection_Map : logWriter
    {

        /// <summary>
        /// verifyCarSelection_Method - Use 'verifyCarSelection_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public string verifyCarSelection_Method(string CarCat)
        {
            #region Variable Declarations
            HtmlDiv uIUserCarPane = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIUserCarPane;
            #endregion
            //Comparing the Selected Car from Car Extras Section with Car Extra displayed on the Page
            string SelectCarCat = uIUserCarPane.InnerText;
            string SelectCarCat1 = uIUserCarPane.InnerText.Replace("\r\n", string.Empty).Replace(" ","").Trim();
            int SelectCarCatCount = SelectCarCat.LastIndexOf('-');
            SelectCarCat = SelectCarCat.Remove(SelectCarCatCount);
            int selectcarC = SelectCarCat.LastIndexOf("Group");
            SelectCarCat = SelectCarCat.Substring(selectcarC);
            SelectCarCat = SelectCarCat.Replace("Group", string.Empty).Trim();

            try
            {
                StringAssert.Equals(SelectCarCat, CarCat);
                WriteLogs("PASS : Selected Car Category displayed on the Extra Page - " + SelectCarCat + ".");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Selected Car Category displayed on the Extra Page - " + SelectCarCat );
                WriteLogs("----" + ex.Message.ToString());
            }

            return SelectCarCat1;
        }

        #region Properties
        public virtual verifyCarSelection_MethodExpectedValues verifyCarSelection_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyCarSelection_MethodExpectedValues == null))
                {
                    this.mverifyCarSelection_MethodExpectedValues = new verifyCarSelection_MethodExpectedValues();
                }
                return this.mverifyCarSelection_MethodExpectedValues;
            }
        }

        public UIHolidayExtrasVillaPlWindow UIHolidayExtrasVillaPlWindow
        {
            get
            {
                if ((this.mUIHolidayExtrasVillaPlWindow == null))
                {
                    this.mUIHolidayExtrasVillaPlWindow = new UIHolidayExtrasVillaPlWindow();
                }
                return this.mUIHolidayExtrasVillaPlWindow;
            }
        }
        #endregion

        #region Fields
        private verifyCarSelection_MethodExpectedValues mverifyCarSelection_MethodExpectedValues;

        private UIHolidayExtrasVillaPlWindow mUIHolidayExtrasVillaPlWindow;
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'verifyCarSelection_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifyCarSelection_MethodExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'userCar' pane contains 'Villa & Flight 1
        ///
        ///Group 1Z - Kia Picanto 1.0 or similar (MDMN) £165.00
        /// Collect from airportFree
        /// Return to airportFree '
        /// </summary>
        public string UIUserCarPaneInnerText = "Villa & Flight 1\r\n\r\nGroup 1Z - Kia Picanto 1.0 or similar (MDMN) £165.00\r\n Collec" +
            "t from airportFree\r\n Return to airportFree ";
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHolidayExtrasVillaPlWindow : BrowserWindow
    {

        public UIHolidayExtrasVillaPlWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Holiday Extras | Villa Plus";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Holiday Extras | Villa Plus");
            #endregion
        }

        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }

        #region Properties
        public UIHolidayExtrasVillaPlDocument UIHolidayExtrasVillaPlDocument
        {
            get
            {
                if ((this.mUIHolidayExtrasVillaPlDocument == null))
                {
                    this.mUIHolidayExtrasVillaPlDocument = new UIHolidayExtrasVillaPlDocument(this);
                }
                return this.mUIHolidayExtrasVillaPlDocument;
            }
        }
        #endregion

        #region Fields
        private UIHolidayExtrasVillaPlDocument mUIHolidayExtrasVillaPlDocument;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHolidayExtrasVillaPlDocument : HtmlDocument
    {

        public UIHolidayExtrasVillaPlDocument(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Holiday Extras | Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/Extras/ShowExtras", PropertyExpressionOperator.Contains));
            #endregion
        }

        #region Properties
        public HtmlDiv UIUserCarPane
        {
            get
            {
                if ((this.mUIUserCarPane == null))
                {
                    this.mUIUserCarPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIUserCarPane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "userCar", PropertyExpressionOperator.Contains));
                    this.mUIUserCarPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "carhire-summary", PropertyExpressionOperator.Contains));
                    this.mUIUserCarPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"carhire-summary\" id=\"userCar\"", PropertyExpressionOperator.Contains));
                    this.mUIUserCarPane.WindowTitles.Add("Holiday Extras | Villa Plus");
                    #endregion
                }
                return this.mUIUserCarPane;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mUIUserCarPane;
        #endregion
    }
}
