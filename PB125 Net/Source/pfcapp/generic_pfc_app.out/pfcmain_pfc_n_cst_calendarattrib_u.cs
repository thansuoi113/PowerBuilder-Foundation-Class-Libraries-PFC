//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfcmain.pbl\\pfcmain.pblx\\pfc_n_cst_calendarattrib.sru"
#line hidden
#line 1 "pfc_n_cst_calendarattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_calendarattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcapp\\pfcmain.pbl\\pfcmain.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_calendarattrib")]
public class c__pfc_n_cst_calendarattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_dropdown", null, "pfc_n_cst_calendarattrib", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Public, "= False")]
	public Sybase.PowerBuilder.PBBoolean ib_dropdown = new Sybase.PowerBuilder.PBBoolean(false);

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
		c__pfc_n_cst_calendarattrib vv = (c__pfc_n_cst_calendarattrib)base.Clone();
 		vv.ib_dropdown = ib_dropdown;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_calendarattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_calendarattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_calendarattrib vv = new c__pfc_n_cst_calendarattrib();
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
			return (c__pfc_n_cst_calendarattrib) v.Value;
		}
	}
}
 