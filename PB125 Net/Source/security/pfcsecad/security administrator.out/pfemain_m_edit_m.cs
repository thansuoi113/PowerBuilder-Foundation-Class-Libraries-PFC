//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfemain.pbl\\pfemain.pblx\\m_edit.srm"
#line hidden
#line 1 "m_edit"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("m_edit",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="m_edit")]
public class c__m_edit : c__pfc_m_edit
{
	#line hidden
	public new c__m_edit.c__m_edititem m_edititem
	{
		get { return (c__m_edit.c__m_edititem)base.m_edititem; }
		set { base.m_edititem = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__pfcsecurity_admin.GetCurrentApplication().m_edit = this;
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

	#line 1 "m_edit.m_edititem"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_edititem")]
	public new class c__m_edititem : c__pfc_m_edit.c__m_edititem
	{
		#line hidden
		public new c__m_edit.c__m_edititem.c__m_copy m_copy
		{
			get { return (c__m_edit.c__m_edititem.c__m_copy)base.m_copy; }
			set { base.m_copy = value; }
		}
		public new c__m_edit.c__m_edititem.c__m_cut m_cut
		{
			get { return (c__m_edit.c__m_edititem.c__m_cut)base.m_cut; }
			set { base.m_cut = value; }
		}
		public new c__m_edit.c__m_edititem.c__m_paste m_paste
		{
			get { return (c__m_edit.c__m_edititem.c__m_paste)base.m_paste; }
			set { base.m_paste = value; }
		}
		public new c__m_edit.c__m_edititem.c__m_selectall m_selectall
		{
			get { return (c__m_edit.c__m_edititem.c__m_selectall)base.m_selectall; }
			set { base.m_selectall = value; }
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

		#line 1 "m_edititem.m_cut"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cut")]
		public new class c__m_cut : c__pfc_m_edit.c__m_edititem.c__m_cut
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


		#line 1 "m_edititem.m_copy"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_copy")]
		public new class c__m_copy : c__pfc_m_edit.c__m_edititem.c__m_copy
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


		#line 1 "m_edititem.m_paste"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_paste")]
		public new class c__m_paste : c__pfc_m_edit.c__m_edititem.c__m_paste
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


		#line 1 "m_edititem.m_selectall"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_selectall")]
		public new class c__m_selectall : c__pfc_m_edit.c__m_edititem.c__m_selectall
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

			public c__m_selectall()
			{
				_init();
			}

		}


		void _init()
		{
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		}

		public c__m_edititem()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__m_edit()
	{
		_init();
	}

}
 