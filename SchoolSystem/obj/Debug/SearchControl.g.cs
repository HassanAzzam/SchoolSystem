﻿#pragma checksum "..\..\SearchControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09371EEC6DC62B75A6CF97E06E4A2933"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SchoolSystem;
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


namespace SchoolSystem {
    
    
    /// <summary>
    /// SearchControl
    /// </summary>
    public partial class SearchControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedYear;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedClass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel DisplayList;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy3;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedLocation;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SearchControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy4;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolSystem;component/searchcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchControl.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textBlock_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textBlock_Copy1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.textBlock_Copy2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.SelectedName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\SearchControl.xaml"
            this.SelectedName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SelectedYear = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\SearchControl.xaml"
            this.SelectedYear.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SelectedClass = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\SearchControl.xaml"
            this.SelectedClass.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DisplayList = ((System.Windows.Controls.WrapPanel)(target));
            
            #line 25 "..\..\SearchControl.xaml"
            this.DisplayList.MouseMove += new System.Windows.Input.MouseEventHandler(this.DisplayList_MouseMove);
            
            #line default
            #line hidden
            
            #line 25 "..\..\SearchControl.xaml"
            this.DisplayList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DisplayList_MouseLeave);
            
            #line default
            #line hidden
            
            #line 25 "..\..\SearchControl.xaml"
            this.DisplayList.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DisplayList_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textBlock_Copy3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.SelectedLocation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\SearchControl.xaml"
            this.SelectedLocation.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBlock_Copy4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

