//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfeapsrv.pbl\\pfeapsrv.pblx\\n_cst_numerical.sru"
#line hidden
#line 1 "n_cst_numerical"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("n_cst_numerical",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfeapsrv.pbl\\pfeapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="n_cst_numerical")]
public class c__n_cst_numerical : c__pfc_n_cst_numerical
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

	public override object Clone()
	{
		c__n_cst_numerical vv = (c__n_cst_numerical)base.Clone();
 		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__n_cst_numerical()
	{
		_init();
	}


	public static explicit operator c__n_cst_numerical(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__n_cst_numerical vv = new c__n_cst_numerical();
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
			return (c__n_cst_numerical) v.Value;
		}
	}
}
 