//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvlinkage.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvlinkage"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvlinkage",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvlinkage")]
public class c__pfc_u_tabpg_dwproperty_srvlinkage : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_masterdw st_label_masterdw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_masterdw st_masterdw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_detaldw st_label_detaldw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_style st_label_style = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_style st_style = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_masterarg st_label_masterarg = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__dw_arguments dw_arguments = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_rootdw st_label_rootdw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_rootdw st_rootdw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__mle_detaildw mle_detaildw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_label_currentdw st_label_currentdw = null;
	public c__pfc_u_tabpg_dwproperty_srvlinkage.c__st_currentdw st_currentdw = null;

	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property Linkage Service");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property Linkage Service");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		this.st_label_masterdw = (c__st_label_masterdw)this.CreateInstance(this, "c__st_label_masterdw");
		#line hidden
		#line hidden
		this.st_masterdw = (c__st_masterdw)this.CreateInstance(this, "c__st_masterdw");
		#line hidden
		#line hidden
		this.st_label_detaldw = (c__st_label_detaldw)this.CreateInstance(this, "c__st_label_detaldw");
		#line hidden
		#line hidden
		this.st_label_style = (c__st_label_style)this.CreateInstance(this, "c__st_label_style");
		#line hidden
		#line hidden
		this.st_style = (c__st_style)this.CreateInstance(this, "c__st_style");
		#line hidden
		#line hidden
		this.st_label_masterarg = (c__st_label_masterarg)this.CreateInstance(this, "c__st_label_masterarg");
		#line hidden
		#line hidden
		this.dw_arguments = (c__dw_arguments)this.CreateInstance(this, "c__dw_arguments");
		#line hidden
		#line hidden
		this.st_label_rootdw = (c__st_label_rootdw)this.CreateInstance(this, "c__st_label_rootdw");
		#line hidden
		#line hidden
		this.st_rootdw = (c__st_rootdw)this.CreateInstance(this, "c__st_rootdw");
		#line hidden
		#line hidden
		this.mle_detaildw = (c__mle_detaildw)this.CreateInstance(this, "c__mle_detaildw");
		#line hidden
		#line hidden
		this.st_label_currentdw = (c__st_label_currentdw)this.CreateInstance(this, "c__st_label_currentdw");
		#line hidden
		#line hidden
		this.st_currentdw = (c__st_currentdw)this.CreateInstance(this, "c__st_currentdw");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_masterdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_masterdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_detaldw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_style);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_style);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_masterarg);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_arguments);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_rootdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_rootdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.mle_detaildw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_label_currentdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_currentdw);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_masterdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_masterdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_detaldw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_style);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_style);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_masterarg);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_arguments);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_rootdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_rootdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.mle_detaildw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_label_currentdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_currentdw);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.pfc_propertypopulate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_row = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_style = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_details = Sybase.PowerBuilder.PBString.DefaultValue;
		c__u_dw ldw_temp = null;
		Sybase.PowerBuilder.PBArray ldw_details = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__u_dw));
		c__n_cst_linkageattrib lnv_linkageattrib = (c__n_cst_linkageattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_linkageattrib));
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertypopulate();
		#line hidden
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 60
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 62
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_linkage)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_linkage)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_linkage)))))
		#line hidden
		{
			#line 63
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 67
		st_currentdw.Text = idw_requestor.ClassName();
		#line hidden
		#line 70
		li_rc = idw_requestor.inv_linkage.of_findroot_1_1439069071(ref ldw_temp);
		#line hidden
		#line 71
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ldw_temp)))
		#line hidden
		{
			#line 72
			st_rootdw.Text = ldw_temp.ClassName();
			#line hidden
		}
		#line 76
		li_rc = idw_requestor.inv_linkage.of_getmaster_1_1439069071(ref ldw_temp);
		#line hidden
		#line 77
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ldw_temp)))
		#line hidden
		{
			#line 78
			st_masterdw.Text = ldw_temp.ClassName();
			#line hidden
		}
		#line 82
		li_rc = of_getdetails_1_1439069071_1_p1726207944(idw_requestor.inv_linkage, ref ldw_details);
		#line hidden
		#line 83
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ldw_details)));
		#line hidden
		#line 84
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 85
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__u_dw)ldw_details[(Sybase.PowerBuilder.PBLong)(li_cnt)]))))
				#line hidden
				{
					#line 86
					if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_details)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 86
						ls_details += new Sybase.PowerBuilder.PBString("\r\n");
						#line hidden
					}
					#line 87
					ls_details += ((c__u_dw)ldw_details[ldw_details.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).ClassName();
					#line hidden
				}
		}
		#line 90
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_details)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 91
			mle_detaildw.Text = ls_details;
			#line hidden
		}
		#line 95
		li_style = idw_requestor.inv_linkage.of_getstyle();
		#line hidden
		#line 96
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = li_style;
		#line hidden
		#line 97
		if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_linkage.filter )
		#line hidden
		{
			#line 98
			st_style.Text = new Sybase.PowerBuilder.PBString("Filter");
			#line hidden
		}
		#line 99
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_linkage.retrieve )
		#line hidden
		{
			#line 100
			st_style.Text = new Sybase.PowerBuilder.PBString("Retrieve");
			#line hidden
		}
		#line 101
		else if (__PB_TEMP______switchTmpVar0 == c__n_cst_dwsrv_linkage.scroll )
		#line hidden
		{
			#line 102
			st_style.Text = new Sybase.PowerBuilder.PBString("Scroll");
			#line hidden
		}
		else 
		{
			#line 104
			st_style.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_style))));
			#line hidden
		}

		#line 108
		li_rc = idw_requestor.inv_linkage.of_getregistered_1_461794519(ref lnv_linkageattrib);
		#line hidden
		#line 109
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lnv_linkageattrib)))
		#line hidden
		{
			#line 110
			li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(lnv_linkageattrib.is_mastercolarg)));
			#line hidden
			#line 111
			for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
			#line hidden
			{
					#line 112
					if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)lnv_linkageattrib.is_mastercolarg[(Sybase.PowerBuilder.PBLong)(li_cnt)])))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 113
						li_row = (Sybase.PowerBuilder.PBInt)(dw_arguments.pfc_addrow());
						#line hidden
						#line 114
						if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_row)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
						#line hidden
						{
							#line 115
							((Sybase.PowerBuilder.PBExtObject)(((Sybase.PowerBuilder.PBExtObject)(dw_arguments.Object))[new Sybase.PowerBuilder.PBString(@"mastercolumn"), Sybase.PowerBuilder.PBBoolean.False].Value))[
								#line 115
								new Sybase.PowerBuilder.PBString(@"primary"), 
								#line 115
								new Sybase.PowerBuilder.PBUInt(1), 
								#line 115
								new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(li_row)}) 
							#line 115
							] = (Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)lnv_linkageattrib.is_mastercolarg[(Sybase.PowerBuilder.PBLong)(li_cnt)])));
							#line hidden
							#line 117
							((Sybase.PowerBuilder.PBExtObject)(((Sybase.PowerBuilder.PBExtObject)(dw_arguments.Object))[new Sybase.PowerBuilder.PBString(@"detailcolumn"), Sybase.PowerBuilder.PBBoolean.False].Value))[
								#line 117
								new Sybase.PowerBuilder.PBString(@"primary"), 
								#line 117
								new Sybase.PowerBuilder.PBUInt(1), 
								#line 117
								new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(li_row)}) 
							#line 117
							] = (Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)lnv_linkageattrib.is_detailcolarg[(Sybase.PowerBuilder.PBLong)(li_cnt)])));
							#line hidden
						}
					}
			}
		}
		#line 124
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyapply();
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_linkage)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_linkage)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_linkage)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.pfc_propertysyntax"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertysyntax")]
	public override Sybase.PowerBuilder.PBString pfc_propertysyntax()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rowcount = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_row = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_syntax = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_mastercol = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_detailcol = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ancestorreturnvalue = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertysyntax();
		#line hidden
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_linkage)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor.inv_linkage)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor.inv_linkage)))))
		#line hidden
		{
			#line 60
			return new Sybase.PowerBuilder.PBString("!");
			#line hidden
		}
		#line 64
		ls_syntax += new Sybase.PowerBuilder.PBString("This.of_SetLinkage(True)\r\n");
		#line hidden
		#line 67
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNumber(st_style.Text))
		#line hidden
		{
			#line 68
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_linkage.of_SetStyle(")+ st_style.Text)+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}
		else
		{
			#line 70
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_linkage.of_SetStyle(inv_linkage.")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.Upper(st_style.Text))+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}
		#line 74
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Upper(st_masterdw.Text) != new Sybase.PowerBuilder.PBString("NONE")))
		#line hidden
		{
			#line 75
			ls_syntax += (new Sybase.PowerBuilder.PBString("\r\nThis.inv_linkage.of_SetMaster(")+ st_masterdw.Text)+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}
		#line 79
		li_rowcount = (Sybase.PowerBuilder.PBInt)(dw_arguments.RowCount());
		#line hidden
		#line 80
		for (li_row = new Sybase.PowerBuilder.PBInt(1);li_row <= li_rowcount;li_row = li_row + 1)
		#line hidden
		{
				#line 81
				ls_mastercol = (Sybase.PowerBuilder.PBString)(((Sybase.PowerBuilder.PBExtObject)(((Sybase.PowerBuilder.PBExtObject)(dw_arguments.Object))[new Sybase.PowerBuilder.PBString(@"mastercolumn"), Sybase.PowerBuilder.PBBoolean.False].Value))[
					#line 81
					new Sybase.PowerBuilder.PBString(@"primary"), 
					#line 81
					new Sybase.PowerBuilder.PBUInt(1), 
					#line 81
					new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(li_row)}) ,
					#line 81
					Sybase.PowerBuilder.PBBoolean.True
				#line 81
				]);
				#line hidden
				#line 82
				ls_detailcol = (Sybase.PowerBuilder.PBString)(((Sybase.PowerBuilder.PBExtObject)(((Sybase.PowerBuilder.PBExtObject)(dw_arguments.Object))[new Sybase.PowerBuilder.PBString(@"detailcolumn"), Sybase.PowerBuilder.PBBoolean.False].Value))[
					#line 82
					new Sybase.PowerBuilder.PBString(@"primary"), 
					#line 82
					new Sybase.PowerBuilder.PBUInt(1), 
					#line 82
					new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(li_row)}) ,
					#line 82
					Sybase.PowerBuilder.PBBoolean.True
				#line 82
				]);
				#line hidden
				#line 83
				ls_syntax += (((new Sybase.PowerBuilder.PBString("\r\nThis.inv_linkage.of_Register(\"")+ ls_mastercol)+ new Sybase.PowerBuilder.PBString("\",\""))+ ls_detailcol)+ new Sybase.PowerBuilder.PBString("\")");
				#line hidden
		}
		#line 86
		return ls_syntax;
		#line hidden
	}

	public Sybase.PowerBuilder.PBInt of_getdetails_1_1439069071_1_p1726207944(c__pfc_n_cst_dwsrv_linkage this__object, ref Sybase.PowerBuilder.PBArray adw_details)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getdetails_1_1439069071(ref adw_details);
		return return_value;
	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_masterdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_masterdw")]
	public class c__st_label_masterdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_masterdw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_masterdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_masterdw")]
	public class c__st_masterdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_masterdw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_detaldw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_detaldw")]
	public class c__st_label_detaldw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_detaldw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_style"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_style")]
	public class c__st_label_style : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_style()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_style"
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


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_masterarg"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_masterarg")]
	public class c__st_label_masterarg : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_masterarg()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.dw_arguments"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_dwproperty_linkageargs", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_arguments")]
	public class c__dw_arguments : c__u_dw
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.dw_arguments.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.constructor();
			#line hidden
			#line 1
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_dwproperty_linkageargs");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_arguments()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_rootdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_rootdw")]
	public class c__st_label_rootdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_rootdw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_rootdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_rootdw")]
	public class c__st_rootdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_rootdw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.mle_detaildw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_detaildw")]
	public class c__mle_detaildw : c__u_mle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__mle_detaildw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_label_currentdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_label_currentdw")]
	public class c__st_label_currentdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_label_currentdw()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvlinkage.st_currentdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_currentdw")]
	public class c__st_currentdw : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_currentdw()
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

	public c__pfc_u_tabpg_dwproperty_srvlinkage()
	{
		_init();
	}

}
 