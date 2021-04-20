HA$PBExportHeader$n_cst_filesrvaix.sru
$PBExportComments$Extension aix File handler service
forward
global type n_cst_filesrvaix from pfc_n_cst_filesrvaix
end type
end forward

global type n_cst_filesrvaix from pfc_n_cst_filesrvaix
end type
global n_cst_filesrvaix n_cst_filesrvaix

on n_cst_filesrvaix.create
TriggerEvent( this, "constructor" )
end on

on n_cst_filesrvaix.destroy
TriggerEvent( this, "destructor" )
end on

