//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_inifile.sru"
#line hidden
#line 1 "pfc_n_cst_inifile"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_inifile",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_inifile")]
public class c__pfc_n_cst_inifile : c__n_base
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_lineend", null, "pfc_n_cst_inifile", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBString is_lineend = Sybase.PowerBuilder.PBString.DefaultValue;

	#line 1 "pfc_n_cst_inifile.of_getsections(ISRS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsections", new string[]{"string", "ref string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getsections_2_345252223(Sybase.PowerBuilder.PBString as_file, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] ref Sybase.PowerBuilder.PBArray as_sections)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_length = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBInt li_file = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_pos = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_first = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_last = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBInt li_section = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_line = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_section = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_sections = new Sybase.PowerBuilder.PBUnboundedStringArray();
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		#line 63
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 66
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(as_file)))
		#line hidden
		{
			#line 67
			return new Sybase.PowerBuilder.PBInt(-2);
			#line hidden
		}
		#line 71
		ll_length = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileLength(as_file);
		#line hidden
		#line 72
		li_file = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(as_file, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.LineMode)));
		#line hidden
		#line 73
		if ((Sybase.PowerBuilder.PBBoolean)(li_file == new Sybase.PowerBuilder.PBInt(-1)))
		#line hidden
		{
			#line 73
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 76
		as_sections.AssignFrom((Sybase.PowerBuilder.PBArray)ls_sections);
		#line hidden
		#line 80
		while ( (Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
		#line hidden
		{
				#line 81
				li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileRead(li_file, ref ls_line);
				#line hidden
				#line 82
				if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 83
					return li_rc;
					#line hidden
				}
				#line 84
				else if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 85
					ll_first = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("["));
					#line hidden
					#line 86
					ll_last = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
					#line hidden
					#line 87
					if ((Sybase.PowerBuilder.PBBoolean)((ll_first> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_last> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
					#line hidden
					{
						#line 88
						ls_line = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
						#line hidden
						#line 89
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_line, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("[")))
						#line hidden
						{
							#line 90
							ll_pos = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
							#line hidden
							#line 91
							ls_section = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_line, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)), ll_pos- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)));
							#line hidden
							#line 92
							li_section++;
							#line hidden
							#line 93
							as_sections[as_sections.Extend((Sybase.PowerBuilder.PBLong)(li_section))] = ls_section;
							#line hidden
						}
					}
				}
		}

		#line 100
		Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_file);
		#line hidden
		#line 101
		return li_section;
		#line hidden
	}

	#line 1 "pfc_n_cst_inifile.of_getkeys(ISSRS[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getkeys", new string[]{"string", "string", "ref string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_getkeys_3_345252223(Sybase.PowerBuilder.PBString as_file, Sybase.PowerBuilder.PBString as_section, [Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] ref Sybase.PowerBuilder.PBArray as_keys)
	{
		#line hidden
		Sybase.PowerBuilder.PBBoolean lb_sectionfound = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt li_file = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_keys = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_pos = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_first = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_last = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_equal = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_length = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_line = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_key = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_section = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_comment = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_keys = new Sybase.PowerBuilder.PBUnboundedStringArray();
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		#line 69
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 72
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(as_file)))
		#line hidden
		{
			#line 73
			return new Sybase.PowerBuilder.PBInt(-2);
			#line hidden
		}
		#line 77
		ll_length = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileLength(as_file);
		#line hidden
		#line 78
		li_file = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(as_file, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.LineMode)));
		#line hidden
		#line 79
		if ((Sybase.PowerBuilder.PBBoolean)(li_file == new Sybase.PowerBuilder.PBInt(-1)))
		#line hidden
		{
			#line 79
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 82
		as_keys.AssignFrom((Sybase.PowerBuilder.PBArray)ls_keys);
		#line hidden
		#line 86
		while ( ((Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& !(lb_sectionfound) )
		#line hidden
		{
				#line 89
				li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileRead(li_file, ref ls_line);
				#line hidden
				#line 90
				if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 91
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
				#line 95
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 98
					ll_first = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("["));
					#line hidden
					#line 99
					ll_last = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
					#line hidden
					#line 102
					if ((Sybase.PowerBuilder.PBBoolean)((ll_first> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_last> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
					#line hidden
					{
						#line 105
						ls_line = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
						#line hidden
						#line 106
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_line, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("[")))
						#line hidden
						{
							#line 107
							ll_pos = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
							#line hidden
							#line 108
							ls_section = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_line, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)), ll_pos- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)));
							#line hidden
							#line 110
							if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_section) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_section)))
							#line hidden
							{
								#line 112
								lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(true);
								#line hidden
							}
						}
					}
				}
		}

		#line 123
		if (lb_sectionfound)
		#line hidden
		{
			#line 124
			lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 125
			while ( ((Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& !(lb_sectionfound) )
			#line hidden
			{
					#line 128
					li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileRead(li_file, ref ls_line);
					#line hidden
					#line 129
					if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(-1)))
					#line hidden
					{
						#line 130
						return new Sybase.PowerBuilder.PBInt(-1);
						#line hidden
					}
					#line 134
					if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 136
						ls_comment = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
						#line hidden
						#line 137
						if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBString)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Char((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_comment))))) == new Sybase.PowerBuilder.PBString(";")))
						#line hidden
						{
							#line 137
							continue;
							#line hidden
						}
						#line 139
						ll_equal = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("="));
						#line hidden
						#line 140
						if ((Sybase.PowerBuilder.PBBoolean)(ll_equal> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
						#line hidden
						{
							#line 141
							ls_key = lnv_string.of_trim(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_line, ll_equal- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))), new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
							#line 142
							if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_key)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
							#line hidden
							{
								#line 143
								li_keys++;
								#line hidden
								#line 144
								as_keys[as_keys.Extend((Sybase.PowerBuilder.PBLong)(li_keys))] = ls_key;
								#line hidden
							}
						}
						else
						{
							#line 147
							ll_first = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("["));
							#line hidden
							#line 148
							ll_last = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
							#line hidden
							#line 149
							if ((Sybase.PowerBuilder.PBBoolean)((ll_first> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_last> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
							#line hidden
							{
								#line 150
								ls_line = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
								#line hidden
								#line 151
								if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_line, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("[")))
								#line hidden
								{
									#line 152
									lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(true);
									#line hidden
								}
							}
						}
					}
			}

		}
		#line 164
		Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_file);
		#line hidden
		#line 165
		return li_keys;
		#line hidden
	}

	#line 1 "pfc_n_cst_inifile.of_delete(ISS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_delete", new string[]{"string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_delete(Sybase.PowerBuilder.PBString as_file, Sybase.PowerBuilder.PBString as_section)
	{
		#line hidden
		Sybase.PowerBuilder.PBBlob lblb_newfile = Sybase.PowerBuilder.PBBlob.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_skipline = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_sectionfound = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt li_file = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt li_filewriterc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_length = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_first = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_last = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_pos = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_line = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_section = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_temp = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		c__n_cst_filesrv lnv_filesrv = null;
		#line 69
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 72
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(as_file)))
		#line hidden
		{
			#line 73
			return new Sybase.PowerBuilder.PBInt(-2);
			#line hidden
		}
		#line 77
		ll_length = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileLength(as_file);
		#line hidden
		#line 78
		li_file = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(as_file);
		#line hidden
		#line 79
		if ((Sybase.PowerBuilder.PBBoolean)(li_file == new Sybase.PowerBuilder.PBInt(-1)))
		#line hidden
		{
			#line 79
			return li_file;
			#line hidden
		}
		#line 84
		while ( (Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
		#line hidden
		{
				#line 87
				li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileRead(li_file, ref ls_line);
				#line hidden
				#line 88
				if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 89
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
				#line 93
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
				#line hidden
				{
					#line 95
					ll_first = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("["));
					#line hidden
					#line 96
					ll_last = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
					#line hidden
					#line 99
					if ((Sybase.PowerBuilder.PBBoolean)((ll_first> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_last> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
					#line hidden
					{
						#line 102
						ls_temp = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
						#line hidden
						#line 103
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_temp, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("[")))
						#line hidden
						{
							#line 104
							ll_pos = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_temp, new Sybase.PowerBuilder.PBString("]"));
							#line hidden
							#line 105
							ls_section = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_temp, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)), ll_pos- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)));
							#line hidden
							#line 107
							if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_section) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_section)))
							#line hidden
							{
								#line 109
								lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(true);
								#line hidden
								#line 111
								lb_skipline = new Sybase.PowerBuilder.PBBoolean(true);
								#line hidden
							}
							else
							{
								#line 114
								lb_skipline = new Sybase.PowerBuilder.PBBoolean(false);
								#line hidden
							}
						}
					}
				}
				#line 121
				ls_line = ls_line+ this.of_getlineending();
				#line hidden
				#line 125
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& !(lb_skipline)))
				#line hidden
				{
					#line 126
					lblb_newfile.AssignFrom(lblb_newfile+ Sybase.PowerBuilder.WPF.PBSystemFunctions.Blob((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_line)))));
					#line hidden
				}
		}

		#line 131
		Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_file);
		#line hidden
		#line 134
		if (!(lb_sectionfound))
		#line hidden
		{
			#line 135
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 139
		li_rc = c__f_setfilesrv.f_setfilesrv(ref lnv_filesrv, new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 140
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 140
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 141
		li_filewriterc = lnv_filesrv.of_filewrite(as_file, (lblb_newfile).ToPBBlob(-1), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 142
		li_rc = c__f_setfilesrv.f_setfilesrv(ref lnv_filesrv, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 144
		return li_filewriterc;
		#line hidden
	}

	#line 1 "pfc_n_cst_inifile.of_delete(ISSS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_delete", new string[]{"string", "string", "string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_delete(Sybase.PowerBuilder.PBString as_file, Sybase.PowerBuilder.PBString as_section, Sybase.PowerBuilder.PBString as_key)
	{
		#line hidden
		Sybase.PowerBuilder.PBBlob lblb_newfile = Sybase.PowerBuilder.PBBlob.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_skipline = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_sectionfound = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_entryremoved = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt li_file = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_rc = new Sybase.PowerBuilder.PBInt(1);
		Sybase.PowerBuilder.PBInt li_filewriterc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_keylength = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_length = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_first = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_last = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_pos = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_line = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_section = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_temp = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		c__n_cst_filesrv lnv_filesrv = null;
		#line 75
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 78
		if (!(Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(as_file)))
		#line hidden
		{
			#line 79
			return new Sybase.PowerBuilder.PBInt(-2);
			#line hidden
		}
		#line 83
		ll_length = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileLength(as_file);
		#line hidden
		#line 84
		li_file = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(as_file);
		#line hidden
		#line 85
		if ((Sybase.PowerBuilder.PBBoolean)(li_file == new Sybase.PowerBuilder.PBInt(-1)))
		#line hidden
		{
			#line 85
			return li_file;
			#line hidden
		}
		#line 90
		li_keylength = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(as_key));
		#line hidden
		#line 91
		while ( (Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) )
		#line hidden
		{
				#line 94
				li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileRead(li_file, ref ls_line);
				#line hidden
				#line 95
				if ((Sybase.PowerBuilder.PBBoolean)(li_rc == new Sybase.PowerBuilder.PBInt(-1)))
				#line hidden
				{
					#line 96
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
				#line 99
				if (!(lb_entryremoved))
				#line hidden
				{
					#line 100
					if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 103
						ll_first = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("["));
						#line hidden
						#line 104
						ll_last = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_line, new Sybase.PowerBuilder.PBString("]"));
						#line hidden
						#line 107
						if ((Sybase.PowerBuilder.PBBoolean)((ll_first> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (ll_last> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
						#line hidden
						{
							#line 110
							ls_temp = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
							#line hidden
							#line 111
							if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_temp, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))) == new Sybase.PowerBuilder.PBString("[")))
							#line hidden
							{
								#line 112
								ll_pos = Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_temp, new Sybase.PowerBuilder.PBString("]"));
								#line hidden
								#line 113
								ls_section = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_temp, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)), ll_pos- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)));
								#line hidden
								#line 115
								if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(ls_section) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_section)))
								#line hidden
								{
									#line 117
									lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(true);
									#line hidden
								}
								else
								{
									#line 120
									lb_sectionfound = new Sybase.PowerBuilder.PBBoolean(false);
									#line hidden
								}
							}
						}
						else
						{
							#line 125
							if (lb_sectionfound)
							#line hidden
							{
								#line 127
								ls_temp = lnv_string.of_lefttrim(ls_line, new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
								#line hidden
								#line 129
								if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_temp, (Sybase.PowerBuilder.PBLong)(li_keylength))) == Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_key)))
								#line hidden
								{
									#line 131
									ls_temp = lnv_string.of_lefttrim(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(ls_temp, (Sybase.PowerBuilder.PBLong)(li_keylength)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))), new Sybase.PowerBuilder.PBBoolean(true), new Sybase.PowerBuilder.PBBoolean(true));
									#line hidden
									#line 132
									if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBString)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Char((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_temp))))) == new Sybase.PowerBuilder.PBString("=")))
									#line hidden
									{
										#line 134
										lb_skipline = new Sybase.PowerBuilder.PBBoolean(true);
										#line hidden
										#line 136
										lb_entryremoved = new Sybase.PowerBuilder.PBBoolean(true);
										#line hidden
									}
								}
							}
						}
					}
				}
				else
				{
					#line 144
					lb_skipline = new Sybase.PowerBuilder.PBBoolean(false);
					#line hidden
				}
				#line 148
				ls_line = ls_line+ this.of_getlineending();
				#line hidden
				#line 152
				if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBLong)(li_rc)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& !(lb_skipline)))
				#line hidden
				{
					#line 153
					lblb_newfile.AssignFrom(lblb_newfile+ Sybase.PowerBuilder.WPF.PBSystemFunctions.Blob((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ls_line)))));
					#line hidden
				}
		}

		#line 158
		Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_file);
		#line hidden
		#line 161
		if ((Sybase.PowerBuilder.PBBoolean)(!(lb_sectionfound)| !(lb_entryremoved)))
		#line hidden
		{
			#line 162
			return new Sybase.PowerBuilder.PBInt(0);
			#line hidden
		}
		#line 166
		li_rc = c__f_setfilesrv.f_setfilesrv(ref lnv_filesrv, new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 167
		if ((Sybase.PowerBuilder.PBBoolean)(li_rc != new Sybase.PowerBuilder.PBInt(1)))
		#line hidden
		{
			#line 167
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 168
		li_filewriterc = lnv_filesrv.of_filewrite(as_file, (lblb_newfile).ToPBBlob(-1), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 169
		li_rc = c__f_setfilesrv.f_setfilesrv(ref lnv_filesrv, new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 171
		return li_filewriterc;
		#line hidden
	}

	#line 1 "pfc_n_cst_inifile.of_setlineending(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setlineending", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setlineending(Sybase.PowerBuilder.PBString as_lineending)
	{
		#line hidden
		#line 49
		is_lineend = as_lineending;
		#line hidden
		#line 50
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_n_cst_inifile.of_getlineending(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getlineending", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getlineending()
	{
		#line hidden
		#line 46
		return is_lineend;
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

	#line 1 "pfc_n_cst_inifile.constructor"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("constructor")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
	public override Sybase.PowerBuilder.PBLong constructor()
	{
		#line hidden
		Sybase.PowerBuilder.PBEnvironment lenv_obj = (Sybase.PowerBuilder.PBEnvironment) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.PBEnvironment));
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 41
		Sybase.PowerBuilder.WPF.PBSystemFunctions.GetEnvironment(ref lenv_obj);
		#line hidden
		#line 43
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(lenv_obj)))
		#line hidden
		{
			#line 44
			Sybase.PowerBuilder.PBOsTypesValue __PB_TEMP______switchTmpVar0 = lenv_obj.osType;
			#line hidden
			#line 46
			if ((__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.AIX)) )|| (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.OSF1)) )|| (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.HPUX)) )|| (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.AIX)) ))
			#line hidden
			{
				#line 47
				this.of_setlineending(new Sybase.PowerBuilder.PBString("\n"));
				#line hidden
			}
			#line 50
			else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.Macintosh)) )
			#line hidden
			{
				#line 51
				this.of_setlineending(new Sybase.PowerBuilder.PBString("\r"));
				#line hidden
			}
			else 
			{
				#line 55
				this.of_setlineending(new Sybase.PowerBuilder.PBString("\r\n"));
				#line hidden
			}

		}
		else
		{
			#line 58
			this.of_setlineending(new Sybase.PowerBuilder.PBString("\r\n"));
			#line hidden
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	public override object Clone()
	{
		c__pfc_n_cst_inifile vv = (c__pfc_n_cst_inifile)base.Clone();
 		vv.is_lineend = is_lineend;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
	}

	public c__pfc_n_cst_inifile()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_inifile(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_inifile vv = new c__pfc_n_cst_inifile();
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
			return (c__pfc_n_cst_inifile) v.Value;
		}
	}
}
 