forward
global type u_salesreptab from u_tabpg
end type
type dw_1 from u_dw within u_salesreptab
end type
type p_1 from u_p within u_salesreptab
end type
end forward


global type u_salesreptab from u_tabpg 

dw_1 dw_1 
p_1 p_1 
end type


global u_salesreptab u_salesreptab

type variables
Private:
boolean              ib_constructor
u_tab                  itab_parent
w_tablink            iw_parentwindow


end variables

on u_salesreptab.create
int iCurrent
call u_tabpg::create
this.dw_1=create dw_1
this.p_1=create p_1
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=dw_1
this.Control[iCurrent+2]=p_1
end on

on u_salesreptab.destroy
call u_tabpg::destroy
destroy(this.dw_1)
destroy(this.p_1)
end on

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Inserts a reference of itself into the parentwindow's control array.
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

integer   li_upperbound
tab       ltab_parent

if ib_constructor then return

of_GetParentWindow(iw_parentwindow)

ltab_parent = GetParent()

if IsNull(ltab_parent) or not IsValid(ltab_parent) then
	return -1
end if

itab_parent = ltab_parent 

li_upperbound = UpperBound(ltab_parent.control)
li_upperbound++
ltab_parent.control[li_upperbound] = this

ib_constructor =  true
end event

type dw_1 from u_dw within u_salesreptab 
string dataobject = "d_salesreptab"

end type



event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
// Initialize the Linkage Service in the detail datawindow.
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

// Start the linkage service.
of_SetLinkage(true)

// Identify the u_dw descendent that will act as the 'master'
// for this linkage relationship.
if inv_linkage.of_SetMaster(iw_parentwindow.dw_1) <> 1 then
	MessageBox("Linkage Error","Master does not exist.")
end if

// Define the columns to be linked together by the
// linkage service.
inv_linkage.of_Register("sales_rep","emp_id")

// Define the linkage type that will be used to align the 
// DataWindows.  (FILTER, RETRIEVE, or SCROLL)
inv_linkage.of_SetStyle(inv_linkage.FILTER)

// Set the Update Style for this relationship.
inv_linkage.of_SetUpdateStyle(inv_linkage.BOTTOMUP)

SetRowFocusIndicator(p_1)
end event

event pfc_retrieve;call super::pfc_retrieve;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	pfc_retrieve
//
//	Arguments:
//	None
//
//	Returns:
//	long
//	The number of rows retrieved from the database
// -1 if it fails
// If any argument's value is NULL, pfc_retrieve returns NULL
//
//	Description:
//	Retrieves data into the DataWindow.
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

return this.Retrieve()

end event

type p_1 from u_p within u_salesreptab 

end type

