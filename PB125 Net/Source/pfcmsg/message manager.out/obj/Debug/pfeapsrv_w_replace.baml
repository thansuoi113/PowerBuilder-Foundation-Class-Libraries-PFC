   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �   
 pfcmsg   	w_replace   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263581 6  ���	#fff0f0f0   MaxBox .     MinBox .     PBHeight$
 1012��6M     PBTitle$ Replace��6]     PBWidth$
 2190��6o     	Resizable .     X$	 384��6�     Y$	 560��6�  	   
WindowType$	 popup=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 402��60   $��87��6>      TabOrder$	 110��6I      Text$ _Help��6X      X$
 1696��6e      Y$	 468��6n      FaceName$ MS Sans Serif��6v      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   6   0Sybase.PowerBuilder.WPF.Controls.DropDownListBox  5   
   -   5        $��ddlb_searchdirection��5          Accelerator$	 115��6<      	BackColor$ 
1090519039 6N      PBHeight$	 208��6e   $��27��6t      Sorted .     TabOrder$ 40��6�      X$	 571��6�      Y$	 424��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�       	FontPitch$  variable=�6�   !   PBFontFamily$! swiss=�6�   "   PBWidth$	" 343��6  $��74��6  #   	TextColor$# 33554432 6$  $   TextSize$$ -8��69  %   
VScrollBar% . &   Weight$	& 400��6Y  .@�5      :   4Sybase.PowerBuilder.WPF.Controls.DropDownListBoxItem  '   Item$
' Down��6(     5      $' Up��6(   5        5   
   -   5        $��cb_replaceall��5      $	 402��63   $��87��6A   $ 90��6L   $ Replace _All��6Z   $
 1696��6n   $	 252��6w   $ MS Sans Serif��6   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5	   
   -   5        $��
cb_replace��5	      $	 402��60   $��87��6>   $ 80��6I   $ _Replace��6W   $
 1696��6g   $	 144��6p   $ MS Sans Serif��6x   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5
   
   -   5        $��
st_replace��5
      (   	BackColor$( 79416533 6-   )   PBHeight$) 72��6B   $��17��6P   *   PBWidth$	* 526��6\   $	��114��6j   +   Text$+ Re_place with��6v   ,   X$, 32��6�   -   Y$	- 300��6�   .   Enabled. .  /   FaceName$/ MS Sans Serif��6�   0   FocusRectangle0 .  1   	FontPitch$1 variable=�6�   2   PBFontFamily$2 swiss=�6�   3   	TextColor$3 33554432 6  4   TextSize$4 -8��6  5   Weight$	5 400��6'  66  5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_replace��5      6   Accelerator$	6 112��62   7   PBHeight$7 80��6D   $��19��6R   8   PBWidth$
8 1056��6^   $	��230��6m   9   TabOrder$9 30��6y   :   X$	: 571��6�   ;   Y$	; 288��6�   <   AutoHScroll< .  =   	BackColor$= 
1090519039 6�   >   BorderStyle$> stylelowered 6�   ?   FaceName$? MS Sans Serif��6�   @   	FontPitch$@ variable=�6�   A   PBFontFamily$A swiss=�6  B   	TextColor$B 33554432 6   C   TextSize$C -8��65  D   Weight$	D 400��6C  6R    5   
   -   5        $��sle_findwhat��5      $	6 110��63   $7 80��6E   $��19��6S   $
8 1056��6_   $	��230��6n   $9 20��6z   $	: 571��6�   $	; 164��6�   < .  $= 
1090519039 6�   $> stylelowered 6�   $? MS Sans Serif��6�   $@ variable=�6�   $A swiss=�6  $B 33554432 6!  $C -8��66  $	D 400��6D  6S    5   
   -   5        $��	cb_cancel��5      E   CancelE . $	 402��6=   $��87��6K   $	 100��6V   $ Cancel��6e   $
 1696��6s   $	 360��6|   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -	   5        $��cb_findnext��5      $	 402��61   $��87��6?   $ 70��6J   $ 
_Find Next��6X   $
 1696��6j   $ 36��6s   $ MS Sans Serif��6z   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   /	   )Sybase.PowerBuilder.WPF.Controls.CheckBox	  5   
   -
   5        $��cbx_matchcase��5      F 	  	BackColor$F 79416533 6.   G 	  PBHeight$G 72��6C   $��17��6Q   H 	  PBWidth$
H 1504��6]   $	��328��6l   I 	  TabOrder$I 60��6x   J 	  Text$J Match _Case  ��6�   K 	  X$	K 571��6�   L 	  Y$	L 792��6�   M 	  BorderStyle$M stylelowered 6�   N 	  FaceName$N MS Sans Serif��6�   O 	  	FontPitch$O variable=�6�   P 	  PBFontFamily$P swiss=�6�   Q 	  	TextColor$Q 33554432 6	  R 	  TextSize$R -8��6  S 	  Weight$	S 400��6,  6;  	  5   
   -   5        $��cbx_wholeword��5      $F 79416533 6.   $G 72��6C   $��17��6Q   $
H 1504��6]   $	��328��6l   $I 50��6x   $J Whole _Word��6�   $	K 571��6�   $	L 696��6�   $M stylelowered 6�   $N MS Sans Serif��6�   $O variable=�6�   $P swiss=�6�   $Q 33554432 6  $R -8��6  $	S 400��6*  69    5   
   -   5        $��st_searchdirection��5      $( 79416533 65   $) 72��6J   $��17��6X   $	* 526��6d   $	��114��6r   $+ _Search��6~   $, 32��6�   $	- 428��6�   . .  $/ MS Sans Serif��6�   0 .  $1 variable=�6�   $2 swiss=�6�   $3 33554432 6  $4 -8��6  $	5 400��6)  68    5   
   -   5        $��ddlb_findwhere��5       $	 101��66   $	 308��6H   $��27��6W   $
" 1056��6c   $	��230��6r    .  $ 10��6�   $	 571��6�   $ 48��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $  variable=�6�   $! swiss=�6�   $# 33554432 6  $$ -8��6  % . $	& 400��6=  6L    5   
   -   5        $��st_findwhat��5      $( 79416533 6.   $) 72��6C   $��17��6Q   $	* 526��6]   $	��114��6k   $+ 
Fi_nd what��6w   $, 32��6�   $	- 176��6�   . .  $/ MS Sans Serif��6�   0 .  $1 variable=�6�   $2 swiss=�6�   $3 33554432 6  $4 -8��6  $	5 400��6%  64    5   
   -   5        $��st_findwhere��5      $( 79416533 6/   $) 72��6D   $��17��6R   $	* 526��6^   $	��114��6l   $+ Find wher_e��6x   $, 32��6�   $- 48��6�   . .  $/ MS Sans Serif��6�   0 .  $1 variable=�6�   $2 swiss=�6�   $3 33554432 6  $4 -8��6  $	5 400��6&  65  5      5      