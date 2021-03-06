﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MobileTestAutomation.UIMap.SearchPage.enterDestnameSearchLayer_MapClasses
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
    public partial class enterDestnameSearchLayer_Map:logWriter
    {
        
        /// <summary>
        /// enterDestnameSearchLayer_Method - Use 'enterDestnameSearchLayer_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enterDestnameSearchLayer_Method()
        {
            #region Variable Declarations
            HtmlEdit uITxtNameEdit = this.UISearchVillaPlusWindoWindow.UISearchVillaPlusDocument.UITxtNameEdit;
            #endregion

            // Type 'alg' in 'txtName' text box
            try
            {
                uITxtNameEdit.Text = this.enterDestnameSearchLayer_MethodParams.UITxtNameEditText;
                WriteLogs("search centre alg entered correctly:Pass");
            }
            catch (Exception ex)
            {
                WriteLogs("Issue entering create name : Fail" + ex.ToString());
            }
        }
        
        #region Properties
        public virtual enterDestnameSearchLayer_MethodParams enterDestnameSearchLayer_MethodParams
        {
            get
            {
                if ((this.menterDestnameSearchLayer_MethodParams == null))
                {
                    this.menterDestnameSearchLayer_MethodParams = new enterDestnameSearchLayer_MethodParams();
                }
                return this.menterDestnameSearchLayer_MethodParams;
            }
        }
        
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
        private enterDestnameSearchLayer_MethodParams menterDestnameSearchLayer_MethodParams;
        
        private UISearchVillaPlusWindoWindow mUISearchVillaPlusWindoWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterDestnameSearchLayer_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class enterDestnameSearchLayer_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'alg' in 'txtName' text box
        /// </summary>
        public string UITxtNameEditText = "alg";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UISearchVillaPlusDocument : HtmlDocument
    {
        
        public UISearchVillaPlusDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Id, "", PropertyExpressionOperator.Contains));
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Search | Villa Plus";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/search", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://m.villaplus.com/search", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Search | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UITxtNameEdit
        {
            get
            {
                if ((this.mUITxtNameEdit == null))
                {
                    this.mUITxtNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtNameEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Id, "txtName", PropertyExpressionOperator.Contains));
                    this.mUITxtNameEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Type, "SINGLELINE", PropertyExpressionOperator.Contains));
                    this.mUITxtNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = "";
                    this.mUITxtNameEdit.FilterProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Class, "top-input", PropertyExpressionOperator.Contains));
                    this.mUITxtNameEdit.FilterProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.ControlDefinition, "class=\"top-input\" id=\"txtName\" value=\"En", PropertyExpressionOperator.Contains));
                    this.mUITxtNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUITxtNameEdit.WindowTitles.Add("Search | Villa Plus");
                    #endregion
                }
                return this.mUITxtNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtNameEdit;
        #endregion
    }
}
