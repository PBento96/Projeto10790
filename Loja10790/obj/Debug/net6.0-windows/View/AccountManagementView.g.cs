﻿#pragma checksum "..\..\..\..\View\AccountManagementView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08611E7D5669DADD6A24904E49D13E06D3DFD962"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Loja10790.View;
using Loja10790.View.UserControls;
using Loja10790.View.User_Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Loja10790.View {
    
    
    /// <summary>
    /// AccountManagementView
    /// </summary>
    public partial class AccountManagementView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmployeeAccounts;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClientAccounts;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAccounts;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Loja10790.View.User_Controls.ClearableTextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnView;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\View\AccountManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Loja10790;component/view/accountmanagementview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AccountManagementView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEmployeeAccounts = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnEmployeeAccounts.Click += new System.Windows.RoutedEventHandler(this.btnEmployeeAccounts_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClientAccounts = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnClientAccounts.Click += new System.Windows.RoutedEventHandler(this.btnClientAccounts_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgAccounts = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.txtSearch = ((Loja10790.View.User_Controls.ClearableTextBox)(target));
            return;
            case 6:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnView_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnView = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnView.Click += new System.Windows.RoutedEventHandler(this.btnView_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 171 "..\..\..\..\View\AccountManagementView.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

