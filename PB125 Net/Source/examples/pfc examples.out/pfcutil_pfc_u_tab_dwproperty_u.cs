//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tab_dwproperty.sru"
#line hidden
#line 1 "pfc_u_tab_dwproperty"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tab_dwproperty",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tab_dwproperty")]
public class c__pfc_u_tab_dwproperty : c__u_tab
{
	#line hidden
	public c__pfc_u_tab_dwproperty.c__tabpage_services tabpage_services = null;
	public c__pfc_u_tab_dwproperty.c__tabpage_buffers tabpage_buffers = null;
	public c__pfc_u_tab_dwproperty.c__tabpage_status tabpage_status = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idw_requestor", null, "pfc_u_tab_dwproperty", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_dw idw_requestor = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_attrib", null, "pfc_u_tab_dwproperty", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_dwpropertyattrib inv_attrib = (c__n_cst_dwpropertyattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_dwpropertyattrib));

	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyinitialize")]
	[Sybase.PowerBuilder.PBNoImplementAttribute]
	public virtual Sybase.PowerBuilder.PBInt pfc_propertyinitialize(c__n_cst_dwpropertyattrib anv_attrib)
	{
		return Sybase.PowerBuilder.PBInt.NullValue;	}

	#line 1 "pfc_u_tab_dwproperty.pfc_propertyopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyopen")]
	public virtual Sybase.PowerBuilder.PBInt pfc_propertyopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBAny la_rc = Sybase.PowerBuilder.PBAny.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 51
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line 52
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 53
				la_rc = Sybase.PowerBuilder.PBMethod.InvokeDynamic(((Sybase.PowerBuilder.WPF.PBUserObject)this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]), "pfc_propertyopen", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
				#line 54
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("integer"))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("long"))))
				#line hidden
				{
					#line 56
					if ((Sybase.PowerBuilder.PBBoolean)(la_rc< (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 56
						return new Sybase.PowerBuilder.PBInt(-1);
						#line hidden
					}
				}
		}
		#line 60
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tab_dwproperty.pfc_propertyapply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyapply")]
	public virtual Sybase.PowerBuilder.PBInt pfc_propertyapply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBAny la_rc = Sybase.PowerBuilder.PBAny.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 51
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line 52
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 53
				la_rc = Sybase.PowerBuilder.PBMethod.InvokeDynamic(((Sybase.PowerBuilder.WPF.PBUserObject)this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]), "pfc_propertyapply", new Sybase.PowerBuilder.PBArgument[0] {}, 0);
				#line hidden
				#line 54
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("integer"))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("long"))))
				#line hidden
				{
					#line 56
					if ((Sybase.PowerBuilder.PBBoolean)(la_rc< (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 56
						return new Sybase.PowerBuilder.PBInt(-1);
						#line hidden
					}
				}
		}
		#line 60
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tab_dwproperty.pfc_propertystart"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertystart")]
	public virtual Sybase.PowerBuilder.PBInt pfc_propertystart(c__n_cst_dwpropertyattrib anv_attrib)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBAny la_rc = Sybase.PowerBuilder.PBAny.DefaultValue;
		Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_attrib)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_attrib)))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_attrib.idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_attrib.idw_requestor)))))
		#line hidden
		{
			#line 57
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		inv_attrib = ((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_attrib)));
		#line hidden
		#line 64
		idw_requestor = (c__u_dw)(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_attrib.idw_requestor))));
		#line hidden
		#line 67
		li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line 68
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 69
				la_rc = Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBUser1683014359(((Sybase.PowerBuilder.WPF.PBUserObject)this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]), ref inv_attrib);
				#line hidden
				#line 70
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("integer"))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName(((Sybase.PowerBuilder.PBAny)(la_rc))) == new Sybase.PowerBuilder.PBString("long"))))
				#line hidden
				{
					#line 72
					if ((Sybase.PowerBuilder.PBBoolean)(la_rc< (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 72
						return new Sybase.PowerBuilder.PBInt(-1);
						#line hidden
					}
				}
		}
		#line 77
		li_rc = this.pfc_propertyinitialize(((c__n_cst_dwpropertyattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_attrib))));
		#line hidden
		#line 79
		return li_rc;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt icurrent = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line hidden
		this.tabpage_services = (c__tabpage_services)this.CreateInstance(this, "c__tabpage_services");
		#line hidden
		#line hidden
		this.tabpage_buffers = (c__tabpage_buffers)this.CreateInstance(this, "c__tabpage_buffers");
		#line hidden
		#line hidden
		this.tabpage_status = (c__tabpage_status)this.CreateInstance(this, "c__tabpage_status");
		#line hidden
		#line hidden
		base.create();
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBUserObject)(this.tabpage_services);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBUserObject)(this.tabpage_buffers);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBUserObject)(this.tabpage_status);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tabpage_services);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tabpage_buffers);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tabpage_status);
		#line hidden
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_WPF_u002e_PBUser1683014359<T0>(Sybase.PowerBuilder.WPF.PBUserObject this__object, ref T0 temp_arg_name_0) where T0: c__n_cst_dwpropertyattrib
	{
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[1] {
			new Sybase.PowerBuilder.PBArgument(temp_arg_name_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__n_cst_dwpropertyattrib))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "pfc_propertystart", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0 = (T0)__tempArgument4DynamicCall[0].Value;

		return return_value;
	}


	#line 1 "pfc_u_tab_dwproperty.tabpage_services"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tabpage_services")]
	public class c__tabpage_services : c__u_tabpg_dwproperty_services
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__tabpage_services()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tab_dwproperty.tabpage_buffers"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tabpage_buffers")]
	public class c__tabpage_buffers : c__u_tabpg_dwproperty_buffers
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__tabpage_buffers()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tab_dwproperty.tabpage_status"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tabpage_status")]
	public class c__tabpage_status : c__u_tabpg_dwproperty_status
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__tabpage_status()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);

		OnInitialUpdate();
	}

	public c__pfc_u_tab_dwproperty()
	{
		_init();
	}

}
 