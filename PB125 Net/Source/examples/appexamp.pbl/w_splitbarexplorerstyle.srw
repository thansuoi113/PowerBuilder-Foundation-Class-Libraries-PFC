forward
global type w_splitbarexplorerstyle from w_main
end type
type rte_topright from u_rte within w_splitbarexplorerstyle
end type
type st_v1 from u_st_splitbar within w_splitbarexplorerstyle
end type
type rte_topleft from u_rte within w_splitbarexplorerstyle
end type
end forward


global type w_splitbarexplorerstyle from w_main 

rte_topright rte_topright 
st_v1 st_v1 
rte_topleft rte_topleft 
end type


global w_splitbarexplorerstyle w_splitbarexplorerstyle

type variables

end variables

on w_splitbarexplorerstyle.create
int iCurrent
call super::create
this.rte_topright=create rte_topright
this.st_v1=create st_v1
this.rte_topleft=create rte_topleft
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.rte_topright
this.Control[iCurrent+2]=this.st_v1
this.Control[iCurrent+3]=this.rte_topleft
end on

on w_splitbarexplorerstyle.destroy
call super::destroy
destroy(this.rte_topright)
destroy(this.st_v1)
destroy(this.rte_topleft)
end on

event pfc_preopen;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	pfc_preopen
//
//	Arguments:
//	None
//
//	Returns:
// None
//
//	Description:
// Register with the SplitBar and Resize service.
//
//////////////////////////////////////////////////////////////////////////////

// Register the controls with the Vertical SplitBar
st_v1.of_Register(rte_topleft, st_v1.LEFT)
st_v1.of_Register(rte_topright, st_v1.RIGHT)

// Window Resize Behavior
of_SetResize(True)
inv_resize.of_Register(rte_topleft, 0, 0, 0, 100)
inv_resize.of_Register(st_v1, 0, 0, 0, 100)
inv_resize.of_Register(rte_topright, 0, 0, 100, 100)

end event

type rte_topright from u_rte within w_splitbarexplorerstyle 

end type



on rte_topright.create
call super::create
HScrollBar=true
VScrollBar=true
RulerBar=true
BackColor=1090519039
InputFieldBackColor=1090519039
end on

type st_v1 from u_st_splitbar within w_splitbarexplorerstyle 

end type



type rte_topleft from u_rte within w_splitbarexplorerstyle 

end type


on rte_topleft.create
call super::create
HScrollBar=true
VScrollBar=true
RulerBar=true
BackColor=1090519039
InputFieldBackColor=1090519039
end on
