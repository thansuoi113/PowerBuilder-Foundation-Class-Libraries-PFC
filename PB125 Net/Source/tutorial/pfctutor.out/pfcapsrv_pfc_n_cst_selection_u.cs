//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_selection.sru"
#line hidden
#line 1 "pfc_n_cst_selection"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_selection",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_selection")]
public class c__pfc_n_cst_selection : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_defaulttitle", null, "pfc_n_cst_selection", "Open", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= \"Open\"")]
	protected Sybase.PowerBuilder.PBString is_defaulttitle = new Sybase.PowerBuilder.PBString("Open");

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]RCn_tr.S[]A[20]S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "ref n_tr", "string", "any", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_6_295634248<T2>(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, ref T2 atr_object, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny), new int[2]{1,20})] Sybase.PowerBuilder.PBArray aa_argument, Sybase.PowerBuilder.PBString as_title) where T2 : c__n_tr
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_cst_selectionattrib lnv_sel = (c__n_cst_selectionattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_selectionattrib));
		#line 55
		lnv_sel.is_dataobject = as_dataobject;
		#line hidden
		#line 56
		lnv_sel.itr_object = (c__n_tr)(c__n_tr)(atr_object);
		#line hidden
		#line 57
		lnv_sel.is_columnreturn.AssignFrom((Sybase.PowerBuilder.PBArray)as_colreturn);
		#line hidden
		#line 58
		lnv_sel.ia_argument.AssignFrom((Sybase.PowerBuilder.PBArray)aa_argument);
		#line hidden
		#line 59
		lnv_sel.is_title = as_title;
		#line hidden
		#line 61
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__pfctutor.GetCurrentApplication().w_selection, (Sybase.PowerBuilder.PBPowerObject)(lnv_sel));
		#line hidden
		#line 63
		lnv_sel = (c__n_cst_selectionattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfctutor.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 64
		li_rc = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(lnv_sel.ia_returnval)));
		#line hidden
		#line 65
		aa_returnval.AssignFrom((Sybase.PowerBuilder.PBArray)lnv_sel.ia_returnval);
		#line hidden
		#line 67
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_2_1875022546(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval)
	{
		#line hidden
		c__n_tr ltr_object = null;
		Sybase.PowerBuilder.PBArray ls_colreturn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBArray la_argument = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		#line 5
		ltr_object = null;
		#line hidden
		#line 6
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref ltr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(ls_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(la_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]RCn_tr.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "ref n_tr"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_3_301210683<T2>(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, ref T2 atr_object) where T2 : c__n_tr
	{
		#line hidden
		Sybase.PowerBuilder.PBArray ls_colreturn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBArray la_argument = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		#line 4
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref atr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(ls_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(la_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]RCn_tr.S[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "ref n_tr", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_4_1197857690<T2>(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, ref T2 atr_object, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn) where T2 : c__n_tr
	{
		#line hidden
		Sybase.PowerBuilder.PBArray la_argument = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		#line 3
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref atr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(as_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(la_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]RCn_tr.S[]A[20])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "ref n_tr", "string", "any"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_5_295634248<T2>(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, ref T2 atr_object, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny), new int[2]{1,20})] Sybase.PowerBuilder.PBArray aa_argument) where T2 : c__n_tr
	{
		#line hidden
		#line 1
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref atr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(as_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(aa_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]S[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_3_1602430317(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn)
	{
		#line hidden
		Sybase.PowerBuilder.PBArray la_argument = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		c__n_tr ltr_object = null;
		#line 4
		ltr_object = null;
		#line hidden
		#line 5
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref ltr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(as_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(la_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]S[]S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_4_1602430317(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn, Sybase.PowerBuilder.PBString as_title)
	{
		#line hidden
		Sybase.PowerBuilder.PBArray la_argument = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		c__n_tr ltr_object = null;
		#line 4
		ltr_object = null;
		#line hidden
		#line 5
		return of_open_6_295634248_6_pfc_n_cs1515927247(this, as_dataobject, ref aa_returnval, ref ltr_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(as_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), (Sybase.PowerBuilder.PBBoundedAnyArray)(la_argument).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), as_title);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]XCpowerobject.[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "powerobject"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_3_497924832(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBPowerObject))] [Sybase.PowerBuilder.PBReadOnlyAttribute]Sybase.PowerBuilder.PBArray apo_object)
	{
		#line hidden
		Sybase.PowerBuilder.PBArray ls_colreturn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		#line 3
		return of_open_5_419691167_5_pfc_n_cs1437306857(this, as_dataobject, ref aa_returnval, apo_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(ls_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]XCpowerobject.[]S[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "powerobject", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_4_419691167(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBPowerObject))] [Sybase.PowerBuilder.PBReadOnlyAttribute]Sybase.PowerBuilder.PBArray apo_object, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn)
	{
		#line hidden
		#line 1
		return of_open_5_419691167_5_pfc_n_cs1437306857(this, as_dataobject, ref aa_returnval, apo_object, (Sybase.PowerBuilder.PBUnboundedStringArray)(as_colreturn).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)), is_defaulttitle);
		#line hidden
	}

	#line 1 "pfc_n_cst_selection.of_open(ISRA[]XCpowerobject.[]S[]S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_open", new string[]{"string", "ref any", "powerobject", "string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_open_5_419691167(Sybase.PowerBuilder.PBString as_dataobject, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] ref Sybase.PowerBuilder.PBArray aa_returnval, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBPowerObject))] [Sybase.PowerBuilder.PBReadOnlyAttribute]Sybase.PowerBuilder.PBArray apo_object, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] Sybase.PowerBuilder.PBArray as_colreturn, Sybase.PowerBuilder.PBString as_title)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__n_cst_selectionattrib lnv_sel = (c__n_cst_selectionattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_selectionattrib));
		#line 53
		lnv_sel.is_dataobject = as_dataobject;
		#line hidden
		#line 54
		lnv_sel.ipo_data.AssignFrom((Sybase.PowerBuilder.PBArray)apo_object);
		#line hidden
		#line 55
		lnv_sel.is_columnreturn.AssignFrom((Sybase.PowerBuilder.PBArray)as_colreturn);
		#line hidden
		#line 56
		lnv_sel.is_title = as_title;
		#line hidden
		#line 58
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__pfctutor.GetCurrentApplication().w_selection, (Sybase.PowerBuilder.PBPowerObject)(lnv_sel));
		#line hidden
		#line 60
		lnv_sel = (c__n_cst_selectionattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfctutor.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 61
		li_rc = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(lnv_sel.ia_returnval)));
		#line hidden
		#line 62
		aa_returnval.AssignFrom((Sybase.PowerBuilder.PBArray)lnv_sel.ia_returnval);
		#line hidden
		#line 64
		return li_rc;
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
		c__pfc_n_cst_selection vv = (c__pfc_n_cst_selection)base.Clone();
 		vv.is_defaulttitle = is_defaulttitle;
		return vv;
	}

	public Sybase.PowerBuilder.PBInt of_open_6_295634248_6_pfc_n_cs1515927247<T2>(c__pfc_n_cst_selection this__object, Sybase.PowerBuilder.PBString as_dataobject, ref Sybase.PowerBuilder.PBArray aa_returnval, ref T2 atr_object, Sybase.PowerBuilder.PBArray as_colreturn, Sybase.PowerBuilder.PBArray aa_argument, Sybase.PowerBuilder.PBString as_title) where T2: c__n_tr
	{
		c__n_tr temp_var_2 = atr_object;
		 Sybase.PowerBuilder.PBArray temp_var_as_colreturn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_colreturn.AssignFrom(as_colreturn);
		 Sybase.PowerBuilder.PBArray temp_var_aa_argument = new Sybase.PowerBuilder.PBBoundedAnyArray(new  Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1,20},false));
		temp_var_aa_argument.AssignFrom(aa_argument);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_open_6_295634248(as_dataobject, ref aa_returnval, ref temp_var_2, temp_var_as_colreturn, temp_var_aa_argument, as_title);
		atr_object = (T2)temp_var_2;
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_open_5_419691167_5_pfc_n_cs1437306857(c__pfc_n_cst_selection this__object, Sybase.PowerBuilder.PBString as_dataobject, ref Sybase.PowerBuilder.PBArray aa_returnval, Sybase.PowerBuilder.PBArray apo_object, Sybase.PowerBuilder.PBArray as_colreturn, Sybase.PowerBuilder.PBString as_title)
	{
		 Sybase.PowerBuilder.PBArray temp_var_as_colreturn = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_colreturn.AssignFrom(as_colreturn);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_open_5_419691167(as_dataobject, ref aa_returnval, apo_object, temp_var_as_colreturn, as_title);
		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_selection()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_selection(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_selection vv = new c__pfc_n_cst_selection();
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
			return (c__pfc_n_cst_selection) v.Value;
		}
	}
}
 