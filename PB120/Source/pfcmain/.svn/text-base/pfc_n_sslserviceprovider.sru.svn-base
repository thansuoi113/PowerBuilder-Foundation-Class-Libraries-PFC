HA$PBExportHeader$pfc_n_sslserviceprovider.sru
forward
global type pfc_n_sslserviceprovider from sslserviceprovider
end type
end forward

global type pfc_n_sslserviceprovider from sslserviceprovider
end type
global pfc_n_sslserviceprovider pfc_n_sslserviceprovider

on pfc_n_sslserviceprovider.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_sslserviceprovider.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

