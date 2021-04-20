HA$PBExportHeader$pfc_u_inkpicture.sru
forward
global type pfc_u_inkpicture from inkpicture
end type
end forward

global type pfc_u_inkpicture from inkpicture
integer width = 480
integer height = 840
end type
global pfc_u_inkpicture pfc_u_inkpicture

on pfc_u_inkpicture.create
call super::create
TriggerEvent(this, "constructor")
end on

on pfc_u_inkpicture.destroy
TriggerEvent(this, "destructor")
call super::destroy
end on

