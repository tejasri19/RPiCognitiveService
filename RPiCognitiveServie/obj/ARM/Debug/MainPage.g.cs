﻿#pragma checksum "C:\Users\ShiJiong\Documents\Visual Studio 2017\Projects\RPiCognitiveServie\RPiCognitiveServie\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A153E667EF07C122940718FF77523337"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPiCognitiveServie
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
                    this.navSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.ListView element2 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 13 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)element2).SelectionChanged += this.ListView_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.frmPages = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
