HA$PBExportHeader$w_frame.srw
forward
global type w_frame from pfc_w_frame
end type
end forward

global type w_frame from pfc_w_frame
end type
global w_frame w_frame

on w_frame.create
call super::create
end on

on w_frame.destroy
call super::destroy
if IsValid(MenuID) then destroy(MenuID)
end on

event pfc_pretoolbar;call super::pfc_pretoolbar;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	pfc_pretoolbar
//
//	Arguments:
//	anv_toolbarattrib		A reference to the toolbar attribute object
//
//	Returns:
// None
//
//	Description:
//	Populate values before passing object to toolbar window.  The frame
// windows that are used in this application have not been designed for 
// large icon toolbars.  Therefore, we have disabled this attribute on the 
// w_toolbars response window.
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

anv_toolbarattrib.ib_largebuttonsenabled = false
end event

