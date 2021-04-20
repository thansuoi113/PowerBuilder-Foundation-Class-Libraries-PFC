HA$PBExportHeader$pfc_n_exception.sru
forward
global type pfc_n_exception from exception
end type
end forward

global type pfc_n_exception from exception
end type
global pfc_n_exception pfc_n_exception

on pfc_n_exception.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_exception.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

