//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcwnsrv.pbl\\pfcwnsrv.pblx\\pfc_n_cst_winsrv_sheetmanager.sru"
#line hidden
#line 1 "pfc_n_cst_winsrv_sheetmanager"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_winsrv_sheetmanager",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcwnsrv.pbl\\pfcwnsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_winsrv_sheetmanager")]
public class c__pfc_n_cst_winsrv_sheetmanager : c__n_cst_winsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ie_arrange", null, "pfc_n_cst_winsrv_sheetmanager", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArrangeTypesValue ie_arrange = new Sybase.PowerBuilder.PBArrangeTypesValue();
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_winsrv_sheetmanagerattrib))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_sheet", null, "pfc_n_cst_winsrv_sheetmanager", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray inv_sheet = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_winsrv_sheetmanagerattrib));
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_winsrv_sheetmanagerattrib))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "istr_sheet", null, "pfc_n_cst_winsrv_sheetmanager", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBArray istr_sheet = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_winsrv_sheetmanagerattrib));

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_cascade"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cascade")]
	public virtual Sybase.PowerBuilder.PBInt pfc_cascade()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		this.of_setcurrentstate((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Cascade)));
		#line hidden
		#line 54
		li_rc = iw_requestor.ArrangeSheets((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Cascade)));
		#line hidden
		#line 56
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_tilehorizontal"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_tilehorizontal")]
	public virtual Sybase.PowerBuilder.PBInt pfc_tilehorizontal()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		this.of_setcurrentstate((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.TileHorizontal)));
		#line hidden
		#line 54
		li_rc = iw_requestor.ArrangeSheets((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.TileHorizontal)));
		#line hidden
		#line 56
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_tilevertical"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_tilevertical")]
	public virtual Sybase.PowerBuilder.PBInt pfc_tilevertical()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		this.of_setcurrentstate((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Tile)));
		#line hidden
		#line 54
		li_rc = iw_requestor.ArrangeSheets((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Tile)));
		#line hidden
		#line 56
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_layer"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_layer")]
	public virtual Sybase.PowerBuilder.PBInt pfc_layer()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		this.of_setcurrentstate((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Layer)));
		#line hidden
		#line 53
		li_rc = iw_requestor.ArrangeSheets((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Layer)));
		#line hidden
		#line 55
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_minimizeall"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_minimizeall")]
	public virtual Sybase.PowerBuilder.PBInt pfc_minimizeall()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_sheetcount = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBArray lw_sheet = new Sybase.PowerBuilder.PBUnboundedArray(typeof(Sybase.PowerBuilder.WPF.PBWindow));
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		li_sheetcount = of_getsheets_1_232646770_1_pfc1939012307(this, ref lw_sheet);
		#line hidden
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_sheetcount)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 58
			this.of_setcurrentstate((new Sybase.PowerBuilder.PBArrangeTypesValue(Sybase.PowerBuilder.PBArrangeTypes.Icons)));
			#line hidden
			#line 60
			for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_sheetcount;li_cnt = li_cnt + 1)
			#line hidden
			{
					#line 61
					((Sybase.PowerBuilder.WPF.PBWindow)lw_sheet[lw_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).WindowState = (new Sybase.PowerBuilder.PBWindowStateValue(Sybase.PowerBuilder.PBWindowState.Minimized));
					#line hidden
			}
		}
		#line 65
		return li_sheetcount;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.pfc_undoarrange"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_undoarrange")]
	public virtual Sybase.PowerBuilder.PBInt pfc_undoarrange()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 46
		li_count = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_sheet)));
		#line hidden
		#line 47
		for (li_cnt = li_count;li_cnt >= new Sybase.PowerBuilder.PBInt(1);li_cnt = li_cnt + new Sybase.PowerBuilder.PBInt(-1))
		#line hidden
		{
				#line 48
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).w_obj)))
				#line hidden
				{
					#line 49
					((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj.WindowState = ((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).e_state;
					#line hidden
					#line 50
					((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj.Width = ((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).i_width;
					#line hidden
					#line 51
					((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj.Height = ((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).i_height;
					#line hidden
					#line 52
					((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj.X = ((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).i_x;
					#line hidden
					#line 53
					((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj.Y = ((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[(Sybase.PowerBuilder.PBLong)(li_cnt)]).i_y;
					#line hidden
				}
		}
		#line 57
		ie_arrange = null;
		#line hidden
		#line 59
		return li_count;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getsheetcount(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsheetcount", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsheetcount()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_counter = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		lw_sheet = iw_requestor.GetFirstSheet();
		#line hidden
		#line 55
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
		#line hidden
		{
			do
			{
					#line 57
					li_counter++;
					#line hidden
					#line 58
					lw_sheet = iw_requestor.GetNextSheet(lw_sheet);
					#line hidden
			}
			#line 59
			while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
			#line hidden
		}
		#line 62
		return li_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getsheets(IRCwindow.[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsheets", new string[]{"ref window"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsheets_1_232646770([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.WPF.PBWindow))] ref Sybase.PowerBuilder.PBArray aw_sheet)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_counter = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		lw_sheet = iw_requestor.GetFirstSheet();
		#line hidden
		#line 55
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
		#line hidden
		{
			do
			{
					#line 57
					li_counter++;
					#line hidden
					#line 58
					aw_sheet[aw_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_counter))] = lw_sheet;
					#line hidden
					#line 59
					lw_sheet = iw_requestor.GetNextSheet(lw_sheet);
					#line hidden
			}
			#line 60
			while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
			#line hidden
		}
		#line 63
		return li_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getsheetsbyclass(IRCwindow.[]S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsheetsbyclass", new string[]{"ref window", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsheetsbyclass_2_232646770([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.WPF.PBWindow))] ref Sybase.PowerBuilder.PBArray aw_sheet, Sybase.PowerBuilder.PBString as_classname)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_counter = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		lw_sheet = iw_requestor.GetFirstSheet();
		#line hidden
		#line 57
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
		#line hidden
		{
			do
			{
					#line 59
					if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.ClassName((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet))))))) == as_classname))
					#line hidden
					{
						#line 60
						li_counter++;
						#line hidden
						#line 61
						aw_sheet[aw_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_counter))] = lw_sheet;
						#line hidden
					}
					#line 63
					lw_sheet = iw_requestor.GetNextSheet(lw_sheet);
					#line hidden
			}
			#line 64
			while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
			#line hidden
		}
		#line 67
		return li_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getsheetsbytitle(IRCwindow.[]SB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsheetsbytitle", new string[]{"ref window", "string", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsheetsbytitle_3_232646770([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.WPF.PBWindow))] ref Sybase.PowerBuilder.PBArray aw_sheet, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBBoolean ab_partialmatch)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_counter = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(iw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_requestor)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 57
		lw_sheet = iw_requestor.GetFirstSheet();
		#line hidden
		#line 58
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
		#line hidden
		{
			do
			{
					#line 60
					if ((Sybase.PowerBuilder.PBBoolean)(ab_partialmatch == new Sybase.PowerBuilder.PBBoolean(false)))
					#line hidden
					{
						#line 61
						if ((Sybase.PowerBuilder.PBBoolean)(lw_sheet.Title == as_title))
						#line hidden
						{
							#line 62
							li_counter++;
							#line hidden
							#line 63
							aw_sheet[aw_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_counter))] = lw_sheet;
							#line hidden
						}
					}
					else
					{
						#line 66
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(lw_sheet.Title, as_title)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
						#line hidden
						{
							#line 67
							li_counter++;
							#line hidden
							#line 68
							aw_sheet[aw_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_counter))] = lw_sheet;
							#line hidden
						}
					}
					#line 72
					lw_sheet = iw_requestor.GetNextSheet(lw_sheet);
					#line hidden
			}
			#line 73
			while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
			#line hidden
		}
		#line 76
		return li_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getsheetsbytitle(IRCwindow.[]S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsheetsbytitle", new string[]{"ref window", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsheetsbytitle_2_232646770([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.WPF.PBWindow))] ref Sybase.PowerBuilder.PBArray aw_sheet, Sybase.PowerBuilder.PBString as_title)
	{
		#line hidden
		#line 48
		return of_getsheetsbytitle_3_23264677104636435(this, ref aw_sheet, as_title, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_setrequestor(ICw_master.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"w_master"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_setrequestor(c__w_master aw_requestor)
	{
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__w_master)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(aw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(aw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)((aw_requestor.WindowType != (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Mdi)))& (aw_requestor.WindowType != (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.MdiHelp)))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 57
		iw_requestor = aw_requestor;
		#line hidden
		#line 58
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_getcurrentstate(Carrangetypes.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getcurrentstate", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBArrangeTypesValue of_getcurrentstate()
	{
		#line hidden
		#line 47
		return ie_arrange;
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.of_setcurrentstate(ICarrangetypes.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setcurrentstate", new string[]{"arrangetypes"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setcurrentstate(Sybase.PowerBuilder.PBArrangeTypesValue ae_arrange)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBArray lw_sheets = new Sybase.PowerBuilder.PBUnboundedArray(typeof(Sybase.PowerBuilder.WPF.PBWindow));
		Sybase.PowerBuilder.PBArray lnv_sheet = new Sybase.PowerBuilder.PBUnboundedArray(typeof(c__n_cst_winsrv_sheetmanagerattrib));
		#line 55
		ie_arrange = ae_arrange;
		#line hidden
		#line 58
		li_count = of_getsheets_1_232646770_1_pfc1939012307(this, ref lw_sheets);
		#line hidden
		#line 61
		inv_sheet.AssignFrom((Sybase.PowerBuilder.PBArray)lnv_sheet);
		#line hidden
		#line 62
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_count;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 63
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).w_obj = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]);
				#line hidden
				#line 64
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).e_state = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]).WindowState;
				#line hidden
				#line 65
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).i_width = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]).Width;
				#line hidden
				#line 66
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).i_height = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]).Height;
				#line hidden
				#line 67
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).i_x = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]).X;
				#line hidden
				#line 68
				((c__n_cst_winsrv_sheetmanagerattrib)inv_sheet[inv_sheet.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).i_y = ((Sybase.PowerBuilder.WPF.PBWindow)lw_sheets[(Sybase.PowerBuilder.PBLong)(li_cnt)]).Y;
				#line hidden
		}
		#line 71
		return li_rc;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		this.TriggerEvent(new Sybase.PowerBuilder.PBString("destructor"));
		#line hidden
	}

	#line 1 "pfc_n_cst_winsrv_sheetmanager.constructor"
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
		#line 1
		ie_arrange = null;
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	public Sybase.PowerBuilder.PBInt of_getsheets_1_232646770_1_pfc1939012307(c__pfc_n_cst_winsrv_sheetmanager this__object, ref Sybase.PowerBuilder.PBArray aw_sheet)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getsheets_1_232646770(ref aw_sheet);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getsheetsbytitle_3_23264677104636435(c__pfc_n_cst_winsrv_sheetmanager this__object, ref Sybase.PowerBuilder.PBArray aw_sheet, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBBoolean ab_partialmatch)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getsheetsbytitle_3_232646770(ref aw_sheet, as_title, ab_partialmatch);
		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
	}

	public c__pfc_n_cst_winsrv_sheetmanager()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_winsrv_sheetmanager(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_winsrv_sheetmanager vv = new c__pfc_n_cst_winsrv_sheetmanager();
			if (vv.FromUnboundedAnyArray(a) > 0)
			{
				return vv;
			}
			else
			{
				return null;
			}
		}
		else
		{
			return (c__pfc_n_cst_winsrv_sheetmanager) v.Value;
		}
	}
}
 