//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvsort.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvsort"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvsort",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvsort")]
public class c__pfc_u_tabpg_dwproperty_srvsort : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvsort.c__st_style st_style = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__cbx_columnheader cbx_columnheader = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__cbx_visibleonly cbx_visibleonly = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__cbx_usedisplayvalue cbx_usedisplayvalue = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__st_excludecols st_excludecols = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__ddlb_style ddlb_style = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__lb_excludecols lb_excludecols = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__st_headersuffix st_headersuffix = null;
	public c__pfc_u_tabpg_dwproperty_srvsort.c__sle_headersuffix sle_headersuffix = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_style", null, "pfc_u_tabpg_dwproperty_srvsort", -1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= - 1")]
	protected Sybase.PowerBuilder.PBInt ii_style = new Sybase.PowerBuilder.PBInt(-1);

	#line 1 "pfc_u_tabpg_dwproperty_srvsort.pfc_propertypopulate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperall = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upperexc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cntall = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cntexc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_style = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_allcols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBArray ls_excludecols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertypopulate();
		#line hidden
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_sort)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_sort)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_sort)))))
		#line hidden
		{
			#line 60
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 64
		li_style = idw_requestor.inv_sort.of_getstyle();
		#line hidden
		#line 66
		ii_style = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_style)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 67
		li_rc = ddlb_style.SelectItem(ii_style);
		#line hidden
		#line 70
		cbx_columnheader.Checked = idw_requestor.inv_sort.of_getcolumnheader();
		#line hidden
		#line 73
		sle_headersuffix.Text = idw_requestor.inv_sort.of_getdefaultheadersuffix();
		#line hidden
		#line 76
		cbx_visibleonly.Checked = idw_requestor.inv_sort.of_getvisibleonly();
		#line hidden
		#line 79
		cbx_usedisplayvalue.Checked = idw_requestor.inv_sort.of_getusedisplay();
		#line hidden
		#line 82
		li_rc = of_getregisterable_1_3452522231462242015(idw_requestor.inv_sort, ref ls_allcols);
		#line hidden
		#line 84
		li_rc = of_getexclude_1_345252223_1_pf823700964(idw_requestor.inv_sort, ref ls_excludecols);
		#line hidden
		#line 86
		li_upperall = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ls_allcols)));
		#line hidden
		#line 87
		li_upperexc = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ls_excludecols)));
		#line hidden
		#line 88
		for (li_cntall = new Sybase.PowerBuilder.PBInt(1);li_cntall <= li_upperall;li_cntall = li_cntall + 1)
		#line hidden
		{
				#line 89
				li_index = lb_excludecols.AddItem(((Sybase.PowerBuilder.PBString)ls_allcols[(Sybase.PowerBuilder.PBLong)(li_cntall)]));
				#line hidden
				#line 91
				for (li_cntexc = new Sybase.PowerBuilder.PBInt(1);li_cntexc <= li_upperexc;li_cntexc = li_cntexc + 1)
				#line hidden
				{
						#line 92
						if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)ls_allcols[(Sybase.PowerBuilder.PBLong)(li_cntall)]) == ((Sybase.PowerBuilder.PBString)ls_excludecols[(Sybase.PowerBuilder.PBLong)(li_cntexc)])))
						#line hidden
						{
							#line 93
							lb_excludecols.SetState(li_index, new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
							#line 94
							break;
							#line hidden
						}
				}
		}
		#line 99
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsort.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property Sort Service");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property Sort Service");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsort.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		this.cbx_columnheader = (c__cbx_columnheader)this.CreateInstance(this, "c__cbx_columnheader");
		#line hidden
		#line hidden
		this.cbx_visibleonly = (c__cbx_visibleonly)this.CreateInstance(this, "c__cbx_visibleonly");
		#line hidden
		#line hidden
		this.cbx_usedisplayvalue = (c__cbx_usedisplayvalue)this.CreateInstance(this, "c__cbx_usedisplayvalue");
		#line hidden
		#line hidden
		this.st_excludecols = (c__st_excludecols)this.CreateInstance(this, "c__st_excludecols");
		#line hidden
		#line hidden
		this.ddlb_style = (c__ddlb_style)this.CreateInstance(this, "c__ddlb_style");
		#line hidden
		#line hidden
		this.lb_excludecols = (c__lb_excludecols)this.CreateInstance(this, "c__lb_excludecols");
		#line hidden
		#line hidden
		this.st_headersuffix = (c__st_headersuffix)this.CreateInstance(this, "c__st_headersuffix");
		#line hidden
		#line hidden
		this.sle_headersuffix = (c__sle_headersuffix)this.CreateInstance(this, "c__sle_headersuffix");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_style);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_columnheader);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_visibleonly);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_usedisplayvalue);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_excludecols);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_style);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.lb_excludecols);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_headersuffix);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.sle_headersuffix);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_columnheader);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_visibleonly);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_usedisplayvalue);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_excludecols);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_style);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.lb_excludecols);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_headersuffix);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_headersuffix);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsort.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_stylecurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_styledesired = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_excludecount = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBArray ls_excludecols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBString ls_headersuffixcurrent = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_headersuffixdesired = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_current = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_desired = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyapply();
		#line hidden
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 59
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_sort)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_sort)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_sort)))))
		#line hidden
		{
			#line 62
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 66
		li_stylecurrent = idw_requestor.inv_sort.of_getstyle();
		#line hidden
		#line 67
		li_styledesired = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(ii_style)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 69
		if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_styledesired)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (li_stylecurrent != li_styledesired)))
		#line hidden
		{
			#line 70
			li_rc = idw_requestor.inv_sort.of_setstyle(li_styledesired);
			#line hidden
		}
		#line 74
		lb_current = idw_requestor.inv_sort.of_getcolumnheader();
		#line hidden
		#line 75
		lb_desired = cbx_columnheader.Checked;
		#line hidden
		#line 77
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 78
			li_rc = idw_requestor.inv_sort.of_setcolumnheader(lb_desired);
			#line hidden
		}
		#line 82
		ls_headersuffixcurrent = idw_requestor.inv_sort.of_getdefaultheadersuffix();
		#line hidden
		#line 83
		ls_headersuffixdesired = sle_headersuffix.Text;
		#line hidden
		#line 85
		if ((Sybase.PowerBuilder.PBBoolean)(ls_headersuffixcurrent != ls_headersuffixdesired))
		#line hidden
		{
			#line 86
			li_rc = idw_requestor.inv_sort.of_setdefaultheadersuffix(ls_headersuffixdesired);
			#line hidden
		}
		#line 90
		lb_current = idw_requestor.inv_sort.of_getvisibleonly();
		#line hidden
		#line 91
		lb_desired = cbx_visibleonly.Checked;
		#line hidden
		#line 93
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 94
			li_rc = idw_requestor.inv_sort.of_setvisibleonly(lb_desired);
			#line hidden
		}
		#line 98
		lb_current = idw_requestor.inv_sort.of_getusedisplay();
		#line hidden
		#line 99
		lb_desired = cbx_usedisplayvalue.Checked;
		#line hidden
		#line 101
		if ((Sybase.PowerBuilder.PBBoolean)(lb_current != lb_desired))
		#line hidden
		{
			#line 102
			li_rc = idw_requestor.inv_sort.of_setusedisplay(lb_desired);
			#line hidden
		}
		#line 107
		li_upper = lb_excludecols.TotalItems();
		#line hidden
		#line 108
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 110
				if ((Sybase.PowerBuilder.PBBoolean)(lb_excludecols.State(li_cnt) == new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 111
					li_excludecount++;
					#line hidden
					#line 112
					ls_excludecols[ls_excludecols.Extend((Sybase.PowerBuilder.PBLong)(li_excludecount))] = lb_excludecols.Text(li_cnt);
					#line hidden
				}
		}
		#line 115
		li_rc = of_setexclude_1_345252223_1_pf823700964(idw_requestor.inv_sort, (Sybase.PowerBuilder.PBUnboundedStringArray)(ls_excludecols).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)));
		#line hidden
		#line 117
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsort.pfc_propertysyntax"
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
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_sort)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_sort)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_sort)))))
		#line hidden
		{
			#line 64
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 69
		ls_syntax += new Sybase.PowerBuilder.PBString("This.of_SetSort(True)\r\n");
		#line hidden
		#line 72
		li_styledesired = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(ii_style)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 73
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = li_styledesired;
		#line hidden
		#line 74
		if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_sort.@default )
		#line hidden
		{
			#line 75
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetStyle(inv_sort.DEFAULT)");
			#line hidden
		}
		#line 76
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_sort.dragdrop )
		#line hidden
		{
			#line 77
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetStyle(inv_sort.DRAGDROP)");
			#line hidden
		}
		#line 78
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_sort.simple )
		#line hidden
		{
			#line 79
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetStyle(inv_sort.SIMPLE)");
			#line hidden
		}
		#line 80
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_sort.dropdownlistbox )
		#line hidden
		{
			#line 81
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetStyle(inv_sort.DROPDOWNLISTBOX)");
			#line hidden
		}
		else 
		{
			#line 83
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetStyle(")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_styledesired)))))+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}

		#line 87
		lb_desired = cbx_columnheader.Checked;
		#line hidden
		#line 88
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetColumnHeader(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 91
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(sle_headersuffix.Text))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 92
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetDefaultHeaderSuffix(\"")+ sle_headersuffix.Text)+ new Sybase.PowerBuilder.PBString("\")");
			#line hidden
		}
		#line 96
		lb_desired = cbx_visibleonly.Checked;
		#line hidden
		#line 97
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetVisibleOnly(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 100
		lb_desired = cbx_usedisplayvalue.Checked;
		#line hidden
		#line 101
		ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetUseDisplay(")+ lnv_conversion.of_string(lb_desired))+ new Sybase.PowerBuilder.PBString(")");
		#line hidden
		#line 105
		li_upper = lb_excludecols.TotalItems();
		#line hidden
		#line 106
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 108
				if ((Sybase.PowerBuilder.PBBoolean)(lb_excludecols.State(li_cnt) == new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 109
					li_excludecount++;
					#line hidden
					#line 110
					ls_exclude += (((new Sybase.PowerBuilder.PBString("\r\nls_exclude[")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_excludecount)))))+ new Sybase.PowerBuilder.PBString("] = \""))+ lb_excludecols.Text(li_cnt))+ new Sybase.PowerBuilder.PBString("\"");
					#line hidden
				}
		}
		#line 114
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_excludecount)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 116
			ls_syntax = new Sybase.PowerBuilder.PBString("String	ls_exclude[]\r\n\r\n")+ ls_syntax;
			#line hidden
			#line 117
			ls_syntax += ls_exclude;
			#line hidden
			#line 118
			ls_syntax += new Sybase.PowerBuilder.PBString("\r\nThis.inv_sort.of_SetExclude(ls_exclude)");
			#line hidden
		}
		#line 121
		return ls_syntax;
		#line hidden
	}

	public Sybase.PowerBuilder.PBInt of_getregisterable_1_3452522231462242015(c__pfc_n_cst_dwsrv_sort this__object, ref Sybase.PowerBuilder.PBArray as_allcolumns)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getregisterable_1_345252223(ref as_allcolumns);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getexclude_1_345252223_1_pf823700964(c__pfc_n_cst_dwsrv_sort this__object, ref Sybase.PowerBuilder.PBArray as_excludecols)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getexclude_1_345252223(ref as_excludecols);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_setexclude_1_345252223_1_pf823700964(c__pfc_n_cst_dwsrv_sort this__object, Sybase.PowerBuilder.PBArray as_excludecols)
	{
		 Sybase.PowerBuilder.PBArray temp_var_as_excludecols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_excludecols.AssignFrom(as_excludecols);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_setexclude_1_345252223(temp_var_as_excludecols);
		return return_value;
	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.st_style"
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


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.cbx_columnheader"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_columnheader")]
	public class c__cbx_columnheader : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_columnheader()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.cbx_visibleonly"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_visibleonly")]
	public class c__cbx_visibleonly : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_visibleonly()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.cbx_usedisplayvalue"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_usedisplayvalue")]
	public class c__cbx_usedisplayvalue : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_usedisplayvalue()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.st_excludecols"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_excludecols")]
	public class c__st_excludecols : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_excludecols()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.ddlb_style"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_style")]
	public class c__ddlb_style : c__u_ddlb
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_srvsort.ddlb_style.selectionchanged"
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
			((c__pfc_u_tabpg_dwproperty_srvsort)(Parent)).ii_style = index;
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


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.lb_excludecols"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="lb_excludecols")]
	public class c__lb_excludecols : c__u_lb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__lb_excludecols()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.st_headersuffix"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_headersuffix")]
	public class c__st_headersuffix : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_headersuffix()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsort.sle_headersuffix"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_headersuffix")]
	public class c__sle_headersuffix : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_headersuffix()
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

	public c__pfc_u_tabpg_dwproperty_srvsort()
	{
		_init();
	}

}
 