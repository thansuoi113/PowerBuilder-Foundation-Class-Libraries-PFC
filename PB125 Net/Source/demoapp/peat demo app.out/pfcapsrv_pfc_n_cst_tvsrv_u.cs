//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_tvsrv.sru"
#line hidden
#line 1 "pfc_n_cst_tvsrv"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_tvsrv",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_tvsrv")]
public class c__pfc_n_cst_tvsrv : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBLong))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_queue", null, "pfc_n_cst_tvsrv", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray il_queue = new Sybase.PowerBuilder.PBUnboundedLongArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_delimiter", null, "pfc_n_cst_tvsrv", ";", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \";\"")]
	protected Sybase.PowerBuilder.PBString is_delimiter = new Sybase.PowerBuilder.PBString(";");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_displayitem", null, "pfc_n_cst_tvsrv", "this item", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \"this item\"")]
	protected Sybase.PowerBuilder.PBString is_displayitem = new Sybase.PowerBuilder.PBString("this item");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_displayunits", null, "pfc_n_cst_tvsrv", "items", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \"items\"")]
	protected Sybase.PowerBuilder.PBString is_displayunits = new Sybase.PowerBuilder.PBString("items");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itv_requestor", null, "pfc_n_cst_tvsrv", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_tvs itv_requestor = null;

	#line 1 "pfc_n_cst_tvsrv.of_getdataany(AL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdataany", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBAny of_getdataany(Sybase.PowerBuilder.PBLong al_handle)
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_handle))))| (al_handle< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 49
			return (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(itv_requestor.GetItem(al_handle, ref ltvi_item) != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 53
			return (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		else
		{
			#line 55
			return ltvi_item.Data;
			#line hidden
		}
	}

	#line 1 "pfc_n_cst_tvsrv.of_getdatastring(SL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdatastring", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdatastring(Sybase.PowerBuilder.PBLong al_handle)
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_handle))))| (al_handle< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(itv_requestor.GetItem(al_handle, ref ltvi_item) != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		else
		{
			#line 55
			return Sybase.PowerBuilder.WPF.PBSystemFunctions.String(((Sybase.PowerBuilder.PBAny)(ltvi_item.Data)));
			#line hidden
		}
	}

	#line 1 "pfc_n_cst_tvsrv.of_finditem(LSALIBB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_finditem", new string[]{"string", "any", "long", "integer", "boolean", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_finditem(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target, Sybase.PowerBuilder.PBLong al_begin, Sybase.PowerBuilder.PBInt ai_level, Sybase.PowerBuilder.PBBoolean ab_respectcase, Sybase.PowerBuilder.PBBoolean ab_fullcompare)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_next = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_parent = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray ll_queue = new Sybase.PowerBuilder.PBUnboundedLongArray();
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_attribute))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_begin)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_level)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_respectcase)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_fullcompare))))))
		#line hidden
		{
			#line 68
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 69
		if ((Sybase.PowerBuilder.PBBoolean)(((al_begin< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))| ((Sybase.PowerBuilder.PBLong)(ai_level)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))| (as_attribute == new Sybase.PowerBuilder.PBString(""))))
		#line hidden
		{
			#line 69
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 72
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 75
		il_queue.AssignFrom((Sybase.PowerBuilder.PBArray)ll_queue);
		#line hidden
		#line 78
		if ((Sybase.PowerBuilder.PBBoolean)(al_begin == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 80
			ll_handle = itv_requestor.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.RootTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
			#line hidden
		}
		else
		{
			#line 84
			li_next = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
			#line hidden
			#line 85
			il_queue[il_queue.Extend((Sybase.PowerBuilder.PBLong)(li_next))] = al_begin;
			#line hidden
			#line 87
			ll_handle = itv_requestor.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.NextTreeItem)), al_begin);
			#line hidden
		}
		#line 91
		while ( ll_handle> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
		#line hidden
		{
				#line 93
				li_next = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
				#line hidden
				#line 94
				il_queue[il_queue.Extend((Sybase.PowerBuilder.PBLong)(li_next))] = ll_handle;
				#line hidden
				#line 95
				ll_handle = itv_requestor.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.NextTreeItem)), ll_handle);
				#line hidden
		}

		#line 98
		return this.of_searchchild(as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), al_begin, ai_level, ab_respectcase, ab_fullcompare);
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_finditem(LSALIB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_finditem", new string[]{"string", "any", "long", "integer", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_finditem(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target, Sybase.PowerBuilder.PBLong al_begin, Sybase.PowerBuilder.PBInt ai_level, Sybase.PowerBuilder.PBBoolean ab_respectcase)
	{
		#line hidden
		#line 61
		return this.of_finditem(as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), al_begin, ai_level, ab_respectcase, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_finditem(LSALI)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_finditem", new string[]{"string", "any", "long", "integer"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_finditem(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target, Sybase.PowerBuilder.PBLong al_begin, Sybase.PowerBuilder.PBInt ai_level)
	{
		#line hidden
		#line 58
		return this.of_finditem(as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), al_begin, ai_level, new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_finditem(LSAL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_finditem", new string[]{"string", "any", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_finditem(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target, Sybase.PowerBuilder.PBLong al_begin)
	{
		#line hidden
		#line 57
		return this.of_finditem(as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), al_begin, new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_finditem(LSA)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_finditem", new string[]{"string", "any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_finditem(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target)
	{
		#line hidden
		#line 56
		return this.of_finditem(as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_setrequestor(ICu_tvs.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"u_tvs"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrequestor(c__u_tvs atv_requestor)
	{
		#line hidden
		#line 46
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_tvs)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(atv_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(atv_requestor)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		itv_requestor = atv_requestor;
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_setdisplayitem(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdisplayitem", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdisplayitem(Sybase.PowerBuilder.PBString as_displayitem)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_displayitem)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		is_displayitem = as_displayitem;
		#line hidden
		#line 55
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_getdisplayitem(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdisplayitem", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdisplayitem()
	{
		#line hidden
		#line 45
		return is_displayitem;
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_getdisplayunits(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdisplayunits", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdisplayunits()
	{
		#line hidden
		#line 45
		return is_displayunits;
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_setdisplayunits(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdisplayunits", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdisplayunits(Sybase.PowerBuilder.PBString as_displayunits)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_displayunits)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		is_displayunits = as_displayunits;
		#line hidden
		#line 55
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_getdatanumeric(LL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdatanumeric", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_getdatanumeric(Sybase.PowerBuilder.PBLong al_handle)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_data = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_handle))))| (al_handle< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 49
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(itv_requestor.GetItem(al_handle, ref ltvi_item) != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 53
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		else
		{
			#line 55
			ls_data = Sybase.PowerBuilder.WPF.PBSystemFunctions.String(((Sybase.PowerBuilder.PBAny)(ltvi_item.Data)));
			#line hidden
			#line 56
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNumber(ls_data))
			#line hidden
			{
				#line 57
				return Sybase.PowerBuilder.WPF.PBSystemFunctions.Long((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_data))));
				#line hidden
			}
			else
			{
				#line 59
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
				#line hidden
			}
		}
	}

	#line 1 "pfc_n_cst_tvsrv.of_setdelimiter(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdelimiter", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdelimiter(Sybase.PowerBuilder.PBString as_delimiter)
	{
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_delimiter))))| (as_delimiter == new Sybase.PowerBuilder.PBString(""))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		is_delimiter = as_delimiter;
		#line hidden
		#line 55
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_getdelimiter(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdelimiter", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdelimiter()
	{
		#line hidden
		#line 46
		return is_delimiter;
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_findfirstitemlevel(LIL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_findfirstitemlevel", new string[]{"integer", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_findfirstitemlevel(Sybase.PowerBuilder.PBInt ai_level, Sybase.PowerBuilder.PBLong al_handle)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_found = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBInt li_items = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_idx = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		Sybase.PowerBuilder.PBAny la_find = Sybase.PowerBuilder.PBAny.DefaultValue;
		#line 57
		la_find = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBString("0987654321FIRSTitemonlevel1234567890)(*&^%$#@!~"));
		#line hidden
		#line 60
		this.of_finditem(new Sybase.PowerBuilder.PBString("label"), ((Sybase.PowerBuilder.PBAny)(la_find)), al_handle, ai_level, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 62
		li_items = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue)));
		#line hidden
		#line 63
		for (li_idx = new Sybase.PowerBuilder.PBInt(1);li_idx <= li_items;li_idx = li_idx + 1)
		#line hidden
		{
				#line 64
				if ((Sybase.PowerBuilder.PBBoolean)(itv_requestor.GetItem(((Sybase.PowerBuilder.PBLong)il_queue[(Sybase.PowerBuilder.PBLong)(li_idx)]), ref ltvi_item) == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 64
					return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
					#line hidden
				}
				#line 67
				if ((Sybase.PowerBuilder.PBBoolean)(ai_level == ltvi_item.Level))
				#line hidden
				{
					#line 68
					return ((Sybase.PowerBuilder.PBLong)il_queue[(Sybase.PowerBuilder.PBLong)(li_idx)]);
					#line hidden
				}
		}
		#line 72
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
	}

	#line 1 "pfc_n_cst_tvsrv.of_searchchild(LSALIBB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_searchchild", new string[]{"string", "any", "long", "integer", "boolean", "boolean"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_searchchild(Sybase.PowerBuilder.PBString as_attribute, Sybase.PowerBuilder.PBAny aa_target, Sybase.PowerBuilder.PBLong al_begin, Sybase.PowerBuilder.PBInt ai_level, Sybase.PowerBuilder.PBBoolean ab_respectcase, Sybase.PowerBuilder.PBBoolean ab_fullcompare)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_level = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_next = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_child = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_qposition = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 68
		ll_qposition = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
		#line 70
		if ((Sybase.PowerBuilder.PBBoolean)(ll_qposition> Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue))))
		#line hidden
		{
			#line 70
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		do
		{
				#line 73
				ll_handle = ((Sybase.PowerBuilder.PBLong)il_queue[ll_qposition]);
				#line hidden
				#line 76
				if ((Sybase.PowerBuilder.PBBoolean)(itv_requestor.GetItem(ll_handle, ref ltvi_item) == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 76
					return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
					#line hidden
				}
				#line 77
				li_level = ltvi_item.Level;
				#line hidden
				#line 80
				if ((Sybase.PowerBuilder.PBBoolean)((ai_level == new Sybase.PowerBuilder.PBInt(0))| (ai_level == li_level)))
				#line hidden
				{
					#line 81
					if (itv_requestor.pfc_searchcompare(ll_handle, as_attribute, ((Sybase.PowerBuilder.PBAny)(aa_target)), ab_respectcase, ab_fullcompare))
					#line hidden
					{
						#line 82
						return ll_handle;
						#line hidden
					}
				}
				else
				{
					#line 86
					if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_level)> (Sybase.PowerBuilder.PBLong)(ai_level)))
					#line hidden
					{
						#line 86
						return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
						#line hidden
					}
				}
				#line 90
				ll_child = itv_requestor.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.ChildTreeItem)), ll_handle);
				#line hidden
				#line 91
				while ( ll_child> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
				#line hidden
				{
						#line 93
						li_next = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
						#line hidden
						#line 94
						il_queue[il_queue.Extend((Sybase.PowerBuilder.PBLong)(li_next))] = ll_child;
						#line hidden
						#line 95
						ll_child = itv_requestor.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.NextTreeItem)), ll_child);
						#line hidden
				}

				#line 98
				ll_qposition++;
				#line hidden
		}
		#line 100
		while ( !(ll_qposition> Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(il_queue))));
		#line hidden
		#line 102
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
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

	public c__pfc_n_cst_tvsrv()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_tvsrv(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_tvsrv vv = new c__pfc_n_cst_tvsrv();
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
			return (c__pfc_n_cst_tvsrv) v.Value;
		}
	}
}
 