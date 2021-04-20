HA$PBExportHeader$pfc_u_inkedit.sru
forward
global type pfc_u_inkedit from inkedit
end type
end forward

global type pfc_u_inkedit from inkedit
integer width = 480
integer height = 840
borderstyle borderstyle = stylelowered!
string text = "none"
integer textsize = -10
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
end type
global pfc_u_inkedit pfc_u_inkedit

on pfc_u_inkedit.create
call super::create
TriggerEvent(this, "constructor")
end on

on pfc_u_inkedit.destroy
TriggerEvent(this, "destructor")
call super::destroy
end on

