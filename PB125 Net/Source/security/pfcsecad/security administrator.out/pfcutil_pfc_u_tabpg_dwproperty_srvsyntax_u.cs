//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_srvsyntax.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_srvsyntax"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_srvsyntax",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_srvsyntax")]
public class c__pfc_u_tabpg_dwproperty_srvsyntax : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_srvsyntax.c__mle_syntax mle_syntax = null;
	public c__pfc_u_tabpg_dwproperty_srvsyntax.c__cb_save cb_save = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_style", null, "pfc_u_tabpg_dwproperty_srvsyntax", -1, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Protected, "= - 1")]
	protected Sybase.PowerBuilder.PBInt ii_style = new Sybase.PowerBuilder.PBInt(-1);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_endtext", null, "pfc_u_tabpg_dwproperty_srvsyntax", "\r\n", typeof(Sybase.PowerBuilder.PBString), Sybase.PowerBuilder.PBModifier.Protected, "= '~r~n'")]
	protected Sybase.PowerBuilder.PBString is_endtext = new Sybase.PowerBuilder.PBString("\r\n");

	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertypopulate")]
	[Sybase.PowerBuilder.PBNoImplementAttribute]
	public override Sybase.PowerBuilder.PBInt pfc_propertypopulate()
	{
		return Sybase.PowerBuilder.PBInt.NullValue;	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.of_setsyntax(IS)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_setsyntax", new string[]{"string"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_setsyntax(Sybase.PowerBuilder.PBString as_syntax)
	{
		#line hidden
		#line 52
		mle_syntax.Text = as_syntax+ is_endtext;
		#line hidden
		#line 53
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.of_getsyntax(S)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getsyntax", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBString of_getsyntax()
	{
		#line hidden
		#line 46
		return mle_syntax.Text;
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.of_getinfo(IRCn_cst_infoattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getinfo", new string[]{"ref n_cst_infoattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getinfo_1_920697064<T0>(ref T0 anv_infoattrib)
	{
		#line hidden
		#line 49
		anv_infoattrib.is_name = new Sybase.PowerBuilder.PBString("DW Property Syntax Tab");
		#line hidden
		#line 50
		anv_infoattrib.is_description = new Sybase.PowerBuilder.PBString("DW Property Syntax Tab");
		#line hidden
		#line 52
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.of_getpropertyinfo(IRCn_cst_propertyattrib.)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_getpropertyinfo", new string[]{"ref n_cst_propertyattrib"}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public override Sybase.PowerBuilder.PBInt of_getpropertyinfo_1_66237089<T0>(ref T0 anv_attrib)
	{
		#line hidden
		c__n_cst_infoattrib lnv_infoattrib = (c__n_cst_infoattrib) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_infoattrib));
		#line 51
		this.of_getinfo_1_920697064(ref lnv_infoattrib);
		#line hidden
		#line 52
		anv_attrib.is_name = lnv_infoattrib.is_name;
		#line hidden
		#line 53
		anv_attrib.is_description = lnv_infoattrib.is_description;
		#line hidden
		#line 56
		anv_attrib.is_propertytabtext = new Sybase.PowerBuilder.PBString("Syntax");
		#line hidden
		#line 58
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
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
		this.mle_syntax = (c__mle_syntax)this.CreateInstance(this, "c__mle_syntax");
		#line hidden
		#line hidden
		this.cb_save = (c__cb_save)this.CreateInstance(this, "c__cb_save");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.mle_syntax);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cb_save);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.mle_syntax);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cb_save);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.mle_syntax"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="mle_syntax")]
	public class c__mle_syntax : c__u_mle
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__mle_syntax()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.cb_save"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cb_save")]
	public class c__cb_save : c__u_cb
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_srvsyntax.cb_save.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBString title = new Sybase.PowerBuilder.PBString("Save PowerScript File");
			Sybase.PowerBuilder.PBString ls_path_filename = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_filename = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_text = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_filenumber = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 52
			Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
			#line hidden
			#line 55
			li_rc = Sybase.PowerBuilder.WPF.PBSystemFunctions.GetFileSaveName(title, ref ls_path_filename, ref ls_filename, new Sybase.PowerBuilder.PBString("TXT"), new Sybase.PowerBuilder.PBString("Text Files (*.TXT), *.TXT"));
			#line hidden
			#line 58
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 60
				if (Sybase.PowerBuilder.WPF.PBSystemFunctions.FileExists(ls_path_filename))
				#line hidden
				{
					#line 64
					if ((Sybase.PowerBuilder.PBBoolean)(this.of_messagebox(new Sybase.PowerBuilder.PBString("pfc_dwpropertysyntax_replacefile"), title, new Sybase.PowerBuilder.PBString("Replace existing file ")+ ls_path_filename, (new Sybase.PowerBuilder.PBIconValue(Sybase.PowerBuilder.PBIcon.Question)), (new Sybase.PowerBuilder.PBButtonValue(Sybase.PowerBuilder.PBButton.YesNo)), new Sybase.PowerBuilder.PBInt(1)) == new Sybase.PowerBuilder.PBInt(2)))
					#line hidden
					{
						#line 66
						return (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1));
						#line hidden
					}
				}
				#line 71
				Sybase.PowerBuilder.WPF.PBSystemFunctions.SetPointer((new Sybase.PowerBuilder.PBPointerValue(Sybase.PowerBuilder.PBPointer.HourGlass)));
				#line hidden
				#line 72
				li_filenumber = Sybase.PowerBuilder.WPF.PBSystemFunctions.FileOpen(ls_path_filename, (new Sybase.PowerBuilder.PBFileModeValue(Sybase.PowerBuilder.PBFileMode.StreamMode)), (new Sybase.PowerBuilder.PBFileAccessValue(Sybase.PowerBuilder.PBFileAccess.Write)), (new Sybase.PowerBuilder.PBFileLockValue(Sybase.PowerBuilder.PBFileLock.LockWrite)), (new Sybase.PowerBuilder.PBWriteModeValue(Sybase.PowerBuilder.PBWriteMode.Replace)));
				#line hidden
				#line 73
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_filenumber)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 74
					ls_text = ((c__pfc_u_tabpg_dwproperty_srvsyntax)(Parent)).mle_syntax.Text;
					#line hidden
					#line 75
					Sybase.PowerBuilder.WPF.PBSystemFunctions.FileWrite(li_filenumber, ls_text);
					#line hidden
					#line 76
					Sybase.PowerBuilder.WPF.PBSystemFunctions.FileClose(li_filenumber);
					#line hidden
				}
			}
			#line 81
			return (Sybase.PowerBuilder.PBLong)(li_rc);
			#line hidden
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cb_save()
		{
			_init();
		}

	}


	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);

		OnInitialUpdate();
	}

	public c__pfc_u_tabpg_dwproperty_srvsyntax()
	{
		_init();
	}

}
 