//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx\\u_pbargeneral.sru"
#line hidden
#line 1 "u_pbargeneral"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("u_pbargeneral",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\appexamp.pbl\\appexamp.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="u_pbargeneral")]
public class c__u_pbargeneral : c__u_tabpg
{
	#line hidden
	public c__u_pbargeneral.c__cbx_autoreset cbx_autoreset = null;
	public c__u_pbargeneral.c__ddlb_fillstyle ddlb_fillstyle = null;
	public c__u_pbargeneral.c__ddlb_displaystyle ddlb_displaystyle = null;
	public c__u_pbargeneral.c__st_1 st_1 = null;
	public c__u_pbargeneral.c__st_3 st_3 = null;
	public c__u_pbargeneral.c__st_4 st_4 = null;
	public c__u_pbargeneral.c__ddlb_borderstyle ddlb_borderstyle = null;
	public c__u_pbargeneral.c__st_8 st_8 = null;
	public c__u_pbargeneral.c__gb_2 gb_2 = null;
	public c__u_pbargeneral.c__ddlb_messagetext ddlb_messagetext = null;
	public c__u_pbargeneral.c__st_5 st_5 = null;
	public c__u_pbargeneral.c__sle_minimum sle_minimum = null;
	public c__u_pbargeneral.c__st_6 st_6 = null;
	public c__u_pbargeneral.c__sle_maximum sle_maximum = null;
	public c__u_pbargeneral.c__st_7 st_7 = null;
	public c__u_pbargeneral.c__sle_step sle_step = null;
	public c__u_pbargeneral.c__gb_1 gb_1 = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_selectionchanged", null, "u_pbargeneral", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Public, "= false")]
	public Sybase.PowerBuilder.PBBoolean ib_selectionchanged = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_messages", null, "u_pbargeneral", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray is_messages = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_selectedmsg", null, "u_pbargeneral", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_selectedmsg = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iuo_progbar", null, "u_pbargeneral", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__u_progressbar iuo_progbar = null;

	#line 1 "u_pbargeneral.ue_apply"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("ue_apply")]
	public virtual void ue_apply()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 42
		iuo_progbar = (c__u_progressbar)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 44
		of_setmessagetext_1_345252223_1624237752(iuo_progbar, (Sybase.PowerBuilder.PBUnboundedStringArray)(is_messages).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)));
		#line hidden
		#line 46
		iuo_progbar.of_setautoreset(cbx_autoreset.Checked);
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)((iuo_progbar.Border == new Sybase.PowerBuilder.PBBoolean(false))& (ddlb_borderstyle.Text != new Sybase.PowerBuilder.PBString("None"))))
		#line hidden
		{
			#line 49
			iuo_progbar.Border = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		#line 52
		Sybase.PowerBuilder.PBString __PB_TEMP______switchTmpVar0 = ddlb_borderstyle.Text;
		#line hidden
		#line 53
		if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("Box") )
		#line hidden
		{
			#line 54
			iuo_progbar.BorderStyle = (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleBox));
			#line hidden
		}
		#line 55
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("3D Lowered") )
		#line hidden
		{
			#line 56
			iuo_progbar.BorderStyle = (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleLowered));
			#line hidden
		}
		#line 57
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("3D Raised") )
		#line hidden
		{
			#line 58
			iuo_progbar.BorderStyle = (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleRaised));
			#line hidden
		}
		#line 59
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("ShadowBox") )
		#line hidden
		{
			#line 60
			iuo_progbar.BorderStyle = (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleShadowBox));
			#line hidden
		}
		#line 61
		else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("None") )
		#line hidden
		{
			#line 62
			iuo_progbar.Border = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}

		#line 65
		li_index = ddlb_displaystyle.FindItem(ddlb_displaystyle.Text, new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 66
		iuo_progbar.of_setdisplaystyle((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_index)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
		#line hidden
		#line 68
		li_index = ddlb_fillstyle.FindItem(ddlb_fillstyle.Text, new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 69
		iuo_progbar.of_setfillstyle((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_index)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
		#line hidden
		#line 71
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNumber(sle_maximum.Text))
		#line hidden
		{
			#line 72
			iuo_progbar.of_setmaximum(Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(sle_maximum.Text)))));
			#line hidden
		}
		#line 75
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNumber(sle_minimum.Text))
		#line hidden
		{
			#line 76
			iuo_progbar.of_setminimum(Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(sle_minimum.Text)))));
			#line hidden
		}
		#line 79
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNumber(sle_step.Text))
		#line hidden
		{
			#line 80
			iuo_progbar.of_setstep(Sybase.PowerBuilder.WPF.PBSystemFunctions.Integer((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(sle_step.Text)))));
			#line hidden
		}
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
		this.cbx_autoreset = (c__cbx_autoreset)this.CreateInstance(this, "c__cbx_autoreset");
		#line hidden
		#line hidden
		this.ddlb_fillstyle = (c__ddlb_fillstyle)this.CreateInstance(this, "c__ddlb_fillstyle");
		#line hidden
		#line hidden
		this.ddlb_displaystyle = (c__ddlb_displaystyle)this.CreateInstance(this, "c__ddlb_displaystyle");
		#line hidden
		#line hidden
		this.st_1 = (c__st_1)this.CreateInstance(this, "c__st_1");
		#line hidden
		#line hidden
		this.st_3 = (c__st_3)this.CreateInstance(this, "c__st_3");
		#line hidden
		#line hidden
		this.st_4 = (c__st_4)this.CreateInstance(this, "c__st_4");
		#line hidden
		#line hidden
		this.ddlb_borderstyle = (c__ddlb_borderstyle)this.CreateInstance(this, "c__ddlb_borderstyle");
		#line hidden
		#line hidden
		this.st_8 = (c__st_8)this.CreateInstance(this, "c__st_8");
		#line hidden
		#line hidden
		this.gb_2 = (c__gb_2)this.CreateInstance(this, "c__gb_2");
		#line hidden
		#line hidden
		this.ddlb_messagetext = (c__ddlb_messagetext)this.CreateInstance(this, "c__ddlb_messagetext");
		#line hidden
		#line hidden
		this.st_5 = (c__st_5)this.CreateInstance(this, "c__st_5");
		#line hidden
		#line hidden
		this.sle_minimum = (c__sle_minimum)this.CreateInstance(this, "c__sle_minimum");
		#line hidden
		#line hidden
		this.st_6 = (c__st_6)this.CreateInstance(this, "c__st_6");
		#line hidden
		#line hidden
		this.sle_maximum = (c__sle_maximum)this.CreateInstance(this, "c__sle_maximum");
		#line hidden
		#line hidden
		this.st_7 = (c__st_7)this.CreateInstance(this, "c__st_7");
		#line hidden
		#line hidden
		this.sle_step = (c__sle_step)this.CreateInstance(this, "c__sle_step");
		#line hidden
		#line hidden
		this.gb_1 = (c__gb_1)this.CreateInstance(this, "c__gb_1");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(cbx_autoreset);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(ddlb_fillstyle);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(ddlb_displaystyle);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_1);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_3);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_4);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(ddlb_borderstyle);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_8);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(gb_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(ddlb_messagetext);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_5);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(sle_minimum);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(13)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_6);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(14)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(sle_maximum);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(15)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(st_7);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(16)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(sle_step);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(17)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(gb_1);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_autoreset);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_fillstyle);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_displaystyle);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_3);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_4);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_borderstyle);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_8);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_messagetext);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_5);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_minimum);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_6);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_maximum);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_7);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_step);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_1);
		#line hidden
	}

	#line 1 "u_pbargeneral.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_borderindex = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_displaystyle = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_fillstyle = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_msgcount = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_style = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.constructor();
		#line hidden
		#line 48
		iuo_progbar = (c__u_progressbar)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__pfcexamp.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 51
		li_msgcount = of_getmessagetext_1_345252223_1624237752(iuo_progbar, ref is_messages);
		#line hidden
		#line 52
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_msgcount)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 53
			for (li_count = new Sybase.PowerBuilder.PBInt(1);li_count <= li_msgcount;li_count = li_count + 1)
			#line hidden
			{
					#line 54
					ddlb_messagetext.AddItem(((Sybase.PowerBuilder.PBString)is_messages[(Sybase.PowerBuilder.PBLong)(li_count)]));
					#line hidden
			}
			#line 56
			ddlb_messagetext.SelectItem(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
			#line 57
			is_selectedmsg = ddlb_messagetext.text(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		else
		{
			#line 59
			is_selectedmsg = new Sybase.PowerBuilder.PBString("");
			#line hidden
		}
		#line 62
		cbx_autoreset.Checked = iuo_progbar.of_isautoreset();
		#line hidden
		#line 64
		if ((Sybase.PowerBuilder.PBBoolean)(iuo_progbar.Border == new Sybase.PowerBuilder.PBBoolean(true)))
		#line hidden
		{
			#line 65
			Sybase.PowerBuilder.PBBorderStyleValue __PB_TEMP______switchTmpVar1 = iuo_progbar.BorderStyle;
			#line hidden
			#line 66
			if (__PB_TEMP______switchTmpVar1 == (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleBox)) )
			#line hidden
			{
				#line 67
				ddlb_borderstyle.SelectItem(new Sybase.PowerBuilder.PBString("Box"), li_borderindex);
				#line hidden
			}
			#line 68
			else if (__PB_TEMP______switchTmpVar1 == (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleLowered)) )
			#line hidden
			{
				#line 69
				ddlb_borderstyle.SelectItem(new Sybase.PowerBuilder.PBString("3D Lowered"), li_borderindex);
				#line hidden
			}
			#line 70
			else if (__PB_TEMP______switchTmpVar1 == (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleRaised)) )
			#line hidden
			{
				#line 71
				ddlb_borderstyle.SelectItem(new Sybase.PowerBuilder.PBString("3D Raised"), li_borderindex);
				#line hidden
			}
			#line 72
			else if (__PB_TEMP______switchTmpVar1 == (new Sybase.PowerBuilder.PBBorderStyleValue(Sybase.PowerBuilder.PBBorderStyle.StyleShadowBox)) )
			#line hidden
			{
				#line 73
				ddlb_borderstyle.SelectItem(new Sybase.PowerBuilder.PBString("ShadowBox"), li_borderindex);
				#line hidden
			}

		}
		else
		{
			#line 76
			ddlb_borderstyle.SelectItem(new Sybase.PowerBuilder.PBString("None"), li_borderindex);
			#line hidden
		}
		#line 79
		li_displaystyle = iuo_progbar.of_getdisplaystyle();
		#line hidden
		#line 80
		ddlb_displaystyle.SelectItem((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_displaystyle)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
		#line hidden
		#line 82
		li_fillstyle = iuo_progbar.of_getfillstyle();
		#line hidden
		#line 83
		ddlb_fillstyle.SelectItem((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_fillstyle)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
		#line hidden
		#line 85
		sle_maximum.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(iuo_progbar.of_getmaximum()))));
		#line hidden
		#line 86
		sle_minimum.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(iuo_progbar.of_getminimum()))));
		#line hidden
		#line 87
		sle_step.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(iuo_progbar.of_getstep()))));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	public Sybase.PowerBuilder.PBInt of_setmessagetext_1_345252223_1624237752(c__pfc_u_progressbar this__object, Sybase.PowerBuilder.PBArray as_msgtext)
	{
		 Sybase.PowerBuilder.PBArray temp_var_as_msgtext = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_msgtext.AssignFrom(as_msgtext);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_setmessagetext_1_345252223(temp_var_as_msgtext);
		return return_value;
	}

	public Sybase.PowerBuilder.PBInt of_getmessagetext_1_345252223_1624237752(c__pfc_u_progressbar this__object, ref Sybase.PowerBuilder.PBArray as_messagetext)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getmessagetext_1_345252223(ref as_messagetext);
		return return_value;
	}


	#line 1 "u_pbargeneral.cbx_autoreset"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_autoreset")]
	public class c__cbx_autoreset : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_autoreset()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.ddlb_fillstyle"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_fillstyle")]
	public class c__ddlb_fillstyle : c__u_ddlb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_fillstyle()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.ddlb_displaystyle"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_displaystyle")]
	public class c__ddlb_displaystyle : c__u_ddlb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_displaystyle()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_1")]
	public class c__st_1 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_1()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_3"
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


	#line 1 "u_pbargeneral.st_4"
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


	#line 1 "u_pbargeneral.ddlb_borderstyle"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_borderstyle")]
	public class c__ddlb_borderstyle : c__u_ddlb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_borderstyle()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_8"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_8")]
	public class c__st_8 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_8()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.gb_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_2")]
	public class c__gb_2 : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_2()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.ddlb_messagetext"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_messagetext")]
	public class c__ddlb_messagetext : c__u_ddlb
	{
		#line hidden

		#line 1 "u_pbargeneral.ddlb_messagetext.selectionchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_cbnselchange)]
		public override Sybase.PowerBuilder.PBLong selectionchanged(Sybase.PowerBuilder.PBInt index)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanged(index);
			#line hidden
			#line 1
			((c__u_pbargeneral)(Parent)).is_selectedmsg = this.Text;
			#line hidden
			#line 2
			((c__u_pbargeneral)(Parent)).ib_selectionchanged = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "u_pbargeneral.ddlb_messagetext.modified"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("modified")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_cbnmodified)]
		public override Sybase.PowerBuilder.PBLong modified()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_count = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_index = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_msgcount = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_newmessage = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.modified();
			#line hidden
			#line 6
			if ((Sybase.PowerBuilder.PBBoolean)(((c__u_pbargeneral)(Parent)).ib_selectionchanged == new Sybase.PowerBuilder.PBBoolean(true)))
			#line hidden
			{
				#line 7
				((c__u_pbargeneral)(Parent)).ib_selectionchanged = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 8
				return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0));
				#line hidden
			}
			#line 11
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(this.TotalItems())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 12
				li_index = this.FindItem(((c__u_pbargeneral)(Parent)).is_selectedmsg, new Sybase.PowerBuilder.PBInt(0));
				#line hidden
				#line 13
				((c__u_pbargeneral)(Parent)).is_messages[((c__u_pbargeneral)(Parent)).is_messages.Extend((Sybase.PowerBuilder.PBLong)(li_index))] = this.Text;
				#line hidden
				#line 14
				((c__u_pbargeneral)(Parent)).is_selectedmsg = this.Text;
				#line hidden
				#line 16
				li_msgcount = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(((c__u_pbargeneral)(Parent)).is_messages)));
				#line hidden
				#line 17
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_msgcount)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 18
					this.Reset();
					#line hidden
					#line 19
					for (li_count = new Sybase.PowerBuilder.PBInt(1);li_count <= li_msgcount;li_count = li_count + 1)
					#line hidden
					{
							#line 20
							((c__u_pbargeneral)(Parent)).ddlb_messagetext.AddItem(((Sybase.PowerBuilder.PBString)((c__u_pbargeneral)(Parent)).is_messages[(Sybase.PowerBuilder.PBLong)(li_count)]));
							#line hidden
					}
					#line 22
					if ((Sybase.PowerBuilder.PBBoolean)(((c__u_pbargeneral)(Parent)).is_selectedmsg != new Sybase.PowerBuilder.PBString("")))
					#line hidden
					{
						#line 23
						li_index = this.FindItem(((c__u_pbargeneral)(Parent)).is_selectedmsg, new Sybase.PowerBuilder.PBInt(0));
						#line hidden
						#line 24
						((c__u_pbargeneral)(Parent)).ddlb_messagetext.SelectItem(li_index);
						#line hidden
					}
				}
			}
			else
			{
				#line 28
				li_newmessage = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(((c__u_pbargeneral)(Parent)).is_messages))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
				#line hidden
				#line 29
				((c__u_pbargeneral)(Parent)).is_messages[((c__u_pbargeneral)(Parent)).is_messages.Extend((Sybase.PowerBuilder.PBLong)(li_newmessage))] = this.Text;
				#line hidden
				#line 30
				((c__u_pbargeneral)(Parent)).is_selectedmsg = this.Text;
				#line hidden
				#line 31
				this.AddItem(this.Text);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.SelectionChangedEvent += new Sybase.PowerBuilder.PBM_EventHandler_i(this.selectionchanged);
			this.ModifiedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.modified);

			OnInitialUpdate();
		}

		public c__ddlb_messagetext()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_5"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_5")]
	public class c__st_5 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_5()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.sle_minimum"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_minimum")]
	public class c__sle_minimum : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_minimum()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_6"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_6")]
	public class c__st_6 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_6()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.sle_maximum"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_maximum")]
	public class c__sle_maximum : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_maximum()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.st_7"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_7")]
	public class c__st_7 : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_7()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.sle_step"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_step")]
	public class c__sle_step : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_step()
		{
			_init();
		}

	}


	#line 1 "u_pbargeneral.gb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_1")]
	public class c__gb_1 : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

		OnInitialUpdate();
	}

	public c__u_pbargeneral()
	{
		_init();
	}

}
 