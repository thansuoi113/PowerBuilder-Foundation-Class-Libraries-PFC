//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx\\pfc_m_dw.srm"
#line hidden
#line 1 "pfc_m_dw"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_m_dw",Sybase.PowerBuilder.PBGroupType.Menu,"","c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_m_dw")]
public class c__pfc_m_dw : Sybase.PowerBuilder.WPF.PBMenu
{
	#line hidden
	public c__pfc_m_dw.c__m_table m_table = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idw_parent", null, "pfc_m_dw", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.WPF.PBDataWindow idw_parent = null;

	#line 1 "pfc_m_dw.of_setparent(ICdatawindow.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setparent", new string[]{"datawindow"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setparent(Sybase.PowerBuilder.WPF.PBDataWindow adw_parent)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(adw_parent)))
		#line hidden
		{
			#line 50
			idw_parent = adw_parent;
			#line hidden
		}
		else
		{
			#line 52
			li_rc = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
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
		c__pfcexamp.GetCurrentApplication().pfc_m_dw = this;
		#line hidden
		#line hidden
		this.m_table = (c__m_table)this.CreateInstance(this, "c__m_table");
		#line hidden
		#line hidden
		this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(c__pfc_m_dw.c__m_table),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 1},false), new c__pfc_m_dw.c__m_table[1]{
		#line hidden
		this.m_table })));
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_table);
		#line hidden
	}

	#line 1 "pfc_m_dw.m_table"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="m_table")]
	public class c__m_table : Sybase.PowerBuilder.WPF.PBMenu
	{
		#line hidden
		public c__pfc_m_dw.c__m_table.c__m_cut m_cut = null;
		public c__pfc_m_dw.c__m_table.c__m_copy m_copy = null;
		public c__pfc_m_dw.c__m_table.c__m_paste m_paste = null;
		public c__pfc_m_dw.c__m_table.c__m_selectall m_selectall = null;
		public c__pfc_m_dw.c__m_table.c__m_dash11 m_dash11 = null;
		public c__pfc_m_dw.c__m_table.c__m_insert m_insert = null;
		public c__pfc_m_dw.c__m_table.c__m_addrow m_addrow = null;
		public c__pfc_m_dw.c__m_table.c__m_delete m_delete = null;
		public c__pfc_m_dw.c__m_table.c__m_restorerow m_restorerow = null;
		public c__pfc_m_dw.c__m_table.c__m_dash12 m_dash12 = null;
		public c__pfc_m_dw.c__m_table.c__m_columns m_columns = null;
		public c__pfc_m_dw.c__m_table.c__m_functions m_functions = null;
		public c__pfc_m_dw.c__m_table.c__m_operators m_operators = null;
		public c__pfc_m_dw.c__m_table.c__m_values m_values = null;
		public c__pfc_m_dw.c__m_table.c__m_dash13 m_dash13 = null;
		public c__pfc_m_dw.c__m_table.c__m_debug m_debug = null;
		public c__pfc_m_dw.c__m_table.c__m_properties m_properties = null;

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("create")]
		public override void create()
		{
			#line hidden
			InitMenu(MenuType.MenuItem);

			#line hidden
			this.Text = new Sybase.PowerBuilder.PBString("_Table");
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
			this.m_selectall = (c__m_selectall)this.CreateInstance(this, "c__m_selectall");
			#line hidden
			#line hidden
			this.m_dash11 = (c__m_dash11)this.CreateInstance(this, "c__m_dash11");
			#line hidden
			#line hidden
			this.m_insert = (c__m_insert)this.CreateInstance(this, "c__m_insert");
			#line hidden
			#line hidden
			this.m_addrow = (c__m_addrow)this.CreateInstance(this, "c__m_addrow");
			#line hidden
			#line hidden
			this.m_delete = (c__m_delete)this.CreateInstance(this, "c__m_delete");
			#line hidden
			#line hidden
			this.m_restorerow = (c__m_restorerow)this.CreateInstance(this, "c__m_restorerow");
			#line hidden
			#line hidden
			this.m_dash12 = (c__m_dash12)this.CreateInstance(this, "c__m_dash12");
			#line hidden
			#line hidden
			this.m_columns = (c__m_columns)this.CreateInstance(this, "c__m_columns");
			#line hidden
			#line hidden
			this.m_functions = (c__m_functions)this.CreateInstance(this, "c__m_functions");
			#line hidden
			#line hidden
			this.m_operators = (c__m_operators)this.CreateInstance(this, "c__m_operators");
			#line hidden
			#line hidden
			this.m_values = (c__m_values)this.CreateInstance(this, "c__m_values");
			#line hidden
			#line hidden
			this.m_dash13 = (c__m_dash13)this.CreateInstance(this, "c__m_dash13");
			#line hidden
			#line hidden
			this.m_debug = (c__m_debug)this.CreateInstance(this, "c__m_debug");
			#line hidden
			#line hidden
			this.m_properties = (c__m_properties)this.CreateInstance(this, "c__m_properties");
			#line hidden
			#line hidden
			this.Item.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBMenu),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 17},false), new Sybase.PowerBuilder.WPF.PBMenu[17]{
			#line hidden
			(Sybase.PowerBuilder.WPF.PBMenu)(this.m_cut),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_copy),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_paste),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_selectall),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash11),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_insert),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_addrow),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_delete),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_restorerow),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash12),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_columns),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_functions),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_operators),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_values),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_dash13),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_debug),(Sybase.PowerBuilder.WPF.PBMenu)(this.m_properties) })));
			#line hidden
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("destroy")]
		public override void destroy()
		{
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
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_selectall);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash11);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_insert);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_addrow);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_delete);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_restorerow);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash12);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_columns);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_functions);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_operators);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_values);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_dash13);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_debug);
			#line hidden
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.m_properties);
			#line hidden
		}

		#line 1 "m_table.m_cut"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_cut")]
		public class c__m_cut : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("C_ut");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Moves the selection to the Clipboard");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_cut.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_cut", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_cut()
			{
				_init();
			}

		}


		#line 1 "m_table.m_copy"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_copy")]
		public class c__m_copy : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

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
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Copies the selection to the Clipboard");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_copy.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_copy", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_copy()
			{
				_init();
			}

		}


		#line 1 "m_table.m_paste"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_paste")]
		public class c__m_paste : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

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
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Inserts Clipboard contents at current insertion point");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_paste.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_paste", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_paste()
			{
				_init();
			}

		}


		#line 1 "m_table.m_selectall"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_selectall")]
		public class c__m_selectall : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Select A_ll");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Selects all items or information");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_selectall.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_selectall", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_selectall()
			{
				_init();
			}

		}


		#line 1 "m_table.m_dash11"
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


		#line 1 "m_table.m_insert"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_insert")]
		public class c__m_insert : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Insert");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Inserts a new row");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_insert.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_insertrow", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_insert()
			{
				_init();
			}

		}


		#line 1 "m_table.m_addrow"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_addrow")]
		public class c__m_addrow : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_dw.m_addrow.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_addrow", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Add");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Adds a new row to the end");
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

			public c__m_addrow()
			{
				_init();
			}

		}


		#line 1 "m_table.m_delete"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_delete")]
		public class c__m_delete : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

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
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Deletes selected rows");
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_delete.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_deleterow", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_delete()
			{
				_init();
			}

		}


		#line 1 "m_table.m_restorerow"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_restorerow")]
		public class c__m_restorerow : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_dw.m_restorerow.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_restorerow", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Re_store...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Restores rows that have been deleted");
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

			public c__m_restorerow()
			{
				_init();
			}

		}


		#line 1 "m_table.m_dash12"
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
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
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


		#line 1 "m_table.m_columns"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_columns")]
		public class c__m_columns : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("C_olumns...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Select from a list of available column names");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_columns.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_columns", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_columns()
			{
				_init();
			}

		}


		#line 1 "m_table.m_functions"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_functions")]
		public class c__m_functions : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Functions...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Select from a list of available functions");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_functions.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_functions", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_functions()
			{
				_init();
			}

		}


		#line 1 "m_table.m_operators"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_operators")]
		public class c__m_operators : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line 1 "pfc_m_dw.m_operators.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_operators", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Op_erators...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Select from a list of available operators");
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

			public c__m_operators()
			{
				_init();
			}

		}


		#line 1 "m_table.m_values"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_values")]
		public class c__m_values : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("_Values...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Select from a list of available values");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_values.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_values", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_values()
			{
				_init();
			}

		}


		#line 1 "m_table.m_dash13"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_dash13")]
		public class c__m_dash13 : Sybase.PowerBuilder.WPF.PBMenu
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
				#line hidden
				this.ShiftToRight = new Sybase.PowerBuilder.PBBoolean(true);
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


		#line 1 "m_table.m_debug"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_debug")]
		public class c__m_debug : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("create")]
			public override void create()
			{
				#line hidden
				InitMenu(MenuType.MenuItem);

				#line hidden
				this.Text = new Sybase.PowerBuilder.PBString("Data_Window Properties...");
				#line hidden
				#line hidden
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays or changes properties of the DataWindow");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.ShiftToRight = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}

			#line 1 "pfc_m_dw.m_debug.clicked"
			#line hidden
			[Sybase.PowerBuilder.PBEventAttribute("clicked")]
			public override void clicked()
			{
				#line hidden
				#line 1
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(((c__pfc_m_dw)(Parent.Parent)).idw_parent, "pfc_debug", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
			}

			void _init()
			{
				this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
				this.ClickedEvent += new Sybase.PowerBuilder.PBEventHandler(this.clicked);
			}

			public c__m_debug()
			{
				_init();
			}

		}


		#line 1 "m_table.m_properties"
		#line hidden
		[System.Diagnostics.DebuggerDisplay("",Type="m_properties")]
		public class c__m_properties : Sybase.PowerBuilder.WPF.PBMenu
		{
			#line hidden

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
				this.MicroHelp = new Sybase.PowerBuilder.PBString("Displays or changes properties of the item");
				#line hidden
				#line hidden
				this.Visible = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line hidden
				this.ShiftToRight = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
				#line hidden
				this.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
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
			this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		}

		public c__m_table()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_m_dw()
	{
		_init();
	}

}
 