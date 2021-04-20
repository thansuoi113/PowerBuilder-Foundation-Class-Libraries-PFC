HA$PBExportHeader$pfc_n_cst_platformwin32.sru
$PBExportComments$PFC Win32 Cross Platform service
forward
global type pfc_n_cst_platformwin32 from n_cst_platform
end type
type os_memorystatus from structure within pfc_n_cst_platformwin32
end type
type os_size from structure within pfc_n_cst_platformwin32
end type
end forward

type os_memorystatus from structure
    unsignedlong ul_length
    unsignedlong ul_memoryload
    unsignedlong ul_totalphys
    unsignedlong ul_availphys
    unsignedlong ul_totalpagefile
    unsignedlong ul_availpagefile
    unsignedlong ul_totalvirtual
    unsignedlong ul_availvirtual
end type

type os_size from structure
    long l_cx
    long l_cy
end type

global type pfc_n_cst_platformwin32 from n_cst_platform
end type
global pfc_n_cst_platformwin32 pfc_n_cst_platformwin32

type prototypes
// Sound
Function boolean sndPlaySoundA (string SoundName, ulong Flags) Library "WINMM.DLL"
Function ulong waveOutGetNumDevs () Library "WINMM.DLL"

// Get free memory
Subroutine GlobalMemoryStatus (ref os_memorystatus memorystatus ) Library "KERNEL32.DLL"

// Get module handle
Function ulong GetModuleHandleA(string modname) Library "KERNEL32.DLL"

// Window functions
Function ulong GetWindowTextA(ulong handle, ref string wintext, ulong length) Library "USER32.DLL"
Function ulong GetWindowsDirectoryA (ref string dirtext, ulong textlen) library "KERNEL32.DLL"
Function ulong GetSystemDirectoryA (ref string dirtext, ulong textlen) library "KERNEL32.DLL"
Function ulong FindWindowA( ref string lpClassName, ref string lpWindowName) Library "USER32.DLL"

// User/computer information
function boolean GetUserNameA(ref string  lpBuffer, ref ulong nSize) library "ADVAPI32.DLL"
function boolean GetComputerNameA(ref string  lpBuffer, ref ulong nSize) library "KERNEL32.DLL"

// Get text size
Function boolean SystemParametersInfoA(uint wActon, uint wParam, REF int pvParam, uint fUpdateProfile) Library "USER32.DLL"
Function ulong GetDC(ulong hWnd) Library "USER32.DLL"
Function long ReleaseDC(ulong hWnd, ulong hdcr) Library "USER32.DLL"
Function boolean GetTextExtentPoint32A(ulong hdcr, string lpString, long nCount, ref os_size size) Library "GDI32.DLL"
Function ulong SelectObject(ulong hdc, ulong hWnd) Library "GDI32.DLL"

end prototypes

type variables
end variables

forward prototypes
public function unsignedinteger of_FindWindow (string as_window_name)
public function integer of_GetActiveWindowBorder ()
public function string of_GetComputerName ()
public function long of_GetPhysicalMemory ()
public function string of_GetSystemDirectory ()
public function integer of_GetTextSize (ref window aw_obj, string as_text, string as_fontface, integer ai_fontsize, boolean ab_bold, boolean ab_italic, boolean ab_underline, ref integer ai_height, ref integer ai_width)
public function string of_GetUserID ()
public function string of_GetWindowsDirectory ()
public function string of_GetWindowText (unsignedinteger ai_handle)
public function integer of_PlaySound (string as_file)
public function long of_getfreememory ()
end prototypes

public function unsignedinteger of_FindWindow (string as_window_name);//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_FindWindow
//	Arguments: 			as_window_name - window text to search for
//	Returns:  			uint  - window handle
//	Description:  		Return the handle of the window passed in by window name (Window Title)
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint variables to Ulong for NT4.0 compatibility
// 							7.0		Moved the class names into an instance array.  Allow for multiple class names.
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
ulong		lul_whnd
long 		ll_idx, ll_upper

ll_upper = UpperBound(is_ClassName)

FOR ll_idx = 1 TO ll_upper
	lul_whnd = FindWindowA( is_classname[ll_idx], as_window_name)
	IF lul_whnd > 0 THEN
		EXIT
	END IF
NEXT

return lul_whnd
end function

public function integer of_GetActiveWindowBorder ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetActiveWindowBorder
//	Arguments:			None
//	Returns:				int
//	Description:			Get the size of the active window's border
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							7.0   Initial version
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
boolean lb_success
int li_border
uint SPI_GETBORDER = 5

lb_success = SystemParametersInfoA(SPI_GETBORDER, 0, li_border, 0)

if lb_success then
	return li_border
else
	return -1
end if
end function

public function string of_GetComputerName ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetComputerName
//	Arguments: 			none
//	Returns:  			string - computer name
//	Description:  		Return the the computer name the user is using
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint size variable to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
boolean	lb_rc
ulong		lul_size = 16 // MAX_COMPUTERNAME_LENGTH + 1
string 	ls_computer_name

ls_computer_name = space(lul_size)

lb_rc = GetComputerNameA( ls_computer_name, lul_size)

if not lb_rc THEN
	return ""
else
	return ls_computer_name
end if
end function

public function long of_GetPhysicalMemory ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetPhysicalMemory
//	Arguments: 			none
//	Returns:  			long -  total memory
//	Description:  		Return the total physical memory (RAM) installed in the machine
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
os_memorystatus lstr_memory

//structure size is 8 ulong's or 8 * 4 bytes
lstr_memory.ul_length = 32

GlobalMemoryStatus(lstr_memory)

//bytes of virtual memory available
Return (lstr_memory.ul_totalphys)
end function

public function string of_GetSystemDirectory ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetSystemDirectory
//	Arguments: 			none
//	Returns:  			string 
//							system directory
//							"" if error			
//	Description:  		Return the window's system directory
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint variables to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
ulong		lul_size = 260 // MAX_PATH
ulong		lul_rc
string 	ls_dir 

ls_dir = space(lul_size)

lul_rc = GetSystemDirectoryA(ls_dir, lul_size)

if lul_rc > 0 THEN
	return ls_dir
else
	return ""
end if
end function

public function integer of_GetTextSize (ref window aw_obj, string as_text, string as_fontface, integer ai_fontsize, boolean ab_bold, boolean ab_italic, boolean ab_underline, ref integer ai_height, ref integer ai_width);//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetTextSize
//	Arguments:  			aw_obj:  				Window where temporary text will be created
//							as_Text:				The text to be sized.
//							as_FontFace:		The font used.
//							ai_FontSize:			The point size of the font.
//							ab_Bold:				True - Bold, False - Normal.
//							ab_Italic:			True - Yes, False - No.
//							ab_Underline:		True - Yes, False - No.
//							ai_Height:			the height of the object in pixels
//							ai_Width:			the width of the object in pixels
//	Returns:  			Integer			1 if successful, -1 if an error occurrs
//	Description:  		Calculates the size of a text object in pixels
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint variables to Ulong for NT4.0 compatibility
//							8.0		Not deleting statictext object under certain conditions.
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
Integer		li_Size, li_Len, li_Return, &
				li_WM_GETFONT = 49 	//  hex 0x0031
ULong			lul_Hdc, lul_Handle, lul_hFont
StaticText	lst_Temp
os_size 		lstr_Size

// Datawindow syntax specifies font point size is negative
li_Size = -1 * ai_FontSize

if IsNull(aw_obj) Or Not IsValid (aw_obj) then
	return -1
end if

// Create a dummy StaticText Object on the window
// containing text with the desired characteristics
li_Return = aw_obj.OpenUserObject(lst_Temp)
If li_Return = 1 Then
	lst_Temp.FaceName = as_FontFace
	lst_Temp.TextSize = li_Size
	If ab_Bold Then
		lst_Temp.Weight = 700
	Else
		lst_Temp.Weight = 400
	End If
	lst_Temp.Italic = ab_Italic
	lst_Temp.Underline = ab_Underline

	li_Len = Len(as_Text)

	// Get the handle of the StaticText Object and create a Device Context
	lul_Handle = Handle(lst_Temp)
	lul_Hdc = GetDC(lul_Handle)

	// Get the font in use on the Static Text
	lul_hFont = Send(lul_Handle, li_WM_GETFONT, 0, 0)

	// Select it into the device context
	SelectObject(lul_Hdc, lul_hFont)

	// Get the size of the text.
	If Not GetTextExtentpoint32A(lul_Hdc, as_Text, li_Len, lstr_Size ) Then 
		aw_obj.CloseUserObject(lst_Temp)
		Return -1
	End If

	ai_Height = lstr_Size.l_cy
	ai_Width = lstr_Size.l_cx

	ReleaseDC(lul_Handle, lul_Hdc)

	li_Return = aw_obj.CloseUserObject(lst_Temp)
End if

Return li_Return
end function

public function string of_GetUserID ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetUserID
//	Arguments: 			none
//	Returns:  			string  - user id/name
//	Description:  		Return the user id/name currently logged into a network
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint size variable to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
boolean	lb_rc
ulong		lul_size = 255
string 	ls_name

ls_name = space(lul_size)

lb_rc = GetUserNameA( ls_name, lul_size)

if not lb_rc THEN
	return ""
else
	return ls_name
end if
end function

public function string of_GetWindowsDirectory ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetWindowsDirectory
//	Arguments: 			none
//	Returns:  			string 
//							windows directoy
//							"" if error
//	Description:  		Return the window's directory
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed int variables to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
ulong 	lul_size = 260 // MAX_PATH
ulong		lul_rc
string 	ls_dir 

ls_dir = space(lul_size)

lul_rc = GetWindowsDirectoryA(ls_dir, lul_size)

if lul_rc > 0 THEN
	return ls_dir
else
	return ""
end if
end function

public function string of_GetWindowText (unsignedinteger ai_handle);//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetWindowText
//	Arguments:			unsignedinteger	
//	Returns:  			string
//							window text
//							"" if error
//	Description:			Return the window title text
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed int variables to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
ulong		lul_rc
ulong		lul_size = 255
string 	ls_wintext

ls_wintext = space (lul_size)

lul_rc = GetWindowTextA(ai_handle, ls_wintext, lul_size)

if lul_rc > 0 THEN
	return ls_wintext
else
	return ""
end if
end function

public function integer of_PlaySound (string as_file);//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_PlaySound
//	Arguments:			as_file - sound file to play
//	Returns:  			integer
//	Description:  		Play a sound file
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							5.0.03	Changed Uint variable to Ulong for NT4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
ulong lul_numdevs

lul_numdevs = WaveOutGetNumDevs() 
If lul_numdevs > 0 Then 
	sndPlaySoundA(as_file, 1)
	return 1
Else
	return -1
End If
end function

public function long of_getfreememory ();//////////////////////////////////////////////////////////////////////////////
//	Public Function:		of_GetFreeMemory
//	Arguments: 			none
//	Returns:  			long - 	bytes of memory
//	Description:  		returns the number of bytes of memory currently available 
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
//							8.0		Changed from lstr_memory.ul_availpagefile to
//									to lstr_memory.ul_availpagefile
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
os_memorystatus lstr_memory

//structure size is 8 ulong's or 8 * 4 bytes
lstr_memory.ul_length = 32

GlobalMemoryStatus(lstr_memory)

//bytes of physical memory available
Return (lstr_memory.ul_availphys)
end function

on pfc_n_cst_platformwin32.create
call super::create
end on

on pfc_n_cst_platformwin32.destroy
call super::destroy
end on

event constructor;call super::constructor;//////////////////////////////////////////////////////////////////////////////
//	Object Name:		pfc_n_cst_platformwin32
//	Description:			Windows 32bit platform object
//////////////////////////////////////////////////////////////////////////////
//	Rev. History			Version
//							5.0		Initial version
// 							5.0.03	Replace Uint with Ulong in Local External Functions for full NT 4.0 compatibility
//////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////
is_separator = "\"
end event

