//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_dwresizegrid.srw"
#line hidden
#line 1 "w_dwresizegrid"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_dwresizegrid",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_dwresizegrid")]
public class c__w_dwresizegrid : c__w_main
{
	#line hidden
	public c__w_dwresizegrid.c__dw_1 dw_1 = null;
	public c__w_dwresizegrid.c__cb_2 cb_2 = null;

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
		this.cb_2 = (c__cb_2)this.CreateInstance(this, "c__cb_2");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_2);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_2);
		#line hidden
	}

	#line 1 "w_dwresizegrid.pfc_preopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_preopen")]
	public override void pfc_preopen()
	{
		#line hidden
		#line 17
		this.of_setresize(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 18
		this.inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_2), c__n_cst_resize.fixedrightbottom);
		#line hidden
		#line 19
		this.inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(dw_1), c__n_cst_resize.scalerightbottom);
		#line hidden
	}

	#line 1 "w_dwresizegrid.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_ddobjsamp", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "w_dwresizegrid.dw_1.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			this.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
			#line hidden
			#line 13
			this.of_setresize(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 15
			inv_resize.of_register(new Sybase.PowerBuilder.PBString("sales_order_order_date"), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(20), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 16
			inv_resize.of_register(new Sybase.PowerBuilder.PBString("customer_lname"), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(20), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 17
			inv_resize.of_register(new Sybase.PowerBuilder.PBString("customer_phone"), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(20), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 18
			inv_resize.of_register(new Sybase.PowerBuilder.PBString("sales_order_items_quantity"), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(20), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 19
			inv_resize.of_register(new Sybase.PowerBuilder.PBString("sales_order_items_prod_id"), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(0), new Sybase.PowerBuilder.PBInt(20), new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 21
			this.of_retrieve();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "w_dwresizegrid.dw_1.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 20
			return this.Retrieve();
			#line hidden
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_ddobjsamp");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	#line 1 "w_dwresizegrid.cb_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_2")]
	public class c__cb_2 : c__u_cb
	{
		#line hidden

		#line 1 "w_dwresizegrid.cb_2.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 11
			((c__w_dwresizegrid)(this.Parent)).pfc_close();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_2()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_dwresizegrid()
	{
		_init();
	}

}
 