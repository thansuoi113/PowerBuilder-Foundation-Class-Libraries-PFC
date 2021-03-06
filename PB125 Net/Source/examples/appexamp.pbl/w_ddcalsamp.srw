forward
global type w_ddcalsamp from w_main
end type
type dw_1 from u_dw within w_ddcalsamp
end type
type cb_close from u_cb within w_ddcalsamp
end type
type cb_update from u_cb within w_ddcalsamp
end type
type cb_retrieve from u_cb within w_ddcalsamp
end type
end forward


global type w_ddcalsamp from w_main 

dw_1 dw_1 
cb_close cb_close 
cb_update cb_update 
cb_retrieve cb_retrieve 
end type


global w_ddcalsamp w_ddcalsamp

on w_ddcalsamp.create
int iCurrent
call super::create
this.dw_1=create dw_1
this.cb_close=create cb_close
this.cb_update=create cb_update
this.cb_retrieve=create cb_retrieve
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.dw_1
this.Control[iCurrent+2]=this.cb_close
this.Control[iCurrent+3]=this.cb_update
this.Control[iCurrent+4]=this.cb_retrieve
end on

on w_ddcalsamp.destroy
call super::destroy
destroy(this.dw_1)
destroy(this.cb_close)
destroy(this.cb_update)
destroy(this.cb_retrieve)
end on

type dw_1 from u_dw within w_ddcalsamp 
string dataobject = "d_employee"

end type



event constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Starts the Drop-down Calculator and Calendar Services and registers the
// DataWindow columns that apply.
//
//////////////////////////////////////////////////////////////////////////////

of_SetTransObject(sqlca)

// Start the Drop-down Calendar and associate with the 
// "order date" column of the DataWindow.
of_SetDropDownCalendar(true)
iuo_calendar.of_Register('start_date', iuo_calendar.DDLB_WITHARROW)

// Start the Drop-down Calculator and associate with the "quantity" column
// of the DataWindow.
of_SetDropDownCalculator(true)
iuo_calculator.of_Register('salary', iuo_calculator.DDLB_WITHARROW)

//  Call the of_Retrieve function to retrieve the data.
of_Retrieve()
end event

event pfc_retrieve;//////////////////////////////////////////////////////////////////////////////
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

type cb_close from u_cb within w_ddcalsamp 

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

type cb_update from u_cb within w_ddcalsamp 

end type



event clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Calls the pfc_save event on the window.
//
//////////////////////////////////////////////////////////////////////////////

parent.event pfc_save()
end event

type cb_retrieve from u_cb within w_ddcalsamp 

end type


event clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Calls the of_Retrieve function on the DataWindow.
//
//////////////////////////////////////////////////////////////////////////////

//  Call the of_Retrieve function to retrieve the data.
dw_1.of_Retrieve()

end event
