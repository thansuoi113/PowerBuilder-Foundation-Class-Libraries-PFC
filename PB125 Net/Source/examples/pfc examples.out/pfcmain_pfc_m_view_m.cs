//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx\\pfc_m_view.srm"
#line hidden
#line 1 "pfc_m_view"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_m_view",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_m_view")]
public class c__pfc_m_view : Sybase.PowerBuilder.WPF.PBMenu
{
	#line hidden
	public c__pfc_m_view.c__m_viewitem m_viewitem = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ilv_parent", null, "pfc_m_view", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.WPF.PBListView ilv_parent = null;

	#line 1 "pfc_m_view.of_setparent(IClistview.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setparent", new string[]{"listview"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setparent(Sybase.PowerBuilder.WPF.PBListView alv_parent)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(alv_parent)))
		#line hidden
		{
			#line 50
			ilv_parent = alv_parent;
			#line hidden
			#line 51
			li_rc = new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		else
		{
			#line 53
			li_rc = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		return li_rc;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		InitMenu(MenuType.MainMenu);

		#line hidden
		c__pfcexamp.GetCurrentApplication().pfc_m_view = this;
		#line hidden
		#line hidden
		this.m_viewitem = (c__m_viewitem)this.CreateInstance(this, "c__m_viewitem");
		#line hidden
		#line hidden
		this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(c__pfc_m_view.c__m_viewitem),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 1},false), new c__pfc_m_view.c__m_viewitem[1]{
		#line hidden
		this.m_viewitem })));
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_viewitem);
		#line hidden
	}

	#line 1 "pfc_m_view.m_viewitem"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_viewitem")]
	public class c__m_viewitem : Sybase.PowerBuilder.WPF.PBMenu
	{
		#line hidden
		public c__pfc_m_view.c__m_viewitem.c__m_viewdisplay m_viewdisplay = null;
		public c__pfc_m_view.c__m_viewitem.c__m_dash11 m_dash11 = null;
		public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons m_arrangeicons = null;

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("create")]
		public override void create()
		{
			#line hidden
			InitMenu(MenuType.MenuItem);

			#line hidden
			this.Text = new Sybase.PowerBuilder.PBString("_View");
			#line hidden
			#line hidden
			this.m_viewdisplay = (c__m_viewdisplay)this.CreateInstance(this, "c__m_viewdisplay");
			#line hidden
			#line hidden
			this.m_dash11 = (c__m_dash11)this.CreateInstance(this, "c__m_dash11");
			#line hidden
			#line hidden
			this.m_arrangeicons = (c__m_arrangeicons)this.CreateInstance(this, "c__m_arrangeicons");
			#line hidden
			#line hidden
			this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBMenu),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 3},false), new Sybase.PowerBuilder.WPF.PBMenu[3]{
			#line hidden
			(Sybase.PowerBuilder.WPF.PBMenu)(this.m_viewdisplay),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash11),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_arrangeicons) })));
			#line hidden
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("destroy")]
		public override void destroy()
		{
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_viewdisplay);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash11);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_arrangeicons);
			#line hidden
		}

		#line 1 "m_viewitem.m_viewdisplay"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_viewdisplay")]
		public class c__m_viewdisplay : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden
			public c__pfc_m_view.c__m_viewitem.c__m_viewdisplay.c__m_largeicon m_largeicon = null;
			public c__pfc_m_view.c__m_viewitem.c__m_viewdisplay.c__m_smallicon m_smallicon = null;
			public c__pfc_m_view.c__m_viewitem.c__m_viewdisplay.c__m_list m_list = null;
			public c__pfc_m_view.c__m_viewitem.c__m_viewdisplay.c__m_details m_details = null;

			#line 1 "pfc_m_view.m_viewdisplay.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				this.m_largeicon.Checked = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 39
				this.m_smallicon.Checked = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 40
				this.m_list.Checked = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 41
				this.m_details.Checked = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 43
				Sybase.PowerBuilder.PBListViewViewValue __PB_TEMP______switchTmpVar0 = ((c__pfc_m_view)(Parent.Parent)).ilv_parent.View;
				#line hidden
				#line 44
				if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewLargeIcon)) )
				#line hidden
				{
					#line 45
					this.m_largeicon.Checked = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
				#line 46
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewSmallIcon)) )
				#line hidden
				{
					#line 47
					this.m_smallicon.Checked = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
				#line 48
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewList)) )
				#line hidden
				{
					#line 49
					this.m_list.Checked = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
				#line 50
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewReport)) )
				#line hidden
				{
					#line 51
					this.m_details.Checked = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}

			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_View");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Contains commands for customizing display of items");
				#line hidden
				#line hidden
				this.m_largeicon = (c__m_largeicon)this.CreateInstance(this, "c__m_largeicon");
				#line hidden
				#line hidden
				this.m_smallicon = (c__m_smallicon)this.CreateInstance(this, "c__m_smallicon");
				#line hidden
				#line hidden
				this.m_list = (c__m_list)this.CreateInstance(this, "c__m_list");
				#line hidden
				#line hidden
				this.m_details = (c__m_details)this.CreateInstance(this, "c__m_details");
				#line hidden
				#line hidden
				this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBMenu),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 4},false), new Sybase.PowerBuilder.WPF.PBMenu[4]{
				#line hidden
				(Sybase.PowerBuilder.WPF.PBMenu)(this.m_largeicon),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_smallicon),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_list),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_details) })));
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("destroy")]
			public override void destroy()
			{
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_largeicon);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_smallicon);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_list);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_details);
				#line hidden
			}

			#line 1 "m_viewdisplay.m_largeicon"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_largeicon")]
			public class c__m_largeicon : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line 1 "pfc_m_view.m_largeicon.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 39
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.View = (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewLargeIcon));
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("Lar_ge Icons");
					#line hidden
					#line hidden
					this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays items by using large icons");
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("destroy")]
				public override void destroy()
				{
					#line hidden
				}

				void _init()
				{
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.DestroyEvent -= new Sybase.PowerBuilder.PBEventHandler(this.destroy);
				}

				public c__m_largeicon()
				{
					_init();
				}

			}


			#line 1 "m_viewdisplay.m_smallicon"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_smallicon")]
			public class c__m_smallicon : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line 1 "pfc_m_view.m_smallicon.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 39
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.View = (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewSmallIcon));
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("S_mall Icons");
					#line hidden
					#line hidden
					this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays items by using small icons");
					#line hidden
				}

				void _init()
				{
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
			public class c__m_list : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line 1 "pfc_m_view.m_list.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 39
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.View = (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewList));
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("_List");
					#line hidden
					#line hidden
					this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays items in a list");
					#line hidden
				}

				void _init()
				{
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
			public class c__m_details : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line 1 "pfc_m_view.m_details.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 39
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.View = (new Sybase.PowerBuilder.PBListViewViewValue(Sybase.PowerBuilder.PBListViewView.ListViewReport));
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("_Details");
					#line hidden
					#line hidden
					this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays information about each item");
					#line hidden
				}

				void _init()
				{
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				}

				public c__m_details()
				{
					_init();
				}

			}


			void _init()
			{
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
			}

			public c__m_viewdisplay()
			{
				_init();
			}

		}


		#line 1 "m_viewitem.m_dash11"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash11")]
		public class c__m_dash11 : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("-");
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
		public class c__m_arrangeicons : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_1 m_1 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_2 m_2 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_3 m_3 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_4 m_4 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_5 m_5 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_6 m_6 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_7 m_7 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_8 m_8 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_9 m_9 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_10 m_10 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_dash12 m_dash12 = null;
			public c__pfc_m_view.c__m_viewitem.c__m_arrangeicons.c__m_autoarrange m_autoarrange = null;

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Arrange _Icons");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Contains commands for arranging items");
				#line hidden
				#line hidden
				this.m_1 = (c__m_1)this.CreateInstance(this, "c__m_1");
				#line hidden
				#line hidden
				this.m_2 = (c__m_2)this.CreateInstance(this, "c__m_2");
				#line hidden
				#line hidden
				this.m_3 = (c__m_3)this.CreateInstance(this, "c__m_3");
				#line hidden
				#line hidden
				this.m_4 = (c__m_4)this.CreateInstance(this, "c__m_4");
				#line hidden
				#line hidden
				this.m_5 = (c__m_5)this.CreateInstance(this, "c__m_5");
				#line hidden
				#line hidden
				this.m_6 = (c__m_6)this.CreateInstance(this, "c__m_6");
				#line hidden
				#line hidden
				this.m_7 = (c__m_7)this.CreateInstance(this, "c__m_7");
				#line hidden
				#line hidden
				this.m_8 = (c__m_8)this.CreateInstance(this, "c__m_8");
				#line hidden
				#line hidden
				this.m_9 = (c__m_9)this.CreateInstance(this, "c__m_9");
				#line hidden
				#line hidden
				this.m_10 = (c__m_10)this.CreateInstance(this, "c__m_10");
				#line hidden
				#line hidden
				this.m_dash12 = (c__m_dash12)this.CreateInstance(this, "c__m_dash12");
				#line hidden
				#line hidden
				this.m_autoarrange = (c__m_autoarrange)this.CreateInstance(this, "c__m_autoarrange");
				#line hidden
				#line hidden
				this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBMenu),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 12},false), new Sybase.PowerBuilder.WPF.PBMenu[12]{
				#line hidden
				(Sybase.PowerBuilder.WPF.PBMenu)(this.m_1),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_2),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_3),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_4),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_5),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_6),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_7),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_8),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_9),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_10),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash12),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_autoarrange) })));
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("destroy")]
			public override void destroy()
			{
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_1);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_2);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_3);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_4);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_5);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_6);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_7);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_8);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_9);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_10);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash12);
				#line hidden
				#line hidden
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_autoarrange);
				#line hidden
			}

			#line 1 "m_arrangeicons.m_1"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_1")]
			public class c__m_1 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("1");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("destroy")]
				public override void destroy()
				{
					#line hidden
				}

				#line 1 "pfc_m_view.m_1.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(1));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.DestroyEvent -= new Sybase.PowerBuilder.PBEventHandler(this.destroy);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_1()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_2"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_2")]
			public class c__m_2 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("2");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_2.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(2));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_2()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_3"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_3")]
			public class c__m_3 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("3");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_3.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(3));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_3()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_4"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_4")]
			public class c__m_4 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("4");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_4.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(4));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_4()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_5"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_5")]
			public class c__m_5 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("5");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_5.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(5));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_5()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_6"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_6")]
			public class c__m_6 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("6");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_6.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(6));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_6()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_7"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_7")]
			public class c__m_7 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("7");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_7.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(7));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_7()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_8"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_8")]
			public class c__m_8 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("8");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_8.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(8));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_8()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_9"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_9")]
			public class c__m_9 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("9");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_9.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(9));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_9()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_10"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_10")]
			public class c__m_10 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("10");
					#line hidden
					#line hidden
					this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}

				#line 1 "pfc_m_view.m_10.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.columnclick(new Sybase.PowerBuilder.PBInt(10));
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_10()
				{
					_init();
				}

			}


			#line 1 "m_arrangeicons.m_dash12"
			#line hidden
			[System.Diagnostics.DebuggerDisplay("",Type="m_dash12")]
			public class c__m_dash12 : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("-");
					#line hidden
					#line hidden
					this.ShiftToRight = new Sybase.PowerBuilder.PBBoolean(true);
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
			public class c__m_autoarrange : Sybase.PowerBuilder.WPF.PBMenu
			{
				#line hidden

				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("create")]
				public override void create()
				{
					#line hidden
					InitMenu(MenuType.MenuItem);

					#line hidden
					this.Text = new Sybase.PowerBuilder.PBString("_Auto Arrange");
					#line hidden
					#line hidden
					this.MicroHelp = new Sybase.PowerBuilder.PBString("Arranges the icons automatically");
					#line hidden
					#line hidden
					this.ShiftToRight = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}

				#line 1 "pfc_m_view.m_autoarrange.clicked"
				#line hidden
				[Sybase.PowerBuilder.PBEventAttribute("clicked")]
				public override void clicked()
				{
					#line hidden
					#line 38
					this.Checked = !(this.Checked);
					#line hidden
					#line 39
					((c__pfc_m_view)(Parent.Parent.Parent)).ilv_parent.AutoArrange = this.Checked;
					#line hidden
				}

				void _init()
				{
					this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
					this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				}

				public c__m_autoarrange()
				{
					_init();
				}

			}


			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
			}

			public c__m_arrangeicons()
			{
				_init();
			}

		}


		void _init()
		{
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
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

	public c__pfc_m_view()
	{
		_init();
	}

}
 