//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx\\pfc_w_dwproperty.srw"
#line hidden
#line 1 "pfc_w_dwproperty"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_dwproperty",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_dwproperty")]
public class c__pfc_w_dwproperty : c__w_response
{
	#line hidden
	public c__pfc_w_dwproperty.c__cb_ok cb_ok = null;
	public c__pfc_w_dwproperty.c__tab_property tab_property = null;
	public c__pfc_w_dwproperty.c__cb_dlghelp cb_dlghelp = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_attrib", null, "pfc_w_dwproperty", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_dwpropertyattrib inv_attrib = (c__n_cst_dwpropertyattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_dwpropertyattrib));

	[Sybase.PowerBuilder.PBEventAttribute("pfc_applyothers")]
	[Sybase.PowerBuilder.PBNoImplementAttribute]
	public virtual Sybase.PowerBuilder.PBInt pfc_applyothers(Sybase.PowerBuilder.PBString as_servicename, Sybase.PowerBuilder.PBBoolean ab_desiredstate)
	{
		return Sybase.PowerBuilder.PBInt.NullValue;	}

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
	}

	#line 1 "pfc_w_dwproperty.open"
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
		#line 6
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 9
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))
		#line hidden
		{
			#line 10
			if ((Sybase.PowerBuilder.PBBoolean)(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm.ClassName() == inv_attrib.ClassName()))
			#line hidden
			{
				#line 11
				inv_attrib = (c__n_cst_dwpropertyattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))));
				#line hidden
			}
		}
		#line 16
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 17
		this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 20
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_attrib)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_attrib)))))
		#line hidden
		{
			#line 21
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
			#line hidden
		}
		#line 23
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_attrib.idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_attrib.idw_requestor)))))
		#line hidden
		{
			#line 24
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
			#line hidden
		}
		#line 29
		this.Title += new Sybase.PowerBuilder.PBString(" ")+ inv_attrib.idw_requestor.DataObject;
		#line hidden
		#line 32
		li_rc = tab_property.pfc_propertystart(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_attrib))));
		#line hidden
		#line 33
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 34
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
			#line hidden
			#line 35
			return new Sybase.PowerBuilder.PBLong(0);
			#line hidden
		}
		#line 39
		li_rc = tab_property.pfc_propertyopen();
		#line hidden
		#line 41
		return new Sybase.PowerBuilder.PBLong(0);
		#line hidden
	}

	#line 1 "pfc_w_dwproperty.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		#line 1
		base.pfc_default();
		#line hidden
		#line 40
		this.pfc_apply();
		#line hidden
		#line 43
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
	}

	#line 1 "pfc_w_dwproperty.pfc_apply"
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

	#line 1 "pfc_w_dwproperty.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(this));
		#line hidden
	}

	#line 1 "pfc_w_dwproperty.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_dwproperty.cb_ok.clicked"
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
			((c__pfc_w_dwproperty)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_dwproperty.tab_property"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tab_property")]
	public class c__tab_property : c__u_tab_dwproperty
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


	#line 1 "pfc_w_dwproperty.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_dwproperty.cb_dlghelp.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_helpindex = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 43
			li_helpindex = (Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBLong)(((c__pfc_w_dwproperty)(Parent)).tab_property.SelectedTab)* (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(100)))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10000)));
			#line hidden
			#line 45
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(li_helpindex));
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
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
	}

	public c__pfc_w_dwproperty()
	{
		_init();
	}

}
 