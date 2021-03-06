﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.ExtrasPage.clickVillaExtrasAll_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using System.Data;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using MobileTestAutomation.Utility;


    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class clickVillaExtrasAll_Map : logWriter
    {

        /// <summary>
        /// clickVillaExtrasAll_Method - Use 'clickVillaExtrasAll_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void clickVillaExtrasAll_Method(int numOfPax)
        {
            #region Variable Declarations
            HtmlDiv uIItem0xStarterPack000Pane = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UIItem0xStarterPack000Pane;
            #endregion

            UITestControlCollection ui = uIItem0xStarterPack000Pane.FindMatchingControls();

            int count = ui.Count;
            Random rnd = new Random();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("VillaExtrasName"), new DataColumn("VillaExtrasCount") });

            foreach (HtmlDiv VillaExtra in ui)
            {
                int NumClickCount = 0;
                int ClickCountonPage = 0;
                int ExtrasCount = rnd.Next(1, numOfPax);
                for (int i = 0; i < ExtrasCount; i++)
                {
                    foreach (UITestControl E in VillaExtra.GetChildren())
                    {
                        if (E.GetType() == typeof(HtmlSpan))
                        {
                            if (E.Enabled == true && E.GetProperty("displaytext").ToString() == "+" && E.GetProperty("class").ToString() == "icon-plus")
                            {
                                Mouse.Click(E);
                                NumClickCount++;
                            }
                        }
                    }
                }
                String VillaExtraName = string.Empty;
                String SelectedVillaExtrasName = string.Empty;
                VillaExtraName = VillaExtra.InnerText.ToString().Trim();
                VillaExtraName = VillaExtraName.Replace("\r\n", string.Empty);
                String[] arrVillaExtraName = VillaExtraName.Split('x');
                ClickCountonPage = Convert.ToInt32(arrVillaExtraName[0].Replace("-", ""));
                VillaExtraName = arrVillaExtraName[1];
                arrVillaExtraName = VillaExtraName.Split('-');
                VillaExtraName = arrVillaExtraName[0];

                WriteLogs("PASS : " + VillaExtraName + " is selected Villa Extra");

                try
                {
                    StringAssert.Equals(NumClickCount, ClickCountonPage);
                    WriteLogs("PASS : Total Number of Villa Extras Clicked -  " + NumClickCount + " and Total Villa Extras Quantity -  " + ClickCountonPage + "is matched");
                }
                catch (Exception ex)
                {
                    WriteLogs("FAIL : Total Number of Villa Extras Clicked - " + NumClickCount + " and Total Villa Extras Quantity -  " + ClickCountonPage + "is not matched");
                    WriteLogs("-----" + ex.Message.ToString());
                }
                dt.Rows.Add(VillaExtraName, NumClickCount);
            }

            // Verify that the 'InnerText' property of '- 0 x Starter Pack - £0.00 +' pane contains '- 
            //0 x Starter Pack - £0.00
            //+ '
            //StringAssert.Contains(uIItem0xStarterPack000Pane.InnerText, this.clickVillaExtrasAll_MethodExpectedValues.UIItem0xStarterPack000PaneInnerText);

            List<String> stringArr = new List<String>();
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                stringArr.Add(dt.Rows[a]["VillaExtrasCount"].ToString());
            }

            int extrascount = 0;
            foreach (HtmlDiv VillaExtra in ui)
            {
                int NumClickCount = 0;
                int x = Convert.ToInt32(stringArr[extrascount]);
                int ExtrasCount = rnd.Next(1, x);
                for (int i = 0; i < ExtrasCount; i++)
                {
                    if (i == 0)
                    {
                        i = 1;
                    }
                    foreach (UITestControl E in VillaExtra.GetChildren())
                    {
                        if (E.GetType() == typeof(HtmlSpan))
                        {
                            if (E.Enabled == true && E.GetProperty("displaytext").ToString() == "-" && E.GetProperty("class").ToString() == "icon-minus")
                            {
                                Mouse.Click(E);
                                NumClickCount++;
                            }
                        }
                    }
                }

                String VillaExtraName = string.Empty;
                VillaExtraName = VillaExtra.InnerText.ToString().Trim();
                VillaExtraName = VillaExtraName.Replace("-", string.Empty);
                VillaExtraName = VillaExtraName.Replace("+", String.Empty);
                VillaExtraName = VillaExtraName.Replace("\r\n", string.Empty);
                WriteLogs("PASS : " + VillaExtraName + " is selected Villa Extra");
                int TotalClickedCount = VillaExtraName.LastIndexOf('x');
                VillaExtraName = VillaExtraName.Remove(TotalClickedCount);
                int TotalVEXTras = Convert.ToInt32(VillaExtraName);

                int countTotalExtras = 0;

                countTotalExtras = x - NumClickCount;
                try
                {
                    StringAssert.Equals(countTotalExtras, VillaExtraName);
                    WriteLogs("PASS : Total Number of villa extras are removed - " + NumClickCount + " and Total Villa Extras Quantity available on the page - " + VillaExtraName + "is matched");
                }
                catch (Exception ex)
                {
                    WriteLogs("FAIL : Total Number of villa extras are removed - " + NumClickCount + " and Total Villa Extras Quantity available on the page - " + VillaExtraName + "is not matched");
                    WriteLogs("-----" + ex.Message.ToString());
                }
                extrascount++;
            }
        }

        #region Properties
        public virtual clickVillaExtrasAll_MethodExpectedValues clickVillaExtrasAll_MethodExpectedValues
        {
            get
            {
                if ((this.mclickVillaExtrasAll_MethodExpectedValues == null))
                {
                    this.mclickVillaExtrasAll_MethodExpectedValues = new clickVillaExtrasAll_MethodExpectedValues();
                }
                return this.mclickVillaExtrasAll_MethodExpectedValues;
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
        private clickVillaExtrasAll_MethodExpectedValues mclickVillaExtrasAll_MethodExpectedValues;

        private UIHolidayExtrasVillaPlWindow mUIHolidayExtrasVillaPlWindow;
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'clickVillaExtrasAll_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class clickVillaExtrasAll_MethodExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '- 0 x Starter Pack - £0.00 +' pane contains '- 
        ///0 x Starter Pack - £0.00
        ///+ '
        /// </summary>
        public string UIItem0xStarterPack000PaneInnerText = "- \r\n0 x Starter Pack - £0.00\r\n+ ";
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
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Holiday Extras | Villa Plus";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/Extras/ShowExtras", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Holiday Extras | Villa Plus");
            #endregion
        }

        #region Properties
        public HtmlDiv UIItem0xStarterPack000Pane
        {
            get
            {
                if ((this.mUIItem0xStarterPack000Pane == null))
                {
                    this.mUIItem0xStarterPack000Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItem0xStarterPack000Pane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "minus-plus min vExtras", PropertyExpressionOperator.Contains));
                    this.mUIItem0xStarterPack000Pane.WindowTitles.Add("Holiday Extras | Villa Plus");
                    #endregion
                }
                return this.mUIItem0xStarterPack000Pane;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mUIItem0xStarterPack000Pane;
        #endregion
    }
}
