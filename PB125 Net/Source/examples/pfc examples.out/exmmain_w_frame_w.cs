//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\exmmain.pbl\\exmmain.pblx\\w_frame.srw"
#line hidden
#line 1 "w_frame"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_frame",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\exmmain.pbl\\exmmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_frame")]
public class c__w_frame : c__pfc_w_frame
{
	#line hidden
	public new c__w_frame.c__mdi_1 mdi_1
	{
		get { return (c__w_frame.c__mdi_1)base.mdi_1; }
		set { base.mdi_1 = value; }
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
		#line hidden
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(MenuID)))
		#line hidden
		{
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(MenuID);
			#line hidden
		}
	}

	#line 1 "w_frame.pfc_pretoolbar"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_pretoolbar")]
	public override void pfc_pretoolbar<T0>(ref T0 anv_toolbarattrib)
	{
		#line hidden
		#line 1
		base.pfc_pretoolbar(ref anv_toolbarattrib);
		#line hidden
		#line 49
		anv_toolbarattrib.ib_largebuttonsenabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "w_frame.mdi_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mdi_1")]
	public new class c__mdi_1 : c__pfc_w_frame.c__mdi_1
	{
		#line hidden

		void _init()
		{
		}

		public c__mdi_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_frame()
	{
		_init();
	}

}
 