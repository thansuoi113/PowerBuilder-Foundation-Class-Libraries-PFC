//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfeutil.pbl\\pfeutil.pblx\\u_tabpg_dwproperty_srvfind.sru"
#line hidden
#line 1 "u_tabpg_dwproperty_srvfind"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_tabpg_dwproperty_srvfind",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_tabpg_dwproperty_srvfind")]
public class c__u_tabpg_dwproperty_srvfind : c__pfc_u_tabpg_dwproperty_srvfind
{
	#line hidden
	public new c__u_tabpg_dwproperty_srvfind.c__cbx_allowfinddlg cbx_allowfinddlg
	{
		get { return (c__u_tabpg_dwproperty_srvfind.c__cbx_allowfinddlg)base.cbx_allowfinddlg; }
		set { base.cbx_allowfinddlg = value; }
	}
	public new c__u_tabpg_dwproperty_srvfind.c__cbx_allowreplacedlg cbx_allowreplacedlg
	{
		get { return (c__u_tabpg_dwproperty_srvfind.c__cbx_allowreplacedlg)base.cbx_allowreplacedlg; }
		set { base.cbx_allowreplacedlg = value; }
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

	#line 1 "u_tabpg_dwproperty_srvfind.cbx_allowfinddlg"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_allowfinddlg")]
	public new class c__cbx_allowfinddlg : c__pfc_u_tabpg_dwproperty_srvfind.c__cbx_allowfinddlg
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_allowfinddlg()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_srvfind.cbx_allowreplacedlg"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_allowreplacedlg")]
	public new class c__cbx_allowreplacedlg : c__pfc_u_tabpg_dwproperty_srvfind.c__cbx_allowreplacedlg
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_allowreplacedlg()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);

		OnInitialUpdate();
	}

	public c__u_tabpg_dwproperty_srvfind()
	{
		_init();
	}

}
 