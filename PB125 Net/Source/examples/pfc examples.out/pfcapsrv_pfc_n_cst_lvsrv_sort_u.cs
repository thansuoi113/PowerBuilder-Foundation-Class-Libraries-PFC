//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_lvsrv_sort.sru"
#line hidden
#line 1 "pfc_n_cst_lvsrv_sort"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_lvsrv_sort",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_lvsrv_sort")]
public class c__pfc_n_cst_lvsrv_sort : c__n_cst_lvsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_columnheadersort", null, "pfc_n_cst_lvsrv_sort", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_columnheadersort = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_excludecolumns", null, "pfc_n_cst_lvsrv_sort", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray is_excludecolumns = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_currentsortcol", null, "pfc_n_cst_lvsrv_sort", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBInt ii_currentsortcol = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ie_currentsort", null, "pfc_n_cst_lvsrv_sort", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBGRSortTypeValue ie_currentsort = new Sybase.PowerBuilder.PBGRSortTypeValue();

	#line 1 "pfc_n_cst_lvsrv_sort.pfc_columnclick"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_columnclick")]
	public virtual Sybase.PowerBuilder.PBLong pfc_columnclick(Sybase.PowerBuilder.PBInt ai_column)
	{
		#line hidden
		c__n_cst_columnattrib lnv_columnattrib = (c__n_cst_columnattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_columnattrib));
		#line 52
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 52
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_column))))| ((Sybase.PowerBuilder.PBLong)(ai_column)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))))
		#line hidden
		{
			#line 53
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 56
		if (!(this.of_iscolumnheader()))
		#line hidden
		{
			#line 57
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
		}
		else
		{
			#line 60
			if (this.of_isexclude(ai_column))
			#line hidden
			{
				#line 61
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
			#line 63
			if ((Sybase.PowerBuilder.PBBoolean)(ai_column != ii_currentsortcol))
			#line hidden
			{
				#line 64
				ie_currentsort = (new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Ascending));
				#line hidden
				#line 65
				ii_currentsortcol = ai_column;
				#line hidden
			}
			else
			{
				#line 67
				if ((Sybase.PowerBuilder.PBBoolean)(ie_currentsort == (new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Ascending))))
				#line hidden
				{
					#line 68
					ie_currentsort = (new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Descending));
					#line hidden
				}
				else
				{
					#line 70
					ie_currentsort = (new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Ascending));
					#line hidden
				}
			}
			#line 76
			ilv_requestor.of_getcolumninfo_2_1110033942(ai_column, ref lnv_columnattrib);
			#line hidden
			#line 77
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(lnv_columnattrib.is_coltype, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))) == new Sybase.PowerBuilder.PBString("char")))
			#line hidden
			{
				#line 79
				ilv_requestor.Sort(ie_currentsort, ai_column);
				#line hidden
			}
			else
			{
				#line 82
				ilv_requestor.Sort((new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Userdefinedsort)), ai_column);
				#line hidden
			}
		}
		#line 87
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.pfc_sort"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_sort")]
	public virtual Sybase.PowerBuilder.PBLong pfc_sort(Sybase.PowerBuilder.PBInt ai_index1, Sybase.PowerBuilder.PBInt ai_index2, Sybase.PowerBuilder.PBInt ai_column)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_returnmodifier = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_value1 = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_value2 = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_columnattrib lnv_columnattrib = (c__n_cst_columnattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_columnattrib));
		Sybase.PowerBuilder.PBDate ld_item1 = Sybase.PowerBuilder.PBDate.DefaultValue;
		Sybase.PowerBuilder.PBDate ld_item2 = Sybase.PowerBuilder.PBDate.DefaultValue;
		Sybase.PowerBuilder.PBDateTime ldt_item1 = Sybase.PowerBuilder.PBDateTime.DefaultValue;
		Sybase.PowerBuilder.PBDateTime ldt_item2 = Sybase.PowerBuilder.PBDateTime.DefaultValue;
		Sybase.PowerBuilder.PBDecimal ldc_item1 = new Sybase.PowerBuilder.PBDecimal(0m);
		Sybase.PowerBuilder.PBDecimal ldc_item2 = new Sybase.PowerBuilder.PBDecimal(0m);
		Sybase.PowerBuilder.PBLong ll_item1 = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_item2 = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBReal lr_item1 = Sybase.PowerBuilder.PBReal.DefaultValue;
		Sybase.PowerBuilder.PBReal lr_item2 = Sybase.PowerBuilder.PBReal.DefaultValue;
		Sybase.PowerBuilder.PBTime lt_item1 = Sybase.PowerBuilder.PBTime.DefaultValue;
		Sybase.PowerBuilder.PBTime lt_item2 = Sybase.PowerBuilder.PBTime.DefaultValue;
		#line 54
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 54
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
		}
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_index1))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_index2)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_column))))))
		#line hidden
		{
			#line 55
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBLong)(ai_index1)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))| ((Sybase.PowerBuilder.PBLong)(ai_index2)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))| ((Sybase.PowerBuilder.PBLong)(ai_column)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))))
		#line hidden
		{
			#line 56
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(ie_currentsort == (new Sybase.PowerBuilder.PBGRSortTypeValue(Sybase.PowerBuilder.PBGRSortType.Ascending))))
		#line hidden
		{
			#line 60
			li_returnmodifier = new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		else
		{
			#line 62
			li_returnmodifier = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 66
		ilv_requestor.GetItem(ai_index1, ai_column, ref ls_value1);
		#line hidden
		#line 67
		ilv_requestor.GetItem(ai_index2, ai_column, ref ls_value2);
		#line hidden
		#line 70
		ilv_requestor.of_getcolumninfo_2_1110033942(ai_column, ref lnv_columnattrib);
		#line hidden
		#line 71
		Sybase.PowerBuilder.PBString __PB_TEMP______switchTmpVar0 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(lnv_columnattrib.is_coltype, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))));
		#line hidden
		#line 72
		if ((__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("char(") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("char") ))
		#line hidden
		{
			#line 73
			if ((Sybase.PowerBuilder.PBBoolean)(ls_value1> ls_value2))
			#line hidden
			{
				#line 74
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 75
			else if ((Sybase.PowerBuilder.PBBoolean)(ls_value1< ls_value2))
			#line hidden
			{
				#line 76
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 78
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 80
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("date") )
		#line hidden
		{
			#line 82
			ld_item1 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Date(ls_value1);
			#line hidden
			#line 83
			ld_item2 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Date(ls_value2);
			#line hidden
			#line 84
			if ((Sybase.PowerBuilder.PBBoolean)(ld_item1> ld_item2))
			#line hidden
			{
				#line 85
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 86
			else if ((Sybase.PowerBuilder.PBBoolean)(ld_item1< ld_item2))
			#line hidden
			{
				#line 87
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 89
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 91
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("datet") )
		#line hidden
		{
			#line 93
			ldt_item1 = Sybase.PowerBuilder.WPF.PBSystemFunctions.DateTime((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value1))));
			#line hidden
			#line 94
			ldt_item2 = Sybase.PowerBuilder.WPF.PBSystemFunctions.DateTime((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value2))));
			#line hidden
			#line 95
			if ((Sybase.PowerBuilder.PBBoolean)(ldt_item1> ldt_item2))
			#line hidden
			{
				#line 96
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 97
			else if ((Sybase.PowerBuilder.PBBoolean)(ldt_item1< ldt_item2))
			#line hidden
			{
				#line 98
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 100
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 102
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("decim") )
		#line hidden
		{
			#line 104
			ldc_item1.AssignFrom(Sybase.PowerBuilder.WPF.PBSystemFunctions.Dec((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value1)))));
			#line hidden
			#line 105
			ldc_item2.AssignFrom(Sybase.PowerBuilder.WPF.PBSystemFunctions.Dec((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value2)))));
			#line hidden
			#line 106
			if ((Sybase.PowerBuilder.PBBoolean)(ldc_item1> ldc_item2))
			#line hidden
			{
				#line 107
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 108
			else if ((Sybase.PowerBuilder.PBBoolean)(ldc_item1< ldc_item2))
			#line hidden
			{
				#line 109
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 111
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 113
		else if ((__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("numbe") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("long") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("ulong") ))
		#line hidden
		{
			#line 115
			ll_item1 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Long((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value1))));
			#line hidden
			#line 116
			ll_item2 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Long((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value2))));
			#line hidden
			#line 117
			if ((Sybase.PowerBuilder.PBBoolean)(ll_item1> ll_item2))
			#line hidden
			{
				#line 118
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 119
			else if ((Sybase.PowerBuilder.PBBoolean)(ll_item1< ll_item2))
			#line hidden
			{
				#line 120
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 122
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 124
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("real") )
		#line hidden
		{
			#line 126
			lr_item1 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Real((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value1))));
			#line hidden
			#line 127
			lr_item2 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Real((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_value2))));
			#line hidden
			#line 128
			if ((Sybase.PowerBuilder.PBBoolean)(lr_item1> lr_item2))
			#line hidden
			{
				#line 129
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 130
			else if ((Sybase.PowerBuilder.PBBoolean)(lr_item1< lr_item2))
			#line hidden
			{
				#line 131
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 133
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		#line 135
		else if ((__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("time") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("times") ))
		#line hidden
		{
			#line 137
			lt_item1 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Time(ls_value1);
			#line hidden
			#line 138
			lt_item2 = Sybase.PowerBuilder.WPF.PBSystemFunctions.Time(ls_value2);
			#line hidden
			#line 139
			if ((Sybase.PowerBuilder.PBBoolean)(lt_item1> lt_item2))
			#line hidden
			{
				#line 140
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			#line 141
			else if ((Sybase.PowerBuilder.PBBoolean)(lt_item1< lt_item2))
			#line hidden
			{
				#line 142
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))* (Sybase.PowerBuilder.PBLong)(li_returnmodifier);
				#line hidden
			}
			else
			{
				#line 144
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
		}
		else 
		{
			#line 147
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
		}

		#line 150
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_iscolumnheader(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_iscolumnheader", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_iscolumnheader()
	{
		#line hidden
		#line 47
		return ib_columnheadersort;
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_setcolumnheader(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setcolumnheader", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setcolumnheader(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		ib_columnheadersort = ab_switch;
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_setexclude(IS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setexclude", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setexclude_1_345252223([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_excludecols)
	{
		#line hidden
		#line 47
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(as_excludecols))< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		is_excludecolumns.AssignFrom((Sybase.PowerBuilder.PBArray)as_excludecols);
		#line hidden
		#line 53
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_getexclude(IRS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getexclude", new string[]{"ref string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getexclude_1_345252223([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] ref Sybase.PowerBuilder.PBArray as_excludecols)
	{
		#line hidden
		Sybase.PowerBuilder.PBArray ls_empty = new Sybase.PowerBuilder.PBUnboundedStringArray();
		#line 49
		as_excludecols.AssignFrom((Sybase.PowerBuilder.PBArray)ls_empty);
		#line hidden
		#line 50
		as_excludecols.AssignFrom((Sybase.PowerBuilder.PBArray)is_excludecolumns);
		#line hidden
		#line 52
		return (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(as_excludecols)));
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_isexclude(BI)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isexclude", new string[]{"integer"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isexclude(Sybase.PowerBuilder.PBInt ai_column)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_width = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_label = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBAlignmentValue lal_align = new Sybase.PowerBuilder.PBAlignmentValue();
		#line 50
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_column))))| ((Sybase.PowerBuilder.PBLong)(ai_column)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 54
		ilv_requestor.GetColumn(ai_column, ref ls_label, ref lal_align, ref li_width);
		#line hidden
		#line 56
		return this.of_isexclude(ls_label);
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv_sort.of_isexclude(BS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isexclude", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isexclude(Sybase.PowerBuilder.PBString as_columnlabel)
	{
		#line hidden
		Sybase.PowerBuilder.PBBoolean lb_exclude = new Sybase.PowerBuilder.PBBoolean(false);
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 49
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_columnlabel))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_columnlabel) == new Sybase.PowerBuilder.PBString(""))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 53
		li_count = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_excludecolumns)));
		#line hidden
		#line 54
		for (li_index = new Sybase.PowerBuilder.PBInt(1);li_index <= li_count;li_index = li_index + 1)
		#line hidden
		{
				#line 55
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_columnlabel) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(((Sybase.PowerBuilder.PBString)is_excludecolumns[(Sybase.PowerBuilder.PBLong)(li_index)]))))
				#line hidden
				{
					#line 56
					lb_exclude = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
					#line 57
					break;
					#line hidden
				}
		}
		#line 61
		return lb_exclude;
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

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_lvsrv_sort()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_lvsrv_sort(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_lvsrv_sort vv = new c__pfc_n_cst_lvsrv_sort();
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
			return (c__pfc_n_cst_lvsrv_sort) v.Value;
		}
	}
}
 