//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfewnsrv.pbl\\pfewnsrv.pblx\\n_cst_winsrv_sheetmanager.sru"
#line hidden
#line 1 "n_cst_winsrv_sheetmanager"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("n_cst_winsrv_sheetmanager",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfewnsrv.pbl\\pfewnsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="n_cst_winsrv_sheetmanager")]
public class c__n_cst_winsrv_sheetmanager : c__pfc_n_cst_winsrv_sheetmanager
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

	public c__n_cst_winsrv_sheetmanager()
	{
		_init();
	}


	public static explicit operator c__n_cst_winsrv_sheetmanager(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__n_cst_winsrv_sheetmanager vv = new c__n_cst_winsrv_sheetmanager();
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
			return (c__n_cst_winsrv_sheetmanager) v.Value;
		}
	}
}
 