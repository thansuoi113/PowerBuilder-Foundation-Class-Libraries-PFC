//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexmfe.pbl\\appexmfe.pblx\\u_utilproperties.sru"
#line hidden
#line 1 "u_utilproperties"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_utilproperties",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexmfe.pbl\\appexmfe.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_utilproperties")]
public class c__u_utilproperties : c__u_tabpg
{
	#line hidden
	public c__u_utilproperties.c__cbx_5 cbx_5 = null;
	public c__u_utilproperties.c__cbx_4 cbx_4 = null;
	public c__u_utilproperties.c__cbx_3 cbx_3 = null;
	public c__u_utilproperties.c__gb_1 gb_1 = null;
	public c__u_utilproperties.c__cbx_1 cbx_1 = null;
	public c__u_utilproperties.c__cbx_2 cbx_2 = null;
	public c__u_utilproperties.c__gb_2 gb_2 = null;
	public c__u_utilproperties.c__sle_1 sle_1 = null;
	public c__u_utilproperties.c__cb_1 cb_1 = null;

	#line 1 "u_utilproperties.ue_apply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("ue_apply")]
	public virtual void ue_apply()
	{
		#line hidden
		#line 1
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))
		#line hidden
		{
			#line 3
			c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setdwproperty(cbx_1.Checked);
			#line hidden
			#line 6
			c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setalwaysontop(cbx_2.Checked);
			#line hidden
			#line 8
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))
			#line hidden
			{
				#line 10
				if (cbx_3.Checked)
				#line hidden
				{
					#line 11
					c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setlogfile(sle_1.Text);
					#line hidden
				}
				else
				{
					#line 13
					c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setlogfile(new Sybase.PowerBuilder.PBString(""));
					#line hidden
				}
				#line 17
				c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setallowinspect(cbx_4.Checked);
				#line hidden
				#line 20
				c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setalwaysontop(cbx_5.Checked);
				#line hidden
			}
		}
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
		this.cbx_5 = (c__cbx_5)this.CreateInstance(this, "c__cbx_5");
		#line hidden
		#line hidden
		this.cbx_4 = (c__cbx_4)this.CreateInstance(this, "c__cbx_4");
		#line hidden
		#line hidden
		this.cbx_3 = (c__cbx_3)this.CreateInstance(this, "c__cbx_3");
		#line hidden
		#line hidden
		this.gb_1 = (c__gb_1)this.CreateInstance(this, "c__gb_1");
		#line hidden
		#line hidden
		this.cbx_1 = (c__cbx_1)this.CreateInstance(this, "c__cbx_1");
		#line hidden
		#line hidden
		this.cbx_2 = (c__cbx_2)this.CreateInstance(this, "c__cbx_2");
		#line hidden
		#line hidden
		this.gb_2 = (c__gb_2)this.CreateInstance(this, "c__gb_2");
		#line hidden
		#line hidden
		this.sle_1 = (c__sle_1)this.CreateInstance(this, "c__sle_1");
		#line hidden
		#line hidden
		this.cb_1 = (c__cb_1)this.CreateInstance(this, "c__cb_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_5);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_4);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.sle_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_5);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_4);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_1);
		#line hidden
	}

	#line 1 "u_utilproperties.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		c__u_dw ldw_obj = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 3
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_debug)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug)))))
		#line hidden
		{
			#line 4
			cbx_1.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 5
			cbx_2.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 6
			cbx_3.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 7
			cbx_4.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 8
			cbx_5.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 9
			return new Sybase.PowerBuilder.PBLong(0);
			#line hidden
		}
		else
		{
			#line 12
			ldw_obj = (c__u_dw)this.CreateInstance(typeof(c__u_dw));
			#line hidden
			#line 13
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ldw_obj)))
			#line hidden
			{
				#line 14
				cbx_1.Checked = ldw_obj.of_issharedproperty();
				#line hidden
				#line 15
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(ldw_obj);
				#line hidden
			}
			#line 19
			cbx_2.Checked = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_getalwaysontop();
			#line hidden
			#line 22
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_sqlspy)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy)))))
			#line hidden
			{
				#line 24
				cbx_3.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 25
				cbx_4.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 26
				cbx_5.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			else
			{
				#line 29
				sle_1.Text = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_getlogfile();
				#line hidden
				#line 30
				if ((Sybase.PowerBuilder.PBBoolean)(sle_1.Text != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 31
					cbx_3.Checked = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
					#line 32
					sle_1.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
					#line 33
					cb_1.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
					#line hidden
				}
				#line 37
				cbx_4.Checked = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_getallowinspect();
				#line hidden
				#line 40
				cbx_5.Checked = c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_getalwaysontop();
				#line hidden
			}
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "u_utilproperties.cbx_5"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_5")]
	public class c__cbx_5 : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_5()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.cbx_4"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_4")]
	public class c__cbx_4 : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_4()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.cbx_3"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_3")]
	public class c__cbx_3 : c__u_cbx
	{
		#line hidden

		#line 1 "u_utilproperties.cbx_3.clicked"
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
			#line 1
			if ((Sybase.PowerBuilder.PBBoolean)(this.Checked == new Sybase.PowerBuilder.PBBoolean(true)))
			#line hidden
			{
				#line 2
				((c__u_utilproperties)(Parent)).sle_1.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
				#line 3
				((c__u_utilproperties)(Parent)).cb_1.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			else
			{
				#line 5
				((c__u_utilproperties)(Parent)).sle_1.Text = new Sybase.PowerBuilder.PBString("");
				#line hidden
				#line 6
				((c__u_utilproperties)(Parent)).sle_1.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 7
				((c__u_utilproperties)(Parent)).cb_1.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cbx_3()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.gb_1"
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


	#line 1 "u_utilproperties.cbx_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_1")]
	public class c__cbx_1 : c__u_cbx
	{
		#line hidden

		#line 1 "u_utilproperties.cbx_1.clicked"
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
			#line 46
			if ((Sybase.PowerBuilder.PBBoolean)(this.Checked == new Sybase.PowerBuilder.PBBoolean(true)))
			#line hidden
			{
				#line 47
				c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setdwproperty(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
				#line 48
				this.Checked = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			else
			{
				#line 50
				c__pfcexamp.GetCurrentApplication().gnv_app.inv_debug.of_setdwproperty(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
				#line 51
				this.Checked = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
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


	#line 1 "u_utilproperties.cbx_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_2")]
	public class c__cbx_2 : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_2()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.gb_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_2")]
	public class c__gb_2 : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_2()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.sle_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_1")]
	public class c__sle_1 : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_1()
		{
			_init();
		}

	}


	#line 1 "u_utilproperties.cb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_1")]
	public class c__cb_1 : c__u_cb
	{
		#line hidden

		#line 1 "u_utilproperties.cb_1.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBString title = new Sybase.PowerBuilder.PBString("Select SQLSpy Log File");
			Sybase.PowerBuilder.PBInt li_filenum = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_return = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBString ls_filename = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_path_filename = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 7
			Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
			#line hidden
			#line 10
			li_return = Sybase.PowerBuilder.WPF.PBSystemFunctions.GetFileSaveName(title, ref ls_path_filename, ref ls_filename, new Sybase.PowerBuilder.PBString("LOG"), new Sybase.PowerBuilder.PBString("LOG Files (*.LOG), *.LOG, *.*"));
			#line hidden
			#line 13
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_return)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 14
				((c__u_utilproperties)(Parent)).sle_1.Text = ls_path_filename;
				#line hidden
				#line 15
				li_filenum = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(ls_filename, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.LineMode)), (new Sybase.PowerBuilder.PBFileAccessValue(Sybase.PowerBuilder.PBFileAccess.Write)), (new Sybase.PowerBuilder.PBFileLockValue(Sybase.PowerBuilder.PBFileLock.LockWrite)), (new Sybase.PowerBuilder.PBWriteModeValue(Sybase.PowerBuilder.PBWriteMode.Replace)));
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

		OnInitialUpdate();
	}

	public c__u_utilproperties()
	{
		_init();
	}

}
 