//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_attrib.srw"
#line hidden
#line 1 "w_attrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_attrib",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_attrib")]
public class c__w_attrib : c__w_response
{
	#line hidden
	public c__w_attrib.c__cbx_readonly cbx_readonly = null;
	public c__w_attrib.c__cbx_system cbx_system = null;
	public c__w_attrib.c__cbx_hidden cbx_hidden = null;
	public c__w_attrib.c__cbx_archive cbx_archive = null;
	public c__w_attrib.c__cb_ok cb_ok = null;
	public c__w_attrib.c__cb_cancel cb_cancel = null;

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
		this.cbx_readonly = (c__cbx_readonly)this.CreateInstance(this, "c__cbx_readonly");
		#line hidden
		#line hidden
		this.cbx_system = (c__cbx_system)this.CreateInstance(this, "c__cbx_system");
		#line hidden
		#line hidden
		this.cbx_hidden = (c__cbx_hidden)this.CreateInstance(this, "c__cbx_hidden");
		#line hidden
		#line hidden
		this.cbx_archive = (c__cbx_archive)this.CreateInstance(this, "c__cbx_archive");
		#line hidden
		#line hidden
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_readonly);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_system);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_hidden);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_archive);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_readonly);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_system);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_hidden);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_archive);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
	}

	#line 1 "w_attrib.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_parm = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_readonly = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_hidden = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_system = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_archive = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 4
		ls_parm = c__pfcexamp.GetCurrentApplication().message.StringParm;
		#line hidden
		#line 6
		ls_readonly = Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_parm, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 7
		ls_hidden = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_parm, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 8
		ls_system = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_parm, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 9
		ls_archive = Sybase.PowerBuilder.WPF.PBSystemFunctions.Right(ls_parm, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 11
		cbx_readonly.Checked = lnv_conversion.of_boolean(ls_readonly);
		#line hidden
		#line 12
		cbx_hidden.Checked = lnv_conversion.of_boolean(ls_hidden);
		#line hidden
		#line 13
		cbx_system.Checked = lnv_conversion.of_boolean(ls_system);
		#line hidden
		#line 14
		cbx_archive.Checked = lnv_conversion.of_boolean(ls_archive);
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_attrib.cbx_readonly"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_readonly")]
	public class c__cbx_readonly : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_readonly()
		{
			_init();
		}

	}


	#line 1 "w_attrib.cbx_system"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_system")]
	public class c__cbx_system : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_system()
		{
			_init();
		}

	}


	#line 1 "w_attrib.cbx_hidden"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_hidden")]
	public class c__cbx_hidden : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_hidden()
		{
			_init();
		}

	}


	#line 1 "w_attrib.cbx_archive"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_archive")]
	public class c__cbx_archive : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_archive()
		{
			_init();
		}

	}


	#line 1 "w_attrib.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "w_attrib.cb_ok.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBString ls_parm = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 3
			if (((c__w_attrib)(Parent)).cbx_readonly.Checked)
			#line hidden
			{
				#line 4
				ls_parm = new Sybase.PowerBuilder.PBString("1");
				#line hidden
			}
			else
			{
				#line 6
				ls_parm = new Sybase.PowerBuilder.PBString("0");
				#line hidden
			}
			#line 9
			if (((c__w_attrib)(Parent)).cbx_hidden.Checked)
			#line hidden
			{
				#line 10
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("1");
				#line hidden
			}
			else
			{
				#line 12
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("0");
				#line hidden
			}
			#line 15
			if (((c__w_attrib)(Parent)).cbx_system.Checked)
			#line hidden
			{
				#line 16
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("1");
				#line hidden
			}
			else
			{
				#line 18
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("0");
				#line hidden
			}
			#line 21
			if (((c__w_attrib)(Parent)).cbx_archive.Checked)
			#line hidden
			{
				#line 22
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("1");
				#line hidden
			}
			else
			{
				#line 24
				ls_parm = ls_parm+ new Sybase.PowerBuilder.PBString("0");
				#line hidden
			}
			#line 27
			Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(((c__w_attrib)(this.Parent))), ls_parm);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_ok()
		{
			_init();
		}

	}


	#line 1 "w_attrib.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "w_attrib.cb_cancel.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(((c__w_attrib)(this.Parent))), new Sybase.PowerBuilder.PBString(""));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_cancel()
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

	public c__w_attrib()
	{
		_init();
	}

}
 