//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx\\pfc_w_debuglog.srw"
#line hidden
#line 1 "pfc_w_debuglog"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_debuglog",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_debuglog")]
public class c__pfc_w_debuglog : c__w_main
{
	#line hidden
	public c__pfc_w_debuglog.c__dw_debuglog dw_debuglog = null;
	public c__pfc_w_debuglog.c__cb_print cb_print = null;
	public c__pfc_w_debuglog.c__cb_clear cb_clear = null;
	public c__pfc_w_debuglog.c__cb_close cb_close = null;
	public c__pfc_w_debuglog.c__cb_dlghelp cb_dlghelp = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_initcolwidth", null, "pfc_w_debuglog", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBInt ii_initcolwidth = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_initdwwidth", null, "pfc_w_debuglog", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBInt ii_initdwwidth = Sybase.PowerBuilder.PBInt.DefaultValue;

	#line 1 "pfc_w_debuglog.of_dwscrolltorow(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_dwscrolltorow", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_dwscrolltorow(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		#line 47
		return dw_debuglog.ScrollToRow(al_row);
		#line hidden
	}

	#line 1 "pfc_w_debuglog.of_dwsetredraw(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_dwsetredraw", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_dwsetredraw(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 47
		return dw_debuglog.SetRedraw(ab_switch);
		#line hidden
	}

	#line 1 "pfc_w_debuglog.of_setalwaysontop(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setalwaysontop", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setalwaysontop(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		if (ab_switch)
		#line hidden
		{
			#line 52
			this.SetPosition((new Sybase.PowerBuilder.PBSetPosTypeValue(Sybase.PowerBuilder.PBSetPosType.TopMost)));
			#line hidden
		}
		else
		{
			#line 54
			this.SetPosition((new Sybase.PowerBuilder.PBSetPosTypeValue(Sybase.PowerBuilder.PBSetPosType.NoTopMost)));
			#line hidden
		}
		#line 57
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
		this.dw_debuglog = (c__dw_debuglog)this.CreateInstance(this, "c__dw_debuglog");
		#line hidden
		#line hidden
		this.cb_print = (c__cb_print)this.CreateInstance(this, "c__cb_print");
		#line hidden
		#line hidden
		this.cb_clear = (c__cb_clear)this.CreateInstance(this, "c__cb_clear");
		#line hidden
		#line hidden
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_debuglog);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_print);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_clear);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_debuglog);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_print);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_clear);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
	}

	#line 1 "pfc_w_debuglog.resize"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("resize")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_size)]
	public override Sybase.PowerBuilder.PBLong resize(Sybase.PowerBuilder.PBULong sizetype, Sybase.PowerBuilder.PBInt newwidth, Sybase.PowerBuilder.PBInt newheight)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_sizedelta = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.resize(sizetype, newwidth, newheight);
		#line hidden
		#line 49
		li_sizedelta = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(dw_debuglog.Width)- (Sybase.PowerBuilder.PBLong)(ii_initdwwidth));
		#line hidden
		#line 50
		((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_debuglog.Object))[new Sybase.PowerBuilder.PBString(@"msg"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"width")] = (Sybase.PowerBuilder.PBAny)((Sybase.PowerBuilder.PBLong)(ii_initcolwidth)+ (Sybase.PowerBuilder.PBLong)(li_sizedelta));
		#line hidden
		#line 51
		((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_debuglog.Object))[new Sybase.PowerBuilder.PBString(@"msg_t"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"width")] = (Sybase.PowerBuilder.PBAny)((Sybase.PowerBuilder.PBLong)(ii_initcolwidth)+ (Sybase.PowerBuilder.PBLong)(li_sizedelta));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_debuglog.pfc_preopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_preopen")]
	public override void pfc_preopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 45
		this.of_setresize(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 48
		inv_resize.of_setminsize(new Sybase.PowerBuilder.PBInt(1500), (Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBLong)(cb_clear.Height)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(30)))* (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))));
		#line hidden
		#line 51
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_print), c__n_cst_resize.fixedright);
		#line hidden
		#line 52
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_clear), c__n_cst_resize.fixedright);
		#line hidden
		#line 53
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_close), c__n_cst_resize.fixedright);
		#line hidden
		#line 54
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(dw_debuglog), c__n_cst_resize.scalerightbottom);
		#line hidden
		#line 55
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_dlghelp), c__n_cst_resize.fixedright);
		#line hidden
		#line 59
		ii_initcolwidth = Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer(((Sybase.PowerBuilder.PBAny)((((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_debuglog.Object))[new Sybase.PowerBuilder.PBString(@"msg"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"width"), Sybase.PowerBuilder.PBBoolean.True]))));
		#line hidden
		#line 60
		ii_initdwwidth = dw_debuglog.Width;
		#line hidden
		#line 64
		if (c__pfcsecurity_admin.GetCurrentApplication().gnv_app.of_isregistryavailable())
		#line hidden
		{
			#line 65
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(c__pfcsecurity_admin.GetCurrentApplication().gnv_app.of_getuserkey())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 66
				this.of_setpreference(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		else
		{
			#line 69
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(c__pfcsecurity_admin.GetCurrentApplication().gnv_app.of_getuserinifile())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 70
				this.of_setpreference(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		#line 75
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 78
		this.of_setalwaysontop(c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_debug.of_getalwaysontop());
		#line hidden
		#line 81
		dw_debuglog.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 82
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 85
		li_rc = c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_debug.ids_debuglog.ShareData((Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_w_debuglog.c__dw_debuglog)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dw_debuglog)))));
		#line hidden
		#line 86
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 87
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_debuglog_failedsharedata"), new Sybase.PowerBuilder.PBString("PowerBuilder Class Library"), new Sybase.PowerBuilder.PBString("Open on pfc_w_debuglog event has received a ShareData() fail code.  ")+ new Sybase.PowerBuilder.PBString("The ShareData() functionality is unable to be processed."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Information)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
	}

	#line 1 "pfc_w_debuglog.dw_debuglog"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_debuglog", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_debuglog")]
	public class c__dw_debuglog : c__u_dw
	{
		#line hidden

		#line 1 "pfc_w_debuglog.dw_debuglog.constructor"
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
			#line 1
			ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_debuglog");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_debuglog()
		{
			_init();
		}

	}


	#line 1 "pfc_w_debuglog.cb_print"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_print")]
	public class c__cb_print : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_debuglog.cb_print.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 42
			c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_debug.of_printlog();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_print()
		{
			_init();
		}

	}


	#line 1 "pfc_w_debuglog.cb_clear"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_clear")]
	public class c__cb_clear : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_debuglog.cb_clear.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 42
			c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_debug.of_clearlog();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_clear()
		{
			_init();
		}

	}


	#line 1 "pfc_w_debuglog.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_debuglog.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 42
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(((c__pfc_w_debuglog)(this.Parent))));
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


	#line 1 "pfc_w_debuglog.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_debuglog.cb_dlghelp.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 40
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10000)));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_dlghelp()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ResizeEvent += new Sybase.PowerBuilder.PBM_EventHandler_mouse(this.resize);
	}

	public c__pfc_w_debuglog()
	{
		_init();
	}

}
 