//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfeutil.pbl\\pfeutil.pblx\\u_tabpg_dwproperty_srvdropdownsearch.sru"
#line hidden
#line 1 "u_tabpg_dwproperty_srvdropdownsearch"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_tabpg_dwproperty_srvdropdownsearch",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_tabpg_dwproperty_srvdropdownsearch")]
public class c__u_tabpg_dwproperty_srvdropdownsearch : c__pfc_u_tabpg_dwproperty_srvdropdownsearch
{
	#line hidden
	public new c__u_tabpg_dwproperty_srvdropdownsearch.c__st_registeredcolumns st_registeredcolumns
	{
		get { return (c__u_tabpg_dwproperty_srvdropdownsearch.c__st_registeredcolumns)base.st_registeredcolumns; }
		set { base.st_registeredcolumns = value; }
	}
	public new c__u_tabpg_dwproperty_srvdropdownsearch.c__lb_registeredcolumns lb_registeredcolumns
	{
		get { return (c__u_tabpg_dwproperty_srvdropdownsearch.c__lb_registeredcolumns)base.lb_registeredcolumns; }
		set { base.lb_registeredcolumns = value; }
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

	#line 1 "u_tabpg_dwproperty_srvdropdownsearch.st_registeredcolumns"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_registeredcolumns")]
	public new class c__st_registeredcolumns : c__pfc_u_tabpg_dwproperty_srvdropdownsearch.c__st_registeredcolumns
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_registeredcolumns()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_srvdropdownsearch.lb_registeredcolumns"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="lb_registeredcolumns")]
	public new class c__lb_registeredcolumns : c__pfc_u_tabpg_dwproperty_srvdropdownsearch.c__lb_registeredcolumns
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__lb_registeredcolumns()
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

	public c__u_tabpg_dwproperty_srvdropdownsearch()
	{
		_init();
	}

}
 