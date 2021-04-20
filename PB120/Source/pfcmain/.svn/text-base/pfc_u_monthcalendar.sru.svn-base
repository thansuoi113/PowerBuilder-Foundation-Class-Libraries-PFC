HA$PBExportHeader$pfc_u_monthcalendar.sru
forward
global type pfc_u_monthcalendar from monthcalendar
end type
end forward

global type pfc_u_monthcalendar from monthcalendar
integer width = 1006
integer height = 760
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long titletextcolor = 134217742
long trailingtextcolor = 134217745
long monthbackcolor = 1073741824
long titlebackcolor = 134217741
integer maxselectcount = 31
integer scrollrate = 1
boolean todaysection = true
boolean todaycircle = true
boolean border = true
borderstyle borderstyle = stylelowered!
end type
global pfc_u_monthcalendar pfc_u_monthcalendar

on pfc_u_monthcalendar.create
call super::create
TriggerEvent(this, "constructor")
end on

on pfc_u_monthcalendar.destroy
TriggerEvent(this, "destructor")
call super::destroy
end on

