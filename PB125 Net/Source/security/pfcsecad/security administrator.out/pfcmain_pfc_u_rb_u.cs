//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcmain.pbl\\pfcmain.pblx\\pfc_u_rb.sru"
#line hidden
#line 1 "pfc_u_rb"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_rb",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_rb")]
public class c__pfc_u_rb : Sybase.PowerBuilder.WPF.PBRadioButton
{
	#line hidden

	#line 1 "pfc_u_rb.of_getparentwindow(IRCwindow.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getparentwindow", new string[]{"ref window"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getparentwindow_1_232646770<T0>(ref T0 aw_parent) where T0 : Sybase.PowerBuilder.WPF.PBWindow
	{
		#line hidden
		Sybase.PowerBuilder.PBPowerObject lpo_parent = null;
		#line 50
		lpo_parent = this.GetParent();
		#line hidden
		#line 53
		while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(lpo_parent) )
		#line hidden
		{
				#line 54
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.PBPowerObject.TypeOf(lpo_parent) != (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.Window))))
				#line hidden
				{
					#line 55
					lpo_parent = lpo_parent.GetParent();
					#line hidden
				}
				else
				{
					#line 57
					break;
					#line hidden
				}
		}

		#line 61
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lpo_parent)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(lpo_parent))))
		#line hidden
		{
			#line 62
			aw_parent = null;
			#line hidden
			#line 63
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 66
		aw_parent = (T0)(Sybase.PowerBuilder.WPF.PBWindow)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lpo_parent))));
		#line hidden
		#line 67
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_rb.of_messagebox(ISSSCicon.Cbutton.I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_messagebox", new string[]{"string", "string", "string", "icon", "button", "integer"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_messagebox(Sybase.PowerBuilder.PBString as_id, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBString as_text, Sybase.PowerBuilder.PBIconValue ae_icon, Sybase.PowerBuilder.PBButtonValue ae_button, Sybase.PowerBuilder.PBInt ai_default)
	{
		#line hidden
		#line 53
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(as_title, as_text, ae_icon, ae_button, ai_default);
		#line hidden
	}

	#line 1 "pfc_u_rb.getfocus"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("getfocus")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnsetfocus)]
	public override Sybase.PowerBuilder.PBLong getfocus()
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		if (c__pfcsecurity_admin.GetCurrentApplication().gnv_app.of_getmicrohelp())
		#line hidden
		{
			#line 48
			this.of_getparentwindow_1_232646770(ref lw_parent);
			#line hidden
			#line 49
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_parent)))
			#line hidden
			{
				#line 50
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(lw_parent, "pfc_controlgotfocus", new Sybase.PowerBuilder.PBArgument[1] {new Sybase.PowerBuilder.PBArgument(this, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__pfc_u_rb))}, 0);
				#line hidden
			}
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
	}

	void _init()
	{
		this.GetFocusEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.getfocus);
		this.CreateEvent -= new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent -= new Sybase.PowerBuilder.PBEventHandler(this.destroy);

		OnInitialUpdate();
	}

	public c__pfc_u_rb()
	{
		_init();
	}

}
 