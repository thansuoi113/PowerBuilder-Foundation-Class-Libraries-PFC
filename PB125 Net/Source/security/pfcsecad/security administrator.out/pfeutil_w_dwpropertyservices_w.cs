//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfeutil.pbl\\pfeutil.pblx\\w_dwpropertyservices.srw"
#line hidden
#line 1 "w_dwpropertyservices"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_dwpropertyservices",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_dwpropertyservices")]
public class c__w_dwpropertyservices : c__pfc_w_dwpropertyservices
{
	#line hidden
	public new c__w_dwpropertyservices.c__cb_ok cb_ok
	{
		get { return (c__w_dwpropertyservices.c__cb_ok)base.cb_ok; }
		set { base.cb_ok = value; }
	}
	public new c__w_dwpropertyservices.c__tab_property tab_property
	{
		get { return (c__w_dwpropertyservices.c__tab_property)base.tab_property; }
		set { base.tab_property = value; }
	}
	public new c__w_dwpropertyservices.c__cb_dlghelp cb_dlghelp
	{
		get { return (c__w_dwpropertyservices.c__cb_dlghelp)base.cb_dlghelp; }
		set { base.cb_dlghelp = value; }
	}
	public new c__w_dwpropertyservices.c__cb_cancel cb_cancel
	{
		get { return (c__w_dwpropertyservices.c__cb_cancel)base.cb_cancel; }
		set { base.cb_cancel = value; }
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

	#line 1 "w_dwpropertyservices.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public new class c__cb_ok : c__pfc_w_dwpropertyservices.c__cb_ok
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_ok()
		{
			_init();
		}

	}


	#line 1 "w_dwpropertyservices.tab_property"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tab_property")]
	public new class c__tab_property : c__pfc_w_dwpropertyservices.c__tab_property
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__tab_property()
		{
			_init();
		}

	}


	#line 1 "w_dwpropertyservices.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public new class c__cb_dlghelp : c__pfc_w_dwpropertyservices.c__cb_dlghelp
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_dlghelp()
		{
			_init();
		}

	}


	#line 1 "w_dwpropertyservices.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public new class c__cb_cancel : c__pfc_w_dwpropertyservices.c__cb_cancel
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_cancel()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_dwpropertyservices()
	{
		_init();
	}

}
 