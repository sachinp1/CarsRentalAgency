﻿#pragma checksum "..\..\Window2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12CC6001EDBEF157C7CBB54513D73D68830A7DEE17D60E427F1F364742618CF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarsRentalAgency;
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


namespace CarsRentalAgency {
    
    
    /// <summary>
    /// Window2
    /// </summary>
    public partial class Window2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 113 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grd_Menu;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rentingcar;
        
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
            System.Uri resourceLocater = new System.Uri("/CarsRentalAgency;component/window2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window2.xaml"
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
            
            #line 8 "..\..\Window2.xaml"
            ((CarsRentalAgency.Window2)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 43 "..\..\Window2.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 54 "..\..\Window2.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 65 "..\..\Window2.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 73 "..\..\Window2.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_2);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 106 "..\..\Window2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Final_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Grd_Menu = ((System.Windows.Controls.Grid)(target));
            
            #line 113 "..\..\Window2.xaml"
            this.Grd_Menu.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Grd_Menu_MouseEnter);
            
            #line default
            #line hidden
            
            #line 113 "..\..\Window2.xaml"
            this.Grd_Menu.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Grd_Menu_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rentingcar = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\Window2.xaml"
            this.rentingcar.Click += new System.Windows.RoutedEventHandler(this.Btn_rent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
