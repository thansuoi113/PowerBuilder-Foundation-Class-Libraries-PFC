//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_rtefind.sru"
#line hidden
#line 1 "pfc_n_cst_rtefind"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_rtefind",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_rtefind")]
public class c__pfc_n_cst_rtefind : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_ongoingfind", null, "pfc_n_cst_rtefind", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_ongoingfind = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idw_requestor", null, "pfc_n_cst_rtefind", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_dw idw_requestor = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "irte_requestor", null, "pfc_n_cst_rtefind", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__u_rte irte_requestor = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_findattrib", null, "pfc_n_cst_rtefind", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_findattrib inv_findattrib = (c__n_cst_findattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_findattrib));

	#line 1 "pfc_n_cst_rtefind.pfc_findnext"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_findnext")]
	public virtual Sybase.PowerBuilder.PBInt pfc_findnext(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_forward = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		#line 47
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor))))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_rte)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(irte_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor))))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		if (ib_ongoingfind)
		#line hidden
		{
			#line 54
			ib_ongoingfind = this.of_isongoingfind(((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib))));
			#line hidden
		}
		#line 58
		inv_findattrib = ((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib)));
		#line hidden
		#line 61
		lb_forward = !((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(inv_findattrib.is_direction) == new Sybase.PowerBuilder.PBString("up")));
		#line hidden
		#line 64
		if (ib_ongoingfind)
		#line hidden
		{
			#line 66
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
			#line hidden
			{
				#line 67
				li_rc = irte_requestor.FindNext();
				#line hidden
			}
			else
			{
				#line 69
				li_rc = idw_requestor.FindNext();
				#line hidden
			}
		}
		else
		{
			#line 73
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
			#line hidden
			{
				#line 74
				li_rc = irte_requestor.Find(inv_findattrib.is_find, lb_forward, !(inv_findattrib.ib_matchcase), inv_findattrib.ib_wholeword, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
			else
			{
				#line 78
				li_rc = idw_requestor.Find(inv_findattrib.is_find, lb_forward, !(inv_findattrib.ib_matchcase), inv_findattrib.ib_wholeword, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		#line 85
		ib_ongoingfind = (Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 87
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.pfc_replace"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_replace")]
	public virtual Sybase.PowerBuilder.PBInt pfc_replace(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_forward = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBString ls_selectedtext = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor))))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_rte)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(irte_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor))))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		if (ib_ongoingfind)
		#line hidden
		{
			#line 57
			ib_ongoingfind = this.of_isongoingfind(((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib))));
			#line hidden
		}
		#line 61
		inv_findattrib = ((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib)));
		#line hidden
		#line 64
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
		#line hidden
		{
			#line 65
			ls_selectedtext = irte_requestor.SelectedText();
			#line hidden
		}
		else
		{
			#line 67
			ls_selectedtext = idw_requestor.SelectedText();
			#line hidden
		}
		#line 71
		if ((Sybase.PowerBuilder.PBBoolean)(ls_selectedtext == inv_findattrib.is_find))
		#line hidden
		{
			#line 72
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
			#line hidden
			{
				#line 73
				li_rc = irte_requestor.ReplaceText(inv_findattrib.is_replacewith);
				#line hidden
			}
			else
			{
				#line 75
				li_rc = idw_requestor.ReplaceText(inv_findattrib.is_replacewith);
				#line hidden
			}
		}
		#line 80
		lb_forward = !((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(inv_findattrib.is_direction) == new Sybase.PowerBuilder.PBString("up")));
		#line hidden
		#line 83
		if (ib_ongoingfind)
		#line hidden
		{
			#line 85
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
			#line hidden
			{
				#line 86
				li_rc = irte_requestor.FindNext();
				#line hidden
			}
			else
			{
				#line 88
				li_rc = idw_requestor.FindNext();
				#line hidden
			}
		}
		else
		{
			#line 93
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
			#line hidden
			{
				#line 94
				li_rc = irte_requestor.Find(inv_findattrib.is_find, lb_forward, !(inv_findattrib.ib_matchcase), inv_findattrib.ib_wholeword, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
			else
			{
				#line 98
				li_rc = idw_requestor.Find(inv_findattrib.is_find, lb_forward, !(inv_findattrib.ib_matchcase), inv_findattrib.ib_wholeword, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		#line 105
		ib_ongoingfind = (Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 107
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.pfc_replaceall"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_replaceall")]
	public virtual Sybase.PowerBuilder.PBInt pfc_replaceall(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_counter = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor))))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_rte)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(irte_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor))))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
		#line hidden
		{
			#line 56
			li_rc = irte_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
		}
		else
		{
			#line 58
			li_rc = idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
		}
		do
		{
				#line 62
				li_rc = this.pfc_replace(((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib))));
				#line hidden
				#line 63
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 64
					li_counter++;
					#line hidden
				}
		}
		#line 66
		while ( !((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))));
		#line hidden
		#line 68
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
		#line hidden
		{
			#line 69
			li_rc = irte_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		else
		{
			#line 71
			li_rc = idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		#line 73
		return li_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.pfc_finddlg"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_finddlg")]
	public virtual void pfc_finddlg()
	{
		#line hidden
		#line 46
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcmsg.GetCurrentApplication().w_replace)))
		#line hidden
		{
			#line 46
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(c__pfcmsg.GetCurrentApplication().w_replace));
			#line hidden
		}
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcmsg.GetCurrentApplication().w_find)))
		#line hidden
		{
			#line 47
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(c__pfcmsg.GetCurrentApplication().w_find));
			#line hidden
		}
		#line 50
		inv_findattrib.ipo_requestor = (Sybase.PowerBuilder.PBPowerObject)(this);
		#line hidden
		#line 53
		inv_findattrib.ib_lookenabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 54
		inv_findattrib.ib_lookvisible = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 56
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__pfcmsg.GetCurrentApplication().w_find, (Sybase.PowerBuilder.PBPowerObject)(inv_findattrib));
		#line hidden
		#line 57
		return;
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.pfc_replacedlg"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_replacedlg")]
	public virtual void pfc_replacedlg()
	{
		#line hidden
		#line 45
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcmsg.GetCurrentApplication().w_replace)))
		#line hidden
		{
			#line 45
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(c__pfcmsg.GetCurrentApplication().w_replace));
			#line hidden
		}
		#line 46
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcmsg.GetCurrentApplication().w_find)))
		#line hidden
		{
			#line 46
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(c__pfcmsg.GetCurrentApplication().w_find));
			#line hidden
		}
		#line 49
		inv_findattrib.ipo_requestor = (Sybase.PowerBuilder.PBPowerObject)(this);
		#line hidden
		#line 52
		inv_findattrib.ib_lookenabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 53
		inv_findattrib.ib_lookvisible = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 56
		Sybase.PowerBuilder.WPF.PBSystemFunctions.OpenWithParm(ref c__pfcmsg.GetCurrentApplication().w_replace, (Sybase.PowerBuilder.PBPowerObject)(inv_findattrib));
		#line hidden
		#line 58
		return;
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.of_setrequestor(ICu_dw.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"u_dw"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrequestor(c__u_dw adw_requestor)
	{
		#line hidden
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(irte_requestor)))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(adw_requestor)))
		#line hidden
		{
			#line 52
			idw_requestor = adw_requestor;
			#line hidden
			#line 53
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 56
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.of_setrequestor(ICu_rte.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setrequestor", new string[]{"u_rte"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setrequestor(c__u_rte arte_requestor)
	{
		#line hidden
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(arte_requestor)))
		#line hidden
		{
			#line 52
			irte_requestor = arte_requestor;
			#line hidden
			#line 53
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 56
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.of_compareattrib(BCn_cst_findattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_compareattrib", new string[]{"n_cst_findattrib"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_compareattrib(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(anv_findattrib.is_find != inv_findattrib.is_find))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(anv_findattrib.is_replacewith != inv_findattrib.is_replacewith))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(anv_findattrib.ib_wholeword != inv_findattrib.ib_wholeword))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(anv_findattrib.ib_matchcase != inv_findattrib.ib_matchcase))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(anv_findattrib.is_direction != inv_findattrib.is_direction))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 56
		return new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.of_isongoingfind(BCn_cst_findattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isongoingfind", new string[]{"n_cst_findattrib"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isongoingfind(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_findattrib)))
		#line hidden
		{
			#line 50
			if (!(this.of_compareattrib(((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib))))))
			#line hidden
			{
				#line 51
				return new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
		}
		#line 55
		return new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
	}

	#line 1 "pfc_n_cst_rtefind.of_initialize(ICn_cst_findattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_initialize", new string[]{"n_cst_findattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_initialize(c__n_cst_findattrib anv_findattrib)
	{
		#line hidden
		#line 46
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_findattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(anv_findattrib)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(anv_findattrib)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		inv_findattrib.is_find = anv_findattrib.is_find;
		#line hidden
		#line 52
		inv_findattrib.is_replacewith = anv_findattrib.is_replacewith;
		#line hidden
		#line 55
		inv_findattrib.ib_wholewordvisible = anv_findattrib.ib_wholewordvisible;
		#line hidden
		#line 56
		inv_findattrib.ib_wholewordenabled = anv_findattrib.ib_wholewordenabled;
		#line hidden
		#line 57
		inv_findattrib.ib_wholeword = anv_findattrib.ib_wholeword;
		#line hidden
		#line 60
		inv_findattrib.ib_matchcasevisible = anv_findattrib.ib_matchcasevisible;
		#line hidden
		#line 61
		inv_findattrib.ib_matchcaseenabled = anv_findattrib.ib_matchcaseenabled;
		#line hidden
		#line 62
		inv_findattrib.ib_matchcase = anv_findattrib.ib_matchcase;
		#line hidden
		#line 65
		inv_findattrib.ib_directionvisible = anv_findattrib.ib_directionvisible;
		#line hidden
		#line 66
		inv_findattrib.ib_directionenabled = anv_findattrib.ib_directionenabled;
		#line hidden
		#line 67
		inv_findattrib.is_direction = anv_findattrib.is_direction;
		#line hidden
		#line 70
		inv_findattrib.ib_lookvisible = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 71
		inv_findattrib.ib_lookenabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 73
		return new Sybase.PowerBuilder.PBInt(1);
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

	public c__pfc_n_cst_rtefind()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_rtefind(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_rtefind vv = new c__pfc_n_cst_rtefind();
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
			return (c__pfc_n_cst_rtefind) v.Value;
		}
	}
}
 