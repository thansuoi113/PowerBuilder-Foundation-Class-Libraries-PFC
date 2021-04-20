//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\peat.pbl\\peat.pblx\\w_s_projectlist.srw"
#line hidden
#line 1 "w_s_projectlist"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_s_projectlist",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\demoapp\\peat.pbl\\peat.pblx",null)]
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("MenuName","m_peat_master", typeof(Sybase.PowerBuilder.PBString))]
[System.Diagnostics.DebuggerDisplay("",Type="w_s_projectlist")]
public class c__w_s_projectlist : c__w_sheet
{
	#line hidden
	public c__w_s_projectlist.c__tv_project_list tv_project_list = null;
	public c__w_s_projectlist.c__lv_project_info lv_project_info = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_projectid", null, "w_s_projectlist", 1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Private, "= 1")]
	protected Sybase.PowerBuilder.PBLong il_projectid = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_projectname", null, "w_s_projectlist", "PEAT", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Private, "= \"PEAT\"")]
	protected Sybase.PowerBuilder.PBString is_projectname = new Sybase.PowerBuilder.PBString("PEAT");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ids_project", null, "w_s_projectlist", null, null, Sybase.PowerBuilder.PBModifier.Private, "")]
	protected c__n_ds ids_project = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_explorer", null, "w_s_projectlist", null, null, Sybase.PowerBuilder.PBModifier.Private, "")]
	protected c__n_cst_explorer inv_explorer = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_prevlabel", null, "w_s_projectlist", null, null, Sybase.PowerBuilder.PBModifier.Private, "")]
	protected Sybase.PowerBuilder.PBString is_prevlabel = Sybase.PowerBuilder.PBString.DefaultValue;

	#line 1 "w_s_projectlist.peat_estimate"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_estimate")]
	public virtual void peat_estimate()
	{
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__peat.GetCurrentApplication().w_r_estimates, (Sybase.PowerBuilder.PBDouble)(il_projectid));
		#line hidden
	}

	#line 1 "w_s_projectlist.peat_actual"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_actual")]
	public virtual void peat_actual()
	{
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__peat.GetCurrentApplication().w_r_actuals, (Sybase.PowerBuilder.PBDouble)(il_projectid));
		#line hidden
	}

	#line 1 "w_s_projectlist.peat_analyzer"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_analyzer")]
	public virtual void peat_analyzer()
	{
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__peat.GetCurrentApplication().w_r_analyzer, (Sybase.PowerBuilder.PBDouble)(il_projectid));
		#line hidden
	}

	#line 1 "w_s_projectlist.peat_report"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_report")]
	public virtual void peat_report()
	{
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__peat.GetCurrentApplication().w_r_projectreport, (Sybase.PowerBuilder.PBDouble)(il_projectid));
		#line hidden
	}

	#line 1 "w_s_projectlist.peat_properties"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_properties")]
	public virtual void peat_properties()
	{
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__peat.GetCurrentApplication().w_r_projectwizard, (Sybase.PowerBuilder.PBDouble)(il_projectid));
		#line hidden
	}

	#line 1 "w_s_projectlist.peat_delete"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("peat_delete")]
	public virtual void peat_delete()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_label = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltv_local = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 8
		ll_handle = tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.CurrentTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 9
		tv_project_list.GetItem(ll_handle, ref ltv_local);
		#line hidden
		#line 10
		ls_label = ltv_local.Label;
		#line hidden
		#line 12
		if ((Sybase.PowerBuilder.PBBoolean)(ltv_local.Level != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 13
			c__peat.GetCurrentApplication().gnv_app.inv_error.of_message(c__peat.GetCurrentApplication().gnv_app.iapp_object.DisplayName, (new Sybase.PowerBuilder.PBString("Only projects can be deleted from this window.  Categories ")+ new Sybase.PowerBuilder.PBString("and derived items can be deleted from the 'Project Information' "))+ new Sybase.PowerBuilder.PBString("window."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Information)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)));
			#line hidden
			#line 17
			return;
			#line hidden
		}
		#line 25
		if ((Sybase.PowerBuilder.PBBoolean)(c__peat.GetCurrentApplication().gnv_app.inv_error.of_message(c__peat.GetCurrentApplication().gnv_app.iapp_object.DisplayName, ((new Sybase.PowerBuilder.PBString("Deleting project '")+ ls_label)+ new Sybase.PowerBuilder.PBString("' will remove all information "))+ new Sybase.PowerBuilder.PBString("associated with the project. Do you wish to continue?"), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Exclamation)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNo)), new Sybase.PowerBuilder.PBInt(2)) == new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{

			#line 27
			Sybase.PowerBuilder.DSI.PBSQL.DSISQLFunc.Delete(Sybase.PowerBuilder.WPF.PBSession.CurrentSession,
			#line 27
new Sybase.PowerBuilder.DB.DBStatement(
				#line 27
					new System.String[2] {
						"delete from project WHERE \"project\".\"project_id\" = ",
						" "
					},
					#line 27
					new Sybase.PowerBuilder.IPBValue[1] {
						il_projectid
					}
				#line 27
				),
				#line 27
				new Sybase.PowerBuilder.IPBValue[1] {
					il_projectid
				},
				#line 27
				c__peat.GetCurrentApplication().sqlca
			#line 27
			);
			#line hidden
			#line 28
			if ((Sybase.PowerBuilder.PBBoolean)(c__peat.GetCurrentApplication().sqlca.SQLCode == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 29
				c__peat.GetCurrentApplication().sqlca.of_commit();
				#line hidden
				#line 32
				ll_handle = tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.CurrentTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
				#line hidden
				#line 33
				tv_project_list.SelectItem(tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.NextVisibleTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
				#line hidden
				#line 34
				tv_project_list.DeleteItem(ll_handle);
				#line hidden
			}
			else
			{
				#line 36
				c__peat.GetCurrentApplication().sqlca.of_rollback();
				#line hidden
			}
		}
	}

	#line 1 "w_s_projectlist.of_getprojectname(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getprojectname", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getprojectname()
	{
		#line hidden
		#line 1
		return is_projectname;
		#line hidden
	}

	#line 1 "w_s_projectlist.of_refresh(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_refresh", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_refresh()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 7
		tv_project_list.of_refreshlevel(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
		#line 8
		tv_project_list.of_refreshlevel(new Sybase.PowerBuilder.PBInt(2));
		#line hidden
		#line 9
		lv_project_info.of_refresh();
		#line hidden
		#line 12
		ll_handle = tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.CurrentTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 13
		tv_project_list.SelectItem(ll_handle);
		#line hidden
		#line 14
		tv_project_list.ExpandItem(ll_handle);
		#line hidden
		#line 17
		tv_project_list.selectionchanged((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), ll_handle);
		#line hidden
		#line 19
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "w_s_projectlist.of_setexplorer(QB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setexplorer", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual void of_setexplorer(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 43
		if (ab_switch)
		#line hidden
		{
			#line 44
			if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_explorer))))
			#line hidden
			{
				#line 45
				inv_explorer = (c__n_cst_explorer)this.CreateInstance(typeof(c__n_cst_explorer), 0);
				#line hidden
				#line 46
				inv_explorer.of_setrequestor((c__w_master)(this));
				#line hidden
			}
		}
		else
		{
			#line 49
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_explorer)))
			#line hidden
			{
				#line 50
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(inv_explorer);
				#line hidden
			}
		}
		#line 54
		return;
		#line hidden
	}

	#line 1 "w_s_projectlist.of_setlistview(QCtreeviewitem.Ctreeviewitem.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setlistview", new string[]{"treeviewitem", "treeviewitem"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual void of_setlistview(Sybase.PowerBuilder.WPF.PBTreeViewItem atvi_old, Sybase.PowerBuilder.WPF.PBTreeViewItem atvi_new)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc1 = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 20
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 24
		if ((Sybase.PowerBuilder.PBBoolean)(atvi_new.Level == atvi_old.Level))
		#line hidden
		{
			#line 25
			if ((Sybase.PowerBuilder.PBBoolean)(atvi_new.Level != new Sybase.PowerBuilder.PBInt(2)))
			#line hidden
			{
				#line 26
				return;
				#line hidden
			}
			#line 28
			if ((Sybase.PowerBuilder.PBBoolean)((atvi_new.Label != new Sybase.PowerBuilder.PBString("Derived Items"))& (atvi_old.Label != new Sybase.PowerBuilder.PBString("Derived Items"))))
			#line hidden
			{
				#line 29
				return;
				#line hidden
			}
		}
		#line 34
		lv_project_info.DeleteColumns();
		#line hidden
		#line 38
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = atvi_new.Level;
		#line hidden
		#line 39
		if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBInt(1) )
		#line hidden
		{
			#line 42
			li_rc1 = lv_project_info.of_setdatasource(new Sybase.PowerBuilder.PBString("d_ds_ProjectSummary"), c__peat.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("1"));
			#line hidden
			#line 43
			li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("Category Name"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Left)), new Sybase.PowerBuilder.PBInt(750));
			#line hidden
			#line 44
			li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("estimated_hours"), new Sybase.PowerBuilder.PBString("Estimated Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(450));
			#line hidden
			#line 45
			li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("actual_hours"), new Sybase.PowerBuilder.PBString("Actual Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(350));
			#line hidden
		}
		#line 46
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBInt(2) )
		#line hidden
		{
			#line 52
			if ((Sybase.PowerBuilder.PBBoolean)(atvi_new.Label != new Sybase.PowerBuilder.PBString("Derived Items")))
			#line hidden
			{
				#line 53
				li_rc1 = lv_project_info.of_setdatasource(new Sybase.PowerBuilder.PBString("d_ds_CategorySummary"), c__peat.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("2"));
				#line hidden
				#line 54
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("Name"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Left)), new Sybase.PowerBuilder.PBInt(700));
				#line hidden
				#line 55
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("estimated_hours"), new Sybase.PowerBuilder.PBString("Est Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 56
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("actual_hours"), new Sybase.PowerBuilder.PBString("Act Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 57
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("estimated_cost"), new Sybase.PowerBuilder.PBString("Est Cost"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 58
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("actual_cost"), new Sybase.PowerBuilder.PBString("Act Cost"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
			}
			else
			{
				#line 60
				li_rc1 = lv_project_info.of_setdatasource(new Sybase.PowerBuilder.PBString("d_ds_DerivedSummary"), c__peat.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("2"));
				#line hidden
				#line 61
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString("Name"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Left)), new Sybase.PowerBuilder.PBInt(700));
				#line hidden
				#line 62
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("estimated_hours"), new Sybase.PowerBuilder.PBString("Est Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 63
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("actual_hours"), new Sybase.PowerBuilder.PBString("Act Hours"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 64
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("estimated_cost"), new Sybase.PowerBuilder.PBString("Est Cost"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
				#line 65
				li_rc1 = lv_project_info.of_addcolumn(new Sybase.PowerBuilder.PBString("actual_cost"), new Sybase.PowerBuilder.PBString("Act Cost"), (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right)), new Sybase.PowerBuilder.PBInt(300));
				#line hidden
			}
		}

	}

	#line 1 "w_s_projectlist.of_getprojectid(L)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getprojectid", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_getprojectid()
	{
		#line hidden
		#line 1
		return il_projectid;
		#line hidden
	}

	#line 1 "w_s_projectlist.of_addnewproject(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_addnewproject", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_addnewproject(Sybase.PowerBuilder.PBString as_name)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_ret = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_handle = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.WPF.PBTreeViewItem ltv_local = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
		#line 7
		this.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 8
		ll_ret = (Sybase.PowerBuilder.PBLong)(this.tv_project_list.of_discardchildren((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
		#line hidden
		#line 9
		ll_ret = this.tv_project_list.of_initialretrieve();
		#line hidden
		#line 12
		ll_handle = tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.FirstVisibleTreeItem)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 13
		while ( ll_handle != (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1)) )
		#line hidden
		{
				#line 14
				tv_project_list.GetItem(ll_handle, ref ltv_local);
				#line hidden
				#line 15
				if ((Sybase.PowerBuilder.PBBoolean)(ltv_local.Label == as_name))
				#line hidden
				{
					#line 16
					tv_project_list.SelectItem(ll_handle);
					#line hidden
					#line 17
					tv_project_list.ExpandItem(ll_handle);
					#line hidden
					#line 18
					break;
					#line hidden
				}
				else
				{
					#line 20
					ll_handle = tv_project_list.FindItem((new Sybase.PowerBuilder.PBTreeNavigationValue(Sybase.PowerBuilder.PBTreeNavigation.NextTreeItem)), ll_handle);
					#line hidden
				}
		}

		#line 25
		this.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 27
		return (Sybase.PowerBuilder.PBInt)(ll_ret);
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
		if ((Sybase.PowerBuilder.PBBoolean)(this.MenuName == new Sybase.PowerBuilder.PBString("m_peat_master")))
		#line hidden
		{
			#line hidden
			this.MenuID = (Sybase.PowerBuilder.WPF.PBMenu)((c__m_peat_master)this.CreateInstance(this, typeof(c__m_peat_master)));
			#line hidden
		}
		#line hidden
		this.tv_project_list = (c__tv_project_list)this.CreateInstance(this, "c__tv_project_list");
		#line hidden
		#line hidden
		this.lv_project_info = (c__lv_project_info)this.CreateInstance(this, "c__lv_project_info");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.tv_project_list);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.lv_project_info);
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
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(MenuID)))
		#line hidden
		{
			#line hidden
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(MenuID);
			#line hidden
		}
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.tv_project_list);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.lv_project_info);
		#line hidden
	}

	#line 1 "w_s_projectlist.pfc_postopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_postopen")]
	public override void pfc_postopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc1 = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		base.pfc_postopen();
		#line hidden
		#line 1
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 7
		li_rc1 = tv_project_list.of_setdatasource(new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBString("d_ds_projectList"), c__peat.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString(""), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBInt(1), new Sybase.PowerBuilder.PBInt(1));
		#line hidden
		#line 8
		li_rc1 = tv_project_list.of_setdatasource(new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBString("d_ds_category"), c__peat.GetCurrentApplication().sqlca, new Sybase.PowerBuilder.PBString("name"), new Sybase.PowerBuilder.PBString(":parent.1.project_id"), new Sybase.PowerBuilder.PBBoolean(false), new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBInt(2), new Sybase.PowerBuilder.PBInt(2));
		#line hidden
		#line 9
		li_rc1 = (Sybase.PowerBuilder.PBInt)(tv_project_list.of_initialretrieve());
		#line hidden
		#line 13
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc1)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 14
			tv_project_list.SelectItem((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
			#line hidden
		}
	}

	#line 1 "w_s_projectlist.close"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("close")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_close)]
	public override Sybase.PowerBuilder.PBLong close()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.close();
		#line hidden
		#line 1
		this.of_setexplorer(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_s_projectlist.open"
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
		this.of_setexplorer(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 2
		inv_explorer.of_setcontrols((Sybase.PowerBuilder.WPF.PBDragObject)(tv_project_list), (Sybase.PowerBuilder.WPF.PBDragObject)(lv_project_info));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_s_projectlist.resize"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("resize")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_size)]
	public override Sybase.PowerBuilder.PBLong resize(Sybase.PowerBuilder.PBULong sizetype, Sybase.PowerBuilder.PBInt newwidth, Sybase.PowerBuilder.PBInt newheight)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.resize(sizetype, newwidth, newheight);
		#line hidden
		#line 1
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_explorer)))
		#line hidden
		{
			#line 2
			inv_explorer.of_resize();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_s_projectlist.tv_project_list"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="tv_project_list")]
	public class c__tv_project_list : c__u_tv
	{
		#line hidden

		#line 1 "w_s_projectlist.tv_project_list.selectionchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_tvnselchanged)]
		public override Sybase.PowerBuilder.PBLong selectionchanged(Sybase.PowerBuilder.PBLong oldhandle, Sybase.PowerBuilder.PBLong newhandle)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc1 = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_current = Sybase.PowerBuilder.PBLong.DefaultValue;
			c__n_ds lds_current = null;
			Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_new = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
			Sybase.PowerBuilder.WPF.PBTreeViewItem ltvi_old = (Sybase.PowerBuilder.WPF.PBTreeViewItem) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.WPF.PBTreeViewItem));
			Sybase.PowerBuilder.PBArray la_any = new Sybase.PowerBuilder.PBBoundedAnyArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,20}, false));
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanged(oldhandle, newhandle);
			#line hidden
			#line 10
			this.GetItem(newhandle, ref ltvi_new);
			#line hidden
			#line 11
			this.GetItem(oldhandle, ref ltvi_old);
			#line hidden
			#line 16
			((c__w_s_projectlist)(Parent)).of_setlistview(((Sybase.PowerBuilder.WPF.PBTreeViewItem)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(ltvi_old))), ((Sybase.PowerBuilder.WPF.PBTreeViewItem)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(ltvi_new))));
			#line hidden
			#line 20
			Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = ltvi_new.Level;
			#line hidden
			#line 21
			if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBInt(1) )
			#line hidden
			{
				#line 22
				li_rc1 = ((c__w_s_projectlist)(Parent)).tv_project_list.of_getdatarow_3_1438817508(newhandle, ref lds_current, ref ll_row);
				#line hidden
				#line 23
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc1)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 24
					la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = (Sybase.PowerBuilder.PBAny)(lds_current.GetItemNumber(ll_row, new Sybase.PowerBuilder.PBString("project_id")));
					#line hidden
					#line 25
					((c__w_s_projectlist)(Parent)).il_projectid = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBAny(la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]));
					#line hidden
					#line 26
					((c__w_s_projectlist)(Parent)).is_projectname = lds_current.GetItemString(ll_row, new Sybase.PowerBuilder.PBString("name"));
					#line hidden
					#line 27
					li_rc1 = (Sybase.PowerBuilder.PBInt)(of_populate_1_1875022546_1_pfc1173817200(((c__w_s_projectlist)(Parent)).lv_project_info, (Sybase.PowerBuilder.PBBoundedAnyArray)(la_any).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20}))));
					#line hidden
				}
				else
				{
					#line 29
					la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0));
					#line hidden
					#line 30
					li_rc1 = (Sybase.PowerBuilder.PBInt)(of_populate_1_1875022546_1_pfc1173817200(((c__w_s_projectlist)(Parent)).lv_project_info, (Sybase.PowerBuilder.PBBoundedAnyArray)(la_any).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20}))));
					#line hidden
				}
			}
			#line 33
			else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBInt(2) )
			#line hidden
			{
				#line 34
				li_rc1 = ((c__w_s_projectlist)(Parent)).tv_project_list.of_getdatarow_3_1438817508(newhandle, ref lds_current, ref ll_row);
				#line hidden
				#line 35
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc1)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 36
					la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = (Sybase.PowerBuilder.PBAny)(lds_current.GetItemNumber(ll_row, new Sybase.PowerBuilder.PBString("project_id")));
					#line hidden
					#line 37
					la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))] = (Sybase.PowerBuilder.PBAny)(lds_current.GetItemNumber(ll_row, new Sybase.PowerBuilder.PBString("default_category_id")));
					#line hidden
					#line 38
					li_rc1 = (Sybase.PowerBuilder.PBInt)(of_populate_1_1875022546_1_pfc1173817200(((c__w_s_projectlist)(Parent)).lv_project_info, (Sybase.PowerBuilder.PBBoundedAnyArray)(la_any).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20}))));
					#line hidden
				}
				else
				{
					#line 40
					la_any[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0));
					#line hidden
					#line 41
					li_rc1 = (Sybase.PowerBuilder.PBInt)(of_populate_1_1875022546_1_pfc1173817200(((c__w_s_projectlist)(Parent)).lv_project_info, (Sybase.PowerBuilder.PBBoundedAnyArray)(la_any).ToBounded(typeof(Sybase.PowerBuilder.PBAny), new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1, 20}))));
					#line hidden
				}
			}
			else 
			{
			}

			return new Sybase.PowerBuilder.PBLong(0);
		}

	public Sybase.PowerBuilder.PBLong of_populate_1_1875022546_1_pfc1173817200(c__pfc_u_lv this__object, Sybase.PowerBuilder.PBArray aa_args)
	{
		 Sybase.PowerBuilder.PBArray temp_var_aa_args = new Sybase.PowerBuilder.PBBoundedAnyArray(new  Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1,20},false));
		temp_var_aa_args.AssignFrom(aa_args);
		Sybase.PowerBuilder.PBLong return_value = this__object.of_populate_1_1875022546(temp_var_aa_args);
		return return_value;
	}


		void _init()
		{
			this.SelectionChangedEvent += new Sybase.PowerBuilder.PBM_EventHandler_ll(this.selectionchanged);

			OnInitialUpdate();
		}

		public c__tv_project_list()
		{
			_init();
		}

	}


	#line 1 "w_s_projectlist.lv_project_info"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="lv_project_info")]
	public class c__lv_project_info : c__u_lv
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__lv_project_info()
		{
			_init();
		}

	}


	void _init()
	{
		MenuName = new Sybase.PowerBuilder.PBString("m_peat_master");
		#line hidden
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.CloseEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.close);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.ResizeEvent += new Sybase.PowerBuilder.PBM_EventHandler_mouse(this.resize);
	}

	public c__w_s_projectlist()
	{
		_init();
	}

}
 