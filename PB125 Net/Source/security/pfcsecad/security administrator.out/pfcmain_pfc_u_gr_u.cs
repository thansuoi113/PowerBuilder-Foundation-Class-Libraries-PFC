//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcmain.pbl\\pfcmain.pblx\\pfc_u_gr.sru"
#line hidden
#line 1 "pfc_u_gr"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_gr",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcmain.pbl\\pfcmain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_gr")]
public class c__pfc_u_gr : Sybase.PowerBuilder.WPF.PBGraph
{
	#line hidden

	#line 1 "pfc_u_gr.of_getparentwindow(IRCwindow.)"
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

	#line 1 "pfc_u_gr.of_messagebox(ISSSCicon.Cbutton.I)"
	#line hidden
	[Sybase.PowerBuilder.PBFunctionAttribute("of_messagebox", new string[]{"string", "string", "string", "icon", "button", "integer"}, Sybase.PowerBuilder.PBModifier.Protected, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
	public virtual Sybase.PowerBuilder.PBInt of_messagebox(Sybase.PowerBuilder.PBString as_id, Sybase.PowerBuilder.PBString as_title, Sybase.PowerBuilder.PBString as_text, Sybase.PowerBuilder.PBIconValue ae_icon, Sybase.PowerBuilder.PBButtonValue ae_button, Sybase.PowerBuilder.PBInt ai_default)
	{
		#line hidden
		#line 53
		return Sybase.PowerBuilder.WPF.PBSystemFunctions.MessageBox(as_title, as_text, ae_icon, ae_button, ai_default);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		TitleDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		LegendDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		PieDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Series = (Sybase.PowerBuilder.PBGRAxis)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRAxis));
		#line hidden
		#line hidden
		Series.DispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Series.LabelDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Category = (Sybase.PowerBuilder.PBGRAxis)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRAxis));
		#line hidden
		#line hidden
		Category.DispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Category.LabelDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Values = (Sybase.PowerBuilder.PBGRAxis)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRAxis));
		#line hidden
		#line hidden
		Values.DispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		Values.LabelDispAttr = (Sybase.PowerBuilder.PBGRDispAttr)this.CreateInstance(typeof(Sybase.PowerBuilder.PBGRDispAttr));
		#line hidden
		#line hidden
		TitleDispAttr.Weight = new Sybase.PowerBuilder.PBInt(700);
		#line hidden
		#line hidden
		TitleDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		TitleDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		TitleDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		TitleDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		TitleDispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Center));
		#line hidden
		#line hidden
		TitleDispAttr.TextColor = new Sybase.PowerBuilder.PBLong(33554432);
		#line hidden
		#line hidden
		TitleDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		TitleDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		TitleDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("title");
		#line hidden
		#line hidden
		TitleDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Category.Label = new Sybase.PowerBuilder.PBString("(None)");
		#line hidden
		#line hidden
		Category.AutoScale = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Category.ShadeBackEdge = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Category.SecondaryLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Category.MajorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Category.MinorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Category.DropLines = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Category.OriginLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Category.MajorTic = (new Sybase.PowerBuilder.PBGRTicTypeValue(Sybase.PowerBuilder.PBGRTicType.Outside));
		#line hidden
		#line hidden
		Category.DataType = (new Sybase.PowerBuilder.PBGRAxisDataTypeValue(Sybase.PowerBuilder.PBGRAxisDataType.AdtText));
		#line hidden
		#line hidden
		Category.DispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Category.DispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Category.DispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Category.DispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Category.DispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Category.DispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Center));
		#line hidden
		#line hidden
		Category.DispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Category.DispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Category.DispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("category");
		#line hidden
		#line hidden
		Category.DispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Category.LabelDispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Category.LabelDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Category.LabelDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Category.LabelDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Category.LabelDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Category.LabelDispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Center));
		#line hidden
		#line hidden
		Category.LabelDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Category.LabelDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Category.LabelDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("categoryaxislabel");
		#line hidden
		#line hidden
		Category.LabelDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Values.Label = new Sybase.PowerBuilder.PBString("(None)");
		#line hidden
		#line hidden
		Values.AutoScale = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Values.SecondaryLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Values.MajorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Values.MinorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Values.DropLines = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Values.MajorTic = (new Sybase.PowerBuilder.PBGRTicTypeValue(Sybase.PowerBuilder.PBGRTicType.Outside));
		#line hidden
		#line hidden
		Values.DataType = (new Sybase.PowerBuilder.PBGRAxisDataTypeValue(Sybase.PowerBuilder.PBGRAxisDataType.AdtDouble));
		#line hidden
		#line hidden
		Values.DispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Values.DispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Values.DispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Values.DispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Values.DispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Values.DispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Right));
		#line hidden
		#line hidden
		Values.DispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Values.DispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Values.DispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("value");
		#line hidden
		#line hidden
		Values.DispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Values.LabelDispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Values.LabelDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Values.LabelDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Values.LabelDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Values.LabelDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Values.LabelDispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Center));
		#line hidden
		#line hidden
		Values.LabelDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Values.LabelDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Values.LabelDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("valuesaxislabel");
		#line hidden
		#line hidden
		Values.LabelDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Values.LabelDispAttr.Escapement = new Sybase.PowerBuilder.PBInt(900);
		#line hidden
		#line hidden
		Series.Label = new Sybase.PowerBuilder.PBString("(None)");
		#line hidden
		#line hidden
		Series.AutoScale = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Series.SecondaryLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Series.MajorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Series.MinorGridLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Series.DropLines = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Series.OriginLine = (new Sybase.PowerBuilder.PBLineStyleValue(Sybase.PowerBuilder.PBLineStyle.Transparent));
		#line hidden
		#line hidden
		Series.MajorTic = (new Sybase.PowerBuilder.PBGRTicTypeValue(Sybase.PowerBuilder.PBGRTicType.Outside));
		#line hidden
		#line hidden
		Series.DataType = (new Sybase.PowerBuilder.PBGRAxisDataTypeValue(Sybase.PowerBuilder.PBGRAxisDataType.AdtText));
		#line hidden
		#line hidden
		Series.DispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Series.DispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Series.DispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Series.DispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Series.DispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Series.DispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Series.DispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Series.DispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("series");
		#line hidden
		#line hidden
		Series.DispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		Series.LabelDispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		Series.LabelDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		Series.LabelDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		Series.LabelDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		Series.LabelDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		Series.LabelDispAttr.Alignment = (new Sybase.PowerBuilder.PBAlignmentValue(Sybase.PowerBuilder.PBAlignment.Center));
		#line hidden
		#line hidden
		Series.LabelDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		Series.LabelDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		Series.LabelDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("seriesaxislabel");
		#line hidden
		#line hidden
		Series.LabelDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		LegendDispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		LegendDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		LegendDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		LegendDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		LegendDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		LegendDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		LegendDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		LegendDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("series");
		#line hidden
		#line hidden
		LegendDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
		#line hidden
		PieDispAttr.Weight = new Sybase.PowerBuilder.PBInt(400);
		#line hidden
		#line hidden
		PieDispAttr.FaceName = new Sybase.PowerBuilder.PBString("Arial");
		#line hidden
		#line hidden
		PieDispAttr.FontCharSet = (new Sybase.PowerBuilder.PBFontCharSetValue(Sybase.PowerBuilder.PBFontCharSet.DefaultCharSet));
		#line hidden
		#line hidden
		PieDispAttr.FontFamily = (new Sybase.PowerBuilder.PBFontFamilyValue(Sybase.PowerBuilder.PBFontFamily.Swiss));
		#line hidden
		#line hidden
		PieDispAttr.FontPitch = (new Sybase.PowerBuilder.PBFontPitchValue(Sybase.PowerBuilder.PBFontPitch.Variable));
		#line hidden
		#line hidden
		PieDispAttr.BackColor = new Sybase.PowerBuilder.PBLong(536870912);
		#line hidden
		#line hidden
		PieDispAttr.Format = new Sybase.PowerBuilder.PBString("[General]");
		#line hidden
		#line hidden
		PieDispAttr.DisplayExpression = new Sybase.PowerBuilder.PBString("if(seriescount > 1, series,string(percentofseries,\"0.00%\"))");
		#line hidden
		#line hidden
		PieDispAttr.AutoSize = new Sybase.PowerBuilder.PBBoolean(true);
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(TitleDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(LegendDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(PieDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Series.DispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Series.LabelDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Series);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Category.DispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Category.LabelDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Category);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Values.DispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Values.LabelDispAttr);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(Values);
		#line hidden
	}

	#line 1 "pfc_u_gr.getfocus"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("getfocus")]
	[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnsetfocus)]
	public override Sybase.PowerBuilder.PBLong getfocus()
	{
		#line hidden
		Sybase.PowerBuilder.WPF.PBWindow lw_parent = null;
		Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
		#line 46
		if (c__pfcsecurity_admin.GetCurrentApplication().gnv_app.of_getmicrohelp())
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
				Sybase.PowerBuilder.PBMethod.InvokeDynamic(lw_parent, "pfc_controlgotfocus", new Sybase.PowerBuilder.PBArgument[1] {new Sybase.PowerBuilder.PBArgument(this, Sybase.PowerBuilder.ParameterStyle.ByValue, typeof(c__pfc_u_gr))}, 0);
				#line hidden
			}
		}
		return new Sybase.PowerBuilder.PBLong(0);
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
		this.GetFocusEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.getfocus);

		OnInitialUpdate();
	}

	public c__pfc_u_gr()
	{
		_init();
	}

}
 