//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcmain.pbl\\pfcmain.pblx\\pfc_w_sheet.srw"
#line hidden
#line 1 "pfc_w_sheet"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_sheet",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\demoapp\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_sheet")]
public class c__pfc_w_sheet : c__w_master
{
	#line hidden

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
	}

	#line 1 "pfc_w_sheet.pfc_controlgotfocus"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_controlgotfocus")]
	public override void pfc_controlgotfocus(Sybase.PowerBuilder.WPF.PBDragObject adrg_control)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_columntag = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_microhelp = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_colname = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.WPF.PBDataWindow ldw_control = null;
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		#line 1
		base.pfc_controlgotfocus(adrg_control);
		#line hidden
		#line 52
		if (c__peat.GetCurrentApplication().gnv_app.of_getmicrohelp())
		#line hidden
		{
			#line 54
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBDragObject.TypeOf(adrg_control) == (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.DataWindow))))
			#line hidden
			{
				#line 55
				ldw_control = (Sybase.PowerBuilder.WPF.PBDataWindow)(((Sybase.PowerBuilder.WPF.PBDragObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(adrg_control))));
				#line hidden
				#line 56
				ls_colname = ldw_control.GetColumnName();
				#line hidden
				#line 57
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_colname)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 59
					ls_columntag = ldw_control.Describe(ls_colname+ new Sybase.PowerBuilder.PBString(".tag"));
					#line hidden
					#line 60
					ls_microhelp = lnv_string.of_getkeyvalue(ls_columntag, new Sybase.PowerBuilder.PBString("microhelp"), new Sybase.PowerBuilder.PBString(";"));
					#line hidden
				}
			}
			else
			{
				#line 64
				ls_microhelp = lnv_string.of_getkeyvalue(adrg_control.Tag, new Sybase.PowerBuilder.PBString("microhelp"), new Sybase.PowerBuilder.PBString(";"));
				#line hidden
			}
			#line 68
			if (lnv_string.of_isempty(ls_microhelp))
			#line hidden
			{
				#line 69
				ls_microhelp = new Sybase.PowerBuilder.PBString("");
				#line hidden
			}
			#line 73
			this.pfc_microhelp(ls_microhelp);
			#line hidden
		}
	}

	#line 1 "pfc_w_sheet.pfc_microhelp"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_microhelp")]
	public override void pfc_microhelp(Sybase.PowerBuilder.PBString as_microhelp)
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_frame = null;
		#line 1
		base.pfc_microhelp(as_microhelp);
		#line hidden
		#line 46
		lw_frame = this.ParentWindow();
		#line hidden
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_frame)))
		#line hidden
		{
			#line 49
			Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind1892134229(lw_frame, ref as_microhelp);
			#line hidden
		}
	}

	#line 1 "pfc_w_sheet.activate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("activate")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_activate)]
	public override Sybase.PowerBuilder.PBLong activate()
	{
		#line hidden
		Sybase.PowerBuilder.PBObjectValue le_object = new Sybase.PowerBuilder.PBObjectValue();
		Sybase.PowerBuilder.WPF.PBGraphicObject lgo_focus = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.activate();
		#line hidden
		#line 42
		if (c__peat.GetCurrentApplication().gnv_app.of_getmicrohelp())
		#line hidden
		{
			#line 43
			lgo_focus = Sybase.PowerBuilder.WPF.PBSystemFunctions.GetFocus();
			#line hidden
			#line 44
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lgo_focus)))
			#line hidden
			{
				#line 45
				le_object = Sybase.PowerBuilder.WPF.PBGraphicObject.TypeOf(lgo_focus);
				#line hidden
				#line 46
				if ((Sybase.PowerBuilder.PBBoolean)(((le_object != (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.MDIClient)))& (le_object != (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.Menu))))& (le_object != (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.Window)))))
				#line hidden
				{
					#line 47
					this.pfc_controlgotfocus((Sybase.PowerBuilder.WPF.PBDragObject)(((Sybase.PowerBuilder.WPF.PBGraphicObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lgo_focus)))));
					#line hidden
				}
			}
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBWind1892134229(Sybase.PowerBuilder.WPF.PBWindow this__object, ref Sybase.PowerBuilder.PBString temp_arg_name_0)
	{
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[1] {
			new Sybase.PowerBuilder.PBArgument(temp_arg_name_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(Sybase.PowerBuilder.PBString))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "pfc_microhelp", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0 = (Sybase.PowerBuilder.PBString)__tempArgument4DynamicCall[0].Value;

		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ActivateEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.activate);
	}

	public c__pfc_w_sheet()
	{
		_init();
	}

}
 