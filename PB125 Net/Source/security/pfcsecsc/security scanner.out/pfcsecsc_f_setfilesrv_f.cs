//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx\\f_setfilesrv.srf"
#line hidden
#line 1 "f_setfilesrv"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("f_setfilesrv",Sybase.PowerBuilder.PBGroupType.FunctionObject,"","c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="f_setfilesrv")]
public class c__f_setfilesrv : Sybase.PowerBuilder.PBFunction_Object
{
	#line hidden

	#line 1 "f_setfilesrv(IRCpfcscanner_n_cst_filesrv.B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("f_setfilesrv", new string[]{"ref pfcscanner_n_cst_filesrv", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public static Sybase.PowerBuilder.PBInt f_setfilesrv<T0>(ref T0 anv_filesrv, Sybase.PowerBuilder.PBBoolean ab_switch) where T0 : c__pfcscanner_n_cst_filesrv
	{
		#line hidden
		Sybase.PowerBuilder.PBEnvironment le_env = (Sybase.PowerBuilder.PBEnvironment) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(Sybase.PowerBuilder.PBEnvironment));
		#line 56
		Sybase.PowerBuilder.WPF.PBSystemFunctions.GetEnvironment(ref le_env);
		#line hidden
		#line 58
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 58
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 60
		if (ab_switch)
		#line hidden
		{
			#line 61
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(c__pfcscanner_n_cst_filesrv)((new Sybase.PowerBuilder.PBAny(((c__pfcscanner_n_cst_filesrv)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_filesrv)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcscanner_n_cst_filesrv)(anv_filesrv)))))
			#line hidden
			{
				#line 63
				Sybase.PowerBuilder.PBOsTypesValue __PB_TEMP______switchTmpVar0 = le_env.osType;
				#line hidden
				#line 64
				if ((__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.Windows)) )|| (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.WindowsNT)) ))
				#line hidden
				{
					#line 65
					if ((Sybase.PowerBuilder.PBBoolean)(le_env.CharSet == (new Sybase.PowerBuilder.PBCharSetValue(Sybase.PowerBuilder.PBCharSet.CharSetUnicode))))
					#line hidden
					{
						#line 66
						anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrvunicode)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrvunicode), 0));
						#line hidden
					}
					else
					{
						#line 68
						anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrvwin32)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrvwin32), 0));
						#line hidden
					}
				}
				#line 70
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.SOL2)) )
				#line hidden
				{
					#line 71
					anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrvsol2)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrvsol2), 0));
					#line hidden
				}
				#line 72
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.HPUX)) )
				#line hidden
				{
					#line 73
					anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrvhpux)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrvhpux), 0));
					#line hidden
				}
				#line 74
				else if (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.AIX)) )
				#line hidden
				{
					#line 75
					anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrvaix)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrvaix), 0));
					#line hidden
				}
				else 
				{
					#line 77
					anv_filesrv = (T0)(c__pfcscanner_n_cst_filesrv)((c__pfcscanner_n_cst_filesrv)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__pfcscanner_n_cst_filesrv), 0));
					#line hidden
				}

				#line 79
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		else
		{
			#line 82
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__pfcscanner_n_cst_filesrv)(anv_filesrv)))
			#line hidden
			{
				#line 83
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(anv_filesrv);
				#line hidden
				#line 84
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		#line 88
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}
}
 