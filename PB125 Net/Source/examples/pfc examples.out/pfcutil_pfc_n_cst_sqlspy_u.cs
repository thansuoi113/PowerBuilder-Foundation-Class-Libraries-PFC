//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx\\pfc_n_cst_sqlspy.sru"
#line hidden
#line 1 "pfc_n_cst_sqlspy"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_sqlspy",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_sqlspy")]
public class c__pfc_n_cst_sqlspy : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_sqlspy", null, "pfc_n_cst_sqlspy", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_sqlspy iw_sqlspy = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "iw_sqlspyinspect", null, "pfc_n_cst_sqlspy", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected c__w_sqlspyinspect iw_sqlspyinspect = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_allowinspect", null, "pfc_n_cst_sqlspy", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_allowinspect = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_batchmode", null, "pfc_n_cst_sqlspy", true, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= True")]
	protected Sybase.PowerBuilder.PBBoolean ib_batchmode = new Sybase.PowerBuilder.PBBoolean(true);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_alwaysontop", null, "pfc_n_cst_sqlspy", false, typeof(Sybase.PowerBuilder.PBBoolean), Sybase.PowerBuilder.PBModifier.Protected, "= False")]
	protected Sybase.PowerBuilder.PBBoolean ib_alwaysontop = new Sybase.PowerBuilder.PBBoolean(false);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_history", null, "pfc_n_cst_sqlspy", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= ''")]
	protected Sybase.PowerBuilder.PBString is_history = new Sybase.PowerBuilder.PBString("");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_currentheading", null, "pfc_n_cst_sqlspy", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= ''")]
	protected Sybase.PowerBuilder.PBString is_currentheading = new Sybase.PowerBuilder.PBString("");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_currentsyntax", null, "pfc_n_cst_sqlspy", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= ''")]
	protected Sybase.PowerBuilder.PBString is_currentsyntax = new Sybase.PowerBuilder.PBString("");
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_logfile", null, "pfc_n_cst_sqlspy", "", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= ''")]
	protected Sybase.PowerBuilder.PBString is_logfile = new Sybase.PowerBuilder.PBString("");

	#line 1 "pfc_n_cst_sqlspy.of_sqlsyntax(ISRSB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sqlsyntax", new string[]{"string", "ref string", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sqlsyntax(Sybase.PowerBuilder.PBString as_heading, ref Sybase.PowerBuilder.PBString as_syntax, Sybase.PowerBuilder.PBBoolean ab_oktopause)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_null = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 58
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_heading))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_syntax)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_oktopause))))))
		#line hidden
		{
			#line 60
			li_null.SetNull();
			#line hidden
			#line 61
			return li_null;
			#line hidden
		}
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)(ab_oktopause& (ib_batchmode == new Sybase.PowerBuilder.PBBoolean(false))))
		#line hidden
		{
			#line 71
			this.of_setcurrentheading(as_heading);
			#line hidden
			#line 72
			this.of_setcurrentsyntax(as_syntax);
			#line hidden
			#line 75
			li_rc = this.of_opensqlspyinspect();
			#line hidden
			#line 77
			if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(0)))
			#line hidden
			{
				#line 79
				as_heading = this.of_getcurrentheading();
				#line hidden
				#line 80
				as_syntax = this.of_getcurrentsyntax();
				#line hidden
			}
			#line 81
			else if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 83
				as_heading = new Sybase.PowerBuilder.PBString("");
				#line hidden
				#line 84
				as_syntax = new Sybase.PowerBuilder.PBString("");
				#line hidden
			}
		}
		else
		{
			#line 89
			li_rc = new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 93
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(0)))
		#line hidden
		{
			#line 94
			this.of_addtohistory(as_heading, as_syntax);
			#line hidden
		}
		#line 97
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_sqlsyntax(ISS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sqlsyntax", new string[]{"string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sqlsyntax(Sybase.PowerBuilder.PBString as_heading, Sybase.PowerBuilder.PBString as_syntax)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_null = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_heading))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_syntax))))))
		#line hidden
		{
			#line 58
			li_null.SetNull();
			#line hidden
			#line 59
			return li_null;
			#line hidden
		}
		#line 64
		li_rc = this.of_sqlsyntax(as_heading, ref as_syntax, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 66
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setcurrentsyntax(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setcurrentsyntax", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setcurrentsyntax(Sybase.PowerBuilder.PBString as_currentsyntax)
	{
		#line hidden
		#line 46
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_currentsyntax)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		is_currentsyntax = as_currentsyntax;
		#line hidden
		#line 53
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getallowinspect(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getallowinspect", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getallowinspect()
	{
		#line hidden
		#line 46
		return ib_allowinspect;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_addtohistory(ISS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_addtohistory", new string[]{"string", "string"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_addtohistory(Sybase.PowerBuilder.PBString as_heading, Sybase.PowerBuilder.PBString as_syntax)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_newentry = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_spacing = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_rc = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBDateTime ldm_current = Sybase.PowerBuilder.PBDateTime.DefaultValue;
		Sybase.PowerBuilder.PBInt li_null = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 55
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_heading))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_syntax))))))
		#line hidden
		{
			#line 57
			li_null.SetNull();
			#line hidden
			#line 58
			return li_null;
			#line hidden
		}
		#line 62
		ldm_current = Sybase.PowerBuilder.WPF.PBSystemFunctions.DateTime(Sybase.PowerBuilder.WPF.PBSystemFunctions.Today(), Sybase.PowerBuilder.WPF.PBSystemFunctions.Now());
		#line hidden
		#line 63
		as_heading = (as_heading+ new Sybase.PowerBuilder.PBString("    TimeStamp: "))+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ldm_current))), new Sybase.PowerBuilder.PBString("dd/mm/yy hh:mm:ss:ff"));
		#line hidden
		#line 66
		as_heading = (new Sybase.PowerBuilder.PBString("/*** ")+ as_heading)+ new Sybase.PowerBuilder.PBString(" ***/");
		#line hidden
		#line 69
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(is_history)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 70
			ls_spacing = new Sybase.PowerBuilder.PBString("\r\n\r\n");
			#line hidden
		}
		#line 75
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_heading)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_syntax)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 76
			ls_newentry = ((ls_spacing+ as_heading)+ new Sybase.PowerBuilder.PBString("\r\n"))+ as_syntax;
			#line hidden
		}
		#line 77
		else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_heading)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 78
			ls_newentry = ls_spacing+ as_heading;
			#line hidden
		}
		else
		{
			#line 80
			ls_newentry = ls_spacing+ as_syntax;
			#line hidden
		}
		#line 84
		is_history = is_history+ ls_newentry;
		#line hidden
		#line 88
		is_history = this.of_preventhistoryoverflow(is_history, ls_newentry);
		#line hidden
		#line 91
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
		#line hidden
		{
			#line 92
			ll_rc = (Sybase.PowerBuilder.PBLong)(iw_sqlspy.of_updatehistory());
			#line hidden
		}
		#line 96
		this.of_addtologfile(ls_newentry);
		#line hidden
		#line 98
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_clearhistory(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_clearhistory", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_clearhistory()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		#line 49
		is_history = new Sybase.PowerBuilder.PBString("");
		#line hidden
		#line 52
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
		#line hidden
		{
			#line 53
			li_rc = iw_sqlspy.of_updatehistory();
			#line hidden
		}
		#line 56
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getbatchmode(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getbatchmode", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getbatchmode()
	{
		#line hidden
		#line 46
		return ib_batchmode;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getcurrentheading(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getcurrentheading", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getcurrentheading()
	{
		#line hidden
		#line 46
		return is_currentheading;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getcurrentsyntax(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getcurrentsyntax", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getcurrentsyntax()
	{
		#line hidden
		#line 46
		return is_currentsyntax;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setallowinspect(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setallowinspect", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setallowinspect(Sybase.PowerBuilder.PBBoolean ab_allowinspect)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_allowinspect)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		ib_allowinspect = ab_allowinspect;
		#line hidden
		#line 56
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setbatchmode(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setbatchmode", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setbatchmode(Sybase.PowerBuilder.PBBoolean ab_batchmode)
	{
		#line hidden
		#line 48
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_batchmode)))))
		#line hidden
		{
			#line 49
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 53
		ib_batchmode = ab_batchmode;
		#line hidden
		#line 56
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
		#line hidden
		{
			#line 57
			iw_sqlspy.of_updatebatchmode();
			#line hidden
		}
		#line 60
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setcurrentheading(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setcurrentheading", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setcurrentheading(Sybase.PowerBuilder.PBString as_currentheading)
	{
		#line hidden
		#line 46
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_currentheading)))))
		#line hidden
		{
			#line 47
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		is_currentheading = as_currentheading;
		#line hidden
		#line 53
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_sqlsyntax(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sqlsyntax", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sqlsyntax(Sybase.PowerBuilder.PBString as_heading)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_empty_sqlsyntax = new Sybase.PowerBuilder.PBString("");
		Sybase.PowerBuilder.PBInt li_null = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 56
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_heading)))))
		#line hidden
		{
			#line 58
			li_null.SetNull();
			#line hidden
			#line 59
			return li_null;
			#line hidden
		}
		#line 65
		li_rc = this.of_sqlsyntax(as_heading, ref ls_empty_sqlsyntax, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 67
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setlogfile(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setlogfile", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setlogfile(Sybase.PowerBuilder.PBString as_logfile)
	{
		#line hidden
		#line 49
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_logfile)))))
		#line hidden
		{
			#line 50
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 54
		is_logfile = as_logfile;
		#line hidden
		#line 56
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_addtologfile(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_addtologfile", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_addtologfile(Sybase.PowerBuilder.PBString as_newentry)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_filenumber = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 50
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_newentry)))))
		#line hidden
		{
			#line 51
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(is_logfile) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_newentry) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 58
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 61
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(is_logfile))
		#line hidden
		{
		}
		#line 66
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 67
		li_filenumber = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(is_logfile, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.StreamMode)), (new Sybase.PowerBuilder.PBFileAccessValue(Sybase.PowerBuilder.PBFileAccess.Write)), (new Sybase.PowerBuilder.PBFileLockValue(Sybase.PowerBuilder.PBFileLock.LockWrite)), (new Sybase.PowerBuilder.PBWriteModeValue(Sybase.PowerBuilder.PBWriteMode.Append)));
		#line hidden
		#line 68
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_filenumber)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 69
			Sybase.PowerBuilder.WPF.PBSystemFunctions.FileWrite(li_filenumber, as_newentry);
			#line hidden
			#line 70
			Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_filenumber);
			#line hidden
		}
		#line 74
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_savehistorytofile(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_savehistorytofile", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_savehistorytofile()
	{
		#line hidden
		Sybase.PowerBuilder.PBString title = new Sybase.PowerBuilder.PBString("Save SQLSpy File");
		Sybase.PowerBuilder.PBString ls_path_filename = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_filename = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_filenumber = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 54
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 57
		li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.GetFileSaveName(title, ref ls_path_filename, ref ls_filename, new Sybase.PowerBuilder.PBString("SQL"), new Sybase.PowerBuilder.PBString("SQL Files (*.SQL), *.SQL"));
		#line hidden
		#line 60
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 62
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(ls_path_filename))
			#line hidden
			{
				#line 66
				if ((Sybase.PowerBuilder.PBBoolean)(this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_sqlspy_replacefile"), title, new Sybase.PowerBuilder.PBString("Replace existing file ")+ ls_path_filename, (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Question)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNo)), new Sybase.PowerBuilder.PBInt(1)) == new Sybase.PowerBuilder.PBInt(2)))
				#line hidden
				{
					#line 68
					return new Sybase.PowerBuilder.PBInt(1);
					#line hidden
				}
			}
			#line 73
			Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
			#line hidden
			#line 74
			li_filenumber = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(ls_path_filename, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.StreamMode)), (new Sybase.PowerBuilder.PBFileAccessValue(Sybase.PowerBuilder.PBFileAccess.Write)), (new Sybase.PowerBuilder.PBFileLockValue(Sybase.PowerBuilder.PBFileLock.LockWrite)), (new Sybase.PowerBuilder.PBWriteModeValue(Sybase.PowerBuilder.PBWriteMode.Replace)));
			#line hidden
			#line 75
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_filenumber)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 76
				Sybase.PowerBuilder.WPF.PBSystemFunctions.FileWrite(li_filenumber, is_history);
				#line hidden
				#line 77
				Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_filenumber);
				#line hidden
			}
		}
		#line 82
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_printhistory(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_printhistory", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_printhistory()
	{
		#line hidden
		c__n_ds lds_print = null;
		#line 47
		lds_print = (c__n_ds)this.CreateInstance(typeof(c__n_ds), 0);
		#line hidden
		#line 49
		lds_print.DataObject = new Sybase.PowerBuilder.PBString("d_sqlspyprint");
		#line hidden
		#line 51
		if ((Sybase.PowerBuilder.PBBoolean)(lds_print.InsertRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
		#line hidden
		{
			#line 52
			if ((Sybase.PowerBuilder.PBBoolean)(lds_print.SetItem((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)), new Sybase.PowerBuilder.PBString("text"), is_history) == new Sybase.PowerBuilder.PBInt(1)))
			#line hidden
			{
				#line 53
				if ((Sybase.PowerBuilder.PBBoolean)(lds_print.Print() == new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 55
					Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(lds_print);
					#line hidden
					#line 56
					return new Sybase.PowerBuilder.PBInt(1);
					#line hidden
				}
			}
		}
		#line 62
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(lds_print);
		#line hidden
		#line 63
		return new Sybase.PowerBuilder.PBInt(-1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_preventhistoryoverflow(SSS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_preventhistoryoverflow", new string[]{"string", "string"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_preventhistoryoverflow(Sybase.PowerBuilder.PBString as_history, Sybase.PowerBuilder.PBString al_newentry)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong test_length = (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(32700));
		Sybase.PowerBuilder.PBLong ll_pos = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_startposition = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_historylength = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_null = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 56
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_history))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_newentry))))))
		#line hidden
		{
			#line 58
			ls_null.SetNull();
			#line hidden
			#line 59
			return ls_null;
			#line hidden
		}
		#line 65
		ll_startposition = Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(al_newentry);
		#line hidden
		#line 68
		ll_historylength = Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_history);
		#line hidden
		#line 70
		if ((Sybase.PowerBuilder.PBBoolean)(ll_historylength> test_length))
		#line hidden
		{
			#line 71
			ll_pos = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(as_history, new Sybase.PowerBuilder.PBString("/***"), ll_startposition);
			#line hidden
			#line 72
			if ((Sybase.PowerBuilder.PBBoolean)(ll_pos> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 73
				as_history = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(as_history, ll_pos, ll_historylength);
				#line hidden
			}
		}
		#line 77
		return as_history;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_opensqlspy(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_opensqlspy", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_opensqlspy(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 55
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 56
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		if (ab_switch)
		#line hidden
		{
			#line 60
			li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.Open(ref iw_sqlspy);
			#line hidden
			#line 61
			return li_rc;
			#line hidden
		}
		else
		{
			#line 63
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
			#line hidden
			{
				#line 64
				return Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(iw_sqlspy));
				#line hidden
			}
		}
		#line 68
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_gethistory(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_gethistory", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_gethistory()
	{
		#line hidden
		#line 47
		return is_history;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_opensqlspyinspect(I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_opensqlspyinspect", new string[]{}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_opensqlspyinspect()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_testrc = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 55
		if (ib_alwaysontop)
		#line hidden
		{
			#line 56
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
			#line hidden
			{
				#line 57
				li_testrc = iw_sqlspy.of_setalwaysontop(new Sybase.PowerBuilder.PBBoolean(false));
				#line hidden
			}
		}
		#line 62
		Sybase.PowerBuilder.WPF.PBSystemFunctions.Open(ref iw_sqlspyinspect);
		#line hidden
		#line 65
		li_rc = (Sybase.PowerBuilder.PBInt)(c__pfcexamp.GetCurrentApplication().message.DoubleParm);
		#line hidden
		#line 68
		if (ib_alwaysontop)
		#line hidden
		{
			#line 69
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
			#line hidden
			{
				#line 70
				li_testrc = iw_sqlspy.of_setalwaysontop(new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
			}
		}
		#line 74
		return li_rc;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_sqlpreview(ISCsqlpreviewfunction.Csqlpreviewtype.RSCdwbuffer.L)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_sqlpreview", new string[]{"string", "sqlpreviewfunction", "sqlpreviewtype", "ref string", "dwbuffer", "long"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_sqlpreview(Sybase.PowerBuilder.PBString as_controlname, Sybase.PowerBuilder.PBSQLPreviewFunctionValue a_sqlpreviewfunction, Sybase.PowerBuilder.PBSQLPreviewTypeValue a_sqlpreviewtype, ref Sybase.PowerBuilder.PBString as_sqlsyntax, Sybase.PowerBuilder.PBDWBufferValue a_dwbuffer, Sybase.PowerBuilder.PBLong al_row)
	{
		#line hidden
		Sybase.PowerBuilder.PBString ls_newentry_heading = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_sqltype = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
		#line 66
		if ((Sybase.PowerBuilder.PBBoolean)(((((Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_controlname))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(a_sqlpreviewfunction)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(a_sqlpreviewtype)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(as_sqlsyntax)))))| Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(a_dwbuffer)))))| (as_sqlsyntax == new Sybase.PowerBuilder.PBString(""))))
		#line hidden
		{
			#line 68
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 73
		ls_sqltype = lnv_conversion.of_string(a_sqlpreviewtype);
		#line hidden
		#line 76
		ls_newentry_heading = (ls_sqltype+ new Sybase.PowerBuilder.PBString(" - "))+ as_controlname;
		#line hidden
		#line 77
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_sqltype), Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(new Sybase.PowerBuilder.PBString("Retrieve"))) == (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 78
			ls_newentry_heading = ((ls_newentry_heading+ new Sybase.PowerBuilder.PBString("("))+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(al_row)))))+ new Sybase.PowerBuilder.PBString(")");
			#line hidden
		}
		#line 82
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_sqltype), Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(new Sybase.PowerBuilder.PBString("Retrieve")))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 84
			return this.of_sqlsyntax(ls_newentry_heading, ref as_sqlsyntax, new Sybase.PowerBuilder.PBBoolean(false));
			#line hidden
		}
		#line 88
		return this.of_sqlsyntax(ls_newentry_heading, ref as_sqlsyntax, new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_setalwaysontop(IB)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setalwaysontop", new string[]{"boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setalwaysontop(Sybase.PowerBuilder.PBBoolean ab_switch)
	{
		#line hidden
		#line 47
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 48
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 51
		ib_alwaysontop = ab_switch;
		#line hidden
		#line 53
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy)))
		#line hidden
		{
			#line 54
			iw_sqlspy.of_setalwaysontop(ib_alwaysontop);
			#line hidden
		}
		#line 57
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getalwaysontop(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getalwaysontop", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_getalwaysontop()
	{
		#line hidden
		#line 44
		return ib_alwaysontop;
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_isopen(B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_isopen", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBBoolean of_isopen()
	{
		#line hidden
		#line 44
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(iw_sqlspy));
		#line hidden
	}

	#line 1 "pfc_n_cst_sqlspy.of_getlogfile(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getlogfile", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getlogfile()
	{
		#line hidden
		#line 51
		return is_logfile;
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

	#line 1 "pfc_n_cst_sqlspy.destructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
	public override Sybase.PowerBuilder.PBLong destructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 43
		this.of_opensqlspy(new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
	}

	public c__pfc_n_cst_sqlspy()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_sqlspy(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_sqlspy vv = new c__pfc_n_cst_sqlspy();
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
			return (c__pfc_n_cst_sqlspy) v.Value;
		}
	}
}
 