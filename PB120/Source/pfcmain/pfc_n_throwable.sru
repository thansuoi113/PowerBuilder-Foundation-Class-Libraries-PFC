HA$PBExportHeader$pfc_n_throwable.sru
forward
global type pfc_n_throwable from throwable
end type
end forward

global type pfc_n_throwable from throwable
end type
global pfc_n_throwable pfc_n_throwable

on pfc_n_throwable.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_throwable.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

