﻿#pragma checksum "..\..\..\..\View\CreateMaterialWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F8B72AB00F02BCC564643BA013349D0C1827B4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Nordlangelands_Tækkemand;
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


namespace Nordlangelands_Tækkemand {
    
    
    /// <summary>
    /// CreateMaterialWindow
    /// </summary>
    public partial class CreateMaterialWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NavnT;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ThatchingTypeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton WoodTypeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton VariousTypeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StockCountTextBox;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StorageIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\View\CreateMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Nordlangelands Tækkemand;component/view/creatematerialwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\CreateMaterialWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NavnT = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ThatchingTypeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.WoodTypeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.VariousTypeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.StockCountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.StorageIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

