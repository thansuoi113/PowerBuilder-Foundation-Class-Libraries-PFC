//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_sort.srw"
#line hidden
#line 1 "w_sort"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_sort",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_sort")]
public class c__w_sort : c__w_main
{
	#line hidden
	public c__w_sort.c__dw_1 dw_1 = null;
	public c__w_sort.c__cb_sort cb_sort = null;
	public c__w_sort.c__cb_close cb_close = null;
	public c__w_sort.c__rb_1 rb_1 = null;
	public c__w_sort.c__rb_3 rb_3 = null;
	public c__w_sort.c__rb_2 rb_2 = null;
	public c__w_sort.c__rb_4 rb_4 = null;
	public c__w_sort.c__gb_1 gb_1 = null;

	#line 1 "w_sort.of_modifydw(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_modifydw", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_modifydw()
	{
		#line hidden
		#line 50
		dw_1.Modify(new Sybase.PowerBuilder.PBString("first_name.Background.Color='78682240'"));
		#line hidden
		#line 51
		dw_1.Modify(new Sybase.PowerBuilder.PBString("last_name.Background.Color='78682240'"));
		#line hidden
		#line 52
		dw_1.Modify(new Sybase.PowerBuilder.PBString("company_name.Background.Color='78682240'"));
		#line hidden
		#line 54
		dw_1.SetTabOrder(new Sybase.PowerBuilder.PBString("first_name"), new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 55
		dw_1.SetTabOrder(new Sybase.PowerBuilder.PBString("last_name"), new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 56
		dw_1.SetTabOrder(new Sybase.PowerBuilder.PBString("company_name"), new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 58
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt icurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line hidden
		base.create();
		#line hidden
		#line hidden
		this.dw_1 = (c__dw_1)this.CreateInstance(this, "c__dw_1");
		#line hidden
		#line hidden
		this.cb_sort = (c__cb_sort)this.CreateInstance(this, "c__cb_sort");
		#line hidden
		#line hidden
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		this.rb_1 = (c__rb_1)this.CreateInstance(this, "c__rb_1");
		#line hidden
		#line hidden
		this.rb_3 = (c__rb_3)this.CreateInstance(this, "c__rb_3");
		#line hidden
		#line hidden
		this.rb_2 = (c__rb_2)this.CreateInstance(this, "c__rb_2");
		#line hidden
		#line hidden
		this.rb_4 = (c__rb_4)this.CreateInstance(this, "c__rb_4");
		#line hidden
		#line hidden
		this.gb_1 = (c__gb_1)this.CreateInstance(this, "c__gb_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_sort);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.rb_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.rb_3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.rb_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.rb_4);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_1);
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
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_sort);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_4);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_1);
		#line hidden
	}

	#line 1 "w_sort.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_customerlist", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "w_sort.dw_1.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			this.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
			#line hidden
			#line 13
			((c__w_sort)(this.Parent)).of_modifydw();
			#line hidden
			#line 14
			this.of_setsort(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 16
			inv_sort.of_setstyle(c__n_cst_dwsrv_sort.dragdrop);
			#line hidden
			#line 17
			inv_sort.of_setcolumnnamesource(c__n_cst_dwsrv_sort.header);
			#line hidden
			#line 18
			inv_sort.of_setvisibleonly(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 20
			inv_sort.of_setusedisplay(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 21
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 23
			this.of_retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_sort.dw_1.pfc_prermbmenu"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
		public override void pfc_prermbmenu<T0>(ref T0 am_dw)
		{
			#line hidden
			#line 18
			am_dw.m_table.m_insert.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 19
			am_dw.m_table.m_addrow.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 20
			am_dw.m_table.m_delete.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}

		#line 1 "w_sort.dw_1.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.pfc_retrieve();
			#line hidden
			#line 49
			return this.Retrieve();
			#line hidden
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_customerlist");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	#line 1 "w_sort.cb_sort"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_sort")]
	public class c__cb_sort : c__u_cb
	{
		#line hidden

		#line 1 "w_sort.cb_sort.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			((c__w_sort)(Parent)).dw_1.pfc_sortdlg();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_sort()
		{
			_init();
		}

	}


	#line 1 "w_sort.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "w_sort.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_sort)(this.Parent)).pfc_close();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_close()
		{
			_init();
		}

	}


	#line 1 "w_sort.rb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_1")]
	public class c__rb_1 : c__u_rb
	{
		#line hidden

		#line 1 "w_sort.rb_1.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_sort)(Parent)).dw_1.inv_sort.of_setstyle(c__n_cst_dwsrv_sort.dragdrop);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_1()
		{
			_init();
		}

	}


	#line 1 "w_sort.rb_3"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_3")]
	public class c__rb_3 : c__u_rb
	{
		#line hidden

		#line 1 "w_sort.rb_3.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_sort)(Parent)).dw_1.inv_sort.of_setstyle(c__n_cst_dwsrv_sort.dropdownlistbox);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_3()
		{
			_init();
		}

	}


	#line 1 "w_sort.rb_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_2")]
	public class c__rb_2 : c__u_rb
	{
		#line hidden

		#line 1 "w_sort.rb_2.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_sort)(Parent)).dw_1.inv_sort.of_setstyle(c__n_cst_dwsrv_sort.simple);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_2()
		{
			_init();
		}

	}


	#line 1 "w_sort.rb_4"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_4")]
	public class c__rb_4 : c__u_rb
	{
		#line hidden

		#line 1 "w_sort.rb_4.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_sort)(Parent)).dw_1.inv_sort.of_setstyle(c__n_cst_dwsrv_sort.@default);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_4()
		{
			_init();
		}

	}


	#line 1 "w_sort.gb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_1")]
	public class c__gb_1 : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_sort()
	{
		_init();
	}

}
 