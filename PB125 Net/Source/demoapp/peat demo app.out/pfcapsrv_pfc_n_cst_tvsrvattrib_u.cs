//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_tvsrvattrib.sru"
#line hidden
#line 1 "pfc_n_cst_tvsrvattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_tvsrvattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_tvsrvattrib")]
public class c__pfc_n_cst_tvsrvattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_recursive", null, "pfc_n_cst_tvsrvattrib", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Public, "= False")]
	public Sybase.PowerBuilder.PBBoolean ib_recursive = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_deletestyle", null, "pfc_n_cst_tvsrvattrib", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 0")]
	public Sybase.PowerBuilder.PBInt ii_deletestyle = new Sybase.PowerBuilder.PBInt(0);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_filtercols", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_filtercols = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_dataobject", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_dataobject = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_labelcolumn", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_labelcolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_retrieveargs", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_retrieveargs = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_method", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_method = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_picturecolumn", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_picturecolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_selectedcolumn", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_selectedcolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_statecolumn", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_statecolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_overlaycolumn", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_overlaycolumn = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ids_obj", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_ds ids_obj = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itr_obj", null, "pfc_n_cst_tvsrvattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
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
		c__pfc_n_cst_tvsrvattrib vv = (c__pfc_n_cst_tvsrvattrib)base.Clone();
 		vv.ib_recursive = ib_recursive;
		vv.ii_deletestyle = ii_deletestyle;
		vv.is_filtercols = is_filtercols;
		vv.is_dataobject = is_dataobject;
		vv.is_labelcolumn = is_labelcolumn;
		vv.is_retrieveargs = is_retrieveargs;
		vv.is_method = is_method;
		vv.is_picturecolumn = is_picturecolumn;
		vv.is_selectedcolumn = is_selectedcolumn;
		vv.is_statecolumn = is_statecolumn;
		vv.is_overlaycolumn = is_overlaycolumn;
		vv.ids_obj = ids_obj;
		vv.itr_obj = itr_obj;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_tvsrvattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_tvsrvattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_tvsrvattrib vv = new c__pfc_n_cst_tvsrvattrib();
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
			return (c__pfc_n_cst_tvsrvattrib) v.Value;
		}
	}
}
 