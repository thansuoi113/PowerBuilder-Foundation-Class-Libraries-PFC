//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfcutil.pbl\\pfcutil.pblx\\pfc_w_sqlspyinspect.srw"
#line hidden
#line 1 "pfc_w_sqlspyinspect"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_sqlspyinspect",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\pfcapp\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_sqlspyinspect")]
public class c__pfc_w_sqlspyinspect : c__w_response
{
	#line hidden
	public c__pfc_w_sqlspyinspect.c__cb_step cb_step = null;
	public c__pfc_w_sqlspyinspect.c__cb_cancel cb_cancel = null;
	public c__pfc_w_sqlspyinspect.c__cb_cancelall cb_cancelall = null;
	public c__pfc_w_sqlspyinspect.c__mle_currentheading mle_currentheading = null;
	public c__pfc_w_sqlspyinspect.c__mle_currentsyntax mle_currentsyntax = null;
	public c__pfc_w_sqlspyinspect.c__cb_resume cb_resume = null;
	public c__pfc_w_sqlspyinspect.c__cb_dlghelp cb_dlghelp = null;

	#line 1 "pfc_w_sqlspyinspect.of_populatebeforeclose(QCcommandbutton.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_populatebeforeclose", new string[]{"commandbutton"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual void of_populatebeforeclose(Sybase.PowerBuilder.WPF.PBCommandButton acb_pressed)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(-1);
		#line 56
		c__generic_pfc_app.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setcurrentheading(mle_currentheading.Text);
		#line hidden
		#line 57
		c__generic_pfc_app.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setcurrentsyntax(mle_currentsyntax.Text);
		#line hidden
		#line 60
		if ((Sybase.PowerBuilder.PBBoolean)(acb_pressed == (Sybase.PowerBuilder.WPF.PBCommandButton)(cb_cancel)))
		#line hidden
		{
			#line 61
			li_rc = new Sybase.PowerBuilder.PBInt(2);
			#line hidden
		}
		#line 62
		else if ((Sybase.PowerBuilder.PBBoolean)(acb_pressed == (Sybase.PowerBuilder.WPF.PBCommandButton)(cb_cancelall)))
		#line hidden
		{
			#line 63
			li_rc = new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 64
		else if ((Sybase.PowerBuilder.PBBoolean)(acb_pressed == (Sybase.PowerBuilder.WPF.PBCommandButton)(cb_step)))
		#line hidden
		{
			#line 65
			li_rc = new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 66
		else if ((Sybase.PowerBuilder.PBBoolean)(acb_pressed == (Sybase.PowerBuilder.WPF.PBCommandButton)(cb_resume)))
		#line hidden
		{
			#line 68
			c__generic_pfc_app.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_setbatchmode(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 69
			li_rc = new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 73
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBDouble)(li_rc));
		#line hidden
		#line 75
		return;
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
		this.cb_step = (c__cb_step)this.CreateInstance(this, "c__cb_step");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.cb_cancelall = (c__cb_cancelall)this.CreateInstance(this, "c__cb_cancelall");
		#line hidden
		#line hidden
		this.mle_currentheading = (c__mle_currentheading)this.CreateInstance(this, "c__mle_currentheading");
		#line hidden
		#line hidden
		this.mle_currentsyntax = (c__mle_currentsyntax)this.CreateInstance(this, "c__mle_currentsyntax");
		#line hidden
		#line hidden
		this.cb_resume = (c__cb_resume)this.CreateInstance(this, "c__cb_resume");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_step);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancelall);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.mle_currentheading);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.mle_currentsyntax);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_resume);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_step);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancelall);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.mle_currentheading);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.mle_currentsyntax);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_resume);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
	}

	#line 1 "pfc_w_sqlspyinspect.pfc_preopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_preopen")]
	public override void pfc_preopen()
	{
		#line hidden
		#line 1
		base.pfc_preopen();
		#line hidden
		#line 43
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 46
		mle_currentsyntax.SetFocus();
		#line hidden
		#line 49
		mle_currentheading.Text = c__generic_pfc_app.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_getcurrentheading();
		#line hidden
		#line 50
		mle_currentsyntax.Text = c__generic_pfc_app.GetCurrentApplication().gnv_app.inv_debug.inv_sqlspy.of_getcurrentsyntax();
		#line hidden
		#line 53
		if (c__generic_pfc_app.GetCurrentApplication().gnv_app.of_isregistryavailable())
		#line hidden
		{
			#line 54
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(c__generic_pfc_app.GetCurrentApplication().gnv_app.of_getuserkey())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 55
				this.of_setpreference(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		else
		{
			#line 58
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(c__generic_pfc_app.GetCurrentApplication().gnv_app.of_getuserinifile())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 59
				this.of_setpreference(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
	}

	#line 1 "pfc_w_sqlspyinspect.cb_step"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_step")]
	public class c__cb_step : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sqlspyinspect.cb_step.clicked"
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
			#line 44
			((c__pfc_w_sqlspyinspect)(Parent)).of_populatebeforeclose((Sybase.PowerBuilder.WPF.PBCommandButton)(this));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_step()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sqlspyinspect.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sqlspyinspect.cb_cancel.clicked"
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
			#line 44
			((c__pfc_w_sqlspyinspect)(Parent)).of_populatebeforeclose((Sybase.PowerBuilder.WPF.PBCommandButton)(this));
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


	#line 1 "pfc_w_sqlspyinspect.cb_cancelall"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancelall")]
	public class c__cb_cancelall : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sqlspyinspect.cb_cancelall.clicked"
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
			#line 44
			((c__pfc_w_sqlspyinspect)(Parent)).of_populatebeforeclose((Sybase.PowerBuilder.WPF.PBCommandButton)(this));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_cancelall()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sqlspyinspect.mle_currentheading"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_currentheading")]
	public class c__mle_currentheading : c__u_mle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__mle_currentheading()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sqlspyinspect.mle_currentsyntax"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_currentsyntax")]
	public class c__mle_currentsyntax : c__u_mle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__mle_currentsyntax()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sqlspyinspect.cb_resume"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_resume")]
	public class c__cb_resume : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sqlspyinspect.cb_resume.clicked"
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
			#line 44
			((c__pfc_w_sqlspyinspect)(Parent)).of_populatebeforeclose((Sybase.PowerBuilder.WPF.PBCommandButton)(this));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_resume()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sqlspyinspect.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sqlspyinspect.cb_dlghelp.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10600)));
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
	}

	public c__pfc_w_sqlspyinspect()
	{
		_init();
	}

}
 