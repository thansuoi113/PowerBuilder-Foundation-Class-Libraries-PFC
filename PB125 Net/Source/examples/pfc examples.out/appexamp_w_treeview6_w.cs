//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\w_treeview6.srw"
#line hidden
#line 1 "w_treeview6"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_treeview6",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_treeview6")]
public class c__w_treeview6 : c__w_main
{
	#line hidden
	public c__w_treeview6.c__dw_1 dw_1 = null;
	public c__w_treeview6.c__tv_1 tv_1 = null;

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
		this.tv_1 = (c__tv_1)this.CreateInstance(this, "c__tv_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.tv_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tv_1);
		#line hidden
	}

	#line 1 "w_treeview6.open"
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
		#line 1
		tv_1.of_setlevelsource(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 2
		tv_1.of_setbase(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 3
		tv_1.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 5
		dw_1.of_setbase(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 6
		dw_1.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
		#line hidden
		#line 7
		dw_1.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 11
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBString("sales_regions_region"), new Sybase.PowerBuilder.PBString(""), new Sybase.PowerBuilder.PBString("d_region"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 12
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBString("1"));
		#line hidden
		#line 13
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 15
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBString("states_state_name"), new Sybase.PowerBuilder.PBString(":parent.1.sales_regions_region"), new Sybase.PowerBuilder.PBString("d_regionstate"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 16
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBString("2"));
		#line hidden
		#line 17
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 19
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(3), new Sybase.PowerBuilder.PBString("customer_company_name"), new Sybase.PowerBuilder.PBString(":parent.2.sales_regions_region, :parent.1.states_state_id"), new Sybase.PowerBuilder.PBString("d_regionstatecust"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 20
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(3), new Sybase.PowerBuilder.PBString("3"));
		#line hidden
		#line 21
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(3), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 23
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(4), new Sybase.PowerBuilder.PBString("employee_emp_lname"), new Sybase.PowerBuilder.PBString(":parent.1.customer_id"), new Sybase.PowerBuilder.PBString("d_regionstatecustrep"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 24
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(4), new Sybase.PowerBuilder.PBString("4"));
		#line hidden
		#line 25
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(4), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 27
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(5), new Sybase.PowerBuilder.PBString("order_id_string"), new Sybase.PowerBuilder.PBString(":parent.2.customer_id, :parent.1.employee_emp_id"), new Sybase.PowerBuilder.PBString("d_regionstatecustrepord"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 28
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(5), new Sybase.PowerBuilder.PBString("5"));
		#line hidden
		#line 29
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(5), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 31
		tv_1.inv_levelsource.of_register(new Sybase.PowerBuilder.PBInt(6), new Sybase.PowerBuilder.PBString("product_description"), new Sybase.PowerBuilder.PBString(":parent.1.sales_order_id"), new Sybase.PowerBuilder.PBString("d_regionstatecustreporditm"), c__pfcexamp.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 32
		tv_1.inv_levelsource.of_setpicturecolumn(new Sybase.PowerBuilder.PBInt(6), new Sybase.PowerBuilder.PBString("6"));
		#line hidden
		#line 33
		tv_1.inv_levelsource.of_setselectedpicturecolumn(new Sybase.PowerBuilder.PBInt(6), new Sybase.PowerBuilder.PBString("7"));
		#line hidden
		#line 36
		tv_1.pfc_populate((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 39
		tv_1.SelectItem(tv_1.inv_base.of_findfirstitemlevel(new Sybase.PowerBuilder.PBInt(1), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
		#line hidden
		#line 41
		tv_1.inv_levelsource.of_setupdatestyle(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_treeview6.dw_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "w_treeview6.dw_1.ue_refreshview"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("ue_refreshview")]
		public virtual void ue_refreshview(Sybase.PowerBuilder.WPF.PBDataStore ads_source, Sybase.PowerBuilder.PBLong al_row)
		{
			#line hidden
			#line 1
			if ((Sybase.PowerBuilder.PBBoolean)(this.pfc_accepttext(new Sybase.PowerBuilder.PBBoolean(true)) != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 3
				return;
				#line hidden
			}
			#line 6
			this.Reset();
			#line hidden
			#line 7
			this.DataObject = ads_source.DataObject;
			#line hidden
			#line 8
			this.of_settransobject(c__pfcexamp.GetCurrentApplication().sqlca);
			#line hidden
			#line 9
			ads_source.RowsCopy(al_row, al_row, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (Sybase.PowerBuilder.IPBDataWindowControl)(((c__w_treeview6.c__dw_1)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(((c__w_treeview6)(Parent)).dw_1)))), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
			#line hidden
			#line 10
			((c__w_treeview6)(Parent)).dw_1.ResetUpdate();
			#line hidden
		}

		void _init()
		{

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	#line 1 "w_treeview6.tv_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tv_1")]
	public class c__tv_1 : c__u_tvs
	{
		#line hidden

		#line 1 "w_treeview6.tv_1.ue_update"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("ue_update")]
		public virtual void ue_update(Sybase.PowerBuilder.PBInt ai_level)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_msg = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
			c__n_ds lds_source = null;
			#line 6
			li_rc = ((c__w_treeview6)(Parent)).dw_1.pfc_accepttext(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 7
			if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 7
				return;
				#line hidden
			}
			#line 9
			li_rc = ((c__w_treeview6)(Parent)).dw_1.pfc_updatespending();
			#line hidden
			#line 10
			if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(0)))
			#line hidden
			{
				#line 12
				return;
				#line hidden
			}
			else
			{
				#line 15
				li_msg = this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_updatetree_savechanges"), c__pfcexamp.GetCurrentApplication().gnv_app.iapp_object.DisplayName, new Sybase.PowerBuilder.PBString("Do you want to save changes?"), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Exclamation)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNoCancel)), new Sybase.PowerBuilder.PBInt(1));
				#line hidden
				#line 17
				if ((Sybase.PowerBuilder.PBBoolean)(li_msg != new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 18
					return;
					#line hidden
				}
			}
			#line 22
			((c__w_treeview6)(Parent)).dw_1.of_update(new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}

		#line 1 "w_treeview6.tv_1.pfc_retrieve"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_retrieve")]
		public override Sybase.PowerBuilder.PBLong pfc_retrieve<T1>(Sybase.PowerBuilder.PBLong al_parent, ref T1 ads_data)
		{
			#line hidden
			Sybase.PowerBuilder.PBArray la_args = new Sybase.PowerBuilder.PBBoundedAnyArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,20}, false));
			Sybase.PowerBuilder.PBInt li_level = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.pfc_retrieve(al_parent, ref ads_data);
			#line hidden
			#line 5
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_levelsource)))
			#line hidden
			{
				#line 6
				li_level = this.of_getnextlevel(al_parent);
				#line hidden
				#line 7
				of_getargs_3_1875022546_3_pfc_1715530003(inv_levelsource, al_parent, li_level, ref la_args);
				#line hidden
			}
			#line 10
			return of_retrieve_3_301211210_3_pfc_1986446072(this, al_parent, (Sybase.PowerBuilder.PBBoundedAnyArray)(la_args).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20})), ref ads_data);
			#line hidden
		}

		#line 1 "w_treeview6.tv_1.selectionchanging"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanging")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_tvnselchanging)]
		public override Sybase.PowerBuilder.PBLong selectionchanging(Sybase.PowerBuilder.PBLong oldhandle, Sybase.PowerBuilder.PBLong newhandle)
		{
			#line hidden
			c__n_ds lds_datastore = null;
			Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_item = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
			Sybase.PowerBuilder.PBInt li_level = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanging(oldhandle, newhandle);
			#line hidden
			#line 6
			if ((Sybase.PowerBuilder.PBBoolean)(newhandle> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 8
				this.GetItem(newhandle, ref ltvi_item);
				#line hidden
				#line 9
				li_level = ltvi_item.Level;
				#line hidden
				#line 12
				this.ue_update(li_level);
				#line hidden
				#line 14
				this.inv_levelsource.of_getdatasource_2_1438817508(li_level, ref lds_datastore);
				#line hidden
				#line 15
				if ((Sybase.PowerBuilder.PBBoolean)(inv_levelsource.of_getdatarow_3_1438817508(newhandle, ref lds_datastore, ref ll_row) == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 16
					Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(new Sybase.PowerBuilder.PBString("Error"), new Sybase.PowerBuilder.PBString("Error in of_getdatarow"), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Exclamation)));
					#line hidden
					#line 17
					return new Sybase.PowerBuilder.PBLong(0);
					#line hidden
				}
				#line 20
				lds_datastore.ReselectRow(ll_row);
				#line hidden
				#line 21
				((c__w_treeview6)(Parent)).dw_1.ue_refreshview((Sybase.PowerBuilder.WPF.PBDataStore)(lds_datastore), ll_row);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

	public Sybase.PowerBuilder.PBInt of_getargs_3_1875022546_3_pfc_1715530003(c__pfc_n_cst_tvsrv_levelsource this__object, Sybase.PowerBuilder.PBLong al_parent, Sybase.PowerBuilder.PBInt ai_level, ref Sybase.PowerBuilder.PBArray aa_arg)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getargs_3_1875022546(al_parent, ai_level, ref aa_arg);
		return return_value;
	}

	public Sybase.PowerBuilder.PBLong of_retrieve_3_301211210_3_pfc_1986446072<T2>(c__pfc_u_tvs this__object, Sybase.PowerBuilder.PBLong al_parent, Sybase.PowerBuilder.PBArray aa_args, ref T2 ads_data) where T2: c__n_ds
	{
		 Sybase.PowerBuilder.PBArray temp_var_aa_args = new Sybase.PowerBuilder.PBBoundedAnyArray(new  Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1,20},false));
		temp_var_aa_args.AssignFrom(aa_args);
		c__n_ds temp_var_2 = ads_data;
		Sybase.PowerBuilder.PBLong return_value = this__object.of_retrieve_3_301211210(al_parent, temp_var_aa_args, ref temp_var_2);
		ads_data = (T2)temp_var_2;
		return return_value;
	}


		void _init()
		{
			this.SelectionChangingEvent += new Sybase.PowerBuilder.PBM_EventHandler_ll(this.selectionchanging);

			OnInitialUpdate();
		}

		public c__tv_1()
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

	public c__w_treeview6()
	{
		_init();
	}

}
 