//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_list.sru"
#line hidden
#line 1 "pfc_n_cst_list"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_list",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_list")]
public class c__pfc_n_cst_list : c__n_cst_linkedlistbase
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_duplicatesallowed", null, "pfc_n_cst_list", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= True")]
	protected Sybase.PowerBuilder.PBBoolean ib_duplicatesallowed = new Sybase.PowerBuilder.PBBoolean(true);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_sorted", null, "pfc_n_cst_list", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_sorted = new Sybase.PowerBuilder.PBBoolean(false);

	#line 1 "pfc_n_cst_list.of_setduplicatesallowed(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setduplicatesallowed", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setduplicatesallowed(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 52
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(ib_duplicatesallowed == ab_switch))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 61
		if (this.of_isempty())
		#line hidden
		{
			#line 62
			ib_duplicatesallowed = ab_switch;
			#line hidden
			#line 63
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 66
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_isduplicatesallowed(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isduplicatesallowed", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isduplicatesallowed()
	{
		#line hidden
		#line 48
		return ib_duplicatesallowed;
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_setsorted(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setsorted", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setsorted(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 52
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(ib_sorted == ab_switch))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 61
		if (this.of_isempty())
		#line hidden
		{
			#line 62
			ib_sorted = ab_switch;
			#line hidden
			#line 63
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 66
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_issorted(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_issorted", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_issorted()
	{
		#line hidden
		#line 48
		return ib_sorted;
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_find(IRCn_cst_linkedlistnode.Cn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_find", new string[]{"ref n_cst_linkedlistnode", "n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_find_2_441479535<T0>(ref T0 anv_returningnode, c__n_cst_linkedlistnode anv_keynode) where T0 : c__n_cst_linkedlistnode
	{
		#line hidden
		c__n_cst_linkedlistnode lnv_startnode = null;
		#line 53
		return this.of_find_3_441479535(ref anv_returningnode, anv_keynode, lnv_startnode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_find(IRCn_cst_linkedlistnode.Cn_cst_linkedlistnode.Cn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_find", new string[]{"ref n_cst_linkedlistnode", "n_cst_linkedlistnode", "n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_find_3_441479535<T0>(ref T0 anv_returningnode, c__n_cst_linkedlistnode anv_keynode, c__n_cst_linkedlistnode anv_startnode) where T0 : c__n_cst_linkedlistnode
	{
		#line hidden
		Sybase.PowerBuilder.PBInt found = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt not_found = new Sybase.PowerBuilder.PBInt(0);
		c__n_cst_linkedlistnode lnv_node = null;
		c__n_cst_linkedlistnode lnv_nonvalid = null;
		#line 64
		anv_returningnode = (T0)(c__n_cst_linkedlistnode)(lnv_nonvalid);
		#line hidden
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_keynode)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_keynode)))))
		#line hidden
		{
			#line 68
			return failure;
			#line hidden
		}
		#line 71
		if (this.of_isempty())
		#line hidden
		{
			#line 72
			return not_found;
			#line hidden
		}
		#line 76
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_head)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_head)))))
		#line hidden
		{
			#line 76
			return failure;
			#line hidden
		}
		#line 79
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_startnode)))
		#line hidden
		{
			#line 81
			anv_startnode.of_getnext_1_390848009(ref lnv_node);
			#line hidden
		}
		else
		{
			#line 83
			lnv_node = inv_head;
			#line hidden
		}
		#line 87
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnodecompare)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_compare)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_compare)))))
		#line hidden
		{
			#line 88
			inv_compare = (c__n_cst_linkedlistnodecompare)this.CreateInstance(typeof(c__n_cst_linkedlistnodecompare), 0);
			#line hidden
		}
		#line 92
		while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lnv_node)) )
		#line hidden
		{
				#line 93
				Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = inv_compare.of_compare((c__n_cst_nodebase)(anv_keynode), (c__n_cst_nodebase)(lnv_node));
				#line hidden
				#line 94
				if (__PB_TEMP______switchTmpVar0 == c__n_cst_linkedlistnodecompare.equal )
				#line hidden
				{
					#line 96
					anv_returningnode = (T0)(c__n_cst_linkedlistnode)(lnv_node);
					#line hidden
					#line 97
					return found;
					#line hidden
				}
				#line 98
				else if (__PB_TEMP______switchTmpVar0 == c__n_cst_linkedlistnodecompare.lessthan )
				#line hidden
				{
					#line 100
					if (ib_sorted)
					#line hidden
					{
						#line 102
						return not_found;
						#line hidden
					}
					else
					{
					}
				}
				#line 106
				else if (__PB_TEMP______switchTmpVar0 == c__n_cst_linkedlistnodecompare.greaterthan )
				#line hidden
				{
				}

				#line 110
				lnv_node.of_getnext_1_390848009(ref lnv_node);
				#line hidden
		}

		#line 113
		return not_found;
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_removetail(IRCn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_removetail", new string[]{"ref n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_removetail_1_441479535<T0>(ref T0 anv_tailnode)
	{
		#line hidden
		#line 48
		return base.of_removetail_1_441479535(ref anv_tailnode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_removehead(IRCn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_removehead", new string[]{"ref n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_removehead_1_441479535<T0>(ref T0 anv_headnode)
	{
		#line hidden
		#line 48
		return base.of_removehead_1_441479535(ref anv_headnode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_remove(IRCn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_remove", new string[]{"ref n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_remove_1_441479535<T0>(ref T0 anv_removenode)
	{
		#line hidden
		#line 49
		return base.of_remove_1_441479535(ref anv_removenode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_addhead(ICn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_addhead", new string[]{"n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_addhead(c__n_cst_linkedlistnode anv_newheadnode)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_cst_linkedlistnode lnv_locatenode = null;
		#line 56
		if (ib_sorted)
		#line hidden
		{
			#line 56
			return failure;
			#line hidden
		}
		#line 59
		if (!(ib_duplicatesallowed))
		#line hidden
		{
			#line 60
			if (this.of_isinlist(anv_newheadnode))
			#line hidden
			{
				#line 62
				return failure;
				#line hidden
			}
		}
		#line 66
		return base.of_addhead(anv_newheadnode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_addtail(ICn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_addtail", new string[]{"n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_addtail(c__n_cst_linkedlistnode anv_newtailnode)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_cst_linkedlistnode lnv_locatenode = null;
		#line 56
		if (ib_sorted)
		#line hidden
		{
			#line 56
			return failure;
			#line hidden
		}
		#line 59
		if (!(ib_duplicatesallowed))
		#line hidden
		{
			#line 60
			if (this.of_isinlist(anv_newtailnode))
			#line hidden
			{
				#line 62
				return failure;
				#line hidden
			}
		}
		#line 66
		return base.of_addtail(anv_newtailnode);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_isinlist(BCn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isinlist", new string[]{"n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isinlist(c__n_cst_linkedlistnode anv_node)
	{
		#line hidden
		c__n_cst_linkedlistnode lnv_locatenode = null;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_node)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_node)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnodecompare)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_compare)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_compare)))))
		#line hidden
		{
			#line 55
			inv_compare = (c__n_cst_linkedlistnodecompare)this.CreateInstance(typeof(c__n_cst_linkedlistnodecompare), 0);
			#line hidden
		}
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)(this.of_find_2_441479535(ref lnv_locatenode, anv_node) == new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 60
			return new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 63
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_list.of_add(ICn_cst_linkedlistnode.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_add", new string[]{"n_cst_linkedlistnode"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_add(c__n_cst_linkedlistnode anv_newnode)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_cst_linkedlistnode lnv_locatenode = null;
		c__n_cst_linkedlistnode lnv_insertpointnode = null;
		c__n_cst_linkedlistnode lnv_temp = null;
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_newnode)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_newnode)))))
		#line hidden
		{
			#line 58
			return failure;
			#line hidden
		}
		#line 62
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_head)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_head)))))
		#line hidden
		{
			#line 64
			return base.of_addhead(anv_newnode);
			#line hidden
		}
		#line 68
		if (!(ib_duplicatesallowed))
		#line hidden
		{
			#line 69
			if (this.of_isinlist(anv_newnode))
			#line hidden
			{
				#line 71
				return failure;
				#line hidden
			}
		}
		#line 76
		if (!(ib_sorted))
		#line hidden
		{
			#line 78
			return base.of_addtail(anv_newnode);
			#line hidden
		}
		#line 84
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_head)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_head)))))
		#line hidden
		{
			#line 84
			return failure;
			#line hidden
		}
		#line 85
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnode)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_tail)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_tail)))))
		#line hidden
		{
			#line 85
			return failure;
			#line hidden
		}
		#line 88
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_linkedlistnodecompare)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_compare)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_compare)))))
		#line hidden
		{
			#line 89
			inv_compare = (c__n_cst_linkedlistnodecompare)this.CreateInstance(typeof(c__n_cst_linkedlistnodecompare), 0);
			#line hidden
		}
		#line 93
		li_rc = inv_compare.of_compare((c__n_cst_nodebase)(anv_newnode), (c__n_cst_nodebase)(inv_head));
		#line hidden
		#line 94
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == c__n_cst_linkedlistnodecompare.failure))
		#line hidden
		{
			#line 94
			return failure;
			#line hidden
		}
		#line 95
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == c__n_cst_linkedlistnodecompare.lessthan))
		#line hidden
		{
			#line 97
			return base.of_addhead(anv_newnode);
			#line hidden
		}
		#line 101
		li_rc = inv_compare.of_compare((c__n_cst_nodebase)(anv_newnode), (c__n_cst_nodebase)(inv_tail));
		#line hidden
		#line 102
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == c__n_cst_linkedlistnodecompare.failure))
		#line hidden
		{
			#line 102
			return failure;
			#line hidden
		}
		#line 103
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == c__n_cst_linkedlistnodecompare.greaterthan))
		#line hidden
		{
			#line 105
			return base.of_addtail(anv_newnode);
			#line hidden
		}
		#line 111
		lnv_insertpointnode = inv_head;
		#line hidden
		#line 113
		lnv_insertpointnode.of_getnext_1_390848009(ref lnv_temp);
		#line hidden
		#line 114
		while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lnv_temp)) )
		#line hidden
		{
				#line 115
				li_rc = inv_compare.of_compare((c__n_cst_nodebase)(lnv_temp), (c__n_cst_nodebase)(anv_newnode));
				#line hidden
				#line 116
				Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar1 = li_rc;
				#line hidden
				#line 117
				if (__PB_TEMP______switchTmpVar1 == c__n_cst_linkedlistnodecompare.equal )
				#line hidden
				{
					#line 119
					lnv_insertpointnode = lnv_temp;
					#line hidden
				}
				#line 120
				else if (__PB_TEMP______switchTmpVar1 == c__n_cst_linkedlistnodecompare.lessthan )
				#line hidden
				{
					#line 122
					lnv_insertpointnode = lnv_temp;
					#line hidden
				}
				#line 123
				else if (__PB_TEMP______switchTmpVar1 == c__n_cst_linkedlistnodecompare.greaterthan )
				#line hidden
				{
					#line 125
					break;
					#line hidden
				}
				else 
				{
					#line 127
					return failure;
					#line hidden
				}

				#line 129
				lnv_temp.of_getnext_1_390848009(ref lnv_temp);
				#line hidden
		}

		#line 132
		return this.of_add(anv_newnode, lnv_insertpointnode);
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
		c__pfc_n_cst_list vv = (c__pfc_n_cst_list)base.Clone();
 		vv.ib_duplicatesallowed = ib_duplicatesallowed;
		vv.ib_sorted = ib_sorted;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_list()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_list(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_list vv = new c__pfc_n_cst_list();
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
			return (c__pfc_n_cst_list) v.Value;
		}
	}
}
 