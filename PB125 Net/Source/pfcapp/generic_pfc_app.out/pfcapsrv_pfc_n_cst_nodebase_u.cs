//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_nodebase.sru"
#line hidden
#line 1 "pfc_n_cst_nodebase"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_nodebase",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_nodebase")]
public class c__pfc_n_cst_nodebase : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_prev", null, "pfc_n_cst_nodebase", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_nodebase inv_prev = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_next", null, "pfc_n_cst_nodebase", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_nodebase inv_next = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ia_key", null, "pfc_n_cst_nodebase", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBAny ia_key = Sybase.PowerBuilder.PBAny.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ia_data", null, "pfc_n_cst_nodebase", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBAny ia_data = Sybase.PowerBuilder.PBAny.DefaultValue;

	#line 1 "pfc_n_cst_nodebase.of_getdata(IRA)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdata", new string[]{"ref any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getdata(ref Sybase.PowerBuilder.PBAny aa_data)
	{
		#line hidden
		#line 48
		aa_data = ia_data;
		#line hidden
		#line 49
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_getkey(IRA)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getkey", new string[]{"ref any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getkey(ref Sybase.PowerBuilder.PBAny aa_key)
	{
		#line hidden
		#line 48
		aa_key = ia_key;
		#line hidden
		#line 49
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_setdata(IA)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdata", new string[]{"any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdata(Sybase.PowerBuilder.PBAny aa_data)
	{
		#line hidden
		#line 48
		ia_data = aa_data;
		#line hidden
		#line 49
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_setkey(IA)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setkey", new string[]{"any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setkey(Sybase.PowerBuilder.PBAny aa_key)
	{
		#line hidden
		#line 53
		ia_key = aa_key;
		#line hidden
		#line 54
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_setprev(ICn_cst_nodebase.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setprev", new string[]{"n_cst_nodebase"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setprev(c__n_cst_nodebase anv_node)
	{
		#line hidden
		#line 48
		inv_prev = anv_node;
		#line hidden
		#line 49
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_setnext(ICn_cst_nodebase.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setnext", new string[]{"n_cst_nodebase"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setnext(c__n_cst_nodebase anv_node)
	{
		#line hidden
		#line 48
		inv_next = anv_node;
		#line hidden
		#line 49
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_getnext(IRCn_cst_nodebase.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getnext", new string[]{"ref n_cst_nodebase"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getnext_1_390848009<T0>(ref T0 anv_node) where T0 : c__n_cst_nodebase
	{
		#line hidden
		c__n_cst_nodebase lnv_nil = null;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_nodebase)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_next)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_next)))))
		#line hidden
		{
			#line 52
			anv_node = (T0)(c__n_cst_nodebase)(lnv_nil);
			#line hidden
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		anv_node = (T0)(c__n_cst_nodebase)(inv_next);
		#line hidden
		#line 57
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_getprev(IRCn_cst_nodebase.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getprev", new string[]{"ref n_cst_nodebase"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getprev_1_390848009<T0>(ref T0 anv_node) where T0 : c__n_cst_nodebase
	{
		#line hidden
		c__n_cst_nodebase lnv_nil = null;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_nodebase)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_prev)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_prev)))))
		#line hidden
		{
			#line 52
			anv_node = (T0)(c__n_cst_nodebase)(lnv_nil);
			#line hidden
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		anv_node = (T0)(c__n_cst_nodebase)(inv_prev);
		#line hidden
		#line 57
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_nodebase.of_copyto(IRCn_cst_nodebase.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_copyto", new string[]{"ref n_cst_nodebase"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_copyto_1_390848009<T0>(ref T0 anv_copy) where T0 : c__n_cst_nodebase
	{
		#line hidden
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(c__n_cst_nodebase)((new Sybase.PowerBuilder.PBAny(((c__n_cst_nodebase)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_copy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__n_cst_nodebase)(anv_copy)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		anv_copy.of_setkey(((Sybase.PowerBuilder.PBAny)(ia_key)));
		#line hidden
		#line 56
		anv_copy.of_setdata(((Sybase.PowerBuilder.PBAny)(ia_data)));
		#line hidden
		#line 57
		anv_copy.of_setnext(inv_next);
		#line hidden
		#line 58
		anv_copy.of_setprev(inv_prev);
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

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_nodebase()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_nodebase(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_nodebase vv = new c__pfc_n_cst_nodebase();
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
			return (c__pfc_n_cst_nodebase) v.Value;
		}
	}
}
 