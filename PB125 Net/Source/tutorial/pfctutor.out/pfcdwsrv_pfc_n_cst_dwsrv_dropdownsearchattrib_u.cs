//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_n_cst_dwsrv_dropdownsearchattrib.sru"
#line hidden
#line 1 "pfc_n_cst_dwsrv_dropdownsearchattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwsrv_dropdownsearchattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwsrv_dropdownsearchattrib")]
public class c__pfc_n_cst_dwsrv_dropdownsearchattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_columnname", null, "pfc_n_cst_dwsrv_dropdownsearchattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_columnname = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_editstyle", null, "pfc_n_cst_dwsrv_dropdownsearchattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_editstyle = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "dwc_object", null, "pfc_n_cst_dwsrv_dropdownsearchattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.WPF.PBDataWindowChild dwc_object = (Sybase.PowerBuilder.WPF.PBDataWindowChild) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBDataWindowChild));

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
		c__pfc_n_cst_dwsrv_dropdownsearchattrib vv = (c__pfc_n_cst_dwsrv_dropdownsearchattrib)base.Clone();
 		vv.s_columnname = s_columnname;
		vv.s_editstyle = s_editstyle;
		vv.dwc_object = (Sybase.PowerBuilder.WPF.PBDataWindowChild)(dwc_object.Clone());
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dwsrv_dropdownsearchattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwsrv_dropdownsearchattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwsrv_dropdownsearchattrib vv = new c__pfc_n_cst_dwsrv_dropdownsearchattrib();
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
			return (c__pfc_n_cst_dwsrv_dropdownsearchattrib) v.Value;
		}
	}
}
 