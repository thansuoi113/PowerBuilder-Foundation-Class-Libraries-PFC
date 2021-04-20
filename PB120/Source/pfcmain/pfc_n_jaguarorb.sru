HA$PBExportHeader$pfc_n_jaguarorb.sru
forward
global type pfc_n_jaguarorb from jaguarorb
end type
end forward

global type pfc_n_jaguarorb from jaguarorb
unsignedlong handle = 265409360
end type
global pfc_n_jaguarorb pfc_n_jaguarorb

on pfc_n_jaguarorb.create
call super::create
TriggerEvent( this, "constructor" )
end on

on pfc_n_jaguarorb.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

