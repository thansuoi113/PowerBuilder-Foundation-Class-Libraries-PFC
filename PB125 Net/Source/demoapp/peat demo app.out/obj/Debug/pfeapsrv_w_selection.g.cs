﻿#pragma checksum "..\..\pfeapsrv_w_selection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "149153862B16F068351893BC889860B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sybase.PowerBuilder.WPF.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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




/// <summary>
/// w_selection
/// </summary>
public partial class w_selection : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfeapsrv_w_selection.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_cancel;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfeapsrv_w_selection.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_ok;
    
    #line default
    #line hidden
    
    
    #line 5 "..\..\pfeapsrv_w_selection.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.DataWindow dw_1;
    
    #line default
    #line hidden
    
    private bool _contentLoaded;
    
    /// <summary>
    /// InitializeComponent
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public void InitializeComponent() {
        if (_contentLoaded) {
            return;
        }
        _contentLoaded = true;
        System.Uri resourceLocater = new System.Uri("/peat;component/pfeapsrv_w_selection.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfeapsrv_w_selection.xaml"
        System.Windows.Application.LoadComponent(this, resourceLocater);
        
        #line default
        #line hidden
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
        this.cb_cancel = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 2:
        this.cb_ok = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 3:
        this.dw_1 = ((Sybase.PowerBuilder.WPF.Controls.DataWindow)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

