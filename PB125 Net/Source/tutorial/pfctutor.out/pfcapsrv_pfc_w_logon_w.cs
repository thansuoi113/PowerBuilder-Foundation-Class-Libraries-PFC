//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_w_logon.srw"
#line hidden
#line 1 "pfc_w_logon"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_w_logon",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\tutorial\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_w_logon")]
public class c__pfc_w_logon : c__w_response
{
	#line hidden
	public c__pfc_w_logon.c__p_logo p_logo = null;
	public c__pfc_w_logon.c__st_help st_help = null;
	public c__pfc_w_logon.c__cb_ok cb_ok = null;
	public c__pfc_w_logon.c__cb_cancel cb_cancel = null;
	public c__pfc_w_logon.c__sle_userid sle_userid = null;
	public c__pfc_w_logon.c__sle_password sle_password = null;
	public c__pfc_w_logon.c__st_2 st_2 = null;
	public c__pfc_w_logon.c__st_3 st_3 = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "inv_logonattrib", null, "pfc_w_logon", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__n_cst_logonattrib inv_logonattrib = (c__n_cst_logonattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_logonattrib));
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_logonattempts", null, "pfc_w_logon", 1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= 1")]
	protected Sybase.PowerBuilder.PBInt ii_logonattempts = new Sybase.PowerBuilder.PBInt(1);

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
		this.p_logo = (c__p_logo)this.CreateInstance(this, "c__p_logo");
		#line hidden
		#line hidden
		this.st_help = (c__st_help)this.CreateInstance(this, "c__st_help");
		#line hidden
		#line hidden
		this.cb_ok = (c__cb_ok)this.CreateInstance(this, "c__cb_ok");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.sle_userid = (c__sle_userid)this.CreateInstance(this, "c__sle_userid");
		#line hidden
		#line hidden
		this.sle_password = (c__sle_password)this.CreateInstance(this, "c__sle_password");
		#line hidden
		#line hidden
		this.st_2 = (c__st_2)this.CreateInstance(this, "c__st_2");
		#line hidden
		#line hidden
		this.st_3 = (c__st_3)this.CreateInstance(this, "c__st_3");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.p_logo);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_help);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_ok);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_cancel);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.sle_userid);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.sle_password);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_2);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_3);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.p_logo);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_help);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_ok);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_userid);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.sle_password);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_3);
		#line hidden
	}

	#line 1 "pfc_w_logon.open"
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
		ib_disableclosequery = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 44
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(c__pfctutor.GetCurrentApplication().message.PowerObjectParm))
		#line hidden
		{
			#line 45
			if ((Sybase.PowerBuilder.PBBoolean)(inv_logonattrib.ClassName() == c__pfctutor.GetCurrentApplication().message.PowerObjectParm.ClassName()))
			#line hidden
			{
				#line 46
				inv_logonattrib = (c__n_cst_logonattrib)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(c__pfctutor.GetCurrentApplication().message.PowerObjectParm))));
				#line hidden
			}
		}
		else
		{
			#line 50
			inv_logonattrib.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
			#line 51
			inv_logonattrib.is_userid = new Sybase.PowerBuilder.PBString("");
			#line hidden
			#line 52
			Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_logonattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_logonattrib)))));
			#line hidden
			#line 53
			return new Sybase.PowerBuilder.PBLong(0);
			#line hidden
		}
		#line 57
		sle_userid.Text = inv_logonattrib.is_userid;
		#line hidden
		#line 60
		sle_password.Text = inv_logonattrib.is_password;
		#line hidden
		#line 63
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_logonattrib.is_logo)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 64
			p_logo.PictureName = inv_logonattrib.is_logo;
			#line hidden
		}
		else
		{
			#line 66
			p_logo.Visible = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 70
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(inv_logonattrib.is_appname) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 71
			inv_logonattrib.is_appname = new Sybase.PowerBuilder.PBString("the application");
			#line hidden
		}
		#line 73
		st_help.Text = (st_help.Text+ inv_logonattrib.is_appname)+ new Sybase.PowerBuilder.PBString(".");
		#line hidden
		#line 76
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_logonattrib)))
		#line hidden
		{
			#line 77
			if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(inv_logonattrib.ii_logonattempts))))))
			#line hidden
			{
				#line 78
				ii_logonattempts = inv_logonattrib.ii_logonattempts;
				#line hidden
			}
		}
		#line 83
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(sle_userid.Text)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 84
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(sle_password.Text)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 85
				cb_ok.SetFocus();
				#line hidden
			}
			else
			{
				#line 87
				sle_password.SetFocus();
				#line hidden
			}
		}
		else
		{
			#line 90
			sle_userid.SetFocus();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "pfc_w_logon.pfc_default"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_default")]
	public override void pfc_default()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(sle_userid.Text) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 49
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_logon_enterid"), inv_logonattrib.is_appname, new Sybase.PowerBuilder.PBString("Please enter a User ID to logon."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Exclamation)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
			#line 51
			sle_userid.SetFocus();
			#line hidden
			#line 52
			return;
			#line hidden
		}
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(sle_password.Text) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 55
			this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_logon_enterpassword"), inv_logonattrib.is_appname, new Sybase.PowerBuilder.PBString("Please enter a password to logon."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Exclamation)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
			#line hidden
			#line 57
			sle_password.SetFocus();
			#line hidden
			#line 58
			return;
			#line hidden
		}
		#line 60
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_logonattrib.ipo_source)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(inv_logonattrib.ipo_source))))
		#line hidden
		{
			#line 61
			this.pfc_cancel();
			#line hidden
			#line 62
			return;
			#line hidden
		}
		#line 68
		ii_logonattempts--;
		#line hidden
		#line 69
		li_rc = (Sybase.PowerBuilder.PBInt)(Sybase_u002e_PowerBuilder_u002e_PBPowerObj1314764694(inv_logonattrib.ipo_source, sle_userid, sle_password));
		#line hidden
		#line 71
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(li_rc)))))
		#line hidden
		{
			#line 72
			this.pfc_cancel();
			#line hidden
			#line 73
			return;
			#line hidden
		}
		#line 74
		else if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 75
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(ii_logonattempts)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 77
				this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_logon_incorrectpassword"), new Sybase.PowerBuilder.PBString("Login"), new Sybase.PowerBuilder.PBString("The password is incorrect."), (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.StopSign)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.Ok)), new Sybase.PowerBuilder.PBInt(1));
				#line hidden
				#line 79
				sle_password.SetFocus();
				#line hidden
				#line 80
				return;
				#line hidden
			}
			else
			{
				#line 83
				inv_logonattrib.ii_rc = new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
				#line 84
				Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_logonattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_logonattrib)))));
				#line hidden
			}
		}
		else
		{
			#line 88
			inv_logonattrib.ii_rc = new Sybase.PowerBuilder.PBInt(1);
			#line hidden
			#line 89
			inv_logonattrib.is_userid = sle_userid.Text;
			#line hidden
			#line 90
			inv_logonattrib.is_password = sle_password.Text;
			#line hidden
			#line 91
			Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_logonattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_logonattrib)))));
			#line hidden
		}
		#line 94
		return;
		#line hidden
	}

	#line 1 "pfc_w_logon.pfc_cancel"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cancel")]
	public override void pfc_cancel()
	{
		#line hidden
		#line 1
		base.pfc_cancel();
		#line hidden
		#line 44
		inv_logonattrib.ii_rc = new Sybase.PowerBuilder.PBInt(0);
		#line hidden
		#line 46
		inv_logonattrib.is_userid = new Sybase.PowerBuilder.PBString("");
		#line hidden
		#line 47
		Sybase.PowerBuilder.WPF.PBSystemFunctions.CloseWithReturn((Sybase.PowerBuilder.WPF.PBWindow)(this), (Sybase.PowerBuilder.PBPowerObject)(((c__n_cst_logonattrib)(Sybase.PowerBuilder.PBSystemFunctions.PBClone(inv_logonattrib)))));
		#line hidden
	}

	#line 1 "pfc_w_logon.close"
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
		if ((Sybase.PowerBuilder.PBBoolean)(inv_logonattrib.ii_rc == new Sybase.PowerBuilder.PBInt(-99)))
		#line hidden
		{
			#line 42
			this.pfc_cancel();
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	Sybase.PowerBuilder.PBAny Sybase_u002e_PowerBuilder_u002e_PBPowerObj1314764694(Sybase.PowerBuilder.PBPowerObject this__object, Sybase.PowerBuilder.WPF.PBSingleLineEdit temp_arg_name_0, Sybase.PowerBuilder.WPF.PBSingleLineEdit temp_arg_name_1)
	{
		Sybase.PowerBuilder.PBString temp_var_0 = temp_arg_name_0.Text;
		Sybase.PowerBuilder.PBString temp_var_1 = temp_arg_name_1.Text;
		Sybase.PowerBuilder.PBArgument[] __tempArgument4DynamicCall = new Sybase.PowerBuilder.PBArgument[2] {
			new Sybase.PowerBuilder.PBArgument(temp_var_0, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(Sybase.PowerBuilder.PBString)),
			new Sybase.PowerBuilder.PBArgument(temp_var_1, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(Sybase.PowerBuilder.PBString))
			};
		Sybase.PowerBuilder.PBAny return_value = Sybase.PowerBuilder.PBMethod.InvokeDynamic(this__object, "pfc_logon", ref __tempArgument4DynamicCall);

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_var_0 = (Sybase.PowerBuilder.PBString)__tempArgument4DynamicCall[0].Value;

		if (__tempArgument4DynamicCall[1].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_var_1 = (Sybase.PowerBuilder.PBString)__tempArgument4DynamicCall[1].Value;

		if (__tempArgument4DynamicCall[0].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_0.Text = (Sybase.PowerBuilder.PBString)temp_var_0;
		if (__tempArgument4DynamicCall[1].Style == Sybase.PowerBuilder.ParameterStyle.ByRef)
			temp_arg_name_1.Text = (Sybase.PowerBuilder.PBString)temp_var_1;
		return return_value;
	}


	#line 1 "pfc_w_logon.p_logo"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="p_logo")]
	public class c__p_logo : c__u_p
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__p_logo()
		{
			_init();
		}

	}


	#line 1 "pfc_w_logon.st_help"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_help")]
	public class c__st_help : c__u_st
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_help()
		{
			_init();
		}

	}


	#line 1 "pfc_w_logon.cb_ok"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_ok")]
	public class c__cb_ok : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_logon.cb_ok.clicked"
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
			((c__pfc_w_logon)(this.Parent)).pfc_default();
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


	#line 1 "pfc_w_logon.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : c__u_cb
	{
		#line hidden

		#line 1 "pfc_w_logon.cb_cancel.clicked"
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
			((c__pfc_w_logon)(this.Parent)).pfc_cancel();
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


	#line 1 "pfc_w_logon.sle_userid"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_userid")]
	public class c__sle_userid : c__u_sle
	{
		#line hidden

		#line 1 "pfc_w_logon.sle_userid.constructor"
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
			this.ib_autoselect = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__sle_userid()
		{
			_init();
		}

	}


	#line 1 "pfc_w_logon.sle_password"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="sle_password")]
	public class c__sle_password : c__u_sle
	{
		#line hidden

		#line 1 "pfc_w_logon.sle_password.constructor"
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
			this.ib_autoselect = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__sle_password()
		{
			_init();
		}

	}


	#line 1 "pfc_w_logon.st_2"
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


	#line 1 "pfc_w_logon.st_3"
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


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.CloseEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.close);
	}

	public c__pfc_w_logon()
	{
		_init();
	}

}
 