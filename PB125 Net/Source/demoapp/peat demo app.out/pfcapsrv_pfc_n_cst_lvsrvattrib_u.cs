//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_lvsrvattrib.sru"
#line hidden
#line 1 "pfc_n_cst_lvsrvattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_lvsrvattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_lvsrvattrib")]
public class c__pfc_n_cst_lvsrvattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_dataobject", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_dataobject = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_labelcolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_labelcolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_picturecolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_picturecolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_statecolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_statecolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_overlaycolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_overlaycolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_xposcolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_xposcolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_yposcolumn", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_yposcolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_method", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_method = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_keycolumns", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray is_keycolumns = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ids_source", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_ds ids_source = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itr_obj", null, "pfc_n_cst_lvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_tr itr_obj = null;

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
		c__pfc_n_cst_lvsrvattrib vv = (c__pfc_n_cst_lvsrvattrib)base.Clone();
 		vv.is_dataobject = is_dataobject;
		vv.is_labelcolumn = is_labelcolumn;
		vv.is_picturecolumn = is_picturecolumn;
		vv.is_statecolumn = is_statecolumn;
		vv.is_overlaycolumn = is_overlaycolumn;
		vv.is_xposcolumn = is_xposcolumn;
		vv.is_yposcolumn = is_yposcolumn;
		vv.is_method = is_method;
		vv.is_keycolumns = (Sybase.PowerBuilder.PBUnboundedStringArray)(is_keycolumns.Clone());
		vv.ids_source = ids_source;
		vv.itr_obj = itr_obj;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_lvsrvattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_lvsrvattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_lvsrvattrib vv = new c__pfc_n_cst_lvsrvattrib();
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
			return (c__pfc_n_cst_lvsrvattrib) v.Value;
		}
	}
}
 