HA$PBExportHeader$n_cst_platformhpux.sru
$PBExportComments$Extension hpux Cross Platform service
forward
global type n_cst_platformhpux from pfc_n_cst_platformhpux
end type
end forward

global type n_cst_platformhpux from pfc_n_cst_platformhpux
end type
global n_cst_platformhpux n_cst_platformhpux

on n_cst_platformhpux.create
TriggerEvent( this, "constructor" )
end on

on n_cst_platformhpux.destroy
TriggerEvent( this, "destructor" )
end on

