HA$PBExportHeader$w_msgs_sheet.srw
$PBExportComments$Main sheet in application
forward
global type w_msgs_sheet from w_sheet
end type
type dw_master from u_dw within w_msgs_sheet
end type
type dw_detail from u_dw within w_msgs_sheet
end type
type st_splitbar from u_st_splitbar within w_msgs_sheet
end type
end forward

global type w_msgs_sheet from w_sheet
int X=5
int Y=4
int Width=2802
int Height=1448
boolean TitleBar=true
string Title="Message Table Maintenance"
string MenuName="m_msgs_sheet"
WindowState WindowState=maximized!
event ue_reload ( )
event ue_test ( )
event ue_insert ( )
event ue_delete ( )
event ue_import ( )
event ue_export ( )
event pfc_reload ( )
event pfc_test ( )
event pfc_delete ( )
event ue_undelete ( )
event ue_sort ( )
event ue_filter ( )
event pfc_finddlg ( )
event ue_copy ( )
event ue_paste ( )
event ue_clear ( )
event pfc_undelete ( )
event type integer ue_undelete_toggle ( boolean ab_switch )
event pfc_replacedlg ( )
dw_master dw_master
dw_detail dw_detail
st_splitbar st_splitbar
end type
global w_msgs_sheet w_msgs_sheet

type variables
s_copystruct istr_blank, istr_copy
end variables

forward prototypes
public subroutine of_highlight (datawindow adw_dw, integer ai_row)
end prototypes

event ue_reload;call super::ue_reload;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_reload
//
//	Description:  	refreshes/retrieves the ds.
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.event pfc_retrieve()
end event

event ue_test;call super::ue_test;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  w_msgs_sheet	
//
// Method : pfc_test
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
// -------
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
n_cst_conversion lnv_conversion

IF dw_detail.Accepttext() <>1 Then Return

String  ls_title, ls_text, ls_button, ls_icon, ls_print
String  ls_userinput, ls_severity,ls_default
Icon    le_icon
Button  le_button
Integer li_default,li_row, li_severity
Boolean  lb_print, lb_userinput

li_row = dw_detail.GetRow()

// Check for no rows.
If li_row < 1 Then Return 

// Grab the stuff from the buffer as strings for debugging
// Use getitem string because dot notation seems to be hanging at times
//ls_title  = dw_detail.object.msgtitle[li_row]
ls_title  = dw_detail.GetItemString(li_row, "msgtitle")
//ls_text   = dw_detail.object.msgtext[li_row]
ls_text   = dw_detail.GetItemString(li_row, "msgtext")
//ls_icon = dw_detail.object.msgicon[li_row] 
ls_icon = dw_detail.GetItemString(li_row, "msgicon")
//ls_button = dw_detail.object.msgbutton[li_row]
ls_button = dw_detail.GetItemString(li_row, "msgbutton")
//ls_default = String(dw_detail.object.msgdefaultbutton[li_row])
ls_default = String(dw_detail.GetItemNumber(li_row, "msgdefaultbutton"))
//ls_severity = String(dw_detail.object.msgseverity[li_row])
ls_severity = String(dw_detail.GetItemNumber(li_row, "msgseverity"))
//ls_print = dw_detail.object.msgprint[li_row]
ls_print = dw_detail.GetItemString(li_row, "msgprint")
//ls_userinput = dw_detail.object.msguserinput[li_row]
ls_userinput = dw_detail.GetItemString(li_row, "msguserinput")

// is the debugger on?
If IsValid (gnv_app.inv_debug) THEN
	gnv_app.inv_error.of_message ("Applicaion Debugger","Title = "+ls_title+&
																			"~r~nText = "+ls_text+&
																			"~r~nIcons = "+ls_icon+&
																			"~r~nButtons = "+ls_button+&
																			"~r~nDefault = "+ls_default+&
																			"~r~nSeverity = "+ls_severity+&																			
																			"~r~nPrint = "+ls_print+&																			
																			"~r~nUser Input = "+ls_Userinput)
End IF

// Convert the enumerated and boolean variables
li_severity = Integer (ls_severity)
li_default = Integer (ls_default)
lnv_conversion.of_icon (ls_icon, le_icon) 
lnv_conversion.of_button(ls_button, le_button)
lb_print = (ls_print="Y")
lb_userinput = (ls_Userinput="Y")

// Display the error message
gnv_App.inv_error.of_message(ls_title, ls_text, le_icon,le_button,li_default,&
                                 li_severity, lb_print, lb_userinput)


end event

event ue_insert;call super::ue_insert;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_Insert
//
//	Description: Insert a row
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
Integer li_newrow

li_newrow = dw_detail.Event pfc_Insertrow()

dw_master.SetRow(li_newrow)
dw_detail.ScrollToRow(li_newrow)
of_highlight (dw_master,li_newrow)

// Fill in defaults
dw_detail.object.msgprint[li_newrow] = "N"
dw_detail.object.msguserinput[li_newrow] = "N"

// Set focus
dw_detail.SetFocus()
dw_detail.SetColumn("msgid")

end event

event ue_delete;call super::ue_delete;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_delete
//
//	Description:  	Delete a row
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.Event pfc_deleterow()

of_highlight (dw_master,dw_master.GetRow())


end event

event ue_import;call super::ue_import;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet
//
// Method : ue_import
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
SetPointer(HourGlass!)

String ls_filename

SetNull (ls_filename)

IF dw_master.ImportFile ( ls_filename ) = -1 Then
	gnv_App.inv_error.of_message("Message Manager","Import FAILED",Exclamation!)
ELSE
	gnv_app.inv_error.of_message("Message Manager","Import Complete",Information!)
END IF
end event

event ue_export;call super::ue_export;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet
//
// Method : ue_export
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
IF dw_master.SaveAs() = -1 THEN
	gnv_app.inv_error.of_message ("Message Manager","Export FAILED")
ELSE
	gnv_app.inv_error.of_message ("Message Manager","Export Complete")
END IF
end event

event ue_undelete;call super::ue_undelete;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_undelete
//
//	Description:  	unDelete a row(s)
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.inv_rowmanager.of_undelete()
end event

event ue_sort;call super::ue_sort;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_sort
//
//	Description:  	sort
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.Event pfc_sortdlg()
end event

event ue_filter;call super::ue_filter;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_filter
//
//	Description:  	filter, man
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.event pfc_filterdlg()
end event

event pfc_finddlg;call super::pfc_finddlg;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_finddlg
//
//	Description:  	sort, man
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.Event pfc_finddlg()
end event

event ue_copy;call super::ue_copy;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_copy
//
//	Description: copy the current message
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
istr_copy.s_msgid = dw_master.object.msgid [dw_master.GetRow()]
istr_copy.s_msgtitle = dw_master.object.msgtitle [dw_master.GetRow()]
istr_copy.s_msgtext = dw_master.object.msgtext [dw_master.GetRow()]
istr_copy.s_msgicon = dw_master.object.msgicon [dw_master.GetRow()]
istr_copy.s_msgbutton = dw_master.object.msgbutton [dw_master.GetRow()]
istr_copy.i_msgdefaultbutton = dw_master.object.msgdefaultbutton [dw_master.GetRow()]
istr_copy.i_msgseverity = dw_master.object.msgseverity [dw_master.GetRow()]
istr_copy.s_msgprint = dw_master.object.msgprint  [dw_master.GetRow()]
istr_copy.s_msguserinput = dw_master.object.msguserinput [dw_master.GetRow()]
end event

event ue_paste;call super::ue_paste;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_paste
//
//	Description: paste the current message
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_detail.object.msgid [dw_detail.GetRow()] = istr_copy.s_msgid 
dw_detail.object.msgtitle [dw_detail.GetRow()] = istr_copy.s_msgtitle 
dw_detail.object.msgtext [dw_detail.GetRow()] = istr_copy.s_msgtext 
dw_detail.object.msgicon [dw_detail.GetRow()] = istr_copy.s_msgicon
dw_detail.object.msgbutton [dw_detail.GetRow()] = istr_copy.s_msgbutton 
dw_detail.object.msgdefaultbutton [dw_detail.GetRow()] = istr_copy.i_msgdefaultbutton 
dw_detail.object.msgseverity [dw_detail.GetRow()] = istr_copy.i_msgseverity 
dw_detail.object.msgprint  [dw_detail.GetRow()] = istr_copy.s_msgprint 
dw_detail.object.msguserinput [dw_detail.GetRow()] = istr_copy.s_msguserinput 

dw_detail.AcceptText()
dw_master.accepttext()

dw_detail.SetRedraw(true)
end event

event ue_clear;call super::ue_clear;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : ue_paste
//
//	Description: paste the current message
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
istr_copy= istr_blank
end event

event pfc_undelete;call super::pfc_undelete;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet
//
// Method : pfc_undelete
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.inv_rowmanager.of_undelete()

If dw_master.DeletedCount () < 1 Then
	// Disable the undelete option
	This.Event ue_undelete_toggle(False)
End IF
end event

event ue_undelete_toggle;call super::ue_undelete_toggle;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet
//
// Method : ue_undelete_toggle
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
m_msgs_sheet lm_menu

If dw_master.DeletedCount () < 1 Then
	// Disable the undelete option
	If IsValid (gnv_app.inv_debug) Then
		Messagebox ("Debug","Disabling Undelete")
	End IF
	lm_menu = this.menuid
	lm_menu.m_tools.m_undelete.enabled=False
End IF

Return 1
end event

event pfc_replacedlg;call super::pfc_replacedlg;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_replacedlg
//
//	Description:  	sort, man
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_detail.Event pfc_replacedlg()
end event

public subroutine of_highlight (datawindow adw_dw, integer ai_row);//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: m_msgs_sheet 	
//
// Method : of_highlight
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
adw_dw.SetRedraw(False)
adw_dw.ScrollToRow(ai_row)
adw_dw.SelectRow(0 , False)
adw_dw.SelectRow(ai_row,True)
adw_dw.SetRedraw(True)
end subroutine

on w_msgs_sheet.create
int iCurrent
call w_sheet::create
if this.MenuName = "m_msgs_sheet" then this.MenuID = create m_msgs_sheet
this.dw_master=create dw_master
this.dw_detail=create dw_detail
this.st_splitbar=create st_splitbar
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=dw_master
this.Control[iCurrent+2]=dw_detail
this.Control[iCurrent+3]=st_splitbar
end on

on w_msgs_sheet.destroy
call w_sheet::destroy
if IsValid(MenuID) then destroy(MenuID)
destroy(this.dw_master)
destroy(this.dw_detail)
destroy(this.st_splitbar)
end on

event pfc_preopen;call super::pfc_preopen;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_preopen
//
//	Description:  	makes sure the sheet opens in the right place
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
This.move(0,0)
end event

event open;call super::open;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : open
//
//	Description:  set up resizing
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
This.of_SetResize(True)
This.inv_resize.of_register(dw_master,"ScaleToRight")
This.inv_resize.of_register(dw_detail,"ScaletoRight&Bottom")
this.inv_resize.of_Register(st_splitbar, "ScaleToRight")


end event

event pfc_save;call super::pfc_save;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  w_msgs_sheet	
//
// Method : pfc_save
//
//	Description:  	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Refresh the service cache
gnv_app.inv_error.POST of_LoadPredefinedMsg()

// Disable the undelete option
This.Event ue_undelete_toggle(False)

Return 1
end event

event pfc_close;call super::pfc_close;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_close
//
//	Description:  
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
Close (This)
end event

type dw_master from u_dw within w_msgs_sheet
event pfc_undelete ( )
event ue_key pbm_dwnkey
int X=41
int Y=20
int Width=2702
int Height=468
int TabOrder=10
string DataObject="d_messages"
BorderStyle BorderStyle=StyleBox!
boolean HScrollBar=true
boolean LiveScroll=false
end type

event pfc_undelete;call super::pfc_undelete;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: dw_master
//
// Method : pfc_undelete
//
//	Description: turn on services 	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
This.inv_rowmanager.of_undelete()

If This.DeletedCount () < 1 Then
	// Disable the undelete option
	Parent.Event ue_undelete_toggle(False)
End IF
end event

event ue_key;call super::ue_key;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : Keydown
//
//	Description: Set up delete and insert keys
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
IF KeyDown (KeyInsert!) THEN
	This.Event pfc_insertrow()
ELSEIF KeyDown (KeyDelete!) THEN
	This.Event pfc_DeleteRow()
	This.SelectRow (1,True)
END IF

end event

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : constructor
//
//	Description: turn on services 	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Turn on row selection service
This.of_SetRowSelect(True)
This.inv_rowselect.of_setstyle(0)

// Turn on row manager service
This.of_SetRowManager(True)

// Turn on Find Service
This.of_SetFind(True)

// Turn on sort service
This.of_SetSort(True)
This.inv_sort.of_SetColumnHeader(True) 
This.inv_sort.of_SetStyle(1)
This.inv_sort.of_SetColumnNameSource(2)

// Turn on Filter Service
This.of_SetFilter(True)
This.inv_filter.of_SetStyle(1)

// Excluse certain columns
String ls_excludecols[]
ls_excludecols[1]="cf_count"
inv_sort.of_SetExclude(ls_excludecols[])

// Retrieve the data
This.Event pfc_retrieve()

end event

event pfc_retrieve;call super::pfc_retrieve;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_sheet 	
//
// Method : pfc_retrieve
//
//	Description:  retrieve the data
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
Integer li_rows
string ls_string
long ll_long
dwobject ldwo

// Turn the sharing off 
This.ShareDataOff()

// Reset the datawindows
This.Reset()
//dw_detail.Reset()

// Re retrieve this datawindow
This.SetTransObject(SQLCA)
li_rows = This.Retrieve()

// highlight the first row if any.
IF li_rows > 0 Then
	This.SelectRow(1,True)
	This.ScrollToRow(1)
END IF

// Turn the share back on
This.Sharedata(dw_detail)

// Trigger Itemchanged
dw_detail.Event itemchanged(ll_long,ldwo,ls_string)

Return li_rows
end event

event pfc_deleterow;call super::pfc_deleterow;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : pfc_deleterow
//
//	Description: enable the undelete option	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
m_msgs_sheet lm_menu

lm_menu = Parent.menuid

lm_menu.m_tools.m_undelete.enabled=true

Return 1
end event

event rowfocuschanged;call super::rowfocuschanged;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : 		rowfocuschanged
//
//	Description: 
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_detail.SetRow(This.GetRow())
dw_detail.ScrollToRow(this.GetRow())
end event

event doubleclicked;call super::doubleclicked;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : doubleclicked
//
//	Description: test the current message
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
SetPointer(HourGlass!)

// Check for no rows.
IF row < 1 THEN
	Return
ELSE
	Parent.Event ue_test()
END IF

end event

event dberror;call super::dberror;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_master
//
// Method : dberror
//
//	Description: trap for dead database connection 	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
IF sqldbcode = -100 Then
	Messagebox ("PFC Message Manager - Database Connection Error # "+String(sqldbcode),&
					"Error Text From your DBMS :"+"~n~n" +sqlerrtext)
	Return 1
END IF
end event

type dw_detail from u_dw within w_msgs_sheet
event ue_dwnkey pbm_dwnkey
int X=41
int Y=516
int Width=2702
int Height=736
int TabOrder=20
boolean BringToTop=true
string DataObject="d_tb_messages"
BorderStyle BorderStyle=StyleBox!
boolean VScrollBar=false
end type

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_detail
//
// Method : constructor
//
//	Description: turn on services 	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Set up the linkage service
This.of_SetLinkage(true)
inv_linkage.of_LinkTo(dw_master)
inv_linkage.of_SetUseColLinks(3)
inv_linkage.of_SetArguments("cf_count","cf_count")

// Turn on Find Service
This.of_SetFind(True)

// Make sure both dw's don't get updated
This.of_SetUpdateable(False)

end event

event rowfocuschanged;call super::rowfocuschanged;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	dw_detail
//
// Method : 		rowfocuschanged
//
//	Description: 	Keep the dw's in sync	
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
dw_master.SetRow(currentrow)
dw_master.ScrollToRow(currentrow)
end event

type st_splitbar from u_st_splitbar within w_msgs_sheet
int X=14
int Y=492
int Width=2743
long BackColor=79741120
long BorderColor=79741120
end type

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  st_splitbar
//
// Method : constructor
//
//	Description: register datawindow above and below the splitbar object
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version 
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////
this.of_Register(dw_master, ABOVE)
this.of_Register(dw_detail, BELOW)
this.of_SetBarColor(RGB(192, 192, 192))

end event

