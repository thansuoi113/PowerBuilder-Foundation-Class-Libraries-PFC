//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\u_custinfotab.sru"
#line hidden
#line 1 "u_custinfotab"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_custinfotab",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_custinfotab")]
public class c__u_custinfotab : c__u_tabpg
{
	#line hidden
	public c__u_custinfotab.c__dw_1 dw_1 = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_constructor", null, "u_custinfotab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_constructor = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itab_parent", null, "u_custinfotab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_tab itab_parent = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_parentwindow", null, "u_custinfotab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_tablink iw_parentwindow = null;

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
		this.dw_1 = (c__dw_1)this.CreateInstance(this, "c__dw_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(dw_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_1);
		#line hidden
	}

	#line 1 "u_custinfotab.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_upperbound = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTab ltab_parent = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.constructor();
		#line hidden
		#line 43
		if (ib_constructor)
		#line hidden
		{
			#line 43
			return new Sybase.PowerBuilder.PBLong(0);
			#line hidden
		}
		#line 45
		this.of_getparentwindow_1_232646770(ref iw_parentwindow);
		#line hidden
		#line 46
		ltab_parent = (Sybase.PowerBuilder.WPF.PBTab)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this.GetParent()))));
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBTab)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(ltab_parent)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ltab_parent)))))
		#line hidden
		{
			#line 49
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 52
		itab_parent = (c__u_tab)(((Sybase.PowerBuilder.WPF.PBTab)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(ltab_parent))));
		#line hidden
		#line 54
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ltab_parent.Control)));
		#line hidden
		#line 55
		li_upperbound++;
		#line hidden
		#line 56
		ltab_parent.Control[ltab_parent.Control.Extend((Sybase.PowerBuilder.PBLong)(li_upperbound))] = (Sybase.PowerBuilder.WPF.PBUserObject)(this);
		#line hidden
		#line 58
		ib_constructor = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "u_custinfotab.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_custtab", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "u_custinfotab.dw_1.constructor"
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
			#line 41
			this.of_setlinkage(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 45
			if ((Sybase.PowerBuilder.PBBoolean)(inv_linkage.of_setmaster((c__u_dw)(((c__u_custinfotab)(Parent)).iw_parentwindow.dw_1)) != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 46
				Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(new Sybase.PowerBuilder.PBString("Linkage Error"), new Sybase.PowerBuilder.PBString("Master does not exist."));
				#line hidden
			}
			#line 51
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("cust_id"), new Sybase.PowerBuilder.PBString("cust_id"));
			#line hidden
			#line 55
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.scroll);
			#line hidden
			#line 63
			inv_linkage.of_setupdatestyle(c__n_cst_dwsrv_linkage.bottomup);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "u_custinfotab.dw_1.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.pfc_retrieve();
			#line hidden
			#line 49
			return this.Retrieve();
			#line hidden
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_custtab");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_1()
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

	public c__u_custinfotab()
	{
		_init();
	}

}
 