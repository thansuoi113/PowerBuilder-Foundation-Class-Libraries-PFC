HA$PBExportHeader$n_cst_platformwin32.sru
$PBExportComments$Extension Win32 Cross Platform service
forward
global type n_cst_platformwin32 from pfc_n_cst_platformwin32
end type
end forward

global type n_cst_platformwin32 from pfc_n_cst_platformwin32
end type
global n_cst_platformwin32 n_cst_platformwin32

on n_cst_platformwin32.create
TriggerEvent( this, "constructor" )
end on

on n_cst_platformwin32.destroy
TriggerEvent( this, "destructor" )
end on

