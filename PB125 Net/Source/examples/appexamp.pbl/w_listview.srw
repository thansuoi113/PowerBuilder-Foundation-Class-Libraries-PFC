forward
global type w_listview from w_main
end type
type lv_1 from u_lv within w_listview
end type
type cb_close from u_cb within w_listview
end type
end forward


global type w_listview from w_main 

lv_1 lv_1 
cb_close cb_close 
end type


global w_listview w_listview

event open;call super::open;If lv_1.of_SetDatasource("d_products", SQLCA, "description", "picture_name") < 0 Then
	MessageBox("Error", "Error in of_setdatasource", Exclamation!)
End If

lv_1.of_AddColumns()

lv_1.Post of_populate()

end event

on w_listview.create
int iCurrent
call super::create
this.lv_1=create lv_1
this.cb_close=create cb_close
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.lv_1
this.Control[iCurrent+2]=this.cb_close
end on

on w_listview.destroy
call super::destroy
destroy(this.lv_1)
destroy(this.cb_close)
end on

type lv_1 from u_lv within w_listview 

end type



event constructor;call u_lv::constructor;ib_RMBMenu = True
end event

type cb_close from u_cb within w_listview 

end type


event clicked;call u_cb::clicked;parent.event pfc_close()
end event
