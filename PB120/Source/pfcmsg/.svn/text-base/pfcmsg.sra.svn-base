HA$PBExportHeader$pfcmsg.sra
$PBExportComments$Application Object for message manage application
forward
global n_tr sqlca
global dynamicdescriptionarea sqlda
global dynamicstagingarea sqlsa
global n_err error
global n_msg message
end forward

global variables
n_cst_msgs_manager gnv_app
end variables

global type pfcmsg from application
 end type
global pfcmsg pfcmsg

on pfcmsg.create
appname = "pfcmsg"
message = create n_msg
sqlca = create n_tr
sqlda = create dynamicdescriptionarea
sqlsa = create dynamicstagingarea
error = create n_err
end on

on pfcmsg.destroy
destroy( sqlca )
destroy( sqlda )
destroy( sqlsa )
destroy( error )
destroy( message )
end on

event open;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: App obj
//
// Method : Open
//
//	Description: Redirect he app open event  	
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
gnv_app = CREATE n_cst_msgs_manager
gnv_app.Event pfc_open(commandline)
end event

event close;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: app obj	
//
// Method : Close
//
//	Description: Redirect the close event and destroy that app manager object	
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
gnv_app.event pfc_close()
Destroy gnv_app
end event

