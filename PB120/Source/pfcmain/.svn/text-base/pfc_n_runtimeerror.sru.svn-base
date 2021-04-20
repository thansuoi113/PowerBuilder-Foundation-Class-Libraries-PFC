HA$PBExportHeader$pfc_n_runtimeerror.sru
forward
global type pfc_n_runtimeerror from runtimeerror
end type
end forward

global type pfc_n_runtimeerror from runtimeerror
end type
global pfc_n_runtimeerror pfc_n_runtimeerror

on pfc_n_runtimeerror.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_runtimeerror.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

