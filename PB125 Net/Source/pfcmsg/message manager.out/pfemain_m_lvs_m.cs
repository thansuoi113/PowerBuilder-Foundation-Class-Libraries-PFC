//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfemain.pbl\\pfemain.pblx\\m_lvs.srm"
#line hidden
#line 1 "m_lvs"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("m_lvs",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\pfcmsg\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="m_lvs")]
public class c__m_lvs : c__pfc_m_lvs
{
	#line hidden
	public new c__m_lvs.c__m_viewitem m_viewitem
	{
		get { return (c__m_lvs.c__m_viewitem)base.m_viewitem; }
		set { base.m_viewitem = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__pfcmsg.GetCurrentApplication().m_lvs = this;
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

	#line 1 "m_lvs.m_viewitem"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_viewitem")]
	public new class c__m_viewitem : c__pfc_m_lvs.c__m_viewitem
	{
		#line hidden
		public new c__m_lvs.c__m_viewitem.c__m_arrangeicons m_arrangeicons
		{
			get { return (c__m_lvs.c__m_viewitem.c__m_arrangeicons)base.m_arrangeicons; }
			set { base.m_arrangeicons = value; }
		}
		public new c__m_lvs.c__m_viewitem.c__m_delete m_delete
		{
			get { return (c__m_lvs.c__m_viewitem.c__m_delete)base.m_delete; }
			set { base.m_delete = value; }
		}
		public new c__m_lvs.c__m_viewitem.c__m_dash15 m_dash15
		{
			get { return (c__m_lvs.c__m_viewitem.c__m_dash15)base.m_dash15; }
			set { base.m_dash15 = value; }
		}
		public new c__m_lvs.c__m_viewitem.c__m_rename m_rename
		{
			get { return (c__m_lvs.c__m_viewitem.c__m_rename)base.m_rename; }
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

		#line 1 "m_viewitem.m_viewdisplay"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_viewdisplay")]
		public new class c__m_viewdisplay : c__pfc_m_lvs.c__m_viewitem.c__m_viewdisplay
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

			#line 1 "m_viewdisplay.m_largeicon"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_largeicon")]
			public new class c__m_largeicon : c__pfc_m_lvs.c__m_viewitem.c__m_viewdisplay.c__m_largeicon
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

				public c__m_largeicon()
				{
					_init();
				}

			}


			#line 1 "m_viewdisplay.m_smallicon"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_smallicon")]
			public new class c__m_smallicon : c__pfc_m_lvs.c__m_viewitem.c__m_viewdisplay.c__m_smallicon
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

				public c__m_smallicon()
				{
					_init();
				}

			}


			#line 1 "m_viewdisplay.m_list"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_list")]
			public new class c__m_list : c__pfc_m_lvs.c__m_viewitem.c__m_viewdisplay.c__m_list
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

				public c__m_list()
				{
					_init();
				}

			}


			#line 1 "m_viewdisplay.m_details"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_details")]
			public new class c__m_details : c__pfc_m_lvs.c__m_viewitem.c__m_viewdisplay.c__m_details
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

				public c__m_details()
				{
					_init();
				}

			}


			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_viewdisplay()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash11"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash11")]
		public new class c__m_dash11 : c__pfc_m_lvs.c__m_viewitem.c__m_dash11
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


		#line 1 "m_viewitem.m_arrangeicons"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_arrangeicons")]
		public new class c__m_arrangeicons : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons
		{
			#line hidden
			public new c__m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_autoarrange m_autoarrange
			{
				get { return (c__m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_autoarrange)base.m_autoarrange; }
				set { base.m_autoarrange = value; }
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

			#line 1 "m_arrangeicons.m_1"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_1")]
			public new class c__m_1 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_1
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

				public c__m_1()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_2"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_2")]
			public new class c__m_2 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_2
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

				public c__m_2()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_3"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_3")]
			public new class c__m_3 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_3
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

				public c__m_3()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_4"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_4")]
			public new class c__m_4 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_4
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

				public c__m_4()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_5"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_5")]
			public new class c__m_5 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_5
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

				public c__m_5()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_6"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_6")]
			public new class c__m_6 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_6
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

				public c__m_6()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_7"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_7")]
			public new class c__m_7 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_7
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

				public c__m_7()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_8"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_8")]
			public new class c__m_8 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_8
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

				public c__m_8()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_9"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_9")]
			public new class c__m_9 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_9
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

				public c__m_9()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_10"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_10")]
			public new class c__m_10 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_10
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

				public c__m_10()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_dash12"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_dash12")]
			public new class c__m_dash12 : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_dash12
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

				public c__m_dash12()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_autoarrange"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_autoarrange")]
			public new class c__m_autoarrange : c__pfc_m_lvs.c__m_viewitem.c__m_arrangeicons.c__m_autoarrange
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

				public c__m_autoarrange()
				{
					_init();
				}

			}


			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			}

			public c__m_arrangeicons()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash13"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash13")]
		public new class c__m_dash13 : c__pfc_m_lvs.c__m_viewitem.c__m_dash13
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

			public c__m_dash13()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_selectall"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_selectall")]
		public new class c__m_selectall : c__pfc_m_lvs.c__m_viewitem.c__m_selectall
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


		#line 1 "m_viewitem.m_invertselection"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_invertselection")]
		public new class c__m_invertselection : c__pfc_m_lvs.c__m_viewitem.c__m_invertselection
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

			public c__m_invertselection()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash14"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash14")]
		public new class c__m_dash14 : c__pfc_m_lvs.c__m_viewitem.c__m_dash14
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
		public new class c__m_cut : c__pfc_m_lvs.c__m_viewitem.c__m_cut
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
		public new class c__m_copy : c__pfc_m_lvs.c__m_viewitem.c__m_copy
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
		public new class c__m_paste : c__pfc_m_lvs.c__m_viewitem.c__m_paste
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
		public new class c__m_clear : c__pfc_m_lvs.c__m_viewitem.c__m_clear
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
		public new class c__m_dash15 : c__pfc_m_lvs.c__m_viewitem.c__m_dash15
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
		public new class c__m_new : c__pfc_m_lvs.c__m_viewitem.c__m_new
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
		public new class c__m_delete : c__pfc_m_lvs.c__m_viewitem.c__m_delete
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
		public new class c__m_rename : c__pfc_m_lvs.c__m_viewitem.c__m_rename
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
		public new class c__m_dash16 : c__pfc_m_lvs.c__m_viewitem.c__m_dash16
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
		public new class c__m_properties : c__pfc_m_lvs.c__m_viewitem.c__m_properties
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

	public c__m_lvs()
	{
		_init();
	}

}
 