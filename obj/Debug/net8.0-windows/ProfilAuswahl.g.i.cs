﻿#pragma checksum "..\..\..\ProfilAuswahl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4032DBA6BCEE10E0C1A67E01C749952114A2D8D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BudgetPlaner {
    
    
    /// <summary>
    /// ProfilAuswahl
    /// </summary>
    public partial class ProfilAuswahl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ProfilAuswahl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProfileListe;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ProfilAuswahl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfilAuswaehlenButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ProfilAuswahl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfilBearbeitenButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ProfilAuswahl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfilLoeschenButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ProfilAuswahl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NeuesProfilButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BudgetPlaner;component/profilauswahl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ProfilAuswahl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProfileListe = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.ProfilAuswaehlenButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\ProfilAuswahl.xaml"
            this.ProfilAuswaehlenButton.Click += new System.Windows.RoutedEventHandler(this.ProfilAuswaehlen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProfilBearbeitenButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ProfilAuswahl.xaml"
            this.ProfilBearbeitenButton.Click += new System.Windows.RoutedEventHandler(this.ProfilBearbeiten_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProfilLoeschenButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ProfilAuswahl.xaml"
            this.ProfilLoeschenButton.Click += new System.Windows.RoutedEventHandler(this.ProfilLoeschen_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NeuesProfilButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\ProfilAuswahl.xaml"
            this.NeuesProfilButton.Click += new System.Windows.RoutedEventHandler(this.NeuesProfilErstellen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

