//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx\\pfc_w_dwpropertyservices.srw"
#line hidden
#line 1 "pfc_w_dwpropertyservices"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_dwpropertyservices",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\pfcmsg\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_dwpropertyservices")]
public class c__pfc_w_dwpropertyservices : c__w_response
{
	#line hidden
	public c__pfc_w_dwpropertyservices.c__cb_ok cb_ok = null;
	public c__pfc_w_dwpropertyservices.c__tab_property tab_property = null;
	public c__pfc_w_dwpropertyservices.c__cb_dlghelp cb_dlghelp = null;
	public c__pfc_w_dwpropertyservices.c__cb_cancel cb_cancel = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_attrib", null, "pfc_w_dwpropertyservices", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_dwpropertyattrib inv_attrib = (c__n_cst_dwpropertyattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_dwpropertyattrib));

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
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.tab_property = (c__tab_property)this.CreateInstance(this, "c__tab_property");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.tab_property);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tab_property);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
	}

	#line 1 "pfc_w_dwpropertyservices.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_row = Sybase.PowerBuilder.PBInt.DefaultValue;
		c__u_dw ldw_obj = null;
		Sybase.PowerBuilder.PBString ls_dataobject = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 45
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(c__pfcmsg.GetCurrentApplication().message.PowerObjectParm))
		#line hidden
		{
			#line 46
			if ((Sybase.PowerBuilder.PBBoolean)(c__pfcmsg.GetCurrentApplication().message.PowerObjectParm.ClassName() == inv_attrib.ClassName()))
			#line hidden
			{
				#line 47
				inv_attrib = (c__n_cst_dwpropertyattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcmsg.GetCurrentApplication().message.PowerObjectParm))));
				#line hidden
			}
		}
		#line 52
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 53
		this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_attrib)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_attrib)))))
		#line hidden
		{
			#line 57
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_attrib.idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_attrib.idw_requestor)))))
		#line hidden
		{
			#line 60
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
			#line hidden
		}
		#line 65
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_attrib.iw_main)))
		#line hidden
		{
			#line 66
			this.Move((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(inv_attrib.iw_main.X)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(200))), (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(inv_attrib.iw_main.Y)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(250))));
			#line hidden
		}
		#line 69
		tab_property.pfc_propertystart(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_attrib))));
		#line hidden
		#line 71
		tab_property.pfc_propertyopen();
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_dwpropertyservices.pfc_apply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_apply")]
	public override void pfc_apply()
	{
		#line hidden
		#line 1
		base.pfc_apply();
		#line hidden
		#line 39
		tab_property.pfc_propertyapply();
		#line hidden
	}

	#line 1 "pfc_w_dwpropertyservices.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		#line 1
		base.pfc_default();
		#line hidden
		#line 40
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(tab_property.pfc_propertyvalidation())<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 42
			return;
			#line hidden
		}
		#line 46
		this.pfc_apply();
		#line hidden
		#line 49
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
	}

	#line 1 "pfc_w_dwpropertyservices.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 43
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
	}

	#line 1 "pfc_w_dwpropertyservices.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_dwpropertyservices.cb_ok.clicked"
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
			#line 39
			((c__pfc_w_dwpropertyservices)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_dwpropertyservices.tab_property"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tab_property")]
	public class c__tab_property : c__u_tab_dwproperty_srv
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__tab_property()
		{
			_init();
		}

	}


	#line 1 "pfc_w_dwpropertyservices.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_dwpropertyservices.cb_dlghelp.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10400)));
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


	#line 1 "pfc_w_dwpropertyservices.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_dwpropertyservices.cb_cancel.clicked"
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
			#line 39
			((c__pfc_w_dwpropertyservices)(this.Parent)).pfc_cancel();
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

	public c__pfc_w_dwpropertyservices()
	{
		_init();
	}

}
 