﻿#pragma checksum "C:\Users\apple\source\repos\App1\App1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB6C013FFC3C250BD2A150535220B106"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.checkbox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 21 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.checkbox).Click += this.checkBox_check;
                    #line default
                }
                break;
            case 2:
                {
                    this.line = (global::Windows.UI.Xaml.Shapes.Line)(target);
                }
                break;
            case 3:
                {
                    this.Goto_button = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Goto_button).Click += this.Goto_button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

