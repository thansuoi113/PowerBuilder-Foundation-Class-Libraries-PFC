//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\u_tabpgtwo.sru"
#line hidden
#line 1 "u_tabpgtwo"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_tabpgtwo",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_tabpgtwo")]
public class c__u_tabpgtwo : c__u_tabpg
{
	#line hidden
	public c__u_tabpgtwo.c__rb_allfiles rb_allfiles = null;
	public c__u_tabpgtwo.c__rb_findfiles rb_findfiles = null;
	public c__u_tabpgtwo.c__gb_1 gb_1 = null;
	public c__u_tabpgtwo.c__rb_between rb_between = null;
	public c__u_tabpgtwo.c__rb_prevmonths rb_prevmonths = null;
	public c__u_tabpgtwo.c__rb_prevdays rb_prevdays = null;
	public c__u_tabpgtwo.c__em_startdate em_startdate = null;
	public c__u_tabpgtwo.c__em_enddate em_enddate = null;
	public c__u_tabpgtwo.c__st_1 st_1 = null;
	public c__u_tabpgtwo.c__em_months em_months = null;
	public c__u_tabpgtwo.c__em_days em_days = null;
	public c__u_tabpgtwo.c__st_2 st_2 = null;
	public c__u_tabpgtwo.c__st_3 st_3 = null;

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
		this.rb_allfiles = (c__rb_allfiles)this.CreateInstance(this, "c__rb_allfiles");
		#line hidden
		#line hidden
		this.rb_findfiles = (c__rb_findfiles)this.CreateInstance(this, "c__rb_findfiles");
		#line hidden
		#line hidden
		this.gb_1 = (c__gb_1)this.CreateInstance(this, "c__gb_1");
		#line hidden
		#line hidden
		this.rb_between = (c__rb_between)this.CreateInstance(this, "c__rb_between");
		#line hidden
		#line hidden
		this.rb_prevmonths = (c__rb_prevmonths)this.CreateInstance(this, "c__rb_prevmonths");
		#line hidden
		#line hidden
		this.rb_prevdays = (c__rb_prevdays)this.CreateInstance(this, "c__rb_prevdays");
		#line hidden
		#line hidden
		this.em_startdate = (c__em_startdate)this.CreateInstance(this, "c__em_startdate");
		#line hidden
		#line hidden
		this.em_enddate = (c__em_enddate)this.CreateInstance(this, "c__em_enddate");
		#line hidden
		#line hidden
		this.st_1 = (c__st_1)this.CreateInstance(this, "c__st_1");
		#line hidden
		#line hidden
		this.em_months = (c__em_months)this.CreateInstance(this, "c__em_months");
		#line hidden
		#line hidden
		this.em_days = (c__em_days)this.CreateInstance(this, "c__em_days");
		#line hidden
		#line hidden
		this.st_2 = (c__st_2)this.CreateInstance(this, "c__st_2");
		#line hidden
		#line hidden
		this.st_3 = (c__st_3)this.CreateInstance(this, "c__st_3");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(rb_allfiles);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(rb_findfiles);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(gb_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(rb_between);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(rb_prevmonths);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(rb_prevdays);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(em_startdate);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(em_enddate);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(em_months);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(em_days);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(13)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_3);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_allfiles);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_findfiles);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_between);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_prevmonths);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.rb_prevdays);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.em_startdate);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.em_enddate);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.em_months);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.em_days);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_3);
		#line hidden
	}

	#line 1 "u_tabpgtwo.constructor"
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
		#line 40
		em_days.Text = new Sybase.PowerBuilder.PBString("1");
		#line hidden
		#line 41
		em_months.Text = new Sybase.PowerBuilder.PBString("1");
		#line hidden
		#line 42
		em_startdate.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Today()))));
		#line hidden
		#line 43
		em_enddate.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBSystemFunctions.RelativeDate(Sybase.PowerBuilder.WPF.PBSystemFunctions.Today(), new Sybase.PowerBuilder.PBInt(30))))));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "u_tabpgtwo.rb_allfiles"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_allfiles")]
	public class c__rb_allfiles : c__u_rb
	{
		#line hidden

		#line 1 "u_tabpgtwo.rb_allfiles.clicked"
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
			((c__u_tabpgtwo)(Parent)).em_startdate.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 41
			((c__u_tabpgtwo)(Parent)).em_enddate.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 42
			((c__u_tabpgtwo)(Parent)).em_months.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 43
			((c__u_tabpgtwo)(Parent)).em_days.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_allfiles()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.rb_findfiles"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_findfiles")]
	public class c__rb_findfiles : c__u_rb
	{
		#line hidden

		#line 1 "u_tabpgtwo.rb_findfiles.clicked"
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
			((c__u_tabpgtwo)(Parent)).em_startdate.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 41
			((c__u_tabpgtwo)(Parent)).em_enddate.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 42
			((c__u_tabpgtwo)(Parent)).em_months.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 43
			((c__u_tabpgtwo)(Parent)).em_days.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__rb_findfiles()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.gb_1"
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


	#line 1 "u_tabpgtwo.rb_between"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_between")]
	public class c__rb_between : c__u_rb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__rb_between()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.rb_prevmonths"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_prevmonths")]
	public class c__rb_prevmonths : c__u_rb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__rb_prevmonths()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.rb_prevdays"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="rb_prevdays")]
	public class c__rb_prevdays : c__u_rb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__rb_prevdays()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.em_startdate"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="em_startdate")]
	public class c__em_startdate : c__u_em
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__em_startdate()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.em_enddate"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="em_enddate")]
	public class c__em_enddate : c__u_em
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__em_enddate()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.st_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_1")]
	public class c__st_1 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_1()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.em_months"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="em_months")]
	public class c__em_months : c__u_em
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__em_months()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.em_days"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="em_days")]
	public class c__em_days : c__u_em
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__em_days()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.st_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_2")]
	public class c__st_2 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_2()
		{
			_init();
		}

	}


	#line 1 "u_tabpgtwo.st_3"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_3")]
	public class c__st_3 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_3()
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

	public c__u_tabpgtwo()
	{
		_init();
	}

}
 