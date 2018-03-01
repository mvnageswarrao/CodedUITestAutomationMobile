namespace MobileTestAutomation.UIMap.Header.clickHeaderLogo_MapClasses
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
    using MobileTestAutomation.Utility;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public partial class clickHeaderLogo_Map:logWriter
    {   public void clickHeaderLogo_Method(string strURL)
        {
            delayExecution(strURL);
            BrowserWindow BrWindow = this.UIVillaHolidaysThatYouWindow;
            HtmlHyperlink Logolink = new HtmlHyperlink(BrWindow);
            Logolink.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "logo");
            Logolink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Villa Plus");

            // Click 'Villa Plus' link
            string chkurl = BrWindow.Uri.ToString();
            int findindx = chkurl.IndexOf('.');
            string absoluteURL = chkurl.Substring(findindx).Trim();
            String PageName = string.Empty;

            switch (absoluteURL)
            {
                case ".villaplus.com/":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/home/index":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/search":
                    PageName = "Search Page";
                    break;
                case ".villaplus.com/search/searchresult":
                    PageName = "Search Results Page";
                    break;
            }

            try
            {
                Mouse.Click(Logolink);
                string chkURL = BrWindow.Uri.ToString();
                StringAssert.Contains(chkURL, ".villaplus.com/home");
                WriteLogs("PASS : Clicked \"VP LOGO\" from Header from \"Search\" Page");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Clould not Click \"VP LOGO\" from Header from Search Page" + ex.ToString());
            }
            delayExecution(strURL);
            if (PageName != "Home Page")
            {
                BrWindow.Back();
            }
            WriteLogs("INFO : Clicked Back From Browser And Restored " + PageName + " Page.");
        }
        public void verifyHeaderLogo_Method(string strURL)
        {
            delayExecution(strURL);
            BrowserWindow BrWindow = this.UIVillaHolidaysThatYouWindow;
            HtmlHyperlink Logolink = new HtmlHyperlink(BrWindow);
            Logolink.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "logo");
            Logolink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Villa Plus");
            Boolean IsLogoExists = Logolink.Exists;
            string chkurl = BrWindow.Uri.ToString();
            int findindx = chkurl.IndexOf('.');
            string absoluteURL = chkurl.Substring(findindx).Trim();
            String PageName = string.Empty;

            switch (absoluteURL)
            {
                case ".villaplus.com/":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/home/index":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/search":
                    PageName = "Search Page";
                    break;
                case ".villaplus.com/search/searchresult":
                    PageName = "Search Results Page";
                    break;
            }
            try
            {
                if (IsLogoExists == true)
                {
                    WriteLogs("PASS : \"Villa Plus LOGO\" is shown on " + PageName);
                }
                else
                {
                    WriteLogs("FAIL : \"Villa Plus LOGO\" is Not shown on " + PageName);
                }
            }
            catch(Exception ex)
            {
                WriteLogs("FAIL : \"Villa Plus LOGO\" is Not shown on " + PageName + " " + ex.Message);
            }
        }
        public void clickBackFromPage(string strURL)
        {
            var window = this.UIVillaHolidaysThatYouWindow;
            HtmlDocument doc = new HtmlDocument(window);
            HtmlCustom NavTopCustom = new HtmlCustom(doc);
            NavTopCustom.SearchProperties[HtmlCustom.PropertyNames.Id] = "nav-top";
            HtmlCustom BackBtn = new HtmlCustom(NavTopCustom);
            BackBtn.SearchProperties["TagName"] = "A";
            BackBtn.SearchProperties["Id"] = null;
            BackBtn.SearchProperties[UITestControl.PropertyNames.Name] = null;
            BackBtn.SearchProperties["Class"] = "back";
            BackBtn.FilterProperties["ControlDefinition"] = "class=\"back\" onclick=\"history.go(-1)\"";
            BackBtn.FilterProperties["TagInstance"] = "1";

            string chkurl = window.GetProperty("Uri").ToString();
            int findindx = chkurl.IndexOf('.');
            string absoluteURL = chkurl.Substring(findindx).Trim();
            String PageName = string.Empty;

            switch (absoluteURL)
            {
                case ".villaplus.com/":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/home/index":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/#":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/search":
                    PageName = "Search Page";
                    break;
                case ".villaplus.com/search/searchresult":
                    PageName = "Search Results Page";
                    break;
            }
            try
            {
                bool ctrlexists = BackBtn.Exists;
                Mouse.Click(BackBtn);
                WriteLogs("PASS : \"VP Back Button\" is Clicked From " + PageName);
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could Not click \"VP Back Button\" From " + PageName + " " + ex.Message);
            }
            delayExecution(strURL);
            if (PageName== "Home Page")
            {
                window.Forward();
            }
            else
            {
                window.Back();
            }
            WriteLogs("INFO : Restored " + PageName + " Page.");
        }
        public void clickSearchIconFromPage(string strURL)
        {
            var window = this.UIVillaHolidaysThatYouWindow;
            HtmlDocument doc = new HtmlDocument(window);
            HtmlCustom NavTopCustom = new HtmlCustom(doc);
            NavTopCustom.SearchProperties[HtmlCustom.PropertyNames.Id] = "nav-top";
            HtmlCustom SearchIcon = new HtmlCustom(NavTopCustom);
            SearchIcon.SearchProperties["Class"] = "search";
            SearchIcon.FilterProperties["href"] = "/search";
            //HtmlHyperlink SearchIcon = new HtmlHyperlink(li);
            //SearchIcon.SearchProperties["Class"] = "icon-search-small";
            //SearchIcon.SearchProperties["href"] = "/search";


            string chkurl = window.GetProperty("Uri").ToString();
            int findindx = chkurl.IndexOf('.');
            string absoluteURL = chkurl.Substring(findindx).Trim();
            String PageName = string.Empty;

            switch (absoluteURL)
            {
                case ".villaplus.com/":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/home/index":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/search":
                    PageName = "Search Page";
                    break;
                case ".villaplus.com/search/searchresult":
                    PageName = "Search Results Page";
                    break;
            }
            try
            {
                bool ctrlexists = SearchIcon.Exists;
                //Mouse.Click(SearchIcon);
                Mouse.Click(SearchIcon.BoundingRectangle.Location);
                WriteLogs("PASS : \"Search Icon\" is Clicked From " + PageName);
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could Not click \"Search Icon\" From " + PageName + " " + ex.Message);
            }
            delayExecution(strURL);
            if (PageName == "Home Page")
            {
                window.Forward();
            }
            else
            {
                window.Back();
            }
            WriteLogs("INFO : Restored " + PageName + " Page.");
        }
        public void verifyAllHeaderCtrls(string strURL)
        {
            var window = this.UIVillaHolidaysThatYouWindow;
            HtmlDocument doc = new HtmlDocument(window);
            HtmlCustom NavTopCustomHeader = new HtmlCustom(doc);
            NavTopCustomHeader.SearchProperties[HtmlCustom.PropertyNames.Id] = "nav-top";

            string chkurl = window.GetProperty("Uri").ToString();
            int findindx = chkurl.IndexOf('.');
            string absoluteURL = chkurl.Substring(findindx).Trim();
            String PageName = string.Empty;
            String PageNameNew = string.Empty;
            String IconName = string.Empty;

            switch (absoluteURL)
            {
                case ".villaplus.com/":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/home/index":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/#":
                    PageName = "Home Page";
                    break;
                case ".villaplus.com/search":
                    PageName = "Search Page";
                    break;
                case ".villaplus.com/search/searchresult":
                    PageName = "Search Results Page";
                    break;
                case ".villaplus.com/menu":
                    PageName = "Menu Page";
                    break;
            }
            try
            {
                bool isHeaderexists = NavTopCustomHeader.Exists;
                WriteLogs("PASS : \"Header\" is displayed on " + PageName);
                try
                { 
                UITestControlCollection ui = NavTopCustomHeader.GetChildren();

                    foreach (UITestControl a in ui)
                    {
                        var ctrlpnt = a.BoundingRectangle;
                        var point = new Point(ctrlpnt.X + 20, ctrlpnt.Y + 10);
                        delayExecution(strURL);
                        string ctrlname = a.GetProperty("FriendlyName").ToString();
                        if (ctrlname == "" || ctrlname == "/")
                        {
                            UITestControlCollection uia = a.GetChildren();
                            ctrlname = uia[0].GetProperty("FriendlyName").ToString();
                            if (ctrlname == "" || ctrlname == "/")
                            {
                                ctrlname = a.GetProperty("innertext").ToString();
                            }
                        }
                        switch (ctrlname)
                        {
                            case "back":
                                IconName = "Back Icon";
                                break;
                            case "/menu":
                                IconName = "Menu Icon";
                                break;
                            case "ContBook":
                                IconName = "Suit Case Icon";
                                break;
                            case "/search":
                                IconName = "Search Icon";
                                break;
                            case "Search":
                                IconName = "Search Icon";
                                break;
                        }
                        Mouse.Move(point);
                        Mouse.Click(point);
                        WriteLogs("PASS : \"" + IconName + "\" Clicked From " + PageName);
                        delayExecution(strURL);
                        absoluteURL = window.Uri.AbsolutePath.ToString();
                        switch (absoluteURL)
                        {
                            case ".villaplus.com/":
                                PageNameNew = "Home Page";
                                break;
                            case ".villaplus.com/home/index":
                                PageNameNew = "Home Page";
                                break;
                            case ".villaplus.com/#":
                                PageNameNew = "Home Page";
                                break;
                            case "/search":
                                PageNameNew = "Search Page";
                                break;
                            case ".villaplus.com/search/searchresult":
                                PageNameNew = "Search Results Page";
                                break;
                            case "/menu":
                                PageNameNew = "Menu Page";
                                break;
                        }
                        if (IconName == "Menu Icon")
                        {
                            Assert.AreEqual(absoluteURL, "/menu");
                            WriteLogs("PASS : \"" + PageNameNew + "\" is Opened." );
                        }
                        if (IconName == "Search Icon")
                        {
                            Assert.AreEqual(absoluteURL, "/search");
                            WriteLogs("PASS : \"" + PageNameNew + "\" is Opened.");
                        }
                        if (IconName == "Suit Case Icon")
                        {
                            Assert.AreEqual(absoluteURL, ".villaplus.com/booking/");
                            WriteLogs("PASS : \"" + PageNameNew + "\" is Opened.");
                        }
                        if (IconName == "Back Icon")
                        {
                            window.Forward();
                            WriteLogs("INFO : Restored " + PageNameNew + " Page.");
                        }
                        else
                        {
                            window.Back();
                            WriteLogs("INFO : Restored " + PageName + " Page.");
                        }
                        delayExecution(strURL);
                    }
                }
                catch (Exception exlowlevel)
                {
                    WriteLogs("FAIL : Could Not Click \"" + IconName + "\" From " + PageName + " " + exlowlevel.Message);
                }
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : \"Header\" is Not Displayed on " + PageName + " " + ex.Message);
            }
        }
        public void verifyVillaDetailsNPrices(string strURL, List<string> VillaDetailsList, int VillaID, string VOPriceFromDB)
        {
            Tuple<HtmlDiv, HtmlDiv, HtmlDiv> returnValues = SRProperties();
            HtmlDiv VillaDetailsBox = returnValues.Item1;
            HtmlDiv HeaderDiv = returnValues.Item2;
            HtmlDiv ImageDiv = returnValues.Item3;
            UITestControlCollection AllBoxes = VillaDetailsBox.FindMatchingControls();
            foreach (UITestControl Box in AllBoxes)
            {
                #region
                HtmlImage img = new HtmlImage(Box);
                img.SearchProperties["alt"] = "";
                #endregion
                string Imgpath = img.GetProperty("src").ToString().Trim();
                int index = Imgpath.IndexOf('/');
                string ImgName = Imgpath.Substring(Imgpath.LastIndexOf('/'));
                string[] arr = ImgName.Split('_');
                int VillaIDFrmPage = Convert.ToInt32(arr[1]);

                if (VillaIDFrmPage == VillaID)
                {
                    String VillaHeader = Box.GetProperty("InnerText").ToString().Replace("\r\n", " ").Trim();
                    string CenterName = VillaHeader.Substring(VillaHeader.LastIndexOf(',')).Replace(',', ' ').Trim();
                    string VRName = VillaHeader.Remove(VillaHeader.LastIndexOf(',')).Trim();
                    string ResortName = VRName.Substring(VRName.LastIndexOf(' ')).Trim();
                    string VillaName = VRName.Remove(VRName.LastIndexOf(' ')).Trim();
                    string DetailsTxt = Box.GetProperty("InnerText").ToString().Replace("\r\n", " ").Trim();
                    //Get Villa Only Price//
                    string VOPriceFrmPage = DetailsTxt.Substring(DetailsTxt.IndexOf('£'));
                    string[] ArrVOprice = VOPriceFrmPage.Split(' ');
                    VOPriceFrmPage = ArrVOprice[0];
                    VOPriceFrmPage = VOPriceFrmPage.Replace("£", "").Trim();

                    string PKpriceFrmPage = string.Empty;
                    if (DetailsTxt.Trim().Contains("Book Villa & Flights"))
                    {
                        //Get Villa Package Price//
                        PKpriceFrmPage = DetailsTxt.Substring(DetailsTxt.LastIndexOf('£'));
                        string[] ArrPKprice = PKpriceFrmPage.Split(' ');
                        PKpriceFrmPage = ArrPKprice[0];
                        PKpriceFrmPage = PKpriceFrmPage.Replace("£", "").Trim();
                    }
                    //Compare VO Price From Page to DB Value//
                    try
                    {
                        if(VOPriceFromDB.Contains(".00"))
                        {
                            VOPriceFromDB = VOPriceFromDB.Replace(".00", "");
                        }
                        Assert.AreEqual(VOPriceFromDB, VOPriceFrmPage);
                        WriteLogs("PASS : \"Villa Only Price\" is Matched with DB for \"" + VillaName + "\" in \"Search Results Page\"");
                    }
                    catch (Exception ex)
                    {
                        WriteLogs("FAIL : \"Villa Only Price\" is Not Matched with DB for \"" + VillaName + "\" in \"Search Results Page\".");
                        WriteLogs("--------" + ex.Message.ToString());
                    }
                    //Get Refined Details//
                    string RefndVDetails = DetailsTxt.Remove(DetailsTxt.IndexOf("More")).Replace(" ", "").Trim();
                    foreach (string Detail in VillaDetailsList)
                    {
                        try
                        {
                            StringAssert.Contains(RefndVDetails, Detail.Replace(" ", "").Trim());
                        }
                        catch (Exception ex)
                        {
                            WriteLogs("FAIL : \"Villa Details( " + Detail.Replace(" ", "").Trim() + ")\" Shown are Not correct for \"" + VillaName + "\" in \"Search Results Page\".");
                            WriteLogs("--------" + ex.Message.ToString());
                        }
                    }WriteLogs("PASS : \"Villa Details\" are Shown correct for \"" + VillaName + "\" in \"Search Results Page\"");
                }
            }     
        }
        public List<int> getVillaID(string strURL)
        {
            Tuple<HtmlDiv, HtmlDiv, HtmlDiv> returnValues= SRProperties();
            HtmlDiv VillaDetailsBox = returnValues.Item1;

            List<int> VillaIDs = new List<int>();
            UITestControlCollection AllBoxes = VillaDetailsBox.FindMatchingControls();
            foreach (UITestControl Box in AllBoxes)
            {
                #region ImageDiv & Image Box Properties
                HtmlImage img = new HtmlImage(Box);
                img.SearchProperties["alt"] = "";
                #endregion
                string Imgpath = img.GetProperty("src").ToString().Trim();
                int index = Imgpath.IndexOf('/');
                string ImgName = Imgpath.Substring(Imgpath.LastIndexOf('/'));
                string[] arr = ImgName.Split('_');
                VillaIDs.Add(Convert.ToInt32(arr[1]));
            }
            return VillaIDs;
        }
        private Tuple<HtmlDiv, HtmlDiv, HtmlDiv> SRProperties()
        {
            HtmlDiv VillaDetailsBox;
            HtmlDiv VillaHeaderDiv;
            #region All Control Properties

            #region Window & Doc Properties
            var window = this.UIVillaHolidaysThatYouWindow;
            HtmlDocument DOC = new HtmlDocument(window);
            #endregion

            #region Search Results Div Properties
            HtmlDiv Div = new HtmlDiv(DOC);
            Div.SearchProperties["ControlType"] = "Pane";
            Div.SearchProperties["ID"] = "search-results";
            Div.SearchProperties["Tagname"] = "DIV";
            #endregion

            #region Villa Details Box Properties
            VillaDetailsBox = new HtmlDiv(Div);
            VillaDetailsBox.SearchProperties["ControlType"] = "Pane";
            VillaDetailsBox.SearchProperties["Tagname"] = "DIV";
            VillaDetailsBox.SearchProperties["Class"] = "result-item";
            #endregion

            #region Villa Header Properties
            VillaHeaderDiv = new HtmlDiv(Div);
            VillaHeaderDiv.SearchProperties["Class"] = "col-2";
            VillaHeaderDiv.SearchProperties["ClassName"] = "HtmlPane";
            #endregion

            #region ImageDiv & Image Box Properties
            HtmlDiv ImageDiv = new HtmlDiv(Div);
            ImageDiv.SearchProperties["Class"] = "result-img";

            //img = new HtmlImage(ImageDiv);
            //img.SearchProperties["alt"] = "";
            #endregion

            #endregion
            var returnValues = new Tuple<HtmlDiv, HtmlDiv,HtmlDiv>(VillaDetailsBox, VillaHeaderDiv, ImageDiv);
            return returnValues;
        }
    }
}
