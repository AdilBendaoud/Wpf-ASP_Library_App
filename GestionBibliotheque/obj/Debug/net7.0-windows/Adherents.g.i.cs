﻿#pragma checksum "..\..\..\Adherents.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C80271E61374504E0E746F7C37395959D76ACCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using GestionBibliotheque;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace GestionBibliotheque {
    
    
    /// <summary>
    /// Adherents
    /// </summary>
    public partial class Adherents : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 110 "..\..\..\Adherents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button empBtn;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Adherents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchInput;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Adherents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestionBibliotheque;component/adherents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Adherents.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\Adherents.xaml"
            ((GestionBibliotheque.Adherents)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.HandleDragWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaximizeBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 71 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EmprruntHandle);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 88 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LivreHandle);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 96 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AuteursHandle);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 103 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.empBtn = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\Adherents.xaml"
            this.empBtn.Click += new System.Windows.RoutedEventHandler(this.goToEmployees);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 118 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignOut);
            
            #line default
            #line hidden
            return;
            case 11:
            this.searchInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 136 "..\..\..\Adherents.xaml"
            this.searchInput.KeyUp += new System.Windows.Input.KeyEventHandler(this.Search);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 153 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExporteBtn);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 159 "..\..\..\Adherents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportBtn);
            
            #line default
            #line hidden
            return;
            case 14:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 168 "..\..\..\Adherents.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

