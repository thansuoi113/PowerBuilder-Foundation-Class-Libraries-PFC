//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx\\pfc_n_cst_errorattrib.sru"
#line hidden
#line 1 "pfc_n_cst_errorattrib"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_n_cst_errorattrib",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\pfcmsg\\pfcapsrv.pbl\\pfcapsrv.pblx",null)]
[Sybase.PowerBuilder.PBAutoInstantiate]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_n_cst_errorattrib")]
public class c__pfc_n_cst_errorattrib : c__n_cst_baseattrib
{
	#line hidden
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_rc", null, "pfc_n_cst_errorattrib", -99, typeof(Sybase.PowerBuilder.PBInt), Sybase.PowerBuilder.PBModifier.Public, "= - 99")]
	public Sybase.PowerBuilder.PBInt ii_rc = new Sybase.PowerBuilder.PBInt(-99);
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_buttonclicked", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt ii_buttonclicked = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_title", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_title = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_text", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_text = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ie_icon", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBIconValue ie_icon = new Sybase.PowerBuilder.PBIconValue();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ie_buttonstyle", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBButtonValue ie_buttonstyle = new Sybase.PowerBuilder.PBButtonValue();
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_default", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt ii_default = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_severity", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt ii_severity = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_print", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_print = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_userinput", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBBoolean ib_userinput = Sybase.PowerBuilder.PBBoolean.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_usertext", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_usertext = Sybase.PowerBuilder.PBString.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ii_timeout", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBInt ii_timeout = Sybase.PowerBuilder.PBInt.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "idt_date", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBDateTime idt_date = Sybase.PowerBuilder.PBDateTime.DefaultValue;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "is_user", null, "pfc_n_cst_errorattrib", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
	public Sybase.PowerBuilder.PBString is_user = Sybase.PowerBuilder.PBString.DefaultValue;

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

	public override object Clone()
	{
		c__pfc_n_cst_errorattrib vv = (c__pfc_n_cst_errorattrib)base.Clone();
 		vv.ii_rc = ii_rc;
		vv.ii_buttonclicked = ii_buttonclicked;
		vv.is_title = is_title;
		vv.is_text = is_text;
		vv.ie_icon = ie_icon;
		vv.ie_buttonstyle = ie_buttonstyle;
		vv.ii_default = ii_default;
		vv.ii_severity = ii_severity;
		vv.ib_print = ib_print;
		vv.ib_userinput = ib_userinput;
		vv.is_usertext = is_usertext;
		vv.ii_timeout = ii_timeout;
		vv.idt_date = idt_date;
		vv.is_user = is_user;
		return vv;
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__pfc_n_cst_errorattrib()
	{
		_init();
	}


	public static explicit operator c__pfc_n_cst_errorattrib(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
		{
			Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
			c__pfc_n_cst_errorattrib vv = new c__pfc_n_cst_errorattrib();
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
			return (c__pfc_n_cst_errorattrib) v.Value;
		}
	}
}
 