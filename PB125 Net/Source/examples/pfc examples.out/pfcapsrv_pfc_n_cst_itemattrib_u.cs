//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_itemattrib.sru"
#line hidden
#line 1 "pfc_n_cst_itemattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_itemattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_itemattrib")]
public class c__pfc_n_cst_itemattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_index", null, "pfc_n_cst_itemattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt ii_index = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_itemtext", null, "pfc_n_cst_itemattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_itemtext = Sybase.PowerBuilder.PBString.DefaultValue;

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
		c__pfc_n_cst_itemattrib vv = (c__pfc_n_cst_itemattrib)base.Clone();
 		vv.ii_index = ii_index;
		vv.is_itemtext = is_itemtext;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_itemattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_itemattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_itemattrib vv = new c__pfc_n_cst_itemattrib();
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
			return (c__pfc_n_cst_itemattrib) v.Value;
		}
	}
}
 