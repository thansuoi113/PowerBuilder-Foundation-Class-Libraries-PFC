//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx\\pfc_u_sle.sru"
#line hidden
#line 1 "pfc_u_sle"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_sle",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_sle")]
public class c__pfc_u_sle : Sybase.PowerBuilder.WPF.PBSingleLineEdit
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_autoselect", null, "pfc_u_sle", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_autoselect = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_rmbmenu", null, "pfc_u_sle", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= true")]
	protected Sybase.PowerBuilder.PBBoolean ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(true);

	[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
	[Sybase.PowerBuilder.PBNoImplementAttribute]
	public virtual void pfc_prermbmenu<T0>(ref T0 am_edit) where T0 : c__m_edit
	{
	}

	#line 1 "pfc_u_sle.pfc_cut"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cut")]
	public virtual Sybase.PowerBuilder.PBInt pfc_cut()
	{
		#line hidden
		#line 43
		return (Sybase.PowerBuilder.PBInt)(this.Cut());
		#line hidden
	}

	#line 1 "pfc_u_sle.pfc_copy"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_copy")]
	public virtual Sybase.PowerBuilder.PBInt pfc_copy()
	{
		#line hidden
		#line 43
		return (Sybase.PowerBuilder.PBInt)(this.Copy());
		#line hidden
	}

	#line 1 "pfc_u_sle.pfc_paste"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_paste")]
	public virtual Sybase.PowerBuilder.PBInt pfc_paste()
	{
		#line hidden
		#line 43
		return (Sybase.PowerBuilder.PBInt)(this.Paste());
		#line hidden
	}

	#line 1 "pfc_u_sle.pfc_undo"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_undo")]
	public virtual Sybase.PowerBuilder.PBInt pfc_undo()
	{
		#line hidden
		#line 45
		if (this.CanUndo())
		#line hidden
		{
			#line 46
			return this.Undo();
			#line hidden
		}
		#line 49
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_u_sle.pfc_clear"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_clear")]
	public virtual Sybase.PowerBuilder.PBInt pfc_clear()
	{
		#line hidden
		#line 43
		return (Sybase.PowerBuilder.PBInt)(this.Clear());
		#line hidden
	}

	#line 1 "pfc_u_sle.pfc_selectall"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_selectall")]
	public virtual Sybase.PowerBuilder.PBInt pfc_selectall()
	{
		#line hidden
		#line 44
		return (Sybase.PowerBuilder.PBInt)(this.SelectText((Sybase.PowerBuilder.PBULong)(new Sybase.PowerBuilder.PBInt(1)), (Sybase.PowerBuilder.PBULong)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(this.Text))));
		#line hidden
	}

	#line 1 "pfc_u_sle.rbuttonup"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("rbuttonup")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_rbuttonup)]
	public virtual Sybase.PowerBuilder.PBLong rbuttonup(Sybase.PowerBuilder.PBULong flags, Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
	{
		#line hidden
		#line 29
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
	}

	#line 1 "pfc_u_sle.contextmenu"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("contextmenu")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_contextmenu)]
	public virtual Sybase.PowerBuilder.PBLong contextmenu(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
	{
		#line hidden
		Sybase.PowerBuilder.PBBoolean lb_frame = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		c__m_edit lm_edit = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_frame = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_childparent = null;
		#line 36
		if (!(ib_rmbmenu))
		#line hidden
		{
			#line 37
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 41
		this.of_getparentwindow_1_232646770(ref lw_parent);
		#line hidden
		#line 42
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_parent)))
		#line hidden
		{
			#line 44
			lw_frame = lw_parent;
			#line hidden
			#line 45
			while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_frame)) )
			#line hidden
			{
					#line 46
					if ((Sybase.PowerBuilder.PBBoolean)((lw_frame.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Mdi)))| (lw_frame.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.MdiHelp)))))
					#line hidden
					{
						#line 47
						lb_frame = new Sybase.PowerBuilder.PBBoolean(true);
						#line hidden
						#line 48
						break;
						#line hidden
					}
					else
					{
						#line 50
						lw_frame = lw_frame.ParentWindow();
						#line hidden
					}
			}

			#line 54
			if (lb_frame)
			#line hidden
			{
				#line 57
				if ((Sybase.PowerBuilder.PBBoolean)(lw_parent.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Child))))
				#line hidden
				{
					#line 58
					lw_parent = lw_frame;
					#line hidden
				}
				else
				{
					#line 60
					lw_sheet = lw_frame.GetFirstSheet();
					#line hidden
					#line 61
					if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
					#line hidden
					{
						do
						{
								#line 64
								if ((Sybase.PowerBuilder.PBBoolean)(lw_sheet == lw_parent))
								#line hidden
								{
									#line 65
									lw_parent = lw_frame;
									#line hidden
									#line 66
									break;
									#line hidden
								}
								#line 68
								lw_sheet = lw_frame.GetNextSheet(lw_sheet);
								#line hidden
						}
						#line 69
						while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
						#line hidden
					}
				}
			}
			else
			{
				#line 75
				if ((Sybase.PowerBuilder.PBBoolean)(lw_parent.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Child))))
				#line hidden
				{
					#line 76
					lw_childparent = lw_parent.ParentWindow();
					#line hidden
					#line 77
					if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_childparent)))
					#line hidden
					{
						#line 78
						lw_parent = lw_childparent;
						#line hidden
					}
				}
			}
		}
		else
		{
			#line 83
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 87
		lm_edit = (c__m_edit)this.CreateInstance(this, typeof(c__m_edit));
		#line hidden
		#line 88
		lm_edit.of_setparent((Sybase.PowerBuilder.WPF.PBDragObject)(this));
		#line hidden
		#line 91
		lm_edit.m_edititem.m_copy.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 92
		lm_edit.m_edititem.m_cut.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 93
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(this.SelectedText())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 94
			lm_edit.m_edititem.m_copy.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 95
			if (!(this.DisplayOnly))
			#line hidden
			{
				#line 96
				lm_edit.m_edititem.m_cut.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
				#line hidden
			}
		}
		#line 100
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Clipboard())> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& !(this.DisplayOnly)))
		#line hidden
		{
			#line 101
			lm_edit.m_edititem.m_paste.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		else
		{
			#line 103
			lm_edit.m_edititem.m_paste.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 106
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(this.Text)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 107
			lm_edit.m_edititem.m_selectall.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		else
		{
			#line 109
			lm_edit.m_edititem.m_selectall.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 112
		this.pfc_prermbmenu(ref lm_edit);
		#line hidden
		#line 114
		lm_edit.m_edititem.PopMenu((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(lw_parent.PointerX())+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))), (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(lw_parent.PointerY())+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10))));
		#line hidden
		#line 115
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(lm_edit);
		#line hidden
		#line 117
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
	}

	#line 1 "pfc_u_sle.of_getparentwindow(IRCwindow.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getparentwindow", new string[]{"ref window"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getparentwindow_1_232646770<T0>(ref T0 aw_parent) where T0 : Sybase.PowerBuilder.WPF.PBWindow
	{
		#line hidden
		Sybase.PowerBuilder.PBPowerObject lpo_parent = null;
		#line 50
		lpo_parent = this.GetParent();
		#line hidden
		#line 53
		while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(lpo_parent) )
		#line hidden
		{
				#line 54
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.PBPowerObject.TypeOf(lpo_parent) != (new Sybase.PowerBuilder.PBObjectValue(Sybase.PowerBuilder.PBObject.Window))))
				#line hidden
				{
					#line 55
					lpo_parent = lpo_parent.GetParent();
					#line hidden
				}
				else
				{
					#line 57
					break;
					#line hidden
				}
		}

		#line 61
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lpo_parent)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid(lpo_parent))))
		#line hidden
		{
			#line 62
			aw_parent = null;
			#line hidden
			#line 63
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 66
		aw_parent = (T0)(Sybase.PowerBuilder.WPF.PBWindow)(((Sybase.PowerBuilder.PBPowerObject)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lpo_parent))));
		#line hidden
		#line 67
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_sle.of_messagebox(ISSSCicon.Cbutton.I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_messagebox", new string[]{"string", "string", "string", "icon", "button", "integer"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_messagebox(Sybase.PowerBuilder.PBString as_id, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBString as_text, Sybase.PowerBuilder.PBIconValue ae_icon, Sybase.PowerBuilder.PBButtonValue ae_button, Sybase.PowerBuilder.PBInt ai_default)
	{
		#line hidden
		#line 53
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(as_title, as_text, ae_icon, ae_button, ai_default);
		#line hidden
	}

	#line 1 "pfc_u_sle.getfocus"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("getfocus")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_ensetfocus)]
	public override Sybase.PowerBuilder.PBLong getfocus()
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		if (c__pfcexamp.GetCurrentApplication().gnv_app.of_getmicrohelp())
		#line hidden
		{
			#line 48
			this.of_getparentwindow_1_232646770(ref lw_parent);
			#line hidden
			#line 49
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_parent)))
			#line hidden
			{
				#line 50
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(lw_parent, "pfc_controlgotfocus", new Sybase.PowerBuilder.PBArgument[1] {new Sybase.PowerBuilder.PBArgument(this, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__pfc_u_sle))}, 0);
				#line hidden
			}
		}
		#line 55
		if (ib_autoselect)
		#line hidden
		{
			#line 56
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.PostMethod(this, "pfc_selectall", new Sybase.PowerBuilder.PBArgument[0]{					});
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.GetFocusEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.getfocus);

		OnInitialUpdate();
	}

	public c__pfc_u_sle()
	{
		_init();
	}

}
 