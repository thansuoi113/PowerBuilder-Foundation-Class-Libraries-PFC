//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexmfe.pbl\\appexmfe.pblx\\u_cb_sqlspy.sru"
#line hidden
#line 1 "u_cb_sqlspy"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_cb_sqlspy",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexmfe.pbl\\appexmfe.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_cb_sqlspy")]
public class c__u_cb_sqlspy : c__u_cb
{
	#line hidden

	#line 1 "u_cb_sqlspy.clicked"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("clicked")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
	public override Sybase.PowerBuilder.PBLong clicked()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_return = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 23
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_debug)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))
		#line hidden
		{
			#line 24
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.of_setdebug(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		#line 27
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 27
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 29
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_sqlspy)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))
		#line hidden
		{
			#line 32
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setsqlspy(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 33
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 33
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
				#line hidden
			}
		}
		#line 37
		li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_opensqlspy(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 39
		return (Sybase.PowerBuilder.PBLong)(li_return);
		#line hidden
	}

	void _init()
	{
		this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

		OnInitialUpdate();
	}

	public c__u_cb_sqlspy()
	{
		_init();
	}

}
 