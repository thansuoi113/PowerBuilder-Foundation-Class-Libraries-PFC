//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcapp\\pfcdwsrv.pbl\\pfcdwsrv.pblx\\pfc_n_cst_dwsrv_rowselection.sru"
#line hidden
#line 1 "pfc_n_cst_dwsrv_rowselection"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_dwsrv_rowselection",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcapp\\pfcdwsrv.pbl\\pfcdwsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_dwsrv_rowselection")]
public class c__pfc_n_cst_dwsrv_rowselection : c__n_cst_dwsrv
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "single", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 0")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt single = new Sybase.PowerBuilder.PBInt(0);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "multiple", null, "pfc_n_cst_dwsrv_rowselection", 1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 1")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt multiple = new Sybase.PowerBuilder.PBInt(1);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "extended", null, "pfc_n_cst_dwsrv_rowselection", 2, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= 2")]
	[Sybase.PowerBuilder.PBConstantAttribute()]
	static public Sybase.PowerBuilder.PBInt extended = new Sybase.PowerBuilder.PBInt(2);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_style", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBInt ii_style = new Sybase.PowerBuilder.PBInt(0);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_prevclickedrow", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBLong il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_currclickedrow", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBLong il_currclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_prevrow", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBLong il_prevrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_prevrowcount", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBLong il_prevrowcount = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_prevcntrl", null, "pfc_n_cst_dwsrv_rowselection", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_prevshift", null, "pfc_n_cst_dwsrv_rowselection", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_keyboard", null, "pfc_n_cst_dwsrv_rowselection", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= True")]
	protected Sybase.PowerBuilder.PBBoolean ib_keyboard = new Sybase.PowerBuilder.PBBoolean(true);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_anchorrow", null, "pfc_n_cst_dwsrv_rowselection", 0, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 0")]
	protected Sybase.PowerBuilder.PBLong il_anchorrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_lbuttonpressed", null, "pfc_n_cst_dwsrv_rowselection", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_rbuttonpressed", null, "pfc_n_cst_dwsrv_rowselection", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_clicked"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_clicked")]
	public virtual Sybase.PowerBuilder.PBInt pfc_clicked<T3>(Sybase.PowerBuilder.PBInt ai_xpos, Sybase.PowerBuilder.PBInt ai_ypos, Sybase.PowerBuilder.PBLong al_row, ref T3 adwo_obj) where T3 : Sybase.PowerBuilder.WPF.PBDWObject
	{
		#line hidden
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(Sybase.PowerBuilder.WPF.PBDWObject)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDWObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(adwo_obj))))))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 55
		il_currclickedrow = al_row;
		#line hidden
		#line 58
		return this.of_rowselect(al_row);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_lbuttondown"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_lbuttondown")]
	public virtual void pfc_lbuttondown(Sybase.PowerBuilder.PBULong aul_flags, Sybase.PowerBuilder.PBInt ai_xpos, Sybase.PowerBuilder.PBInt ai_ypos)
	{
		#line hidden
		#line 46
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 49
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_lbuttonup"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_lbuttonup")]
	public virtual void pfc_lbuttonup(Sybase.PowerBuilder.PBULong aul_flags, Sybase.PowerBuilder.PBInt ai_xpos, Sybase.PowerBuilder.PBInt ai_ypos)
	{
		#line hidden
		#line 46
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 49
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 52
		this.of_buttonup();
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_rbuttonup"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_rbuttonup")]
	public virtual void pfc_rbuttonup(Sybase.PowerBuilder.PBInt ai_xpos, Sybase.PowerBuilder.PBInt ai_ypos, Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.WPF.PBDWObject adwo_obj)
	{
		#line hidden
		#line 47
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 50
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 53
		this.of_buttonup();
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_rbuttondown"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_rbuttondown")]
	public virtual void pfc_rbuttondown(Sybase.PowerBuilder.PBInt ai_xpos, Sybase.PowerBuilder.PBInt ai_ypos, Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.WPF.PBDWObject dwo_obj)
	{
		#line hidden
		#line 47
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 50
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 53
			return;
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 54
			return;
			#line hidden
		}
		#line 57
		il_currclickedrow = al_row;
		#line hidden
		#line 60
		this.of_rowselect(al_row);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.pfc_rowfocuschanged"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_rowfocuschanged")]
	public virtual Sybase.PowerBuilder.PBInt pfc_rowfocuschanged(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBBoolean lb_rowdeletion = new Sybase.PowerBuilder.PBBoolean(false);
		Sybase.PowerBuilder.PBBoolean lb_rowclicked = new Sybase.PowerBuilder.PBBoolean(false);
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 57
		if (ib_keyboard)
		#line hidden
		{
			#line 60
			lb_rowdeletion = ((al_row == (il_prevrow- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))| (al_row == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))& (idw_requestor.RowCount() == (il_prevrowcount- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
			#line hidden
			#line 64
			lb_rowclicked = il_currclickedrow == al_row;
			#line hidden
			#line 67
			if ((Sybase.PowerBuilder.PBBoolean)(!(lb_rowdeletion)& !(lb_rowclicked)))
			#line hidden
			{
				#line 69
				li_rc = this.of_keybrowselect(al_row);
				#line hidden
			}
		}
		#line 74
		il_currclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 78
		il_prevrow = al_row;
		#line hidden
		#line 79
		il_prevrowcount = idw_requestor.RowCount();
		#line hidden
		#line 81
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_selectedcount(LRL[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_selectedcount", new string[]{"ref long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBLong of_selectedcount_1_1746598010([Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBLong))] ref Sybase.PowerBuilder.PBArray al_selectedrows)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_selected = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		Sybase.PowerBuilder.PBLong ll_counter = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 49
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		do
		{
				#line 53
				ll_selected = idw_requestor.GetSelectedRow(ll_selected);
				#line hidden
				#line 54
				if ((Sybase.PowerBuilder.PBBoolean)(ll_selected> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 55
					ll_counter++;
					#line hidden
					#line 56
					al_selectedrows[al_selectedrows.Extend(ll_counter)] = ll_selected;
					#line hidden
				}
		}
		#line 58
		while (ll_selected> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)));
		#line hidden
		#line 60
		return ll_counter;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_invertselection(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_invertselection", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_invertselection()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_max = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_i = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 47
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 50
		ll_max = idw_requestor.RowCount();
		#line hidden
		#line 53
		idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 56
		for (ll_i = ((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));ll_i <= ll_max;ll_i = ll_i + 1)
		#line hidden
		{
				#line 57
				idw_requestor.SelectRow(ll_i, !(idw_requestor.IsSelected(ll_i)));
				#line hidden
		}
		#line 61
		idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 63
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_rowselectsingle(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_rowselectsingle", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_rowselectsingle(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 56
		idw_requestor.SelectRow(al_row, new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.GetRow() != al_row))
		#line hidden
		{
			#line 60
			idw_requestor.SetRow(al_row);
			#line hidden
		}
		#line 63
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_rowselectmulti(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_rowselectmulti", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_rowselectmulti(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		idw_requestor.SelectRow(al_row, !(idw_requestor.IsSelected(al_row)));
		#line hidden
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.GetRow() != al_row))
		#line hidden
		{
			#line 57
			idw_requestor.SetRow(al_row);
			#line hidden
		}
		#line 60
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_rowselectext(ILBB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_rowselectext", new string[]{"long", "boolean", "boolean"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_rowselectext(Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.PBBoolean ab_cntrlpressed, Sybase.PowerBuilder.PBBoolean ab_shiftpressed)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_i = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_waitforbuttonup = new Sybase.PowerBuilder.PBBoolean(false);
		Sybase.PowerBuilder.PBBoolean lb_takenoaction = new Sybase.PowerBuilder.PBBoolean(false);
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 53
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 74
		if ((Sybase.PowerBuilder.PBBoolean)((((ib_lbuttonpressed| ib_rbuttonpressed)& ab_cntrlpressed)& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false)))| (((idw_requestor.IsSelected(al_row)& ib_lbuttonpressed)& (ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false)))))
		#line hidden
		{
			#line 78
			lb_waitforbuttonup = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 80
		else if ((Sybase.PowerBuilder.PBBoolean)(((idw_requestor.IsSelected(al_row)& ib_rbuttonpressed)& (ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 82
			lb_takenoaction = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 85
		if (lb_waitforbuttonup)
		#line hidden
		{
			#line 87
			il_prevclickedrow = al_row;
			#line hidden
			#line 88
			ib_prevcntrl = ab_cntrlpressed;
			#line hidden
			#line 89
			ib_prevshift = ab_shiftpressed;
			#line hidden
			#line 91
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 95
		il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 96
		ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 97
		ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 99
		if (lb_takenoaction)
		#line hidden
		{
			#line 103
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 115
		if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 117
			idw_requestor.SelectRow(al_row, !(idw_requestor.IsSelected(al_row)));
			#line hidden
			#line 120
			il_anchorrow = al_row;
			#line hidden
		}
		#line 122
		else if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed| ab_shiftpressed))
		#line hidden
		{
			#line 131
			if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))
			#line hidden
			{
				#line 133
				idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
			}
			#line 137
			if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 138
				idw_requestor.SelectRow(al_row, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
			else
			{
				#line 141
				idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
				#line 144
				if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow> al_row))
				#line hidden
				{
					#line 145
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i >= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + ((Sybase.PowerBuilder.PBInt)(new Sybase.PowerBuilder.PBInt(-1))))
					#line hidden
					{
							#line 146
							idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				else
				{
					#line 149
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i <= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + 1)
					#line hidden
					{
							#line 150
							idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				#line 155
				idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		else
		{
			#line 160
			this.of_rowselectsingle(al_row);
			#line hidden
			#line 163
			il_anchorrow = al_row;
			#line hidden
		}
		#line 168
		if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.GetRow() != al_row))
		#line hidden
		{
			#line 169
			idw_requestor.SetRow(al_row);
			#line hidden
		}
		#line 172
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_buttonup(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_buttonup", new string[]{}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_buttonup()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__u_dw)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(idw_requestor)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(idw_requestor)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 52
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar0 = ii_style;
		#line hidden
		#line 53
		if (__PB_TEMP______switchTmpVar0 == single )
		#line hidden
		{
		}
		#line 56
		else if (__PB_TEMP______switchTmpVar0 == multiple )
		#line hidden
		{
		}
		#line 59
		else if (__PB_TEMP______switchTmpVar0 == extended )
		#line hidden
		{
			#line 61
			if ((Sybase.PowerBuilder.PBBoolean)(il_prevclickedrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 62
				li_rc = this.of_rowselectext(il_prevclickedrow, ib_prevcntrl, ib_prevshift);
				#line hidden
			}
		}

		#line 67
		il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 68
		ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 69
		ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 71
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_setstyle(II)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setstyle", new string[]{"integer"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setstyle(Sybase.PowerBuilder.PBInt ai_style)
	{
		#line hidden
		#line 54
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ai_style)))))
		#line hidden
		{
			#line 55
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 58
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar1 = ai_style;
		#line hidden
		#line 59
		if ((__PB_TEMP______switchTmpVar1 == single )|| (__PB_TEMP______switchTmpVar1 == multiple )|| (__PB_TEMP______switchTmpVar1 == extended ))
		#line hidden
		{
			#line 60
			ii_style = ai_style;
			#line hidden
			#line 61
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}

		#line 64
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_getstyle(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getstyle", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getstyle()
	{
		#line hidden
		#line 47
		return ii_style;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_rowselect(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_rowselect", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_rowselect(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(-1);
		#line 49
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar2 = ii_style;
		#line hidden
		#line 50
		if (__PB_TEMP______switchTmpVar2 == single )
		#line hidden
		{
			#line 51
			li_rc = this.of_rowselectsingle(al_row);
			#line hidden
		}
		#line 53
		else if (__PB_TEMP______switchTmpVar2 == multiple )
		#line hidden
		{
			#line 54
			li_rc = this.of_rowselectmulti(al_row);
			#line hidden
		}
		#line 56
		else if (__PB_TEMP______switchTmpVar2 == extended )
		#line hidden
		{
			#line 57
			li_rc = this.of_rowselectext(al_row, Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyControl))), Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyShift))));
			#line hidden
		}

		#line 60
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_keybrowselectext(ILBB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_keybrowselectext", new string[]{"long", "boolean", "boolean"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_keybrowselectext(Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.PBBoolean ab_cntrlpressed, Sybase.PowerBuilder.PBBoolean ab_shiftpressed)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_i = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 57
		ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 58
		ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 60
		if (ab_shiftpressed)
		#line hidden
		{
			#line 63
			idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 66
			if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 67
				idw_requestor.SelectRow(al_row, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
			else
			{
				#line 70
				idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
				#line 73
				if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow> al_row))
				#line hidden
				{
					#line 74
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i >= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + ((Sybase.PowerBuilder.PBInt)(new Sybase.PowerBuilder.PBInt(-1))))
					#line hidden
					{
							#line 75
							idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				else
				{
					#line 78
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i <= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + 1)
					#line hidden
					{
							#line 79
							idw_requestor.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				#line 84
				idw_requestor.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		#line 87
		else if (ab_cntrlpressed)
		#line hidden
		{
		}
		else
		{
			#line 92
			this.of_rowselectsingle(al_row);
			#line hidden
			#line 95
			il_anchorrow = al_row;
			#line hidden
		}
		#line 100
		if ((Sybase.PowerBuilder.PBBoolean)(idw_requestor.GetRow() != al_row))
		#line hidden
		{
			#line 101
			idw_requestor.SetRow(al_row);
			#line hidden
		}
		#line 104
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_keybrowselect(IL)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_keybrowselect", new string[]{"long"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_keybrowselect(Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(-1);
		#line 48
		Sybase.PowerBuilder.PBInt __PB_TEMP______switchTmpVar3 = ii_style;
		#line hidden
		#line 49
		if (__PB_TEMP______switchTmpVar3 == single )
		#line hidden
		{
			#line 50
			li_rc = this.of_rowselectsingle(al_row);
			#line hidden
		}
		#line 52
		else if (__PB_TEMP______switchTmpVar3 == multiple )
		#line hidden
		{
		}
		#line 55
		else if (__PB_TEMP______switchTmpVar3 == extended )
		#line hidden
		{
			#line 56
			li_rc = this.of_keybrowselectext(al_row, Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyControl))), Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyShift))));
			#line hidden
		}

		#line 59
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_setkeyboard(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setkeyboard", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setkeyboard(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		ib_keyboard = ab_switch;
		#line hidden
		#line 54
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("Row Selection");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("Provides the datawindow with either Singlerow selection, ")+ new Sybase.PowerBuilder.PBString("Multirow selection, or Extendedrow selection.");
		#line hidden
		#line 54
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
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
		new Sybase.PowerBuilder.PBString("u_tabpg_dwproperty_srvrowselection") })));
		#line hidden
		#line 57
		anv_attrib.ib_switchbuttons = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 59
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_dwsrv_rowselection.of_iskeyboard(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_iskeyboard", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_iskeyboard()
	{
		#line hidden
		#line 45
		return ib_keyboard;
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

	public c__pfc_n_cst_dwsrv_rowselection()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_dwsrv_rowselection(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_dwsrv_rowselection vv = new c__pfc_n_cst_dwsrv_rowselection();
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
			return (c__pfc_n_cst_dwsrv_rowselection) v.Value;
		}
	}
}
 