//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_trregistration.sru"
#line hidden
#line 1 "pfc_n_cst_trregistration"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_trregistration",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_trregistration")]
public class c__pfc_n_cst_trregistration : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_count", null, "pfc_n_cst_trregistration", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBInt ii_count = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_trregistrationattrib))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_trans", null, "pfc_n_cst_trregistration", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray inv_trans = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_trregistrationattrib));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_destructordestroy", null, "pfc_n_cst_trregistration", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= TRUE")]
	protected Sybase.PowerBuilder.PBBoolean ib_destructordestroy = new Sybase.PowerBuilder.PBBoolean(true);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_allowsqlcadestroy", null, "pfc_n_cst_trregistration", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= TRUE")]
	protected Sybase.PowerBuilder.PBBoolean ib_allowsqlcadestroy = new Sybase.PowerBuilder.PBBoolean(true);
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_trregistrationattrib))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "istr_trans", null, "pfc_n_cst_trregistration", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray istr_trans = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_trregistrationattrib));

	#line 1 "pfc_n_cst_trregistration.of_getcount(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getcount", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getcount()
	{
		#line hidden
		#line 45
		return ii_count;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_register(ICn_tr.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_register", new string[]{"n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_register(c__n_tr atr_object)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_slotavailable = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_cnt = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_upperbound = new Sybase.PowerBuilder.PBInt(0);
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_tr)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(atr_object)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(atr_object)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 60
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 61
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upperbound;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 63
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object == atr_object))
				#line hidden
				{
					#line 64
					return new Sybase.PowerBuilder.PBInt(0);
					#line hidden
				}
				#line 68
				if (!(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).b_used))
				#line hidden
				{
					#line 69
					if ((Sybase.PowerBuilder.PBBoolean)(li_slotavailable == new Sybase.PowerBuilder.PBInt(0)))
					#line hidden
					{
						#line 71
						li_slotavailable = li_cnt;
						#line hidden
					}
				}
		}
		#line 77
		if ((Sybase.PowerBuilder.PBBoolean)(li_slotavailable == new Sybase.PowerBuilder.PBInt(0)))
		#line hidden
		{
			#line 78
			li_slotavailable = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_upperbound)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
			#line hidden
		}
		#line 82
		((c__n_cst_trregistrationattrib)inv_trans[inv_trans.Extend((Sybase.PowerBuilder.PBLong)(li_slotavailable))]).tr_object = atr_object;
		#line hidden
		#line 83
		((c__n_cst_trregistrationattrib)inv_trans[inv_trans.Extend((Sybase.PowerBuilder.PBLong)(li_slotavailable))]).b_used = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 86
		ii_count++;
		#line hidden
		#line 88
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_unregister(ICn_tr.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_unregister", new string[]{"n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_unregister(c__n_tr atr_obj)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBBoolean lb_found = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_tr)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(atr_obj)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(atr_obj)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 60
		while ( !(lb_found)& ((Sybase.PowerBuilder.PBLong)(li_cnt)<= (Sybase.PowerBuilder.PBLong)(li_upperbound)) )
		#line hidden
		{
				#line 61
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object == atr_obj))
				#line hidden
				{
					#line 63
					((c__n_cst_trregistrationattrib)inv_trans[inv_trans.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).b_used = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
					#line 64
					((c__n_cst_trregistrationattrib)inv_trans[inv_trans.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).tr_object = null;
					#line hidden
					#line 66
					ii_count--;
					#line hidden
					#line 67
					return new Sybase.PowerBuilder.PBInt(1);
					#line hidden
				}
				#line 69
				li_cnt++;
				#line hidden
		}

		#line 73
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_getregistered(IRCn_tr.[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getregistered", new string[]{"ref n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getregistered_1_1438818035([Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_tr))] ref Sybase.PowerBuilder.PBArray atr_obj)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 29
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 30
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upperbound;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 31
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).b_used& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object))))
				#line hidden
				{
					#line 32
					li_count++;
					#line hidden
					#line 33
					atr_obj[atr_obj.Extend((Sybase.PowerBuilder.PBLong)(li_count))] = ((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object;
					#line hidden
				}
		}
		#line 37
		return li_count;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_isregistered(BS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isregistered", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isregistered(Sybase.PowerBuilder.PBString as_name)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_name = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 53
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 54
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upperbound;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 55
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).b_used& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object))))
				#line hidden
				{
					#line 56
					ls_name = ((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object.of_getname();
					#line hidden
					#line 57
					if ((Sybase.PowerBuilder.PBBoolean)(ls_name == as_name))
					#line hidden
					{
						#line 59
						return new Sybase.PowerBuilder.PBBoolean(true);
						#line hidden
					}
				}
		}
		#line 65
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_isregistered(BCn_tr.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isregistered", new string[]{"n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isregistered(c__n_tr atr_obj)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_tr)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(atr_obj)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(atr_obj)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 57
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 58
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upperbound;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 59
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).b_used& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object))))
				#line hidden
				{
					#line 60
					if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object == atr_obj))
					#line hidden
					{
						#line 62
						return new Sybase.PowerBuilder.PBBoolean(true);
						#line hidden
					}
				}
		}
		#line 68
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_getbyname(ISRCn_tr.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getbyname", new string[]{"string", "ref n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getbyname_2_1438818035<T1>(Sybase.PowerBuilder.PBString as_name, ref T1 atr_obj) where T1 : c__n_tr
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_name = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 54
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 55
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upperbound;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 56
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).b_used& Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object))))
				#line hidden
				{
					#line 57
					ls_name = ((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object.of_getname();
					#line hidden
					#line 58
					if ((Sybase.PowerBuilder.PBBoolean)(ls_name == as_name))
					#line hidden
					{
						#line 60
						atr_obj = (T1)(c__n_tr)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_cnt)]).tr_object);
						#line hidden
						#line 61
						return new Sybase.PowerBuilder.PBInt(1);
						#line hidden
					}
				}
		}
		#line 67
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_setdestructordestroy(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setdestructordestroy", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setdestructordestroy(Sybase.PowerBuilder.PBBoolean ab_switch)
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
		ib_destructordestroy = ab_switch;
		#line hidden
		#line 54
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_setallowsqlcadestroy(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setallowsqlcadestroy", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setallowsqlcadestroy(Sybase.PowerBuilder.PBBoolean ab_switch)
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
		ib_allowsqlcadestroy = ab_switch;
		#line hidden
		#line 54
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_isallowsqlcadestroy(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isallowsqlcadestroy", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isallowsqlcadestroy()
	{
		#line hidden
		#line 47
		return ib_allowsqlcadestroy;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_isdestructordestroy(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isdestructordestroy", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isdestructordestroy()
	{
		#line hidden
		#line 47
		return ib_destructordestroy;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_destroy(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_destroy", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_destroy()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_destroycnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_idx = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_tr ltr_object = null;
		#line 56
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_trans)));
		#line hidden
		#line 57
		for (li_idx = new Sybase.PowerBuilder.PBInt(1);li_idx <= li_upper;li_idx = li_idx + 1)
		#line hidden
		{
				#line 58
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_idx)]).tr_object)))
				#line hidden
				{
					#line 59
					if (!(this.of_isallowsqlcadestroy()))
					#line hidden
					{
						#line 60
						if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__peat.GetCurrentApplication().sqlca)))
						#line hidden
						{
							#line 61
							if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_idx)]).tr_object == c__peat.GetCurrentApplication().sqlca))
							#line hidden
							{
								#line 63
								continue;
								#line hidden
							}
						}
					}
					#line 68
					ltr_object = ((c__n_cst_trregistrationattrib)inv_trans[(Sybase.PowerBuilder.PBLong)(li_idx)]).tr_object;
					#line hidden
					#line 69
					this.of_unregister(ltr_object);
					#line hidden
					#line 70
					Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(ltr_object);
					#line hidden
					#line 71
					li_destroycnt++;
					#line hidden
				}
		}
		#line 75
		return li_destroycnt;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.of_unregister(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_unregister", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_unregister()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_registedcnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBArray lnv_trans = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_trregistrationattrib));
		#line 53
		li_registedcnt = this.of_getcount();
		#line hidden
		#line 56
		inv_trans.AssignFrom((Sybase.PowerBuilder.PBArray)lnv_trans);
		#line hidden
		#line 57
		ii_count = new Sybase.PowerBuilder.PBInt(0);
		#line hidden
		#line 59
		return li_registedcnt;
		#line hidden
	}

	#line 1 "pfc_n_cst_trregistration.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 41
		if (this.of_isdestructordestroy())
		#line hidden
		{
			#line 42
			this.of_destroy();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
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
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_trregistration()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_trregistration(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_trregistration vv = new c__pfc_n_cst_trregistration();
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
			return (c__pfc_n_cst_trregistration) v.Value;
		}
	}
}
 