﻿#pragma checksum "..\..\..\UserInterface.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21A3BF46D479759A4DEFDC82DE79707E3D2FCD65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome5;
using FontAwesome5.Converters;
using Nomadic;
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


namespace Nomadic {
    
    
    /// <summary>
    /// UserInterface
    /// </summary>
    public partial class UserInterface : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listFiles;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Bar;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSync;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpload;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewFile;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowFiles;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRecent;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\UserInterface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoved;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Nomadic;component/userinterface.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserInterface.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.listFiles = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Bar = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.btnSync = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\UserInterface.xaml"
            this.btnSync.Click += new System.Windows.RoutedEventHandler(this.btnSync_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnUpload = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\UserInterface.xaml"
            this.btnUpload.Click += new System.Windows.RoutedEventHandler(this.btnUpload_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnNewFile = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UserInterface.xaml"
            this.btnNewFile.Click += new System.Windows.RoutedEventHandler(this.btnNewFile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnShowFiles = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\UserInterface.xaml"
            this.btnShowFiles.Click += new System.Windows.RoutedEventHandler(this.btnShowFiles_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRecent = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\UserInterface.xaml"
            this.btnRecent.Click += new System.Windows.RoutedEventHandler(this.btnRecent_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRemoved = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\UserInterface.xaml"
            this.btnRemoved.Click += new System.Windows.RoutedEventHandler(this.btnNewFile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
