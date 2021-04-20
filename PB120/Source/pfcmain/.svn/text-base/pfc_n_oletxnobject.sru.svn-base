HA$PBExportHeader$pfc_n_oletxnobject.sru
forward
global type pfc_n_oletxnobject from oletxnobject
end type
end forward

global type pfc_n_oletxnobject from oletxnobject
end type
global pfc_n_oletxnobject pfc_n_oletxnobject

on pfc_n_oletxnobject.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_oletxnobject.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

