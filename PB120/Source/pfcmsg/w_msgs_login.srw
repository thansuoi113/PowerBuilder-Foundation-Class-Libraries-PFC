HA$PBExportHeader$w_msgs_login.srw
$PBExportComments$This is the message application login window
forward
global type w_msgs_login from w_response
end type
type cb_ok from u_cb within w_msgs_login
end type
type cb_cancel from u_cb within w_msgs_login
end type
type st_dbms from u_st within w_msgs_login
end type
type st_database from u_st within w_msgs_login
end type
type st_logid from u_st within w_msgs_login
end type
type st_logpass from u_st within w_msgs_login
end type
type st_servername from u_st within w_msgs_login
end type
type st_userid from u_st within w_msgs_login
end type
type st_dbpass from u_st within w_msgs_login
end type
type st_lock from u_st within w_msgs_login
end type
type st_dbparm from u_st within w_msgs_login
end type
type sle_database from u_sle within w_msgs_login
end type
type sle_logid from u_sle within w_msgs_login
end type
type sle_logpass from u_sle within w_msgs_login
end type
type sle_servername from u_sle within w_msgs_login
end type
type sle_userid from u_sle within w_msgs_login
end type
type sle_dbpass from u_sle within w_msgs_login
end type
type sle_lock from u_sle within w_msgs_login
end type
type sle_dbparm from u_sle within w_msgs_login
end type
type sle_dbms from u_sle within w_msgs_login
end type
end forward

global type w_msgs_login from w_response
integer x = 1010
integer y = 664
integer width = 1655
integer height = 1040
string title = "Database Login"
boolean resizable = true
boolean center = true
cb_ok cb_ok
cb_cancel cb_cancel
st_dbms st_dbms
st_database st_database
st_logid st_logid
st_logpass st_logpass
st_servername st_servername
st_userid st_userid
st_dbpass st_dbpass
st_lock st_lock
st_dbparm st_dbparm
sle_database sle_database
sle_logid sle_logid
sle_logpass sle_logpass
sle_servername sle_servername
sle_userid sle_userid
sle_dbpass sle_dbpass
sle_lock sle_lock
sle_dbparm sle_dbparm
sle_dbms sle_dbms
end type
global w_msgs_login w_msgs_login

type variables
Protected:
string is_ini_file

boolean ib_modified
end variables

event open;call super::open;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_message_login
//
// Method : open
//
//	Description:initialize the dw from the ini file
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

string ls_dbms
is_ini_file = gnv_app.of_getappinifile ( )


// make sure the dbms entry is there
ls_dbms = ProfileString(is_ini_file,"Database","DBMS", "not found")
if ls_dbms = "not found" then
	messagebox(gnv_app.iapp_object.displayname,'Unable to open INI file "'+is_ini_file+'".~r~nHalting.',stopsign!)
	cb_cancel.event post clicked()
	return
end if

// Populate the datawindow based on the ini file
sle_dbms.text       =ls_dbms
sle_database.text   =ProfileString(is_ini_file,"Database","DataBase",         " ")
sle_logid.text      =ProfileString(is_ini_file,"Database","LogID",            " ")
sle_logpass.text    =ProfileString(is_ini_file,"Database","LogPass",      " ")
sle_servername.text =ProfileString(is_ini_file,"Database","ServerName",       " ")
sle_userid.text     =ProfileString(is_ini_file,"Database","UserID",           " ")
sle_dbpass.text     =ProfileString(is_ini_file,"Database","DbPass", " ")
sle_lock.text       =ProfileString(is_ini_file,"Database","Lock",             " ")
slE_dbparm.text     =ProfileString(is_ini_file,"Database","DbParm",           " ")

// Set focus to the password
sle_dbpass.SetFocus()
sle_dbpass.SelectText (1, Len(sle_dbpass.text))

// Resize service
//This.of_SetResize(True)
//This.inv_resize.of_register(sle_dbms, "ScaleToRight")
//This.inv_resize.of_register(sle_dbparm, "ScaleToRight")
//This.inv_resize.of_register(sle_dbpass, "ScaleToRight")
//This.inv_resize.of_register(sle_lock, "ScaleToRight")
//This.inv_resize.of_register(sle_logid, "ScaleToRight")
//This.inv_resize.of_register(sle_logpass, "ScaleToRight")
//This.inv_resize.of_register(sle_servername, "ScaleToRight")
//This.inv_resize.of_register(sle_userid, "ScaleToRight")
//This.inv_resize.of_register(sle_database, "ScaleToRight")
//
//// make the window resizable
//This.Resizable = True

end event

on w_msgs_login.create
int iCurrent
call super::create
this.cb_ok=create cb_ok
this.cb_cancel=create cb_cancel
this.st_dbms=create st_dbms
this.st_database=create st_database
this.st_logid=create st_logid
this.st_logpass=create st_logpass
this.st_servername=create st_servername
this.st_userid=create st_userid
this.st_dbpass=create st_dbpass
this.st_lock=create st_lock
this.st_dbparm=create st_dbparm
this.sle_database=create sle_database
this.sle_logid=create sle_logid
this.sle_logpass=create sle_logpass
this.sle_servername=create sle_servername
this.sle_userid=create sle_userid
this.sle_dbpass=create sle_dbpass
this.sle_lock=create sle_lock
this.sle_dbparm=create sle_dbparm
this.sle_dbms=create sle_dbms
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.cb_ok
this.Control[iCurrent+2]=this.cb_cancel
this.Control[iCurrent+3]=this.st_dbms
this.Control[iCurrent+4]=this.st_database
this.Control[iCurrent+5]=this.st_logid
this.Control[iCurrent+6]=this.st_logpass
this.Control[iCurrent+7]=this.st_servername
this.Control[iCurrent+8]=this.st_userid
this.Control[iCurrent+9]=this.st_dbpass
this.Control[iCurrent+10]=this.st_lock
this.Control[iCurrent+11]=this.st_dbparm
this.Control[iCurrent+12]=this.sle_database
this.Control[iCurrent+13]=this.sle_logid
this.Control[iCurrent+14]=this.sle_logpass
this.Control[iCurrent+15]=this.sle_servername
this.Control[iCurrent+16]=this.sle_userid
this.Control[iCurrent+17]=this.sle_dbpass
this.Control[iCurrent+18]=this.sle_lock
this.Control[iCurrent+19]=this.sle_dbparm
this.Control[iCurrent+20]=this.sle_dbms
end on

on w_msgs_login.destroy
call super::destroy
destroy(this.cb_ok)
destroy(this.cb_cancel)
destroy(this.st_dbms)
destroy(this.st_database)
destroy(this.st_logid)
destroy(this.st_logpass)
destroy(this.st_servername)
destroy(this.st_userid)
destroy(this.st_dbpass)
destroy(this.st_lock)
destroy(this.st_dbparm)
destroy(this.sle_database)
destroy(this.sle_logid)
destroy(this.sle_logpass)
destroy(this.sle_servername)
destroy(this.sle_userid)
destroy(this.sle_dbpass)
destroy(this.sle_lock)
destroy(this.sle_dbparm)
destroy(this.sle_dbms)
end on

event systemkey;call super::systemkey;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_message_login
//
// Method : open
//
//	Description:initialize the dw from the ini file
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
IF KeyDown (KeyD!)Then
	SetFocus (sle_dbms)
ElseIf KeyDown (KeyB!)Then
	SetFocus (sle_database)
ElseIf KeyDown (KeyG!)Then
	SetFocus (sle_logid)	
ElseIf KeyDown (KeyP!)Then
	SetFocus (sle_logpass)
ElseIf KeyDown (KeyN!)Then
	SetFocus (sle_servername)
ElseIf KeyDown (KeyU!)Then
	SetFocus (sle_userid)	
ElseIf KeyDown (KeyS!)Then
	SetFocus (sle_dbpass)
ElseIf KeyDown (KeyK!)Then
	SetFocus (sle_lock)
ElseIf KeyDown (KeyM!)Then
	SetFocus (sle_dbparm)	
END IF
end event

type cb_ok from u_cb within w_msgs_login
integer x = 855
integer y = 816
integer taborder = 100
string text = "OK"
boolean default = true
end type

event clicked;call super::clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: w_message_login
//
// Method : 
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
SetPointer(Hourglass!)

// Set sqlca from the datawindow info
sqlca.DBMS       =sle_dbms.text
sqlca.Database   =sle_DataBase.text
sqlca.LogID      =sle_Logid.text
sqlca.LogPass    =sle_LogPass.text
sqlca.ServerName =sle_ServerName.text
sqlca.UserID     =sle_UserID.text
sqlca.DBPass     =sle_DbPass.text
sqlca.Lock       =sle_Lock.text
sqlca.DbParm     =sle_DbParm.text

connect using sqlca;

if sqlca.sqlcode <> 0 then
	// error on connect
	Messagebox ("PFCMSG Database Connection Error", sqlca.SQLErrText)
	return
end if

// If there have been changes, save back to the ini file
if (Parent.ib_modified) then
	setprofilestring(is_ini_file,'Database','DBMS',sqlca.dbms)
	setprofilestring(is_ini_file,'Database','Database',sqlca.database)
	setprofilestring(is_ini_file,'Database','logid',sqlca.logid)
	setprofilestring(is_ini_file,'Database','logpass',sqlca.logpass)
	setprofilestring(is_ini_file,'Database','servername',sqlca.servername)
	setprofilestring(is_ini_file,'Database','userid',sqlca.userid)
	setprofilestring(is_ini_file,'Database','DBPass',sqlca.DBPass)
	setprofilestring(is_ini_file,'Database','lock',sqlca.lock)
	setprofilestring(is_ini_file,'Database','DBparm',sqlca.dbparm)
end if

close(parent)

end event

type cb_cancel from u_cb within w_msgs_login
integer x = 1234
integer y = 816
integer taborder = 110
string text = "Cancel"
boolean cancel = true
end type

event clicked;call super::clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: cb_cancel
//
// Method : clicked
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
close(parent)
end event

type st_dbms from u_st within w_msgs_login
integer x = 46
integer y = 28
integer width = 343
integer height = 76
string facename = "Arial"
string text = "&DBMS :"
alignment alignment = right!
end type

type st_database from u_st within w_msgs_login
integer x = 46
integer y = 108
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Data&base : "
alignment alignment = right!
end type

type st_logid from u_st within w_msgs_login
integer x = 46
integer y = 192
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Lo&gid :"
alignment alignment = right!
end type

type st_logpass from u_st within w_msgs_login
integer x = 46
integer y = 276
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Log&pass :"
alignment alignment = right!
end type

type st_servername from u_st within w_msgs_login
integer x = 5
integer y = 360
integer width = 384
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Server&name :"
alignment alignment = right!
end type

type st_userid from u_st within w_msgs_login
integer x = 46
integer y = 444
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "&Userid :"
alignment alignment = right!
end type

type st_dbpass from u_st within w_msgs_login
integer x = 46
integer y = 528
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Dbpa&ss :"
alignment alignment = right!
end type

type st_lock from u_st within w_msgs_login
integer x = 46
integer y = 612
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Loc&k :"
alignment alignment = right!
end type

type st_dbparm from u_st within w_msgs_login
integer x = 46
integer y = 696
integer width = 343
integer height = 76
boolean bringtotop = true
string facename = "Arial"
string text = "Dbpar&m :"
alignment alignment = right!
end type

type sle_database from u_sle within w_msgs_login
integer x = 402
integer y = 108
integer width = 1175
integer height = 76
integer taborder = 20
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_database
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_logid from u_sle within w_msgs_login
integer x = 402
integer y = 192
integer width = 1175
integer height = 76
integer taborder = 30
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_logid
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_logpass from u_sle within w_msgs_login
integer x = 402
integer y = 276
integer width = 1175
integer height = 76
integer taborder = 40
boolean bringtotop = true
boolean autohscroll = true
boolean password = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_logpass
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_servername from u_sle within w_msgs_login
integer x = 402
integer y = 360
integer width = 1175
integer height = 76
integer taborder = 50
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_servername
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_userid from u_sle within w_msgs_login
integer x = 402
integer y = 444
integer width = 1175
integer height = 76
integer taborder = 60
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_userid
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_dbpass from u_sle within w_msgs_login
integer x = 402
integer y = 528
integer width = 1175
integer height = 76
integer taborder = 70
boolean bringtotop = true
boolean autohscroll = true
boolean password = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_modified
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_lock from u_sle within w_msgs_login
integer x = 402
integer y = 612
integer width = 1175
integer height = 76
integer taborder = 80
boolean bringtotop = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_lock
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_dbparm from u_sle within w_msgs_login
integer x = 402
integer y = 696
integer width = 1175
integer height = 76
integer taborder = 90
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_dbparm
//
// Method : 
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
Parent.ib_modified = True
end event

type sle_dbms from u_sle within w_msgs_login
integer x = 402
integer y = 24
integer width = 1175
integer height = 76
integer taborder = 10
boolean bringtotop = true
boolean autohscroll = true
end type

event modified;call super::modified;//////////////////////////////////////////////////////////////////////////////
//
//	Object Name: sle_dbms
//
// Method : 
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
Parent.ib_modified = True
end event

