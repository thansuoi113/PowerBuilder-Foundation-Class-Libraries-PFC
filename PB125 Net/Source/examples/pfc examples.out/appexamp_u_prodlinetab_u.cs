//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\u_prodlinetab.sru"
#line hidden
#line 1 "u_prodlinetab"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_prodlinetab",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_prodlinetab")]
public class c__u_prodlinetab : c__u_tabpg
{
	#line hidden
	public c__u_prodlinetab.c__dw_1 dw_1 = null;
	public c__u_prodlinetab.c__p_1 p_1 = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_constructor", null, "u_prodlinetab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_constructor = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "itab_parent", null, "u_prodlinetab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_tab itab_parent = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_parentwindow", null, "u_prodlinetab", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
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
		this.p_1 = (c__p_1)this.CreateInstance(this, "c__p_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(dw_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(p_1);
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
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_1);
		#line hidden
	}

	#line 1 "u_prodlinetab.constructor"
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
		#line 47
		ltab_parent = (Sybase.PowerBuilder.WPF.PBTab)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this.GetParent()))));
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBTab)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(ltab_parent)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(ltab_parent)))))
		#line hidden
		{
			#line 50
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 53
		itab_parent = (c__u_tab)(((Sybase.PowerBuilder.WPF.PBTab)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(ltab_parent))));
		#line hidden
		#line 55
		li_upperbound = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ltab_parent.Control)));
		#line hidden
		#line 56
		li_upperbound++;
		#line hidden
		#line 57
		ltab_parent.Control[ltab_parent.Control.Extend((Sybase.PowerBuilder.PBLong)(li_upperbound))] = (Sybase.PowerBuilder.WPF.PBUserObject)(this);
		#line hidden
		#line 59
		ib_constructor = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "u_prodlinetab.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_lineitemstab", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "u_prodlinetab.dw_1.constructor"
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
			if ((Sybase.PowerBuilder.PBBoolean)(inv_linkage.of_setmaster((c__u_dw)(((c__u_prodlinetab)(Parent)).iw_parentwindow.dw_1)) != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 46
				Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(new Sybase.PowerBuilder.PBString("Linkage Error"), new Sybase.PowerBuilder.PBString("Master does not exist."));
				#line hidden
			}
			#line 51
			inv_linkage.of_register(new Sybase.PowerBuilder.PBString("sales_id"), new Sybase.PowerBuilder.PBString("sales_id"));
			#line hidden
			#line 55
			inv_linkage.of_setstyle(c__n_cst_dwsrv_linkage.retrieve);
			#line hidden
			#line 59
			inv_linkage.of_setupdateonrowchange(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 60
			inv_linkage.of_setconfirmonrowchange(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 63
			inv_linkage.of_setupdatestyle(c__n_cst_dwsrv_linkage.bottomup);
			#line hidden
			#line 65
			this.SetRowFocusIndicator((Sybase.PowerBuilder.IPBPicture)(((c__u_prodlinetab.c__p_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__u_prodlinetab)(Parent)).p_1)))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_lineitemstab");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	#line 1 "u_prodlinetab.p_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_1")]
	public class c__p_1 : c__u_p
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_1()
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

	public c__u_prodlinetab()
	{
		_init();
	}

}
 