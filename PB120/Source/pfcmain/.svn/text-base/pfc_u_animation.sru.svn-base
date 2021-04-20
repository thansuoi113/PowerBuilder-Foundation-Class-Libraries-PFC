HA$PBExportHeader$pfc_u_animation.sru
forward
global type pfc_u_animation from animation
end type
end forward

global type pfc_u_animation from animation
integer width = 686
integer height = 600
boolean border = true
end type
global pfc_u_animation pfc_u_animation

on pfc_u_animation.create
call super::create
TriggerEvent(this, "constructor")
end on

on pfc_u_animation.destroy
TriggerEvent(this, "destructor")
call super::destroy
end on

