//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx\\pfc_u_tabpg_dwproperty_status.sru"
#line hidden
#line 1 "pfc_u_tabpg_dwproperty_status"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("pfc_u_tabpg_dwproperty_status",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\pfc\\12.net\\examples\\pfcutil.pbl\\pfcutil.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="pfc_u_tabpg_dwproperty_status")]
public class c__pfc_u_tabpg_dwproperty_status : c__u_tabpg_dwproperty_base
{
	#line hidden
	public c__pfc_u_tabpg_dwproperty_status.c__gb_column gb_column = null;
	public c__pfc_u_tabpg_dwproperty_status.c__dw_requestorview dw_requestorview = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_rownumber_t st_rownumber_t = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_rowstatus st_rowstatus = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_columnname_t st_columnname_t = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_columnstatus st_columnstatus = null;
	public c__pfc_u_tabpg_dwproperty_status.c__ddlb_rowstatus ddlb_rowstatus = null;
	public c__pfc_u_tabpg_dwproperty_status.c__ddlb_columnstatus ddlb_columnstatus = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_rownumber st_rownumber = null;
	public c__pfc_u_tabpg_dwproperty_status.c__st_columnname st_columnname = null;
	public c__pfc_u_tabpg_dwproperty_status.c__cbx_assistrow cbx_assistrow = null;
	public c__pfc_u_tabpg_dwproperty_status.c__gb_row gb_row = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "ib_assistrowstatus", null, "pfc_u_tabpg_dwproperty_status", null, null, Sybase.PowerBuilder.PBModifier.Protected, "")]
	protected Sybase.PowerBuilder.PBBoolean ib_assistrowstatus = Sybase.PowerBuilder.PBBoolean.DefaultValue;

	#line 1 "pfc_u_tabpg_dwproperty_status.pfc_propertystats"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertystats")]
	public virtual Sybase.PowerBuilder.PBInt pfc_propertystats()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBLong ll_currow = Sybase.PowerBuilder.PBLong.DefaultValue;
		Sybase.PowerBuilder.PBString ls_colname = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBDWItemStatusValue le_status = new Sybase.PowerBuilder.PBDWItemStatusValue();
		Sybase.PowerBuilder.PBString ls_status = Sybase.PowerBuilder.PBString.DefaultValue;
		c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
		#line 51
		ll_currow = dw_requestorview.GetRow();
		#line hidden
		#line 52
		ls_colname = dw_requestorview.GetColumnName();
		#line hidden
		#line 54
		if ((Sybase.PowerBuilder.PBBoolean)((ll_currow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_colname)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
		#line hidden
		{
			#line 57
			st_rownumber.Text = Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)(ll_currow))));
			#line hidden
			#line 58
			le_status = dw_requestorview.GetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
			#line hidden
			#line 59
			ls_status = lnv_conversion.of_string(le_status);
			#line hidden
			#line 60
			li_rc = ddlb_rowstatus.SelectItem(ls_status, new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 61
			ddlb_rowstatus.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
			#line 64
			st_columnname.Text = ls_colname;
			#line hidden
			#line 65
			le_status = dw_requestorview.GetItemStatus(ll_currow, ls_colname, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
			#line hidden
			#line 66
			ls_status = lnv_conversion.of_string(le_status);
			#line hidden
			#line 67
			li_rc = ddlb_columnstatus.SelectItem(ls_status, new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 68
			ddlb_columnstatus.Enabled = new Sybase.PowerBuilder.PBBoolean(true);
			#line hidden
		}
		else
		{
			#line 73
			st_rownumber.Text = new Sybase.PowerBuilder.PBString("N/A");
			#line hidden
			#line 74
			ddlb_rowstatus.SelectItem(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 75
			ddlb_rowstatus.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
			#line 78
			st_columnname.Text = new Sybase.PowerBuilder.PBString("N/A");
			#line hidden
			#line 79
			ddlb_columnstatus.SelectItem(new Sybase.PowerBuilder.PBInt(0));
			#line hidden
			#line 80
			ddlb_columnstatus.Enabled = new Sybase.PowerBuilder.PBBoolean(false);
			#line hidden
		}
		#line 83
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
		this.gb_column = (c__gb_column)this.CreateInstance(this, "c__gb_column");
		#line hidden
		#line hidden
		this.dw_requestorview = (c__dw_requestorview)this.CreateInstance(this, "c__dw_requestorview");
		#line hidden
		#line hidden
		this.st_rownumber_t = (c__st_rownumber_t)this.CreateInstance(this, "c__st_rownumber_t");
		#line hidden
		#line hidden
		this.st_rowstatus = (c__st_rowstatus)this.CreateInstance(this, "c__st_rowstatus");
		#line hidden
		#line hidden
		this.st_columnname_t = (c__st_columnname_t)this.CreateInstance(this, "c__st_columnname_t");
		#line hidden
		#line hidden
		this.st_columnstatus = (c__st_columnstatus)this.CreateInstance(this, "c__st_columnstatus");
		#line hidden
		#line hidden
		this.ddlb_rowstatus = (c__ddlb_rowstatus)this.CreateInstance(this, "c__ddlb_rowstatus");
		#line hidden
		#line hidden
		this.ddlb_columnstatus = (c__ddlb_columnstatus)this.CreateInstance(this, "c__ddlb_columnstatus");
		#line hidden
		#line hidden
		this.st_rownumber = (c__st_rownumber)this.CreateInstance(this, "c__st_rownumber");
		#line hidden
		#line hidden
		this.st_columnname = (c__st_columnname)this.CreateInstance(this, "c__st_columnname");
		#line hidden
		#line hidden
		this.cbx_assistrow = (c__cbx_assistrow)this.CreateInstance(this, "c__cbx_assistrow");
		#line hidden
		#line hidden
		this.gb_row = (c__gb_row)this.CreateInstance(this, "c__gb_row");
		#line hidden
		#line hidden
		icurrent = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(this.Control)));
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_column);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(2)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.dw_requestorview);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(3)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_rownumber_t);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(4)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_rowstatus);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(5)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_columnname_t);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(6)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_columnstatus);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(7)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_rowstatus);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(8)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.ddlb_columnstatus);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(9)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_rownumber);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(10)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.st_columnname);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(11)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.cbx_assistrow);
		#line hidden
		#line hidden
		this.Control[this.Control.Extend((Sybase.PowerBuilder.PBLong)(icurrent)+ (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(12)))] = (Sybase.PowerBuilder.WPF.PBWindowObject)(this.gb_row);
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
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_column);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.dw_requestorview);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_rownumber_t);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_rowstatus);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_columnname_t);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_columnstatus);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_rowstatus);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.ddlb_columnstatus);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_rownumber);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.st_columnname);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.cbx_assistrow);
		#line hidden
		#line hidden
		Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(this.gb_row);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_status.pfc_propertyopen"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyopen")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyopen()
	{
		#line hidden
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyopen();
		#line hidden
		#line 44
		this.pfc_propertystats();
		#line hidden
		#line 46
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_status.pfc_propertyinitialize"
	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyinitialize")]
	public override Sybase.PowerBuilder.PBInt pfc_propertyinitialize(c__n_cst_dwpropertyattrib anv_attrib)
	{
		#line hidden
		Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
		Sybase.PowerBuilder.PBString ls_dataobject = Sybase.PowerBuilder.PBString.DefaultValue;
		Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
		#line 1
		ancestorreturnvalue = base.pfc_propertyinitialize(anv_attrib);
		#line hidden
		#line 50
		if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(inv_attrib.is_dataobjectstatus))> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 51
			ls_dataobject = Sybase.PowerBuilder.WPF.PBSystemFunctions.Trim(inv_attrib.is_dataobjectstatus);
			#line hidden
		}
		else
		{
			#line 53
			ls_dataobject = idw_requestor.DataObject;
			#line hidden
		}
		#line 57
		dw_requestorview.DataObject = ls_dataobject;
		#line hidden
		#line 58
		li_rc = idw_requestor.ShareData((Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_u_tabpg_dwproperty_status.c__dw_requestorview)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dw_requestorview)))));
		#line hidden
		#line 59
		if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
		#line hidden
		{
			#line 61
			ls_dataobject = idw_requestor.DataObject;
			#line hidden
			#line 62
			dw_requestorview.DataObject = ls_dataobject;
			#line hidden
			#line 63
			li_rc = idw_requestor.ShareData((Sybase.PowerBuilder.IPBDataWindowControl)(((c__pfc_u_tabpg_dwproperty_status.c__dw_requestorview)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(dw_requestorview)))));
			#line hidden
			#line 64
			if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)<= (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 65
				return new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
			}
		}
		#line 70
		li_rc = dw_requestorview.pfc_propertyunprotect();
		#line hidden
		#line 72
		return new Sybase.PowerBuilder.PBInt(1);
		#line hidden
	}

	#line 1 "pfc_u_tabpg_dwproperty_status.gb_column"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_column")]
	public class c__gb_column : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_column()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="dw_requestorview")]
	public class c__dw_requestorview : c__u_dw
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.pfc_propertyunprotect"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_propertyunprotect")]
		public virtual Sybase.PowerBuilder.PBInt pfc_propertyunprotect()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_upper = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_cnt = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt li_value = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBString ls_rc = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_modifyexp = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBArray ls_collist = new Sybase.PowerBuilder.PBUnboundedStringArray();
			#line 54
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsNull((Sybase.PowerBuilder.PBAny)((new Sybase.PowerBuilder.PBAny(((c__n_cst_dwsrv_reqcolumn)(Sybase.PowerBuilder.PBSystemFunctions.PBCheckNull(inv_reqcolumn)))))))| !(Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_reqcolumn)))))
			#line hidden
			{
				#line 55
				return new Sybase.PowerBuilder.PBInt(-1);
				#line hidden
			}
			#line 59
			li_rc = of_getobjects_4_345252223_4_pf1632708430(inv_reqcolumn, ref ls_collist, new Sybase.PowerBuilder.PBString("column"), new Sybase.PowerBuilder.PBString("*"), new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 60
			li_upper = (Sybase.PowerBuilder.PBInt)(Sybase.PowerBuilder.WPF.PBSystemFunctions.UpperBound((Sybase.PowerBuilder.PBAny)(ls_collist)));
			#line hidden
			#line 63
			for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
			#line hidden
			{
					#line 64
					ls_modifyexp += ((Sybase.PowerBuilder.PBString)ls_collist[(Sybase.PowerBuilder.PBLong)(li_cnt)])+ new Sybase.PowerBuilder.PBString(".Protect = 0 ");
					#line hidden
			}
			#line 66
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_modifyexp)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 67
				ls_rc = this.Modify(ls_modifyexp);
				#line hidden
				#line 68
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 68
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
			}
			#line 72
			ls_modifyexp = new Sybase.PowerBuilder.PBString("");
			#line hidden
			#line 73
			for (li_cnt = new Sybase.PowerBuilder.PBInt(1);li_cnt <= li_upper;li_cnt = li_cnt + 1)
			#line hidden
			{
					#line 74
					ls_modifyexp += ((((Sybase.PowerBuilder.PBString)ls_collist[(Sybase.PowerBuilder.PBLong)(li_cnt)])+ new Sybase.PowerBuilder.PBString(".TabSequence="))+ Sybase.PowerBuilder.WPF.PBSystemFunctions.String((Sybase.PowerBuilder.PBAny)(((Sybase.PowerBuilder.PBAny)((Sybase.PowerBuilder.PBLong)(li_cnt)+ (Sybase.PowerBuilder.PBLong)(li_value))))))+ new Sybase.PowerBuilder.PBString(" ");
					#line hidden
					#line 75
					li_value += new Sybase.PowerBuilder.PBInt(10);
					#line hidden
			}
			#line 77
			if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_modifyexp)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 78
				ls_rc = this.Modify(ls_modifyexp);
				#line hidden
				#line 79
				if ((Sybase.PowerBuilder.PBBoolean)(Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 79
					return new Sybase.PowerBuilder.PBInt(-1);
					#line hidden
				}
			}
			#line 82
			return new Sybase.PowerBuilder.PBInt(1);
			#line hidden
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.constructor"
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
			#line 39
			this.of_setreqcolumn(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 42
			this.of_setrowselect(new Sybase.PowerBuilder.PBBoolean(true));
			#line hidden
			#line 43
			if (Sybase.PowerBuilder.WPF.PBSystemFunctions.IsValid((Sybase.PowerBuilder.PBPowerObject)(inv_rowselect)))
			#line hidden
			{
				#line 44
				inv_rowselect.of_setstyle(c__n_cst_dwsrv_rowselection.single);
				#line hidden
			}
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.pfc_deleterow"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_deleterow")]
		public override Sybase.PowerBuilder.PBInt pfc_deleterow()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBInt ancestorreturnvalue = Sybase.PowerBuilder.PBInt.DefaultValue;
			#line 42
			li_rc = base.pfc_deleterow();
			#line hidden
			#line 45
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			#line 47
			return li_rc;
			#line hidden
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.pfc_addrow"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_addrow")]
		public override Sybase.PowerBuilder.PBLong pfc_addrow()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 42
			li_rc = (Sybase.PowerBuilder.PBInt)(base.pfc_addrow());
			#line hidden
			#line 45
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			#line 47
			return (Sybase.PowerBuilder.PBLong)(li_rc);
			#line hidden
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.pfc_insertrow"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_insertrow")]
		public override Sybase.PowerBuilder.PBLong pfc_insertrow()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 42
			li_rc = (Sybase.PowerBuilder.PBInt)(base.pfc_insertrow());
			#line hidden
			#line 45
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			#line 47
			return (Sybase.PowerBuilder.PBLong)(li_rc);
			#line hidden
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.itemchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("itemchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnitemchange)]
		public override Sybase.PowerBuilder.PBLong itemchanged(Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo, Sybase.PowerBuilder.PBString data)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.itemchanged(row, dwo, data);
			#line hidden
			#line 39
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.PostMethod(((c__pfc_u_tabpg_dwproperty_status)(this.Parent)), "pfc_propertystats", new Sybase.PowerBuilder.PBArgument[0]{					});
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.pfc_restorerow"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("pfc_restorerow")]
		public override Sybase.PowerBuilder.PBLong pfc_restorerow()
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 42
			li_rc = (Sybase.PowerBuilder.PBInt)(base.pfc_restorerow());
			#line hidden
			#line 45
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			#line 47
			return (Sybase.PowerBuilder.PBLong)(li_rc);
			#line hidden
		}

		#line 1 "pfc_u_tabpg_dwproperty_status.dw_requestorview.itemfocuschanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("itemfocuschanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_dwnitemchangefocus)]
		public override Sybase.PowerBuilder.PBLong itemfocuschanged(Sybase.PowerBuilder.PBLong row, Sybase.PowerBuilder.WPF.PBDWObject dwo)
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.itemfocuschanged(row, dwo);
			#line hidden
			#line 39
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.PostMethod(((c__pfc_u_tabpg_dwproperty_status)(this.Parent)), "pfc_propertystats", new Sybase.PowerBuilder.PBArgument[0]{					});
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

	public Sybase.PowerBuilder.PBInt of_getobjects_4_345252223_4_pf1632708430(c__pfc_n_cst_dwsrv this__object, ref Sybase.PowerBuilder.PBArray as_objlist, Sybase.PowerBuilder.PBString as_objtype, Sybase.PowerBuilder.PBString as_band, Sybase.PowerBuilder.PBBoolean ab_visibleonly)
	{
		Sybase.PowerBuilder.PBInt return_value = this__object.of_getobjects_4_345252223(ref as_objlist, as_objtype, as_band, ab_visibleonly);
		return return_value;
	}


		void _init()
		{
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
			this.ItemChangedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_ldws(this.itemchanged);
			this.ItemFocusChangedEvent += new Sybase.PowerBuilder.WPF.PBM_EventHandler_dwn_ldw(this.itemfocuschanged);

			OnInitialUpdate();
		}

		public c__dw_requestorview()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_rownumber_t"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_rownumber_t")]
	public class c__st_rownumber_t : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_rownumber_t()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_rowstatus"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_rowstatus")]
	public class c__st_rowstatus : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_rowstatus()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_columnname_t"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_columnname_t")]
	public class c__st_columnname_t : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_columnname_t()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_columnstatus"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_columnstatus")]
	public class c__st_columnstatus : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_columnstatus()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.ddlb_rowstatus"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_rowstatus")]
	public class c__ddlb_rowstatus : c__u_ddlb
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_status.ddlb_rowstatus.selectionchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_cbnselchange)]
		public override Sybase.PowerBuilder.PBLong selectionchanged(Sybase.PowerBuilder.PBInt index)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_currow = Sybase.PowerBuilder.PBLong.DefaultValue;
			Sybase.PowerBuilder.PBString ls_desiredstatus = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBDWItemStatusValue le_currentstatus = new Sybase.PowerBuilder.PBDWItemStatusValue();
			Sybase.PowerBuilder.PBDWItemStatusValue le_desiredstatus = new Sybase.PowerBuilder.PBDWItemStatusValue();
			c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanged(index);
			#line hidden
			#line 74
			ll_currow = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.GetRow();
			#line hidden
			#line 76
			if ((Sybase.PowerBuilder.PBBoolean)(ll_currow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
			#line hidden
			{
				#line 78
				ls_desiredstatus = this.Text;
				#line hidden
				#line 79
				li_rc = lnv_conversion.of_dwitemstatus(ls_desiredstatus, ref le_desiredstatus);
				#line hidden
				#line 82
				le_currentstatus = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.GetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)));
				#line hidden
				#line 84
				if ((Sybase.PowerBuilder.PBBoolean)(le_currentstatus == le_desiredstatus))
				#line hidden
				{
					#line 86
					return new Sybase.PowerBuilder.PBLong(0);
					#line hidden
				}
				#line 89
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 90
					if (((c__pfc_u_tabpg_dwproperty_status)(Parent)).ib_assistrowstatus)
					#line hidden
					{
						#line 92
						if ((Sybase.PowerBuilder.PBBoolean)((le_currentstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.New)))& (le_desiredstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NotModified)))))
						#line hidden
						{
							#line 93
							li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.DataModified)));
							#line hidden
						}
						#line 94
						else if ((Sybase.PowerBuilder.PBBoolean)((le_currentstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NewModified)))& (le_desiredstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.New)))))
						#line hidden
						{
							#line 95
							li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.DataModified)));
							#line hidden
							#line 96
							li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NotModified)));
							#line hidden
						}
						#line 97
						else if ((Sybase.PowerBuilder.PBBoolean)((le_currentstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NewModified)))& (le_desiredstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NotModified)))))
						#line hidden
						{
							#line 98
							li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.DataModified)));
							#line hidden
						}
						#line 99
						else if ((Sybase.PowerBuilder.PBBoolean)((le_currentstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.DataModified)))& (le_desiredstatus == (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.New)))))
						#line hidden
						{
							#line 100
							li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), (new Sybase.PowerBuilder.PBDWItemStatusValue(Sybase.PowerBuilder.PBDWItemStatus.NotModified)));
							#line hidden
						}
					}
					#line 105
					li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, new Sybase.PowerBuilder.PBInt(0), (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), le_desiredstatus);
					#line hidden
				}
			}
			#line 111
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.SelectionChangedEvent += new Sybase.PowerBuilder.PBM_EventHandler_i(this.selectionchanged);

			OnInitialUpdate();
		}

		public c__ddlb_rowstatus()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.ddlb_columnstatus"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="ddlb_columnstatus")]
	public class c__ddlb_columnstatus : c__u_ddlb
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_status.ddlb_columnstatus.selectionchanged"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("selectionchanged")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_cbnselchange)]
		public override Sybase.PowerBuilder.PBLong selectionchanged(Sybase.PowerBuilder.PBInt index)
		{
			#line hidden
			Sybase.PowerBuilder.PBInt li_rc = Sybase.PowerBuilder.PBInt.DefaultValue;
			Sybase.PowerBuilder.PBLong ll_currow = Sybase.PowerBuilder.PBLong.DefaultValue;
			Sybase.PowerBuilder.PBString ls_colname = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBString ls_status = Sybase.PowerBuilder.PBString.DefaultValue;
			Sybase.PowerBuilder.PBDWItemStatusValue le_status = new Sybase.PowerBuilder.PBDWItemStatusValue();
			c__n_cst_conversion lnv_conversion = (c__n_cst_conversion) Sybase.PowerBuilder.PBSessionBase.GetCurrentSession().CreateInstance(typeof(c__n_cst_conversion));
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.selectionchanged(index);
			#line hidden
			#line 47
			ll_currow = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.GetRow();
			#line hidden
			#line 48
			ls_colname = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.GetColumnName();
			#line hidden
			#line 50
			if ((Sybase.PowerBuilder.PBBoolean)((ll_currow> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))& (Sybase.PowerBuilder.WPF.PBSystemFunctions.Len(ls_colname)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0)))))
			#line hidden
			{
				#line 51
				ls_status = this.Text;
				#line hidden
				#line 52
				li_rc = lnv_conversion.of_dwitemstatus(ls_status, ref le_status);
				#line hidden
				#line 53
				if ((Sybase.PowerBuilder.PBBoolean)((Sybase.PowerBuilder.PBLong)(li_rc)> (Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(0))))
				#line hidden
				{
					#line 54
					li_rc = ((c__pfc_u_tabpg_dwproperty_status)(Parent)).dw_requestorview.SetItemStatus(ll_currow, ls_colname, (new Sybase.PowerBuilder.PBDWBufferValue(Sybase.PowerBuilder.PBDWBuffer.Primary)), le_status);
					#line hidden
				}
			}
			#line 59
			((c__pfc_u_tabpg_dwproperty_status)(this.Parent)).pfc_propertystats();
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.SelectionChangedEvent += new Sybase.PowerBuilder.PBM_EventHandler_i(this.selectionchanged);

			OnInitialUpdate();
		}

		public c__ddlb_columnstatus()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_rownumber"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_rownumber")]
	public class c__st_rownumber : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_rownumber()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.st_columnname"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="st_columnname")]
	public class c__st_columnname : Sybase.PowerBuilder.WPF.PBStaticText
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__st_columnname()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.cbx_assistrow"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="cbx_assistrow")]
	public class c__cbx_assistrow : c__u_cbx
	{
		#line hidden

		#line 1 "pfc_u_tabpg_dwproperty_status.cbx_assistrow.clicked"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("clicked")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_bnclicked)]
		public override Sybase.PowerBuilder.PBLong clicked()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 1
			ancestorreturnvalue = base.clicked();
			#line hidden
			#line 1
			((c__pfc_u_tabpg_dwproperty_status)(Parent)).ib_assistrowstatus = this.Checked;
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		void _init()
		{
			this.ClickedEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.clicked);

			OnInitialUpdate();
		}

		public c__cbx_assistrow()
		{
			_init();
		}

	}


	#line 1 "pfc_u_tabpg_dwproperty_status.gb_row"
	#line hidden
	[System.Diagnostics.DebuggerDisplay("",Type="gb_row")]
	public class c__gb_row : c__u_gb
	{
		#line hidden

		void _init()
		{

			OnInitialUpdate();
		}

		public c__gb_row()
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

	public c__pfc_u_tabpg_dwproperty_status()
	{
		_init();
	}

}
 