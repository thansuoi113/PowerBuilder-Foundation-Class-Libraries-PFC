HA$PBExportHeader$n_cst_platformaix.sru
$PBExportComments$Extension aix Cross Platform service
forward
global type n_cst_platformaix from pfc_n_cst_platformaix
end type
end forward

global type n_cst_platformaix from pfc_n_cst_platformaix
end type
global n_cst_platformaix n_cst_platformaix

on n_cst_platformaix.create
TriggerEvent( this, "constructor" )
end on

on n_cst_platformaix.destroy
TriggerEvent( this, "destructor" )
end on

