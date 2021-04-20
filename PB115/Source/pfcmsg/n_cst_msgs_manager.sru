HA$PBExportHeader$n_cst_msgs_manager.sru
$PBExportComments$App manager for message manager application
forward
global type n_cst_msgs_manager from n_cst_appmanager
end type
end forward

global type n_cst_msgs_manager from n_cst_appmanager
end type
global n_cst_msgs_manager n_cst_msgs_manager

on n_cst_msgs_manager.create
call super::create
end on

on n_cst_msgs_manager.destroy
call super::destroy
end on

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  n_cst_msgs_manager
//
// Method : constructor
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
ContextInformation lcx_key
int li_major, li_minor
date ld_now

ld_now = Today ( )

/*  Get PB Version.    */
GetContextService ( "ContextInformation", lcx_key)
lcx_key.GetMajorVersion ( li_major )
lcx_key.GetMinorVersion ( li_minor )

// Fix the toolbars
iapp_object.toolbarframetitle = "Toolbar"
iapp_object.toolbarsheettitle = "Toolbar"

// Name of the application
iapp_object.DisplayName="PFC Message Manager"

// Microhelp functionality
of_SetMicroHelp (true)

// The file name of the application INI file
of_SetAppIniFile ("pfcmsg.ini")

// Set the help file 
of_SetHelpFile("pfcmsg" + String ( li_major ) + String (  li_minor ) + ".hlp")

// The application version
of_SetVersion ("Version " + String ( li_major ) + "." + String ( li_minor ) + ".00" )

// The application logo (bitmap file name)
of_SetLogo ("pfcmsg.bmp")

// Application copyright message
this.of_SetCopyright("Copyright (c) 2004-" + String ( Year ( ld_now ), "0000" ) + " Open Source PowerBuilder Foundation Class Libraries, All rights reserved.")


end event

event pfc_open;call super::pfc_open;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name:  	n_cst_msgs_manager
//
// Method : pfc_open
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
integer	li_return
string	ls_inifile

// Connect to database
open(w_msgs_login)  
if dbhandle(sqlca) = 0 then
	halt close
	return
end if

// Initialize the error service
This.of_SetError(True)
this.inv_error.of_SetPredefinedSource (SQLCA)
This.inv_error.of_LoadPredefinedMsg()
This.inv_error.of_setstyle(1)

// Debugger
//This.of_setdebug(true)

// Open the frame
Open (w_msgs_frame)




end event

