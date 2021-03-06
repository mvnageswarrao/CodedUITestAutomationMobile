﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.ExtrasPage.verifyCarsCategory_MapClasses
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
    using System.Configuration;
    using System.Data.SqlClient;

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class verifyCarsCategory_Map : logWriter
    {

        /// <summary>
        /// verifyCarsCategory_Method - Use 'verifyCarsCategory_MethodExpectedValues' to pass parameters into this method.
        /// </summary>

        public void verifyCarsCategory_Method(string CentreName, string AirportCodeName, string SelectYear, string selectDate, string InitialCatalog)
        {
            #region Variable Declarations
            HtmlDiv uICarCategory1AFiatPanPane = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UISec1Custom.UICarCategory1AFiatPanPane;
            HtmlCustom uISec1Custom1 = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UISec1Custom;
            #endregion

            string curntCarCategory = string.Empty;
            string beginCarCategory = string.Empty;
            string carsCategorylist = uICarCategory1AFiatPanPane.InnerText;
            int carsCategoryValue = carsCategorylist.IndexOf("\r\n");
            String carCat = carsCategorylist.Remove(carsCategoryValue).TrimStart();
            beginCarCategory = carCat.Replace("Car Category", string.Empty).Trim();
            
            while (beginCarCategory != curntCarCategory)
            {
                getFromDB getData = new getFromDB();
                SqlDataReader dataReader = null;
                string sqlQuery = string.Empty;
                string CarID = string.Empty;
                string make = string.Empty;
                string CarHeader = string.Empty;
                string carsCategorylist1 = string.Empty;
                string Price = string.Empty;
                string carPrice = string.Empty;
                
                uICarCategory1AFiatPanPane = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UISec1Custom.UICarCategory1AFiatPanPane;
                if (curntCarCategory == string.Empty)
                {
                    carsCategorylist = uICarCategory1AFiatPanPane.InnerText;
                    int CPrice = carsCategorylist.LastIndexOf("£");
                    carPrice = carsCategorylist.Substring(CPrice);
                    carPrice = carPrice.Replace("£", string.Empty);
                    carsCategoryValue = carsCategorylist.IndexOf("\r\n");
                    carCat = carsCategorylist.Remove(carsCategoryValue).TrimStart();
                    curntCarCategory = carCat.Replace("Car Category", string.Empty).Trim();
                }
                else
                {
                    //curntCarCategory = curntCarCategory;
                    carsCategorylist = uICarCategory1AFiatPanPane.InnerText;
                    int CPrice = carsCategorylist.LastIndexOf("£");
                    carPrice = carsCategorylist.Substring(CPrice);
                    carPrice = carPrice.Replace("£", string.Empty);
                }
                //Generating the Car ID
                sqlQuery = "select ID , make from Cars where Centre = '" + CentreName + "' and AirportCode = '" + AirportCodeName + "' and Year = '" + SelectYear + "' and GroupCode = '" + curntCarCategory + "' ";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    CarID = (dataReader["ID"].ToString());
                    make = (dataReader["make"].ToString().Trim());
                }
                //Showing the available Car Features
                List<string> CarFeatures = new List<string>();
                CarFeatures.Add(curntCarCategory);
                CarFeatures.Add(make);
                sqlQuery = "select CarFeatures from cardetails where CarsID = '" + CarID + "' ";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    CarFeatures.Add(dataReader["CarFeatures"].ToString().Trim());
                }
                foreach (string tmpCarCaegory in CarFeatures)
                {
                    if (carsCategorylist.Contains(tmpCarCaegory))
                    {
                        WriteLogs("PASS : Car Features displayed on the Page and DB is Matched - " + tmpCarCaegory);
                    }
                    else
                    {
                        WriteLogs("FAIL : Car Features displayed on the Page and DB is not Matched - " + tmpCarCaegory);
                    }
                }
                //Extracting the Car Price from DB                             
                sqlQuery = "select Price from dbo.TblCarPrice where CarsID = '" + CarID + "' and '" + selectDate + "' between  StartDate and EndDate ";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    Price = (dataReader["Price"].ToString());
                }
                try
                {
                    StringAssert.Equals(Price, carPrice);
                    WriteLogs("PASS : Car Price is matched correctly - " + Price);
                }
                catch (Exception ex)
                {
                    WriteLogs("FAIL : Car Price is matched correctly. ");
                    WriteLogs("--------" + ex.Message.ToString());
                }
                //Drag the Car HIre Image
                System.Threading.Thread.Sleep(500);
                var Mouseposition = uICarCategory1AFiatPanPane.BoundingRectangle;
                Point x = new Point(Mouseposition.X, Mouseposition.Y);
                Point y = new Point(Mouseposition.X - 10, Mouseposition.Y - 10);
                Mouse.Move(x);
                Mouse.StartDragging(uICarCategory1AFiatPanPane, y);
                System.Threading.Thread.Sleep(500);
                Mouse.StopDragging(Mouseposition.X - 30, Mouseposition.Y - 30);
                curntCarCategory = null;
                HtmlDiv uICarCategory1AFiatPanPane1 = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UISec1Custom.UICarCategory1AFiatPanPane;
                HtmlCustom uISec1Custom = this.UIHolidayExtrasVillaPlWindow.UIHolidayExtrasVillaPlDocument.UISec1Custom;
                UITestControlCollection ui = uISec1Custom.GetChildren();
                for (int i = 0; i < ui.Count; i++)
                {
                    if (ui[i].GetProperty("class").ToString() == "car-hire content current")
                    {

                        carsCategorylist1 = ui[i].GetProperty("data-alt").ToString();
                        break;
                    }
                }
                curntCarCategory = carsCategorylist1.Replace("Car Category", string.Empty).Trim();
            }
        }

        #region Properties
        public virtual verifyCarsCategory_MethodExpectedValues verifyCarsCategory_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyCarsCategory_MethodExpectedValues == null))
                {
                    this.mverifyCarsCategory_MethodExpectedValues = new verifyCarsCategory_MethodExpectedValues();
                }
                return this.mverifyCarsCategory_MethodExpectedValues;
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
        private verifyCarsCategory_MethodExpectedValues mverifyCarsCategory_MethodExpectedValues;

        private UIHolidayExtrasVillaPlWindow mUIHolidayExtrasVillaPlWindow;
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'verifyCarsCategory_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifyCarsCategory_MethodExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Car Category 1A Fiat Panda or similar (' pane contains 'Car Category 1A
        ///Fiat Panda or similar (MBMN)3 doors
        ///4 seats
        ///Radio CD
        ///Electric windows
        ///Central locking
        ///Petrol
        /// 4
        ///
        ///1
        ///
        ///1
        ///
        ///Manual
        ///No Air Con
        ///
        ///The picture and information of the car is for guidance only.   
        ///
        ///£125.00 '
        /// </summary>
        public string UICarCategory1AFiatPanPaneInnerText = "Car Category 1A\r\nFiat Panda or similar (MBMN)3 doors\r\n4 seats\r\nRadio CD\r\nElectric" +
            " windows\r\nCentral locking\r\nPetrol\r\n 4\r\n\r\n1\r\n\r\n1\r\n\r\nManual\r\nNo Air Con\r\n\r\nThe pic" +
            "ture and information of the car is for guidance only.   \r\n\r\n£125.00 ";
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
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
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
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion
        }

        #region Properties
        public UISec1Custom UISec1Custom
        {
            get
            {
                if ((this.mUISec1Custom == null))
                {
                    this.mUISec1Custom = new UISec1Custom(this);
                }
                return this.mUISec1Custom;
            }
        }
        #endregion

        #region Fields
        private UISec1Custom mUISec1Custom;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISec1Custom : HtmlCustom
    {

        public UISec1Custom(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "SECTION";
            this.SearchProperties.Add(new PropertyExpression("Id", "sec1", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Holiday Extras | Villa Plus");
            #endregion
        }

        #region Properties
        public HtmlDiv UICarCategory1AFiatPanPane
        {
            get
            {
                //if ((this.mUICarCategory1AFiatPanPane == null))
                //{
                this.mUICarCategory1AFiatPanPane = new HtmlDiv(this);
                #region Search Criteria
                this.mUICarCategory1AFiatPanPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "car-hire content current", PropertyExpressionOperator.Contains));
                this.mUICarCategory1AFiatPanPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"car-hire content current\"", PropertyExpressionOperator.Contains));
                this.mUICarCategory1AFiatPanPane.WindowTitles.Add("Holiday Extras | Villa Plus");
                this.mUICarCategory1AFiatPanPane.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                #endregion
                //}
                return this.mUICarCategory1AFiatPanPane;
            }
        }
        #endregion

        #region Fields
        private HtmlDiv mUICarCategory1AFiatPanPane;
        #endregion
    }
}
