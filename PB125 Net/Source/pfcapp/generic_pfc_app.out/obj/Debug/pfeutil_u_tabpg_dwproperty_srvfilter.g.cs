﻿#pragma checksum "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A72C59ECC7710A988BD2B85B2BF7D4D9"
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
/// u_tabpg_dwproperty_srvfilter
/// </summary>
public partial class u_tabpg_dwproperty_srvfilter : Sybase.PowerBuilder.WPF.Controls.UserObject, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.ListBox lb_excludecols;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.DropDownListBox ddlb_style;
    
    #line default
    #line hidden
    
    
    #line 9 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_style;
    
    #line default
    #line hidden
    
    
    #line 10 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CheckBox cbx_visibleonly;
    
    #line default
    #line hidden
    
    
    #line 11 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_excludecols;
    
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
        System.Uri resourceLocater = new System.Uri("/generic_pfc_app;component/pfeutil_u_tabpg_dwproperty_srvfilter.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfeutil_u_tabpg_dwproperty_srvfilter.xaml"
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
        this.lb_excludecols = ((Sybase.PowerBuilder.WPF.Controls.ListBox)(target));
        return;
            case 2:
        this.ddlb_style = ((Sybase.PowerBuilder.WPF.Controls.DropDownListBox)(target));
        return;
            case 3:
        this.st_style = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 4:
        this.cbx_visibleonly = ((Sybase.PowerBuilder.WPF.Controls.CheckBox)(target));
        return;
            case 5:
        this.st_excludecols = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

