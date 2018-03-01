namespace MobileTestAutomation.UIMap.FlightsPage.verifyFExtrasDetails_MapClasses
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



    public partial class verifyFExtrasDetails_Map
    {
        public void verifyTotalPriceonFltsPage()
        {
            try
            {
                var window = BrowserWindow.Locate("m.villaplus.com https://m.villaplus.com/booking/");
                HtmlDocument doc = new HtmlDocument(window);
                UITestControlCollection collection = doc.GetChildren();
                foreach (UITestControl ctrl in collection)
                {
                    if (ctrl.GetType() == typeof(HtmlDiv))
                    {
                        UITestControlCollection collection1 = ctrl.GetChildren();                                               
                    }
                }
                HtmlDiv page = new HtmlDiv(doc);
                page.SearchProperties["data-role"] = "page";

                HtmlDiv Pane = new HtmlDiv(doc);
                Pane.SearchProperties["Id"] = "msgLoc";
                BrowserWindow win = new BrowserWindow();
                HtmlCustom Pane1 = new HtmlCustom(doc);
                Pane1.FilterProperties["id"] = "msgLoc";
                HtmlSpan TotalSpan = new HtmlSpan(Pane);
                TotalSpan.SearchProperties["TagName"] = "SPAN";
                TotalSpan.SearchProperties["ControlType"] = "Pane";
                TotalSpan.SearchProperties["ClassName"] = "HtmlPane";
                TotalSpan.FilterProperties["class"] = "totalprice_1";
                string TotalPriceFrmPage = TotalSpan.InnerText;
                
                HtmlCustom BookingStepLast = new HtmlCustom(Pane);
                BookingStepLast.SearchProperties["class"] = "booking-step last";


                HtmlDiv BgFlights = new HtmlDiv(BookingStepLast);
                BgFlights.SearchProperties["class"] = "bg-flights";

                HtmlDiv BgWhite = new HtmlDiv(BgFlights);
                BgWhite.SearchProperties["class"] = "bg-white";

                HtmlSpan PtagAdults = new HtmlSpan(BgWhite);
                PtagAdults.SearchProperties["TagName"] = "SPAN";
                PtagAdults.SearchProperties["ControlType"] = "Pane";
                PtagAdults.SearchProperties["ClassName"] = "HtmlPane";
                PtagAdults.SearchProperties["Class"] = "";
                PtagAdults.SearchProperties["Id"] = "";
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
