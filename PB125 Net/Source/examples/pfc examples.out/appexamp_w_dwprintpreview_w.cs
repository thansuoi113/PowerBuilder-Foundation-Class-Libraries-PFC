//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_dwprintpreview.srw"
#line hidden
#line 1 "w_dwprintpreview"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_dwprintpreview",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_dwprintpreview")]
public class c__w_dwprintpreview : c__w_main
{
	#line hidden
	public c__w_dwprintpreview.c__dw_1 dw_1 = null;
	public c__w_dwprintpreview.c__cb_close cb_close = null;
	public c__w_dwprintpreview.c__cb_setzoom cb_setzoom = null;
	public c__w_dwprintpreview.c__cbx_printpreview cbx_printpreview = null;
	public c__w_dwprintpreview.c__cbx_1 cbx_1 = null;
	public c__w_dwprintpreview.c__gb_1 gb_1 = null;

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
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		this.cb_setzoom = (c__cb_setzoom)this.CreateInstance(this, "c__cb_setzoom");
		#line hidden
		#line hidden
		this.cbx_printpreview = (c__cbx_printpreview)this.CreateInstance(this, "c__cbx_printpreview");
		#line hidden
		#line hidden
		this.cbx_1 = (c__cbx_1)this.CreateInstance(this, "c__cbx_1");
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
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_setzoom);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_printpreview);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_setzoom);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_printpreview);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_1);
		#line hidden
	}

	#line 1 "w_dwprintpreview.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_customerlist", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "w_dwprintpreview.dw_1.constructor"
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
			#line 14
			this.Modify(new Sybase.PowerBuilder.PBString("first_name.background.color='78682240'"));
			#line hidden
			#line 15
			this.Modify(new Sybase.PowerBuilder.PBString("last_name.background.color='78682240'"));
			#line hidden
			#line 16
			this.Modify(new Sybase.PowerBuilder.PBString("company_name.background.color='78682240'"));
			#line hidden
			#line 17
			this.SetTabOrder(new Sybase.PowerBuilder.PBString("first_name"), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 18
			this.SetTabOrder(new Sybase.PowerBuilder.PBString("last_name"), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 19
			this.SetTabOrder(new Sybase.PowerBuilder.PBString("company_name"), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 20
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 22
			this.of_setprintpreview(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 24
			this.of_retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dwprintpreview.dw_1.pfc_prermbmenu"
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

		#line 1 "w_dwprintpreview.dw_1.pfc_retrieve"
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


	#line 1 "w_dwprintpreview.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "w_dwprintpreview.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dwprintpreview)(this.Parent)).pfc_close();
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


	#line 1 "w_dwprintpreview.cb_setzoom"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_setzoom")]
	public class c__cb_setzoom : c__u_cb
	{
		#line hidden

		#line 1 "w_dwprintpreview.cb_setzoom.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dwprintpreview)(Parent)).dw_1.inv_printpreview.of_setzoom();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_setzoom()
		{
			_init();
		}

	}


	#line 1 "w_dwprintpreview.cbx_printpreview"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_printpreview")]
	public class c__cbx_printpreview : c__u_cbx
	{
		#line hidden

		#line 1 "w_dwprintpreview.cbx_printpreview.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dwprintpreview)(Parent)).dw_1.pfc_printpreview();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cbx_printpreview()
		{
			_init();
		}

	}


	#line 1 "w_dwprintpreview.cbx_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_1")]
	public class c__cbx_1 : c__u_cbx
	{
		#line hidden

		#line 1 "w_dwprintpreview.cbx_1.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			((c__w_dwprintpreview)(Parent)).dw_1.inv_printpreview.of_setruler(this.Checked);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cbx_1()
		{
			_init();
		}

	}


	#line 1 "w_dwprintpreview.gb_1"
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

	public c__w_dwprintpreview()
	{
		_init();
	}

}
 