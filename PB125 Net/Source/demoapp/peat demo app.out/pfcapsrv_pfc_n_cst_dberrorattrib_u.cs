//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_dberrorattrib.sru"
#line hidden
#line 1 "pfc_n_cst_dberrorattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dberrorattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dberrorattrib")]
public class c__pfc_n_cst_dberrorattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_sqldbcode", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBLong il_sqldbcode = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_row", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBLong il_row = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idwb_buffer", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBDWBufferValue idwb_buffer = new Sybase.PowerBuilder.PBDWBufferValue();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_sqlsyntax", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_sqlsyntax = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_sqlerrtext", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_sqlerrtext = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_errormsg", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_errormsg = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ipo_inerror", null, "pfc_n_cst_dberrorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBPowerObject ipo_inerror = null;

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
		c__pfc_n_cst_dberrorattrib vv = (c__pfc_n_cst_dberrorattrib)base.Clone();
 		vv.il_sqldbcode = il_sqldbcode;
		vv.il_row = il_row;
		vv.idwb_buffer = idwb_buffer;
		vv.is_sqlsyntax = is_sqlsyntax;
		vv.is_sqlerrtext = is_sqlerrtext;
		vv.is_errormsg = is_errormsg;
		vv.ipo_inerror = ipo_inerror;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dberrorattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dberrorattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dberrorattrib vv = new c__pfc_n_cst_dberrorattrib();
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
			return (c__pfc_n_cst_dberrorattrib) v.Value;
		}
	}
}
 