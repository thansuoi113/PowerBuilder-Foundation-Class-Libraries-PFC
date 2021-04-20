HA$PBExportHeader$pfc_n_tracefile.sru
forward
global type pfc_n_tracefile from tracefile
end type
end forward

global type pfc_n_tracefile from tracefile
end type
global pfc_n_tracefile pfc_n_tracefile

on pfc_n_tracefile.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_tracefile.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

