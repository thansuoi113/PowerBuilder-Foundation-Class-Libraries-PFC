//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_dw3types.srw"
#line hidden
#line 1 "w_dw3types"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_dw3types",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_dw3types")]
public class c__w_dw3types : c__w_main
{
	#line hidden
	public c__w_dw3types.c__dw_link1 dw_link1 = null;
	public c__w_dw3types.c__dw_link2 dw_link2 = null;
	public c__w_dw3types.c__dw_link3 dw_link3 = null;
	public c__w_dw3types.c__dw_pfc_nolink dw_pfc_nolink = null;
	public c__w_dw3types.c__dw_nonpfc dw_nonpfc = null;
	public c__w_dw3types.c__cb_update cb_update = null;
	public c__w_dw3types.c__cb_retrieve cb_retrieve = null;
	public c__w_dw3types.c__cb_close cb_close = null;
	public c__w_dw3types.c__gb_linkedpfcdw gb_linkedpfcdw = null;
	public c__w_dw3types.c__gb_nonpfcdw gb_nonpfcdw = null;
	public c__w_dw3types.c__gb_unlinkedpfcdw gb_unlinkedpfcdw = null;
	public c__w_dw3types.c__cb_1 cb_1 = null;
	public c__w_dw3types.c__p_1 p_1 = null;

	#line 1 "w_dw3types.ue_sqlspy"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("ue_sqlspy")]
	public virtual Sybase.PowerBuilder.PBInt ue_sqlspy()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_return = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_debug)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))
		#line hidden
		{
			#line 53
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.of_setdebug(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 56
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_sqlspy)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))
		#line hidden
		{
			#line 61
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setsqlspy(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 62
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 62
				return new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
			}
			#line 64
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setallowinspect(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 65
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 65
				return new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
			}
			#line 67
			li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_opensqlspy(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		else
		{
			#line 69
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))
			#line hidden
			{
				#line 71
				li_return = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setsqlspy(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
			}
		}
		#line 74
		return li_return;
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
		this.dw_link1 = (c__dw_link1)this.CreateInstance(this, "c__dw_link1");
		#line hidden
		#line hidden
		this.dw_link2 = (c__dw_link2)this.CreateInstance(this, "c__dw_link2");
		#line hidden
		#line hidden
		this.dw_link3 = (c__dw_link3)this.CreateInstance(this, "c__dw_link3");
		#line hidden
		#line hidden
		this.dw_pfc_nolink = (c__dw_pfc_nolink)this.CreateInstance(this, "c__dw_pfc_nolink");
		#line hidden
		#line hidden
		this.dw_nonpfc = (c__dw_nonpfc)this.CreateInstance(this, "c__dw_nonpfc");
		#line hidden
		#line hidden
		this.cb_update = (c__cb_update)this.CreateInstance(this, "c__cb_update");
		#line hidden
		#line hidden
		this.cb_retrieve = (c__cb_retrieve)this.CreateInstance(this, "c__cb_retrieve");
		#line hidden
		#line hidden
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		this.gb_linkedpfcdw = (c__gb_linkedpfcdw)this.CreateInstance(this, "c__gb_linkedpfcdw");
		#line hidden
		#line hidden
		this.gb_nonpfcdw = (c__gb_nonpfcdw)this.CreateInstance(this, "c__gb_nonpfcdw");
		#line hidden
		#line hidden
		this.gb_unlinkedpfcdw = (c__gb_unlinkedpfcdw)this.CreateInstance(this, "c__gb_unlinkedpfcdw");
		#line hidden
		#line hidden
		this.cb_1 = (c__cb_1)this.CreateInstance(this, "c__cb_1");
		#line hidden
		#line hidden
		this.p_1 = (c__p_1)this.CreateInstance(this, "c__p_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_link1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_link2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_link3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_pfc_nolink);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_nonpfc);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_update);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_retrieve);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_linkedpfcdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_nonpfcdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_unlinkedpfcdw);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(13)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.p_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_link1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_link2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_link3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_pfc_nolink);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_nonpfc);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_update);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_retrieve);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_linkedpfcdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_nonpfcdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_unlinkedpfcdw);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_1);
		#line hidden
	}

	#line 1 "w_dw3types.open"
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
		dw_link1.inv_linkage.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
		#line hidden
		#line 16
		dw_link1.of_retrieve();
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_dw3types.dw_link1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_customerdetailupdatable", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_link1")]
	public class c__dw_link1 : c__u_dw
	{
		#line hidden

		#line 1 "w_dw3types.dw_link1.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 16
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 19
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_dw3types.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_dw3types)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dw3types.dw_link1.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 20
			return this.Retrieve();
			#line hidden
		}

		#line 1 "w_dw3types.dw_link1.pfc_prermbmenu"
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_customerdetailupdatable");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_link1()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.dw_link2"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_salesforcustomersupdatable2", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_link2")]
	public class c__dw_link2 : c__u_dw
	{
		#line hidden

		#line 1 "w_dw3types.dw_link2.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 15
			inv_linkage.of_setmaster((c__u_dw)(((c__w_dw3types)(Parent)).dw_link1));
			#line hidden
			#line 19
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("cust_id"), new Sybase.PowerBuilder.PBString("cust_id"));
			#line hidden
			#line 23
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 25
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_dw3types.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_dw3types)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dw3types.dw_link2.pfc_prermbmenu"
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_salesforcustomersupdatable2");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_link2()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.dw_link3"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_lineitemsupdatable2", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_link3")]
	public class c__dw_link3 : c__u_dw
	{
		#line hidden

		#line 1 "w_dw3types.dw_link3.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 15
			inv_linkage.of_setmaster((c__u_dw)(((c__w_dw3types)(Parent)).dw_link2));
			#line hidden
			#line 19
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("sales_id"), new Sybase.PowerBuilder.PBString("sales_id"));
			#line hidden
			#line 23
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 25
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__w_dw3types.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_dw3types)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dw3types.dw_link3.pfc_prermbmenu"
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

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_lineitemsupdatable2");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_link3()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.dw_pfc_nolink"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_empnamesupdateable", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_pfc_nolink")]
	public class c__dw_pfc_nolink : c__u_dw
	{
		#line hidden

		#line 1 "w_dw3types.dw_pfc_nolink.constructor"
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
			#line 12
			this.of_retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dw3types.dw_pfc_nolink.pfc_prermbmenu"
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

		#line 1 "w_dw3types.dw_pfc_nolink.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 21
			return this.Retrieve();
			#line hidden
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_empnamesupdateable");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_pfc_nolink()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.dw_nonpfc"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_deptsfreeform", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_nonpfc")]
	public class c__dw_nonpfc : Sybase.PowerBuilder.WPF.PBDataWindow
	{
		#line hidden

		#line 1 "w_dw3types.dw_nonpfc.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dw3types)(Parent)).dw_nonpfc.SetTransObject((Sybase.PowerBuilder.PBTransaction)(c__pfcexamp.GetCurrentApplication().sqlca));
			#line hidden
			#line 12
			((c__w_dw3types)(Parent)).dw_nonpfc.Retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_deptsfreeform");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_nonpfc()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.cb_update"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_update")]
	public class c__cb_update : c__u_cb
	{
		#line hidden

		#line 1 "w_dw3types.cb_update.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			((c__w_dw3types)(this.Parent)).pfc_save();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_update()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.cb_retrieve"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_retrieve")]
	public class c__cb_retrieve : c__u_cb
	{
		#line hidden

		#line 1 "w_dw3types.cb_retrieve.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 13
			((c__w_dw3types)(Parent)).dw_link1.of_retrieve();
			#line hidden
			#line 16
			((c__w_dw3types)(Parent)).dw_pfc_nolink.of_retrieve();
			#line hidden
			#line 19
			((c__w_dw3types)(Parent)).dw_nonpfc.Retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_retrieve()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "w_dw3types.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dw3types)(this.Parent)).pfc_close();
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


	#line 1 "w_dw3types.gb_linkedpfcdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_linkedpfcdw")]
	public class c__gb_linkedpfcdw : Sybase.PowerBuilder.WPF.PBGroupBox
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_linkedpfcdw()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.gb_nonpfcdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_nonpfcdw")]
	public class c__gb_nonpfcdw : Sybase.PowerBuilder.WPF.PBGroupBox
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_nonpfcdw()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.gb_unlinkedpfcdw"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_unlinkedpfcdw")]
	public class c__gb_unlinkedpfcdw : Sybase.PowerBuilder.WPF.PBGroupBox
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_unlinkedpfcdw()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.cb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_1")]
	public class c__cb_1 : c__u_cb_sqlspy
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_1()
		{
			_init();
		}

	}


	#line 1 "w_dw3types.p_1"
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

	public c__w_dw3types()
	{
		_init();
	}

}
 