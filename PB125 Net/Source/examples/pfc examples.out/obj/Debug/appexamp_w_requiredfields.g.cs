﻿#pragma checksum "..\..\appexamp_w_requiredfields.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A7DFE0E4E23DF9A625CF6C9A5B6EBF7"
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
/// w_requiredfields
/// </summary>
public partial class w_requiredfields : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\appexamp_w_requiredfields.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CheckBox cbx_required;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\appexamp_w_requiredfields.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_close;
    
    #line default
    #line hidden
    
    
    #line 5 "..\..\appexamp_w_requiredfields.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_checkrequired;
    
    #line default
    #line hidden
    
    
    #line 6 "..\..\appexamp_w_requiredfields.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_2;
    
    #line default
    #line hidden
    
    
    #line 7 "..\..\appexamp_w_requiredfields.xaml"
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
        System.Uri resourceLocater = new System.Uri("/pfcexamp;component/appexamp_w_requiredfields.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\appexamp_w_requiredfields.xaml"
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
        this.cbx_required = ((Sybase.PowerBuilder.WPF.Controls.CheckBox)(target));
        return;
            case 2:
        this.cb_close = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 3:
        this.cb_checkrequired = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 4:
        this.st_2 = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 5:
        this.dw_1 = ((Sybase.PowerBuilder.WPF.Controls.DataWindow)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

