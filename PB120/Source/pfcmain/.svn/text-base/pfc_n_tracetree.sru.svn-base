HA$PBExportHeader$pfc_n_tracetree.sru
forward
global type pfc_n_tracetree from tracetree
end type
end forward

global type pfc_n_tracetree from tracetree
end type
global pfc_n_tracetree pfc_n_tracetree

on pfc_n_tracetree.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_tracetree.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

