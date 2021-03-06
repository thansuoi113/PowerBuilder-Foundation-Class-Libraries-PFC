forward
global type u_tabpgone from u_tabpg
end type
type st_1 from u_st within u_tabpgone
end type
type st_2 from u_st within u_tabpgone
end type
type ddlb_1 from u_ddlb within u_tabpgone
end type
type ddplb_1 from u_ddplb within u_tabpgone
end type
type cb_1 from u_cb within u_tabpgone
end type
type cbx_1 from u_cbx within u_tabpgone
end type
end forward


global type u_tabpgone from u_tabpg 

st_1 st_1 
st_2 st_2 
ddlb_1 ddlb_1 
ddplb_1 ddplb_1 
cb_1 cb_1 
cbx_1 cbx_1 
end type


global u_tabpgone u_tabpgone

on u_tabpgone.create
int iCurrent
call u_tabpg::create
this.st_1=create st_1
this.st_2=create st_2
this.ddlb_1=create ddlb_1
this.ddplb_1=create ddplb_1
this.cb_1=create cb_1
this.cbx_1=create cbx_1
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=st_1
this.Control[iCurrent+2]=st_2
this.Control[iCurrent+3]=ddlb_1
this.Control[iCurrent+4]=ddplb_1
this.Control[iCurrent+5]=cb_1
this.Control[iCurrent+6]=cbx_1
end on

on u_tabpgone.destroy
call u_tabpg::destroy
destroy(this.st_1)
destroy(this.st_2)
destroy(this.ddlb_1)
destroy(this.ddplb_1)
destroy(this.cb_1)
destroy(this.cbx_1)
end on

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Start the resize service and register the controls.
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

integer  li_rc

// Start the Resize Service.
of_SetResize(true)

//Set the MinSize of the main object.
inv_resize.of_SetMinSize(1043, 401)

//Set the behavior of each object.
inv_resize.of_Register(cb_1, inv_resize.FIXEDRIGHT)
inv_resize.of_Register(ddlb_1, inv_resize.SCALERIGHTBOTTOM)
inv_resize.of_Register(ddplb_1, inv_resize.SCALERIGHTBOTTOM)

ddplb_1.SelectItem(2)
end event

type st_1 from u_st within u_tabpgone 

end type



type st_2 from u_st within u_tabpgone 

end type



type ddlb_1 from u_ddlb within u_tabpgone 

end type



event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Populate the Drop-down List Box with the names of the files
// on the current directory.
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

integer				li_count
integer				li_entries
string				ls_currentdir
n_cst_dirattrib	lnv_dirattrib[]
n_cst_filesrv		lnv_filesrv

f_SetFileSrv(lnv_filesrv, true)

ls_currentdir = lnv_filesrv.of_GetCurrentDirectory() + "/*.*"

li_entries = lnv_filesrv.of_DirList(ls_currentdir, 0, lnv_dirattrib[])

for li_count = 1 to li_entries
	AddItem(lnv_dirattrib[li_count].is_filename)
next
return 1
end event

type ddplb_1 from u_ddplb within u_tabpgone 

end type



type cb_1 from u_cb within u_tabpgone 

end type



type cbx_1 from u_cbx within u_tabpgone 

end type

