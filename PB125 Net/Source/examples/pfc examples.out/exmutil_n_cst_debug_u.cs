//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\exmutil.pbl\\exmutil.pblx\\n_cst_debug.sru"
#line hidden
#line 1 "n_cst_debug"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("n_cst_debug",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\exmutil.pbl\\exmutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="n_cst_debug")]
public class c__n_cst_debug : c__pfc_n_cst_debug
{
	#line hidden

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

	#line 1 "n_cst_debug.constructor"
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
		#line 12
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().w_examplemain)))
		#line hidden
		{
			#line 13
			c__pfcexamp.GetCurrentApplication().w_examplemain.ue_notify(new Sybase.PowerBuilder.PBString("debugsrv"), new Sybase.PowerBuilder.PBString("open"));
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "n_cst_debug.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.destructor();
		#line hidden
		#line 12
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().w_examplemain)))
		#line hidden
		{
			#line 13
			c__pfcexamp.GetCurrentApplication().w_examplemain.ue_notify(new Sybase.PowerBuilder.PBString("debugsrv"), new Sybase.PowerBuilder.PBString("close"));
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
	}

	public c__n_cst_debug()
	{
		_init();
	}


	public static explicit operator c__n_cst_debug(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__n_cst_debug vv = new c__n_cst_debug();
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
			return (c__n_cst_debug) v.Value;
		}
	}
}
 