//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_w_about.srw"
#line hidden
#line 1 "pfc_w_about"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_about",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_about")]
public class c__pfc_w_about : c__w_response
{
	#line hidden
	public c__pfc_w_about.c__p_about p_about = null;
	public c__pfc_w_about.c__st_application st_application = null;
	public c__pfc_w_about.c__st_version st_version = null;
	public c__pfc_w_about.c__cb_ok cb_ok = null;
	public c__pfc_w_about.c__st_copyright st_copyright = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_aboutattrib", null, "pfc_w_about", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_aboutattrib inv_aboutattrib = (c__n_cst_aboutattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_aboutattrib));

	#line 1 "pfc_w_about.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		#line 1
		base.pfc_default();
		#line hidden
		#line 43
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
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
		this.p_about = (c__p_about)this.CreateInstance(this, "c__p_about");
		#line hidden
		#line hidden
		this.st_application = (c__st_application)this.CreateInstance(this, "c__st_application");
		#line hidden
		#line hidden
		this.st_version = (c__st_version)this.CreateInstance(this, "c__st_version");
		#line hidden
		#line hidden
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.st_copyright = (c__st_copyright)this.CreateInstance(this, "c__st_copyright");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.p_about);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_application);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_version);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_copyright);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_about);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_application);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_version);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_copyright);
		#line hidden
	}

	#line 1 "pfc_w_about.open"
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
		#line 44
		inv_aboutattrib = (c__n_cst_aboutattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcexamp.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 47
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_aboutattrib.is_logo)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 51
			p_about.PictureName = inv_aboutattrib.is_logo;
			#line hidden
		}
		else
		{
			#line 53
			p_about.Visible = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_aboutattrib.is_application)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 58
			st_application.Text = inv_aboutattrib.is_application;
			#line hidden
			#line 59
			this.Title = new Sybase.PowerBuilder.PBString("About ")+ inv_aboutattrib.is_application;
			#line hidden
		}
		else
		{
			#line 61
			st_application.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
			#line 62
			this.Title = new Sybase.PowerBuilder.PBString("About");
			#line hidden
		}
		#line 66
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_aboutattrib.is_version)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 67
			st_version.Text = inv_aboutattrib.is_version;
			#line hidden
		}
		else
		{
			#line 69
			st_version.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 73
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_aboutattrib.is_copyright)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 74
			st_copyright.Text = inv_aboutattrib.is_copyright;
			#line hidden
		}
		else
		{
			#line 76
			st_copyright.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_about.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
	}

	#line 1 "pfc_w_about.p_about"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_about")]
	public class c__p_about : c__u_p
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_about()
		{
			_init();
		}

	}


	#line 1 "pfc_w_about.st_application"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_application")]
	public class c__st_application : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_application()
		{
			_init();
		}

	}


	#line 1 "pfc_w_about.st_version"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_version")]
	public class c__st_version : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_version()
		{
			_init();
		}

	}


	#line 1 "pfc_w_about.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_about.cb_ok.clicked"
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
			((c__pfc_w_about)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_about.st_copyright"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_copyright")]
	public class c__st_copyright : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_copyright()
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

	public c__pfc_w_about()
	{
		_init();
	}

}
 