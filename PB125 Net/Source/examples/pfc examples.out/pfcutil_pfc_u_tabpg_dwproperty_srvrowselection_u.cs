//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvrowselection.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvrowselection"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvrowselection",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvrowselection")]
public class c__pfc_u_tabpg_dwproperty_srvrowselection : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvrowselection.c__st_style st_style = null;
	public c__pfc_u_tabpg_dwproperty_srvrowselection.c__cbx_keyboard cbx_keyboard = null;
	public c__pfc_u_tabpg_dwproperty_srvrowselection.c__ddlb_style ddlb_style = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_style", null, "pfc_u_tabpg_dwproperty_srvrowselection", -1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= - 1")]
	protected Sybase.PowerBuilder.PBInt ii_style = new Sybase.PowerBuilder.PBInt(-1);

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.pfc_propertypopulate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_style = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_rowselection)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_rowselect)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_rowselect)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		li_style = idw_requestor.inv_rowselect.of_getstyle();
		#line hidden
		#line 60
		ii_style = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_style)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 61
		li_rc = ddlb_style.SelectItem(ii_style);
		#line hidden
		#line 64
		cbx_keyboard.Checked = idw_requestor.inv_rowselect.of_iskeyboard();
		#line hidden
		#line 66
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property RowSelection Service");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property RowSelection Service");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		this.st_style = (c__st_style)this.CreateInstance(this, "c__st_style");
		#line hidden
		#line hidden
		this.cbx_keyboard = (c__cbx_keyboard)this.CreateInstance(this, "c__cbx_keyboard");
		#line hidden
		#line hidden
		this.ddlb_style = (c__ddlb_style)this.CreateInstance(this, "c__ddlb_style");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_style);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_keyboard);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_style);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_style);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_keyboard);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_style);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_stylecurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_styledesired = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_current = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_desired = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_rowselection)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_rowselect)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_rowselect)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		li_stylecurrent = idw_requestor.inv_rowselect.of_getstyle();
		#line hidden
		#line 62
		li_styledesired = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(ii_style)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 64
		if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_styledesired)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (li_stylecurrent != li_styledesired)))
		#line hidden
		{
			#line 65
			li_rc = idw_requestor.inv_rowselect.of_setstyle(li_styledesired);
			#line hidden
		}
		#line 69
		lb_current = idw_requestor.inv_rowselect.of_iskeyboard();
		#line hidden
		#line 70
		lb_desired = cbx_keyboard.Checked;
		#line hidden
		#line 72
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 73
			li_rc = idw_requestor.inv_rowselect.of_setkeyboard(lb_desired);
			#line hidden
		}
		#line 76
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.pfc_propertysyntax"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertysyntax")]
	public override Sybase.PowerBuilder.PBString pfc_propertysyntax()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_styledesired = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_excludecount = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBArray ls_excludecols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBString ls_exclude = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_syntax = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_desired = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
		Sybase.PowerBuilder.PBString ancestorreturnvalue = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertysyntax();
		#line hidden
		#line 60
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 61
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_rowselection)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_rowselect)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_rowselect)))))
		#line hidden
		{
			#line 64
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 69
		ls_syntax += new Sybase.PowerBuilder.PBString("This.of_SetRowSelect(True)\r\n");
		#line hidden
		#line 72
		li_styledesired = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(ii_style)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 73
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = li_styledesired;
		#line hidden
		#line 74
		if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_rowselection.single )
		#line hidden
		{
			#line 75
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_rowselect.of_SetStyle(inv_rowselect.SINGLE)");
			#line hidden
		}
		#line 76
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_rowselection.multiple )
		#line hidden
		{
			#line 77
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_rowselect.of_SetStyle(inv_rowselect.MULTIPLE)");
			#line hidden
		}
		#line 78
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_rowselection.extended )
		#line hidden
		{
			#line 79
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_rowselect.of_SetStyle(inv_rowselect.EXTENDED)");
			#line hidden
		}
		else 
		{
			#line 81
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_rowselect.of_SetStyle(")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_styledesired)))))+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}

		#line 85
		lb_desired = cbx_keyboard.Checked;
		#line hidden
		#line 86
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_rowselect.of_SetKeyBoard(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 88
		return ls_syntax;
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.st_style"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_style")]
	public class c__st_style : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_style()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.cbx_keyboard"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_keyboard")]
	public class c__cbx_keyboard : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_keyboard()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.ddlb_style"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_style")]
	public class c__ddlb_style : c__u_ddlb
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_srvrowselection.ddlb_style.selectionchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_cbnselchange)]
		public override Sybase.PowerBuilder.PBLong selectionchanged(Sybase.PowerBuilder.PBInt index)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanged(index);
			#line hidden
			#line 3
			((c__pfc_u_tabpg_dwproperty_srvrowselection)(Parent)).ii_style = index;
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.SelectionChangedEvent += new Sybase.PowerBuilder.PBM_EventHandler_i(this.selectionchanged);

			OnInitialUpdate();
		}

		public c__ddlb_style()
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

	public c__pfc_u_tabpg_dwproperty_srvrowselection()
	{
		_init();
	}

}
 