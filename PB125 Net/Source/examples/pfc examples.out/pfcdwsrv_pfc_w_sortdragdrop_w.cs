//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_w_sortdragdrop.srw"
#line hidden
#line 1 "pfc_w_sortdragdrop"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_sortdragdrop",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_sortdragdrop")]
public class c__pfc_w_sortdragdrop : c__w_response
{
	#line hidden
	public c__pfc_w_sortdragdrop.c__dw_sorted dw_sorted = null;
	public c__pfc_w_sortdragdrop.c__st_3 st_3 = null;
	public c__pfc_w_sortdragdrop.c__st_4 st_4 = null;
	public c__pfc_w_sortdragdrop.c__st_2 st_2 = null;
	public c__pfc_w_sortdragdrop.c__dw_sortcolumns dw_sortcolumns = null;
	public c__pfc_w_sortdragdrop.c__cb_ok cb_ok = null;
	public c__pfc_w_sortdragdrop.c__cb_cancel cb_cancel = null;
	public c__pfc_w_sortdragdrop.c__cb_dlghelp cb_dlghelp = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_availablerow", null, "pfc_w_sortdragdrop", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBLong il_availablerow = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_sortingrow", null, "pfc_w_sortdragdrop", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBLong il_sortingrow = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_sortattrib", null, "pfc_w_sortdragdrop", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_sortattrib inv_sortattrib = (c__n_cst_sortattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_sortattrib));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_return", null, "pfc_w_sortdragdrop", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_returnattrib inv_return = (c__n_cst_returnattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_returnattrib));

	#line 1 "pfc_w_sortdragdrop.of_buildsortstring(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_buildsortstring", new string[]{}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_buildsortstring()
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_colname = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_sortitem = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_sortstring = new Sybase.PowerBuilder.PBString("");
		Sybase.PowerBuilder.PBInt li_i = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_max = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 52
		li_max = (Sybase.PowerBuilder.PBInt)(dw_sorted.RowCount());
		#line hidden
		#line 53
		for (li_i = new Sybase.PowerBuilder.PBInt(1);li_i <= li_max;li_i = li_i + 1)
		#line hidden
		{
				#line 56
				ls_colname = dw_sorted.GetItemString((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBString("columnname"));
				#line hidden
				#line 57
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_colname))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(ls_colname)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
				#line hidden
				{
					#line 57
					continue;
					#line hidden
				}
				#line 60
				if ((Sybase.PowerBuilder.PBBoolean)(dw_sorted.GetItemString((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBString("use_display")) == new Sybase.PowerBuilder.PBString("1")))
				#line hidden
				{
					#line 62
					ls_sortitem = (new Sybase.PowerBuilder.PBString("LookUpDisplay(")+ ls_colname)+ new Sybase.PowerBuilder.PBString(") ");
					#line hidden
				}
				else
				{
					#line 65
					ls_sortitem = ls_colname+ new Sybase.PowerBuilder.PBString(" ");
					#line hidden
				}
				#line 69
				ls_sortitem = (ls_sortitem+ dw_sorted.GetItemString((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBString("sort_order")))+ new Sybase.PowerBuilder.PBString(" ");
				#line hidden
				#line 72
				ls_sortstring = ls_sortstring+ ls_sortitem;
				#line hidden
		}
		#line 76
		return ls_sortstring;
		#line hidden
	}

	#line 1 "pfc_w_sortdragdrop.open"
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
		#line 41
		inv_sortattrib = (c__n_cst_sortattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcexamp.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 44
		this.of_setbase(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 47
		inv_base.of_center();
		#line hidden
		#line 50
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 52
		((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_sortcolumns.Object))[new Sybase.PowerBuilder.PBString(@"display_column"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"width")] = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(2194));
		#line hidden
		#line 53
		((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_sortcolumns.Object))[new Sybase.PowerBuilder.PBString(@"sort_order"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"visible")] = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
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
		this.dw_sorted = (c__dw_sorted)this.CreateInstance(this, "c__dw_sorted");
		#line hidden
		#line hidden
		this.st_3 = (c__st_3)this.CreateInstance(this, "c__st_3");
		#line hidden
		#line hidden
		this.st_4 = (c__st_4)this.CreateInstance(this, "c__st_4");
		#line hidden
		#line hidden
		this.st_2 = (c__st_2)this.CreateInstance(this, "c__st_2");
		#line hidden
		#line hidden
		this.dw_sortcolumns = (c__dw_sortcolumns)this.CreateInstance(this, "c__dw_sortcolumns");
		#line hidden
		#line hidden
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_sorted);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_4);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_sortcolumns);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_sorted);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_4);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_sortcolumns);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
	}

	#line 1 "pfc_w_sortdragdrop.pfc_postopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_postopen")]
	public override void pfc_postopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_i = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_sortnumcols = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_orignumcols = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_found = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_newrow = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		base.pfc_postopen();
		#line hidden
		#line 41
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 44
		dw_sortcolumns.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 48
		li_sortnumcols = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_sortattrib.is_sortcolumns)));
		#line hidden
		#line 49
		for (li_i = new Sybase.PowerBuilder.PBInt(1);li_i <= li_sortnumcols;li_i = li_i + 1)
		#line hidden
		{
				#line 51
				li_newrow = (Sybase.PowerBuilder.PBInt)(dw_sortcolumns.InsertRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
				#line hidden
				#line 53
				dw_sortcolumns.SetItem((Sybase.PowerBuilder.PBLong)(li_newrow), new Sybase.PowerBuilder.PBString("columnname"), ((Sybase.PowerBuilder.PBString)inv_sortattrib.is_sortcolumns[(Sybase.PowerBuilder.PBLong)(li_i)]));
				#line hidden
				#line 54
				dw_sortcolumns.SetItem((Sybase.PowerBuilder.PBLong)(li_newrow), new Sybase.PowerBuilder.PBString("displayname"), ((Sybase.PowerBuilder.PBString)inv_sortattrib.is_colnamedisplay[(Sybase.PowerBuilder.PBLong)(li_i)]));
				#line hidden
				#line 55
				if (((Sybase.PowerBuilder.PBBoolean)inv_sortattrib.ib_usedisplay[(Sybase.PowerBuilder.PBLong)(li_i)]))
				#line hidden
				{
					#line 56
					dw_sortcolumns.SetItem((Sybase.PowerBuilder.PBLong)(li_newrow), new Sybase.PowerBuilder.PBString("use_display"), new Sybase.PowerBuilder.PBString("1"));
					#line hidden
				}
				else
				{
					#line 58
					dw_sortcolumns.SetItem((Sybase.PowerBuilder.PBLong)(li_newrow), new Sybase.PowerBuilder.PBString("use_display"), new Sybase.PowerBuilder.PBString("0"));
					#line hidden
				}
		}
		#line 63
		dw_sortcolumns.SetSort(new Sybase.PowerBuilder.PBString("displayname A"));
		#line hidden
		#line 64
		dw_sortcolumns.Sort();
		#line hidden
		#line 67
		li_orignumcols = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_sortattrib.is_origcolumns)));
		#line hidden
		#line 68
		for (li_i = new Sybase.PowerBuilder.PBInt(1);li_i <= li_orignumcols;li_i = li_i + 1)
		#line hidden
		{
				#line 70
				li_found = (Sybase.PowerBuilder.PBInt)(dw_sortcolumns.Find((new Sybase.PowerBuilder.PBString("columnname = '")+ ((Sybase.PowerBuilder.PBString)inv_sortattrib.is_origcolumns[(Sybase.PowerBuilder.PBLong)(li_i)]))+ new Sybase.PowerBuilder.PBString("'"), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), dw_sortcolumns.RowCount()));
				#line hidden
				#line 72
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_found)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 74
					li_rc = dw_sortcolumns.RowsMove((Sybase.PowerBuilder.PBLong)(li_found), (Sybase.PowerBuilder.PBLong)(li_found), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_w_sortdragdrop.c__dw_sorted)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dw_sorted)))), dw_sorted.RowCount()+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
					#line hidden
					#line 78
					dw_sorted.SetItem((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBString("sort_order"), ((Sybase.PowerBuilder.PBString)inv_sortattrib.is_origorder[(Sybase.PowerBuilder.PBLong)(li_i)]));
					#line hidden
				}
		}
		#line 83
		dw_sortcolumns.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
	}

	#line 1 "pfc_w_sortdragdrop.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 43
		inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(0);
		#line hidden
		#line 46
		inv_return.is_rs = new Sybase.PowerBuilder.PBString("");
		#line hidden
		#line 49
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
		#line hidden
	}

	#line 1 "pfc_w_sortdragdrop.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		#line 1
		base.pfc_default();
		#line hidden
		#line 43
		inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(1);
		#line hidden
		#line 46
		inv_return.is_rs = this.of_buildsortstring();
		#line hidden
		#line 49
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
		#line hidden
	}

	#line 1 "pfc_w_sortdragdrop.close"
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
		#line 44
		if ((Sybase.PowerBuilder.PBBoolean)(inv_return.ii_rc == new Sybase.PowerBuilder.PBInt(-99)))
		#line hidden
		{
			#line 45
			this.pfc_cancel();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_sortdragdrop.dw_sorted"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_sortdragdrop", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_sorted")]
	public class c__dw_sorted : c__u_dw
	{
		#line hidden

		#line 1 "pfc_w_sortdragdrop.dw_sorted.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnlbuttonclk)]
		public override Sybase.PowerBuilder.PBLong clicked(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked(xpos, ypos, row, dwo);
			#line hidden
			#line 37
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDWObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dwo)))))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(row)))))| (row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
			#line hidden
			{
				#line 38
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
			#line 41
			if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBExtObject)(dwo))[new Sybase.PowerBuilder.PBString(@"name"), Sybase.PowerBuilder.PBBoolean.True]) == (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBString("display_column"))))
			#line hidden
			{
				#line 42
				((c__pfc_w_sortdragdrop)(Parent)).il_sortingrow = row;
				#line hidden
				#line 45
				this.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.Begin)));
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_sortdragdrop.dw_sorted.dragdrop"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("dragdrop")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwndragdrop)]
		public override Sybase.PowerBuilder.PBLong dragdrop(Sybase.PowerBuilder.WPF.PBDragObject source, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.WPF.PBDragObject ldrg_object = null;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 42
			ldrg_object = Sybase.PowerBuilder.WPF.PBSystemFunctions.DraggedObject();
			#line hidden
			#line 45
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBDragObject.TypeOf(ldrg_object) == (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.DataWindow))))
			#line hidden
			{
				#line 46
				if ((Sybase.PowerBuilder.PBBoolean)(ldrg_object.ClassName() == new Sybase.PowerBuilder.PBString("dw_sorted")))
				#line hidden
				{
					#line 47
					li_rc = this.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.Cancel)));
					#line hidden
					#line 48
					return new Sybase.PowerBuilder.PBLong(0);
					#line hidden
				}
			}
			#line 53
			if ((Sybase.PowerBuilder.PBBoolean)(((c__pfc_w_sortdragdrop)(Parent)).il_availablerow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 54
				li_rc = ((c__pfc_w_sortdragdrop)(Parent)).dw_sortcolumns.RowsMove(((c__pfc_w_sortdragdrop)(Parent)).il_availablerow, ((c__pfc_w_sortdragdrop)(Parent)).il_availablerow, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_w_sortdragdrop.c__dw_sorted)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this)))), this.RowCount()+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
				#line hidden
			}
			#line 58
			((c__pfc_w_sortdragdrop)(Parent)).dw_sortcolumns.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.End)));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_sortdragdrop.dw_sorted.constructor"
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
			#line 42
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 43
			ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_sortdragdrop");
			#line hidden
			this.ClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.clicked);
			this.DragDropEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dragdw(this.dragdrop);
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_sorted()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sortdragdrop.st_3"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_3")]
	public class c__st_3 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_3()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sortdragdrop.st_4"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_4")]
	public class c__st_4 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_4()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sortdragdrop.st_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_2")]
	public class c__st_2 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_2()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sortdragdrop.dw_sortcolumns"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_sortdragdrop", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_sortcolumns")]
	public class c__dw_sortcolumns : c__u_dw
	{
		#line hidden

		#line 1 "pfc_w_sortdragdrop.dw_sortcolumns.dragdrop"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("dragdrop")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwndragdrop)]
		public override Sybase.PowerBuilder.PBLong dragdrop(Sybase.PowerBuilder.WPF.PBDragObject source, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.WPF.PBDragObject ldrg_object = null;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 42
			ldrg_object = Sybase.PowerBuilder.WPF.PBSystemFunctions.DraggedObject();
			#line hidden
			#line 45
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBDragObject.TypeOf(ldrg_object) == (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.DataWindow))))
			#line hidden
			{
				#line 46
				if ((Sybase.PowerBuilder.PBBoolean)(ldrg_object.ClassName() == new Sybase.PowerBuilder.PBString("dw_sortcolumns")))
				#line hidden
				{
					#line 47
					li_rc = this.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.Cancel)));
					#line hidden
					#line 48
					return new Sybase.PowerBuilder.PBLong(0);
					#line hidden
				}
			}
			#line 53
			if ((Sybase.PowerBuilder.PBBoolean)(((c__pfc_w_sortdragdrop)(Parent)).il_sortingrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 54
				li_rc = ((c__pfc_w_sortdragdrop)(Parent)).dw_sorted.RowsMove(((c__pfc_w_sortdragdrop)(Parent)).il_sortingrow, ((c__pfc_w_sortdragdrop)(Parent)).il_sortingrow, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_w_sortdragdrop.c__dw_sortcolumns)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(this)))), this.RowCount()+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
				#line hidden
			}
			#line 58
			li_rc = this.SetSort(new Sybase.PowerBuilder.PBString("display_column A"));
			#line hidden
			#line 59
			li_rc = this.Sort();
			#line hidden
			#line 61
			((c__pfc_w_sortdragdrop)(Parent)).dw_sorted.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.End)));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_sortdragdrop.dw_sortcolumns.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnlbuttonclk)]
		public override Sybase.PowerBuilder.PBLong clicked(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked(xpos, ypos, row, dwo);
			#line hidden
			#line 37
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDWObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dwo)))))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(row)))))| (row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
			#line hidden
			{
				#line 38
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
			#line 41
			if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBExtObject)(dwo))[new Sybase.PowerBuilder.PBString(@"name"), Sybase.PowerBuilder.PBBoolean.True]) == (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBString("display_column"))))
			#line hidden
			{
				#line 42
				((c__pfc_w_sortdragdrop)(Parent)).il_availablerow = row;
				#line hidden
				#line 45
				this.Drag((new Sybase.PowerBuilder.PBDragModesValue(Sybase.PowerBuilder.PBDragModes.Begin)));
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_sortdragdrop.dw_sortcolumns.constructor"
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
			#line 43
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 44
			ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 47
			((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(this.Object))[new Sybase.PowerBuilder.PBString(@"sort_order"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"visible")] = (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_sortdragdrop");
			#line hidden
			this.DragDropEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dragdw(this.dragdrop);
			this.ClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.clicked);
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_sortcolumns()
		{
			_init();
		}

	}


	#line 1 "pfc_w_sortdragdrop.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sortdragdrop.cb_ok.clicked"
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
			#line 38
			((c__pfc_w_sortdragdrop)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_sortdragdrop.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sortdragdrop.cb_cancel.clicked"
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
			#line 38
			((c__pfc_w_sortdragdrop)(this.Parent)).pfc_cancel();
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


	#line 1 "pfc_w_sortdragdrop.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_sortdragdrop.cb_dlghelp.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(900)));
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
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.CloseEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.close);
	}

	public c__pfc_w_sortdragdrop()
	{
		_init();
	}

}
 