//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx\\w_pfcsecurity_objectlist.srw"
#line hidden
#line 1 "w_pfcsecurity_objectlist"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_pfcsecurity_objectlist",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\security\\pfcsecsc\\pfcsecsc.pbl\\pfcsecsc.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_pfcsecurity_objectlist")]
public class c__w_pfcsecurity_objectlist : Sybase.PowerBuilder.WPF.PBWindow
{
	#line hidden
	public c__w_pfcsecurity_objectlist.c__cb_2 cb_2 = null;
	public c__w_pfcsecurity_objectlist.c__cb_cancel cb_cancel = null;
	public c__w_pfcsecurity_objectlist.c__cb_1 cb_1 = null;
	public c__w_pfcsecurity_objectlist.c__dw_1 dw_1 = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_canceled", null, "w_pfcsecurity_objectlist", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_canceled = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "il_gutter", null, "w_pfcsecurity_objectlist", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt il_gutter = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_liblist", null, "w_pfcsecurity_objectlist", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_liblist = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBArrayAttribute(typeof(Sybase.PowerBuilder.PBString))] 
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_libs", null, "w_pfcsecurity_objectlist", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBArray is_libs = new Sybase.PowerBuilder.PBUnboundedStringArray();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_app", null, "w_pfcsecurity_objectlist", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_app = Sybase.PowerBuilder.PBString.DefaultValue;

	#line 1 "w_pfcsecurity_objectlist.ue_scanlist"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("ue_scanlist")]
	public virtual void ue_scanlist()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_r = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_rows = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_libs = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBString ls_liblist = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_title = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_object = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_type = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBString ls_library = Sybase.PowerBuilder.PBString.DefaultValue;
		c__pfcscanner_n_cst_securityscanner lnv_security = null;
		c__pfcscanner_n_cst_string lnv_string = (c__pfcscanner_n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__pfcscanner_n_cst_string));
		#line 6
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 8
		ls_libs.AssignFrom((Sybase.PowerBuilder.PBArray)is_libs);
		#line hidden
		#line 9
		ls_title = this.Title;
		#line hidden
		#line 10
		ib_canceled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 11
		cb_cancel.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line 13
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 15
		lnv_security = (c__pfcscanner_n_cst_securityscanner)this.CreateInstance(typeof(c__pfcscanner_n_cst_securityscanner), 0);
		#line hidden
		#line 16
		of_initscanprocess_3_3452522231948383395(lnv_security, c__pfcsecurity_scanner.GetCurrentApplication().inv_trans, is_app, (Sybase.PowerBuilder.PBUnboundedStringArray)(ls_libs).ToUnbounded(typeof(Sybase.PowerBuilder.PBString)));
		#line hidden
		#line 18
		dw_1.SetFilter(new Sybase.PowerBuilder.PBString("IsSelected()"));
		#line hidden
		#line 19
		dw_1.Filter();
		#line hidden
		#line 21
		ll_rows = dw_1.RowCount();
		#line hidden
		#line 22
		dw_1.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(false));
		#line hidden
		#line 23
		for (ll_r = ((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));ll_r <= ll_rows;ll_r = ll_r + 1)
		#line hidden
		{
				#line 24
				Sybase.PowerBuilder.WPF.PBSystemFunctions.Yield();
				#line hidden
				#line 25
				if (ib_canceled)
				#line hidden
				{
					#line 25
					break;
					#line hidden
				}
				#line 26
				this.Title = ((((ls_title+ new Sybase.PowerBuilder.PBString(" ("))+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ll_r)))))+ new Sybase.PowerBuilder.PBString(" of "))+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ll_rows)))))+ new Sybase.PowerBuilder.PBString(")");
				#line hidden
				#line 27
				dw_1.ScrollToRow(ll_r);
				#line hidden
				#line 28
				dw_1.SelectRow(ll_r, new Sybase.PowerBuilder.PBBoolean(true));
				#line hidden
				#line 29
				ls_object = dw_1.GetItemString(ll_r, new Sybase.PowerBuilder.PBString("name"));
				#line hidden
				#line 30
				ls_type = Sybase.PowerBuilder.WPF.PBSystemFunctions.Lower(dw_1.GetItemString(ll_r, new Sybase.PowerBuilder.PBString("otype")));
				#line hidden
				#line 31
				ls_library = (Sybase.PowerBuilder.PBString)(((Sybase.PowerBuilder.PBExtObject)dw_1.Object)[
					#line 31
					new Sybase.PowerBuilder.PBString(@"pbl"), 
					#line 31
					new Sybase.PowerBuilder.PBUInt(1), 
					#line 31
					new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[1]{(Sybase.PowerBuilder.PBLong)(ll_r)}) ,
					#line 31
					Sybase.PowerBuilder.PBBoolean.True
				#line 31
				]);
				#line hidden
				#line 32
				Sybase.PowerBuilder.PBString __PB_TEMP______switchTmpVar0 = ls_type;
				#line hidden
				#line 33
				if ((__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("window") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("menu") )|| (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("userobject") ))
				#line hidden
				{
					#line 34
					lnv_security.of_scanobject(ls_object, ls_library);
					#line hidden
					#line 35
					Sybase.PowerBuilder.WPF.PBSystemFunctions.Yield();
					#line hidden
				}
				#line 36
				else if (__PB_TEMP______switchTmpVar0 == new Sybase.PowerBuilder.PBString("datawindow") )
				#line hidden
				{
					#line 37
					lnv_security.of_scandatawindow(ls_object, ls_library);
					#line hidden
					#line 38
					Sybase.PowerBuilder.WPF.PBSystemFunctions.Yield();
					#line hidden
				}

				#line 40
				if ((Sybase.PowerBuilder.PBBoolean)(lnv_security.of_update() != new Sybase.PowerBuilder.PBInt(1)))
				#line hidden
				{
					#line 41
					Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(this.Title, ((new Sybase.PowerBuilder.PBString("Error updating ")+ ls_type)+ new Sybase.PowerBuilder.PBString(" - "))+ ls_object);
					#line hidden
					#line 42
					return;
					#line hidden
				}
		}
		#line 46
		this.Title = ls_title;
		#line hidden
		#line 47
		dw_1.SelectRow((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)), new Sybase.PowerBuilder.PBBoolean(true));
		#line hidden
		#line 49
		dw_1.SetFilter(new Sybase.PowerBuilder.PBString(""));
		#line hidden
		#line 50
		dw_1.Filter();
		#line hidden
		#line 51
		dw_1.Sort();
		#line hidden
		#line 53
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(lnv_security);
		#line hidden
		#line 54
		cb_cancel.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
	}

	#line 1 "w_pfcsecurity_objectlist.ue_postopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("ue_postopen")]
	public virtual void ue_postopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ll_start = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_end = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_l = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_libs = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_x = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBArray ls_libarray = new Sybase.PowerBuilder.PBUnboundedStringArray();
		Sybase.PowerBuilder.PBArray ls_init = new Sybase.PowerBuilder.PBUnboundedStringArray();
		#line 4
		Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
		#line hidden
		#line 6
		ll_libs = Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(is_libs));
		#line hidden
		#line 7
		for (ll_l = ((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));ll_l <= ll_libs;ll_l = ll_l + 1)
		#line hidden
		{
				#line 8
				dw_1.ImportString(Sybase.PowerBuilder.WPF.PBSystemFunctions.LibraryDirectoryEx(((Sybase.PowerBuilder.PBString)is_libs[ll_l]), (new Sybase.PowerBuilder.PBLibDirTypeValue(Sybase.PowerBuilder.PBLibDirType.DirAll))));
				#line hidden
				#line 9
				ll_start = ll_end+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
				#line hidden
				#line 10
				ll_end = dw_1.RowCount();
				#line hidden
				#line 11
				ls_libarray.AssignFrom((Sybase.PowerBuilder.PBArray)ls_init);
				#line hidden
				#line 12
				for (ll_x = ((Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));ll_x <= (ll_end- ll_start)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));ll_x = ll_x + 1)
				#line hidden
				{
						#line 13
						ls_libarray[ls_libarray.Extend(ll_x)] = ((Sybase.PowerBuilder.PBString)is_libs[ll_l]);
						#line hidden
				}
				#line 15
				((Sybase.PowerBuilder.PBExtObject)(((Sybase.PowerBuilder.PBExtObject)(dw_1.Object))[new Sybase.PowerBuilder.PBString(@"pbl"), Sybase.PowerBuilder.PBBoolean.False].Value))[
					#line 15
					new Sybase.PowerBuilder.PBString(@"current"), 
					#line 15
					new Sybase.PowerBuilder.PBUInt(2), 
					#line 15
					new Sybase.PowerBuilder.PBUnboundedLongArray(new Sybase.PowerBuilder.PBLong[2]{(Sybase.PowerBuilder.PBLong)(ll_start),(Sybase.PowerBuilder.PBLong)(ll_end)}) 
				#line 15
				] = (Sybase.PowerBuilder.PBAny)(ls_libarray);
				#line hidden
		}
		#line 19
		dw_1.Filter();
		#line hidden
		#line 20
		dw_1.Sort();
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		this.cb_2 = (c__cb_2)this.CreateInstance(this, "c__cb_2");
		#line hidden
		#line hidden
		this.cb_cancel = (c__cb_cancel)this.CreateInstance(this, "c__cb_cancel");
		#line hidden
		#line hidden
		this.cb_1 = (c__cb_1)this.CreateInstance(this, "c__cb_1");
		#line hidden
		#line hidden
		this.dw_1 = (c__dw_1)this.CreateInstance(this, "c__dw_1");
		#line hidden
		#line hidden
		this.Control.AssignFrom((Sybase.PowerBuilder.PBArray)( new Sybase.PowerBuilder.PBBoundedArray(typeof(Sybase.PowerBuilder.WPF.PBDragObject),  new Sybase.PowerBuilder.PBArray.ArrayBounds(new int[2]{1, 4},false), new Sybase.PowerBuilder.WPF.PBDragObject[4]{
		#line hidden
		(Sybase.PowerBuilder.WPF.PBDragObject)(this.cb_2),(Sybase.PowerBuilder.WPF.PBDragObject)(this.cb_cancel),(Sybase.PowerBuilder.WPF.PBDragObject)(this.cb_1),(Sybase.PowerBuilder.WPF.PBDragObject)(this.dw_1) })));
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_2);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_cancel);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_1);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_1);
		#line hidden
	}

	#line 1 "w_pfcsecurity_objectlist.open"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("open")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_open)]
	public override Sybase.PowerBuilder.PBLong open()
	{
		#line hidden
		c__pfcscanner_n_cst_string lnv_string = (c__pfcscanner_n_cst_string) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__pfcscanner_n_cst_string));
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 3
		is_liblist = c__pfcsecurity_scanner.GetCurrentApplication().message.StringParm;
		#line hidden
		#line 4
		is_app = Sybase.PowerBuilder.WPF.PBSystemFunctions.Left(is_liblist, Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(is_liblist, new Sybase.PowerBuilder.PBString("\t"))- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 5
		is_liblist = Sybase.PowerBuilder.WPF.PBSystemFunctions.Mid(is_liblist, Sybase.PowerBuilder.WPF.PBSystemFunctions.Pos(is_liblist, new Sybase.PowerBuilder.PBString("\t"))+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)));
		#line hidden
		#line 6
		of_parsetoarray_3_345252223_3_366964156(lnv_string, is_liblist, new Sybase.PowerBuilder.PBString(";"), ref is_libs);
		#line hidden
		#line 8
		cb_cancel.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
		#line hidden
		#line 10
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.PostMethod(this, "ue_postopen", new Sybase.PowerBuilder.PBArgument[0]{				});
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	#line 1 "w_pfcsecurity_objectlist.resize"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("resize")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_size)]
	public override Sybase.PowerBuilder.PBLong resize(Sybase.PowerBuilder.PBULong sizetype, Sybase.PowerBuilder.PBInt newwidth, Sybase.PowerBuilder.PBInt newheight)
	{
		#line hidden
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 1
		dw_1.Resize((Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBLong)(this.WorkSpaceWidth())- (Sybase.PowerBuilder.PBLong)(dw_1.X))- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(24))), (Sybase.PowerBuilder.PBInt)(((Sybase.PowerBuilder.PBLong)(this.WorkSpaceHeight())- (Sybase.PowerBuilder.PBLong)(dw_1.Y))- (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(24))));
		#line hidden
		return new Sybase.PowerBuilder.PBLong(0);
	}

	public Sybase.PowerBuilder.PBInt of_initscanprocess_3_3452522231948383395(c__pfcscanner_n_cst_securityscanner this__object, Sybase.PowerBuilder.PBTransaction a_trans, Sybase.PowerBuilder.PBString as_app, Sybase.PowerBuilder.PBArray as_lib_list)
	{
		 Sybase.PowerBuilder.PBArray temp_var_as_lib_list = new Sybase.PowerBuilder.PBUnboundedStringArray();
		temp_var_as_lib_list.AssignFrom(as_lib_list);
		Sybase.PowerBuilder.PBInt return_value = this__object.of_initscanprocess_3_345252223(a_trans, as_app, temp_var_as_lib_list);
		return return_value;
	}

	public Sybase.PowerBuilder.PBLong of_parsetoarray_3_345252223_3_366964156(c__pfcscanner_n_cst_string this__object, Sybase.PowerBuilder.PBString as_source, Sybase.PowerBuilder.PBString as_delimiter, ref Sybase.PowerBuilder.PBArray as_array)
	{
		Sybase.PowerBuilder.PBLong return_value = this__object.of_parsetoarray_3_345252223(as_source, as_delimiter, ref as_array);
		return return_value;
	}


	#line 1 "w_pfcsecurity_objectlist.cb_2"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_2")]
	public class c__cb_2 : Sybase.PowerBuilder.WPF.PBCommandButton
	{
		#line hidden

		#line 1 "w_pfcsecurity_objectlist.cb_2.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			Sybase.PowerBuilder.WPF.PBSystemFunctions.Close((Sybase.PowerBuilder.WPF.PBWindow)(((c__w_pfcsecurity_objectlist)(this.Parent))));
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_2()
		{
			_init();
		}

	}


	#line 1 "w_pfcsecurity_objectlist.cb_cancel"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_cancel")]
	public class c__cb_cancel : Sybase.PowerBuilder.WPF.PBCommandButton
	{
		#line hidden

		#line 1 "w_pfcsecurity_objectlist.cb_cancel.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			((c__w_pfcsecurity_objectlist)(Parent)).ib_canceled = new Sybase.PowerBuilder.PBBoolean(true);
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


	#line 1 "w_pfcsecurity_objectlist.cb_1"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_1")]
	public class c__cb_1 : Sybase.PowerBuilder.WPF.PBCommandButton
	{
		#line hidden

		#line 1 "w_pfcsecurity_objectlist.cb_1.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.PostMethod(((c__w_pfcsecurity_objectlist)(this.Parent)), "ue_scanlist", new Sybase.PowerBuilder.PBArgument[0]{					});
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_1()
		{
			_init();
		}

	}


	#line 1 "w_pfcsecurity_objectlist.dw_1"
	#line hidden
[Sybase.PowerBuilder.PBFieldInfoCollectionAttribute("DataObject","d_pfcsecurity_objectlist", typeof(Sybase.PowerBuilder.PBString))]
	[System.Diagnostics.DebuggerDisplay("",Type="dw_1")]
	public class c__dw_1 : c__pfcscanner_u_dw
	{
		#line hidden

		#line 1 "w_pfcsecurity_objectlist.dw_1.constructor"
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
			ib_extended = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			DataObject = new Sybase.PowerBuilder.PBString("d_pfcsecurity_objectlist");
			#line hidden
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);

			OnInitialUpdate();
		}

		public c__dw_1()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.OpenEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.open);
		this.ResizeEvent += new Sybase.PowerBuilder.PBM_EventHandler_mouse(this.resize);
	}

	public c__w_pfcsecurity_objectlist()
	{
		_init();
	}

}
 