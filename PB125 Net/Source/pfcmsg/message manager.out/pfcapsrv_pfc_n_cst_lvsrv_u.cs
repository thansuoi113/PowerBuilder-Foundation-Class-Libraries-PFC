//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_lvsrv.sru"
#line hidden
#line 1 "pfc_n_cst_lvsrv"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_lvsrv",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_lvsrv")]
public class c__pfc_n_cst_lvsrv : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_delimiter", null, "pfc_n_cst_lvsrv", ";", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \";\"")]
	protected Sybase.PowerBuilder.PBString is_delimiter = new Sybase.PowerBuilder.PBString(";");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_displayitem", null, "pfc_n_cst_lvsrv", "this item", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \"this item\"")]
	protected Sybase.PowerBuilder.PBString is_displayitem = new Sybase.PowerBuilder.PBString("this item");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_displayunits", null, "pfc_n_cst_lvsrv", "items", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \"items\"")]
	protected Sybase.PowerBuilder.PBString is_displayunits = new Sybase.PowerBuilder.PBString("items");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ilv_requestor", null, "pfc_n_cst_lvsrv", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_lvs ilv_requestor = null;

	#line 1 "pfc_n_cst_lvsrv.of_setrequestor(ICu_lvs.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"u_lvs"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrequestor(c__u_lvs alv_requestor)
	{
		#line hidden
		#line 46
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_lvs)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(alv_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(alv_requestor)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		ilv_requestor = alv_requestor;
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_setdisplayitem(IS)"
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

	#line 1 "pfc_n_cst_lvsrv.of_getdisplayitem(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdisplayitem", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdisplayitem()
	{
		#line hidden
		#line 45
		return is_displayitem;
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_getdisplayunits(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdisplayunits", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdisplayunits()
	{
		#line hidden
		#line 45
		return is_displayunits;
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_setdisplayunits(IS)"
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

	#line 1 "pfc_n_cst_lvsrv.of_findnext(IICdirection.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_findnext", new string[]{"integer", "direction"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_findnext(Sybase.PowerBuilder.PBInt ai_index, Sybase.PowerBuilder.PBDirectionValue ad_direction)
	{
		#line hidden
		#line 51
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_index))))| ((Sybase.PowerBuilder.PBLong)(ai_index)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		return ilv_requestor.FindItem(ai_index, ad_direction, new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_findselected(IICdirection.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_findselected", new string[]{"integer", "direction"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_findselected(Sybase.PowerBuilder.PBInt ai_index, Sybase.PowerBuilder.PBDirectionValue ad_direction)
	{
		#line hidden
		#line 51
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ilv_requestor))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_index))))| ((Sybase.PowerBuilder.PBLong)(ai_index)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		return ilv_requestor.FindItem(ai_index, ad_direction, new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_getdelimiter(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getdelimiter", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getdelimiter()
	{
		#line hidden
		#line 46
		return is_delimiter;
		#line hidden
	}

	#line 1 "pfc_n_cst_lvsrv.of_setdelimiter(IS)"
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

	public c__pfc_n_cst_lvsrv()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_lvsrv(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_lvsrv vv = new c__pfc_n_cst_lvsrv();
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
			return (c__pfc_n_cst_lvsrv) v.Value;
		}
	}
}
 