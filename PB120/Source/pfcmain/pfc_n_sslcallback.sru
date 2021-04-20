HA$PBExportHeader$pfc_n_sslcallback.sru
forward
global type pfc_n_sslcallback from sslcallback
end type
end forward

global type pfc_n_sslcallback from sslcallback
end type
global pfc_n_sslcallback pfc_n_sslcallback

on pfc_n_sslcallback.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_sslcallback.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

