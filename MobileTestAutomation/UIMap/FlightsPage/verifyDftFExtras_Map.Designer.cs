﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.FlightsPage.verifyDftFExtras_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class verifyDftFExtras_Map:logWriter
    {
        
        /// <summary>
        /// verifyDftFExtras_Method - Use 'verifyDftFExtras_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Tuple<bool,string> verifyDftFExtras_Method()
        {
            #region Variable Declarations
            HtmlDiv uITravellinglightMostaPane = this.UIHttpmobstagingvillapWindow.UIHttpmobstagingvillapDocument.UIMsgLocPane.UITravellinglightMostaPane;
            #endregion
            Boolean IsFExtrsAvaialable = true;
            string DfltFExtrasTxt = uITravellinglightMostaPane.InnerText;

            String ExpFExtrasTxt = "Travellinglight?Mostairlinesnowchargeanadditionalfeeperpersontocheckinluggage.Thisisluggagethatisstoredintheholdandwillnotbeaccessibleduringtheflight.Youcanchoosepreciselyhowmanybagsyouneedbysimplyusingtheoptionsavailablebelow.";
            string ExpFExtrasTxt1 = "Thereseemstobeanissueinlocatingthebaggageinformationforthisflight";
            string ExpFExtrasTxt2 = "Yourselectedflightwillautomaticallyinclude1holdallbagperperson(excludinginfants).Yourbaggageallowancewillbeconfirmedonyourinvoice.";
            try
            {
                DfltFExtrasTxt = DfltFExtrasTxt.Replace("\r\n", "").Replace(" ", "");
                
                if (DfltFExtrasTxt.Contains(ExpFExtrasTxt) || DfltFExtrasTxt.Contains("+"))
                {
                    //StringAssert.Contains(DfltFExtrasTxt, ExpFExtrasTxt);
                    int indx = DfltFExtrasTxt.IndexOf('-');
                    DfltFExtrasTxt = DfltFExtrasTxt.Substring(indx).Trim();

                    if (DfltFExtrasTxt.Contains("+"))
                    {
                        IsFExtrsAvaialable = true;
                    }
                    WriteLogs("PASS : \"Flights Extras\" are avaialable for the selected flight.");
                }
                else if (DfltFExtrasTxt.Contains(ExpFExtrasTxt1))
                {
                    StringAssert.Contains(DfltFExtrasTxt, ExpFExtrasTxt1);
                    IsFExtrsAvaialable = false;
                    WriteLogs("INFO : \"Flights Extras\" are NOT avaialable for the selected flight.");
                }
                else if (DfltFExtrasTxt.Contains(ExpFExtrasTxt2))
                {
                    StringAssert.Contains(DfltFExtrasTxt, ExpFExtrasTxt2);
                    //IsFExtrsAvaialable = false;
                    WriteLogs("INFO : \"Flights Extras\" are NOT avaialable for the selected flight.");
                }
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : \"Flights Extras\" are NOT avaialable for the selected flight.");
                WriteLogs("--------" + ex.Message.ToString());
            }
            Tuple<bool, string> values = new Tuple<bool , string >(IsFExtrsAvaialable, DfltFExtrasTxt);
            return values;
        }
        
        #region Properties
        public virtual verifyDftFExtras_MethodExpectedValues verifyDftFExtras_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyDftFExtras_MethodExpectedValues == null))
                {
                    this.mverifyDftFExtras_MethodExpectedValues = new verifyDftFExtras_MethodExpectedValues();
                }
                return this.mverifyDftFExtras_MethodExpectedValues;
            }
        }
        
        public UIHttpmobstagingvillapWindow UIHttpmobstagingvillapWindow
        {
            get
            {
                if ((this.mUIHttpmobstagingvillapWindow == null))
                {
                    this.mUIHttpmobstagingvillapWindow = new UIHttpmobstagingvillapWindow();
                }
                return this.mUIHttpmobstagingvillapWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyDftFExtras_MethodExpectedValues mverifyDftFExtras_MethodExpectedValues;
        
        private UIHttpmobstagingvillapWindow mUIHttpmobstagingvillapWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyDftFExtras_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class verifyDftFExtras_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Travelling light? Most airlines now char' pane equals '
        ///
        /// 
        ///
        ///Travelling light? Most airlines now charge an additional fee per person to check in luggage. This is luggage that is stored in the hold and will not be accessible during the flight. You can choose precisely how many bags you need by simply using the options available below.
        ///
        ///- 
        ///0  x Check-in Bags (20kg)  - 0.00
        ///+ 
        ///- 
        ///6  x Check-in Bags (15kg)  - 282.00
        ///+ 
        ///- 
        ///4  x Golf Luggages  - 272.00
        ///+ 
        ///- 
        ///4  x Bicycle  - 432.00
        ///+ 
        ///- 
        ///4  x Ski  - 352.00
        ///+ 
        ///- 
        ///4  x Musical Inst (Excl. Cellos)  - 432.00
        ///+ 
        ///- 
        ///4  x Bike  - 512.00
        ///+ 
        ///- 
        ///4  x Other Small Sporting Equipment  - 272.00
        ///+ '
        /// </summary>
        public string UITravellinglightMostaPaneInnerText = @"

 

Travelling light? Most airlines now charge an additional fee per person to check in luggage. This is luggage that is stored in the hold and will not be accessible during the flight. You can choose precisely how many bags you need by simply using the options available below.

- 
0  x Check-in Bags (20kg)  - 0.00
+ 
- 
6  x Check-in Bags (15kg)  - 282.00
+ 
- 
4  x Golf Luggages  - 272.00
+ 
- 
4  x Bicycle  - 432.00
+ 
- 
4  x Ski  - 352.00
+ 
- 
4  x Musical Inst (Excl. Cellos)  - 432.00
+ 
- 
4  x Bike  - 512.00
+ 
- 
4  x Other Small Sporting Equipment  - 272.00
+ ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttpmobstagingvillapWindow : BrowserWindow
    {
        
        public UIHttpmobstagingvillapWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpmobstagingvillapDocument UIHttpmobstagingvillapDocument
        {
            get
            {
                if ((this.mUIHttpmobstagingvillapDocument == null))
                {
                    this.mUIHttpmobstagingvillapDocument = new UIHttpmobstagingvillapDocument(this);
                }
                return this.mUIHttpmobstagingvillapDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpmobstagingvillapDocument mUIHttpmobstagingvillapDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHttpmobstagingvillapDocument : HtmlDocument
    {
        
        public UIHttpmobstagingvillapDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        #region Properties
        public UIMsgLocPane UIMsgLocPane
        {
            get
            {
                if ((this.mUIMsgLocPane == null))
                {
                    this.mUIMsgLocPane = new UIMsgLocPane(this);
                }
                return this.mUIMsgLocPane;
            }
        }
        #endregion
        
        #region Fields
        private UIMsgLocPane mUIMsgLocPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMsgLocPane : HtmlDiv
    {
        
        public UIMsgLocPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "msgLoc";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Flights\r\n \r\n\r\nVilla & Flight\r\n\r\nDetails\r", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "wrapper";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"wrapper\" id=\"msgLoc\"";
            this.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UITravellinglightMostaPane
        {
            get
            {
                if ((this.mUITravellinglightMostaPane == null))
                {
                    this.mUITravellinglightMostaPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUITravellinglightMostaPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Travelling light?", PropertyExpressionOperator.Contains));
                    this.mUITravellinglightMostaPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "wrapper";
                    this.mUITravellinglightMostaPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"wrapper\" style=\"background: rgb(255, 255, 255); margin: 1px 10px 0px; padd" +
                        "ing: 15px 20px 1px;\"";
                    this.mUITravellinglightMostaPane.WindowTitles.Add("http://mobstaging.villaplus.com/booking/");
                    #endregion
                }
                return this.mUITravellinglightMostaPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUITravellinglightMostaPane;
        #endregion
    }
}
