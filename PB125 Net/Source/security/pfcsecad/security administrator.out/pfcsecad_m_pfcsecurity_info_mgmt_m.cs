//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx\\m_pfcsecurity_info_mgmt.srm"
#line hidden
#line 1 "m_pfcsecurity_info_mgmt"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("m_pfcsecurity_info_mgmt",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="m_pfcsecurity_info_mgmt")]
public class c__m_pfcsecurity_info_mgmt : c__m_pfcsecurity_master
{
	#line hidden
	public new c__m_pfcsecurity_info_mgmt.c__m_file m_file
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_file)base.m_file; }
		set { base.m_file = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_edit m_edit
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_edit)base.m_edit; }
		set { base.m_edit = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_view m_view
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_view)base.m_view; }
		set { base.m_view = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_insert m_insert
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_insert)base.m_insert; }
		set { base.m_insert = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_tools m_tools
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_tools)base.m_tools; }
		set { base.m_tools = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_window m_window
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_window)base.m_window; }
		set { base.m_window = value; }
	}
	public new c__m_pfcsecurity_info_mgmt.c__m_help m_help
	{
		get { return (c__m_pfcsecurity_info_mgmt.c__m_help)base.m_help; }
		set { base.m_help = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__pfcsecurity_admin.GetCurrentApplication().m_pfcsecurity_info_mgmt = this;
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

	#line 1 "m_pfcsecurity_info_mgmt.m_insert"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_insert")]
	public new class c__m_insert : c__m_pfcsecurity_master.c__m_insert
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
			this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line hidden
			this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}

		#line 1 "m_insert.m_insertfile"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_insertfile")]
		public new class c__m_insertfile : c__m_pfcsecurity_master.c__m_insert.c__m_insertfile
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_insertfile()
			{
				_init();
			}

		}


		#line 1 "m_insert.m_picture"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_picture")]
		public new class c__m_picture : c__m_pfcsecurity_master.c__m_insert.c__m_picture
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_picture()
			{
				_init();
			}

		}


		#line 1 "m_insert.m_dash41"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash41")]
		public new class c__m_dash41 : c__m_pfcsecurity_master.c__m_insert.c__m_dash41
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash41()
			{
				_init();
			}

		}


		#line 1 "m_insert.m_object"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_object")]
		public new class c__m_object : c__m_pfcsecurity_master.c__m_insert.c__m_object
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
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
		}

		public c__m_insert()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_file"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_file")]
	public new class c__m_file : c__m_pfcsecurity_master.c__m_file
	{
		#line hidden

		#line 1 "m_file.m_new"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_new")]
		public new class c__m_new : c__m_pfcsecurity_master.c__m_file.c__m_new
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
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


		#line 1 "m_file.m_open"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_open")]
		public new class c__m_open : c__m_pfcsecurity_master.c__m_file.c__m_open
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
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


		#line 1 "m_file.m_close"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_close")]
		public new class c__m_close : c__m_pfcsecurity_master.c__m_file.c__m_close
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
				this.ToolbarItemVisible = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_close()
			{
				_init();
			}

		}


		#line 1 "m_file.m_saveas"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_saveas")]
		public new class c__m_saveas : c__m_pfcsecurity_master.c__m_file.c__m_saveas
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_saveas()
			{
				_init();
			}

		}


		#line 1 "m_file.m_printpreview"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_printpreview")]
		public new class c__m_printpreview : c__m_pfcsecurity_master.c__m_file.c__m_printpreview
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_printpreview()
			{
				_init();
			}

		}


		#line 1 "m_file.m_dash13"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash13")]
		public new class c__m_dash13 : c__m_pfcsecurity_master.c__m_file.c__m_dash13
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash13()
			{
				_init();
			}

		}


		#line 1 "m_file.m_delete"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_delete")]
		public new class c__m_delete : c__m_pfcsecurity_master.c__m_file.c__m_delete
		{
			#line hidden

			void _init()
			{
			}

			public c__m_delete()
			{
				_init();
			}

		}


		#line 1 "m_file.m_scanapplication"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_scanapplication")]
		public new class c__m_scanapplication : c__m_pfcsecurity_master.c__m_file.c__m_scanapplication
		{
			#line hidden

			void _init()
			{
			}

			public c__m_scanapplication()
			{
				_init();
			}

		}


		#line 1 "m_file.m_edittemplates"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_edittemplates")]
		public new class c__m_edittemplates : c__m_pfcsecurity_master.c__m_file.c__m_edittemplates
		{
			#line hidden

			void _init()
			{
			}

			public c__m_edittemplates()
			{
				_init();
			}

		}


		#line 1 "m_file.m_usersgroups"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_usersgroups")]
		public new class c__m_usersgroups : c__m_pfcsecurity_master.c__m_file.c__m_usersgroups
		{
			#line hidden

			void _init()
			{
			}

			public c__m_usersgroups()
			{
				_init();
			}

		}


		#line 1 "m_file.m_configuresecurity"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_configuresecurity")]
		public new class c__m_configuresecurity : c__m_pfcsecurity_master.c__m_file.c__m_configuresecurity
		{
			#line hidden

			void _init()
			{
			}

			public c__m_configuresecurity()
			{
				_init();
			}

		}


		#line 1 "m_file.m_reports"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_reports")]
		public new class c__m_reports : c__m_pfcsecurity_master.c__m_file.c__m_reports
		{
			#line hidden

			#line 1 "m_reports.m_userreport"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_userreport")]
			public new class c__m_userreport : c__m_pfcsecurity_master.c__m_file.c__m_reports.c__m_userreport
			{
				#line hidden

				void _init()
				{
				}

				public c__m_userreport()
				{
					_init();
				}

			}


			#line 1 "m_reports.m_windowreport"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_windowreport")]
			public new class c__m_windowreport : c__m_pfcsecurity_master.c__m_file.c__m_reports.c__m_windowreport
			{
				#line hidden

				void _init()
				{
				}

				public c__m_windowreport()
				{
					_init();
				}

			}


			void _init()
			{
			}

			public c__m_reports()
			{
				_init();
			}

		}


		#line 1 "m_file.m_dash11"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash11")]
		public new class c__m_dash11 : c__m_pfcsecurity_master.c__m_file.c__m_dash11
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash11()
			{
				_init();
			}

		}


		#line 1 "m_file.m_save"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_save")]
		public new class c__m_save : c__m_pfcsecurity_master.c__m_file.c__m_save
		{
			#line hidden

			void _init()
			{
			}

			public c__m_save()
			{
				_init();
			}

		}


		#line 1 "m_file.m_dash12"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash12")]
		public new class c__m_dash12 : c__m_pfcsecurity_master.c__m_file.c__m_dash12
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash12()
			{
				_init();
			}

		}


		#line 1 "m_file.m_print"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_print")]
		public new class c__m_print : c__m_pfcsecurity_master.c__m_file.c__m_print
		{
			#line hidden

			void _init()
			{
			}

			public c__m_print()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pagesetup"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pagesetup")]
		public new class c__m_pagesetup : c__m_pfcsecurity_master.c__m_file.c__m_pagesetup
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pagesetup()
			{
				_init();
			}

		}


		#line 1 "m_file.m_printimmediate"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_printimmediate")]
		public new class c__m_printimmediate : c__m_pfcsecurity_master.c__m_file.c__m_printimmediate
		{
			#line hidden

			void _init()
			{
			}

			public c__m_printimmediate()
			{
				_init();
			}

		}


		#line 1 "m_file.m_properties"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_properties")]
		public new class c__m_properties : c__m_pfcsecurity_master.c__m_file.c__m_properties
		{
			#line hidden

			void _init()
			{
			}

			public c__m_properties()
			{
				_init();
			}

		}


		#line 1 "m_file.m_dash14"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash14")]
		public new class c__m_dash14 : c__m_pfcsecurity_master.c__m_file.c__m_dash14
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash14()
			{
				_init();
			}

		}


		#line 1 "m_file.m_exit"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_exit")]
		public new class c__m_exit : c__m_pfcsecurity_master.c__m_file.c__m_exit
		{
			#line hidden

			void _init()
			{
			}

			public c__m_exit()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmrudash1"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmrudash1")]
		public new class c__m_pfcmrudash1 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmrudash1
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmrudash1()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmru1"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmru1")]
		public new class c__m_pfcmru1 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmru1
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmru1()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmru2"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmru2")]
		public new class c__m_pfcmru2 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmru2
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmru2()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmru3"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmru3")]
		public new class c__m_pfcmru3 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmru3
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmru3()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmru4"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmru4")]
		public new class c__m_pfcmru4 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmru4
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmru4()
			{
				_init();
			}

		}


		#line 1 "m_file.m_pfcmru5"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pfcmru5")]
		public new class c__m_pfcmru5 : c__m_pfcsecurity_master.c__m_file.c__m_pfcmru5
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pfcmru5()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_file()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_edit"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_edit")]
	public new class c__m_edit : c__m_pfcsecurity_master.c__m_edit
	{
		#line hidden

		#line 1 "m_edit.m_dash23"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash23")]
		public new class c__m_dash23 : c__m_pfcsecurity_master.c__m_edit.c__m_dash23
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash23()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_find"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_find")]
		public new class c__m_find : c__m_pfcsecurity_master.c__m_edit.c__m_find
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
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


		#line 1 "m_edit.m_replace"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_replace")]
		public new class c__m_replace : c__m_pfcsecurity_master.c__m_edit.c__m_replace
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_replace()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_dash24"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash24")]
		public new class c__m_dash24 : c__m_pfcsecurity_master.c__m_edit.c__m_dash24
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash24()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_updatelinks"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_updatelinks")]
		public new class c__m_updatelinks : c__m_pfcsecurity_master.c__m_edit.c__m_updatelinks
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_updatelinks()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_object1"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_object1")]
		public new class c__m_object1 : c__m_pfcsecurity_master.c__m_edit.c__m_object1
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "m_object1.m_edit1"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_edit1")]
			public new class c__m_edit1 : c__m_pfcsecurity_master.c__m_edit.c__m_object1.c__m_edit1
			{
				#line hidden

				void _init()
				{
				}

				public c__m_edit1()
				{
					_init();
				}

			}


			#line 1 "m_object1.m_open1"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_open1")]
			public new class c__m_open1 : c__m_pfcsecurity_master.c__m_edit.c__m_object1.c__m_open1
			{
				#line hidden

				void _init()
				{
				}

				public c__m_open1()
				{
					_init();
				}

			}


			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_object1()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_undo"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_undo")]
		public new class c__m_undo : c__m_pfcsecurity_master.c__m_edit.c__m_undo
		{
			#line hidden

			void _init()
			{
			}

			public c__m_undo()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_dash21"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash21")]
		public new class c__m_dash21 : c__m_pfcsecurity_master.c__m_edit.c__m_dash21
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash21()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_cut"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cut")]
		public new class c__m_cut : c__m_pfcsecurity_master.c__m_edit.c__m_cut
		{
			#line hidden

			void _init()
			{
			}

			public c__m_cut()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_copy"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_copy")]
		public new class c__m_copy : c__m_pfcsecurity_master.c__m_edit.c__m_copy
		{
			#line hidden

			void _init()
			{
			}

			public c__m_copy()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_paste"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_paste")]
		public new class c__m_paste : c__m_pfcsecurity_master.c__m_edit.c__m_paste
		{
			#line hidden

			void _init()
			{
			}

			public c__m_paste()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_pastespecial"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_pastespecial")]
		public new class c__m_pastespecial : c__m_pfcsecurity_master.c__m_edit.c__m_pastespecial
		{
			#line hidden

			void _init()
			{
			}

			public c__m_pastespecial()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_clear"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_clear")]
		public new class c__m_clear : c__m_pfcsecurity_master.c__m_edit.c__m_clear
		{
			#line hidden

			void _init()
			{
			}

			public c__m_clear()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_dash22"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash22")]
		public new class c__m_dash22 : c__m_pfcsecurity_master.c__m_edit.c__m_dash22
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash22()
			{
				_init();
			}

		}


		#line 1 "m_edit.m_selectall"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_selectall")]
		public new class c__m_selectall : c__m_pfcsecurity_master.c__m_edit.c__m_selectall
		{
			#line hidden

			void _init()
			{
			}

			public c__m_selectall()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_edit()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_view"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_view")]
	public new class c__m_view : c__m_pfcsecurity_master.c__m_view
	{
		#line hidden

		#line 1 "m_view.m_ruler"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_ruler")]
		public new class c__m_ruler : c__m_pfcsecurity_master.c__m_view.c__m_ruler
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_ruler()
			{
				_init();
			}

		}


		#line 1 "m_view.m_dash31"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash31")]
		public new class c__m_dash31 : c__m_pfcsecurity_master.c__m_view.c__m_dash31
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash31()
			{
				_init();
			}

		}


		#line 1 "m_view.m_filter"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_filter")]
		public new class c__m_filter : c__m_pfcsecurity_master.c__m_view.c__m_filter
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_filter()
			{
				_init();
			}

		}


		#line 1 "m_view.m_dash36"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash36")]
		public new class c__m_dash36 : c__m_pfcsecurity_master.c__m_view.c__m_dash36
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_dash36()
			{
				_init();
			}

		}


		#line 1 "m_view.m_zoom"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_zoom")]
		public new class c__m_zoom : c__m_pfcsecurity_master.c__m_view.c__m_zoom
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_zoom()
			{
				_init();
			}

		}


		#line 1 "m_view.m_largeicon"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_largeicon")]
		public new class c__m_largeicon : c__m_pfcsecurity_master.c__m_view.c__m_largeicon
		{
			#line hidden

			void _init()
			{
			}

			public c__m_largeicon()
			{
				_init();
			}

		}


		#line 1 "m_view.m_smallicons"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_smallicons")]
		public new class c__m_smallicons : c__m_pfcsecurity_master.c__m_view.c__m_smallicons
		{
			#line hidden

			void _init()
			{
			}

			public c__m_smallicons()
			{
				_init();
			}

		}


		#line 1 "m_view.m_list"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_list")]
		public new class c__m_list : c__m_pfcsecurity_master.c__m_view.c__m_list
		{
			#line hidden

			void _init()
			{
			}

			public c__m_list()
			{
				_init();
			}

		}


		#line 1 "m_view.m_details"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_details")]
		public new class c__m_details : c__m_pfcsecurity_master.c__m_view.c__m_details
		{
			#line hidden

			void _init()
			{
			}

			public c__m_details()
			{
				_init();
			}

		}


		#line 1 "m_view.m_dash32"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash32")]
		public new class c__m_dash32 : c__m_pfcsecurity_master.c__m_view.c__m_dash32
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash32()
			{
				_init();
			}

		}


		#line 1 "m_view.m_arrangeicons"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_arrangeicons")]
		public new class c__m_arrangeicons : c__m_pfcsecurity_master.c__m_view.c__m_arrangeicons
		{
			#line hidden

			#line 1 "m_arrangeicons.m_by1"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_by1")]
			public new class c__m_by1 : c__m_pfcsecurity_master.c__m_view.c__m_arrangeicons.c__m_by1
			{
				#line hidden

				void _init()
				{
				}

				public c__m_by1()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_dash33"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_dash33")]
			public new class c__m_dash33 : c__m_pfcsecurity_master.c__m_view.c__m_arrangeicons.c__m_dash33
			{
				#line hidden

				void _init()
				{
				}

				public c__m_dash33()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_autoarrange"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_autoarrange")]
			public new class c__m_autoarrange : c__m_pfcsecurity_master.c__m_view.c__m_arrangeicons.c__m_autoarrange
			{
				#line hidden

				void _init()
				{
				}

				public c__m_autoarrange()
				{
					_init();
				}

			}


			void _init()
			{
			}

			public c__m_arrangeicons()
			{
				_init();
			}

		}


		#line 1 "m_view.m_dash34"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash34")]
		public new class c__m_dash34 : c__m_pfcsecurity_master.c__m_view.c__m_dash34
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash34()
			{
				_init();
			}

		}


		#line 1 "m_view.m_first"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_first")]
		public new class c__m_first : c__m_pfcsecurity_master.c__m_view.c__m_first
		{
			#line hidden

			void _init()
			{
			}

			public c__m_first()
			{
				_init();
			}

		}


		#line 1 "m_view.m_priorpage"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_priorpage")]
		public new class c__m_priorpage : c__m_pfcsecurity_master.c__m_view.c__m_priorpage
		{
			#line hidden

			void _init()
			{
			}

			public c__m_priorpage()
			{
				_init();
			}

		}


		#line 1 "m_view.m_nextpage"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_nextpage")]
		public new class c__m_nextpage : c__m_pfcsecurity_master.c__m_view.c__m_nextpage
		{
			#line hidden

			void _init()
			{
			}

			public c__m_nextpage()
			{
				_init();
			}

		}


		#line 1 "m_view.m_lastpage"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_lastpage")]
		public new class c__m_lastpage : c__m_pfcsecurity_master.c__m_view.c__m_lastpage
		{
			#line hidden

			void _init()
			{
			}

			public c__m_lastpage()
			{
				_init();
			}

		}


		#line 1 "m_view.m_dash35"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash35")]
		public new class c__m_dash35 : c__m_pfcsecurity_master.c__m_view.c__m_dash35
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash35()
			{
				_init();
			}

		}


		#line 1 "m_view.m_sort"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_sort")]
		public new class c__m_sort : c__m_pfcsecurity_master.c__m_view.c__m_sort
		{
			#line hidden

			void _init()
			{
			}

			public c__m_sort()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_view()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_tools"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_tools")]
	public new class c__m_tools : c__m_pfcsecurity_master.c__m_tools
	{
		#line hidden

		#line 1 "m_tools.m_toolbars"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_toolbars")]
		public new class c__m_toolbars : c__m_pfcsecurity_master.c__m_tools.c__m_toolbars
		{
			#line hidden

			void _init()
			{
			}

			public c__m_toolbars()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_tools()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_window"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_window")]
	public new class c__m_window : c__m_pfcsecurity_master.c__m_window
	{
		#line hidden

		#line 1 "m_window.m_cascade"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cascade")]
		public new class c__m_cascade : c__m_pfcsecurity_master.c__m_window.c__m_cascade
		{
			#line hidden

			void _init()
			{
			}

			public c__m_cascade()
			{
				_init();
			}

		}


		#line 1 "m_window.m_tilehorizontal"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_tilehorizontal")]
		public new class c__m_tilehorizontal : c__m_pfcsecurity_master.c__m_window.c__m_tilehorizontal
		{
			#line hidden

			void _init()
			{
			}

			public c__m_tilehorizontal()
			{
				_init();
			}

		}


		#line 1 "m_window.m_tilevertical"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_tilevertical")]
		public new class c__m_tilevertical : c__m_pfcsecurity_master.c__m_window.c__m_tilevertical
		{
			#line hidden

			void _init()
			{
			}

			public c__m_tilevertical()
			{
				_init();
			}

		}


		#line 1 "m_window.m_layer"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_layer")]
		public new class c__m_layer : c__m_pfcsecurity_master.c__m_window.c__m_layer
		{
			#line hidden

			void _init()
			{
			}

			public c__m_layer()
			{
				_init();
			}

		}


		#line 1 "m_window.m_dash51"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash51")]
		public new class c__m_dash51 : c__m_pfcsecurity_master.c__m_window.c__m_dash51
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash51()
			{
				_init();
			}

		}


		#line 1 "m_window.m_minimizeall"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_minimizeall")]
		public new class c__m_minimizeall : c__m_pfcsecurity_master.c__m_window.c__m_minimizeall
		{
			#line hidden

			void _init()
			{
			}

			public c__m_minimizeall()
			{
				_init();
			}

		}


		#line 1 "m_window.m_undoarrange"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_undoarrange")]
		public new class c__m_undoarrange : c__m_pfcsecurity_master.c__m_window.c__m_undoarrange
		{
			#line hidden

			void _init()
			{
			}

			public c__m_undoarrange()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_window()
		{
			_init();
		}

	}


	#line 1 "m_pfcsecurity_info_mgmt.m_help"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_help")]
	public new class c__m_help : c__m_pfcsecurity_master.c__m_help
	{
		#line hidden

		#line 1 "m_help.m_helptopics"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_helptopics")]
		public new class c__m_helptopics : c__m_pfcsecurity_master.c__m_help.c__m_helptopics
		{
			#line hidden

			void _init()
			{
			}

			public c__m_helptopics()
			{
				_init();
			}

		}


		#line 1 "m_help.m_dash61"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash61")]
		public new class c__m_dash61 : c__m_pfcsecurity_master.c__m_help.c__m_dash61
		{
			#line hidden

			void _init()
			{
			}

			public c__m_dash61()
			{
				_init();
			}

		}


		#line 1 "m_help.m_about"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_about")]
		public new class c__m_about : c__m_pfcsecurity_master.c__m_help.c__m_about
		{
			#line hidden

			void _init()
			{
			}

			public c__m_about()
			{
				_init();
			}

		}


		void _init()
		{
		}

		public c__m_help()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__m_pfcsecurity_info_mgmt()
	{
		_init();
	}

}
 