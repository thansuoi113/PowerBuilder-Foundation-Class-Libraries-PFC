//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_w_restorerow.srw"
#line hidden
#line 1 "pfc_w_restorerow"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_restorerow",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\examples\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_restorerow")]
public class c__pfc_w_restorerow : c__w_response
{
	#line hidden
	public c__pfc_w_restorerow.c__dw_delete dw_delete = null;
	public c__pfc_w_restorerow.c__cb_ok cb_ok = null;
	public c__pfc_w_restorerow.c__cb_cancel cb_cancel = null;
	public c__pfc_w_restorerow.c__cb_selectall cb_selectall = null;
	public c__pfc_w_restorerow.c__cb_invertselection cb_invertselection = null;
	public c__pfc_w_restorerow.c__cb_dlghelp cb_dlghelp = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwmaxwidth", null, "pfc_w_restorerow", 1451, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 1451")]
	protected Sybase.PowerBuilder.PBInt ii_dwmaxwidth = new Sybase.PowerBuilder.PBInt(1451);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwmaxheight", null, "pfc_w_restorerow", 1168, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 1168")]
	protected Sybase.PowerBuilder.PBInt ii_dwmaxheight = new Sybase.PowerBuilder.PBInt(1168);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwminwidth", null, "pfc_w_restorerow", 729, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 729")]
	protected Sybase.PowerBuilder.PBInt ii_dwminwidth = new Sybase.PowerBuilder.PBInt(729);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwminheight", null, "pfc_w_restorerow", 564, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 564")]
	protected Sybase.PowerBuilder.PBInt ii_dwminheight = new Sybase.PowerBuilder.PBInt(564);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_restorerowattrib", null, "pfc_w_restorerow", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_restorerowattrib inv_restorerowattrib = (c__n_cst_restorerowattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_restorerowattrib));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_return", null, "pfc_w_restorerow", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_returnattrib inv_return = (c__n_cst_returnattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_returnattrib));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idw_parm", null, "pfc_w_restorerow", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.WPF.PBDataWindow idw_parm = null;

	#line 1 "pfc_w_restorerow.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_rowcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_width = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_height = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_loop = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_rownumbertype = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBArray ll_rownumbers = new Sybase.PowerBuilder.PBUnboundedLongArray();
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 45
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 47
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 50
		inv_restorerowattrib = (c__n_cst_restorerowattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcexamp.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 51
		idw_parm = inv_restorerowattrib.idw_active;
		#line hidden
		#line 52
		dw_delete.DataObject = inv_restorerowattrib.idw_active.DataObject;
		#line hidden
		#line 53
		dw_delete.Reset();
		#line hidden
		#line 56
		dw_delete.inv_rowselect.of_modify(new Sybase.PowerBuilder.PBString("protect"), new Sybase.PowerBuilder.PBString("1"), new Sybase.PowerBuilder.PBString("column"), new Sybase.PowerBuilder.PBString("*"), new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 59
		idw_parm.RowsCopy((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), idw_parm.DeletedCount(), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Delete)), (Sybase.PowerBuilder.WPF.PBDataWindow)(dw_delete), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
		#line hidden
		#line 60
		dw_delete.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 63
		ll_rowcount = dw_delete.RowCount();
		#line hidden
		#line 66
		inv_restorerowattrib.is_filter = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(inv_restorerowattrib.is_filter);
		#line hidden
		#line 67
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_restorerowattrib.is_filter)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 69
			if ((Sybase.PowerBuilder.PBBoolean)(dw_delete.SetFilter(inv_restorerowattrib.is_filter) != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 71
				inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
				#line 72
				Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
				#line hidden
				#line 73
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
			#line 75
			if ((Sybase.PowerBuilder.PBBoolean)(dw_delete.Filter() != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 77
				inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
				#line 78
				Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
				#line hidden
				#line 79
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
		}
		#line 84
		inv_restorerowattrib.is_sort = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(inv_restorerowattrib.is_sort);
		#line hidden
		#line 85
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_restorerowattrib.is_sort)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 87
			if ((Sybase.PowerBuilder.PBBoolean)(dw_delete.SetSort(inv_restorerowattrib.is_sort) != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 89
				inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
				#line 90
				Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
				#line hidden
				#line 91
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
			#line 93
			if ((Sybase.PowerBuilder.PBBoolean)(dw_delete.Sort() != new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 95
				inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
				#line 96
				Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
				#line hidden
				#line 97
				return new Sybase.PowerBuilder.PBLong(0);
				#line hidden
			}
		}
		#line 102
		dw_delete.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 105
		this.of_setresize(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 106
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(dw_delete), c__n_cst_resize.scalerightbottom);
		#line hidden
		#line 107
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_ok), c__n_cst_resize.fixedright);
		#line hidden
		#line 108
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_cancel), c__n_cst_resize.fixedright);
		#line hidden
		#line 109
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_invertselection), c__n_cst_resize.fixedright);
		#line hidden
		#line 110
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_selectall), c__n_cst_resize.fixedright);
		#line hidden
		#line 111
		inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_dlghelp), c__n_cst_resize.fixedright);
		#line hidden
		#line 114
		ll_width = dw_delete.inv_rowselect.of_getwidth();
		#line hidden
		#line 115
		ll_width = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Min((Sybase.PowerBuilder.PBDouble)(ii_dwmaxwidth), (Sybase.PowerBuilder.PBDouble)(ll_width)));
		#line hidden
		#line 116
		if ((Sybase.PowerBuilder.PBBoolean)(ll_width == (Sybase.PowerBuilder.PBLong)(ii_dwmaxwidth)))
		#line hidden
		{
			#line 117
			dw_delete.HScrollBar = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 119
		ll_width = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Max((Sybase.PowerBuilder.PBDouble)(ii_dwminwidth), (Sybase.PowerBuilder.PBDouble)(ll_width)));
		#line hidden
		#line 121
		ll_height = dw_delete.inv_rowselect.of_getheight();
		#line hidden
		#line 122
		ll_height = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Min((Sybase.PowerBuilder.PBDouble)(ii_dwmaxheight), (Sybase.PowerBuilder.PBDouble)(ll_height)));
		#line hidden
		#line 123
		ll_height = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Max((Sybase.PowerBuilder.PBDouble)(ii_dwminheight), (Sybase.PowerBuilder.PBDouble)(ll_height)));
		#line hidden
		#line 125
		this.Resize((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Width)+ (ll_width- (Sybase.PowerBuilder.PBLong)(dw_delete.Width))), (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Height)+ (ll_height- (Sybase.PowerBuilder.PBLong)(dw_delete.Height))));
		#line hidden
		#line 128
		if ((Sybase.PowerBuilder.PBBoolean)(ll_rowcount> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 129
			cb_selectall.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 130
			cb_invertselection.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		else
		{
			#line 132
			cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 133
			cb_invertselection.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 134
			cb_selectall.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
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
		this.dw_delete = (c__dw_delete)this.CreateInstance(this, "c__dw_delete");
		#line hidden
		#line hidden
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.cb_selectall = (c__cb_selectall)this.CreateInstance(this, "c__cb_selectall");
		#line hidden
		#line hidden
		this.cb_invertselection = (c__cb_invertselection)this.CreateInstance(this, "c__cb_invertselection");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_delete);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_selectall);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_invertselection);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_delete);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_selectall);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_invertselection);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
	}

	#line 1 "pfc_w_restorerow.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_rowidmax = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_rowid = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_selectedrow = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_focusrow = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_restored = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_originalrow = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_currrow = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_rowcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_idx = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_done = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 1
		base.pfc_default();
		#line hidden
		#line 52
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_parm)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_parm)))))
		#line hidden
		{
			#line 56
			inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
			#line 57
			Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
			#line hidden
		}
		#line 61
		ll_originalrow = idw_parm.GetRow();
		#line hidden
		do
		{
				#line 66
				ll_selectedrow = dw_delete.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
				#line hidden
				#line 67
				if ((Sybase.PowerBuilder.PBBoolean)(ll_selectedrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 69
					ll_rowidmax = dw_delete.GetRowIdFromRow(ll_selectedrow);
					#line hidden
					#line 70
					ll_row = ll_selectedrow;
					#line hidden
					do
					{
							#line 75
							ll_selectedrow = dw_delete.GetSelectedRow(ll_selectedrow);
							#line hidden
							#line 76
							if ((Sybase.PowerBuilder.PBBoolean)(ll_selectedrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
							#line hidden
							{
								#line 78
								ll_rowid = dw_delete.GetRowIdFromRow(ll_selectedrow);
								#line hidden
								#line 79
								if ((Sybase.PowerBuilder.PBBoolean)(ll_rowid> ll_rowidmax))
								#line hidden
								{
									#line 81
									ll_rowidmax = ll_rowid;
									#line hidden
									#line 82
									ll_row = ll_selectedrow;
									#line hidden
								}
							}
					}
					#line 85
					while ( !(ll_selectedrow<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
					#line hidden
					#line 88
					li_rc = idw_parm.RowsMove(ll_rowidmax, ll_rowidmax, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Delete)), (Sybase.PowerBuilder.IPBDataWindowControl)(((Sybase.PowerBuilder.WPF.PBDataWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_parm)))), idw_parm.RowCount()+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
					#line hidden
					#line 90
					dw_delete.DeleteRow(ll_row);
					#line hidden
					#line 93
					if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(1)))
					#line hidden
					{
						#line 94
						idw_parm.SelectRow(idw_parm.RowCount(), new Sybase.PowerBuilder.PBBoolean(false));
						#line hidden
						#line 95
						ll_restored++;
						#line hidden
						#line 97
						ll_selectedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
						#line hidden
					}
					else
					{
						#line 99
						break;
						#line hidden
					}
				}
		}
		#line 103
		while ( !(ll_selectedrow<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
		#line hidden
		#line 105
		if ((Sybase.PowerBuilder.PBBoolean)(ll_restored> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 107
			ll_currrow = idw_parm.GetRow();
			#line hidden
			#line 110
			ll_focusrow = (idw_parm.RowCount()- ll_restored)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
			#line 111
			li_rc = idw_parm.ScrollToRow(ll_focusrow);
			#line hidden
			#line 112
			li_rc = idw_parm.SetRow(ll_focusrow);
			#line hidden
			#line 113
			li_rc = idw_parm.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 116
			if ((Sybase.PowerBuilder.PBBoolean)((ll_restored> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_currrow == ll_focusrow)))
			#line hidden
			{
				#line 117
				idw_parm.rowfocuschanged(ll_focusrow);
				#line hidden
			}
		}
		#line 122
		inv_return.ii_rc = (Sybase.PowerBuilder.PBInt)(ll_restored);
		#line hidden
		#line 123
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
		#line hidden
	}

	#line 1 "pfc_w_restorerow.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 44
		inv_return.ii_rc = new Sybase.PowerBuilder.PBInt(0);
		#line hidden
		#line 45
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_returnattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_return)))));
		#line hidden
	}

	#line 1 "pfc_w_restorerow.close"
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
		#line 41
		if ((Sybase.PowerBuilder.PBBoolean)(inv_return.ii_rc == new Sybase.PowerBuilder.PBInt(-99)))
		#line hidden
		{
			#line 42
			this.pfc_cancel();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_restorerow.dw_delete"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_delete")]
	public class c__dw_delete : c__u_dw
	{
		#line hidden

		#line 1 "pfc_w_restorerow.dw_delete.constructor"
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
			#line 2
			this.of_setrowselect(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 3
			inv_rowselect.of_setstyle(new Sybase.PowerBuilder.PBInt(2));
			#line hidden
			#line 6
			this.of_setupdateable(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 9
			ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_restorerow.dw_delete.clicked"
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
			#line 2
			if ((Sybase.PowerBuilder.PBBoolean)(this.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 3
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			else
			{
				#line 5
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
			this.ClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.clicked);

			OnInitialUpdate();
		}

		public c__dw_delete()
		{
			_init();
		}

	}


	#line 1 "pfc_w_restorerow.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_restorerow.cb_ok.clicked"
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
			#line 1
			((c__pfc_w_restorerow)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_restorerow.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_restorerow.cb_cancel.clicked"
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
			#line 1
			((c__pfc_w_restorerow)(this.Parent)).pfc_cancel();
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


	#line 1 "pfc_w_restorerow.cb_selectall"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_selectall")]
	public class c__cb_selectall : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_restorerow.cb_selectall.clicked"
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
			((c__pfc_w_restorerow)(Parent)).dw_delete.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 42
			if ((Sybase.PowerBuilder.PBBoolean)(((c__pfc_w_restorerow)(Parent)).dw_delete.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 43
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			else
			{
				#line 45
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_selectall()
		{
			_init();
		}

	}


	#line 1 "pfc_w_restorerow.cb_invertselection"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_invertselection")]
	public class c__cb_invertselection : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_restorerow.cb_invertselection.clicked"
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
			((c__pfc_w_restorerow)(Parent)).dw_delete.inv_rowselect.of_invertselection();
			#line hidden
			#line 42
			if ((Sybase.PowerBuilder.PBBoolean)(((c__pfc_w_restorerow)(Parent)).dw_delete.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 43
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			else
			{
				#line 45
				((c__pfc_w_restorerow)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_invertselection()
		{
			_init();
		}

	}


	#line 1 "pfc_w_restorerow.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_restorerow.cb_dlghelp.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(700)));
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

	public c__pfc_w_restorerow()
	{
		_init();
	}

}
 