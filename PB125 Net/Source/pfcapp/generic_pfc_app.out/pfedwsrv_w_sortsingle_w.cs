//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfedwsrv.pbl\\pfedwsrv.pblx\\w_sortsingle.srw"
#line hidden
#line 1 "w_sortsingle"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_sortsingle",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\pfcapp\\pfedwsrv.pbl\\pfedwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_sortsingle")]
public class c__w_sortsingle : c__pfc_w_sortsingle
{
	#line hidden
	public new c__w_sortsingle.c__cbx_asc cbx_asc
	{
		get { return (c__w_sortsingle.c__cbx_asc)base.cbx_asc; }
		set { base.cbx_asc = value; }
	}
	public new c__w_sortsingle.c__cb_cancel cb_cancel
	{
		get { return (c__w_sortsingle.c__cb_cancel)base.cb_cancel; }
		set { base.cb_cancel = value; }
	}
	public new c__w_sortsingle.c__cb_ok cb_ok
	{
		get { return (c__w_sortsingle.c__cb_ok)base.cb_ok; }
		set { base.cb_ok = value; }
	}
	public new c__w_sortsingle.c__ddlb_sort ddlb_sort
	{
		get { return (c__w_sortsingle.c__ddlb_sort)base.ddlb_sort; }
		set { base.ddlb_sort = value; }
	}
	public new c__w_sortsingle.c__gb_sort gb_sort
	{
		get { return (c__w_sortsingle.c__gb_sort)base.gb_sort; }
		set { base.gb_sort = value; }
	}
	public new c__w_sortsingle.c__cb_dlghelp cb_dlghelp
	{
		get { return (c__w_sortsingle.c__cb_dlghelp)base.cb_dlghelp; }
		set { base.cb_dlghelp = value; }
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

	#line 1 "w_sortsingle.cbx_asc"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_asc")]
	public new class c__cbx_asc : c__pfc_w_sortsingle.c__cbx_asc
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_asc()
		{
			_init();
		}

	}


	#line 1 "w_sortsingle.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public new class c__cb_cancel : c__pfc_w_sortsingle.c__cb_cancel
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


	#line 1 "w_sortsingle.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public new class c__cb_ok : c__pfc_w_sortsingle.c__cb_ok
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


	#line 1 "w_sortsingle.ddlb_sort"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_sort")]
	public new class c__ddlb_sort : c__pfc_w_sortsingle.c__ddlb_sort
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_sort()
		{
			_init();
		}

	}


	#line 1 "w_sortsingle.gb_sort"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_sort")]
	public new class c__gb_sort : c__pfc_w_sortsingle.c__gb_sort
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_sort()
		{
			_init();
		}

	}


	#line 1 "w_sortsingle.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public new class c__cb_dlghelp : c__pfc_w_sortsingle.c__cb_dlghelp
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


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_sortsingle()
	{
		_init();
	}

}
 