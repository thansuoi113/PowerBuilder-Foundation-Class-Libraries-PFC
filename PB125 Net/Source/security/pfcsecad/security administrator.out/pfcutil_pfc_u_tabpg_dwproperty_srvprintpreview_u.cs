//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvprintpreview.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvprintpreview",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvprintpreview")]
public class c__pfc_u_tabpg_dwproperty_srvprintpreview : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvprintpreview.c__cbx_enabled cbx_enabled = null;
	public c__pfc_u_tabpg_dwproperty_srvprintpreview.c__cbx_ruler cbx_ruler = null;
	public c__pfc_u_tabpg_dwproperty_srvprintpreview.c__st_zoom st_zoom = null;
	public c__pfc_u_tabpg_dwproperty_srvprintpreview.c__em_zoom em_zoom = null;

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.pfc_propertypopulate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertypopulate();
		#line hidden
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_printpreview)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_printpreview)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_printpreview)))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 58
		cbx_enabled.Checked = idw_requestor.inv_printpreview.of_getenabled();
		#line hidden
		#line 61
		cbx_ruler.Checked = idw_requestor.inv_printpreview.of_getruler();
		#line hidden
		#line 64
		em_zoom.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(idw_requestor.inv_printpreview.of_getzoom()))));
		#line hidden
		#line 66
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property PrintPreview Service");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property PrintPreview Service");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getpropertyinfo", new string[]{"ref n_cst_propertyattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getpropertyinfo_1_66237089<T0>(ref T0 anv_attrib)
	{
		#line hidden
		c__n_cst_infoattrib lnv_infoattrib = (c__n_cst_infoattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_infoattrib));
		#line 51
		this.of_getinfo_1_920697064(ref lnv_infoattrib);
		#line hidden
		#line 52
		anv_attrib.is_name = lnv_infoattrib.is_name;
		#line hidden
		#line 53
		anv_attrib.is_description = lnv_infoattrib.is_description;
		#line hidden
		#line 56
		anv_attrib.is_propertytabtext = new Sybase.PowerBuilder.PBString("General");
		#line hidden
		#line 58
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt icurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line hidden
		base.create();
		#line hidden
		#line hidden
		this.cbx_enabled = (c__cbx_enabled)this.CreateInstance(this, "c__cbx_enabled");
		#line hidden
		#line hidden
		this.cbx_ruler = (c__cbx_ruler)this.CreateInstance(this, "c__cbx_ruler");
		#line hidden
		#line hidden
		this.st_zoom = (c__st_zoom)this.CreateInstance(this, "c__st_zoom");
		#line hidden
		#line hidden
		this.em_zoom = (c__em_zoom)this.CreateInstance(this, "c__em_zoom");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_enabled);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_ruler);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_zoom);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.em_zoom);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		base.destroy();
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_enabled);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_ruler);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_zoom);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.em_zoom);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_zoomcurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_zoomdesired = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_current = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_desired = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyapply();
		#line hidden
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_printpreview)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_printpreview)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_printpreview)))))
		#line hidden
		{
			#line 56
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 60
		lb_current = idw_requestor.inv_printpreview.of_getenabled();
		#line hidden
		#line 61
		lb_desired = cbx_enabled.Checked;
		#line hidden
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 64
			li_rc = idw_requestor.inv_printpreview.of_setenabled(lb_desired);
			#line hidden
		}
		#line 68
		lb_current = idw_requestor.inv_printpreview.of_getruler();
		#line hidden
		#line 69
		lb_desired = cbx_ruler.Checked;
		#line hidden
		#line 71
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 72
			li_rc = idw_requestor.inv_printpreview.of_setruler(lb_desired);
			#line hidden
		}
		#line 76
		li_zoomcurrent = idw_requestor.inv_printpreview.of_getzoom();
		#line hidden
		#line 77
		li_zoomdesired = Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(em_zoom.Text))));
		#line hidden
		#line 79
		if ((Sybase.PowerBuilder.PBBoolean)(li_zoomcurrent != li_zoomdesired))
		#line hidden
		{
			#line 80
			li_rc = idw_requestor.inv_printpreview.of_setzoom(li_zoomdesired);
			#line hidden
		}
		#line 83
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.pfc_propertysyntax"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertysyntax")]
	public override Sybase.PowerBuilder.PBString pfc_propertysyntax()
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_syntax = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_desired = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
		Sybase.PowerBuilder.PBString ancestorreturnvalue = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertysyntax();
		#line hidden
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_printpreview)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_printpreview)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_printpreview)))))
		#line hidden
		{
			#line 56
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 61
		ls_syntax += new Sybase.PowerBuilder.PBString("This.of_SetPrintPreview(True)\r\n");
		#line hidden
		#line 64
		lb_desired = cbx_enabled.Checked;
		#line hidden
		#line 65
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_printpreview.of_SetEnabled(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 68
		lb_desired = cbx_ruler.Checked;
		#line hidden
		#line 69
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_printpreview.of_SetRuler(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 72
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(em_zoom.Text))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 73
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_printpreview.of_SetZoom(")+ em_zoom.Text)+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}
		#line 76
		return ls_syntax;
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.cbx_enabled"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_enabled")]
	public class c__cbx_enabled : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_enabled()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.cbx_ruler"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_ruler")]
	public class c__cbx_ruler : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_ruler()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.st_zoom"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_zoom")]
	public class c__st_zoom : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_zoom()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvprintpreview.em_zoom"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="em_zoom")]
	public class c__em_zoom : c__u_em
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__em_zoom()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);

		OnInitialUpdate();
	}

	public c__pfc_u_tabpg_dwproperty_srvprintpreview()
	{
		_init();
	}

}
 