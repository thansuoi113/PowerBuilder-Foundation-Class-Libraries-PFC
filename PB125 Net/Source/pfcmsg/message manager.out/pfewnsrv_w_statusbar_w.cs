//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfewnsrv.pbl\\pfewnsrv.pblx\\w_statusbar.srw"
#line hidden
#line 1 "w_statusbar"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_statusbar",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\pfcmsg\\pfewnsrv.pbl\\pfewnsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_statusbar")]
public class c__w_statusbar : c__pfc_w_statusbar
{
	#line hidden
	public new c__w_statusbar.c__dw_statusbar dw_statusbar
	{
		get { return (c__w_statusbar.c__dw_statusbar)base.dw_statusbar; }
		set { base.dw_statusbar = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
	}

	#line 1 "w_statusbar.dw_statusbar"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_statusbar")]
	public new class c__dw_statusbar : c__pfc_w_statusbar.c__dw_statusbar
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__dw_statusbar()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_statusbar()
	{
		_init();
	}

}
 