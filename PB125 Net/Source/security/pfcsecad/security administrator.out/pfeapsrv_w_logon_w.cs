//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfeapsrv.pbl\\pfeapsrv.pblx\\w_logon.srw"
#line hidden
#line 1 "w_logon"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_logon",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfeapsrv.pbl\\pfeapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_logon")]
public class c__w_logon : c__pfc_w_logon
{
	#line hidden
	public new c__w_logon.c__p_logo p_logo
	{
		get { return (c__w_logon.c__p_logo)base.p_logo; }
		set { base.p_logo = value; }
	}
	public new c__w_logon.c__st_help st_help
	{
		get { return (c__w_logon.c__st_help)base.st_help; }
		set { base.st_help = value; }
	}
	public new c__w_logon.c__cb_ok cb_ok
	{
		get { return (c__w_logon.c__cb_ok)base.cb_ok; }
		set { base.cb_ok = value; }
	}
	public new c__w_logon.c__cb_cancel cb_cancel
	{
		get { return (c__w_logon.c__cb_cancel)base.cb_cancel; }
		set { base.cb_cancel = value; }
	}
	public new c__w_logon.c__sle_userid sle_userid
	{
		get { return (c__w_logon.c__sle_userid)base.sle_userid; }
		set { base.sle_userid = value; }
	}
	public new c__w_logon.c__sle_password sle_password
	{
		get { return (c__w_logon.c__sle_password)base.sle_password; }
		set { base.sle_password = value; }
	}
	public new c__w_logon.c__st_2 st_2
	{
		get { return (c__w_logon.c__st_2)base.st_2; }
		set { base.st_2 = value; }
	}
	public new c__w_logon.c__st_3 st_3
	{
		get { return (c__w_logon.c__st_3)base.st_3; }
		set { base.st_3 = value; }
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

	#line 1 "w_logon.p_logo"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_logo")]
	public new class c__p_logo : c__pfc_w_logon.c__p_logo
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_logo()
		{
			_init();
		}

	}


	#line 1 "w_logon.st_help"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_help")]
	public new class c__st_help : c__pfc_w_logon.c__st_help
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_help()
		{
			_init();
		}

	}


	#line 1 "w_logon.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public new class c__cb_ok : c__pfc_w_logon.c__cb_ok
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


	#line 1 "w_logon.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public new class c__cb_cancel : c__pfc_w_logon.c__cb_cancel
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


	#line 1 "w_logon.sle_userid"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_userid")]
	public new class c__sle_userid : c__pfc_w_logon.c__sle_userid
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_userid()
		{
			_init();
		}

	}


	#line 1 "w_logon.sle_password"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_password")]
	public new class c__sle_password : c__pfc_w_logon.c__sle_password
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_password()
		{
			_init();
		}

	}


	#line 1 "w_logon.st_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_2")]
	public new class c__st_2 : c__pfc_w_logon.c__st_2
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_2()
		{
			_init();
		}

	}


	#line 1 "w_logon.st_3"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_3")]
	public new class c__st_3 : c__pfc_w_logon.c__st_3
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_3()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_logon()
	{
		_init();
	}

}
 