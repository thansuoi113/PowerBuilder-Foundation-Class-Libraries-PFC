//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfcmain.pbl\\pfcmain.pblx\\pfc_u_oc.sru"
#line hidden
#line 1 "pfc_u_oc"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_oc",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\tutorial\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_oc")]
public class c__pfc_u_oc : Sybase.PowerBuilder.WPF.PBOleControl
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_rmbmenu", null, "pfc_u_oc", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= true")]
	protected Sybase.PowerBuilder.PBBoolean ib_rmbmenu = new Sybase.PowerBuilder.PBBoolean(true);

	[Sybase.PowerBuilder.PBEventAttribute("pfc_prermbmenu")]
	[Sybase.PowerBuilder.PBNoImplementAttribute]
	public virtual void pfc_prermbmenu<T0>(ref T0 am_oc) where T0 : c__m_oc
	{
	}

	#line 1 "pfc_u_oc.pfc_cut"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_cut")]
	public virtual Sybase.PowerBuilder.PBInt pfc_cut()
	{
		#line hidden
		#line 43
		return this.Cut();
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_copy"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_copy")]
	public virtual Sybase.PowerBuilder.PBInt pfc_copy()
	{
		#line hidden
		#line 43
		return this.Copy();
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_paste"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_paste")]
	public virtual Sybase.PowerBuilder.PBInt pfc_paste()
	{
		#line hidden
		#line 43
		return this.Paste();
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_clear"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_clear")]
	public virtual Sybase.PowerBuilder.PBInt pfc_clear()
	{
		#line hidden
		#line 43
		return this.Clear();
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_pastespecial"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_pastespecial")]
	public virtual Sybase.PowerBuilder.PBInt pfc_pastespecial()
	{
		#line hidden
		#line 45
		return this.PasteSpecial();
		#line hidden
	}

	#line 1 "pfc_u_oc.rbuttonup"
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

	#line 1 "pfc_u_oc.contextmenu"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("contextmenu")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_contextmenu)]
	public virtual Sybase.PowerBuilder.PBLong contextmenu(Sybase.PowerBuilder.PBInt xpos, Sybase.PowerBuilder.PBInt ypos)
	{
		#line hidden
		Sybase.PowerBuilder.PBBoolean lb_frame = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBString ls_classdisplayname = Sybase.PowerBuilder.PBString.DefaultValue;
		c__m_oc lm_oc = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_frame = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_sheet = null;
		Sybase.PowerBuilder.WPF.PBWindow lw_childparent = null;
		#line 37
		if ((Sybase.PowerBuilder.PBBoolean)(!(ib_rmbmenu)| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len((this.ObjectData).ToPBBlob(-1)) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 38
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 42
		this.of_getparentwindow_1_232646770(ref lw_parent);
		#line hidden
		#line 43
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_parent)))
		#line hidden
		{
			#line 45
			lw_frame = lw_parent;
			#line hidden
			#line 46
			while ( Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_frame)) )
			#line hidden
			{
					#line 47
					if ((Sybase.PowerBuilder.PBBoolean)((lw_frame.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Mdi)))| (lw_frame.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.MdiHelp)))))
					#line hidden
					{
						#line 48
						lb_frame = new Sybase.PowerBuilder.PBBoolean(true);
						#line hidden
						#line 49
						break;
						#line hidden
					}
					else
					{
						#line 51
						lw_frame = lw_frame.ParentWindow();
						#line hidden
					}
			}

			#line 55
			if (lb_frame)
			#line hidden
			{
				#line 58
				if ((Sybase.PowerBuilder.PBBoolean)(lw_parent.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Child))))
				#line hidden
				{
					#line 59
					lw_parent = lw_frame;
					#line hidden
				}
				else
				{
					#line 61
					lw_sheet = lw_frame.GetFirstSheet();
					#line hidden
					#line 62
					if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))
					#line hidden
					{
						do
						{
								#line 65
								if ((Sybase.PowerBuilder.PBBoolean)(lw_sheet == lw_parent))
								#line hidden
								{
									#line 66
									lw_parent = lw_frame;
									#line hidden
									#line 67
									break;
									#line hidden
								}
								#line 69
								lw_sheet = lw_frame.GetNextSheet(lw_sheet);
								#line hidden
						}
						#line 70
						while ( !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((Sybase.PowerBuilder.WPF.PBWindow)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(lw_sheet)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_sheet)))));
						#line hidden
					}
				}
			}
			else
			{
				#line 76
				if ((Sybase.PowerBuilder.PBBoolean)(lw_parent.WindowType == (new Sybase.PowerBuilder.PBWindowTypeValue(Sybase.PowerBuilder.PBWindowType.Child))))
				#line hidden
				{
					#line 77
					lw_childparent = lw_parent.ParentWindow();
					#line hidden
					#line 78
					if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lw_childparent)))
					#line hidden
					{
						#line 79
						lw_parent = lw_childparent;
						#line hidden
					}
				}
			}
		}
		else
		{
			#line 84
			return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
			#line hidden
		}
		#line 88
		lm_oc = (c__m_oc)this.CreateInstance(this, typeof(c__m_oc));
		#line hidden
		#line 89
		lm_oc.of_setparent((Sybase.PowerBuilder.WPF.PBOleControl)(this));
		#line hidden
		#line 92
		ls_classdisplayname = this.ClassShortName;
		#line hidden
		#line 93
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_classdisplayname) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 94
			ls_classdisplayname = this.ClassLongName;
			#line hidden
		}
		#line 96
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_classdisplayname)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 97
			lm_oc.m_object.m_edit.Text = (lm_oc.m_object.m_edit.Text+ new Sybase.PowerBuilder.PBString(" "))+ ls_classdisplayname;
			#line hidden
			#line 98
			lm_oc.m_object.m_open.Text = (lm_oc.m_object.m_open.Text+ new Sybase.PowerBuilder.PBString(" "))+ ls_classdisplayname;
			#line hidden
		}
		#line 102
		this.pfc_prermbmenu(ref lm_oc);
		#line hidden
		#line 104
		lm_oc.m_object.PopMenu((Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(lw_parent.PointerX())+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))), (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(lw_parent.PointerY())+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10))));
		#line hidden
		#line 105
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(lm_oc);
		#line hidden
		#line 107
		return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_updatelinks"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_updatelinks")]
	public virtual Sybase.PowerBuilder.PBInt pfc_updatelinks()
	{
		#line hidden
		#line 42
		return this.UpdateLinksDialog();
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_editobject"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_editobject")]
	public virtual Sybase.PowerBuilder.PBInt pfc_editobject()
	{
		#line hidden
		#line 49
		return this.Activate((new Sybase.PowerBuilder.PBOMActivateTypeValue(Sybase.PowerBuilder.PBOMActivateType.InPlace)));
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_openobject"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_openobject")]
	public virtual Sybase.PowerBuilder.PBInt pfc_openobject()
	{
		#line hidden
		#line 49
		return this.Activate((new Sybase.PowerBuilder.PBOMActivateTypeValue(Sybase.PowerBuilder.PBOMActivateType.OffSite)));
		#line hidden
	}

	#line 1 "pfc_u_oc.pfc_insertobject"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_insertobject")]
	public virtual Sybase.PowerBuilder.PBInt pfc_insertobject()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 47
		li_rc = this.InsertObject();
		#line hidden
		#line 48
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(0)))
		#line hidden
		{
			#line 49
			this.Activate((new Sybase.PowerBuilder.PBOMActivateTypeValue(Sybase.PowerBuilder.PBOMActivateType.InPlace)));
			#line hidden
		}
		#line 52
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_u_oc.of_getparentwindow(IRCwindow.)"
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

	#line 1 "pfc_u_oc.of_messagebox(ISSSCicon.Cbutton.I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_messagebox", new string[]{"string", "string", "string", "icon", "button", "integer"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_messagebox(Sybase.PowerBuilder.PBString as_id, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBString as_text, Sybase.PowerBuilder.PBIconValue ae_icon, Sybase.PowerBuilder.PBButtonValue ae_button, Sybase.PowerBuilder.PBInt ai_default)
	{
		#line hidden
		#line 53
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(as_title, as_text, ae_icon, ae_button, ai_default);
		#line hidden
	}

	#line 1 "pfc_u_oc.getfocus"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("getfocus")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnsetfocus)]
	public override Sybase.PowerBuilder.PBLong getfocus()
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		if (c__pfctutor.GetCurrentApplication().gnv_app.of_getmicrohelp())
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
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(lw_parent, "pfc_controlgotfocus", new Sybase.PowerBuilder.PBArgument[1] {new Sybase.PowerBuilder.PBArgument(this, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__pfc_u_oc))}, 0);
				#line hidden
			}
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.GetFocusEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.getfocus);

		OnInitialUpdate();
	}

	public c__pfc_u_oc()
	{
		_init();
	}

}
 