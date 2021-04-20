HA$PBExportHeader$n_cst_filesrvsol2.sru
$PBExportComments$Extension Solaris File handler service
forward
global type n_cst_filesrvsol2 from pfc_n_cst_filesrvsol2
end type
end forward

global type n_cst_filesrvsol2 from pfc_n_cst_filesrvsol2
end type
global n_cst_filesrvsol2 n_cst_filesrvsol2

on n_cst_filesrvsol2.create
TriggerEvent( this, "constructor" )
end on

on n_cst_filesrvsol2.destroy
TriggerEvent( this, "destructor" )
end on

