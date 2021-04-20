HA$PBExportHeader$pfc_n_adoresultset.sru
forward
global type pfc_n_adoresultset from adoresultset
end type
end forward

global type pfc_n_adoresultset from adoresultset
end type
global pfc_n_adoresultset pfc_n_adoresultset

on pfc_n_adoresultset.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_adoresultset.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

