//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfemain.pbl\\pfemain.pblx\\m_tvs.srm"
#line hidden
#line 1 "m_tvs"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("m_tvs",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\pfcapp\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="m_tvs")]
public class c__m_tvs : c__pfc_m_tvs
{
	#line hidden
	public new c__m_tvs.c__m_viewitem m_viewitem
	{
		get { return (c__m_tvs.c__m_viewitem)base.m_viewitem; }
		set { base.m_viewitem = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__generic_pfc_app.GetCurrentApplication().m_tvs = this;
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

	#line 1 "m_tvs.m_viewitem"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_viewitem")]
	public new class c__m_viewitem : c__pfc_m_tvs.c__m_viewitem
	{
		#line hidden
		public new c__m_tvs.c__m_viewitem.c__m_delete m_delete
		{
			get { return (c__m_tvs.c__m_viewitem.c__m_delete)base.m_delete; }
			set { base.m_delete = value; }
		}
		public new c__m_tvs.c__m_viewitem.c__m_rename m_rename
		{
			get { return (c__m_tvs.c__m_viewitem.c__m_rename)base.m_rename; }
			set { base.m_rename = value; }
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("create")]
		public override void create()
		{
			#line hidden
			InitMenu(MenuType.MenuItem);

			#line hidden
			base.create();
			#line hidden
			#line hidden
			this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
			#line hidden
		}

		#line 1 "m_viewitem.m_open"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_open")]
		public new class c__m_open : c__pfc_m_tvs.c__m_viewitem.c__m_open
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_open()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_find"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_find")]
		public new class c__m_find : c__pfc_m_tvs.c__m_viewitem.c__m_find
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_find()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash14"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash14")]
		public new class c__m_dash14 : c__pfc_m_tvs.c__m_viewitem.c__m_dash14
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash14()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_cut"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cut")]
		public new class c__m_cut : c__pfc_m_tvs.c__m_viewitem.c__m_cut
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_cut()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_copy"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_copy")]
		public new class c__m_copy : c__pfc_m_tvs.c__m_viewitem.c__m_copy
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_copy()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_paste"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_paste")]
		public new class c__m_paste : c__pfc_m_tvs.c__m_viewitem.c__m_paste
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_paste()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_clear"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_clear")]
		public new class c__m_clear : c__pfc_m_tvs.c__m_viewitem.c__m_clear
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_clear()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash15"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash15")]
		public new class c__m_dash15 : c__pfc_m_tvs.c__m_viewitem.c__m_dash15
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash15()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_new"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_new")]
		public new class c__m_new : c__pfc_m_tvs.c__m_viewitem.c__m_new
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_new()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_delete"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_delete")]
		public new class c__m_delete : c__pfc_m_tvs.c__m_viewitem.c__m_delete
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_delete()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_rename"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_rename")]
		public new class c__m_rename : c__pfc_m_tvs.c__m_viewitem.c__m_rename
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_rename()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash16"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash16")]
		public new class c__m_dash16 : c__pfc_m_tvs.c__m_viewitem.c__m_dash16
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash16()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_properties"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_properties")]
		public new class c__m_properties : c__pfc_m_tvs.c__m_viewitem.c__m_properties
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				base.create();
				#line hidden
				#line hidden
				this.MergeOption = (new Sybase.PowerBuilder.PBMenuMergeOptionValue(Sybase.PowerBuilder.PBMenuMergeOption.Exclude));
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_properties()
			{
				_init();
			}

		}


		void _init()
		{
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		}

		public c__m_viewitem()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__m_tvs()
	{
		_init();
	}

}
 