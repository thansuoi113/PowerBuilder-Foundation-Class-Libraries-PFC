﻿#pragma checksum "..\..\pfeutil_w_sqlspy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "136966A1311AF1F0168E0F3B937BDC0B"
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
/// w_sqlspy
/// </summary>
public partial class w_sqlspy : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_history;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.GroupBox gb_sqlhistory;
    
    #line default
    #line hidden
    
    
    #line 7 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_close;
    
    #line default
    #line hidden
    
    
    #line 8 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_dlghelp;
    
    #line default
    #line hidden
    
    
    #line 9 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_clear;
    
    #line default
    #line hidden
    
    
    #line 10 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.MultiLineEdit mle_history;
    
    #line default
    #line hidden
    
    
    #line 11 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CheckBox cbx_batchmode;
    
    #line default
    #line hidden
    
    
    #line 12 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_save;
    
    #line default
    #line hidden
    
    
    #line 13 "..\..\pfeutil_w_sqlspy.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_print;
    
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
        System.Uri resourceLocater = new System.Uri("/pfcmsg;component/pfeutil_w_sqlspy.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfeutil_w_sqlspy.xaml"
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
        this.st_history = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 2:
        this.gb_sqlhistory = ((Sybase.PowerBuilder.WPF.Controls.GroupBox)(target));
        return;
            case 3:
        this.cb_close = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 4:
        this.cb_dlghelp = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 5:
        this.cb_clear = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 6:
        this.mle_history = ((Sybase.PowerBuilder.WPF.Controls.MultiLineEdit)(target));
        return;
            case 7:
        this.cbx_batchmode = ((Sybase.PowerBuilder.WPF.Controls.CheckBox)(target));
        return;
            case 8:
        this.cb_save = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 9:
        this.cb_print = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

