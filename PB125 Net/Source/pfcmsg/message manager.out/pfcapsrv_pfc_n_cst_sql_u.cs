//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_sql.sru"
#line hidden
#line 1 "pfc_n_cst_sql"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_sql",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_sql")]
public class c__pfc_n_cst_sql : c__n_base
{
	#line hidden

	#line 1 "pfc_n_cst_sql.of_assemble(SCn_cst_sqlattrib.[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_assemble", new string[]{"n_cst_sqlattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_assemble_1_2113381388([Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_sqlattrib))] Sybase.PowerBuilder.PBArray astr_sql)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_numstats = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_sql = Sybase.PowerBuilder.PBString.DefaultValue;
		#line 51
		li_numstats = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(astr_sql)));
		#line hidden
		#line 53
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_numstats;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 56
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb) == new Sybase.PowerBuilder.PBString(""))| (Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables) == new Sybase.PowerBuilder.PBString(""))))
				#line hidden
				{
					#line 58
					return new Sybase.PowerBuilder.PBString("");
					#line hidden
				}
				#line 63
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_cnt)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))))
				#line hidden
				{
					#line 64
					ls_sql = ls_sql+ new Sybase.PowerBuilder.PBString(" UNION ");
					#line hidden
				}
				#line 67
				ls_sql = ls_sql+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb;
				#line hidden
				#line 69
				if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb == new Sybase.PowerBuilder.PBString("SELECT")))
				#line hidden
				{
					#line 70
					if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_columns) == new Sybase.PowerBuilder.PBString("")))
					#line hidden
					{
						#line 71
						return new Sybase.PowerBuilder.PBString("");
						#line hidden
					}
					else
					{
						#line 73
						ls_sql = (((ls_sql+ new Sybase.PowerBuilder.PBString(" "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_columns)+ new Sybase.PowerBuilder.PBString(" FROM "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables;
						#line hidden
					}
				}
				else
				{
					#line 78
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables;
					#line hidden
					#line 80
					if ((Sybase.PowerBuilder.PBBoolean)(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb == new Sybase.PowerBuilder.PBString("UPDATE")))
					#line hidden
					{
						#line 81
						ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" SET "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_columns;
						#line hidden
					}
					#line 82
					else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_columns) != new Sybase.PowerBuilder.PBString("")))
					#line hidden
					{
						#line 83
						ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_columns;
						#line hidden
					}
				}
				#line 87
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_values) != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 88
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" VALUES "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_values;
					#line hidden
				}
				#line 91
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_where) != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 92
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" WHERE "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_where;
					#line hidden
				}
				#line 95
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_group) != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 96
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" GROUP BY "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_group;
					#line hidden
				}
				#line 99
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_having) != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 100
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" HAVING "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_having;
					#line hidden
				}
				#line 103
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_order) != new Sybase.PowerBuilder.PBString("")))
				#line hidden
				{
					#line 104
					ls_sql = (ls_sql+ new Sybase.PowerBuilder.PBString(" ORDER BY "))+ ((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_order;
					#line hidden
				}
		}
		#line 108
		return ls_sql;
		#line hidden
	}

	#line 1 "pfc_n_cst_sql.of_parse(ISRCn_cst_sqlattrib.[])"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_parse", new string[]{"string", "ref n_cst_sqlattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_parse_2_2113381388(Sybase.PowerBuilder.PBString as_sql, [Sybase.PowerBuilder.PBArrayAttribute(typeof(c__n_cst_sqlattrib))] ref Sybase.PowerBuilder.PBArray astr_sql)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_pos = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_kwnum = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_numstats = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBInt li_posu = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_uppersql = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_keyword = new Sybase.PowerBuilder.PBBoundedStringArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,7}, false));
		Sybase.PowerBuilder.PBArray ls_clause = new Sybase.PowerBuilder.PBBoundedStringArray( new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2] {1,7}, false));
		Sybase.PowerBuilder.PBArray ls_sql = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBString ls_right = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString li_unionreplace = new Sybase.PowerBuilder.PBString("*%$!@");
		Sybase.PowerBuilder.PBString li_allreplace = new Sybase.PowerBuilder.PBString("   ");
		Sybase.PowerBuilder.PBChar lc_char = Sybase.PowerBuilder.PBChar.DefaultValue;
		c__n_cst_string lnv_string = (c__n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_string));
		Sybase.PowerBuilder.PBBoolean lb_isunion = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBBoolean lb_isunionall = Sybase.PowerBuilder.PBBoolean.DefaultValue;
		Sybase.PowerBuilder.PBInt li_posall = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 60
		as_sql = lnv_string.of_globalreplace(as_sql, new Sybase.PowerBuilder.PBString("\r"), new Sybase.PowerBuilder.PBString(" "));
		#line hidden
		#line 61
		as_sql = lnv_string.of_globalreplace(as_sql, new Sybase.PowerBuilder.PBString("\n"), new Sybase.PowerBuilder.PBString(" "));
		#line hidden
		#line 62
		as_sql = lnv_string.of_globalreplace(as_sql, new Sybase.PowerBuilder.PBString("\t"), new Sybase.PowerBuilder.PBString(" "));
		#line hidden
		#line 63
		as_sql = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_sql);
		#line hidden
		#line 68
		li_posu = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_sql), new Sybase.PowerBuilder.PBString("union")));
		#line hidden
		#line 69
		li_pos = li_posu;
		#line hidden
		#line 70
		lb_isunion = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 71
		lb_isunionall = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 72
		while  (!( (Sybase.PowerBuilder.PBLong)(li_pos)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)) ))
		#line hidden
		{
				#line 73
				lb_isunion = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 74
				lb_isunionall = new Sybase.PowerBuilder.PBBoolean(false);
				#line hidden
				#line 75
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_pos)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 76
					li_pos = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_pos)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)));
					#line hidden
					#line 77
					while ( new Sybase.PowerBuilder.PBBoolean(true) )
					#line hidden
					{
							#line 79
							lc_char = (Sybase.PowerBuilder.PBChar)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(as_sql, (Sybase.PowerBuilder.PBLong)(li_pos), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
							#line hidden
							#line 80
							if (lnv_string.of_isspace((Sybase.PowerBuilder.PBString)(lc_char)))
							#line hidden
							{
								#line 81
								lb_isunion = new Sybase.PowerBuilder.PBBoolean(true);
								#line hidden
								#line 82
								li_pos++;
								#line hidden
							}
							else
							{
								#line 84
								break;
								#line hidden
							}
					}

					#line 87
					if ((Sybase.PowerBuilder.PBBoolean)(lb_isunion == new Sybase.PowerBuilder.PBBoolean(true)))
					#line hidden
					{
						#line 89
						li_posall = li_pos;
						#line hidden
						#line 90
						ls_right = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_sql), (Sybase.PowerBuilder.PBLong)(li_posall), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)));
						#line hidden
						#line 91
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Upper(ls_right) == new Sybase.PowerBuilder.PBString("ALL")))
						#line hidden
						{
							#line 92
							li_pos = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBLong)(li_pos)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)));
							#line hidden
							#line 93
							while ( new Sybase.PowerBuilder.PBBoolean(true) )
							#line hidden
							{
									#line 94
									lc_char = (Sybase.PowerBuilder.PBChar)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(as_sql, (Sybase.PowerBuilder.PBLong)(li_pos), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))));
									#line hidden
									#line 95
									if (lnv_string.of_isspace((Sybase.PowerBuilder.PBString)(lc_char)))
									#line hidden
									{
										#line 96
										lb_isunionall = new Sybase.PowerBuilder.PBBoolean(true);
										#line hidden
										#line 97
										li_pos++;
										#line hidden
									}
									else
									{
										#line 99
										break;
										#line hidden
									}
							}

						}
						#line 103
						if ((Sybase.PowerBuilder.PBBoolean)(lb_isunionall == new Sybase.PowerBuilder.PBBoolean(true)))
						#line hidden
						{
							#line 104
							as_sql = Sybase.PowerBuilder.WPF.PBSystemFunctions.Replace(as_sql, (Sybase.PowerBuilder.PBLong)(li_posall), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)), li_allreplace);
							#line hidden
						}
						else
						{
							#line 106
							li_pos = li_posall;
							#line hidden
						}
						#line 108
						ls_right = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(as_sql), (Sybase.PowerBuilder.PBLong)(li_pos), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)));
						#line hidden
						#line 109
						if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Upper(ls_right) == new Sybase.PowerBuilder.PBString("SELECT")))
						#line hidden
						{
							#line 110
							as_sql = Sybase.PowerBuilder.WPF.PBSystemFunctions.Replace(as_sql, (Sybase.PowerBuilder.PBLong)(li_posu), (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)), li_unionreplace);
							#line hidden
						}
					}
					#line 113
					li_posu = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(as_sql), new Sybase.PowerBuilder.PBString("union"), (Sybase.PowerBuilder.PBLong)(li_pos)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))));
					#line hidden
					#line 114
					li_pos = li_posu;
					#line hidden
				}
		}

		#line 119
		li_numstats = (Sybase.PowerBuilder.PBInt)(of_parsetoarray_3_345252223_3_877135576(lnv_string, as_sql, li_unionreplace, ref ls_sql));
		#line hidden
		#line 121
		for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_numstats;li_cnt = li_cnt + 1)
		#line hidden
		{
				#line 124
				ls_sql[ls_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))] = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]));
				#line hidden
				#line 127
				ls_uppersql = Sybase.PowerBuilder.WPF.PBSystemFunctions.Upper(((Sybase.PowerBuilder.PBString)ls_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]));
				#line hidden
				#line 132
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))) == new Sybase.PowerBuilder.PBString("SELECT ")))
				#line hidden
				{
					#line 134
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("SELECT ");
					#line hidden
					#line 135
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))] = new Sybase.PowerBuilder.PBString(" FROM ");
					#line hidden
					#line 136
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))] = new Sybase.PowerBuilder.PBString(" WHERE ");
					#line hidden
					#line 137
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4))] = new Sybase.PowerBuilder.PBString(" GROUP BY ");
					#line hidden
					#line 138
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))] = new Sybase.PowerBuilder.PBString(" HAVING ");
					#line hidden
					#line 139
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6))] = new Sybase.PowerBuilder.PBString(" ORDER BY ");
					#line hidden
				}
				#line 141
				else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))) == new Sybase.PowerBuilder.PBString("UPDATE ")))
				#line hidden
				{
					#line 143
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("UPDATE ");
					#line hidden
					#line 144
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))] = new Sybase.PowerBuilder.PBString(" SET ");
					#line hidden
					#line 145
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))] = new Sybase.PowerBuilder.PBString(" WHERE ");
					#line hidden
					#line 146
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6))] = new Sybase.PowerBuilder.PBString(" ORDER BY ");
					#line hidden
				}
				#line 148
				else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12))) == new Sybase.PowerBuilder.PBString("INSERT INTO ")))
				#line hidden
				{
					#line 150
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("INSERT INTO ");
					#line hidden
					#line 151
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))] = new Sybase.PowerBuilder.PBString(" VALUES ");
					#line hidden
				}
				#line 153
				else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))) == new Sybase.PowerBuilder.PBString("INSERT ")))
				#line hidden
				{
					#line 155
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("INSERT ");
					#line hidden
					#line 156
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))] = new Sybase.PowerBuilder.PBString(" VALUES ");
					#line hidden
				}
				#line 158
				else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12))) == new Sybase.PowerBuilder.PBString("DELETE FROM ")))
				#line hidden
				{
					#line 160
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("DELETE FROM ");
					#line hidden
					#line 161
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))] = new Sybase.PowerBuilder.PBString(" WHERE ");
					#line hidden
				}
				#line 163
				else if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(ls_uppersql, (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))) == new Sybase.PowerBuilder.PBString("DELETE ")))
				#line hidden
				{
					#line 165
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))] = new Sybase.PowerBuilder.PBString("DELETE ");
					#line hidden
					#line 166
					ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))] = new Sybase.PowerBuilder.PBString(" WHERE ");
					#line hidden
				}
				#line 171
				for (li_kwnum = new Sybase.PowerBuilder.PBInt(7);li_kwnum >= new Sybase.PowerBuilder.PBInt(1);li_kwnum = li_kwnum + new Sybase.PowerBuilder.PBInt(-1))
				#line hidden
				{
						#line 172
						if ((Sybase.PowerBuilder.PBBoolean)(((Sybase.PowerBuilder.PBString)ls_keyword[(Sybase.PowerBuilder.PBLong)(li_kwnum)]) != new Sybase.PowerBuilder.PBString("")))
						#line hidden
						{
							#line 174
							li_pos = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(ls_uppersql, ((Sybase.PowerBuilder.PBString)ls_keyword[(Sybase.PowerBuilder.PBLong)(li_kwnum)]))- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
							#line hidden
							#line 176
							if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_pos)>= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
							#line hidden
							{
								#line 177
								ls_clause[(Sybase.PowerBuilder.PBLong)(li_kwnum)] = Sybase.PowerBuilder.WPF.PBSystemFunctions.Right(((Sybase.PowerBuilder.PBString)ls_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]), Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(((Sybase.PowerBuilder.PBString)ls_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]))- ((Sybase.PowerBuilder.PBLong)(li_pos)+ Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(((Sybase.PowerBuilder.PBString)ls_keyword[(Sybase.PowerBuilder.PBLong)(li_kwnum)]))));
								#line hidden
								#line 180
								ls_sql[ls_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))] = Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(((Sybase.PowerBuilder.PBString)ls_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]), (Sybase.PowerBuilder.PBLong)(li_pos));
								#line hidden
							}
							else
							{
								#line 182
								ls_clause[(Sybase.PowerBuilder.PBLong)(li_kwnum)] = new Sybase.PowerBuilder.PBString("");
								#line hidden
							}
						}
				}
				#line 187
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_verb = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_keyword[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]));
				#line hidden
				#line 189
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb, new Sybase.PowerBuilder.PBString("SELECT"))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 190
					((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_columns = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]));
					#line hidden
					#line 191
					((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_tables = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))]));
					#line hidden
				}
				else
				{
					#line 193
					((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_tables = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]));
					#line hidden
					#line 195
					if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_verb, new Sybase.PowerBuilder.PBString("INSERT"))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
					#line hidden
					{
						#line 196
						li_pos = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables, new Sybase.PowerBuilder.PBString(" ")));
						#line hidden
						#line 197
						if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_pos)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
						#line hidden
						{
							#line 198
							((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_columns = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(Sybase.PowerBuilder.WPF.PBSystemFunctions.Right(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables, Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables)- (Sybase.PowerBuilder.PBLong)(li_pos)));
							#line hidden
							#line 200
							((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_tables = Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(((c__n_cst_sqlattrib)astr_sql[(Sybase.PowerBuilder.PBLong)(li_cnt)]).s_tables, (Sybase.PowerBuilder.PBLong)(li_pos)- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
							#line hidden
						}
					}
					else
					{
						#line 203
						((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_columns = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2))]));
						#line hidden
					}
				}
				#line 207
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_where = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3))]));
				#line hidden
				#line 208
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_group = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4))]));
				#line hidden
				#line 209
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_having = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5))]));
				#line hidden
				#line 210
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_order = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6))]));
				#line hidden
				#line 211
				((c__n_cst_sqlattrib)astr_sql[astr_sql.Extend((Sybase.PowerBuilder.PBLong)(li_cnt))]).s_values = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(((Sybase.PowerBuilder.PBString)ls_clause[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7))]));
				#line hidden
		}
		#line 214
		return li_numstats;
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
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
	}

	public override object Clone()
	{
		c__pfc_n_cst_sql vv = (c__pfc_n_cst_sql)base.Clone();
 		return vv;
	}

	public Sybase.PowerBuilder.PBLong of_parsetoarray_3_345252223_3_877135576(c__pfc_n_cst_string this__object, Sybase.PowerBuilder.PBString as_source, Sybase.PowerBuilder.PBString as_delimiter, ref Sybase.PowerBuilder.PBArray as_array)
	{
		Sybase.PowerBuilder.PBLong return_value = this__object.of_parsetoarray_3_345252223(as_source, as_delimiter, ref as_array);
		return return_value;
	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_sql()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_sql(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_sql vv = new c__pfc_n_cst_sql();
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
			return (c__pfc_n_cst_sql) v.Value;
		}
	}
}
 