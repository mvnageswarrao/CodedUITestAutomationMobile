﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.PaymentPage.enterCardNum_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class enterCardNum_Map:logWriter
    {
        
        /// <summary>
        /// enterCardNum_Method - Use 'enterCardNum_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enterCardNum_Method(string CCardNum)
        {
            #region Variable Declarations
            HtmlEdit uICreditCardCardNumberEdit = this.UIVillaPlusPaymentInteWindow.UIVillaPlusPaymentDocument.UICreditCardCardNumberEdit;
            #endregion
            try
            {
                uICreditCardCardNumberEdit.SetFocus();
                uICreditCardCardNumberEdit.Text = CCardNum;
                WriteLogs("PASS : \"" + CCardNum + "\" is entered as Card Number.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Could Not enter \"Credit Card\" Number.");
                WriteLogs("--------" + ex.Message.ToString());
            }           
        }
        
        #region Properties
        public virtual enterCardNum_MethodParams enterCardNum_MethodParams
        {
            get
            {
                if ((this.menterCardNum_MethodParams == null))
                {
                    this.menterCardNum_MethodParams = new enterCardNum_MethodParams();
                }
                return this.menterCardNum_MethodParams;
            }
        }
        
        public UIVillaPlusPaymentInteWindow UIVillaPlusPaymentInteWindow
        {
            get
            {
                if ((this.mUIVillaPlusPaymentInteWindow == null))
                {
                    this.mUIVillaPlusPaymentInteWindow = new UIVillaPlusPaymentInteWindow();
                }
                return this.mUIVillaPlusPaymentInteWindow;
            }
        }
        #endregion
        
        #region Fields
        private enterCardNum_MethodParams menterCardNum_MethodParams;
        
        private UIVillaPlusPaymentInteWindow mUIVillaPlusPaymentInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterCardNum_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class enterCardNum_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type '5123450000000008' in 'CreditCard.CardNumber' text box
        /// </summary>
        public string UICreditCardCardNumberEditText = "5123450000000008";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaPlusPaymentInteWindow : BrowserWindow
    {
        
        public UIVillaPlusPaymentInteWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus | Payment");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusPaymentDocument UIVillaPlusPaymentDocument
        {
            get
            {
                if ((this.mUIVillaPlusPaymentDocument == null))
                {
                    this.mUIVillaPlusPaymentDocument = new UIVillaPlusPaymentDocument(this);
                }
                return this.mUIVillaPlusPaymentDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusPaymentDocument mUIVillaPlusPaymentDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaPlusPaymentDocument : HtmlDocument
    {
        
        public UIVillaPlusPaymentDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "book";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/booking/payment", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/booking/payment", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus | Payment");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UICreditCardCardNumberEdit
        {
            get
            {
                if ((this.mUICreditCardCardNumberEdit == null))
                {
                    this.mUICreditCardCardNumberEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUICreditCardCardNumberEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "CreditCard.CardNumber";
                    this.mUICreditCardCardNumberEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "CreditCard.CardNumber";
                    this.mUICreditCardCardNumberEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUICreditCardCardNumberEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"CreditCard.CardNumber\" id=\"CreditC";
                    this.mUICreditCardCardNumberEdit.WindowTitles.Add("Villa Plus | Payment");
                    #endregion
                }
                return this.mUICreditCardCardNumberEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUICreditCardCardNumberEdit;
        #endregion
    }
}
