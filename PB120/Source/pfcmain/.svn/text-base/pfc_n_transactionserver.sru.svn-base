HA$PBExportHeader$pfc_n_transactionserver.sru
forward
global type pfc_n_transactionserver from transactionserver
end type
end forward

global type pfc_n_transactionserver from transactionserver
end type
global pfc_n_transactionserver pfc_n_transactionserver

on pfc_n_transactionserver.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_transactionserver.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

