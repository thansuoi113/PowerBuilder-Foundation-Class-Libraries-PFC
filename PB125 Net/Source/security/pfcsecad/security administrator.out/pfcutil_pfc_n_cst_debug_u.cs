//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx\\pfc_n_cst_debug.sru"
#line hidden
#line 1 "pfc_n_cst_debug"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_debug",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_debug")]
public class c__pfc_n_cst_debug : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_major", null, "pfc_n_cst_debug", 12, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 12")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt pfc_major = new Sybase.PowerBuilder.PBInt(12);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_minor", null, "pfc_n_cst_debug", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 0")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt pfc_minor = new Sybase.PowerBuilder.PBInt(0);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_fixes", null, "pfc_n_cst_debug", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 0")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt pfc_fixes = new Sybase.PowerBuilder.PBInt(0);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_name", null, "pfc_n_cst_debug", "PowerBuilder Foundation Classes", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Public, "= \"PowerBuilder Foundation Classes\"")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBString pfc_name = new Sybase.PowerBuilder.PBString("PowerBuilder Foundation Classes");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_build_date", null, "pfc_n_cst_debug", null, null, Sybase.PowerBuilder.PBModifier.Public, "= Today ( )")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBDate pfc_build_date = Sybase.PowerBuilder.WPF.PBSystemFunctions.Today();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "pfc_build_time", null, "pfc_n_cst_debug", null, null, Sybase.PowerBuilder.PBModifier.Public, "= Now ( )")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBTime pfc_build_time = Sybase.PowerBuilder.WPF.PBSystemFunctions.Now();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ids_debuglog", null, "pfc_n_cst_debug", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_ds ids_debuglog = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_sqlspy", null, "pfc_n_cst_debug", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_cst_sqlspy inv_sqlspy = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_alwaysontop", null, "pfc_n_cst_debug", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_alwaysontop = new Sybase.PowerBuilder.PBBoolean(false);

	#line 1 "pfc_n_cst_debug.of_setsqlspy(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setsqlspy", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setsqlspy(Sybase.PowerBuilder.PBBoolean ab_switch)
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
		#line 53
		if (ab_switch)
		#line hidden
		{
			#line 54
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_sqlspy)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_sqlspy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_sqlspy)))))
			#line hidden
			{
				#line 55
				inv_sqlspy = (c__n_cst_sqlspy)this.CreateInstance(typeof(c__n_cst_sqlspy), 0);
				#line hidden
				#line 56
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		else
		{
			#line 59
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_sqlspy)))
			#line hidden
			{
				#line 60
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(inv_sqlspy);
				#line hidden
				#line 61
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		#line 65
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_message(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_message", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_message(Sybase.PowerBuilder.PBString as_message)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_visible = new Sybase.PowerBuilder.PBBoolean(false);
		#line 52
		lb_visible = Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog));
		#line hidden
		#line 55
		if (lb_visible)
		#line hidden
		{
			#line 55
			c__pfcsecurity_admin.GetCurrentApplication().w_debuglog.of_dwsetredraw(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
		}
		#line 58
		ll_row = ids_debuglog.InsertRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(ll_row> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 60
			((Sybase.PowerBuilder.PBExtObject)ids_debuglog.Object)[
				#line 60
				new Sybase.PowerBuilder.PBString(@"msg"), 
				#line 60
				new Sybase.PowerBuilder.PBUInt(1), 
				#line 60
				new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(ll_row)}) 
			#line 60
			] = (Sybase.PowerBuilder.PBAny)(as_message);
			#line hidden
			#line 63
			if (lb_visible)
			#line hidden
			{
				#line 63
				c__pfcsecurity_admin.GetCurrentApplication().w_debuglog.of_dwscrolltorow(ll_row);
				#line hidden
			}
		}
		#line 66
		if (lb_visible)
		#line hidden
		{
			#line 66
			c__pfcsecurity_admin.GetCurrentApplication().w_debuglog.of_dwsetredraw(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)(ll_row> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 69
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 72
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_clearlog(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_clearlog", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_clearlog()
	{
		#line hidden
		#line 45
		return ids_debuglog.Reset();
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_openlog(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_openlog", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_openlog(Sybase.PowerBuilder.PBBoolean ab_switch)
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
		#line 53
		if (ab_switch)
		#line hidden
		{
			#line 54
			return Sybase.PowerBuilder.WPF.PBSystemFunctions.Open(ref c__pfcsecurity_admin.GetCurrentApplication().w_debuglog);
			#line hidden
		}
		else
		{
			#line 56
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog)))
			#line hidden
			{
				#line 57
				return Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog));
				#line hidden
			}
		}
		#line 61
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_printlog(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_printlog", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_printlog()
	{
		#line hidden
		#line 46
		return ids_debuglog.Print();
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_setalwaysontop(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setalwaysontop", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setalwaysontop(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 48
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		ib_alwaysontop = ab_switch;
		#line hidden
		#line 54
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog)))
		#line hidden
		{
			#line 55
			c__pfcsecurity_admin.GetCurrentApplication().w_debuglog.of_setalwaysontop(ib_alwaysontop);
			#line hidden
		}
		#line 58
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_getalwaysontop(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getalwaysontop", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getalwaysontop()
	{
		#line hidden
		#line 44
		return ib_alwaysontop;
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_setdwproperty(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdwproperty", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdwproperty(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		c__u_dw ldw_obj = null;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 53
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		ldw_obj = (c__u_dw)this.CreateInstance(typeof(c__u_dw));
		#line hidden
		#line 56
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ldw_obj)))
		#line hidden
		{
			#line 57
			li_rc = ldw_obj.of_setsharedproperty(ab_switch);
			#line hidden
			#line 58
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(ldw_obj);
			#line hidden
			#line 59
			return li_rc;
			#line hidden
		}
		#line 62
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_islogopen(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_islogopen", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_islogopen()
	{
		#line hidden
		#line 45
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog));
		#line hidden
	}

	#line 1 "pfc_n_cst_debug.of_isdwproperty(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isdwproperty", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isdwproperty()
	{
		#line hidden
		c__u_dw ldw_obj = null;
		Sybase.PowerBuilder.PBBoolean lb_rc = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 48
		ldw_obj = (c__u_dw)this.CreateInstance(typeof(c__u_dw));
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ldw_obj)))
		#line hidden
		{
			#line 50
			lb_rc = ldw_obj.of_issharedproperty();
			#line hidden
			#line 51
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(ldw_obj);
			#line hidden
			#line 52
			return lb_rc;
			#line hidden
		}
		#line 55
		return new Sybase.PowerBuilder.PBBoolean(false);
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

	#line 1 "pfc_n_cst_debug.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 44
		ids_debuglog = (c__n_ds)this.CreateInstance(typeof(c__n_ds), 0);
		#line hidden
		#line 45
		ids_debuglog.DataObject = new Sybase.PowerBuilder.PBString("d_debuglog");
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_n_cst_debug.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcsecurity_admin.GetCurrentApplication().w_debuglog)))
		#line hidden
		{
			#line 47
			this.of_openlog(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
		}
		#line 51
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ids_debuglog)))
		#line hidden
		{
			#line 52
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(ids_debuglog);
			#line hidden
		}
		#line 56
		this.of_setsqlspy(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 59
		this.of_setdwproperty(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
	}

	public c__pfc_n_cst_debug()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_debug(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_debug vv = new c__pfc_n_cst_debug();
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
			return (c__pfc_n_cst_debug) v.Value;
		}
	}
}
 