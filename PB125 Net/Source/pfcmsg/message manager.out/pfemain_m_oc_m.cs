//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfemain.pbl\\pfemain.pblx\\m_oc.srm"
#line hidden
#line 1 "m_oc"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("m_oc",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\pfcmsg\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="m_oc")]
public class c__m_oc : c__pfc_m_oc
{
	#line hidden
	public new c__m_oc.c__m_object m_object
	{
		get { return (c__m_oc.c__m_object)base.m_object; }
		set { base.m_object = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__pfcmsg.GetCurrentApplication().m_oc = this;
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

	#line 1 "m_oc.m_object"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_object")]
	public new class c__m_object : c__pfc_m_oc.c__m_object
	{
		#line hidden
		public new c__m_oc.c__m_object.c__m_edit m_edit
		{
			get { return (c__m_oc.c__m_object.c__m_edit)base.m_edit; }
			set { base.m_edit = value; }
		}
		public new c__m_oc.c__m_object.c__m_open m_open
		{
			get { return (c__m_oc.c__m_object.c__m_open)base.m_open; }
			set { base.m_open = value; }
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

		#line 1 "m_object.m_edit"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_edit")]
		public new class c__m_edit : c__pfc_m_oc.c__m_object.c__m_edit
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

			public c__m_edit()
			{
				_init();
			}

		}


		#line 1 "m_object.m_open"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_open")]
		public new class c__m_open : c__pfc_m_oc.c__m_object.c__m_open
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


		#line 1 "m_object.m_dash11"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash11")]
		public new class c__m_dash11 : c__pfc_m_oc.c__m_object.c__m_dash11
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

			public c__m_dash11()
			{
				_init();
			}

		}


		#line 1 "m_object.m_cut"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cut")]
		public new class c__m_cut : c__pfc_m_oc.c__m_object.c__m_cut
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


		#line 1 "m_object.m_copy"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_copy")]
		public new class c__m_copy : c__pfc_m_oc.c__m_object.c__m_copy
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


		#line 1 "m_object.m_paste"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_paste")]
		public new class c__m_paste : c__pfc_m_oc.c__m_object.c__m_paste
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


		void _init()
		{
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		}

		public c__m_object()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__m_oc()
	{
		_init();
	}

}
 