forward
global type w_linkautoupdate from w_main
end type
type cb_close from u_cb within w_linkautoupdate
end type
type dw_cust from u_dw within w_linkautoupdate
end type
type dw_sales from u_dw within w_linkautoupdate
end type
type dw_lineitem from u_dw within w_linkautoupdate
end type
type p_1 from u_p within w_linkautoupdate
end type
type gb_2 from groupbox within w_linkautoupdate
end type
type cbx_confirmationonrowchange from u_cbx within w_linkautoupdate
end type
type cb_1 from u_cb_sqlspy within w_linkautoupdate
end type
end forward


global type w_linkautoupdate from w_main 

cb_close cb_close 
dw_cust dw_cust 
dw_sales dw_sales 
dw_lineitem dw_lineitem 
p_1 p_1 
gb_2 gb_2 
cbx_confirmationonrowchange cbx_confirmationonrowchange 
cb_1 cb_1 
end type


global w_linkautoupdate w_linkautoupdate

on w_linkautoupdate.create
int iCurrent
call super::create
this.cb_close=create cb_close
this.dw_cust=create dw_cust
this.dw_sales=create dw_sales
this.dw_lineitem=create dw_lineitem
this.p_1=create p_1
this.gb_2=create gb_2
this.cbx_confirmationonrowchange=create cbx_confirmationonrowchange
this.cb_1=create cb_1
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.cb_close
this.Control[iCurrent+2]=this.dw_cust
this.Control[iCurrent+3]=this.dw_sales
this.Control[iCurrent+4]=this.dw_lineitem
this.Control[iCurrent+5]=this.p_1
this.Control[iCurrent+6]=this.gb_2
this.Control[iCurrent+7]=this.cbx_confirmationonrowchange
this.Control[iCurrent+8]=this.cb_1
end on

on w_linkautoupdate.destroy
call super::destroy
destroy(this.cb_close)
destroy(this.dw_cust)
destroy(this.dw_sales)
destroy(this.dw_lineitem)
destroy(this.p_1)
destroy(this.gb_2)
destroy(this.cbx_confirmationonrowchange)
destroy(this.cb_1)
end on

event open;call super::open;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	open
//
//	Description:
//	Set the transaction object and retrieve the linked DataWindows.
//
//////////////////////////////////////////////////////////////////////////////

//  Set the Transaction Object for all the dws 
dw_cust.inv_linkage.of_SetTransObject(sqlca)

//  Call the retrieve on the top-level datawindow.  This 
//  will retrieve all the datawindows in the linked chain 
dw_cust.of_Retrieve()
end event

type cb_close from u_cb within w_linkautoupdate 

end type



event clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Calls the pfc_close event on the window.
//
//////////////////////////////////////////////////////////////////////////////

parent.event pfc_close()
 
end event

type dw_cust from u_dw within w_linkautoupdate 
string dataobject = "d_customerdetailupdatable"

end type



event constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Initializes the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

// Start the Linkage Service.
of_SetLinkage(true)
inv_linkage.of_SetStyle(inv_linkage.RETRIEVE)
// Set up visual confirmation of saves and deletes.
// This will be the initial setting for the example.
inv_linkage.of_SetUpdateOnRowChange (True)
inv_linkage.of_SetConfirmOnRowChange (True)

of_SetReqColumn(True)

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

return this.Retrieve()
end event

event pfc_prermbmenu;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	pfc_prermbmenu
//
//	Arguments:
//	am_dw   	the menu that will be displayed when the DataWindow
//				is right clicked.
//
//	Returns:
//	None
//
//	Description:
// Initialize the Right Mouse Menu for the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

am_dw.m_table.m_insert.enabled = True
am_dw.m_table.m_addrow.enabled = True
am_dw.m_table.m_delete.enabled = false

end event

type dw_sales from u_dw within w_linkautoupdate 
string dataobject = "d_salesforcustomersupdatable"

end type



event constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Initializes the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

// Start the Linkage Service.
of_SetLinkage(true)
inv_linkage.of_SetMaster(dw_cust) 
inv_linkage.of_Register("cust_id", "cust_id") 
inv_linkage.of_SetStyle(inv_linkage.RETRIEVE) 
// Set up visual confirmation of saves and deletes.
// This will be the initial setting for the example.
inv_linkage.of_SetUpdateOnRowChange (True)
inv_linkage.of_SetConfirmOnRowChange (True)

of_SetReqColumn(True)

SetRowFocusIndicator(p_1)




end event

event pfc_prermbmenu;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	pfc_prermbmenu
//
//	Arguments:
//	am_dw   	the menu that will be displayed when the DataWindow
//				is right clicked.
//
//	Returns:
//	None
//
//	Description:
// Initialize the Right Mouse Menu for the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

am_dw.m_table.m_insert.enabled = True
am_dw.m_table.m_addrow.enabled = True
am_dw.m_table.m_delete.enabled = false

end event

type dw_lineitem from u_dw within w_linkautoupdate 
string dataobject = "d_lineitemsupdatable"

end type



event constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Initializes the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

// Start the Linkage Service.
of_SetLinkage(true)
inv_linkage.of_SetMaster(dw_sales) 
inv_linkage.of_Register("sales_id","sales_id") 
inv_linkage.of_SetStyle(inv_linkage.RETRIEVE) 
// Set up visual confirmation of saves and deletes.
// This will be the initial setting for the example.
inv_linkage.of_SetUpdateOnRowChange (True)
inv_linkage.of_SetConfirmOnRowChange (True)

of_SetReqColumn(True)

SetRowFocusIndicator(p_1)
end event

type p_1 from u_p within w_linkautoupdate 

end type



type gb_2 from groupbox within w_linkautoupdate 

end type



type cbx_confirmationonrowchange from u_cbx within w_linkautoupdate 

end type



event clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Change the Confirmation behavior.
//
//////////////////////////////////////////////////////////////////////////////


dw_cust.inv_linkage.of_SetConfirmOnRowChange (this.Checked)
dw_sales.inv_linkage.of_SetConfirmOnRowChange (this.Checked)
dw_lineitem.inv_linkage.of_SetConfirmOnRowChange (this.Checked)

end event

type cb_1 from u_cb_sqlspy within w_linkautoupdate 

end type

