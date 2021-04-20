//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcwnsrv.pbl\\pfcwnsrv.pblx\\pfc_n_cst_winsrv.sru"
#line hidden
#line 1 "pfc_n_cst_winsrv"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_winsrv",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcwnsrv.pbl\\pfcwnsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_winsrv")]
public class c__pfc_n_cst_winsrv : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_requestor", null, "pfc_n_cst_winsrv", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_master iw_requestor = null;

	#line 1 "pfc_n_cst_winsrv.of_center(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_center", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_center()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_screenheight = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_screenwidth = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_x = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt li_y = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBEnvironment lenv_obj = (Sybase.PowerBuilder.PBEnvironment) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.PBEnvironment));
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.GetEnvironment(ref lenv_obj) == new Sybase.PowerBuilder.PBInt(-1)))
		#line hidden
		{
			#line 62
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 66
		li_screenheight = Sybase.PowerBuilder.WPF.PBSystemFunctions.PixelsToUnits((Sybase.PowerBuilder.PBInt)(lenv_obj.ScreenHeight), (new Sybase.PowerBuilder.PBConvertTypeValue(Sybase.PowerBuilder.PBConvertType.YPixelsToUnits)));
		#line hidden
		#line 67
		li_screenwidth = Sybase.PowerBuilder.WPF.PBSystemFunctions.PixelsToUnits((Sybase.PowerBuilder.PBInt)(lenv_obj.ScreenWidth), (new Sybase.PowerBuilder.PBConvertTypeValue(Sybase.PowerBuilder.PBConvertType.XPixelsToUnits)));
		#line hidden
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)(!((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_screenheight)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))| !((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_screenwidth)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))))
		#line hidden
		{
			#line 69
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 73
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_screenwidth)> (Sybase.PowerBuilder.PBLong)(iw_requestor.Width)))
		#line hidden
		{
			#line 74
			li_x = (Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBDouble)(li_screenwidth)/ (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2)))- ((Sybase.PowerBuilder.PBDouble)(iw_requestor.Width)/ (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2))));
			#line hidden
		}
		#line 76
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_screenheight)> (Sybase.PowerBuilder.PBLong)(iw_requestor.Height)))
		#line hidden
		{
			#line 77
			li_y = (Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBDouble)(li_screenheight)/ (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2)))- ((Sybase.PowerBuilder.PBDouble)(iw_requestor.Height)/ (Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(2))));
			#line hidden
		}
		#line 81
		li_rc = iw_requestor.Move(li_x, li_y);
		#line hidden
		#line 82
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 83
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 86
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv.of_setrequestor(ICw_master.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"w_master"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrequestor(c__w_master aw_requestor)
	{
		#line hidden
		#line 46
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(aw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(aw_requestor)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		iw_requestor = aw_requestor;
		#line hidden
		#line 51
		return new Sybase.PowerBuilder.PBInt(1);
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

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_winsrv()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_winsrv(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_winsrv vv = new c__pfc_n_cst_winsrv();
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
			return (c__pfc_n_cst_winsrv) v.Value;
		}
	}
}
 