﻿#pragma checksum "..\..\..\..\Pages\IngredientsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D043C836E934E9A783D00C7ECA1AD1B659B135D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt.Pages;
using Projekt.Properties;
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


namespace Projekt.Pages {
    
    
    /// <summary>
    /// IngredientsPage
    /// </summary>
    public partial class IngredientsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Ingredients_listview;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name_textbox;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Kcal_textbox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Protein_textbox;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Fat_textbox;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Carbs_textbox;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DietType_combobox;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Pages\IngredientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projekt;component/pages/ingredientspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\IngredientsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Ingredients_listview = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Name_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Kcal_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Protein_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Fat_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Carbs_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.DietType_combobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Add_button = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\..\..\Pages\IngredientsPage.xaml"
            this.Add_button.Click += new System.Windows.RoutedEventHandler(this.Add_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

