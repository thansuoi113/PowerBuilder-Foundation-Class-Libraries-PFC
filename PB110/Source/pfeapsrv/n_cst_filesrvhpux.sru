HA$PBExportHeader$n_cst_filesrvhpux.sru
$PBExportComments$Extension hpux File handler service
forward
global type n_cst_filesrvhpux from pfc_n_cst_filesrvhpux
end type
end forward

global type n_cst_filesrvhpux from pfc_n_cst_filesrvhpux
end type
global n_cst_filesrvhpux n_cst_filesrvhpux

on n_cst_filesrvhpux.create
TriggerEvent( this, "constructor" )
end on

on n_cst_filesrvhpux.destroy
TriggerEvent( this, "destructor" )
end on

