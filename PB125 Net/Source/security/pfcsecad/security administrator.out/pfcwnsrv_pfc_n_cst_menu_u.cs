//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcwnsrv.pbl\\pfcwnsrv.pblx\\pfc_n_cst_menu.sru"
#line hidden
#line 1 "pfc_n_cst_menu"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_menu",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcwnsrv.pbl\\pfcwnsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_menu")]
public class c__pfc_n_cst_menu : c__n_base
{
	#line hidden

	#line 1 "pfc_n_cst_menu.of_isinarray(BI[]I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isinarray", new string[]{"integer", "integer"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isinarray_2_1875031253([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBInt))] Sybase.PowerBuilder.PBArray ai_barindexarray, Sybase.PowerBuilder.PBInt ai_barindex)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_arraysize = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 52
		li_arraysize = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ai_barindexarray)));
		#line hidden
		#line 54
		for (li = new Sybase.PowerBuilder.PBInt(1);li <= li_arraysize;li = li + 1)
		#line hidden
		{
				#line 55
				if ((Sybase.PowerBuilder.PBBoolean)(ai_barindex == ((Sybase.PowerBuilder.PBInt)ai_barindexarray[(Sybase.PowerBuilder.PBLong)(li)])))
				#line hidden
				{
					#line 56
					return new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
		}
		#line 60
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_getmdiframe(ICmenu.RCwindow.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getmdiframe", new string[]{"menu", "ref window"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getmdiframe_2_232646770<T1>(Sybase.PowerBuilder.WPF.PBMenu am_source, ref T1 aw_frame) where T1 : Sybase.PowerBuilder.WPF.PBWindow
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_obj = null;
		Sybase.PowerBuilder.PBBoolean lb_foundframe = new Sybase.PowerBuilder.PBBoolean(false);
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(am_source)))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBMenu)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(am_source)))))))))
		#line hidden
		{
			#line 54
			aw_frame = null;
			#line hidden
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		lw_obj = am_source.ParentWindow;
		#line hidden
		#line 62
		while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_obj)) )
		#line hidden
		{
				#line 63
				if ((Sybase.PowerBuilder.PBBoolean)((lw_obj.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Mdi)))| (lw_obj.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.MdiHelp)))))
				#line hidden
				{
					#line 65
					lb_foundframe = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
					#line 66
					break;
					#line hidden
				}
				else
				{
					#line 69
					lw_obj = lw_obj.ParentWindow();
					#line hidden
				}
		}

		#line 73
		if (!(lb_foundframe))
		#line hidden
		{
			#line 75
			aw_frame = null;
			#line hidden
			#line 76
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 80
		aw_frame = (T1)(Sybase.PowerBuilder.WPF.PBWindow)(lw_obj);
		#line hidden
		#line 81
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_getalltoolbarindex(ICmenu.RI[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getalltoolbarindex", new string[]{"menu", "ref integer"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getalltoolbarindex_2_1875031253(Sybase.PowerBuilder.WPF.PBMenu am_source, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBInt))] ref Sybase.PowerBuilder.PBArray ai_barindex)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_limit = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(am_source)))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBMenu)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(am_source)))))))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(am_source.ToolbarItemName)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 60
			if (!(of_isinarray_2_1875031253_2_pf974146142(this, (Sybase.PowerBuilder.PBUnboundedIntArray)(ai_barindex).ToUnbounded(typeof(Sybase.PowerBuilder.PBInt)), am_source.ToolbarItemBarIndex)))
			#line hidden
			{
				#line 61
				ai_barindex[ai_barindex.Extend(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ai_barindex))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = am_source.ToolbarItemBarIndex;
				#line hidden
			}
		}
		#line 66
		li_limit = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(am_source.Item)));
		#line hidden
		#line 67
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_limit;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 68
				of_getalltoolbarindex_2_1875032057645719(this, ((Sybase.PowerBuilder.WPF.PBMenu)am_source.Item[(Sybase.PowerBuilder.PBLong)(li_cnt)]), ref ai_barindex);
				#line hidden
		}
		#line 71
		return (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ai_barindex)));
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_toolbarexists(BCmenu.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_toolbarexists", new string[]{"menu"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_toolbarexists(Sybase.PowerBuilder.WPF.PBMenu am_source)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_limit = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_toolbarexists = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_null = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(am_source)))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBMenu)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(am_source)))))))))
		#line hidden
		{
			#line 57
			lb_null.SetNull();
			#line hidden
			#line 58
			return lb_null;
			#line hidden
		}
		#line 61
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(am_source.ToolbarItemName)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 62
			return new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 67
		li_limit = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(am_source.Item)));
		#line hidden
		#line 68
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_limit;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 69
				lb_toolbarexists = this.of_toolbarexists(((Sybase.PowerBuilder.WPF.PBMenu)am_source.Item[(Sybase.PowerBuilder.PBLong)(li_cnt)]));
				#line hidden
				#line 70
				if ((Sybase.PowerBuilder.PBBoolean)((lb_toolbarexists == new Sybase.PowerBuilder.PBBoolean(true))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(lb_toolbarexists))))))
				#line hidden
				{
					#line 71
					return lb_toolbarexists;
					#line hidden
				}
		}
		#line 75
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_triggerevent(ICmenu.S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_triggerevent", new string[]{"menu", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_triggerevent(Sybase.PowerBuilder.WPF.PBMenu am_source, Sybase.PowerBuilder.PBString as_event)
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_frame = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_obj = null;
		Sybase.PowerBuilder.PBBoolean lb_frame_exists = new Sybase.PowerBuilder.PBBoolean(false);
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(am_source)))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBMenu)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(am_source)))))))))
		#line hidden
		{
			#line 64
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 70
		this.of_getmdiframe_2_232646770(am_source, ref lw_frame);
		#line hidden
		#line 71
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_frame))))))))& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_frame))))
		#line hidden
		{
			#line 72
			lb_frame_exists = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 78
		if (lb_frame_exists)
		#line hidden
		{
			#line 79
			lw_sheet = lw_frame.GetActiveSheet();
			#line hidden
			#line 80
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
			#line hidden
			{
				#line 81
				return lw_sheet.TriggerEvent(as_event);
				#line hidden
			}
		}
		#line 89
		if (lb_frame_exists)
		#line hidden
		{
			#line 90
			return lw_frame.TriggerEvent(as_event);
			#line hidden
		}
		#line 97
		lw_obj = am_source.ParentWindow;
		#line hidden
		#line 98
		return lw_obj.TriggerEvent(as_event);
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_sendmessage(ICmenu.S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sendmessage", new string[]{"menu", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sendmessage(Sybase.PowerBuilder.WPF.PBMenu am_source, Sybase.PowerBuilder.PBString as_message)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(-1);
		Sybase.PowerBuilder.WPF.PBWindow lw_frame = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_message))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_message)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 64
			return li_rc;
			#line hidden
		}
		#line 68
		this.of_getmdiframe_2_232646770(am_source, ref lw_frame);
		#line hidden
		#line 69
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_frame)))
		#line hidden
		{
			#line 72
			lw_sheet = lw_frame.GetActiveSheet();
			#line hidden
			#line 73
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
			#line hidden
			{
				#line 74
				li_rc = (Sybase.PowerBuilder.PBInt)(Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind205412110(lw_sheet, ref as_message));
				#line hidden
			}
			#line 77
			if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 79
				li_rc = (Sybase.PowerBuilder.PBInt)(Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind205412110(lw_frame, ref as_message));
				#line hidden
			}
		}
		else
		{
			#line 83
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(am_source.ParentWindow)))
			#line hidden
			{
				#line 84
				li_rc = (Sybase.PowerBuilder.PBInt)(Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind205412110(am_source.ParentWindow, ref as_message));
				#line hidden
			}
		}
		#line 88
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_rc)))))
		#line hidden
		{
			#line 89
			li_rc = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 93
		if ((Sybase.PowerBuilder.PBBoolean)((li_rc == new Sybase.PowerBuilder.PBInt(-1))& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_debug))))
		#line hidden
		{
			#line 94
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_menu_msgnotreceived"), c__n_cst_debug.pfc_name, (new Sybase.PowerBuilder.PBString("Message ")+ as_message)+ new Sybase.PowerBuilder.PBString(" was not received."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Information)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 98
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_menu.of_getmenureference(IRCmenu.SRCmenu.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getmenureference", new string[]{"ref menu", "string", "ref menu"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getmenureference_3_480990538<T0, T2>(ref T0 am_source, Sybase.PowerBuilder.PBString as_findmenuitem, ref T2 am_menureference) where T0 : Sybase.PowerBuilder.WPF.PBMenu where T2 : Sybase.PowerBuilder.WPF.PBMenu
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_limit = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_found = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBBoolean lb_found = new Sybase.PowerBuilder.PBBoolean(false);
		Sybase.PowerBuilder.PBString ls_searchitem = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		#line 60
		if ((Sybase.PowerBuilder.PBBoolean)(!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.WPF.PBMenu)(am_source)))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBMenu)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBMenu)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(am_source)))))))))
		#line hidden
		{
			#line 61
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 64
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_findmenuitem))))| (as_findmenuitem == new Sybase.PowerBuilder.PBString(""))))
		#line hidden
		{
			#line 65
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 68
		ls_searchitem = Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_findmenuitem);
		#line hidden
		#line 71
		li_limit = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(am_source.Item)));
		#line hidden
		#line 72
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_limit;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 73
				if ((Sybase.PowerBuilder.PBBoolean)(ls_searchitem == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(((Sybase.PowerBuilder.WPF.PBMenu)am_source.Item[am_source.Item.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).ClassName())))
				#line hidden
				{
					#line 74
					am_menureference = (T2)(Sybase.PowerBuilder.WPF.PBMenu)(((Sybase.PowerBuilder.WPF.PBMenu)am_source.Item[(Sybase.PowerBuilder.PBLong)(li_cnt)]));
					#line hidden
					#line 75
					li_found = new Sybase.PowerBuilder.PBInt(1);
					#line hidden
				}
				else
				{
					#line 78
					if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_found)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 78
						continue;
						#line hidden
					}
					#line 80
					li_found = of_getmenureference_3_480990531090860452(this, am_source.Item, (Sybase.PowerBuilder.PBLong)(li_cnt), as_findmenuitem, ref am_menureference);
					#line hidden
				}
		}
		#line 84
		return li_found;
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

	public override object Clone()
	{
		c__pfc_n_cst_menu vv = (c__pfc_n_cst_menu)base.Clone();
 		return vv;
	}

	public Sybase.PowerBuilder.PBBoolean of_isinarray_2_1875031253_2_pf974146142(c__pfc_n_cst_menu this__object, Sybase.PowerBuilder.PBArray ai_barindexarray, Sybase.PowerBuilder.PBInt ai_barindex)
	{
		 Sybase.PowerBuilder.PBArray temp_var_ai_barindexarray = new Sybase.PowerBuilder.PBUnboundedIntArray();
		temp_var_ai_barindexarray.AssignFrom(ai_barindexarray);
		Sybase.PowerBuilder.PBBoolean return_value = this__object.of_isinarray_2_1875031253(temp_var_ai_barindexarray, ai_barindex);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getalltoolbarindex_2_1875032057645719(c__pfc_n_cst_menu this__object, Sybase.PowerBuilder.WPF.PBMenu am_source, ref Sybase.PowerBuilder.PBArray ai_barindex)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getalltoolbarindex_2_1875031253(am_source, ref ai_barindex);
		return return_value;
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind205412110(Sybase.PowerBuilder.WPF.PBWindow this__object, ref Sybase.PowerBuilder.PBString temp_arg_name_0)
	{
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[1] {
			new Sybase.PowerBuilder.PBArgument(temp_arg_name_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(Sybase.PowerBuilder.PBString))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "pfc_messagerouter", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0 = (Sybase.PowerBuilder.PBString)__tempArgument4DynamicCall[0].Value;

		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getmenureference_3_480990531090860452<T2>(c__pfc_n_cst_menu this__object, Sybase.PowerBuilder.PBArray am_source, int am_source_dim_0, Sybase.PowerBuilder.PBString as_findmenuitem, ref T2 am_menureference) where T2: Sybase.PowerBuilder.WPF.PBMenu
	{
		Sybase.PowerBuilder.WPF.PBMenu temp_var_0 = (Sybase.PowerBuilder.WPF.PBMenu) ((Sybase.PowerBuilder.PBUnboundedArray)am_source)[am_source_dim_0, true];
		Sybase.PowerBuilder.WPF.PBMenu temp_var_2 = am_menureference;
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getmenureference_3_480990538(ref temp_var_0, as_findmenuitem, ref temp_var_2);
		am_source[am_source_dim_0] = temp_var_0;
		am_menureference = (T2)temp_var_2;
		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_menu()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_menu(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_menu vv = new c__pfc_n_cst_menu();
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
			return (c__pfc_n_cst_menu) v.Value;
		}
	}
}
 