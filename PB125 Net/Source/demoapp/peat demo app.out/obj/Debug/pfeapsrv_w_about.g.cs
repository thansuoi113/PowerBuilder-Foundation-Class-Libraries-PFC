﻿#pragma checksum "..\..\pfeapsrv_w_about.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E494FE1CAB1ED8B20071777D64CE103"
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
/// w_about
/// </summary>
public partial class w_about : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfeapsrv_w_about.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_copyright;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfeapsrv_w_about.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_ok;
    
    #line default
    #line hidden
    
    
    #line 5 "..\..\pfeapsrv_w_about.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_version;
    
    #line default
    #line hidden
    
    
    #line 6 "..\..\pfeapsrv_w_about.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.StaticText st_application;
    
    #line default
    #line hidden
    
    
    #line 7 "..\..\pfeapsrv_w_about.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.Picture p_about;
    
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
        System.Uri resourceLocater = new System.Uri("/peat;component/pfeapsrv_w_about.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfeapsrv_w_about.xaml"
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
        this.st_copyright = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 2:
        this.cb_ok = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 3:
        this.st_version = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 4:
        this.st_application = ((Sybase.PowerBuilder.WPF.Controls.StaticText)(target));
        return;
            case 5:
        this.p_about = ((Sybase.PowerBuilder.WPF.Controls.Picture)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

