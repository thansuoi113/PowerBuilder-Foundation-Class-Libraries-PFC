﻿#pragma checksum "..\..\pfeapsrv_w_find.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B78BD596B968FD174006D9D7B1C5166"
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
/// w_find
/// </summary>
public partial class w_find : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_dlghelp;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.DropDownListBox ddlb_searchdirection;
    
    #line default
    #line hidden
    
    
    #line 8 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.SingleLineEdit sle_findwhat;
    
    #line default
    #line hidden
    
    
    #line 9 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_cancel;
    
    #line default
    #line hidden
    
    
    #line 10 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_findnext;
    
    #line default
    #line hidden
    
    
    #line 11 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CheckBox cbx_matchcase;
    
    #line default
    #line hidden
    
    
    #line 12 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CheckBox cbx_wholeword;
    
    #line default
    #line hidden
    
    
    #line 13 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_searchdirection;
    
    #line default
    #line hidden
    
    
    #line 14 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.DropDownListBox ddlb_findwhere;
    
    #line default
    #line hidden
    
    
    #line 15 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_searchfor;
    
    #line default
    #line hidden
    
    
    #line 16 "..\..\pfeapsrv_w_find.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_findwhere;
    
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
        System.Uri resourceLocater = new System.Uri("/pfcmsg;component/pfeapsrv_w_find.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfeapsrv_w_find.xaml"
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
        this.cb_dlghelp = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 2:
        this.ddlb_searchdirection = ((Sybase.PowerBuilder.WPF.Controls.DropDownListBox)(target));
        return;
            case 3:
        this.sle_findwhat = ((Sybase.PowerBuilder.WPF.Controls.SingleLineEdit)(target));
        return;
            case 4:
        this.cb_cancel = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 5:
        this.cb_findnext = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 6:
        this.cbx_matchcase = ((Sybase.PowerBuilder.WPF.Controls.CheckBox)(target));
        return;
            case 7:
        this.cbx_wholeword = ((Sybase.PowerBuilder.WPF.Controls.CheckBox)(target));
        return;
            case 8:
        this.st_searchdirection = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 9:
        this.ddlb_findwhere = ((Sybase.PowerBuilder.WPF.Controls.DropDownListBox)(target));
        return;
            case 10:
        this.st_searchfor = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 11:
        this.st_findwhere = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

