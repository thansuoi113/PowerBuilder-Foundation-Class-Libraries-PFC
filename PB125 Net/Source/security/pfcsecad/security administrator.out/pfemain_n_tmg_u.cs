//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfemain.pbl\\pfemain.pblx\\n_tmg.sru"
#line hidden
#line 1 "n_tmg"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("n_tmg",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="n_tmg")]
public class c__n_tmg : c__pfc_n_tmg
{
	#line hidden

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
		base.destroy();
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

	public c__n_tmg()
	{
		_init();
	}


	public static explicit operator c__n_tmg(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__n_tmg vv = new c__n_tmg();
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
			return (c__n_tmg) v.Value;
		}
	}
}
 