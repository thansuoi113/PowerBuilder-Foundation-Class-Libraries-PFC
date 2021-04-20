HA$PBExportHeader$w_splash.srw
forward
global type w_splash from pfc_w_splash
end type
type p_powerbuilder from u_p within w_splash
end type
end forward

global type w_splash from pfc_w_splash
int X=416
int Y=464
int Width=2208
int Height=1224
p_powerbuilder p_powerbuilder
end type
global w_splash w_splash

on w_splash.create
int iCurrent
call pfc_w_splash::create
this.p_powerbuilder=create p_powerbuilder
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=p_powerbuilder
end on

on w_splash.destroy
call pfc_w_splash::destroy
destroy(this.p_powerbuilder)
end on

event pfc_preopen;call super::pfc_preopen;this.of_setbase(true)
This.inv_base.of_center()
end event

type st_copyright from pfc_w_splash`st_copyright within w_splash
boolean Visible=false
end type

type st_version from pfc_w_splash`st_version within w_splash
boolean Visible=false
end type

type st_application from pfc_w_splash`st_application within w_splash
int X=27
int Y=1236
end type

type gb_allaround from pfc_w_splash`gb_allaround within w_splash
boolean Visible=false
end type

type p_splash from pfc_w_splash`p_splash within w_splash
boolean Visible=false
end type

type p_powerbuilder from u_p within w_splash
int X=0
int Y=0
int Width=2213
int Height=1224
string PictureName="splash.bmp"
end type

