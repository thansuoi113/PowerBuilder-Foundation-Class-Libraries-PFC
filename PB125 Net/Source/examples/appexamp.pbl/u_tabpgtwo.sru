forward
global type u_tabpgtwo from u_tabpg
end type
type rb_allfiles from u_rb within u_tabpgtwo
end type
type rb_findfiles from u_rb within u_tabpgtwo
end type
type gb_1 from u_gb within u_tabpgtwo
end type
type rb_between from u_rb within u_tabpgtwo
end type
type rb_prevmonths from u_rb within u_tabpgtwo
end type
type rb_prevdays from u_rb within u_tabpgtwo
end type
type em_startdate from u_em within u_tabpgtwo
end type
type em_enddate from u_em within u_tabpgtwo
end type
type st_1 from u_st within u_tabpgtwo
end type
type em_months from u_em within u_tabpgtwo
end type
type em_days from u_em within u_tabpgtwo
end type
type st_2 from u_st within u_tabpgtwo
end type
type st_3 from u_st within u_tabpgtwo
end type
end forward


global type u_tabpgtwo from u_tabpg 

rb_allfiles rb_allfiles 
rb_findfiles rb_findfiles 
gb_1 gb_1 
rb_between rb_between 
rb_prevmonths rb_prevmonths 
rb_prevdays rb_prevdays 
em_startdate em_startdate 
em_enddate em_enddate 
st_1 st_1 
em_months em_months 
em_days em_days 
st_2 st_2 
st_3 st_3 
end type


global u_tabpgtwo u_tabpgtwo

on u_tabpgtwo.create
int iCurrent
call u_tabpg::create
this.rb_allfiles=create rb_allfiles
this.rb_findfiles=create rb_findfiles
this.gb_1=create gb_1
this.rb_between=create rb_between
this.rb_prevmonths=create rb_prevmonths
this.rb_prevdays=create rb_prevdays
this.em_startdate=create em_startdate
this.em_enddate=create em_enddate
this.st_1=create st_1
this.em_months=create em_months
this.em_days=create em_days
this.st_2=create st_2
this.st_3=create st_3
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=rb_allfiles
this.Control[iCurrent+2]=rb_findfiles
this.Control[iCurrent+3]=gb_1
this.Control[iCurrent+4]=rb_between
this.Control[iCurrent+5]=rb_prevmonths
this.Control[iCurrent+6]=rb_prevdays
this.Control[iCurrent+7]=em_startdate
this.Control[iCurrent+8]=em_enddate
this.Control[iCurrent+9]=st_1
this.Control[iCurrent+10]=em_months
this.Control[iCurrent+11]=em_days
this.Control[iCurrent+12]=st_2
this.Control[iCurrent+13]=st_3
end on

on u_tabpgtwo.destroy
call u_tabpg::destroy
destroy(this.rb_allfiles)
destroy(this.rb_findfiles)
destroy(this.gb_1)
destroy(this.rb_between)
destroy(this.rb_prevmonths)
destroy(this.rb_prevdays)
destroy(this.em_startdate)
destroy(this.em_enddate)
destroy(this.st_1)
destroy(this.em_months)
destroy(this.em_days)
destroy(this.st_2)
destroy(this.st_3)
end on

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	constructor
//
//	Description:
//	Initializes the values in the controls.
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

em_days.text = "1"
em_months.text = "1"
em_startdate.text = String(Today())
em_enddate.text = String(RelativeDate(Today(), 30))


end event

type rb_allfiles from u_rb within u_tabpgtwo 

end type



event clicked;call super::clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Disables the controls in the group box.
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

em_startdate.enabled = false
em_enddate.enabled = false
em_months.enabled = false
em_days.enabled = false
end event

type rb_findfiles from u_rb within u_tabpgtwo 

end type



event clicked;call super::clicked;//////////////////////////////////////////////////////////////////////////////
//
//	Event:
//	clicked
//
//	Description:
//	Enables the controls in the groupbox.
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

em_startdate.enabled = true
em_enddate.enabled = true
em_months.enabled = true
em_days.enabled = true

end event

type gb_1 from u_gb within u_tabpgtwo 

end type



type rb_between from u_rb within u_tabpgtwo 

end type



type rb_prevmonths from u_rb within u_tabpgtwo 

end type



type rb_prevdays from u_rb within u_tabpgtwo 

end type



type em_startdate from u_em within u_tabpgtwo 

end type



type em_enddate from u_em within u_tabpgtwo 

end type



type st_1 from u_st within u_tabpgtwo 

end type



type em_months from u_em within u_tabpgtwo 

end type



type em_days from u_em within u_tabpgtwo 

end type



type st_2 from u_st within u_tabpgtwo 

end type



type st_3 from u_st within u_tabpgtwo 

end type

