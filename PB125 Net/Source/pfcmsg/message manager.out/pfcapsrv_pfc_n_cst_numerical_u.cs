//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_numerical.sru"
#line hidden
#line 1 "pfc_n_cst_numerical"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_numerical",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_numerical")]
public class c__pfc_n_cst_numerical : c__n_base
{
	#line hidden

	#line 1 "pfc_n_cst_numerical.of_getbit(BLN)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getbit", new string[]{"long", "unsignedinteger"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getbit(Sybase.PowerBuilder.PBLong al_decimal, Sybase.PowerBuilder.PBUInt ai_bit)
	{
		#line hidden
		Sybase.PowerBuilder.PBBoolean lb_null = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_decimal))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_bit))))))
		#line hidden
		{
			#line 56
			lb_null.SetNull();
			#line hidden
			#line 57
			return lb_null;
			#line hidden
		}
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Int(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mod((Sybase.PowerBuilder.PBDouble)(al_decimal)/ (Sybase.PowerBuilder.PBDouble)((Sybase.PowerBuilder.PBSystemFunctions.Pow((Sybase.PowerBuilder.PBDouble)new Sybase.PowerBuilder.PBInt(2), (Sybase.PowerBuilder.PBDouble)((Sybase.PowerBuilder.PBDouble)(ai_bit)- (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(1)))))), (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2)))))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 64
			return new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 67
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_binary(SL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_binary", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_binary(Sybase.PowerBuilder.PBLong al_decimal)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_remainder = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_binary = new Sybase.PowerBuilder.PBString("");
		Sybase.PowerBuilder.PBString ls_null = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_decimal))))| (al_decimal< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 54
			ls_null.SetNull();
			#line hidden
			#line 55
			return ls_null;
			#line hidden
		}
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)(al_decimal == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 59
			return new Sybase.PowerBuilder.PBString("0");
			#line hidden
		}
		#line 62
		while  (!( al_decimal == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) ))
		#line hidden
		{
				#line 63
				li_remainder = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mod((Sybase.PowerBuilder.PBDouble)(al_decimal), (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2))));
				#line hidden
				#line 64
				al_decimal = (Sybase.PowerBuilder.PBLong)((Sybase.PowerBuilder.PBDouble)(al_decimal)/ (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2)));
				#line hidden
				#line 67
				ls_binary = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_remainder))))+ ls_binary;
				#line hidden
		}

		#line 69
		return ls_binary;
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_decimal(LS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_decimal", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_decimal(Sybase.PowerBuilder.PBString as_binary)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_len = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray lch_char = new Sybase.PowerBuilder.PBUnboundedCharArray();
		Sybase.PowerBuilder.PBLong ll_decimal = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		Sybase.PowerBuilder.PBLong ll_null = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_binary))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_binary)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 57
			ll_null.SetNull();
			#line hidden
			#line 58
			return ll_null;
			#line hidden
		}
		#line 62
		ll_len = Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_binary);
		#line hidden
		#line 65
		lch_char.AssignFrom(as_binary);
		#line hidden
		#line 67
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= ((Sybase.PowerBuilder.PBInt)(ll_len));li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 69
				if ((Sybase.PowerBuilder.PBBoolean)(!((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)(((Sybase.PowerBuilder.PBChar)lch_char[(Sybase.PowerBuilder.PBLong)(li_cnt)])) == new Sybase.PowerBuilder.PBString("1"))))& !((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)(((Sybase.PowerBuilder.PBChar)lch_char[(Sybase.PowerBuilder.PBLong)(li_cnt)])) == new Sybase.PowerBuilder.PBString("0"))))))
				#line hidden
				{
					#line 70
					return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
					#line hidden
				}
				#line 73
				ll_decimal = ll_decimal+ (Sybase.PowerBuilder.WPF.PBSystemFunctions.Long((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBChar)lch_char[(Sybase.PowerBuilder.PBLong)(li_cnt)])))))* ((Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.PBSystemFunctions.Pow((Sybase.PowerBuilder.PBDouble)new Sybase.PowerBuilder.PBInt(2), (Sybase.PowerBuilder.PBDouble)(ll_len- (Sybase.PowerBuilder.PBLong)(li_cnt))))));
				#line hidden
		}
		#line 76
		return ll_decimal;
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_bitwiseand(LLL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_bitwiseand", new string[]{"long", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_bitwiseand(Sybase.PowerBuilder.PBLong al_value1, Sybase.PowerBuilder.PBLong al_value2)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_result = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray lb_value1 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		Sybase.PowerBuilder.PBArray lb_value2 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value1))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value2))))))
		#line hidden
		{
			#line 56
			ll_result.SetNull();
			#line hidden
			#line 57
			return ll_result;
			#line hidden
		}
		#line 61
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 62
				lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value1, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
				#line 63
				lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value2, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
		}
		#line 67
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 68
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBBoolean)lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)])& ((Sybase.PowerBuilder.PBBoolean)lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)])))
				#line hidden
				{
					#line 69
					ll_result = ll_result+ ((Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.PBSystemFunctions.Pow((Sybase.PowerBuilder.PBDouble)new Sybase.PowerBuilder.PBInt(2), (Sybase.PowerBuilder.PBDouble)((Sybase.PowerBuilder.PBLong)(li_cnt)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))));
					#line hidden
				}
		}
		#line 73
		return ll_result;
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_bitwiseor(LLL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_bitwiseor", new string[]{"long", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_bitwiseor(Sybase.PowerBuilder.PBLong al_value1, Sybase.PowerBuilder.PBLong al_value2)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_result = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray lb_value1 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		Sybase.PowerBuilder.PBArray lb_value2 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value1))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value2))))))
		#line hidden
		{
			#line 56
			ll_result.SetNull();
			#line hidden
			#line 57
			return ll_result;
			#line hidden
		}
		#line 61
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 62
				lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value1, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
				#line 63
				lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value2, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
		}
		#line 67
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 68
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBBoolean)lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)])| ((Sybase.PowerBuilder.PBBoolean)lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)])))
				#line hidden
				{
					#line 69
					ll_result = ll_result+ ((Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.PBSystemFunctions.Pow((Sybase.PowerBuilder.PBDouble)new Sybase.PowerBuilder.PBInt(2), (Sybase.PowerBuilder.PBDouble)((Sybase.PowerBuilder.PBLong)(li_cnt)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))));
					#line hidden
				}
		}
		#line 73
		return ll_result;
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_bitwisexor(LLL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_bitwisexor", new string[]{"long", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_bitwisexor(Sybase.PowerBuilder.PBLong al_value1, Sybase.PowerBuilder.PBLong al_value2)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_result = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray lb_value1 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		Sybase.PowerBuilder.PBArray lb_value2 = new Sybase.PowerBuilder.PBBoundedBooleanArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,32}, false));
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value1))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value2))))))
		#line hidden
		{
			#line 56
			ll_result.SetNull();
			#line hidden
			#line 57
			return ll_result;
			#line hidden
		}
		#line 61
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 62
				lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value1, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
				#line 63
				lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)] = this.of_getbit(al_value2, (Sybase.PowerBuilder.PBUInt)(li_cnt));
				#line hidden
		}
		#line 67
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= new Sybase.PowerBuilder.PBInt(32);li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 68
				if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBBoolean)lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)])& !(((Sybase.PowerBuilder.PBBoolean)lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)])))| (!(((Sybase.PowerBuilder.PBBoolean)lb_value1[(Sybase.PowerBuilder.PBLong)(li_cnt)]))& ((Sybase.PowerBuilder.PBBoolean)lb_value2[(Sybase.PowerBuilder.PBLong)(li_cnt)]))))
				#line hidden
				{
					#line 70
					ll_result = ll_result+ ((Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.PBSystemFunctions.Pow((Sybase.PowerBuilder.PBDouble)new Sybase.PowerBuilder.PBInt(2), (Sybase.PowerBuilder.PBDouble)((Sybase.PowerBuilder.PBLong)(li_cnt)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))));
					#line hidden
				}
		}
		#line 74
		return ll_result;
		#line hidden
	}

	#line 1 "pfc_n_cst_numerical.of_bitwisenot(LL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_bitwisenot", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_bitwisenot(Sybase.PowerBuilder.PBLong al_value)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_result = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_value = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_result = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 55
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_value)))))
		#line hidden
		{
			#line 56
			ll_result.SetNull();
			#line hidden
			#line 57
			return ll_result;
			#line hidden
		}
		#line 61
		ls_value = this.of_binary(al_value);
		#line hidden
		#line 62
		li_cnt = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_value));
		#line hidden
		#line 65
		for (li_count = new Sybase.PowerBuilder.PBInt(1);li_count <= li_cnt;li_count = li_count + 1)
		#line hidden
		{
				#line 66
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_value, (Sybase.PowerBuilder.PBLong)(li_count), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("0")))
				#line hidden
				{
					#line 67
					ls_result = ls_result+ new Sybase.PowerBuilder.PBString("1");
					#line hidden
				}
				else
				{
					#line 69
					ls_result = ls_result+ new Sybase.PowerBuilder.PBString("0");
					#line hidden
				}
		}
		#line 74
		return this.of_decimal(ls_result);
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
		c__pfc_n_cst_numerical vv = (c__pfc_n_cst_numerical)base.Clone();
 		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_numerical()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_numerical(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_numerical vv = new c__pfc_n_cst_numerical();
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
			return (c__pfc_n_cst_numerical) v.Value;
		}
	}
}
 