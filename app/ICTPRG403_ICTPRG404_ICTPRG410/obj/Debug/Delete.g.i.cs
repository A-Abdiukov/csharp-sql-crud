﻿#pragma checksum "..\..\Delete.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1903E88CDA03C04C42FB245361D15808077CBA0D0735816A5F63029C530E808D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ICTPRG403_ICTPRG404_ICTPRG410;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ICTPRG403_ICTPRG404_ICTPRG410 {
    
    
    /// <summary>
    /// Delete
    /// </summary>
    public partial class Delete : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_FirstName_ReadOnly;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_LastName_ReadOnly;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Height_ReadOnly;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Weight_ReadOnly;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Id_ReadOnly;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_GoBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ICTPRG403_ICTPRG404_ICTPRG410;component/delete.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Delete.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtbox_FirstName_ReadOnly = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtbox_LastName_ReadOnly = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtbox_Height_ReadOnly = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtbox_Weight_ReadOnly = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Delete.xaml"
            this.Btn_Delete.Click += new System.Windows.RoutedEventHandler(this.Btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtbox_Id_ReadOnly = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Btn_GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Delete.xaml"
            this.Btn_GoBack.Click += new System.Windows.RoutedEventHandler(this.Btn_GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

