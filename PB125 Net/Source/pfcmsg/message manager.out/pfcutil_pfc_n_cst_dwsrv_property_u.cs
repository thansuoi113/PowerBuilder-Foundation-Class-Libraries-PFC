//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx\\pfc_n_cst_dwsrv_property.sru"
#line hidden
#line 1 "pfc_n_cst_dwsrv_property"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwsrv_property",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwsrv_property")]
public class c__pfc_n_cst_dwsrv_property : c__n_cst_dwsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_property", null, "pfc_n_cst_dwsrv_property", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_dwproperty iw_property = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_propertyservices", null, "pfc_n_cst_dwsrv_property", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_dwpropertyservices iw_propertyservices = null;

	#line 1 "pfc_n_cst_dwsrv_property.of_openproperty(ICn_cst_dwpropertyattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_openproperty", new string[]{"n_cst_dwpropertyattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_openproperty(c__n_cst_dwpropertyattrib anv_attrib)
	{
		#line hidden
		#line 48
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 50
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref iw_property, (Sybase.PowerBuilder.PBPowerObject)(anv_attrib));
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_property.of_ispropertyopen(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_ispropertyopen", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_ispropertyopen()
	{
		#line hidden
		#line 48
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_property)))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_propertyservices)))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 50
		return new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_property.of_openpropertyservice(ICpowerobject.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_openpropertyservice", new string[]{"powerobject"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_openpropertyservice(Sybase.PowerBuilder.PBPowerObject apo_service)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_tabcnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_uppertab = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_pages = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_args = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBBoolean lb_defined = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.WPF.PBWindow lw_parentwindow = null;
		c__n_cst_propertyattrib lnv_propertyattrib = (c__n_cst_propertyattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_propertyattrib));
		c__n_cst_dwpropertyattrib lnv_attrib = (c__n_cst_dwpropertyattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_dwpropertyattrib));
		c__n_cst_metaclass lnv_metaclass = (c__n_cst_metaclass) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_metaclass));
		#line 63
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 66
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(apo_service)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(apo_service))))
		#line hidden
		{
			#line 67
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 71
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 74
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 86
		li_rc = (Sybase.PowerBuilder.PBInt)(Sybase_u002e_PowerBuilder_u002e_PBPowerObj471799603(apo_service, ref lnv_propertyattrib));
		#line hidden
		#line 87
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 87
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 92
		lnv_attrib.idw_requestor = (Sybase.PowerBuilder.WPF.PBDataWindow)(idw_requestor);
		#line hidden
		#line 95
		lnv_attrib.is_objectname = lnv_propertyattrib.is_name;
		#line hidden
		#line 96
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(lnv_attrib.is_objectname)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 97
			lnv_attrib.is_objectname = apo_service.ClassName();
			#line hidden
		}
		#line 101
		li_uppertab = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(lnv_propertyattrib.is_propertypage)));
		#line hidden
		#line 102
		for (li_tabcnt = new Sybase.PowerBuilder.PBInt(1);li_tabcnt <= li_uppertab;li_tabcnt = li_tabcnt + 1)
		#line hidden
		{
				#line 103
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_tabcnt)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
				#line hidden
				{
					#line 103
					ls_pages += new Sybase.PowerBuilder.PBString("\t");
					#line hidden
				}
				#line 104
				ls_pages += ((Sybase.PowerBuilder.PBString)lnv_propertyattrib.is_propertypage[(Sybase.PowerBuilder.PBLong)(li_tabcnt)]);
				#line hidden
		}
		#line 106
		lnv_attrib.is_tabpages = ls_pages;
		#line hidden
		#line 109
		idw_requestor.of_getparentwindow_1_232646770(ref lw_parentwindow);
		#line hidden
		#line 110
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_parentwindow)))
		#line hidden
		{
			#line 111
			lnv_attrib.iw_main = lw_parentwindow;
			#line hidden
		}
		#line 115
		idw_requestor.pfc_preproperties(ref lnv_attrib);
		#line hidden
		#line 118
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref iw_propertyservices, (Sybase.PowerBuilder.PBPowerObject)(lnv_attrib));
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

	#line 1 "pfc_n_cst_dwsrv_property.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 43
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_property)))
		#line hidden
		{
			#line 43
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(iw_property));
			#line hidden
		}
		#line 44
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_propertyservices)))
		#line hidden
		{
			#line 44
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(iw_propertyservices));
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_n_cst_dwsrv_property.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		return new Sybase.PowerBuilder.PBLong(0);
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_PBPowerObj471799603<T0>(Sybase.PowerBuilder.PBPowerObject this__object, ref T0 temp_arg_name_0) where T0: c__n_cst_propertyattrib
	{
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[1] {
			new Sybase.PowerBuilder.PBArgument(temp_arg_name_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__n_cst_propertyattrib))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "of_getpropertyinfo", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0 = (T0)__tempArgument4DynamicCall[0].Value;

		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
		this.ConstructorEvent -= new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
	}

	public c__pfc_n_cst_dwsrv_property()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwsrv_property(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwsrv_property vv = new c__pfc_n_cst_dwsrv_property();
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
			return (c__pfc_n_cst_dwsrv_property) v.Value;
		}
	}
}
 