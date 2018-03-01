﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.SearchPage.clickPlusIconforInfants_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class clickPlusIconforInfants_Map:logWriter
    {
        
        /// <summary>
        /// clickPlusIconforInfants_Method
        /// </summary>
        public List<object> clickPlusIconforInfants_Method(int NumofADULTSSelected)
        {
            #region Variable Declarations
            HtmlSpan uIItemPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane.UIItemPane;
            HtmlControl UIItem0InfantsPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane;
            #endregion

            int NumofInfantsSelected = 0;
            Boolean Minustobeclicked = false;

            string defltInfants = UIItem0InfantsPane.InnerText;
            string[] arrdefltInfants = defltInfants.Split(' ');
            defltInfants = arrdefltInfants[1].Replace("\r\n", string.Empty);
            int defltNumofInfants = Convert.ToInt32(defltInfants);

            if (defltNumofInfants > NumofADULTSSelected)
            {
                Minustobeclicked = true;
            }
            else if (defltNumofInfants == 0)
            {
                Random rnd = new Random();
                int randomInfantindex = rnd.Next(0, NumofADULTSSelected);
                int SelectableInfants = randomInfantindex;

                while (defltNumofInfants != SelectableInfants)
                {
                    // Click '+' pane
                    Mouse.Click(uIItemPane);
                    defltInfants = UIItem0InfantsPane.InnerText;
                    arrdefltInfants = defltInfants.Split(' ');
                    defltInfants = arrdefltInfants[1].Replace("\r\n", string.Empty);
                    defltNumofInfants = Convert.ToInt32(defltInfants);
                }
                NumofInfantsSelected = defltNumofInfants;
                WriteLogs("PASS : \"" + NumofInfantsSelected + "\" Infants Selected.");
            }
            else
            {
                NumofInfantsSelected = defltNumofInfants;
                WriteLogs("PASS : \"" + NumofInfantsSelected + "\" Infants Selected.");
            }

            List<object> returnvaluesForInfants = new List<object>();
            returnvaluesForInfants.Add(Minustobeclicked);
            returnvaluesForInfants.Add(NumofInfantsSelected);

            return returnvaluesForInfants;
        }

        public int clickPlusIconforMoreInfantsthanAdults_Method(int DefaultAdults)
        {
            #region Variable Declarations
            HtmlSpan uIItemPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane.UIItemPane;
            HtmlControl UIItem0InfantsPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane;
            #endregion
            
            int NumofInfantsSelected = 0;

            string defltInfants = UIItem0InfantsPane.InnerText;
            string[] arrdefltInfants = defltInfants.Split(' ');
            defltInfants = arrdefltInfants[1].Replace("\r\n", string.Empty);
            int defltNumofInfants = Convert.ToInt32(defltInfants);

            while (defltNumofInfants < (DefaultAdults+1))
            {
                // Click '+' pane
                Mouse.Click(uIItemPane);
                defltInfants = UIItem0InfantsPane.InnerText;
                arrdefltInfants = defltInfants.Split(' ');
                defltInfants = arrdefltInfants[1].Replace("\r\n", string.Empty);
                defltNumofInfants = Convert.ToInt32(defltInfants);
            }
            NumofInfantsSelected = defltNumofInfants;
            WriteLogs("PASS : \"" + NumofInfantsSelected + "\" Infants Selected.");

            return NumofInfantsSelected;
        }

        public void verifyPlusFrInfantsDisabled_Method()
        {
            #region Variable Declarations
            HtmlSpan uIItemPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane.UIItemPane;
            HtmlControl UIItem0InfantsPane = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UIItem0InfantsPane;
            #endregion

            string defltInfants = UIItem0InfantsPane.InnerText;
            string[] arrdefltInfants = defltInfants.Split(' ');
            defltInfants = arrdefltInfants[1].Replace("\r\n", string.Empty);
            int defltNumofInfants = Convert.ToInt32(defltInfants);

            Boolean isPlusDisabled = uIItemPane.ControlDefinition.Contains("disabled");

            while (isPlusDisabled != true)
            {
                Mouse.Click(uIItemPane);
                isPlusDisabled = uIItemPane.ControlDefinition.Contains("disabled");
            }
            WriteLogs("PASS : + icon for Infants has been disabled.");
  
        }

        #region Properties
        public UISearchVillaPlusWindoWindow UISearchVillaPlusWindoWindow
        {
            get
            {
                if ((this.mUISearchVillaPlusWindoWindow == null))
                {
                    this.mUISearchVillaPlusWindoWindow = new UISearchVillaPlusWindoWindow();
                }
                return this.mUISearchVillaPlusWindoWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISearchVillaPlusWindoWindow mUISearchVillaPlusWindoWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISearchVillaPlusWindoWindow : BrowserWindow
    {
        
        public UISearchVillaPlusWindoWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Search | Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Search | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UISearchVillaPlusDocument UISearchVillaPlusDocument
        {
            get
            {
                if ((this.mUISearchVillaPlusDocument == null))
                {
                    this.mUISearchVillaPlusDocument = new UISearchVillaPlusDocument(this);
                }
                return this.mUISearchVillaPlusDocument;
            }
        }
        #endregion
        
        #region Fields
        private UISearchVillaPlusDocument mUISearchVillaPlusDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISearchVillaPlusDocument : HtmlDocument
    {
        
        public UISearchVillaPlusDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Search | Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/search", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/search", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Search | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIItem0InfantsPane UIItem0InfantsPane
        {
            get
            {
                if ((this.mUIItem0InfantsPane == null))
                {
                    this.mUIItem0InfantsPane = new UIItem0InfantsPane(this);
                }
                return this.mUIItem0InfantsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIItem0InfantsPane mUIItem0InfantsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem0InfantsPane : HtmlDiv
    {
        
        public UIItem0InfantsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "infantselector";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Infants", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "minus-plus";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"minus-plus\" id=\"infantselector\"", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Search | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "+";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "icon-plus";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"icon-plus\"";
                    this.mUIItemPane.WindowTitles.Add("Search | Villa Plus");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIItemPane;
        #endregion
    }
}
