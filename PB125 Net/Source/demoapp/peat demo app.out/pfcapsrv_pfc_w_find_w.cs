//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_w_find.srw"
#line hidden
#line 1 "pfc_w_find"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_find",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_find")]
public class c__pfc_w_find : c__w_popup
{
	#line hidden
	public c__pfc_w_find.c__st_findwhere st_findwhere = null;
	public c__pfc_w_find.c__st_searchfor st_searchfor = null;
	public c__pfc_w_find.c__ddlb_findwhere ddlb_findwhere = null;
	public c__pfc_w_find.c__st_searchdirection st_searchdirection = null;
	public c__pfc_w_find.c__cbx_wholeword cbx_wholeword = null;
	public c__pfc_w_find.c__cbx_matchcase cbx_matchcase = null;
	public c__pfc_w_find.c__cb_findnext cb_findnext = null;
	public c__pfc_w_find.c__cb_cancel cb_cancel = null;
	public c__pfc_w_find.c__sle_findwhat sle_findwhat = null;
	public c__pfc_w_find.c__ddlb_searchdirection ddlb_searchdirection = null;
	public c__pfc_w_find.c__cb_dlghelp cb_dlghelp = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_findattrib", null, "pfc_w_find", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public c__n_cst_findattrib inv_findattrib = (c__n_cst_findattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_findattrib));

	#line 1 "pfc_w_find.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public virtual void pfc_default()
	{
		#line hidden
		#line 34
		inv_findattrib.ii_lookindex = ddlb_findwhere.FindItem(ddlb_findwhere.Text, new Sybase.PowerBuilder.PBInt(0));
		#line hidden
		#line 37
		inv_findattrib.is_find = sle_findwhat.Text;
		#line hidden
		#line 40
		inv_findattrib.is_direction = ddlb_searchdirection.Text;
		#line hidden
		#line 43
		inv_findattrib.ib_wholeword = cbx_wholeword.Checked;
		#line hidden
		#line 46
		inv_findattrib.ib_matchcase = cbx_matchcase.Checked;
		#line hidden
		#line 49
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase_u002e_PowerBuilder_u002e_PBPowerObj267000348(inv_findattrib.ipo_requestor, ref inv_findattrib) == (Sybase.PowerBuilder.PBAny)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 50
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_find_finishsearch"), this.Title, this.Title+ new Sybase.PowerBuilder.PBString(" has finished searching."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Information)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
	}

	#line 1 "pfc_w_find.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_count = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_i = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_adjust = new Sybase.PowerBuilder.PBInt(0);
		Sybase.PowerBuilder.PBInt li_windowheightadjust = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_origwindowheight = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		ancestorreturnvalue = base.open();
		#line hidden
		#line 49
		li_windowheightadjust = new Sybase.PowerBuilder.PBInt(50);
		#line hidden
		#line 50
		li_origwindowheight = this.Height;
		#line hidden
		#line 53
		inv_findattrib = (c__n_cst_findattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__peat.GetCurrentApplication().message.PowerObjectParm))));
		#line hidden
		#line 56
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 63
		cbx_wholeword.Visible = inv_findattrib.ib_wholewordvisible;
		#line hidden
		#line 64
		cbx_wholeword.Enabled = inv_findattrib.ib_wholewordenabled;
		#line hidden
		#line 67
		cbx_matchcase.Visible = inv_findattrib.ib_matchcasevisible;
		#line hidden
		#line 68
		cbx_matchcase.Enabled = inv_findattrib.ib_matchcaseenabled;
		#line hidden
		#line 71
		ddlb_findwhere.Visible = inv_findattrib.ib_lookvisible;
		#line hidden
		#line 72
		st_findwhere.Visible = inv_findattrib.ib_lookvisible;
		#line hidden
		#line 73
		ddlb_findwhere.Enabled = inv_findattrib.ib_lookenabled;
		#line hidden
		#line 74
		st_findwhere.Enabled = inv_findattrib.ib_lookenabled;
		#line hidden
		#line 77
		ddlb_searchdirection.Visible = inv_findattrib.ib_directionvisible;
		#line hidden
		#line 78
		st_searchdirection.Visible = inv_findattrib.ib_directionvisible;
		#line hidden
		#line 79
		ddlb_searchdirection.Enabled = inv_findattrib.ib_directionenabled;
		#line hidden
		#line 80
		st_searchdirection.Enabled = inv_findattrib.ib_directionenabled;
		#line hidden
		#line 87
		if (ddlb_findwhere.Visible)
		#line hidden
		{
			#line 88
			li_count = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(inv_findattrib.is_lookdata)));
			#line hidden
			#line 89
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_count)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 90
				for (li_i = new Sybase.PowerBuilder.PBInt(1);li_i <= li_count;li_i = li_i + 1)
				#line hidden
				{
						#line 91
						ddlb_findwhere.AddItem(((Sybase.PowerBuilder.PBString)inv_findattrib.is_lookdisplay[(Sybase.PowerBuilder.PBLong)(li_i)]));
						#line hidden
				}
			}
			#line 94
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(inv_findattrib.ii_lookindex)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 95
				ddlb_findwhere.SelectItem(inv_findattrib.ii_lookindex);
				#line hidden
			}
			else
			{
				#line 97
				ddlb_findwhere.SelectItem(new Sybase.PowerBuilder.PBInt(1));
				#line hidden
			}
		}
		#line 102
		sle_findwhat.Text = inv_findattrib.is_find;
		#line hidden
		#line 105
		if (cbx_wholeword.Visible)
		#line hidden
		{
			#line 106
			cbx_wholeword.Checked = inv_findattrib.ib_wholeword;
			#line hidden
		}
		#line 110
		if (cbx_matchcase.Visible)
		#line hidden
		{
			#line 111
			cbx_matchcase.Checked = inv_findattrib.ib_matchcase;
			#line hidden
		}
		#line 115
		if (ddlb_searchdirection.Visible)
		#line hidden
		{
			#line 116
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(inv_findattrib.is_direction) == new Sybase.PowerBuilder.PBString("up")))
			#line hidden
			{
				#line 117
				ddlb_searchdirection.Text = new Sybase.PowerBuilder.PBString("Up");
				#line hidden
			}
			else
			{
				#line 119
				ddlb_searchdirection.Text = new Sybase.PowerBuilder.PBString("Down");
				#line hidden
			}
		}
		#line 128
		if ((Sybase.PowerBuilder.PBBoolean)(ddlb_findwhere.Visible == new Sybase.PowerBuilder.PBBoolean(false)))
		#line hidden
		{
			#line 130
			li_adjust = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(sle_findwhat.Y)- (Sybase.PowerBuilder.PBLong)(ddlb_findwhere.Y));
			#line hidden
			#line 133
			cbx_matchcase.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(cbx_matchcase.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 134
			cbx_wholeword.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(cbx_wholeword.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 135
			ddlb_searchdirection.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(ddlb_searchdirection.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 136
			sle_findwhat.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(sle_findwhat.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 137
			st_searchdirection.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(st_searchdirection.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 138
			st_searchfor.Y = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(st_searchfor.Y)- (Sybase.PowerBuilder.PBLong)(li_adjust));
			#line hidden
			#line 141
			this.Height = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Height)- (Sybase.PowerBuilder.PBLong)(li_windowheightadjust));
			#line hidden
			#line 144
			sle_findwhat.SetFocus();
			#line hidden
		}
		#line 148
		if ((Sybase.PowerBuilder.PBBoolean)((cbx_wholeword.Visible == new Sybase.PowerBuilder.PBBoolean(false))& cbx_matchcase.Visible))
		#line hidden
		{
			#line 149
			cbx_matchcase.Y = cbx_wholeword.Y;
			#line hidden
			#line 152
			if ((Sybase.PowerBuilder.PBBoolean)(this.Height == li_origwindowheight))
			#line hidden
			{
				#line 153
				this.Height = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Height)- (Sybase.PowerBuilder.PBLong)(li_windowheightadjust));
				#line hidden
			}
		}
		#line 158
		if ((Sybase.PowerBuilder.PBBoolean)(((ddlb_searchdirection.Visible == new Sybase.PowerBuilder.PBBoolean(false))& (cbx_wholeword.Visible == new Sybase.PowerBuilder.PBBoolean(false)))& (cbx_matchcase.Visible == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 162
			if ((Sybase.PowerBuilder.PBBoolean)(this.Height == li_origwindowheight))
			#line hidden
			{
				#line 163
				this.Height = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(this.Height)- (Sybase.PowerBuilder.PBLong)(li_windowheightadjust));
				#line hidden
			}
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
		this.st_findwhere = (c__st_findwhere)this.CreateInstance(this, "c__st_findwhere");
		#line hidden
		#line hidden
		this.st_searchfor = (c__st_searchfor)this.CreateInstance(this, "c__st_searchfor");
		#line hidden
		#line hidden
		this.ddlb_findwhere = (c__ddlb_findwhere)this.CreateInstance(this, "c__ddlb_findwhere");
		#line hidden
		#line hidden
		this.st_searchdirection = (c__st_searchdirection)this.CreateInstance(this, "c__st_searchdirection");
		#line hidden
		#line hidden
		this.cbx_wholeword = (c__cbx_wholeword)this.CreateInstance(this, "c__cbx_wholeword");
		#line hidden
		#line hidden
		this.cbx_matchcase = (c__cbx_matchcase)this.CreateInstance(this, "c__cbx_matchcase");
		#line hidden
		#line hidden
		this.cb_findnext = (c__cb_findnext)this.CreateInstance(this, "c__cb_findnext");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.sle_findwhat = (c__sle_findwhat)this.CreateInstance(this, "c__sle_findwhat");
		#line hidden
		#line hidden
		this.ddlb_searchdirection = (c__ddlb_searchdirection)this.CreateInstance(this, "c__ddlb_searchdirection");
		#line hidden
		#line hidden
		this.cb_dlghelp = (c__cb_dlghelp)this.CreateInstance(this, "c__cb_dlghelp");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_findwhere);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_searchfor);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_findwhere);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_searchdirection);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_wholeword);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_matchcase);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_findnext);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.sle_findwhat);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_searchdirection);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_dlghelp);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_findwhere);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_searchfor);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_findwhere);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_searchdirection);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_wholeword);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_matchcase);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_findnext);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_findwhat);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_searchdirection);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_dlghelp);
		#line hidden
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_PBPowerObj267000348<T0>(Sybase.PowerBuilder.PBPowerObject this__object, ref T0 temp_arg_name_0) where T0: c__n_cst_findattrib
	{
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[1] {
			new Sybase.PowerBuilder.PBArgument(temp_arg_name_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__n_cst_findattrib))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "pfc_findnext", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0 = (T0)__tempArgument4DynamicCall[0].Value;

		return return_value;
	}


	#line 1 "pfc_w_find.st_findwhere"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_findwhere")]
	public class c__st_findwhere : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_findwhere()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.st_searchfor"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_searchfor")]
	public class c__st_searchfor : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_searchfor()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.ddlb_findwhere"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_findwhere")]
	public class c__ddlb_findwhere : c__u_ddlb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_findwhere()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.st_searchdirection"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_searchdirection")]
	public class c__st_searchdirection : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_searchdirection()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.cbx_wholeword"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_wholeword")]
	public class c__cbx_wholeword : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_wholeword()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.cbx_matchcase"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_matchcase")]
	public class c__cbx_matchcase : c__u_cbx
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__cbx_matchcase()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.cb_findnext"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_findnext")]
	public class c__cb_findnext : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_find.cb_findnext.clicked"
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
			#line 42
			((c__pfc_w_find)(this.Parent)).pfc_default();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_findnext()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_find.cb_cancel.clicked"
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
			#line 42
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(((c__pfc_w_find)(this.Parent))));
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


	#line 1 "pfc_w_find.sle_findwhat"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_findwhat")]
	public class c__sle_findwhat : c__u_sle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__sle_findwhat()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.ddlb_searchdirection"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_searchdirection")]
	public class c__ddlb_searchdirection : c__pfc_u_ddlb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__ddlb_searchdirection()
		{
			_init();
		}

	}


	#line 1 "pfc_w_find.cb_dlghelp"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_dlghelp")]
	public class c__cb_dlghelp : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_find.cb_dlghelp.clicked"
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
			Sybase.PowerBuilder.WPF.PBSystemFunctions.ShowHelp(new Sybase.PowerBuilder.PBString("pfcdlg.hlp"), (new Sybase.PowerBuilder.PBHelpCommandValue(Sybase.PowerBuilder.PBHelpCommand.Topic)), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(400)));
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
	}

	public c__pfc_w_find()
	{
		_init();
	}

}
 