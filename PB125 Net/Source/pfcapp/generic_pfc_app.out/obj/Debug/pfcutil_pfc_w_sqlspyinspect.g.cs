﻿#pragma checksum "..\..\pfcutil_pfc_w_sqlspyinspect.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD56E48D5D76171D5E33568E5B871BD9"
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
/// pfc_w_sqlspyinspect
/// </summary>
public partial class pfc_w_sqlspyinspect : Sybase.PowerBuilder.WPF.Controls.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 3 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_dlghelp;
    
    #line default
    #line hidden
    
    
    #line 4 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_resume;
    
    #line default
    #line hidden
    
    
    #line 5 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.MultiLineEdit mle_currentsyntax;
    
    #line default
    #line hidden
    
    
    #line 6 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.MultiLineEdit mle_currentheading;
    
    #line default
    #line hidden
    
    
    #line 7 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_cancelall;
    
    #line default
    #line hidden
    
    
    #line 8 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_cancel;
    
    #line default
    #line hidden
    
    
    #line 9 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
    internal Sybase.PowerBuilder.WPF.Controls.CommandButton cb_step;
    
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
        System.Uri resourceLocater = new System.Uri("/generic_pfc_app;component/pfcutil_pfc_w_sqlspyinspect.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\pfcutil_pfc_w_sqlspyinspect.xaml"
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
        this.cb_resume = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 3:
        this.mle_currentsyntax = ((Sybase.PowerBuilder.WPF.Controls.MultiLineEdit)(target));
        return;
            case 4:
        this.mle_currentheading = ((Sybase.PowerBuilder.WPF.Controls.MultiLineEdit)(target));
        return;
            case 5:
        this.cb_cancelall = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 6:
        this.cb_cancel = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            case 7:
        this.cb_step = ((Sybase.PowerBuilder.WPF.Controls.CommandButton)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

