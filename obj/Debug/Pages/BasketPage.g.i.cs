﻿#pragma checksum "..\..\..\Pages\BasketPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEC3867F056D2E46FC7841DF9FD02F91E68208431098EC171B3185C750E38345"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TartugaLeksikovIzrancev.Pages;


namespace TartugaLeksikovIzrancev.Pages {
    
    
    /// <summary>
    /// BasketPage
    /// </summary>
    public partial class BasketPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 38 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvOrder;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTable;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbPrice;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMoney;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbCard;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPromocode;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPromocode;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\Pages\BasketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoBasket;
        
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
            System.Uri resourceLocater = new System.Uri("/TartugaLeksikovIzrancev;component/pages/basketpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\BasketPage.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\BasketPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvOrder = ((System.Windows.Controls.ListView)(target));
            
            #line 65 "..\..\..\Pages\BasketPage.xaml"
            this.lvOrder.KeyDown += new System.Windows.Input.KeyEventHandler(this.lvOrder_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbTable = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.rbMoney = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.rbCard = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.tbPromocode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnPromocode = ((System.Windows.Controls.Button)(target));
            
            #line 225 "..\..\..\Pages\BasketPage.xaml"
            this.btnPromocode.Click += new System.Windows.RoutedEventHandler(this.btnPromocode_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnGoBasket = ((System.Windows.Controls.Button)(target));
            
            #line 239 "..\..\..\Pages\BasketPage.xaml"
            this.btnGoBasket.Click += new System.Windows.RoutedEventHandler(this.btnGoBasket_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 126 "..\..\..\Pages\BasketPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMinus_Click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 146 "..\..\..\Pages\BasketPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnPlus_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

