﻿#pragma checksum "..\..\InsertStudent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2427752E00F05E8CDA8822CF51009337"
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
    /// InsertStudent
    /// </summary>
    public partial class InsertStudent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentYear;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentClass;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AddStudent;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RespondMessage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\InsertStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentID;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolSystem;component/insertstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsertStudent.xaml"
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
            this.StudentName = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\InsertStudent.xaml"
            this.StudentName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StudentYear = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\InsertStudent.xaml"
            this.StudentYear.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StudentClass = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\InsertStudent.xaml"
            this.StudentClass.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddStudent = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\InsertStudent.xaml"
            this.AddStudent.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AddStudent_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RespondMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.StudentID = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\InsertStudent.xaml"
            this.StudentID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
