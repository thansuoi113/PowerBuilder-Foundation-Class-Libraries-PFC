//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_treenodecompare.sru"
#line hidden
#line 1 "pfc_n_cst_treenodecompare"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_treenodecompare",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_treenodecompare")]
public class c__pfc_n_cst_treenodecompare : c__n_cst_nodecomparebase
{
	#line hidden

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

	public c__pfc_n_cst_treenodecompare()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_treenodecompare(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_treenodecompare vv = new c__pfc_n_cst_treenodecompare();
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
			return (c__pfc_n_cst_treenodecompare) v.Value;
		}
	}
}
 