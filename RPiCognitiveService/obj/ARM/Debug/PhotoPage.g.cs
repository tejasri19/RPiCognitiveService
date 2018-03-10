﻿#pragma checksum "C:\Users\ShiJiong\Documents\Visual Studio 2017\Projects\RPiCognitiveService\RPiCognitiveService\PhotoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B079B2AA2CD2F04033E0D9BD27ED4FAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPiCognitiveService
{
    partial class PhotoPage : 
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
                    this.spMain = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.stpPreview = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.grdPicker = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.ringLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5:
                {
                    this.txtLocation = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.gridFaces = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.gridTags = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.gridDesc = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.txtDesc = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.txtDesc_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.txtAdult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.txtAdult_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.txtRacy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.txtRacy_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.lstFiles = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 92 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).KeyUp += this.lstFiles_KeyUp;
                    #line 92 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).DoubleTapped += this.lstFiles_DoubleTapped;
                    #line default
                }
                break;
            case 16:
                {
                    this.lblBreadcrumb = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.btnSelect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 88 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSelect).Click += this.btnSelect_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 89 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.ImageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.PhotoCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 21:
                {
                    this.captureImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 22:
                {
                    this.PreviewTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.PreviewCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 24:
                {
                    this.previewElement = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 25:
                {
                    this.imgPhoto = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 44 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgPhoto).ImageOpened += this.imgPhoto_ImageOpened;
                    #line default
                }
                break;
            case 26:
                {
                    this.cvasMain = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    #line 51 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.cvasMain).SizeChanged += this.cvasMain_SizeChanged;
                    #line default
                }
                break;
            case 27:
                {
                    this.txtFileName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 30 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtFileName).TextChanged += this.txtFileName_TextChanged;
                    #line default
                }
                break;
            case 28:
                {
                    this.btnOpen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpen).Click += this.btnOpen_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.btnBrowse = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBrowse).Click += this.btnBrowse_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClear).Click += this.btnClear_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.btnShow = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnShow).Click += this.btnShow_Click;
                    #line default
                }
                break;
            case 32:
                {
                    this.btnTakePhoto = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnTakePhoto).Click += this.takePhoto_Click;
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
