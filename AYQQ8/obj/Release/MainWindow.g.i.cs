﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8820036826679EBEE583718B43553F8BE513FD5EDD069C855D6ED1FC11D16ACB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AYQQ8;
using AYQQ8.Controls;
using Ay.Framework.WPF.Controls;
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


namespace AYQQ8 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Ay.Framework.WPF.Controls.AyWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.TransitionPresenter windowcontent;
        
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
            System.Uri resourceLocater = new System.Uri("/AYQQ8;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((AYQQ8.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.AyWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.windowcontent = ((Ay.Framework.WPF.Controls.TransitionPresenter)(target));
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
            
            #line 110 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShowBack_Click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 126 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMin_Click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 132 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            
            #line 132 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.closeWindow_LostKeyboardFocus);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 174 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.PasswordBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.pb_Loaded);
            
            #line default
            #line hidden
            
            #line 174 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.PasswordBox)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.pb_MouseEnter);
            
            #line default
            #line hidden
            
            #line 174 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.PasswordBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.pb_MouseLeave);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 230 "..\..\MainWindow.xaml"
            ((Ay.Framework.WPF.Controls.AyImageButton)(target)).Loaded += new System.Windows.RoutedEventHandler(this.btnPwdKeboard_Loaded);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 236 "..\..\MainWindow.xaml"
            ((Ay.Framework.WPF.Controls.PopupEx)(target)).Loaded += new System.Windows.RoutedEventHandler(this.pwdPopup_Loaded);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 240 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Border_Loaded);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 241 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).Loaded += new System.Windows.RoutedEventHandler(this.pwdBorder_Loaded);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 244 "..\..\MainWindow.xaml"
            ((Ay.Framework.WPF.Controls.AyHyberTextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AyHyberTextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 245 "..\..\MainWindow.xaml"
            ((Ay.Framework.WPF.Controls.AyHyberTextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AyHyberTextBlock_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 246 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 297 "..\..\MainWindow.xaml"
            ((Ay.Framework.WPF.Controls.AyTextBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.bindemail_Loaded);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 302 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShowFront_Click);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 304 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMin_Click);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 310 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.closeWindow_LostKeyboardFocus_1);
            
            #line default
            #line hidden
            
            #line 310 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
