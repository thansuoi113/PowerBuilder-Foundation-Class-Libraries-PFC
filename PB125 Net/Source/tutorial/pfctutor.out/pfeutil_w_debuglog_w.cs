//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfeutil.pbl\\pfeutil.pblx\\w_debuglog.srw"
#line hidden
#line 1 "w_debuglog"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_debuglog",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\tutorial\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_debuglog")]
public class c__w_debuglog : c__pfc_w_debuglog
{
	#line hidden
	public new c__w_debuglog.c__dw_debuglog dw_debuglog
	{
		get { return (c__w_debuglog.c__dw_debuglog)base.dw_debuglog; }
		set { base.dw_debuglog = value; }
	}
	public new c__w_debuglog.c__cb_print cb_print
	{
		get { return (c__w_debuglog.c__cb_print)base.cb_print; }
		set { base.cb_print = value; }
	}
	public new c__w_debuglog.c__cb_clear cb_clear
	{
		get { return (c__w_debuglog.c__cb_clear)base.cb_clear; }
		set { base.cb_clear = value; }
	}
	public new c__w_debuglog.c__cb_close cb_close
	{
		get { return (c__w_debuglog.c__cb_close)base.cb_close; }
		set { base.cb_close = value; }
	}
	public new c__w_debuglog.c__cb_dlghelp cb_dlghelp
	{
		get { return (c__w_debuglog.c__cb_dlghelp)base.cb_dlghelp; }
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

	#line 1 "w_debuglog.dw_debuglog"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_debuglog")]
	public new class c__dw_debuglog : c__pfc_w_debuglog.c__dw_debuglog
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__dw_debuglog()
		{
			_init();
		}

	}


	#line 1 "w_debuglog.cb_print"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_print")]
	public new class c__cb_print : c__pfc_w_debuglog.c__cb_print
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_print()
		{
			_init();
		}

	}


	#line 1 "w_debuglog.cb_clear"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_clear")]
	public new class c__cb_clear : c__pfc_w_debuglog.c__cb_clear
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_clear()
		{
			_init();
		}

	}


	#line 1 "w_debuglog.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public new class c__cb_close : c__pfc_w_debuglog.c__cb_close
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_close()
		{
			_init();
		}

	}


	#line 1 "w_debuglog.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public new class c__cb_dlghelp : c__pfc_w_debuglog.c__cb_dlghelp
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

	public c__w_debuglog()
	{
		_init();
	}

}
 