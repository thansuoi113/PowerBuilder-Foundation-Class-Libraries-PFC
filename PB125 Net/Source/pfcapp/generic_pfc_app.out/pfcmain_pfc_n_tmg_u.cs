//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfcmain.pbl\\pfcmain.pblx\\pfc_n_tmg.sru"
#line hidden
#line 1 "pfc_n_tmg"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_tmg",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcapp\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_tmg")]
public class c__pfc_n_tmg : Sybase.PowerBuilder.WPF.PBTiming
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_single", null, "pfc_n_tmg", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_cst_tmgsingle inv_single = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_multiple", null, "pfc_n_tmg", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_cst_tmgmultiple inv_multiple = null;

	#line 1 "pfc_n_tmg.of_setmultiple(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setmultiple", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setmultiple(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(ab_switch& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_single))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if (ab_switch)
		#line hidden
		{
			#line 57
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_tmgmultiple)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_multiple)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_multiple)))))
			#line hidden
			{
				#line 58
				inv_multiple = (c__n_cst_tmgmultiple)this.CreateInstance(typeof(c__n_cst_tmgmultiple), 0);
				#line hidden
				#line 59
				inv_multiple.of_setrequestor((c__n_tmg)(((c__pfc_n_tmg)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this)))));
				#line hidden
				#line 60
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		else
		{
			#line 63
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_multiple)))
			#line hidden
			{
				#line 64
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(inv_multiple);
				#line hidden
				#line 65
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		#line 69
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_tmg.of_setsingle(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setsingle", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setsingle(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(ab_switch& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_multiple))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if (ab_switch)
		#line hidden
		{
			#line 57
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_tmgsingle)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_single)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_single)))))
			#line hidden
			{
				#line 58
				inv_single = (c__n_cst_tmgsingle)this.CreateInstance(typeof(c__n_cst_tmgsingle), 0);
				#line hidden
				#line 59
				inv_single.of_setrequestor((c__n_tmg)(((c__pfc_n_tmg)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this)))));
				#line hidden
				#line 60
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		else
		{
			#line 63
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_single)))
			#line hidden
			{
				#line 64
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(inv_single);
				#line hidden
				#line 65
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		#line 69
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
		base.destroy();
		#line hidden
		#line hidden
		this.TriggerEvent(new Sybase.PowerBuilder.PBString("destructor"));
		#line hidden
	}

	#line 1 "pfc_n_tmg.timer"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("timer")]
	public override void timer()
	{
		#line hidden
		#line 43
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_single)))
		#line hidden
		{
			#line 44
			inv_single.pfc_timer();
			#line hidden
		}
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_multiple)))
		#line hidden
		{
			#line 48
			inv_multiple.pfc_timer();
			#line hidden
		}
	}

	#line 1 "pfc_n_tmg.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 40
		this.of_setsingle(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 41
		this.of_setmultiple(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.TimerEvent += new Sybase.PowerBuilder.PBEventHandler(this.timer);
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
	}

	public c__pfc_n_tmg()
	{
		_init();
	}


	public static explicit operator c__pfc_n_tmg(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_tmg vv = new c__pfc_n_tmg();
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
			return (c__pfc_n_tmg) v.Value;
		}
	}
}
 