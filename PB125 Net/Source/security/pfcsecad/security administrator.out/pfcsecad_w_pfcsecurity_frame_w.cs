//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx\\w_pfcsecurity_frame.srw"
#line hidden
#line 1 "w_pfcsecurity_frame"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_pfcsecurity_frame",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx",null)]
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("MenuName","m_pfcsecurity_frame", typeof(Sybase.PowerBuilder.PBString))]
[System.Diagnostics.DebuggerDisplay("",Type="w_pfcsecurity_frame")]
public class c__w_pfcsecurity_frame : c__w_frame
{
	#line hidden
	public new c__w_pfcsecurity_frame.c__mdi_1 mdi_1
	{
		get { return (c__w_pfcsecurity_frame.c__mdi_1)base.mdi_1; }
		set { base.mdi_1 = value; }
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
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(this.MenuID)))
		#line hidden
		{
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.MenuID);
			#line hidden
		}
		#line hidden
		if ((Sybase.PowerBuilder.PBBoolean)(this.MenuName == new Sybase.PowerBuilder.PBString("m_pfcsecurity_frame")))
		#line hidden
		{
			#line hidden
			this.MenuID = (Sybase.PowerBuilder.WPF.PBMenu)((c__m_pfcsecurity_frame)this.CreateInstance(this, typeof(c__m_pfcsecurity_frame)));
			#line hidden
		}
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
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(MenuID)))
		#line hidden
		{
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(MenuID);
			#line hidden
		}
	}

	#line 1 "w_pfcsecurity_frame.open"
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
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_pfcsecurity_frame.pfc_postopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_postopen")]
	public override void pfc_postopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		base.pfc_postopen();
		#line hidden
		#line 45
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Open(ref c__pfcsecurity_admin.GetCurrentApplication().w_pfcsecurity_login, (Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
		#line 46
		if ((Sybase.PowerBuilder.PBBoolean)(c__pfcsecurity_admin.GetCurrentApplication().gnv_app.inv_trans.DBHandle() == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 47
			Sybase.PowerBuilder.PBApplication.CurrentApplication.Halt(true);
			#line hidden
			#line 48
			return;
			#line hidden
		}
	}

	#line 1 "w_pfcsecurity_frame.mdi_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mdi_1")]
	public new class c__mdi_1 : c__w_frame.c__mdi_1
	{
		#line hidden

		void _init()
		{
		}

		public c__mdi_1()
		{
			_init();
		}

	}


	void _init()
	{
		MenuName = new Sybase.PowerBuilder.PBString("m_pfcsecurity_frame");
		#line hidden
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_pfcsecurity_frame()
	{
		_init();
	}

}
 