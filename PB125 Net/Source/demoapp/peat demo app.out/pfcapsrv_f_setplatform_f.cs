//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx\\f_setplatform.srf"
#line hidden
#line 1 "f_setplatform"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("f_setplatform",Sybase.PowerBuilder.PBGroupType.FunctionObject,"","c:\\pfc\\12.net\\demoapp\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="f_setplatform")]
public class c__f_setplatform : Sybase.PowerBuilder.PBFunction_Object
{
	#line hidden

	#line 1 "f_setplatform(IRCn_cst_platform.B)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("f_setplatform", new string[]{"ref n_cst_platform", "boolean"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public static Sybase.PowerBuilder.PBInt f_setplatform<T0>(ref T0 anv_platform, Sybase.PowerBuilder.PBBoolean ab_switch) where T0 : c__n_cst_platform
	{
		#line hidden
		#line 58
		if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ab_switch)))))
		#line hidden
		{
			#line 58
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_peat)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(c__peat.GetCurrentApplication().gnv_app)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__peat.GetCurrentApplication().gnv_app)))))
		#line hidden
		{
			#line 59
			return new Sybase.PowerBuilder.PBInt(-1);
			#line hidden
		}
		#line 61
		if (ab_switch)
		#line hidden
		{
			#line 62
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)(c__n_cst_platform)((new Sybase.PowerBuilder.PBAny(((c__n_cst_platform)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(anv_platform)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__n_cst_platform)(anv_platform)))))
			#line hidden
			{
				#line 64
				Sybase.PowerBuilder.PBOsTypesValue __PB_TEMP______switchTmpVar0 = c__peat.GetCurrentApplication().gnv_app.ienv_object.osType;
				#line hidden
				#line 65
				if ((__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.Windows)) )|| (__PB_TEMP______switchTmpVar0 == (new Sybase.PowerBuilder.PBOsTypesValue(Sybase.PowerBuilder.PBOsTypes.WindowsNT)) ))
				#line hidden
				{
					#line 66
					if ((Sybase.PowerBuilder.PBBoolean)(c__peat.GetCurrentApplication().gnv_app.ienv_object.CharSet == (new Sybase.PowerBuilder.PBCharSetValue(Sybase.PowerBuilder.PBCharSet.CharSetUnicode))))
					#line hidden
					{
						#line 67
						anv_platform = (T0)(c__n_cst_platform)((c__n_cst_platformunicode)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__n_cst_platformunicode), 0));
						#line hidden
					}
					else
					{
						#line 69
						anv_platform = (T0)(c__n_cst_platform)((c__n_cst_platform)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__n_cst_platform), 0));
						#line hidden
					}
				}
				else 
				{
					#line 72
					anv_platform = (T0)(c__n_cst_platform)((c__n_cst_platform)Sybase.PowerBuilder.WPF.PBSession.CurrentSession.CreateInstance(typeof(c__n_cst_platform), 0));
					#line hidden
				}

				#line 74
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		else
		{
			#line 77
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(c__n_cst_platform)(anv_platform)))
			#line hidden
			{
				#line 78
				Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(anv_platform);
				#line hidden
				#line 79
				return new Sybase.PowerBuilder.PBInt(1);
				#line hidden
			}
		}
		#line 83
		return new Sybase.PowerBuilder.PBInt(0);
		#line hidden
	}
}
 