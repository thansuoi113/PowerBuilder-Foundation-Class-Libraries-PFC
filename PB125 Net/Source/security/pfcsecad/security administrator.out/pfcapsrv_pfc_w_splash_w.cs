//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_w_splash.srw"
#line hidden
#line 1 "pfc_w_splash"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_splash",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_splash")]
public class c__pfc_w_splash : c__w_popup
{
	#line hidden
	public c__pfc_w_splash.c__st_copyright st_copyright = null;
	public c__pfc_w_splash.c__st_version st_version = null;
	public c__pfc_w_splash.c__st_application st_application = null;
	public c__pfc_w_splash.c__gb_allaround gb_allaround = null;
	public c__pfc_w_splash.c__ln_1 ln_1 = null;
	public c__pfc_w_splash.c__ln_2 ln_2 = null;
	public c__pfc_w_splash.c__ln_3 ln_3 = null;
	public c__pfc_w_splash.c__ln_4 ln_4 = null;
	public c__pfc_w_splash.c__p_splash p_splash = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_splashattrib", null, "pfc_w_splash", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_cst_splashattrib inv_splashattrib = (c__n_cst_splashattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_splashattrib));

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
		this.st_copyright = (c__st_copyright)this.CreateInstance(this, "c__st_copyright");
		#line hidden
		#line hidden
		this.st_version = (c__st_version)this.CreateInstance(this, "c__st_version");
		#line hidden
		#line hidden
		this.st_application = (c__st_application)this.CreateInstance(this, "c__st_application");
		#line hidden
		#line hidden
		this.gb_allaround = (c__gb_allaround)this.CreateInstance(this, "c__gb_allaround");
		#line hidden
		#line hidden
		this.ln_1 = (c__ln_1)this.CreateInstance(this, "c__ln_1");
		#line hidden
		#line hidden
		this.ln_2 = (c__ln_2)this.CreateInstance(this, "c__ln_2");
		#line hidden
		#line hidden
		this.ln_3 = (c__ln_3)this.CreateInstance(this, "c__ln_3");
		#line hidden
		#line hidden
		this.ln_4 = (c__ln_4)this.CreateInstance(this, "c__ln_4");
		#line hidden
		#line hidden
		this.p_splash = (c__p_splash)this.CreateInstance(this, "c__p_splash");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_copyright);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_version);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_application);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_allaround);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ln_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ln_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ln_3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ln_4);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.p_splash);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_copyright);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_version);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_application);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_allaround);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ln_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ln_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ln_3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ln_4);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_splash);
		#line hidden
	}

	#line 1 "pfc_w_splash.open"
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
		#line 43
		inv_splashattrib = (c__n_cst_splashattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 46
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 49
		this.of_setbase(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 50
		inv_base.of_center();
		#line hidden
		#line 53
		this.SetPosition((new Sybase.PowerBuilder.PBSetPosTypeValue(Sybase.PowerBuilder.PBSetPosType.TopMost)));
		#line hidden
		#line 54
		gb_allaround.SetPosition((new Sybase.PowerBuilder.PBSetPosTypeValue(Sybase.PowerBuilder.PBSetPosType.ToBottom)));
		#line hidden
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_splashattrib.is_logo)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 58
			p_splash.PictureName = inv_splashattrib.is_logo;
			#line hidden
		}
		else
		{
			#line 60
			p_splash.Visible = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 64
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_splashattrib.is_copyright)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 65
			st_copyright.Text = inv_splashattrib.is_copyright;
			#line hidden
		}
		else
		{
			#line 67
			st_copyright.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 71
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_splashattrib.is_application)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 72
			st_application.Text = inv_splashattrib.is_application;
			#line hidden
		}
		else
		{
			#line 74
			st_application.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 78
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_splashattrib.is_version)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 79
			st_version.Text = inv_splashattrib.is_version;
			#line hidden
		}
		else
		{
			#line 81
			st_version.Text = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 85
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Timer((Sybase.PowerBuilder.PBDouble)(inv_splashattrib.ii_secondsvisible));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_splash.timer"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("timer")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_timer)]
	public override Sybase.PowerBuilder.PBLong timer()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.timer();
		#line hidden
		#line 40
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Timer((Sybase.PowerBuilder.PBDouble)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 41
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_splash.st_copyright"
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


	#line 1 "pfc_w_splash.st_version"
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


	#line 1 "pfc_w_splash.st_application"
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


	#line 1 "pfc_w_splash.gb_allaround"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_allaround")]
	public class c__gb_allaround : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_allaround()
		{
			_init();
		}

	}


	#line 1 "pfc_w_splash.ln_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("enabled",false, typeof(Sybase.PowerBuilder.PBBoolean))]
	[System.Diagnostics.DebuggerDisplay("",Type="ln_1")]
	public class c__ln_1 : Sybase.PowerBuilder.WPF.PBLine
	{
		#line hidden
		public Sybase.PowerBuilder.PBBoolean enabled = Sybase.PowerBuilder.PBBoolean.DefaultValue;

		void _init()
		{
			enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden

			OnInitialUpdate();
		}

		public c__ln_1()
		{
			_init();
		}

	}


	#line 1 "pfc_w_splash.ln_2"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("enabled",false, typeof(Sybase.PowerBuilder.PBBoolean))]
	[System.Diagnostics.DebuggerDisplay("",Type="ln_2")]
	public class c__ln_2 : Sybase.PowerBuilder.WPF.PBLine
	{
		#line hidden
		public Sybase.PowerBuilder.PBBoolean enabled = Sybase.PowerBuilder.PBBoolean.DefaultValue;

		void _init()
		{
			enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden

			OnInitialUpdate();
		}

		public c__ln_2()
		{
			_init();
		}

	}


	#line 1 "pfc_w_splash.ln_3"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("enabled",false, typeof(Sybase.PowerBuilder.PBBoolean))]
	[System.Diagnostics.DebuggerDisplay("",Type="ln_3")]
	public class c__ln_3 : Sybase.PowerBuilder.WPF.PBLine
	{
		#line hidden
		public Sybase.PowerBuilder.PBBoolean enabled = Sybase.PowerBuilder.PBBoolean.DefaultValue;

		void _init()
		{
			enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden

			OnInitialUpdate();
		}

		public c__ln_3()
		{
			_init();
		}

	}


	#line 1 "pfc_w_splash.ln_4"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("enabled",false, typeof(Sybase.PowerBuilder.PBBoolean))]
	[System.Diagnostics.DebuggerDisplay("",Type="ln_4")]
	public class c__ln_4 : Sybase.PowerBuilder.WPF.PBLine
	{
		#line hidden
		public Sybase.PowerBuilder.PBBoolean enabled = Sybase.PowerBuilder.PBBoolean.DefaultValue;

		void _init()
		{
			enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden

			OnInitialUpdate();
		}

		public c__ln_4()
		{
			_init();
		}

	}


	#line 1 "pfc_w_splash.p_splash"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_splash")]
	public class c__p_splash : c__u_p
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_splash()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.TimerEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.timer);
	}

	public c__pfc_w_splash()
	{
		_init();
	}

}
 