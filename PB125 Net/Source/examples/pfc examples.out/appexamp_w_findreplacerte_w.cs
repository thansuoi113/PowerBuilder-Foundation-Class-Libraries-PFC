//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_findreplacerte.srw"
#line hidden
#line 1 "w_findreplacerte"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_findreplacerte",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_findreplacerte")]
public class c__w_findreplacerte : c__w_main
{
	#line hidden
	public c__w_findreplacerte.c__cb_find cb_find = null;
	public c__w_findreplacerte.c__cb_replace cb_replace = null;
	public c__w_findreplacerte.c__rte_1 rte_1 = null;
	public c__w_findreplacerte.c__cb_close cb_close = null;

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
		this.cb_find = (c__cb_find)this.CreateInstance(this, "c__cb_find");
		#line hidden
		#line hidden
		this.cb_replace = (c__cb_replace)this.CreateInstance(this, "c__cb_replace");
		#line hidden
		#line hidden
		this.rte_1 = (c__rte_1)this.CreateInstance(this, "c__rte_1");
		#line hidden
		#line hidden
		this.cb_close = (c__cb_close)this.CreateInstance(this, "c__cb_close");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_find);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_replace);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.rte_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_close);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_find);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_replace);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rte_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_close);
		#line hidden
	}

	#line 1 "w_findreplacerte.open"
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
		#line 11
		rte_1.Scroll((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-50)));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_findreplacerte.cb_find"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_find")]
	public class c__cb_find : c__u_cb
	{
		#line hidden

		#line 1 "w_findreplacerte.cb_find.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			((c__w_findreplacerte)(Parent)).rte_1.pfc_finddlg();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_find()
		{
			_init();
		}

	}


	#line 1 "w_findreplacerte.cb_replace"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_replace")]
	public class c__cb_replace : c__u_cb
	{
		#line hidden

		#line 1 "w_findreplacerte.cb_replace.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 12
			((c__w_findreplacerte)(Parent)).rte_1.pfc_replacedlg();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_replace()
		{
			_init();
		}

	}


	#line 1 "w_findreplacerte.rte_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rte_1")]
	public class c__rte_1 : c__u_rte
	{
		#line hidden

		#line 1 "w_findreplacerte.rte_1.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBString ls_document = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_sql = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_windowname = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 17
			ls_windowname = Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_findreplacerte)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_findreplacerte)(this.Parent)))))))));
			#line hidden
			#line 20
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))
			#line hidden
			{
				#line 21
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))
				#line hidden
				{
					#line 22
					ls_sql = (((new Sybase.PowerBuilder.PBString("SELECT 'examples'.'about'\r\nINTO :ls_document ")+ new Sybase.PowerBuilder.PBString("\r\nFROM 'examples'\r\nWHERE 'examples'."))+ new Sybase.PowerBuilder.PBString("'window' = '"))+ ls_windowname)+ new Sybase.PowerBuilder.PBString("'   ;");
					#line hidden
					#line 25
					c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_sqlsyntax(new Sybase.PowerBuilder.PBString("Get Example's 'About' Information"), ls_sql);
					#line hidden
				}
			}

			Sybase.PowerBuilder.IPBValue[] __PB_TEMP_DB__OutputVars0 = new Sybase.PowerBuilder.IPBValue[1];
			__PB_TEMP_DB__OutputVars0[0] = ls_document;
			Sybase.PowerBuilder.DSI.PBSQL.DSISQLFunc.Select(Sybase.PowerBuilder.WPF.PBSession.CurrentSession,
				new Sybase.PowerBuilder.DB.DBStatement(
					new Sybase.PowerBuilder.DB.DBStatement(
						new System.String[2] {
							"select \"examples\".\"about\"     from \"examples\"    WHERE \"examples\".\"window\" = ",
							" "
						},
						new Sybase.PowerBuilder.IPBValue[1] {
							ls_windowname
						}
					),
					new Sybase.PowerBuilder.DB.DBOutputVarInfo[1] {
						new Sybase.PowerBuilder.DB.DBOutputVarInfo(false)
					}
				),
				new Sybase.PowerBuilder.IPBValue[1] {
					ls_windowname
				},
				__PB_TEMP_DB__OutputVars0,
				new Sybase.PowerBuilder.PBDataType[1] {
					Sybase.PowerBuilder.PBDataType.String
				},
				c__pfcexamp.GetCurrentApplication().sqlca
			);

			#line 29
			ls_document = (Sybase.PowerBuilder.PBString) __PB_TEMP_DB__OutputVars0[0];
			#line hidden
			#line 34
			((c__w_findreplacerte)(Parent)).rte_1.PasteRTF(ls_document);
			#line hidden
			#line 35
			this.of_setfind(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("create")]
		public override void create()
		{
			#line hidden
			#line hidden
			base.create();
			#line hidden
			#line hidden
			VScrollBar = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line hidden
			RulerBar = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line hidden
			BackColor = new Sybase.PowerBuilder.PBLong(1090519039);
			#line hidden
			#line hidden
			InputFieldBackColor = new Sybase.PowerBuilder.PBLong(1090519039);
			#line hidden
		}

		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);

			OnInitialUpdate();
		}

		public c__rte_1()
		{
			_init();
		}

	}


	#line 1 "w_findreplacerte.cb_close"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_close")]
	public class c__cb_close : c__u_cb
	{
		#line hidden

		#line 1 "w_findreplacerte.cb_close.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_findreplacerte)(this.Parent)).pfc_close();
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


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
	}

	public c__w_findreplacerte()
	{
		_init();
	}

}
 