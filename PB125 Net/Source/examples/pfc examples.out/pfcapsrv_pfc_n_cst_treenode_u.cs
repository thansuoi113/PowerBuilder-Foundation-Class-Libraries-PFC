//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_treenode.sru"
#line hidden
#line 1 "pfc_n_cst_treenode"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_treenode",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_treenode")]
public class c__pfc_n_cst_treenode : c__n_cst_nodebase
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_balance", null, "pfc_n_cst_treenode", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBInt ii_balance = Sybase.PowerBuilder.PBInt.DefaultValue;

	#line 1 "pfc_n_cst_treenode.of_getbalance(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getbalance", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getbalance()
	{
		#line hidden
		#line 46
		return ii_balance;
		#line hidden
	}

	#line 1 "pfc_n_cst_treenode.of_setbalance(II)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setbalance", new string[]{"integer"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setbalance(Sybase.PowerBuilder.PBInt ai_balance)
	{
		#line hidden
		#line 47
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_balance))))| ((Sybase.PowerBuilder.PBLong)(ai_balance)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1))))| ((Sybase.PowerBuilder.PBLong)(ai_balance)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 49
		ii_balance = ai_balance;
		#line hidden
		#line 50
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_treenode.of_copyto(IRCn_cst_treenode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_copyto", new string[]{"ref n_cst_treenode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_copyto_1_1535757388<T0>(ref T0 anv_copy) where T0 : c__n_cst_treenode
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(c__n_cst_treenode)((new Sybase.PowerBuilder.PBAny(((c__n_cst_treenode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_copy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__n_cst_treenode)(anv_copy)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 58
		li_rc = base.of_copyto_1_390848009(ref anv_copy);
		#line hidden
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 59
			return li_rc;
			#line hidden
		}
		#line 62
		anv_copy.of_setbalance(ii_balance);
		#line hidden
		#line 64
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

	public c__pfc_n_cst_treenode()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_treenode(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_treenode vv = new c__pfc_n_cst_treenode();
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
			return (c__pfc_n_cst_treenode) v.Value;
		}
	}
}
 