//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx\\pfcscanner_u_dw.sru"
#line hidden
#line 1 "pfcscanner_u_dw"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfcscanner_u_dw",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfcscanner_u_dw")]
public class c__pfcscanner_u_dw : Sybase.PowerBuilder.WPF.PBDataWindow
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_sortcolumn", null, "pfcscanner_u_dw", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Public, "= ''")]
	public Sybase.PowerBuilder.PBString is_sortcolumn = new Sybase.PowerBuilder.PBString("");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_sortorder", null, "pfcscanner_u_dw", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Public, "= ''")]
	public Sybase.PowerBuilder.PBString is_sortorder = new Sybase.PowerBuilder.PBString("");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_rbuttonpressed", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_rbuttonpressed = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_lbuttonpressed", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_lbuttonpressed = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_prevclickedrow", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBLong il_prevclickedrow = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_anchorrow", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBLong il_anchorrow = Sybase.PowerBuilder.PBLong.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_prevcntrl", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_prevcntrl = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_prevshift", null, "pfcscanner_u_dw", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_prevshift = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_extended", null, "pfcscanner_u_dw", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Public, "= false")]
	public Sybase.PowerBuilder.PBBoolean ib_extended = new Sybase.PowerBuilder.PBBoolean(false);

	#line 1 "pfcscanner_u_dw.lbuttonup"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("lbuttonup")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_lbuttonup)]
	public virtual Sybase.PowerBuilder.PBLong lbuttonup(Sybase.PowerBuilder.PBULong flags, Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
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
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfcscanner_u_dw.lbuttondown"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("lbuttondown")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_lbuttondown)]
	public virtual Sybase.PowerBuilder.PBLong lbuttondown(Sybase.PowerBuilder.PBULong flags, Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
	{
		#line hidden
		#line 46
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 49
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfcscanner_u_dw.rbuttonup"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("rbuttonup")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_rbuttonup)]
	public virtual Sybase.PowerBuilder.PBLong rbuttonup(Sybase.PowerBuilder.PBULong flags, Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
	{
		#line hidden
		#line 46
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 49
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 52
		this.of_buttonup();
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfcscanner_u_dw.of_sort(ICdwobject.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sort", new string[]{"dwobject"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sort(Sybase.PowerBuilder.WPF.PBDWObject a_dwo)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_colname = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_sortstring = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_headername = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBInt li_headerlen = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_suffixlen = new Sybase.PowerBuilder.PBInt(2);
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 5
		if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBExtObject)(a_dwo))[new Sybase.PowerBuilder.PBString(@"name"), Sybase.PowerBuilder.PBBoolean.True]) == (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBString("datawindow"))))
		#line hidden
		{
			#line 5
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 6
		if ((Sybase.PowerBuilder.PBBoolean)((((Sybase.PowerBuilder.PBExtObject)(a_dwo))[new Sybase.PowerBuilder.PBString(@"band"), Sybase.PowerBuilder.PBBoolean.True]) != (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBString("header"))))
		#line hidden
		{
			#line 6
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 9
		ls_headername = (Sybase.PowerBuilder.PBString)((((Sybase.PowerBuilder.PBExtObject)(a_dwo))[new Sybase.PowerBuilder.PBString(@"name"), Sybase.PowerBuilder.PBBoolean.True]));
		#line hidden
		#line 10
		li_headerlen = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_headername));
		#line hidden
		#line 14
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Right(ls_headername, (Sybase.PowerBuilder.PBLong)(li_suffixlen)) != new Sybase.PowerBuilder.PBString("_t")))
		#line hidden
		{
			#line 16
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 18
		ls_colname = Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_headername, (Sybase.PowerBuilder.PBLong)(li_headerlen)- (Sybase.PowerBuilder.PBLong)(li_suffixlen));
		#line hidden
		#line 21
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_colname))))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(ls_colname)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 22
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 26
		if ((Sybase.PowerBuilder.PBBoolean)(is_sortcolumn == ls_colname))
		#line hidden
		{
			#line 28
			if ((Sybase.PowerBuilder.PBBoolean)(is_sortorder == new Sybase.PowerBuilder.PBString(" A")))
			#line hidden
			{
				#line 29
				is_sortorder = new Sybase.PowerBuilder.PBString(" D");
				#line hidden
			}
			else
			{
				#line 31
				is_sortorder = new Sybase.PowerBuilder.PBString(" A");
				#line hidden
			}
		}
		else
		{
			#line 35
			is_sortcolumn = ls_colname;
			#line hidden
			#line 36
			is_sortorder = new Sybase.PowerBuilder.PBString(" A");
			#line hidden
		}
		#line 40
		ls_sortstring = is_sortcolumn+ is_sortorder;
		#line hidden
		#line 43
		li_rc = this.SetSort(ls_sortstring);
		#line hidden
		#line 44
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 44
			return li_rc;
			#line hidden
		}
		#line 47
		li_rc = this.Sort();
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 48
			return li_rc;
			#line hidden
		}
		#line 50
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfcscanner_u_dw.of_buttonup(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_buttonup", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_buttonup()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(il_prevclickedrow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 51
			li_rc = this.of_rowselectext(il_prevclickedrow, ib_prevcntrl, ib_prevshift);
			#line hidden
		}
		#line 55
		il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 56
		ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 57
		ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 59
		return li_rc;
		#line hidden
	}

	#line 1 "pfcscanner_u_dw.of_rowselectext(ILBB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_rowselectext", new string[]{"long", "boolean", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_rowselectext(Sybase.PowerBuilder.PBLong al_row, Sybase.PowerBuilder.PBBoolean ab_cntrlpressed, Sybase.PowerBuilder.PBBoolean ab_shiftpressed)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_i = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_waitforbuttonup = new Sybase.PowerBuilder.PBBoolean(false);
		Sybase.PowerBuilder.PBBoolean lb_takenoaction = new Sybase.PowerBuilder.PBBoolean(false);
		#line 53
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row))))| (al_row< (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 54
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 75
		if ((Sybase.PowerBuilder.PBBoolean)((((ib_lbuttonpressed| ib_rbuttonpressed)& ab_cntrlpressed)& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false)))| (((this.IsSelected(al_row)& ib_lbuttonpressed)& (ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false)))))
		#line hidden
		{
			#line 79
			lb_waitforbuttonup = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 81
		else if ((Sybase.PowerBuilder.PBBoolean)(((this.IsSelected(al_row)& ib_rbuttonpressed)& (ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 83
			lb_takenoaction = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 86
		if (lb_waitforbuttonup)
		#line hidden
		{
			#line 88
			il_prevclickedrow = al_row;
			#line hidden
			#line 89
			ib_prevcntrl = ab_cntrlpressed;
			#line hidden
			#line 90
			ib_prevshift = ab_shiftpressed;
			#line hidden
			#line 92
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 96
		il_prevclickedrow = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 97
		ib_prevcntrl = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 98
		ib_prevshift = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 100
		if (lb_takenoaction)
		#line hidden
		{
			#line 104
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}
		#line 116
		if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed& (ab_shiftpressed == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 118
			this.SelectRow(al_row, !(this.IsSelected(al_row)));
			#line hidden
			#line 121
			il_anchorrow = al_row;
			#line hidden
		}
		#line 123
		else if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed| ab_shiftpressed))
		#line hidden
		{
			#line 132
			if ((Sybase.PowerBuilder.PBBoolean)(ab_cntrlpressed == new Sybase.PowerBuilder.PBBoolean(false)))
			#line hidden
			{
				#line 134
				this.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
			}
			#line 138
			if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 139
				this.SelectRow(al_row, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
			else
			{
				#line 142
				this.SetRedraw(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
				#line 145
				if ((Sybase.PowerBuilder.PBBoolean)(il_anchorrow> al_row))
				#line hidden
				{
					#line 146
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i >= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + ((Sybase.PowerBuilder.PBInt)(new Sybase.PowerBuilder.PBInt(-1))))
					#line hidden
					{
							#line 147
							this.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				else
				{
					#line 150
					for (li_i = ((Sybase.PowerBuilder.PBInt)(il_anchorrow));li_i <= ((Sybase.PowerBuilder.PBInt)(al_row));li_i = li_i + 1)
					#line hidden
					{
							#line 151
							this.SelectRow((Sybase.PowerBuilder.PBLong)(li_i), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
					}
				}
				#line 156
				this.SetRedraw(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		else
		{
			#line 162
			this.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 165
			this.SelectRow(al_row, new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 168
			il_anchorrow = al_row;
			#line hidden
		}
		#line 173
		if ((Sybase.PowerBuilder.PBBoolean)(this.GetRow() != al_row))
		#line hidden
		{
			#line 174
			this.SetRow(al_row);
			#line hidden
		}
		#line 177
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfcscanner_u_dw.clicked"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("clicked")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnlbuttonclk)]
	public override Sybase.PowerBuilder.PBLong clicked(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 2
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBDWObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dwo)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(dwo)))))
		#line hidden
		{
			#line 3
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 6
		this.of_sort(dwo);
		#line hidden
		#line 7
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(row))))| (row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 7
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 8
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(this.GetBandAtPointer(), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6))) != new Sybase.PowerBuilder.PBString("detail")))
		#line hidden
		{
			#line 8
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(-1));
			#line hidden
		}
		#line 11
		if (ib_extended)
		#line hidden
		{
			#line 12
			return (Sybase.PowerBuilder.PBLong)(this.of_rowselectext(row, Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyControl))), Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyShift)))));
			#line hidden
		}
		else
		{
			#line 15
			this.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
			#line 18
			this.SelectRow(row, new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfcscanner_u_dw.rbuttondown"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("rbuttondown")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnrbuttondown)]
	public override Sybase.PowerBuilder.PBLong rbuttondown(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		ib_rbuttonpressed = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 49
		ib_lbuttonpressed = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(row))))| (row<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 52
			return new Sybase.PowerBuilder.PBLong(0);
			#line hidden
		}
		#line 55
		this.of_rowselectext(row, Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyControl))), Sybase.PowerBuilder.WPF.PBSystemFunctions.KeyDown((new Sybase.PowerBuilder.PBKeyCodeValue(Sybase.PowerBuilder.PBKeyCode.KeyShift))));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.ClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.clicked);
		this.RButtonDownEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.rbuttondown);

		OnInitialUpdate();
	}

	public c__pfcscanner_u_dw()
	{
		_init();
	}

}
 