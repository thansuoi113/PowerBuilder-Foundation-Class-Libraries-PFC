//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvdropdownsearch.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvdropdownsearch",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvdropdownsearch")]
public class c__pfc_u_tabpg_dwproperty_srvdropdownsearch : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvdropdownsearch.c__st_registeredcolumns st_registeredcolumns = null;
	public c__pfc_u_tabpg_dwproperty_srvdropdownsearch.c__lb_registeredcolumns lb_registeredcolumns = null;

	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.pfc_propertypopulate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperall = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upperreg = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cntall = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cntreg = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_allcols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBArray ls_registeredcols = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertypopulate();
		#line hidden
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 56
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_dropdownsearch)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_dropdownsearch)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_dropdownsearch)))))
		#line hidden
		{
			#line 60
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 65
		li_rc = of_getregisterable_1_3452522231911445111(idw_requestor.inv_dropdownsearch, ref ls_allcols);
		#line hidden
		#line 67
		li_rc = of_getregistered_1_345252223_11278020103(idw_requestor.inv_dropdownsearch, ref ls_registeredcols);
		#line hidden
		#line 69
		li_upperall = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ls_allcols)));
		#line hidden
		#line 70
		li_upperreg = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ls_registeredcols)));
		#line hidden
		#line 71
		for (li_cntall = new Sybase.PowerBuilder.PBInt(1);li_cntall <= li_upperall;li_cntall = li_cntall + 1)
		#line hidden
		{
				#line 72
				li_index = lb_registeredcolumns.AddItem(((Sybase.PowerBuilder.PBString)ls_allcols[(Sybase.PowerBuilder.PBLong)(li_cntall)]));
				#line hidden
				#line 74
				for (li_cntreg = new Sybase.PowerBuilder.PBInt(1);li_cntreg <= li_upperreg;li_cntreg = li_cntreg + 1)
				#line hidden
				{
						#line 75
						if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)ls_allcols[(Sybase.PowerBuilder.PBLong)(li_cntall)]) == ((Sybase.PowerBuilder.PBString)ls_registeredcols[(Sybase.PowerBuilder.PBLong)(li_cntreg)])))
						#line hidden
						{
							#line 76
							lb_registeredcolumns.SetState(li_index, new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
							#line 77
							break;
							#line hidden
						}
				}
		}
		#line 82
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property DropDown Search Service");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property DropDown Search Service");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		this.st_registeredcolumns = (c__st_registeredcolumns)this.CreateInstance(this, "c__st_registeredcolumns");
		#line hidden
		#line hidden
		this.lb_registeredcolumns = (c__lb_registeredcolumns)this.CreateInstance(this, "c__lb_registeredcolumns");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_registeredcolumns);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.lb_registeredcolumns);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_registeredcolumns);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.lb_registeredcolumns);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_column = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyapply();
		#line hidden
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_dropdownsearch)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_dropdownsearch)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_dropdownsearch)))))
		#line hidden
		{
			#line 58
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 63
		li_upper = lb_registeredcolumns.TotalItems();
		#line hidden
		#line 64
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 66
				ls_column = lb_registeredcolumns.Text(li_cnt);
				#line hidden
				#line 68
				if ((Sybase.PowerBuilder.PBBoolean)(lb_registeredcolumns.State(li_cnt) == new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 70
					if (!(idw_requestor.inv_dropdownsearch.of_isregistered(ls_column)))
					#line hidden
					{
						#line 71
						li_rc = idw_requestor.inv_dropdownsearch.of_register(ls_column);
						#line hidden
					}
				}
				else
				{
					#line 75
					if (idw_requestor.inv_dropdownsearch.of_isregistered(ls_column))
					#line hidden
					{
						#line 76
						li_rc = idw_requestor.inv_dropdownsearch.of_unregister(ls_column);
						#line hidden
					}
				}
		}
		#line 81
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.pfc_propertysyntax"
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
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_dropdownsearch)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_dropdownsearch)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_dropdownsearch)))))
		#line hidden
		{
			#line 64
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 69
		ls_syntax += new Sybase.PowerBuilder.PBString("This.of_SetDropDownSearch(True)\r\n");
		#line hidden
		#line 73
		li_upper = lb_registeredcolumns.TotalItems();
		#line hidden
		#line 74
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 76
				if ((Sybase.PowerBuilder.PBBoolean)(lb_registeredcolumns.State(li_cnt) == new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 77
					ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_dropdownsearch.of_Register(\"")+ lb_registeredcolumns.Text(li_cnt))+ new Sybase.PowerBuilder.PBString("\")");
					#line hidden
				}
		}
		#line 82
		return ls_syntax;
		#line hidden
	}

	public Sybase.PowerBuilder.PBInt of_getregisterable_1_3452522231911445111(c__pfc_n_cst_dwsrv_dropdownsearch this__object, ref Sybase.PowerBuilder.PBArray as_allcolumns)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getregisterable_1_345252223(ref as_allcolumns);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getregistered_1_345252223_11278020103(c__pfc_n_cst_dwsrv_dropdownsearch this__object, ref Sybase.PowerBuilder.PBArray as_columns)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getregistered_1_345252223(ref as_columns);
		return return_value;
	}


	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.st_registeredcolumns"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_registeredcolumns")]
	public class c__st_registeredcolumns : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_registeredcolumns()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvdropdownsearch.lb_registeredcolumns"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="lb_registeredcolumns")]
	public class c__lb_registeredcolumns : c__u_lb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__lb_registeredcolumns()
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

	public c__pfc_u_tabpg_dwproperty_srvdropdownsearch()
	{
		_init();
	}

}
 