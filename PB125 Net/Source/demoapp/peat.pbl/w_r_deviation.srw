forward
global type w_r_deviation from w_response
end type
type st_1 from u_st within w_r_deviation
end type
type em_deviation from u_em within w_r_deviation
end type
type cb_ok from u_cb within w_r_deviation
end type
type cb_cancel from u_cb within w_r_deviation
end type
type st_2 from u_st within w_r_deviation
end type
end forward


global type w_r_deviation from w_response 

st_1 st_1 
em_deviation em_deviation 
cb_ok cb_ok 
cb_cancel cb_cancel 
st_2 st_2 
end type


global w_r_deviation w_r_deviation

on w_r_deviation.create
int iCurrent
call super::create
this.st_1=create st_1
this.em_deviation=create em_deviation
this.cb_ok=create cb_ok
this.cb_cancel=create cb_cancel
this.st_2=create st_2
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.st_1
this.Control[iCurrent+2]=this.em_deviation
this.Control[iCurrent+3]=this.cb_ok
this.Control[iCurrent+4]=this.cb_cancel
this.Control[iCurrent+5]=this.st_2
end on

on w_r_deviation.destroy
call super::destroy
destroy(this.st_1)
destroy(this.em_deviation)
destroy(this.cb_ok)
destroy(this.cb_cancel)
destroy(this.st_2)
end on

event open;call w_response::open;// Check to see if a value has been passed in
IF message.DoubleParm > 0 THEN
	em_deviation.text = String(message.DoubleParm)
END IF
end event

type st_1 from u_st within w_r_deviation 

end type



type em_deviation from u_em within w_r_deviation 

end type



type cb_ok from u_cb within w_r_deviation 

end type



event clicked;call u_cb::clicked;// Close the window with the value from the deviaiton field / 100 (for %)

decimal	ldc_deviation

SetPointer(HourGlass!)
em_deviation.GetData(ldc_deviation)
CloseWithReturn(parent, ldc_deviation)
end event

type cb_cancel from u_cb within w_r_deviation 

end type



event clicked;call u_cb::clicked;SetPointer(HourGlass!)
Close(Parent)
end event

type st_2 from u_st within w_r_deviation 

end type

