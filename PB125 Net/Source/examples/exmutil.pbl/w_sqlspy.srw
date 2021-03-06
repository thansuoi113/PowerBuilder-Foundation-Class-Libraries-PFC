forward
global type w_sqlspy from pfc_w_sqlspy
end type
end forward


global type w_sqlspy from pfc_w_sqlspy 

end type


global w_sqlspy w_sqlspy

on w_sqlspy.create
call super::create
end on

on w_sqlspy.destroy
call super::destroy
end on

event close;call super::close;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	close
//
//	Description:
//	Notifies the application's main window that the SQL Spy window
// is closing.
//
//////////////////////////////////////////////////////////////////////////////

if IsValid(w_examplemain) then
	w_examplemain.event ue_notify('sqlspywin','close')
end if
end event

event open;call super::open;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	open
//
//	Description:
//	Notifies the application's main window that the SQL Spy window
// is opening.
//
//////////////////////////////////////////////////////////////////////////////

if IsValid(w_examplemain) then
	w_examplemain.event ue_notify('sqlspywin','open')
end if
end event

type cbx_batchmode from pfc_w_sqlspy`cbx_batchmode within w_sqlspy 

end type

