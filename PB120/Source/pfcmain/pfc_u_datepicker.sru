HA$PBExportHeader$pfc_u_datepicker.sru
forward
global type pfc_u_datepicker from datepicker
end type
end forward

global type pfc_u_datepicker from datepicker
integer width = 686
integer height = 100
boolean border = true
borderstyle borderstyle = stylelowered!
date maxdate = Date("2999-12-31")
date mindate = Date("1800-01-01")
integer textsize = -10
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
boolean todaysection = true
boolean todaycircle = true
end type
global pfc_u_datepicker pfc_u_datepicker

on pfc_u_datepicker.create
call super::create
TriggerEvent(this, "constructor")
end on

on pfc_u_datepicker.destroy
TriggerEvent(this, "destructor")
call super::destroy
end on

