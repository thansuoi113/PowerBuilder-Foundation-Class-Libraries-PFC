//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfeutil.pbl\\pfeutil.pblx\\w_sqlspyinspect.srw"
#line hidden
#line 1 "w_sqlspyinspect"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_sqlspyinspect",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\pfcapp\\pfeutil.pbl\\pfeutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_sqlspyinspect")]
public class c__w_sqlspyinspect : c__pfc_w_sqlspyinspect
{
	#line hidden
	public new c__w_sqlspyinspect.c__cb_step cb_step
	{
		get { return (c__w_sqlspyinspect.c__cb_step)base.cb_step; }
		set { base.cb_step = value; }
	}
	public new c__w_sqlspyinspect.c__cb_cancel cb_cancel
	{
		get { return (c__w_sqlspyinspect.c__cb_cancel)base.cb_cancel; }
		set { base.cb_cancel = value; }
	}
	public new c__w_sqlspyinspect.c__cb_cancelall cb_cancelall
	{
		get { return (c__w_sqlspyinspect.c__cb_cancelall)base.cb_cancelall; }
		set { base.cb_cancelall = value; }
	}
	public new c__w_sqlspyinspect.c__mle_currentheading mle_currentheading
	{
		get { return (c__w_sqlspyinspect.c__mle_currentheading)base.mle_currentheading; }
		set { base.mle_currentheading = value; }
	}
	public new c__w_sqlspyinspect.c__mle_currentsyntax mle_currentsyntax
	{
		get { return (c__w_sqlspyinspect.c__mle_currentsyntax)base.mle_currentsyntax; }
		set { base.mle_currentsyntax = value; }
	}
	public new c__w_sqlspyinspect.c__cb_resume cb_resume
	{
		get { return (c__w_sqlspyinspect.c__cb_resume)base.cb_resume; }
		set { base.cb_resume = value; }
	}
	public new c__w_sqlspyinspect.c__cb_dlghelp cb_dlghelp
	{
		get { return (c__w_sqlspyinspect.c__cb_dlghelp)base.cb_dlghelp; }
		set { base.cb_dlghelp = value; }
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
	}

	#line 1 "w_sqlspyinspect.cb_step"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_step")]
	public new class c__cb_step : c__pfc_w_sqlspyinspect.c__cb_step
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_step()
		{
			_init();
		}

	}


	#line 1 "w_sqlspyinspect.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public new class c__cb_cancel : c__pfc_w_sqlspyinspect.c__cb_cancel
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_cancel()
		{
			_init();
		}

	}


	#line 1 "w_sqlspyinspect.cb_cancelall"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancelall")]
	public new class c__cb_cancelall : c__pfc_w_sqlspyinspect.c__cb_cancelall
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_cancelall()
		{
			_init();
		}

	}


	#line 1 "w_sqlspyinspect.mle_currentheading"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_currentheading")]
	public new class c__mle_currentheading : c__pfc_w_sqlspyinspect.c__mle_currentheading
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


	#line 1 "w_sqlspyinspect.mle_currentsyntax"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_currentsyntax")]
	public new class c__mle_currentsyntax : c__pfc_w_sqlspyinspect.c__mle_currentsyntax
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


	#line 1 "w_sqlspyinspect.cb_resume"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_resume")]
	public new class c__cb_resume : c__pfc_w_sqlspyinspect.c__cb_resume
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cb_resume()
		{
			_init();
		}

	}


	#line 1 "w_sqlspyinspect.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public new class c__cb_dlghelp : c__pfc_w_sqlspyinspect.c__cb_dlghelp
	{
		#line hidden

		void _init()
		{

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

	public c__w_sqlspyinspect()
	{
		_init();
	}

}
 