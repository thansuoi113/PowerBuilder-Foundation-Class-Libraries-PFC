//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx\\pfc_m_tvs.srm"
#line hidden
#line 1 "pfc_m_tvs"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_m_tvs",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_m_tvs")]
public class c__pfc_m_tvs : Sybase.PowerBuilder.WPF.PBMenu
{
	#line hidden
	public c__pfc_m_tvs.c__m_viewitem m_viewitem = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itv_parent", null, "pfc_m_tvs", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.WPF.PBTreeView itv_parent = null;

	#line 1 "pfc_m_tvs.of_setparent(ICtreeview.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setparent", new string[]{"treeview"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setparent(Sybase.PowerBuilder.WPF.PBTreeView atv_parent)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(atv_parent)))
		#line hidden
		{
			#line 50
			itv_parent = atv_parent;
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
		c__pfcexamp.GetCurrentApplication().pfc_m_tvs = this;
		#line hidden
		#line hidden
		this.m_viewitem = (c__m_viewitem)this.CreateInstance(this, "c__m_viewitem");
		#line hidden
		#line hidden
		this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(c__pfc_m_tvs.c__m_viewitem),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 1},false), new c__pfc_m_tvs.c__m_viewitem[1]{
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

	#line 1 "pfc_m_tvs.m_viewitem"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_viewitem")]
	public class c__m_viewitem : Sybase.PowerBuilder.WPF.PBMenu
	{
		#line hidden
		public c__pfc_m_tvs.c__m_viewitem.c__m_open m_open = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_find m_find = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_dash14 m_dash14 = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_cut m_cut = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_copy m_copy = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_paste m_paste = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_clear m_clear = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_dash15 m_dash15 = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_new m_new = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_delete m_delete = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_rename m_rename = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_dash16 m_dash16 = null;
		public c__pfc_m_tvs.c__m_viewitem.c__m_properties m_properties = null;

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
			this.m_open = (c__m_open)this.CreateInstance(this, "c__m_open");
			#line hidden
			#line hidden
			this.m_find = (c__m_find)this.CreateInstance(this, "c__m_find");
			#line hidden
			#line hidden
			this.m_dash14 = (c__m_dash14)this.CreateInstance(this, "c__m_dash14");
			#line hidden
			#line hidden
			this.m_cut = (c__m_cut)this.CreateInstance(this, "c__m_cut");
			#line hidden
			#line hidden
			this.m_copy = (c__m_copy)this.CreateInstance(this, "c__m_copy");
			#line hidden
			#line hidden
			this.m_paste = (c__m_paste)this.CreateInstance(this, "c__m_paste");
			#line hidden
			#line hidden
			this.m_clear = (c__m_clear)this.CreateInstance(this, "c__m_clear");
			#line hidden
			#line hidden
			this.m_dash15 = (c__m_dash15)this.CreateInstance(this, "c__m_dash15");
			#line hidden
			#line hidden
			this.m_new = (c__m_new)this.CreateInstance(this, "c__m_new");
			#line hidden
			#line hidden
			this.m_delete = (c__m_delete)this.CreateInstance(this, "c__m_delete");
			#line hidden
			#line hidden
			this.m_rename = (c__m_rename)this.CreateInstance(this, "c__m_rename");
			#line hidden
			#line hidden
			this.m_dash16 = (c__m_dash16)this.CreateInstance(this, "c__m_dash16");
			#line hidden
			#line hidden
			this.m_properties = (c__m_properties)this.CreateInstance(this, "c__m_properties");
			#line hidden
			#line hidden
			this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBMenu),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 13},false), new Sybase.PowerBuilder.WPF.PBMenu[13]{
			#line hidden
			(Sybase.PowerBuilder.WPF.PBMenu)(this.m_open),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_find),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash14),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_cut),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_copy),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_paste),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_clear),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash15),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_new),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_delete),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_rename),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash16),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_properties) })));
			#line hidden
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("destroy")]
		public override void destroy()
		{
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_open);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_find);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash14);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_cut);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_copy);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_paste);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_clear);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash15);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_new);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_delete);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_rename);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash16);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_properties);
			#line hidden
		}

		#line 1 "m_viewitem.m_open"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_open")]
		public class c__m_open : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_open.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_open", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Open");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_find : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_find.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_finddlg", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Find...");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_dash14 : Sybase.PowerBuilder.WPF.PBMenu
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
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
		public class c__m_cut : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_cut.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_cut", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Cu_t");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_copy : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_copy.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_copy", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Copy");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_paste : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_paste.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_paste", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Paste");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_clear : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_clear.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_clear", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("C_lear");
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
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_dash15 : Sybase.PowerBuilder.WPF.PBMenu
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
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
		public class c__m_new : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_new.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_newitem", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_New");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_delete : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_delete.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_deleteitem", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Delete");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_rename : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_rename.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_renameitem", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Renam_e");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			void _init()
			{
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
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
		public class c__m_dash16 : Sybase.PowerBuilder.WPF.PBMenu
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
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
		public class c__m_properties : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_tvs.m_properties.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 38
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_tvs)(Parent.Parent)).itv_parent, "pfc_properties", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("P_roperties");
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

			void _init()
			{
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.DestroyEvent -= new Sybase.PowerBuilder.PBEventHandler(this.destroy);
			}

			public c__m_properties()
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

	public c__pfc_m_tvs()
	{
		_init();
	}

}
 