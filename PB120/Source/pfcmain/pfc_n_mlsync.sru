HA$PBExportHeader$pfc_n_mlsync.sru
forward
global type pfc_n_mlsync from mlsync
end type
end forward

global type pfc_n_mlsync from mlsync
unsignedlong __ptrdata = 266613332
end type
global pfc_n_mlsync pfc_n_mlsync

on pfc_n_mlsync.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_mlsync.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

