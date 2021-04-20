HA$PBExportHeader$pfc_n_cst_conversion.sru
$PBExportComments$PFC Conversion service class
forward
global type pfc_n_cst_conversion from n_base
end type
end forward

global type pfc_n_cst_conversion from n_base autoinstantiate
end type

forward prototypes
public function boolean of_boolean (string as_val)
public function string of_string (boolean ab_parm)
public function string of_string (toolbaralignment ae_alignment)
public function integer of_integer (boolean ab_arg)
public function string of_string (boolean ab_parm, string as_type)
public function string of_string (sqlpreviewtype a_sqlpreviewtype)
public function string of_string (ostypes ae_ostype)
public function integer of_sqlpreviewtype (string as_source, ref sqlpreviewtype a_sqlpreviewtype)
public function integer of_windowstate (string as_windowstate, ref windowstate aws_windowstate)
public function string of_string (windowstate aws_windowstate)
public function string of_string (icon ae_icon)
public function string of_string (button ae_button)
public function integer of_icon (string as_source, ref icon ae_icon)
public function integer of_button (string as_source, ref button ae_button)
public function integer of_ostype (string as_source, ref ostypes ae_ostype)
public function date of_date (string as_datetime)
public function string of_string (dwitemstatus ae_dwitemstatus)
public function integer of_toolbaralignment (string as_align, ref toolbaralignment ae_toolbaralign)
public function integer of_dwitemstatus (string as_status, ref dwitemstatus ae_dwitemstatus)
public function time of_time (string as_datetime)
public function boolean of_boolean (integer ai_val)
end prototypes

public function boolean of_boolean (string as_val);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_Boolean
//
//	Access:  		public
//
//	Arguments:
//	as_val			The string to be converted to a boolean value.
//
//	Returns: 		boolean
// 					The boolean value of the string.
//						If any argument's value is NULL, function returns NULL.
//						If any argument's value is Invalid, function returns NULL.
//
//	Description:  	Converts a string value to a boolean value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

Boolean lb_null
SetNull(lb_null)


//Check parameters
If IsNull(as_val) Then
	Return lb_null
End If

//Convert to uppercase
as_val = Upper(as_val)

Choose Case as_val
	Case 'TRUE', 'T', 'YES', 'Y', '1'
		Return True
	Case 'FALSE', 'F', 'NO', 'N', '0'
		Return False
End Choose

//Invalid input parameter
Return lb_null

end function

public function string of_string (boolean ab_parm);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	ab_parm			The boolean value to be converted to a string.
//
//	Returns:  		string	
//						The string value of the passed boolean argument.
//						If any argument's value is NULL, function returns NULL.
//
//	Description:  	Returns the passed boolean value as a string.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ab_parm) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

Return of_String(ab_parm, 'TRUEFALSE')

end function

public function string of_string (toolbaralignment ae_alignment);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	ae_alignment	The toolbaralignment value to be converted to a string.
//
//	Returns:  		string		
//						A string representation of the toolbaralignment value.
//						If ae_alignment is NULL, the function returns NULL.
//						If ae_alignment is Invalid, the function returns '!'.
//
//	Description:	Converts the toolbaralignment enumerated datatype to a 
//						readable string representation.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ae_alignment) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

Choose Case ae_alignment

	Case alignattop!
		Return "Top"

	Case alignatbottom!
		Return "Bottom"

	Case alignatright!
		Return "Right"

	Case alignatleft!
		Return "Left"

	Case floating!
		Return "Floating"
	
End Choose

//Invalid parameter value
Return "!"
end function

public function integer of_integer (boolean ab_arg);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_Integer
//
//	Access: 		 	public
//
//	Arguments:
//	ab_arg			The boolean argument to be converted to an integer value.
//
//	Returns: 		integer
//						The integer representation of the boolean value.
//						If any argument's value is NULL, function returns NULL.
//
//	Description:	Converts a boolean value to an integer value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ab_arg) Then
	Integer li_null
	SetNull(li_null)
	Return li_null
End If

If ab_arg Then
	//True
	Return 1
End If

//False
Return 0

end function

public function string of_string (boolean ab_parm, string as_type);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	ab_parm			The boolean value to be converted to a string.
//	as_type			The string containing the desired return value
//						i.e., TrueFalse, TF, YesNo, YN, ZEROONE
//
//	Returns:  		string	
//						The string value of the passed boolean argument.
//						If any argument's value is NULL, function returns NULL.
//						If any argument's value is Invalid, function returns '!'.
//
//	Description:  Returns the passed boolean value as a string.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

String ls_true, ls_false

//Check parameters
If IsNull(ab_parm) or IsNull(as_type) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

//Convert to uppercase
as_type = Upper(as_type)

//Check valid type and define true and false return values
Choose Case as_type
	Case 'TRUEFALSE'
		ls_true = 'TRUE'
		ls_false = 'FALSE'
	Case 'TF'
		ls_true = 'T'
		ls_false = 'F'
	Case 'YESNO'
		ls_true = 'YES'
		ls_false = 'NO'		
	Case 'YN'
		ls_true = 'Y'
		ls_false = 'N'
	Case 'ZEROONE'
		ls_true = '1'
		ls_false = '0'		
	Case Else
		Return '!'
End Choose
	
If ab_parm Then 
	Return ls_true
End If

Return ls_false

end function

public function string of_string (sqlpreviewtype a_sqlpreviewtype);//////////////////////////////////////////////////////////////////////////////
//
//	Function: 		of_String
//
//	Access:  		public
//
//	Arguments:
//	a_sqlpreviewtype		The sqlpreviewtype that needs conversion.
//
//	Returns:  		string
//						A string representation of the sqlpreviewtype value.
//						If ae_alignment is NULL, the function returns NULL.
//						If ae_alignment is Invalid, the function returns '!'.
//
//	Description:  	Converts the sqlpreviewtype enumerated datatype to a 
//						readable string representation.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

If IsNull(a_sqlpreviewtype) Then
	String ls_null
	SetNull (ls_null)
	Return ls_null
End If
	
Choose Case a_sqlpreviewtype
	Case PreviewInsert!
		Return 'Insert'
	Case PreviewDelete!
		Return 'Delete'
	Case PreviewUpdate!
		Return 'Update'
	Case PreviewSelect!
		Return 'Retrieve'
End Choose

//Invalid parameter
Return '!'
end function

public function string of_string (ostypes ae_ostype);//////////////////////////////////////////////////////////////////////////////
//
//	Function: 		of_String
//
//	Access:  		public
//
//	Arguments:
//	ae_ostype		The ostype that needs conversion.
//
//	Returns:  		string
//						A string representation of the ostype value.
//						If ae_ostype is NULL, the function returns NULL.
//						If ae_ostype is Invalid, the function returns '!'.
//
//	Description:  	Converts the ostype enumerated datatype to a 
//						readable string representation.
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

String ls_null

If IsNull(ae_ostype) Then
	SetNull (ls_null)
	Return ls_null
End If
	
Choose Case ae_ostype
	Case aix!
		Return 'aix'
	Case hpux!
		Return 'hpux'
	Case macintosh!
		Return 'macintosh'
	Case osf1!
		Return 'osf1'
	Case sol2!
		Return 'sol2'
	Case windows!
		Return 'windows'
	Case windowsnt!
		Return 'windowsnt'
End Choose

//Invalid parameter
Return '!'
end function

public function integer of_sqlpreviewtype (string as_source, ref sqlpreviewtype a_sqlpreviewtype);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_SQLPreviewType
//
//	Access:  		public
//
//	Arguments:
//	as_source			The string value to be converted to SQLPreviewType
//							datatype value.
//	a_sqlpreviewtype	A SQLPreviewType variable passed by reference which will
//							hold the SQLPreviewType value that the string value was
//							converted to.
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_source value is NULL, function returns NULL.
//						If as_source value is Invalid, function returns -1.
//
//	Description:  Converts a string value to a SQLPreviewType data type value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(as_source) Then
	Integer li_null
	SetNull(li_null)
	Return li_null
End If

//Convert to lowercase
as_source = Lower (as_source)

If Pos (as_source, "insert") > 0 Then
	a_sqlpreviewtype = PreviewInsert!
	Return 1
ElseIf Pos (as_source, "delete") > 0 Then
	a_sqlpreviewtype = PreviewDelete!
	Return 1
ElseIf Pos (as_source, "update") > 0 Then
	a_sqlpreviewtype = PreviewUpdate!
	Return 1
ElseIf Pos (as_source, "retrieve") > 0 or &
		Pos (as_source, "select") > 0 Then
	a_sqlpreviewtype = PreviewSelect!
	Return 1
End If

//Invalid parameter.
Return -1

end function

public function integer of_windowstate (string as_windowstate, ref windowstate aws_windowstate);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_WindowState
//
//	Access:  		public
//
//	Arguments:
//	as_windowstate		The string value to be converted to windowstate data type value.
//	aws_windowstate	A windowstate variable passed by reference which will hold the
//							windowstate value that the string value was converted to.
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_windowstate value is NULL, function returns NULL.
//						If as_windowstate value is Invalid, function returns -1.
//
//	Description:  Converts a string value to a windowstate data type value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Convert to lowercase
as_windowstate = Lower (as_windowstate)

//Check parameters
If IsNull(as_windowstate) Then
	Integer li_null
	SetNull(li_null)
	Return li_null
End If

If Pos (as_windowstate, "maximized") > 0 Then
	aws_windowstate = Maximized!
	Return 1
	
ElseIf Pos (as_windowstate, "minimized") > 0 Then
	aws_windowstate = Minimized!
	Return 1
	
ElseIf Pos (as_windowstate, "normal") > 0 Then
	aws_windowstate = Normal!
	Return 1
	
End If

//Invalid parameter.
Return -1
end function

public function string of_string (windowstate aws_windowstate);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	aws_windowstate	The windowstate value to be converted to a string.
//
//	Returns:  		string		
//						A string representation of the windowstate value.
//						If aws_windowstate is NULL, the function returns NULL.
//						If aws_windowstate is Invalid, the function returns '!'.
//
//	Description:	Converts the windowstate enumerated datatype to a 
//						readable string representation.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(aws_windowstate) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

Choose Case aws_windowstate

	Case Normal!
		Return "normal"

	Case Maximized!
		Return "maximized"

	Case Minimized!
		Return "minimized"

End Choose

//Invalid parameter value
Return "!"
end function

public function string of_string (icon ae_icon);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	ae_icon			The icon value to be converted to a string.
//
//	Returns:  		string		
//						A string representation of the icon value.
//						If ae_icon is NULL, the function returns NULL.
//						If ae_icon is Invalid, the function returns '!'.
//
//	Description:	Converts the icon enumerated datatype to a 
//						readable string representation.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ae_icon) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

Choose Case ae_icon

	Case None!
		Return "None"

	Case Question!
		Return "Question"

	Case Information!
		Return "Information"

	Case StopSign!
		Return "StopSign"

	Case exclamation!
		Return "Exclamation"
	
End Choose

//Invalid parameter value
Return "!"
end function

public function string of_string (button ae_button);//////////////////////////////////////////////////////////////////////////////
//
//	Function:		of_String
//
//	Access:			public
//
//	Arguments:
//	ae_button	The button value to be converted to a string.
//
//	Returns:  		string		
//						A string representation of the button value.
//						If ae_button is NULL, the function returns NULL.
//						If ae_button is Invalid, the function returns '!'.
//
//	Description:	Converts the button enumerated datatype to a 
//						readable string representation.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ae_button) Then
	String ls_null
	SetNull(ls_null)
	Return ls_null
End If

Choose Case ae_button

	Case OK!
		Return "OK"

	Case OKCancel!
		Return "OKCancel"

	Case YesNo!
		Return "YesNo"

	Case YesNoCancel!
		Return "YesNoCancel"

	Case RetryCancel!
		Return "RetryCancel"

	Case AbortRetryIgnore!
		Return "AbortRetryIgnore"
	
End Choose

//Invalid parameter value
Return "!"
end function

public function integer of_icon (string as_source, ref icon ae_icon);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_Icon
//
//	Access:  		public
//
//	Arguments:
//	as_source			The string value to be converted to Icon datatype value.
//	a_sqlpreviewtype	A icon variable passed by reference which will
//							hold the icon value that the string value was
//							converted to.
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_source value is NULL, function returns -1
//						If as_source value is Invalid, function returns -1
//
//	Description:  Converts a string value to a icon data type value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(as_source) Then
	Return -1
End If

//Convert to lowercase
as_source = Lower (as_source)

Choose Case as_source
	Case "none", "none!"
		ae_icon = None!

	Case "question", "question!"
		ae_icon = Question!

	Case "information", "information!"
		ae_icon = Information!

	Case "stopsign", "stopsign!"
		ae_icon = StopSign!

	Case "exclamation", "exclamation!"
		ae_icon = Exclamation!
		
	Case Else
		Return -1
End Choose

Return 1

end function

public function integer of_button (string as_source, ref button ae_button);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_button
//
//	Access:  		public
//
//	Arguments:
//	as_source			The string value to be converted to button	datatype value.
//	a_sqlpreviewtype	A button variable passed by reference which will
//							hold the button value that the string value was
//							converted to.
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_source value is NULL, function returns -1
//						If as_source value is Invalid, function returns -1
//
//	Description:  Converts a string value to a button data type value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(as_source) Then
	Return -1
End If

//Convert to lowercase
as_source = Lower (as_source)

Choose Case as_source
	Case "ok", "ok!"
		ae_button = OK!

	Case "okcancel", "okcancel!"
		ae_button = OKCancel!

	Case "yesno", "yesno!"
		ae_button = YesNo!

	Case "yesnocancel", "yesnocancel!"
		ae_button = YesNoCancel!

	Case "retrycancel", "retrycancel!"
		ae_button = RetryCancel!

	Case "abortretryignore", "abortretryignore!"
		ae_button = AbortRetryIgnore!
		
	Case Else
		Return -1
End Choose

Return 1

end function

public function integer of_ostype (string as_source, ref ostypes ae_ostype);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_OSType
//
//	Access:  		public
//
//	Arguments:
//	as_source			The string value to be converted to an ostype
//							datatype value.
//	ae_ostype			An ostypes variable passed by reference which will
//							hold the ostype value that the string value was
//							converted to.
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_source value is NULL, function returns NULL.
//						If as_source value is Invalid, function returns -1.
//
//	Description:  Converts a string value to an ostype data type value.
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

//Check parameters
If IsNull(as_source) Then
	Return -1
End If

//Convert to lowercase
as_source = Lower (as_source)

Choose Case as_source
	Case "aix", "aix!"
		ae_ostype = AIX!

	Case "hpux", "hpux!"
		ae_ostype = HPUX!

	Case "macintosh", "macintosh!"
		ae_ostype = MACINTOSH!

	Case "osf1", "osf1!"
		ae_ostype = OSF1!

	Case "sol2", "sol2!"
		ae_ostype = SOL2!

	Case "windows", "windows!"
		ae_ostype = WINDOWS!
	
	Case "windowsnt", "windowsnt!"
		ae_ostype = WINDOWSNT!
		
	Case Else
		Return -1
End Choose

Return 1
end function

public function date of_date (string as_datetime);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  of_Date
//
//	Access:  public
//
//	Arguments:
//	as_datetime   Datetime value as a string
//
//	Returns:  date
//	If as_datetime does not contain a valid datetime value, return date
//	is 1900-01-01.  If as_datetime is NULL, function returns NULL.
//
//	Description:
//	Converts a string whose value is a valid datetime to a date
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0.02   Initial version
// 5.0.04	Enhanced to handle to more cases.
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

date	ld_rc = 1900-01-01
long	ll_count
string	ls_datetime[]
n_cst_string	lnv_string

// Check arguments
if IsNull (as_datetime) then
	SetNull (ld_rc)
	return ld_rc
end if

// Validate datetime string ("1/1/95", "1/1/95 8:00", "1/1/95 8:00 PM")
ll_count = lnv_string.of_ParseToArray (as_datetime, " ", ls_datetime)
if ll_count <= 0 or ll_count > 3 then
	return ld_rc
end if

// Date string passed in
if ll_count = 1 then
	return Date (as_datetime)
end if

// Datetime string passed in
if ll_count = 2 or ll_count = 3 then
	return Date (ls_datetime[1])
end if

return ld_rc


end function

public function string of_string (dwitemstatus ae_dwitemstatus);//////////////////////////////////////////////////////////////////////////////
//
//	Function: 		of_String
//
//	Access:  		public
//
//	Arguments:
//	ae_dwitemstatus	The dwitemstatus that needs conversion.
//
//	Returns:  		string
//						A string representation of the dwitemstatus value.
//						If ae_dwitemstatus is NULL or Invalid, the function returns '!'.
//
//	Description:  	Converts the dwitemstatus enumerated datatype to a 
//						readable string representation.
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

If IsNull(ae_dwitemstatus) Then
	Return '!'
End If
	
Choose Case ae_dwitemstatus
	Case NotModified!
		Return 'NotModified'
	Case DataModified!
		Return 'DataModified'
	Case New!
		Return 'New'
	Case NewModified!
		Return 'NewModified'
End Choose

//Invalid parameter
Return '!'
end function

public function integer of_toolbaralignment (string as_align, ref toolbaralignment ae_toolbaralign);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_ToolbarAlignment
//
//	Access:  		public
//
//	Arguments:
//	as_align				The string value to be converted to toolbaralignment data type value
//	ae_toolbaralign	A toolbaralignment variable passed by reference which will hold the
//							toolbaralignment value that the string value was converted to
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_align value is NULL, function returns NULL.
//						If as_align value is Invalid, function returns -1.
//
//	Description:  Converts a string value to a toolbaralignment data type value.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Convert to lowercase
as_align = Lower (as_align)

//Check parameters
If IsNull(as_align) Then
	Integer li_null
	SetNull(li_null)
	Return li_null
End If

If Pos (as_align, "top") > 0 Then
	ae_toolbaralign = alignattop!
	Return 1
	
ElseIf Pos (as_align, "bottom") > 0 Then
	ae_toolbaralign = alignatbottom!
	Return 1
	
ElseIf Pos (as_align, "left") > 0 Then
	ae_toolbaralign = alignatleft!
	Return 1
	
ElseIf Pos (as_align, "right") > 0 Then
	ae_toolbaralign = alignatright!
	Return 1
	
ElseIf Pos (as_align, "floating") > 0 Then
	ae_toolbaralign = floating!
	Return 1
	
End If

//Invalid parameter.
Return -1
end function

public function integer of_dwitemstatus (string as_status, ref dwitemstatus ae_dwitemstatus);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_dwItemStatus
//
//	Access:  		public
//
//	Arguments:
//	as_status			The string value to be converted to dwItemStatus data type value
//	ae_dwItemStatus	A dwItemStatus variable passed by reference which will hold the
//							dwItemStatus value that the string value was converted to
//
//	Returns: 		integer	 
//						1 if a successful conversion was made.
//						If as_status value is Invalid, function returns -1.
//
//	Description:  Converts a string value to a dwItemStatus data type value.
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

//Convert to lowercase
as_status = Lower (as_status)

//Check parameters
If IsNull(as_status) Then
	Return -1
End If

CHOOSE CASE as_status
	CASE "notmodified", "notmodified!"
		ae_dwItemStatus = NotModified!
		Return 1
	CASE "datamodified", "datamodified!"
		ae_dwItemStatus = DataModified!
		Return 1
	CASE "new", "new!"
		ae_dwItemStatus = New!
		Return 1
	CASE "newmodified", "newmodified!"
		ae_dwItemStatus = NewModified!
		Return 1		
END CHOOSE

//Invalid parameter.
Return -1
end function

public function time of_time (string as_datetime);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  of_Time
//
//	Access:  public
//
//	Arguments:
//	as_datetime   Datetime value as a string
//
//	Returns:  time
//	If as_datetime does not contain a valid datetime value, return time
//	is 00:00:00.000000.  If as_datetime is NULL, function returns NULL.
//
//	Description:
//	Converts a string whose value is a valid datetime to a time value
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0.02   Initial version
// 5.0.04 	Enhanced to handle more cases.
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

time	ltm_rc = 00:00:00.000000
long	ll_count
string	ls_datetime[]
n_cst_string	lnv_string

// Check arguments
if IsNull (as_datetime) then
	SetNull (ltm_rc)
	return ltm_rc
end if

// Validate datetime string
ll_count = lnv_string.of_ParseToArray (as_datetime, " ", ls_datetime)
if ll_count <= 0 or ll_count > 3 then
	return ltm_rc
end if

// Date string passed in ("8:00pm")
if ll_count = 1 then
	return Time (as_datetime)
end if

// Datetime string passed in ("1/1/95 8:00pm")
if ll_count = 2 then
	return Time (ls_datetime[2])
end if

// Datetime string passed in ("1/1/95 8:00 pm")
if ll_count = 3 then
	return Time (ls_datetime[2]+' '+ls_datetime[3])
end if

return ltm_rc
end function

public function boolean of_boolean (integer ai_val);//////////////////////////////////////////////////////////////////////////////
//
//	Function:  		of_Boolean
//
//	Access:			public
//
//	Arguments: 
//	ai_val			The integer to be converted to a boolean value.
//
//	Returns:  		boolean
//						The boolean representation of the integer value.
//						If any argument's value is NULL, function returns NULL.
//						If any argument's value is Invalid, function returns NULL.
//
//	Description:  Converts a integer value to a boolean.
//
//////////////////////////////////////////////////////////////////////////////
//
//	Revision History
//
//	Version
//	5.0   Initial version
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

//Check parameters
If IsNull(ai_val) or (ai_val>1) or (ai_val<0) Then
	Boolean lb_null
	SetNull(lb_null)
	Return lb_null
End If

If ai_val=1 Then
	Return True
End If

Return False

end function

on pfc_n_cst_conversion.create
TriggerEvent( this, "constructor" )
end on

on pfc_n_cst_conversion.destroy
TriggerEvent( this, "destructor" )
end on

