//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_w_selection.srw"
#line hidden
#line 1 "pfc_w_selection"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_selection",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_selection")]
public class c__pfc_w_selection : c__w_response
{
	#line hidden
	public c__pfc_w_selection.c__dw_1 dw_1 = null;
	public c__pfc_w_selection.c__cb_ok cb_ok = null;
	public c__pfc_w_selection.c__cb_cancel cb_cancel = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwmaxwidth", null, "pfc_w_selection", 2150, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 2150")]
	protected Sybase.PowerBuilder.PBInt ii_dwmaxwidth = new Sybase.PowerBuilder.PBInt(2150);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwmaxheight", null, "pfc_w_selection", 960, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 960")]
	protected Sybase.PowerBuilder.PBInt ii_dwmaxheight = new Sybase.PowerBuilder.PBInt(960);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwminwidth", null, "pfc_w_selection", 729, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 729")]
	protected Sybase.PowerBuilder.PBInt ii_dwminwidth = new Sybase.PowerBuilder.PBInt(729);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_dwminheight", null, "pfc_w_selection", 551, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 551")]
	protected Sybase.PowerBuilder.PBInt ii_dwminheight = new Sybase.PowerBuilder.PBInt(551);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_selectionattrib", null, "pfc_w_selection", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_selectionattrib inv_selectionattrib = (c__n_cst_selectionattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_selectionattrib));

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
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
	}

	#line 1 "pfc_w_selection.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBString white = new Sybase.PowerBuilder.PBString("16777215");
		Sybase.PowerBuilder.PBLong ll_rowcount = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_width = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_height = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_errbuffer = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_syntax = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_presentation = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 46
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 48
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 50
		inv_selectionattrib = (c__n_cst_selectionattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfcsecurity_admin.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 52
		this.Title = inv_selectionattrib.is_title;
		#line hidden
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(inv_selectionattrib.is_dataobject, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))) == new Sybase.PowerBuilder.PBString("release")))
		#line hidden
		{
			#line 57
			dw_1.Create(inv_selectionattrib.is_dataobject, ref ls_errbuffer);
			#line hidden
		}
		else
		{
			#line 59
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(inv_selectionattrib.is_dataobject, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))) == new Sybase.PowerBuilder.PBString("select")))
			#line hidden
			{
				#line 61
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_selectionattrib.itr_object)))
				#line hidden
				{
					#line 62
					if (inv_selectionattrib.itr_object.of_isconnected())
					#line hidden
					{
						#line 64
						ls_presentation = ((((((new Sybase.PowerBuilder.PBString("DataWindow (color=")+ white)+ new Sybase.PowerBuilder.PBString(") "))+ new Sybase.PowerBuilder.PBString("Column (background.mode=1 border=0 color=0 edit.displayonly='yes' edit.focusrectangle='no' "))+ new Sybase.PowerBuilder.PBString("font.face='MS Sans Serif' font.height='-8' font.weight=400 font.family=2 font.pitch=2 font.charset=0) "))+ new Sybase.PowerBuilder.PBString("Text (alignment=0 border=0 color=0 background.mode=1 "))+ new Sybase.PowerBuilder.PBString("font.face='MS Sans Serif' font.height='-8' font.weight=400 font.family=2 font.pitch=2 font.charset=0) "))+ new Sybase.PowerBuilder.PBString("Style (Header_Bottom_Margin=0 Header_Top_Margin=0 Report='yes')");
						#line hidden
						#line 72
						ls_syntax = inv_selectionattrib.itr_object.SyntaxFromSQL(inv_selectionattrib.is_dataobject, ls_presentation, ref ls_errbuffer);
						#line hidden
						#line 74
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_syntax)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
						#line hidden
						{
							#line 75
							if ((Sybase.PowerBuilder.PBBoolean)(dw_1.Create(ls_syntax, ref ls_errbuffer) == new Sybase.PowerBuilder.PBInt(1)))
							#line hidden
							{
								#line 76
								dw_1.SetSort(new Sybase.PowerBuilder.PBString("#1 A"));
								#line hidden
							}
						}
					}
				}
			}
			else
			{
				#line 82
				dw_1.DataObject = inv_selectionattrib.is_dataobject;
				#line hidden
			}
		}
		#line 86
		dw_1.of_setbase(new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 87
		dw_1.inv_base.of_modify(new Sybase.PowerBuilder.PBString("protect"), new Sybase.PowerBuilder.PBString("1"), new Sybase.PowerBuilder.PBString("column"), new Sybase.PowerBuilder.PBString("*"), new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 90
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_selectionattrib.itr_object)))
		#line hidden
		{
			#line 91
			dw_1.of_settransobject(inv_selectionattrib.itr_object);
			#line hidden
		}
		#line 95
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_selectionattrib.itr_object)))
		#line hidden
		{
			#line 96
			dw_1.Retrieve(((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(13))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(14))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(15))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(16))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(17))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(18))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(19))]))), ((Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBAny(inv_selectionattrib.ia_argument[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(20))]))));
			#line hidden
		}
		#line 107
		else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_selectionattrib.ipo_data))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 108
			((Sybase.PowerBuilder.PBExtObject)(dw_1.Object))[new Sybase.PowerBuilder.PBString(@"data")] = (Sybase.PowerBuilder.PBAny)(inv_selectionattrib.ipo_data);
			#line hidden
		}
		#line 111
		ll_rowcount = dw_1.RowCount();
		#line hidden
		#line 112
		if ((Sybase.PowerBuilder.PBBoolean)(ll_rowcount> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 114
			this.of_setresize(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 115
			inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(dw_1), c__n_cst_resize.scalerightbottom);
			#line hidden
			#line 116
			inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_ok), c__n_cst_resize.fixedrightbottom);
			#line hidden
			#line 117
			inv_resize.of_register((Sybase.PowerBuilder.WPF.PBWindowObject)(cb_cancel), c__n_cst_resize.fixedrightbottom);
			#line hidden
			#line 120
			ll_width = dw_1.inv_base.of_getwidth();
			#line hidden
			#line 121
			ll_width = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Min((Sybase.PowerBuilder.PBDouble)(ii_dwmaxwidth), (Sybase.PowerBuilder.PBDouble)(ll_width)));
			#line hidden
			#line 122
			if ((Sybase.PowerBuilder.PBBoolean)(ll_width == (Sybase.PowerBuilder.PBLong)(ii_dwmaxwidth)))
			#line hidden
			{
				#line 123
				dw_1.HScrollBar = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			#line 125
			ll_width = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Max((Sybase.PowerBuilder.PBDouble)(ii_dwminwidth), (Sybase.PowerBuilder.PBDouble)(ll_width)));
			#line hidden
			#line 127
			ll_height = dw_1.inv_base.of_getheight();
			#line hidden
			#line 128
			ll_height = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Min((Sybase.PowerBuilder.PBDouble)(ii_dwmaxheight), (Sybase.PowerBuilder.PBDouble)(ll_height)));
			#line hidden
			#line 129
			ll_height = (Sybase.PowerBuilder.PBLong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Max((Sybase.PowerBuilder.PBDouble)(ii_dwminheight), (Sybase.PowerBuilder.PBDouble)(ll_height)));
			#line hidden
			#line 131
			this.Resize((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Width)+ (ll_width- (Sybase.PowerBuilder.PBLong)(dw_1.Width))), (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Height)+ (ll_height- (Sybase.PowerBuilder.PBLong)(dw_1.Height))));
			#line hidden
		}
		else
		{
			#line 133
			cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_selection.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		Sybase.PowerBuilder.PBArray la_returnval = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_numcolumns = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_currow = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		base.pfc_default();
		#line hidden
		#line 44
		inv_selectionattrib.ia_returnval.AssignFrom((Sybase.PowerBuilder.PBArray)la_returnval);
		#line hidden
		#line 47
		ll_currow = dw_1.GetRow();
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(ll_currow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 49
			li_numcolumns = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_selectionattrib.is_columnreturn)));
			#line hidden
			#line 51
			if ((Sybase.PowerBuilder.PBBoolean)(li_numcolumns == new Sybase.PowerBuilder.PBInt(0)))
			#line hidden
			{
				#line 52
				li_numcolumns = Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer(((Sybase.PowerBuilder.PBAny)((((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)((((Sybase.PowerBuilder.PBExtObject)(dw_1.Object))[new Sybase.PowerBuilder.PBString(@"datawindow"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"column"), Sybase.PowerBuilder.PBBoolean.False].Value)))[new Sybase.PowerBuilder.PBString(@"count"), Sybase.PowerBuilder.PBBoolean.True]))));
				#line hidden
				#line 53
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_numcolumns)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 54
					inv_selectionattrib.ia_returnval[inv_selectionattrib.ia_returnval.Extend((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = dw_1.inv_rowselect.of_getitemany(ll_currow, new Sybase.PowerBuilder.PBInt(1));
					#line hidden
				}
			}
			else
			{
				#line 57
				for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_numcolumns;li_cnt = li_cnt + 1)
				#line hidden
				{
						#line 58
						inv_selectionattrib.ia_returnval[inv_selectionattrib.ia_returnval.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))] = dw_1.inv_rowselect.of_getitemany(ll_currow, ((Sybase.PowerBuilder.PBString)inv_selectionattrib.is_columnreturn[(Sybase.PowerBuilder.PBLong)(li_cnt)]));
						#line hidden
				}
			}
		}
		#line 63
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_selectionattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_selectionattrib)))));
		#line hidden
	}

	#line 1 "pfc_w_selection.close"
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
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_selectionattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_selectionattrib)))));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_selection.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		Sybase.PowerBuilder.PBArray la_temp = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 41
		inv_selectionattrib.ia_returnval.AssignFrom((Sybase.PowerBuilder.PBArray)la_temp);
		#line hidden
		#line 42
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_selectionattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_selectionattrib)))));
		#line hidden
	}

	#line 1 "pfc_w_selection.dw_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__u_dw
	{
		#line hidden

		#line 1 "pfc_w_selection.dw_1.constructor"
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
			#line 5
			ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_selection.dw_1.clicked"
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
			#line 39
			if ((Sybase.PowerBuilder.PBBoolean)(this.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 40
				((c__pfc_w_selection)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
			else
			{
				#line 42
				((c__pfc_w_selection)(Parent)).cb_ok.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_w_selection.dw_1.doubleclicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("doubleclicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnlbuttondblclk)]
		public override Sybase.PowerBuilder.PBLong doubleclicked(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos, Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.doubleclicked(xpos, ypos, row, dwo);
			#line hidden
			#line 39
			if ((Sybase.PowerBuilder.PBBoolean)(this.GetSelectedRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 40
				((c__pfc_w_selection)(this.Parent)).pfc_default();
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
			this.ClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.clicked);
			this.DoubleClickedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_iildw(this.doubleclicked);

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	#line 1 "pfc_w_selection.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_selection.cb_ok.clicked"
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
			((c__pfc_w_selection)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_selection.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_selection.cb_cancel.clicked"
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
			((c__pfc_w_selection)(this.Parent)).pfc_cancel();
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


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.CloseEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.close);
	}

	public c__pfc_w_selection()
	{
		_init();
	}

}
 