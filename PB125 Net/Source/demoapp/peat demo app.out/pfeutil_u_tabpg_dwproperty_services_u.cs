//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfeutil.pbl\\pfeutil.pblx\\u_tabpg_dwproperty_services.sru"
#line hidden
#line 1 "u_tabpg_dwproperty_services"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_tabpg_dwproperty_services",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_tabpg_dwproperty_services")]
public class c__u_tabpg_dwproperty_services : c__pfc_u_tabpg_dwproperty_services
{
	#line hidden
	public new c__u_tabpg_dwproperty_services.c__dw_services dw_services
	{
		get { return (c__u_tabpg_dwproperty_services.c__dw_services)base.dw_services; }
		set { base.dw_services = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__st_servicesavailable st_servicesavailable
	{
		get { return (c__u_tabpg_dwproperty_services.c__st_servicesavailable)base.st_servicesavailable; }
		set { base.st_servicesavailable = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__cb_property cb_property
	{
		get { return (c__u_tabpg_dwproperty_services.c__cb_property)base.cb_property; }
		set { base.cb_property = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__cb_enable cb_enable
	{
		get { return (c__u_tabpg_dwproperty_services.c__cb_enable)base.cb_enable; }
		set { base.cb_enable = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__cb_disable cb_disable
	{
		get { return (c__u_tabpg_dwproperty_services.c__cb_disable)base.cb_disable; }
		set { base.cb_disable = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__mle_description mle_description
	{
		get { return (c__u_tabpg_dwproperty_services.c__mle_description)base.mle_description; }
		set { base.mle_description = value; }
	}
	public new c__u_tabpg_dwproperty_services.c__gb_description gb_description
	{
		get { return (c__u_tabpg_dwproperty_services.c__gb_description)base.gb_description; }
		set { base.gb_description = value; }
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

	#line 1 "u_tabpg_dwproperty_services.dw_services"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_services")]
	public new class c__dw_services : c__pfc_u_tabpg_dwproperty_services.c__dw_services
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__dw_services()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.st_servicesavailable"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_servicesavailable")]
	public new class c__st_servicesavailable : c__pfc_u_tabpg_dwproperty_services.c__st_servicesavailable
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_servicesavailable()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.cb_property"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_property")]
	public new class c__cb_property : c__pfc_u_tabpg_dwproperty_services.c__cb_property
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_property()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.cb_enable"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_enable")]
	public new class c__cb_enable : c__pfc_u_tabpg_dwproperty_services.c__cb_enable
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_enable()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.cb_disable"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_disable")]
	public new class c__cb_disable : c__pfc_u_tabpg_dwproperty_services.c__cb_disable
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_disable()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.mle_description"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_description")]
	public new class c__mle_description : c__pfc_u_tabpg_dwproperty_services.c__mle_description
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__mle_description()
		{
			_init();
		}

	}


	#line 1 "u_tabpg_dwproperty_services.gb_description"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_description")]
	public new class c__gb_description : c__pfc_u_tabpg_dwproperty_services.c__gb_description
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_description()
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

	public c__u_tabpg_dwproperty_services()
	{
		_init();
	}

}
 