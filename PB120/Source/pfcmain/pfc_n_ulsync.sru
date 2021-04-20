HA$PBExportHeader$pfc_n_ulsync.sru
forward
global type pfc_n_ulsync from ulsync
end type
end forward

global type pfc_n_ulsync from ulsync
unsignedlong __ptrdata = 267801120
end type
global pfc_n_ulsync pfc_n_ulsync

on pfc_n_ulsync.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_ulsync.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

