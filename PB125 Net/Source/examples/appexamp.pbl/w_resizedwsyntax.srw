forward
global type w_resizedwsyntax from w_main
end type
type ddplb_object from u_ddplb within w_resizedwsyntax
end type
type lb_attributes from u_lb within w_resizedwsyntax
end type
type mle_describe from u_mle within w_resizedwsyntax
end type
type mle_dotnotation from u_mle within w_resizedwsyntax
end type
type st_object from u_st within w_resizedwsyntax
end type
type st_describe from u_st within w_resizedwsyntax
end type
type st_dotnotation from u_st within w_resizedwsyntax
end type
type st_note from u_st within w_resizedwsyntax
end type
type gb_notes from u_gb within w_resizedwsyntax
end type
type st_attributes from u_st within w_resizedwsyntax
end type
end forward


global type w_resizedwsyntax from w_main 

ddplb_object ddplb_object 
lb_attributes lb_attributes 
mle_describe mle_describe 
mle_dotnotation mle_dotnotation 
st_object st_object 
st_describe st_describe 
st_dotnotation st_dotnotation 
st_note st_note 
gb_notes gb_notes 
st_attributes st_attributes 
end type


global w_resizedwsyntax w_resizedwsyntax

on w_resizedwsyntax.create
int iCurrent
call super::create
this.ddplb_object=create ddplb_object
this.lb_attributes=create lb_attributes
this.mle_describe=create mle_describe
this.mle_dotnotation=create mle_dotnotation
this.st_object=create st_object
this.st_describe=create st_describe
this.st_dotnotation=create st_dotnotation
this.st_note=create st_note
this.gb_notes=create gb_notes
this.st_attributes=create st_attributes
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.ddplb_object
this.Control[iCurrent+2]=this.lb_attributes
this.Control[iCurrent+3]=this.mle_describe
this.Control[iCurrent+4]=this.mle_dotnotation
this.Control[iCurrent+5]=this.st_object
this.Control[iCurrent+6]=this.st_describe
this.Control[iCurrent+7]=this.st_dotnotation
this.Control[iCurrent+8]=this.st_note
this.Control[iCurrent+9]=this.gb_notes
this.Control[iCurrent+10]=this.st_attributes
end on

on w_resizedwsyntax.destroy
call super::destroy
destroy(this.ddplb_object)
destroy(this.lb_attributes)
destroy(this.mle_describe)
destroy(this.mle_dotnotation)
destroy(this.st_object)
destroy(this.st_describe)
destroy(this.st_dotnotation)
destroy(this.st_note)
destroy(this.gb_notes)
destroy(this.st_attributes)
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
// Start the Window Resize Service and register the window's controls.
//
//////////////////////////////////////////////////////////////////////////////

// Start the Window Resize service.
of_SetResize(true)

// Register the window's controls with the service.
inv_resize.of_SetMinSize(1500, 1000)
inv_resize.of_Register(lb_attributes, 0, 0, 100, 0)
inv_resize.of_Register(gb_notes, 0, 0, 100, 0)
inv_resize.of_Register(mle_describe, 0, 0, 100, 50)
inv_resize.of_Register(st_dotnotation, 0, 50, 0, 0)
inv_resize.of_Register(mle_dotnotation, 0, 50, 100, 50)

end event

type ddplb_object from u_ddplb within w_resizedwsyntax 

end type



event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
// Display a value after creation.
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

SelectItem(1)
end event

type lb_attributes from u_lb within w_resizedwsyntax 

end type



type mle_describe from u_mle within w_resizedwsyntax 

end type



type mle_dotnotation from u_mle within w_resizedwsyntax 

end type



type st_object from u_st within w_resizedwsyntax 

end type



type st_describe from u_st within w_resizedwsyntax 

end type



type st_dotnotation from u_st within w_resizedwsyntax 

end type



type st_note from u_st within w_resizedwsyntax 

end type



type gb_notes from u_gb within w_resizedwsyntax 

end type



type st_attributes from u_st within w_resizedwsyntax 

end type

