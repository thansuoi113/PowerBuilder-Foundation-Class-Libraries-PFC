forward
global type pfc_u_st_hsplitbar from statictext
end type
end forward


global type pfc_u_st_hsplitbar from statictext 

event lbuttonup pbm_lbuttonup
event lbuttondown pbm_lbuttondown
event mousemove pbm_mousemove
end type

global pfc_u_st_hsplitbar pfc_u_st_hsplitbar

type variables
Private:
     boolean ib_dragable
     dragobject  idrg_leftpane
     dragobject  idrg_rightpane


end variables

event lbuttonup;ib_dragable = FALSE
parent.TriggerEvent (resize!)
end event

event lbuttondown;ib_dragable = TRUE
this.SetPosition (ToTop!)
end event

event mousemove;IF ib_dragable THEN
	integer li_pointerx
	integer li_workspacewidth
	WINDOW lw_parent

	lw_parent = PARENT
	li_pointerx = lw_parent.PointerX ( )
	li_workspacewidth = lw_parent.WorkSpaceWidth ( )

	CHOOSE CASE li_pointerx
		CASE IS < 150
			this.X = 150
		CASE IS > (li_workspacewidth - 150)
			this.X = li_workspacewidth - 150
		CASE ELSE
			this.X = li_pointerx
	END CHOOSE
END IF

end event

event constructor;this.y = 1
this.width = 23
end event
