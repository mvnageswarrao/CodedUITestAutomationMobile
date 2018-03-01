namespace MobileTestAutomation.UIMap.FlightsPage.verifyViewSummaryOpened_MapClasses
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
    
    public partial class verifyViewSummaryOpened_Map
    {
        public void verifyFltSectioninViewSummary_Method(string FlightDetailsfromPage,string ATOLTxtFrmFltsPage)
        {
            HtmlDiv Panewin = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIInsidesummaryPane;
            HtmlCustom section = new HtmlCustom(Panewin);
            section.SearchProperties["class"] = "booking-step";

            string FlightSection = string.Empty;

            UITestControlCollection ui = section.FindMatchingControls();
            try
            {
                foreach (UITestControl a in ui)
                {
                    if (a.GetProperty("innertext").ToString().Contains("Villa & Flight"))
                    {
                        FlightSection = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                        break;
                    }
                }

                if(FlightSection.Contains("Villa&FlightEdit"))
                {
                    string ModFlightSection = FlightSection.Replace("Villa&FlightEdit", "").Replace("£",string.Empty);
                    StringAssert.Contains(ModFlightSection, FlightDetailsfromPage.Replace("£",string.Empty));
                    WriteLogs("PASS : \"Flight Details\" Shown in \"View Summary\" are Matched with the details shown in \"Flights\" Page.");
                }
                
                StringAssert.Contains(FlightSection.ToLower(), ATOLTxtFrmFltsPage.ToLower());
                WriteLogs("PASS : \"ATOL\" Text Shown in \"View Summary\" are Matched with the details shown in \"Flights\" Page.");
            }
            catch (Exception)
            {
                WriteLogs("FAIL : \"Flight/Atol Details\" Shown in \"View Summary\" are Not Matched with the details shown in \"Flights\" Page.");
            }
        }
        public void verifyFltSectioninViewSummaryFrmGDPge_Method(string FExtrasDetails)
        {
            HtmlDiv Panewin = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIInsidesummaryPane;
            HtmlCustom section = new HtmlCustom(Panewin);
            section.SearchProperties["class"] = "booking-step";

            string FlightSection = string.Empty;
            string FExtrasDetailsNew = FExtrasDetails.Replace("+-", "");
            FExtrasDetails = FExtrasDetailsNew.Replace("+", "").Substring(1);

            UITestControlCollection ui = section.FindMatchingControls();
            try
            {
                foreach (UITestControl a in ui)
                {
                    if (a.GetProperty("innertext").ToString().Contains("Villa & Flight"))
                    {
                        FlightSection = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                        break;
                    }
                }
                StringAssert.Contains(FlightSection.ToLower(), FExtrasDetails.ToLower());
                WriteLogs("PASS : \"Flight Extras Details\" Shown in \"View Summary\" are Matched with the details Selected in \"Flights\" Page.");
            }
            catch (Exception)
            {
                WriteLogs("INFO : \"Flight Extras Details\" Shown in \"View Summary\" are Not Matched with the details Selected in \"Flights\" Page.");
            }
        }
        public void verifyViewSummaryFrmLeadPaxPge_Method(string VExtrasDetailsFrmPge, string CarHireDetailsFrmPge, string TransferDetailsFrmPge, string ADWDetailsFrmPge)
        {
            HtmlDiv Panewin = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIInsidesummaryPane;
            HtmlCustom section = new HtmlCustom(Panewin);
            section.SearchProperties["class"] = "booking-step";
            string VExtrasDetails = string.Empty;
            string CarHireDetails = string.Empty;
            string TransferDetails = string.Empty;
            string ADWDetails = string.Empty;
            VExtrasDetailsFrmPge = string.Empty;
            UITestControlCollection ui = section.FindMatchingControls();
            try
            {
                foreach (UITestControl a in ui)
                {
                    if (a.GetProperty("innertext").ToString().Contains("Your Villa Extras"))
                    {
                        VExtrasDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Your Car Hire"))
                    {
                        CarHireDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Replace("YourCarHireEdit","").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Your Transfers"))
                    {
                        TransferDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Other"))
                    {
                        ADWDetails = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Trim();
                    }
                }                
                StringAssert.Contains(VExtrasDetails.ToLower(), VExtrasDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Villa Extras Details\" Shown in \"View Summary\" are Matched with the details Selected in \"Extras\" Page.");

                StringAssert.Contains(CarHireDetails.ToLower(), CarHireDetailsFrmPge.Replace("Villa&Flight1", "").Replace("CarHire","").ToLower());
                WriteLogs("PASS : \"Car Hire Details\" Shown in \"View Summary\" are Matched with the details Selected in \"Extras\" Page.");

                StringAssert.Contains(TransferDetails.Replace("YourTransfersEditVilla&Flight1", "").Replace("-PrivateTransfer,", "").Replace("people", "pax").ToLower(), TransferDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Transfer Details\" Shown in \"View Summary\" are Matched with the details Selected in \"Extras\" Page.");

                StringAssert.Contains(ADWDetails.ToLower(), ADWDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"ADW Details\" Shown in \"View Summary\" are Matched with the details Selected in \"Extras\" Page.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : \"Villa Extras/Car Hire/Transfer/ADW Details\" Shown in \"View Summary\" are Not Matched with the details Selected in \"Extras\" Page.");
                WriteLogs("--------" + ex.Message.ToString());
            }
        }
        public Tuple<string,string> verifyViewSummaryFrmPaymentPge_Method(string LeadPaxDetailsFrmPge, string OtherPaxDetailsFrmPge)
        {
            HtmlDiv Panewin = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIInsidesummaryPane;
            HtmlCustom section = new HtmlCustom(Panewin);
            section.SearchProperties["class"] = "booking-step";
            string LeadPaxInfo = string.Empty;
            string OtherPaxInfo = string.Empty;

            UITestControlCollection ui = section.FindMatchingControls();
            try
            {
                foreach (UITestControl a in ui)
                {
                    if (a.GetProperty("innertext").ToString().Contains("Lead Passenger"))
                    {
                        LeadPaxInfo = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Replace("LeadPassengerEdit", "").Trim();
                    }
                    if (a.GetProperty("innertext").ToString().Contains("Additional Passengers"))
                    {
                        OtherPaxInfo = a.GetProperty("innertext").ToString().Replace("\r\n", "").Replace(" ", "").Replace("AdditionalPassengersEdit", "").Trim();
                    }
                }
                StringAssert.Contains(LeadPaxInfo.ToLower().Trim(), LeadPaxDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Lead Pax Details\" Shown in \"View Summary\" are Matched with the details entered in \"Lead Pax\" Page.");
                StringAssert.Contains(OtherPaxInfo.ToLower(), OtherPaxDetailsFrmPge.ToLower());
                WriteLogs("PASS : \"Other Pax Details\" Shown in \"View Summary\" are Matched with the details enetred in \"Lead Pax\" Page.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : \"Lead/Other Pax Details\" Shown in \"View Summary\" are Not Matched with the details entered in \"Lead Pax\" Page.");
                WriteLogs("--------" + ex.Message.ToString());
            }
            Tuple<string, string> PaxInfo = new Tuple<string, string>(LeadPaxInfo,OtherPaxInfo);
            return PaxInfo;
        }
    }
}
