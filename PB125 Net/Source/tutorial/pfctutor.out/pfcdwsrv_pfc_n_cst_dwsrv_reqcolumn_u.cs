//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_n_cst_dwsrv_reqcolumn.sru"
#line hidden
#line 1 "pfc_n_cst_dwsrv_reqcolumn"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwsrv_reqcolumn",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwsrv_reqcolumn")]
public class c__pfc_n_cst_dwsrv_reqcolumn : c__n_cst_dwsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_skipcolumn", null, "pfc_n_cst_dwsrv_reqcolumn", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray is_skipcolumn = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_skip", null, "pfc_n_cst_dwsrv_reqcolumn", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBString is_skip = Sybase.PowerBuilder.PBString.DefaultValue;

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_settonullifempty(ILSS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_settonullifempty", new string[]{"long", "string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_settonullifempty(Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.PBString as_colname, Sybase.PowerBuilder.PBString as_text)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_describe = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_rc = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_null = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBAny la_currentvalue = Sybase.PowerBuilder.PBAny.DefaultValue;
		#line 60
		ls_null.SetNull();
		#line hidden
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(as_text != new Sybase.PowerBuilder.PBString("")))
		#line hidden
		{
			#line 63
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 66
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(is_skip), (new Sybase.PowerBuilder.PBString("\t")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_colname))+ new Sybase.PowerBuilder.PBString("\t"))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 66
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 69
		ls_describe = ((((((as_colname+ new Sybase.PowerBuilder.PBString(".Edit.Required "))+ as_colname)+ new Sybase.PowerBuilder.PBString(".EditMask.Required "))+ as_colname)+ new Sybase.PowerBuilder.PBString(".DDLB.Required "))+ as_colname)+ new Sybase.PowerBuilder.PBString(".DDDW.Required ");
		#line hidden
		#line 73
		ls_rc = idw_requestor.Describe(ls_describe);
		#line hidden
		#line 74
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_rc), new Sybase.PowerBuilder.PBString("yes")) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 74
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 77
		ls_describe = ((((as_colname+ new Sybase.PowerBuilder.PBString(".Edit.NilIsNull "))+ as_colname)+ new Sybase.PowerBuilder.PBString(".DDLB.NilIsNull "))+ as_colname)+ new Sybase.PowerBuilder.PBString(".DDDW.NilIsNull ");
		#line hidden
		#line 80
		ls_rc = idw_requestor.Describe(ls_describe);
		#line hidden
		#line 81
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_rc), new Sybase.PowerBuilder.PBString("yes")) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 81
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 88
		la_currentvalue = this.of_getitemany(al_row, as_colname);
		#line hidden
		#line 92
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull(((Sybase.PowerBuilder.PBAny)(la_currentvalue))))
		#line hidden
		{
			#line 93
			return new Sybase.PowerBuilder.PBInt(3);
			#line hidden
		}
		#line 98
		return this.of_setitem(al_row, as_colname, ls_null);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_updateskipstring(IS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_updateskipstring", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_updateskipstring_1_345252223([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_skipcolumn)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_max = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 50
		is_skip = new Sybase.PowerBuilder.PBString("\t");
		#line hidden
		#line 53
		li_max = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(as_skipcolumn)));
		#line hidden
		#line 56
		for (li_index = new Sybase.PowerBuilder.PBInt(1);li_index <= li_max;li_index = li_index + 1)
		#line hidden
		{
				#line 57
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)as_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_index)])))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 58
					is_skip = (is_skip+ ((Sybase.PowerBuilder.PBString)as_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_index)]))+ new Sybase.PowerBuilder.PBString("\t");
					#line hidden
				}
		}
		#line 62
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_registerskipcolumn(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_registerskipcolumn", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_registerskipcolumn(Sybase.PowerBuilder.PBString as_column)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_slotavailable = new Sybase.PowerBuilder.PBInt(0);
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_column))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_column)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		as_column = Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_column));
		#line hidden
		#line 64
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_skipcolumn)));
		#line hidden
		#line 65
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 66
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_cnt)]) == as_column))
				#line hidden
				{
					#line 68
					return new Sybase.PowerBuilder.PBInt(0);
					#line hidden
				}
				#line 71
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_cnt)])) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (li_slotavailable == new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 72
					li_slotavailable = li_cnt;
					#line hidden
				}
		}
		#line 77
		if ((Sybase.PowerBuilder.PBBoolean)(li_slotavailable == new Sybase.PowerBuilder.PBInt(0)))
		#line hidden
		{
			#line 78
			li_slotavailable = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_upper)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
			#line hidden
		}
		#line 82
		is_skipcolumn[is_skipcolumn.Extend((Sybase.PowerBuilder.PBLong)(li_slotavailable))] = as_column;
		#line hidden
		#line 85
		of_updateskipstring_1_34525222535703856(this, (Sybase.PowerBuilder.PBUnboundedStringArray)(is_skipcolumn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)));
		#line hidden
		#line 87
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_getregisterable(IRS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getregisterable", new string[]{"ref string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getregisterable_1_345252223([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] ref Sybase.PowerBuilder.PBArray as_allcolumns)
	{
		#line hidden
		Sybase.PowerBuilder.PBArray ls_allcolumns = new Sybase.PowerBuilder.PBUnboundedStringArray();
		#line 53
		of_getobjects_4_345252223_4_pf1632708430(this, ref ls_allcolumns, new Sybase.PowerBuilder.PBString("column"), new Sybase.PowerBuilder.PBString("*"), new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 55
		as_allcolumns.AssignFrom((Sybase.PowerBuilder.PBArray)ls_allcolumns);
		#line hidden
		#line 56
		return (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(as_allcolumns)));
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("Required Column");
		#line hidden
		#line 50
		anv_infoattrib.is_description = ((new Sybase.PowerBuilder.PBString("This service enables and disables default DataWindow processing for ")+ new Sybase.PowerBuilder.PBString("required fields, making it easier for your application to handle "))+ new Sybase.PowerBuilder.PBString("interdependent fields within a DataWindow.  "))+ new Sybase.PowerBuilder.PBString("This service applies only to DataWindow columns that use the nilisnull property. ");
		#line hidden
		#line 56
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_getregistered(IRS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getregistered", new string[]{"ref string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getregistered_1_345252223([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] ref Sybase.PowerBuilder.PBArray as_regcolumns)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_regcnt = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBArray ls_empty = new Sybase.PowerBuilder.PBUnboundedStringArray();
		#line 53
		as_regcolumns.AssignFrom((Sybase.PowerBuilder.PBArray)ls_empty);
		#line hidden
		#line 56
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_skipcolumn)));
		#line hidden
		#line 57
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 58
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_cnt)]))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 60
					li_regcnt++;
					#line hidden
					#line 61
					as_regcolumns[as_regcolumns.Extend((Sybase.PowerBuilder.PBLong)(li_regcnt))] = ((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_cnt)]);
					#line hidden
				}
		}
		#line 65
		return (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(as_regcolumns)));
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_isregistered(BS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isregistered", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isregistered(Sybase.PowerBuilder.PBString as_column)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_column))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_column)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 56
		as_column = Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_column));
		#line hidden
		#line 59
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_skipcolumn)));
		#line hidden
		#line 60
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 61
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_cnt)]) == as_column))
				#line hidden
				{
					#line 63
					return new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
		}
		#line 68
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_unregister(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_unregister", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_unregister(Sybase.PowerBuilder.PBString as_column)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_column))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_column)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_skipcolumn)));
		#line hidden
		#line 58
		for (li_index = new Sybase.PowerBuilder.PBInt(1);li_index <= li_upper;li_index = li_index + 1)
		#line hidden
		{
				#line 59
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_column) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(((Sybase.PowerBuilder.PBString)is_skipcolumn[(Sybase.PowerBuilder.PBLong)(li_index)]))))
				#line hidden
				{
					#line 62
					is_skipcolumn[is_skipcolumn.Extend((Sybase.PowerBuilder.PBLong)(li_index))] = new Sybase.PowerBuilder.PBString("");
					#line hidden
					#line 65
					of_updateskipstring_1_34525222535703856(this, (Sybase.PowerBuilder.PBUnboundedStringArray)(is_skipcolumn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)));
					#line hidden
					#line 67
					return new Sybase.PowerBuilder.PBInt(1);
					#line hidden
				}
		}
		#line 72
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_reqcolumn.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		anv_attrib.is_propertypage.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedStringArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 1},false), new Sybase.PowerBuilder.PBString[1]{
		#line 56
		new Sybase.PowerBuilder.PBString("u_tabpg_dwproperty_srvreqcolumn") })));
		#line hidden
		#line 57
		anv_attrib.ib_switchbuttons = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 59
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		this.TriggerEvent(new Sybase.PowerBuilder.PBString("destructor"));
		#line hidden
	}

	public Sybase.PowerBuilder.PBInt of_updateskipstring_1_34525222535703856(c__pfc_n_cst_dwsrv_reqcolumn this__object, Sybase.PowerBuilder.PBArray as_skipcolumn)
	{
		 Sybase.PowerBuilder.PBArray temp_var_as_skipcolumn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_skipcolumn.AssignFrom(as_skipcolumn);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_updateskipstring_1_345252223(temp_var_as_skipcolumn);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getobjects_4_345252223_4_pf1632708430(c__pfc_n_cst_dwsrv this__object, ref Sybase.PowerBuilder.PBArray as_objlist, Sybase.PowerBuilder.PBString as_objtype, Sybase.PowerBuilder.PBString as_band, Sybase.PowerBuilder.PBBoolean ab_visibleonly)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getobjects_4_345252223(ref as_objlist, as_objtype, as_band, ab_visibleonly);
		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dwsrv_reqcolumn()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwsrv_reqcolumn(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwsrv_reqcolumn vv = new c__pfc_n_cst_dwsrv_reqcolumn();
			if (vv.FromUnboundedAnyArray(a) > 0)
			{
				return vv;
			}
			else
			{
				return null;
			}
		}
		else
		{
			return (c__pfc_n_cst_dwsrv_reqcolumn) v.Value;
		}
	}
}
 