HA$PBExportHeader$pfc_u_st_splitbar.sru
$PBExportComments$PFC SplitBar class
forward
global type pfc_u_st_splitbar from u_st
end type
end forward

global type pfc_u_st_splitbar from u_st
int Width=535
int Height=20
boolean Enabled=true
string Text=""
long BackColor=8421504
event mousemove pbm_mousemove
event lbuttonup pbm_lbuttonup
end type
global pfc_u_st_splitbar pfc_u_st_splitbar

type variables
Public:

//-- Define the "style" of split bar. --
constant integer VERTICAL = 1
constant integer HORIZONTAL = 2

//-- Define the "Register" type. --
constant integer LEFT=1
constant integer RIGHT=2
constant integer ABOVE=3
constant integer BELOW=4

Protected:

//-- Define the "Extreme points" constants. --
constant integer LEFTMOST=1
constant integer RIGHTMOST=2
constant integer TOPMOST=3
constant integer BOTTOMMOST=4

constant integer UNITIALIZED = -32000

//-- Define default icons. --
string	is_verticalpointer ='SizeWE!'
string	is_horizontalpointer ='SizeNS!'


// -- Registered information. --
integer	ii_lefttopbound
dragobject idrg_lefttop[]
real	ir_lefttopx[]
real	ir_lefttopy[]
real	ir_lefttopwidth[]
real	ir_lefttopheight[]
integer	ii_rightbottombound
dragobject idrg_rightbottom[] 
real	ir_rightbottomx[]
real	ir_rightbottomy[]
real	ir_rightbottomwidth[]
real	ir_rightbottomheight[]

// --Other. --
integer	ii_style = -1		// Default to negative value.
Integer	ii_barwidth = -1		// Default to negative value.
long	il_barcolor=78682240
long	il_barmovecolor=8421504
integer	ii_minobjectsize = 20
boolean	ib_performredraw=True

//-- Internal attributes. --
boolean	ib_supported = True
integer	ii_prevpositionx = UNITIALIZED
integer	ii_prevpositiony = UNITIALIZED
window	iw_parent
userobject iuo_parent
tab	itab_parent
Integer	ii_rounding=5

end variables

forward prototypes
public function integer of_setbarcolor (long al_color)
public function integer of_setbarmovecolor (long al_color)
protected function integer of_lbuttonup (unsignedlong aul_flags, integer ai_xpos, integer ai_ypos)
protected function integer of_mousemove (unsignedlong aul_flags, integer ai_xpos, integer ai_ypos)
public function integer of_register (dragobject adrg_object, integer ai_position)
protected function integer of_updateobjectdata ()
protected function integer of_redraw (integer ai_prevx, integer ai_prevwidth, integer ai_prevy, integer ai_prevheight)
public function integer of_getextremepoint (integer ai_extremetype)
public function integer of_SetMinObjectSize (integer ai_minsize)
public function integer of_getminobjectsize ()
public function integer of_getbarcolor ()
public function string of_GetHorizontalPointer ()
public function string of_GetVerticalPointer ()
public function integer of_sethorizontalpointer (string as_icon)
public function integer of_setverticalpointer (string as_icon)
public function integer of_GetBarMoveColor ()
public function integer of_getinfo (ref n_cst_infoattrib anv_infoattrib)
protected function boolean of_issupported ()
end prototypes

event mousemove;//////////////////////////////////////////////////////////////////////////////
//
//	Event: 			mousemove
//
//	Arguments:		
//  flags
//  xpos
//	 ypos
//
//	Returns:  		None.
//
//	Description:	Perform the Mouse Move processing.
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

If Not KeyDown(keyLeftButton!) Then
	Return
End If

of_MouseMove(flags, xpos, ypos)

end event

event lbuttonup;call super::lbuttonup;//////////////////////////////////////////////////////////////////////////////
//
//	Event: 			lbuttonup
//
//	Arguments:		
//  flags
//  xpos
//	 ypos
//
//	Returns:  		None.
//
//	Description:	Perform the Left Button Up processing.
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

of_lbuttonup(flags, xpos, ypos)
end event

public function integer of_setbarcolor (long al_color);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SetBarColor
//
//	Access:  		Public
//
//	Arguments:	
//  al_color		The desired color.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Set the Non-Moving Split Bar Color.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Validate the argument.
If IsNull(al_color) Or al_color<0 Then
	Return -1
End If

// Set the color.
il_barcolor = al_color

// Start using the requested color.
this.BackColor = il_barcolor

Return 1
end function

public function integer of_setbarmovecolor (long al_color);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SetBarMoveColor
//
//	Access:  		Public
//
//	Arguments:	
//  al_color		The desired color.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Set the Moving Split Bar Color.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Validate the argument.
If IsNull(al_color) Or al_color<0 Then
	Return -1
End If

il_barmovecolor = al_color
Return 1
end function

protected function integer of_lbuttonup (unsignedlong aul_flags, integer ai_xpos, integer ai_ypos);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_LButtonUp
//
//	Access:  		Protected
//
//	Arguments:		
//	 aul_flags
//  ai_xpos
//  ai_ypos
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Resize the objects according to the bar that was just moved
//						and other service attributes.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer	li_cnt
Integer 	li_deltax, li_deltay
Integer	li_pointerx, li_pointery
Integer	li_minx, li_maxx, li_miny, li_maxy
Integer	li_x, li_y, li_width, li_height

// Validate required values.
If ii_style <0 or ii_barwidth <0 Then 
	Return -1
End If

// Validate that objects were registered.
If UpperBound(idrg_lefttop) =0 Or UpperBound(idrg_rightbottom) =0 Then
	Return -1
End If

this.SetPosition(ToTop!)

// Change to the base color.
this.BackColor = il_barcolor

// Validate that the bar has been moved.
If ii_prevpositionx = UNITIALIZED Or ii_prevpositiony = UNITIALIZED Then
	Return 0
End If

// Get the new position.
If IsValid(iuo_parent) Then	
	li_pointerx = iuo_parent.PointerX()
	li_pointery = iuo_parent.PointerY()	
ElseIf IsValid(itab_parent) Then
	li_pointerx = itab_parent.PointerX()
	li_pointery = itab_parent.PointerY()
ElseIf IsValid(iw_parent) Then
	li_pointerx = iw_parent.PointerX()
	li_pointery = iw_parent.PointerY()
Else
	// Reset the Previous position variables to UNITIALIZED.
	ii_prevpositionx = UNITIALIZED
	ii_prevpositiony = UNITIALIZED
	Return -1
End If

// Calculate the Extreme points the split bars can be moved.
If ii_style = HORIZONTAL Then
	li_miny = of_GetExtremePoint(TOPMOST)
	li_maxy = of_GetExtremePoint(BOTTOMMOST)
	If li_pointery < li_miny Then
		li_pointery = li_miny
	ElseIf li_pointery > li_maxy Then
		li_pointery = li_maxy
	End If	
ElseIf ii_style = VERTICAL Then
	li_minx = of_GetExtremePoint(LEFTMOST)
	li_maxx = of_GetExtremePoint(RIGHTMOST)
	If li_pointerx < li_minx Then
		li_pointerx = li_minx
	ElseIf li_pointerx > li_maxx Then
		li_pointerx = li_maxx
	End If
End If

// Calculate delta values.
li_deltax = li_pointerx - ii_prevpositionx
li_deltay = li_pointery - ii_prevpositiony

// Minimize size rounding problems.
of_UpdateObjectData()

If ii_style = HORIZONTAL Then
	// Position bar on its new location.
	this.Y = li_pointery
	// Refresh the Width of the bar.
	this.Height = ii_barwidth

	// Resize the objects above the horizontal split bar.
	For li_cnt = 1 to UpperBound(idrg_lefttop)
		If IsValid(idrg_lefttop[li_cnt]) Then
			ir_lefttopheight[li_cnt] += li_deltay		
			idrg_lefttop[li_cnt].Resize(ir_lefttopwidth[li_cnt], ir_lefttopheight[li_cnt])
		End If
	Next
	
	// Resize the objects below the horizontal split bar.	
	For li_cnt = 1 to UpperBound(idrg_rightbottom)
		If IsValid(idrg_rightbottom[li_cnt]) Then
			ir_rightbottomy[li_cnt] += li_deltay		
			ir_rightbottomheight[li_cnt] -= li_deltay		

			idrg_rightbottom[li_cnt].Move (ir_rightbottomx[li_cnt], ir_rightbottomy[li_cnt])
			idrg_rightbottom[li_cnt].Resize (ir_rightbottomwidth[li_cnt], ir_rightbottomheight[li_cnt])
		End If
	Next	

ElseIf ii_style = VERTICAL Then
	// Position bar on its new location.	
	this.X = li_pointerx
	// Refresh the Width of the bar.
	this.Width = ii_barwidth	
	
	// Resize the objects left of the verticalbar.
	For li_cnt = 1 to UpperBound(idrg_lefttop)
		If IsValid(idrg_lefttop[li_cnt]) Then
			ir_lefttopwidth[li_cnt] += li_deltax
			idrg_lefttop[li_cnt].Resize(ir_lefttopwidth[li_cnt], ir_lefttopheight[li_cnt])
		End If
	Next
	
	// Resize the objects right of the verticalbar.	
	For li_cnt = 1 to UpperBound(idrg_rightbottom)
		If IsValid(idrg_rightbottom[li_cnt]) Then
			ir_rightbottomx[li_cnt] += li_deltax	
			ir_rightbottomWidth[li_cnt] -= li_deltax
			idrg_rightbottom[li_cnt].Move (ir_rightbottomx[li_cnt], ir_rightbottomy[li_cnt])
			idrg_rightbottom[li_cnt].Resize(ir_rightbottomWidth[li_cnt], ir_rightbottomHeight[li_cnt])
		End If
	Next
End If

// Reset the Previous position variables to UNITIALIZED.
ii_prevpositionx = UNITIALIZED
ii_prevpositiony = UNITIALIZED
Return 1
end function

protected function integer of_mousemove (unsignedlong aul_flags, integer ai_xpos, integer ai_ypos);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_MouseMove
//
//	Access:  		Public
//
//	Arguments:		
//  aul_flags
//  ai_xpos
//  ai_ypos
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	One of the split bars is being moved.  Refresh the location
//						of the appropriate splitbar(s) and perform redraws if requested.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer	li_cnt
Integer	li_pointerx, li_pointery
Integer	li_minx, li_maxx, li_miny, li_maxy
Integer	li_prevx
Integer	li_prevwidth
Integer	li_prevheight
Integer	li_prevy
Integer	li_upperbound
Integer 	li_parentx, li_parenty
string	ls_redraw
Integer	li_x, li_y, li_width, li_height

// Validate required values.
If ii_style < 0 Then 
	Return -1
End If

// Validate that objects were registered.
If UpperBound(idrg_lefttop) =0 Or UpperBound(idrg_rightbottom) =0 Then
	Return -1
End If

// Always keep the Split Bar on top of other objects.
this.SetPosition(ToTop!)

// Store the Begin Movement information.
If ii_prevpositionx = UNITIALIZED or ii_prevpositiony = UNITIALIZED Then
	ii_prevpositionx = This.X
	ii_prevpositiony = This.Y
End If

// Store the previous placement information.
li_prevx = this.X
li_prevwidth = this.Width
li_prevy = this.Y 
li_prevheight = this.Height

// Get the new position.
If IsValid(iuo_parent) Then	
	li_pointerx = iuo_parent.PointerX()
	li_pointery = iuo_parent.PointerY()	
ElseIf IsValid(itab_parent) Then
	li_pointerx = itab_parent.PointerX()
	li_pointery = itab_parent.PointerY()
ElseIf IsValid(iw_parent) Then
	li_pointerx = iw_parent.PointerX()
	li_pointery = iw_parent.PointerY()
Else
	Return -1
End If

// Calculate the Extreme points the split bars can be moved.
If ii_style = HORIZONTAL Then
	li_miny = of_GetExtremePoint(TOPMOST)
	li_maxy = of_GetExtremePoint(BOTTOMMOST)
	If li_pointery < li_miny Then
		li_pointery = li_miny
	ElseIf li_pointery > li_maxy Then
		li_pointery = li_maxy
	End If	
ElseIf ii_style = VERTICAL Then
	li_minx = of_GetExtremePoint(LEFTMOST)
	li_maxx = of_GetExtremePoint(RIGHTMOST)
	If li_pointerx < li_minx Then
		li_pointerx = li_minx
	ElseIf li_pointerx > li_maxx Then
		li_pointerx = li_maxx
	End If
End If

// Change to the "Moving" color.
this.BackColor = il_barmovecolor

If ii_style = HORIZONTAL Then
		
	// Position bar on its new location.
	this.Y = li_pointery
	// Refresh the Width of the bar.
	this.Height = ii_barwidth
		
	// Perform redraws when appropriate.
	If ib_performredraw Then
		If (li_prevy <> this.Y) Then
			of_Redraw(li_prevx, li_prevwidth, li_prevy, li_prevheight)
		End If
	End If

ElseIf ii_style = VERTICAL Then
	
	// Position bar on its new location.		
	this.X = li_pointerx
	// Refresh the Width of the bar.
	this.Width = ii_barwidth	

	// Perform redraws when appropriate.
	If ib_performredraw Then
		If (li_prevx <> this.X) Then
			of_Redraw(li_prevx, li_prevwidth, li_prevy, li_prevheight)
		End If
	End If
		
End If

Return 1

end function

public function integer of_register (dragobject adrg_object, integer ai_position);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_Register
//
//	Access:  		public
//
//	Arguments:
//  adrg_object	The object to register with the service.
//  ai_position	The position of the object in relation to the splitbar.
//	
//	Returns:  		integer
//						1 if it succeeds 
//						-1 if an error registering the objects occurs.
//
//	Description:  	Register controls which need to either be moved and/or resized
//						when the split bar object is moved.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer	li_rc
Integer	li_upperbound
Integer	li_obj

// Validate required values.
If ii_style <0 or ii_barwidth <0 Then 
	Return -1
End If

// Validate the dragobject.
If IsNull(adrg_object) Or Not IsValid(adrg_object) Then 
	Return -1
End If

// Validate the position parameter.
If IsNull(ai_position) Or ai_position < 0 Or ai_position > 4 Then 
	Return -1
Else
	If (ii_style = HORIZONTAL) And &
		(ai_position = LEFT Or ai_position = RIGHT) Then
		Return -1
	ElseIf (ii_style = VERTICAL) And &
		(ai_position = ABOVE Or ai_position = BELOW) Then
		Return -1
	End If
End If

// Make sure this object is not already registered on the left/top array.
li_upperbound = UpperBound (idrg_lefttop)
For li_obj = 1 to li_upperbound
	If IsValid(idrg_lefttop[li_obj]) Then
		If adrg_object = idrg_lefttop[li_obj] Then
			Return -1
		End If
	End If
Next

// Make sure this object is not already registered on the right/bottom array.
li_upperbound = UpperBound (idrg_rightbottom)
For li_obj = 1 to li_upperbound
	If IsValid(idrg_rightbottom[li_obj]) Then
		If adrg_object = idrg_rightbottom[li_obj] Then
			Return -1
		End If
	End If
Next

// Register the new object.
If ai_position = LEFT Or ai_position = ABOVE Then
	ii_lefttopbound = UpperBound (idrg_lefttop) + 1
	idrg_lefttop[ii_lefttopbound] = adrg_object
	ir_lefttopx[ii_lefttopbound] = adrg_object.X
	ir_lefttopy[ii_lefttopbound] = adrg_object.Y
	ir_lefttopwidth[ii_lefttopbound] = adrg_object.Width
	ir_lefttopheight[ii_lefttopbound] = adrg_object.Height	
Else
	ii_rightbottombound = UpperBound (idrg_rightbottom) + 1
	idrg_rightbottom[ii_rightbottombound] = adrg_object	
	ir_rightbottomx[ii_rightbottombound] = adrg_object.X
	ir_rightbottomy[ii_rightbottombound] = adrg_object.Y
	ir_rightbottomwidth[ii_rightbottombound] = adrg_object.Width
	ir_rightbottomheight[ii_rightbottombound] = adrg_object.Height		
End If

Return 1
end function

protected function integer of_updateobjectdata ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_UpdateObjectData
//
//	Access:  		Protected
//
//	Arguments:		None.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Update the registered object data in order to minimize
//						rounding problems.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer li_cnt
Integer li_upperbound

li_upperbound = Upperbound (idrg_lefttop)	
For li_cnt = 1 to li_upperbound
	If IsValid(idrg_lefttop[li_cnt]) Then
		If abs(ir_lefttopx[li_cnt] - idrg_lefttop[li_cnt].X) > ii_rounding Then
			ir_lefttopx[li_cnt] = idrg_lefttop[li_cnt].X
		End If	
		If abs(ir_lefttopy[li_cnt] - idrg_lefttop[li_cnt].Y) > ii_rounding Then
			ir_lefttopy[li_cnt] = idrg_lefttop[li_cnt].Y
		End If	
		If abs(ir_lefttopwidth[li_cnt] - idrg_lefttop[li_cnt].Width) > ii_rounding Then
			ir_lefttopwidth[li_cnt] = idrg_lefttop[li_cnt].Width
		End If	
		If abs(ir_lefttopheight[li_cnt] - idrg_lefttop[li_cnt].Height) > ii_rounding Then
			ir_lefttopheight[li_cnt] = idrg_lefttop[li_cnt].Height
		End If			
	End If
Next
	
li_upperbound = Upperbound (idrg_rightbottom)	
For li_cnt = 1 to li_upperbound
	If IsValid(idrg_rightbottom[li_cnt]) Then
		If abs(ir_rightbottomx[li_cnt] - idrg_rightbottom[li_cnt].X) > ii_rounding Then
			ir_rightbottomx[li_cnt] = idrg_rightbottom[li_cnt].X
		End If	
		If abs(ir_rightbottomy[li_cnt] - idrg_rightbottom[li_cnt].Y) > ii_rounding Then
			ir_rightbottomy[li_cnt] = idrg_rightbottom[li_cnt].Y
		End If	
		If abs(ir_rightbottomwidth[li_cnt] - idrg_rightbottom[li_cnt].Width) > ii_rounding Then
			ir_rightbottomwidth[li_cnt] = idrg_rightbottom[li_cnt].Width
		End If	
		If abs(ir_rightbottomheight[li_cnt] - idrg_rightbottom[li_cnt].Height) > ii_rounding Then
			ir_rightbottomheight[li_cnt] = idrg_rightbottom[li_cnt].Height
		End If			
	End If
Next

Return 1
end function

protected function integer of_redraw (integer ai_prevx, integer ai_prevwidth, integer ai_prevy, integer ai_prevheight);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_Redraw
//
//	Access:  		protected
//
//	Arguments:		
//	 ai_prevx 		The bar previous X location.
//	 ai_prevwidth 	The bar previous Width.
//	 ai_prevy 		The bar previous Y location.
//	 ai_prevheight The bar previous Height.
//
//	Returns:  		Integer
//						1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description:	Perform a Redraw on those object which may be still showing
//						the bar on its previous position.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer li_cnt

// Validate required values.
If ii_style <0 or ii_barwidth <0 Then 
	Return -1
End If

If ii_style = HORIZONTAL Then
	// Redraw the objects above the Horizontal Split Bar.
	For li_cnt = 1 to ii_lefttopbound
		If IsValid(idrg_lefttop[li_cnt]) Then
			If (ai_prevy >= idrg_lefttop[li_cnt].Y Or &
				 ai_prevy + ai_prevheight >= idrg_lefttop[li_cnt].Y) And &
				ai_prevy < idrg_lefttop[li_cnt].Y + idrg_lefttop[li_cnt].Height Then				
				idrg_lefttop[li_cnt].SetRedraw(True)
			End If
		End If
	Next

	// Redraw the objects below the Horizontal Split Bar.
	For li_cnt = 1 to ii_rightbottombound
		If IsValid(idrg_rightbottom[li_cnt]) Then
			If (ai_prevy >= idrg_rightbottom[li_cnt].Y Or & 
				 ai_prevy + ai_prevheight >= idrg_rightbottom[li_cnt].Y ) And &
				ai_prevy < idrg_rightbottom[li_cnt].Y + idrg_rightbottom[li_cnt].Height Then				
				idrg_rightbottom[li_cnt].SetRedraw(True)
			End If
		End If
	Next		
ElseIf ii_style = VERTICAL Then
	
	// Redraw the objects left of the Vertical Split Bar.				
	For li_cnt = 1 to ii_lefttopbound
		If IsValid(idrg_lefttop[li_cnt]) Then
			If (ai_prevx >= idrg_lefttop[li_cnt].X Or & 
				 ai_prevx + ai_prevwidth >= idrg_lefttop[li_cnt].X) And &
				ai_prevx < idrg_lefttop[li_cnt].X + idrg_lefttop[li_cnt].Width Then				
				idrg_lefttop[li_cnt].SetRedraw(True)
			End If
		End If
	Next

	// Redraw the objects right of the Vertical Split Bar.				
	For li_cnt = 1 to ii_rightbottombound
		If IsValid(idrg_rightbottom[li_cnt]) Then
			If (ai_prevx >= idrg_rightbottom[li_cnt].X Or & 
				 ai_prevx + ai_prevwidth >= idrg_rightbottom[li_cnt].X) And &
				ai_prevx < idrg_rightbottom[li_cnt].X + idrg_rightbottom[li_cnt].Width Then				
				idrg_rightbottom[li_cnt].SetRedraw(True)
			End If
		End If
	Next		
End If

Return 1
end function

public function integer of_getextremepoint (integer ai_extremetype);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetExtremePoint
//
//	Access:  		Public
//
//	Arguments:		
//	 ai_extremetype The extreme point desired.  Valid values are:
//						LEFTMOST=1
//						RIGHTMOST=2
//						TOPMOST=3
//						BOTTOMMOST=4
//
//	Returns:  		Integer
//						Returns the desired extreme point.
//
//	Description: 	Get the desired extreme point coordinate.  The coordinate is 
//						the maximum or minimum point where the split bar can be 
//						moved to.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////


Integer li_point
Integer li_extremepoint
Integer li_rc
Integer li_cnt
constant Integer LOW_VALUE = -999999
constant Integer HIGH_VALUE = 999999

CHOOSE CASE ai_extremetype
	CASE LEFTMOST

		// Initialize the extreme point.
		li_point = LOW_VALUE

		// Find the left most point.
		For li_cnt = 1 to UpperBound(idrg_lefttop)
			If IsValid(idrg_lefttop[li_cnt]) Then
				If idrg_lefttop[li_cnt].X > li_point Then 
					li_point = idrg_lefttop[li_cnt].X
				End If
			End If
		Next

		// Take into account the the minimum object size.
		li_extremepoint = li_point + ii_minobjectsize
		
	CASE RIGHTMOST		

		// Initialize the extreme point.
		li_point = HIGH_VALUE

		// Find the right most point.
		For li_cnt = 1 to UpperBound(idrg_rightbottom)
			If IsValid(idrg_rightbottom[li_cnt]) Then
				If idrg_rightbottom[li_cnt].X + idrg_rightbottom[li_cnt].Width < li_point Then 
					li_point = idrg_rightbottom[li_cnt].X + idrg_rightbottom[li_cnt].Width
				End If
			End If
		Next
	
		// Take into account the split bar itself and the minimum object size.
		li_extremepoint = li_point - (ii_barwidth + ii_minobjectsize)		
	
	CASE TOPMOST		
		
		// Initialize the extreme point.
		li_point = LOW_VALUE
		
		// Find the top most point.		
		For li_cnt = 1 to UpperBound(idrg_lefttop)
			If IsValid(idrg_lefttop[li_cnt]) Then
				If idrg_lefttop[li_cnt].Y > li_point Then 
					li_point = idrg_lefttop[li_cnt].Y
				End If
			End If
		Next

		// Take into account the the minimum object size.
		li_extremepoint = li_point + ii_minobjectsize
		
	CASE BOTTOMMOST	
		
		// Initialize the extreme point.
		li_point = HIGH_VALUE		
		
		// Find the bottom most point.		
		For li_cnt = 1 to UpperBound(idrg_rightbottom)
			If IsValid(idrg_rightbottom[li_cnt]) Then
				If idrg_rightbottom[li_cnt].Y + idrg_rightbottom[li_cnt].Height < li_point Then 
					li_point = idrg_rightbottom[li_cnt].Y + idrg_rightbottom[li_cnt].Height
				End If
			End If
		Next

		// Take into account the split bar itself and the minimum object size.
		li_extremepoint = li_point - (ii_barwidth + ii_minobjectsize)		
		
	CASE Else
		Return -1
END CHOOSE

// Make sure the initial value was replaced.
If li_point = LOW_VALUE or li_point = HIGH_VALUE Then 
	Return -1
End If

Return li_extremepoint
end function

public function integer of_SetMinObjectSize (integer ai_minsize);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SetMinObjectSize
//
//	Access:  		Public
//
//	Arguments:	
//  ai_minsize		The desired minimum object size for all registered objects.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	
//	Set the desired minimum object size for all registered objects.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Validate the argument.
If IsNull(ai_minsize) or ai_minsize < 0 Then
	Return -1
End If

ii_minobjectsize  = ai_minsize
Return 1
end function

public function integer of_getminobjectsize ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetMinObjectSize
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		Integer
//		The desired minimum object size for all registered objects.
//
//	Description: 	
//	Gets the desired minimum object size for all registered objects.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Return ii_minobjectsize
end function

public function integer of_getbarcolor ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetBarColor
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		Integer
//		The non-moving Split Bar color.
//
//	Description: 	
//		Gets the Non-Moving Split Bar Color.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Return il_barcolor
end function

public function string of_GetHorizontalPointer ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetHorizontalPointer
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		String
//		Returns the Horizontal Icon.
//
//	Description: 	
//		Reports the Horizontal Icon.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Return is_horizontalpointer
end function

public function string of_GetVerticalPointer ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetVerticalPointer
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		String
//		Returns the Vertical Icon.
//
//	Description: 	
//		Reports the Vertical Icon.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Return is_verticalpointer
end function

public function integer of_sethorizontalpointer (string as_icon);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SetHorizontalPointer
//
//	Access:  		Public
//
//	Arguments:	
//  as_icon			The desired icon.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Set the Horizontal Icon.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer	li_rc

// Validate the argument.
If IsNull(as_icon) Or Len(Trim(as_icon)) = 0 Then
	Return -1
End If

// Set the icon.
is_horizontalpointer = as_icon
If ii_style = HORIZONTAL Then
	this.Pointer = as_icon
End If

Return 1
end function

public function integer of_setverticalpointer (string as_icon);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SetVerticalPointer
//
//	Access:  		Public
//
//	Arguments:	
//  as_icon			The desired icon.
//
//	Returns:  		Integer
//						Returns 1 if it succeeds and$$HEX1$$a000$$ENDHEX$$-1 if an error occurs.
//
//	Description: 	Set the Vertical Icon.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Integer	li_rc

// Validate the argument.
If IsNull(as_icon) Or Len(Trim(as_icon)) = 0 Then
	Return -1
End If

// Set the icon.
is_verticalpointer = as_icon
If ii_style = VERTICAL Then
	this.Pointer = as_icon
End If

Return 1
end function

public function integer of_GetBarMoveColor ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetBarMoveColor
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		Integer
//		The moving Split Bar color.
//
//	Description: 	
//		Gets the Moving Split Bar Color.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Return il_barmovecolor
end function

public function integer of_getinfo (ref n_cst_infoattrib anv_infoattrib);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_GetInfo
//
//	Access:   		Public
//
//	Arguments:		
//		anv_infoattrib	(By reference) The Information attributes.
//
//	Returns:  		Integer
//	 1 for success.
//	-1 for error.
//
//	Description:  
//	 Gets the Object Information.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0    Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

// Populate Information.
anv_infoattrib.is_name = 'SplitBar'
anv_infoattrib.is_description = 'SplitBar'

Return 1
end function

protected function boolean of_issupported ();//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_IsSupported
//
//	Access:  		Public
//
//	Arguments:		None
//
//	Returns:  		Boolean
//	True if running in a supported environment.
//
//	Description: 	
//	Dtermines if object is running in a supported environment.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	6.0   Initial version
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

Environment lenv_object

GetEnvironment (lenv_object)

If lenv_object.ostype = Macintosh! Then
	Return False
End If

Return True
end function

event constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event: 			constructor
//
//	Arguments:		None.
//
//	Returns:  		None.
//
//	Description:	SplitBar Object. 
//		Initialize required information by the object.
//
//	*Note: The Style and the Width (this.Width for a VerticalBar and this.Height
//			for a HorizontalBar) are not changeable past this point.  For example,
//			an outside entity should not change this.Height for a HorizontalBar.
//
//////////////////////////////////////////////////////////////////////////////
//	
//	Revision History
//
//	Version
//	6.0   Initial version - Claudio J. Quant
//
//////////////////////////////////////////////////////////////////////////////
//
/*
 * Open Source PowerBuilder Foundation Class Libraries
 *
 * Copyright (c) 2004-2005, All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted in accordance with the GNU Lesser General
 * Public License Version 2.1, February 1999
 *
 * http://www.gnu.org/copyleft/lesser.html
 *
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals and was originally based on software copyright (c) 
 * 1996-2004 Sybase, Inc. http://www.sybase.com.  For more
 * information on the Open Source PowerBuilder Foundation Class
 * Libraries see http://pfc.codexchange.sybase.com
*/
//
//////////////////////////////////////////////////////////////////////////////

powerobject lpo_parent

// Determine if this object is supported.
ib_supported = of_IsSupported()

// Defined the object to be on Top of other objects.
this.SetPosition(ToTop!)

// Set the object to the Non-Moving Split bar color.
this.BackColor = il_barcolor

// Get and store the parent object.
lpo_parent = this.GetParent()
CHOOSE CASE lpo_parent.TypeOf()
	CASE Window!
		iw_parent = lpo_parent
	CASE UserObject!
		iuo_parent = lpo_parent
	CASE Tab!
		itab_parent = lpo_parent
END CHOOSE

If ib_supported Then
	// Determine object attributes by looking at the object size.
	If this.Height >= this.Width Then
		ii_style = VERTICAL
		this.Pointer = is_verticalpointer
		ii_barwidth = this.Width	
	Else
		ii_style = HORIZONTAL
		this.Pointer = is_horizontalpointer
		ii_barwidth = this.Height
	End If
Else
	// Since it is not supported - hide the object.
	this.Enabled = False
	this.Visible = False
	this.Resize(0,0)
End If

end event

