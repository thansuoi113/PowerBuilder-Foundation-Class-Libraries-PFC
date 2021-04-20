HA$PBExportHeader$w_msgs_frame.srw
$PBExportComments$Frame for messages table manager
forward
global type w_msgs_frame from w_frame
end type
end forward

global type w_msgs_frame from w_frame
integer x = 55
integer y = 128
integer width = 2821
integer height = 1668
string menuname = "m_msgs_frame"
windowstate windowstate = maximized!
end type
global w_msgs_frame w_msgs_frame

on w_msgs_frame.create
call super::create
if IsValid(this.MenuID) then destroy(this.MenuID)
if this.MenuName = "m_msgs_frame" then this.MenuID = create m_msgs_frame
end on

on w_msgs_frame.destroy
call super::destroy
if IsValid(MenuID) then destroy(MenuID)
end on

event pfc_open;call super::pfc_open;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_frame
//
// Method : pfc_open
//
//	Description: open event  	
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
w_msgs_sheet lw_msgs_sheet

OpenSheet (lw_msgs_sheet,this,0,original!)
end event

event pfc_postopen;call super::pfc_postopen;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_frame
//
// Method : pfc_postopen
//
//	Description: open event  	
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
Integer li_rc

//turn on the status bar information
li_rc = this.of_setstatusbar ( true)
if li_rc > 0 then
	this.inv_statusbar.of_SetMem(True)
	this.inv_statusbar.of_SetTimer(True)
	this.inv_statusbar.of_Open(True )
end if

// open the sheet
This.Event pfc_open()
end event

event pfc_preopen;call super::pfc_preopen;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_frame
//
// Method : pfc_preopen
//
//	Description: pfc_preopen event  	
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
This.of_SetBase(True)
This.inv_base.of_Center()
end event

event pfc_close;call super::pfc_close;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_msgs_frame
//
// Method : pfc_close
//
//	Description: close current sheet 	
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
//Messagebox ("","")
w_msgs_sheet lw_sheet

lw_sheet = GetActiveSheet()

if IsValid (lw_sheet) then
	Close ( lw_sheet )
end if
end event

