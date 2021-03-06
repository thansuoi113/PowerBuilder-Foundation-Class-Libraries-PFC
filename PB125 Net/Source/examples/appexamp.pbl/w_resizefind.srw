forward
global type w_resizefind from w_main
end type
type st_named from u_st within w_resizefind
end type
type st_lookin from u_st within w_resizefind
end type
type sle_text from u_sle within w_resizefind
end type
type ddlb_look from u_ddlb within w_resizefind
end type
type cb_browse from u_cb within w_resizefind
end type
type cb_findnow from u_cb within w_resizefind
end type
type cb_stop from u_cb within w_resizefind
end type
type cb_newsearch from u_cb within w_resizefind
end type
type gb_box from u_gb within w_resizefind
end type
end forward


global type w_resizefind from w_main 

st_named st_named 
st_lookin st_lookin 
sle_text sle_text 
ddlb_look ddlb_look 
cb_browse cb_browse 
cb_findnow cb_findnow 
cb_stop cb_stop 
cb_newsearch cb_newsearch 
gb_box gb_box 
end type


global w_resizefind w_resizefind

on w_resizefind.create
int iCurrent
call super::create
this.st_named=create st_named
this.st_lookin=create st_lookin
this.sle_text=create sle_text
this.ddlb_look=create ddlb_look
this.cb_browse=create cb_browse
this.cb_findnow=create cb_findnow
this.cb_stop=create cb_stop
this.cb_newsearch=create cb_newsearch
this.gb_box=create gb_box
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.st_named
this.Control[iCurrent+2]=this.st_lookin
this.Control[iCurrent+3]=this.sle_text
this.Control[iCurrent+4]=this.ddlb_look
this.Control[iCurrent+5]=this.cb_browse
this.Control[iCurrent+6]=this.cb_findnow
this.Control[iCurrent+7]=this.cb_stop
this.Control[iCurrent+8]=this.cb_newsearch
this.Control[iCurrent+9]=this.gb_box
end on

on w_resizefind.destroy
call super::destroy
destroy(this.st_named)
destroy(this.st_lookin)
destroy(this.sle_text)
destroy(this.ddlb_look)
destroy(this.cb_browse)
destroy(this.cb_findnow)
destroy(this.cb_stop)
destroy(this.cb_newsearch)
destroy(this.gb_box)
end on

event pfc_preopen;// Start the Resize service.
of_SetResize(True)

//Set the MinSize of the main object.
inv_resize.of_SetMinSize(1300, 400)

//Set the behavior of each object.
inv_resize.of_Register (sle_text, inv_resize.SCALERIGHT)
inv_resize.of_Register (ddlb_look, inv_resize.SCALERIGHTBOTTOM)
inv_resize.of_Register (cb_browse, inv_resize.FIXEDRIGHT)
inv_resize.of_Register (gb_box, inv_resize.SCALERIGHTBOTTOM)
inv_resize.of_Register (cb_findnow, inv_resize.FIXEDRIGHT)
inv_resize.of_Register (cb_newsearch, inv_resize.FIXEDRIGHT)
inv_resize.of_Register (cb_stop, inv_resize.FIXEDRIGHT)
end event

type st_named from u_st within w_resizefind 

end type



type st_lookin from u_st within w_resizefind 

end type



type sle_text from u_sle within w_resizefind 

end type



type ddlb_look from u_ddlb within w_resizefind 

end type



type cb_browse from u_cb within w_resizefind 

end type



type cb_findnow from u_cb within w_resizefind 

end type



type cb_stop from u_cb within w_resizefind 

end type



event clicked;call super::clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Calls the pfc_close event on the window.
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

parent.event pfc_close()
end event

type cb_newsearch from u_cb within w_resizefind 

end type



type gb_box from u_gb within w_resizefind 

end type

