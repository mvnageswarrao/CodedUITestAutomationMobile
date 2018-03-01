namespace MobileTestAutomation.UIMap.FlightsPage.selectFlightChckBox_MapClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public partial class selectFlightChckBox_Map
    {
        public string selectFlightChckBox_Method(string strURL)
        {
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
            return FlightInfo;
        }
    }
}
