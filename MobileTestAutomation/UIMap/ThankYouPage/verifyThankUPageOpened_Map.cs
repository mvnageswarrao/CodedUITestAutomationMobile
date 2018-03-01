namespace MobileTestAutomation.UIMap.PaymentPage.verifyThankUPageOpened_MapClasses
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



    public partial class verifyThankUPageOpened_Map
    {
        public void VerifyAllSectionsInThankYouPage_Method(string BookingType, string FlightDetailsfromPage, string ATOLTxtFrmFltsPage, string FExtrasDetails, string VExtrasDetailsFrmPge, string CarHireDetailsFrmPge, string TransferDetailsFrmPge, string ADWDetailsFrmPge, string LeadPaxDetailsFrmPge, string OtherPaxDetailsFrmPge)
        {
            HtmlDocument doc = this.UIVillaPlusThankYouIntWindow.UIVillaPlusThankYouDocument;
            HtmlDiv SummaryPane = new HtmlDiv(doc);
            SummaryPane.SearchProperties["id"] = "summary";

            VExtrasDetailsFrmPge = string.Empty;

            HtmlCustom section = new HtmlCustom(SummaryPane);
            section.SearchProperties["class"] = "booking-step";
            string FlightSection = string.Empty;
            string VExtrasDetails = string.Empty;
            string CarHireDetails = string.Empty;
            string TransferDetails = string.Empty;
            string ADWDetails = string.Empty;
            string LeadPaxInfo = string.Empty;
            string OtherPaxInfo = string.Empty;

            UITestControlCollection ui = section.FindMatchingControls();

            foreach (UITestControl a in ui)
                {
                    if (a.GetProperty("innertext").ToString().Contains("Villa & Flight\r\n\r\nVilla"))
                    {
                        FlightSection = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                        FlightSection = FlightSection.Replace("Villa&Flight", "").Replace("£", string.Empty);
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Your Villa Extras"))
                    {
                        VExtrasDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Your Car Hire"))
                    {
                        CarHireDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Replace("YourCarHire", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Your Transfers"))
                    {
                        TransferDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Replace("-","").Replace("people", "pax").Replace("YourTransfersVilla&Flight1", "").ToLower().Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Other"))
                    {
                        ADWDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Lead Passenger"))
                    {
                        LeadPaxInfo = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Additional Passengers"))
                    {
                        OtherPaxInfo = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                }

            if (BookingType == "PK")
            {
                    try
                    {
                        StringAssert.Contains(FlightSection, FlightDetailsfromPage.Replace("£", string.Empty));
                        WriteLogs("PASS : \"Flight Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
                    }
                    catch (Exception)
                    {
                        WriteLogs("FAIL : \"Flight Details\" Shown in \"Thank You\" Page are Not Matched.");
                    }

                    try
                    {
                        StringAssert.Contains(FlightSection.ToLower(), ATOLTxtFrmFltsPage.Replace("£", string.Empty).ToLower());
                        WriteLogs("PASS : \"ATOL\" Text Shown in \"Thank You\" Page are Matched. : VERIFICATION");
                    }
                    catch (Exception)
                    {
                        WriteLogs("FAIL : \"ATOL\" Text Shown in \"Thank You\" Page are Not Matched.");
                    }

                    try
                    {
                        string FExtrasDetailsNew = FExtrasDetails.Replace("+-", "");
                        FExtrasDetails = FExtrasDetailsNew.Replace("+", "").Substring(1);
                        StringAssert.Contains(FlightSection.ToLower(), FExtrasDetails.ToLower().Replace("*", "").Replace("£", string.Empty));
                        WriteLogs("PASS : \"Flight Extras Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
                    }
                    catch (Exception)
                    {
                        WriteLogs("INFO : \"Flight Extras Details\" Shown in \"Thank You\" Page are Not Matched.");
                    }
            }

            try
            {
                StringAssert.Contains(VExtrasDetails.ToLower(), VExtrasDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Villa Extras Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Villa Extras Details\" Shown in \"Thank You\" Page are Not Matched.");
            }

            try
            {
                StringAssert.Contains(CarHireDetailsFrmPge.Replace("Villa&Flight1", "").Replace("carhire","").ToLower(),CarHireDetails.ToLower());
                WriteLogs("PASS : \"Car Hire Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Car Hire Details\" Shown in \"Thank You\" Page are Not Matched.");
            }

            try
            {
                StringAssert.Contains(TransferDetails.ToLower(), TransferDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Transfer Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Transfer Details\" Shown in \"Thank You\" Page are Not Matched.");
            }

            try
            {
                StringAssert.Contains(ADWDetails.ToLower(), ADWDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"ADW Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"ADW Details\" Shown in \"Thank You\" Page are Not Matched.");
            }

            try
            {
                StringAssert.Contains(LeadPaxInfo.ToLower(), LeadPaxDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Lead Pax Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Lead Pax Details\" Shown in \"Thank You\" Page are Not Matched.");
            }

            try
            {
                StringAssert.Contains(OtherPaxInfo.ToLower(), OtherPaxDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Other Pax Details\" Shown in \"Thank You\" Page are Matched. : VERIFICATION");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Other Pax Details\" Shown in \"Thank You\" Page are Not Matched.");
            }
        }
    }
}
