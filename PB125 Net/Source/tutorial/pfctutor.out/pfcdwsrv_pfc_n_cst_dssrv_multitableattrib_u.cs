//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_n_cst_dssrv_multitableattrib.sru"
#line hidden
#line 1 "pfc_n_cst_dssrv_multitableattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dssrv_multitableattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dssrv_multitableattrib")]
public class c__pfc_n_cst_dssrv_multitableattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_updatetable", null, "pfc_n_cst_dssrv_multitableattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString s_updatetable = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "i_whereoption", null, "pfc_n_cst_dssrv_multitableattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt i_whereoption = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "b_keyupdateinplace", null, "pfc_n_cst_dssrv_multitableattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean b_keyupdateinplace = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_updatecolumns", null, "pfc_n_cst_dssrv_multitableattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray s_updatecolumns = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "s_keycolumns", null, "pfc_n_cst_dssrv_multitableattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray s_keycolumns = new Sybase.PowerBuilder.PBUnboundedStringArray();

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
		c__pfc_n_cst_dssrv_multitableattrib vv = (c__pfc_n_cst_dssrv_multitableattrib)base.Clone();
 		vv.s_updatetable = s_updatetable;
		vv.i_whereoption = i_whereoption;
		vv.b_keyupdateinplace = b_keyupdateinplace;
		vv.s_updatecolumns = (Sybase.PowerBuilder.PBUnboundedStringArray)(s_updatecolumns.Clone());
		vv.s_keycolumns = (Sybase.PowerBuilder.PBUnboundedStringArray)(s_keycolumns.Clone());
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dssrv_multitableattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dssrv_multitableattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dssrv_multitableattrib vv = new c__pfc_n_cst_dssrv_multitableattrib();
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
			return (c__pfc_n_cst_dssrv_multitableattrib) v.Value;
		}
	}
}
 