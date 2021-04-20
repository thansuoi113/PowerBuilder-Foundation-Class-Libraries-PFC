//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_n_cst_dwsrv_rowmanager.sru"
#line hidden
#line 1 "pfc_n_cst_dwsrv_rowmanager"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwsrv_rowmanager",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwsrv_rowmanager")]
public class c__pfc_n_cst_dwsrv_rowmanager : c__n_cst_dwsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_confirmondelete", null, "pfc_n_cst_dwsrv_rowmanager", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_confirmondelete = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_restorerow", null, "pfc_n_cst_dwsrv_rowmanager", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= True")]
	protected Sybase.PowerBuilder.PBBoolean ib_restorerow = new Sybase.PowerBuilder.PBBoolean(true);

	#line 1 "pfc_n_cst_dwsrv_rowmanager.pfc_insertrow"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_insertrow")]
	public virtual Sybase.PowerBuilder.PBLong pfc_insertrow(Sybase.PowerBuilder.PBLong al_beforerow)
	{
		#line hidden
		#line 47
		return this.of_insertrow(al_beforerow);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.pfc_addrow"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_addrow")]
	public virtual Sybase.PowerBuilder.PBLong pfc_addrow()
	{
		#line hidden
		#line 45
		return this.of_insertrow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.pfc_deleterow"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_deleterow")]
	public virtual Sybase.PowerBuilder.PBLong pfc_deleterow()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_rc = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_selectedrow = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 50
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 53
		ll_selectedrow = idw_requestor.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(ll_selectedrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 55
			ll_rc = this.of_deleteselected();
			#line hidden
		}
		else
		{
			#line 57
			ll_rc = (Sybase.PowerBuilder.PBLong)(this.of_deleterow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
			#line hidden
		}
		#line 60
		return ll_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.pfc_restorerow"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_restorerow")]
	public virtual Sybase.PowerBuilder.PBLong pfc_restorerow()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_rc = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 48
		ll_rc = this.of_undelete();
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(ll_rc == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-2))))
		#line hidden
		{
			#line 50
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_rowmanager_norestore"), c__pfcsecurity_admin.GetCurrentApplication().gnv_app.iapp_object.DisplayName, (new Sybase.PowerBuilder.PBString("There are no ")+ is_displayunits)+ new Sybase.PowerBuilder.PBString(" to restore."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Information)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 54
		return ll_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_undelete(L)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_undelete", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_undelete()
	{
		#line hidden
		c__n_cst_returnattrib lnv_return = (c__n_cst_returnattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_returnattrib));
		c__n_cst_restorerowattrib lnv_restorerowattrib = (c__n_cst_restorerowattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_restorerowattrib));
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 55
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.DeletedCount()<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 60
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-2));
			#line hidden
		}
		#line 64
		lnv_restorerowattrib.idw_active = (Sybase.PowerBuilder.WPF.PBDataWindow)(idw_requestor);
		#line hidden
		#line 65
		idw_requestor.pfc_prerestorerow(ref lnv_restorerowattrib);
		#line hidden
		#line 68
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__pfcsecurity_admin.GetCurrentApplication().w_restorerow, (Sybase.PowerBuilder.PBPowerObject)(lnv_restorerowattrib));
		#line hidden
		#line 71
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))
		#line hidden
		{
			#line 72
			if ((Sybase.PowerBuilder.PBBoolean)(lnv_return.ClassName() == c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm.ClassName()))
			#line hidden
			{
				#line 73
				lnv_return = (c__n_cst_returnattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))));
				#line hidden
			}
			else
			{
				#line 75
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
				#line hidden
			}
		}
		else
		{
			#line 78
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 82
		idw_requestor.SetFocus();
		#line hidden
		#line 84
		return (Sybase.PowerBuilder.PBLong)(lnv_return.ii_rc);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_getconfirmondelete(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getconfirmondelete", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getconfirmondelete()
	{
		#line hidden
		#line 45
		return ib_confirmondelete;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_setconfirmondelete(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setconfirmondelete", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setconfirmondelete(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		ib_confirmondelete = ab_switch;
		#line hidden
		#line 51
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_insertrow(LL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_insertrow", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_insertrow(Sybase.PowerBuilder.PBLong al_beforerow)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_rc = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 53
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 56
		ll_rc = idw_requestor.InsertRow(al_beforerow);
		#line hidden
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(ll_rc> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 59
			idw_requestor.SetRow(ll_rc);
			#line hidden
			#line 60
			idw_requestor.ScrollToRow(ll_rc);
			#line hidden
			#line 61
			idw_requestor.SetFocus();
			#line hidden
		}
		#line 64
		return ll_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_confirmdelete(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_confirmdelete", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_confirmdelete(Sybase.PowerBuilder.PBLong al_amount)
	{
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(al_amount<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(al_amount == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 55
			return this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_rowmanager_confirmsingledelete"), new Sybase.PowerBuilder.PBString("Confirm Delete"), (new Sybase.PowerBuilder.PBString("Are you sure you want to delete ")+ is_displayitem)+ new Sybase.PowerBuilder.PBString("?"), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Question)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNo)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		else
		{
			#line 58
			return this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_rowmanager_confirmmultipledelete"), new Sybase.PowerBuilder.PBString("Confirm Multiple Delete"), (((new Sybase.PowerBuilder.PBString("Are you sure you want to delete these ")+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_amount)))))+ new Sybase.PowerBuilder.PBString(" "))+ is_displayunits)+ new Sybase.PowerBuilder.PBString("?"), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Question)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNo)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_deleterow(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_deleterow", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_deleterow(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_confirm = new Sybase.PowerBuilder.PBInt(1);
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		if (ib_confirmondelete)
		#line hidden
		{
			#line 60
			li_confirm = this.of_confirmdelete((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
			#line hidden
		}
		#line 64
		if ((Sybase.PowerBuilder.PBBoolean)(li_confirm == new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 65
			if ((Sybase.PowerBuilder.PBBoolean)(al_row == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 66
				al_row = idw_requestor.GetRow();
				#line hidden
				#line 67
				if ((Sybase.PowerBuilder.PBBoolean)(al_row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 67
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
			}
			#line 69
			li_rc = idw_requestor.DeleteRow(al_row);
			#line hidden
			#line 70
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 71
				al_row--;
				#line hidden
				#line 72
				if ((Sybase.PowerBuilder.PBBoolean)(al_row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 73
					al_row = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
					#line hidden
				}
				#line 75
				if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.RowCount()> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 76
					idw_requestor.SetRow(al_row);
					#line hidden
					#line 77
					idw_requestor.ScrollToRow(al_row);
					#line hidden
					#line 78
					idw_requestor.SetFocus();
					#line hidden
				}
			}
		}
		#line 83
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_deleteselected(L)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_deleteselected", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_deleteselected()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_confirm = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt li_delete = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_selectedcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_row = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_deletedcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 57
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 61
		ll_row = idw_requestor.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 62
		while ( ll_row> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
		#line hidden
		{
				#line 63
				ll_selectedcount++;
				#line hidden
				#line 64
				ll_row = idw_requestor.GetSelectedRow(ll_row);
				#line hidden
		}

		#line 68
		if (ib_confirmondelete)
		#line hidden
		{
			#line 69
			li_confirm = this.of_confirmdelete(ll_selectedcount);
			#line hidden
		}
		#line 73
		if ((Sybase.PowerBuilder.PBBoolean)(li_confirm == new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 75
			if ((Sybase.PowerBuilder.PBBoolean)(ll_selectedcount> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
			#line hidden
			{
				#line 76
				Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
				#line hidden
				#line 77
				idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
			}
			#line 81
			ll_row = idw_requestor.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
			#line hidden
			#line 82
			while ( ll_row> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
			#line hidden
			{
					#line 83
					li_delete = idw_requestor.DeleteRow(ll_row);
					#line hidden
					#line 84
					if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_delete)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 85
						ll_deletedcount++;
						#line hidden
					}
					else
					{
						#line 87
						break;
						#line hidden
					}
					#line 89
					ll_row = idw_requestor.GetSelectedRow(ll_row- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
					#line hidden
			}

		}
		#line 94
		if ((Sybase.PowerBuilder.PBBoolean)(ll_selectedcount> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 95
			idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		#line 98
		return ll_deletedcount;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_setrestorerow(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrestorerow", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrestorerow(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		ib_restorerow = ab_switch;
		#line hidden
		#line 51
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("Row Manager");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("Enhances row inserts, deletes, and facilitates restoring of deleted rows.");
		#line hidden
		#line 53
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getpropertyinfo", new string[]{"ref n_cst_propertyattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getpropertyinfo_1_66237089<T0>(ref T0 anv_attrib)
	{
		#line hidden
		c__n_cst_infoattrib lnv_infoattrib = (c__n_cst_infoattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_infoattrib));
		#line 51
		this.of_getinfo_1_920697064(ref lnv_infoattrib);
		#line hidden
		#line 52
		anv_attrib.is_name = lnv_infoattrib.is_name;
		#line hidden
		#line 53
		anv_attrib.is_description = lnv_infoattrib.is_description;
		#line hidden
		#line 56
		anv_attrib.is_propertypage.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedStringArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 1},false), new Sybase.PowerBuilder.PBString[1]{
		#line 56
		new Sybase.PowerBuilder.PBString("u_tabpg_dwproperty_srvrowmanager") })));
		#line hidden
		#line 57
		anv_attrib.ib_switchbuttons = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 59
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_isrestorerow(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isrestorerow", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isrestorerow()
	{
		#line hidden
		#line 45
		return ib_restorerow;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowmanager.of_deleteall(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_deleteall", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_deleteall()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_confirm = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBLong ll_rowcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		ll_rowcount = idw_requestor.RowCount();
		#line hidden
		#line 57
		if ((Sybase.PowerBuilder.PBBoolean)(ll_rowcount<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 58
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 62
		if (ib_confirmondelete)
		#line hidden
		{
			#line 63
			li_confirm = this.of_confirmdelete(ll_rowcount);
			#line hidden
		}
		#line 67
		if ((Sybase.PowerBuilder.PBBoolean)(li_confirm == new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 68
			idw_requestor.RowsMove((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), ll_rowcount, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (Sybase.PowerBuilder.IPBDataWindowControl)(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))), idw_requestor.DeletedCount()+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Delete)));
			#line hidden
			#line 69
			return (Sybase.PowerBuilder.PBInt)(ll_rowcount);
			#line hidden
		}
		#line 73
		return new Sybase.PowerBuilder.PBInt(0);
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

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_dwsrv_rowmanager()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwsrv_rowmanager(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwsrv_rowmanager vv = new c__pfc_n_cst_dwsrv_rowmanager();
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
			return (c__pfc_n_cst_dwsrv_rowmanager) v.Value;
		}
	}
}
 