//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_linkageretrieve.srw"
#line hidden
#line 1 "w_linkageretrieve"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_linkageretrieve",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_linkageretrieve")]
public class c__w_linkageretrieve : c__w_main
{
	#line hidden
	public c__w_linkageretrieve.c__cb_close cb_close = null;
	public c__w_linkageretrieve.c__dw_cust dw_cust = null;
	public c__w_linkageretrieve.c__dw_sales dw_sales = null;
	public c__w_linkageretrieve.c__dw_lineitem dw_lineitem = null;
	public c__w_linkageretrieve.c__p_1 p_1 = null;

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
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		this.dw_cust = (c__dw_cust)this.CreateInstance(this, "c__dw_cust");
		#line hidden
		#line hidden
		this.dw_sales = (c__dw_sales)this.CreateInstance(this, "c__dw_sales");
		#line hidden
		#line hidden
		this.dw_lineitem = (c__dw_lineitem)this.CreateInstance(this, "c__dw_lineitem");
		#line hidden
		#line hidden
		this.p_1 = (c__p_1)this.CreateInstance(this, "c__p_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_cust);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_sales);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_lineitem);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.p_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_cust);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_sales);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_lineitem);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_1);
		#line hidden
	}

	#line 1 "w_linkageretrieve.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 12
		dw_cust.inv_linkage.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
		#line hidden
		#line 16
		dw_cust.of_retrieve();
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_linkageretrieve.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "w_linkageretrieve.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_linkageretrieve)(this.Parent)).pfc_close();
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


	#line 1 "w_linkageretrieve.dw_cust"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_customerdetail", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_cust")]
	public class c__dw_cust : c__u_dw
	{
		#line hidden

		#line 1 "w_linkageretrieve.dw_cust.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.constructor();
			#line hidden
			#line 12
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 15
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 18
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 20
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_linkageretrieve.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_linkageretrieve)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_linkageretrieve.dw_cust.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.pfc_retrieve();
			#line hidden
			#line 20
			return this.Retrieve();
			#line hidden
		}

		#line 1 "w_linkageretrieve.dw_cust.pfc_prermbmenu"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
		public override void pfc_prermbmenu<T0>(ref T0 am_dw)
		{
			#line hidden
			#line 1
			base.pfc_prermbmenu(ref am_dw);
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_customerdetail");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_cust()
		{
			_init();
		}

	}


	#line 1 "w_linkageretrieve.dw_sales"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_salesforcustomers", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_sales")]
	public class c__dw_sales : c__u_dw
	{
		#line hidden

		#line 1 "w_linkageretrieve.dw_sales.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.constructor();
			#line hidden
			#line 12
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 15
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 17
			inv_linkage.of_setmaster((c__u_dw)(((c__w_linkageretrieve)(Parent)).dw_cust));
			#line hidden
			#line 20
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("cust_id"), new Sybase.PowerBuilder.PBString("cust_id"));
			#line hidden
			#line 23
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 25
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_linkageretrieve.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_linkageretrieve)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_linkageretrieve.dw_sales.pfc_prermbmenu"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
		public override void pfc_prermbmenu<T0>(ref T0 am_dw)
		{
			#line hidden
			#line 1
			base.pfc_prermbmenu(ref am_dw);
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_salesforcustomers");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_sales()
		{
			_init();
		}

	}


	#line 1 "w_linkageretrieve.dw_lineitem"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_lineitems", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_lineitem")]
	public class c__dw_lineitem : c__u_dw
	{
		#line hidden

		#line 1 "w_linkageretrieve.dw_lineitem.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.constructor();
			#line hidden
			#line 12
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 15
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 17
			inv_linkage.of_setmaster((c__u_dw)(((c__w_linkageretrieve)(Parent)).dw_sales));
			#line hidden
			#line 20
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("sales_id"), new Sybase.PowerBuilder.PBString("sales_id"));
			#line hidden
			#line 23
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 25
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_linkageretrieve.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_linkageretrieve)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_linkageretrieve.dw_lineitem.pfc_prermbmenu"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
		public override void pfc_prermbmenu<T0>(ref T0 am_dw)
		{
			#line hidden
			#line 1
			base.pfc_prermbmenu(ref am_dw);
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_lineitems");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_lineitem()
		{
			_init();
		}

	}


	#line 1 "w_linkageretrieve.p_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_1")]
	public class c__p_1 : c__u_p
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
	}

	public c__w_linkageretrieve()
	{
		_init();
	}

}
 