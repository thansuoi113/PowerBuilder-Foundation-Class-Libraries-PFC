//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_dwcacheattrib.sru"
#line hidden
#line 1 "pfc_n_cst_dwcacheattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwcacheattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwcacheattrib")]
public class c__pfc_n_cst_dwcacheattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_id", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_id = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ds_obj", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_ds ds_obj = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "tr_obj", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_tr tr_obj = null;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBAny))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "a_args", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray a_args = new Sybase.PowerBuilder.PBUnboundedAnyArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_method", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_method = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_filename", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_filename = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "dw_originalcontrol", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.WPF.PBDataWindow dw_originalcontrol = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ds_originalcontrol", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.WPF.PBDataStore ds_originalcontrol = null;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBPowerObject))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "po_originaldata", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray po_originaldata = new Sybase.PowerBuilder.PBUnboundedArray(typeof(Sybase.PowerBuilder.PBPowerObject));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_originaldataobject", null, "pfc_n_cst_dwcacheattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_originaldataobject = Sybase.PowerBuilder.PBString.DefaultValue;

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
		c__pfc_n_cst_dwcacheattrib vv = (c__pfc_n_cst_dwcacheattrib)base.Clone();
 		vv.s_id = s_id;
		vv.ds_obj = ds_obj;
		vv.tr_obj = tr_obj;
		vv.a_args = (Sybase.PowerBuilder.PBUnboundedAnyArray)(a_args.Clone());
		vv.s_method = s_method;
		vv.s_filename = s_filename;
		vv.dw_originalcontrol = dw_originalcontrol;
		vv.ds_originalcontrol = ds_originalcontrol;
		vv.po_originaldata = (Sybase.PowerBuilder.PBUnboundedArray)(po_originaldata.Clone());
		vv.s_originaldataobject = s_originaldataobject;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dwcacheattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwcacheattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwcacheattrib vv = new c__pfc_n_cst_dwcacheattrib();
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
			return (c__pfc_n_cst_dwcacheattrib) v.Value;
		}
	}
}
 