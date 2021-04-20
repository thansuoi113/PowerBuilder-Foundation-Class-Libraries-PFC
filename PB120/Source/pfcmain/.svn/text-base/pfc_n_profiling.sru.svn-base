HA$PBExportHeader$pfc_n_profiling.sru
forward
global type pfc_n_profiling from profiling
end type
end forward

global type pfc_n_profiling from profiling
end type
global pfc_n_profiling pfc_n_profiling

on pfc_n_profiling.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_profiling.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

