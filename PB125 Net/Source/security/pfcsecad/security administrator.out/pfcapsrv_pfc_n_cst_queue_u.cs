//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_queue.sru"
#line hidden
#line 1 "pfc_n_cst_queue"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_queue",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_queue")]
public class c__pfc_n_cst_queue : c__n_cst_linkedlistbase
{
	#line hidden

	#line 1 "pfc_n_cst_queue.of_put(ICn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_put", new string[]{"n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_put(c__n_cst_linkedlistnode anv_node)
	{
		#line hidden
		#line 47
		return this.of_addtail(anv_node);
		#line hidden
	}

	#line 1 "pfc_n_cst_queue.of_get(IRCn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_get", new string[]{"ref n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_get_1_441479535<T0>(ref T0 anv_node) where T0 : c__n_cst_linkedlistnode
	{
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_head)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_head)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		anv_node = (T0)(c__n_cst_linkedlistnode)(inv_head);
		#line hidden
		#line 57
		return this.of_remove_1_441479535(ref anv_node);
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
		c__pfc_n_cst_queue vv = (c__pfc_n_cst_queue)base.Clone();
 		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_queue()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_queue(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_queue vv = new c__pfc_n_cst_queue();
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
			return (c__pfc_n_cst_queue) v.Value;
		}
	}
}
 