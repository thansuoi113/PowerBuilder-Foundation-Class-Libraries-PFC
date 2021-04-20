HA$PBExportHeader$n_cst_platformsol2.sru
$PBExportComments$Extension Solaris Cross Platform service
forward
global type n_cst_platformsol2 from pfc_n_cst_platformsol2
end type
end forward

global type n_cst_platformsol2 from pfc_n_cst_platformsol2
end type
global n_cst_platformsol2 n_cst_platformsol2

on n_cst_platformsol2.create
TriggerEvent( this, "constructor" )
end on

on n_cst_platformsol2.destroy
TriggerEvent( this, "destructor" )
end on

