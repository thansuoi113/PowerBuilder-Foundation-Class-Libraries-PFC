   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    generic_pfc_app   
pfc_w_find   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   MaxBox .     MinBox .     PBHeight$	 864��6N     PBTitle$
 Find��6]     PBWidth$
 2181��6l     	Resizable .     X$	 384��6�     Y$	 560��6�  	   
WindowType$	 popup=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 402��60   $��87��6>      TabOrder$ 80��6I      Text$ _Help��6W      X$
 1696��6d      Y$	 268��6m      FaceName$ MS Sans Serif��6u      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   6   0Sybase.PowerBuilder.WPF.Controls.DropDownListBox  5   
   -   5        $��ddlb_searchdirection��5          Accelerator$	 115��6<      	BackColor$ 
1090519039 6N      PBHeight$	 208��6e   $��27��6t      Sorted .     TabOrder$ 30��6�      X$	 571��6�      Y$	 304��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�       	FontPitch$  variable=�6�   !   PBFontFamily$! swiss=�6�   "   PBWidth$	" 343��6  $��74��6  #   	TextColor$# 33554432 6$  $   TextSize$$ -8��69  %   
VScrollBar% . &   Weight$	& 400��6Y  .@�5      :   4Sybase.PowerBuilder.WPF.Controls.DropDownListBoxItem  '   Item$
' Down��6(   66     5      $' Up��6(   64   5      5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_findwhat��5      (   Accelerator$	( 110��63   )   PBHeight$) 80��6E   $��19��6S   *   PBWidth$
* 1056��6_   $	��230��6n   +   TabOrder$+ 20��6z   ,   X$	, 571��6�   -   Y$	- 172��6�   .   AutoHScroll. .  /   	BackColor$/ 
1090519039 6�   0   BorderStyle$0 stylelowered 6�   1   FaceName$1 MS Sans Serif��6�   2   	FontPitch$2 variable=�6�   3   PBFontFamily$3 swiss=�6  4   	TextColor$4 33554432 6!  5   TextSize$5 -8��66  6   Weight$	6 400��6D  6S    5	   
   -   5        $��	cb_cancel��5	      7   Cancel7 . $	 402��6=   $��87��6K   $ 70��6V   $ Cancel��6d   $
 1696��6r   $	 152��6{   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5
   
   -   5        $��cb_findnext��5
      $	 402��61   $��87��6?   $ 60��6J   $ 
_Find Next��6X   $
 1696��6j   $ 36��6s   $ MS Sans Serif��6z   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_matchcase��5      8   	BackColor$8 79416533 6.   9   PBHeight$9 72��6C   $��17��6Q   :   PBWidth$
: 1481��6]   $	��323��6l   ;   TabOrder$; 50��6x   <   Text$< Match _Case  ��6�   =   X$	= 571��6�   >   Y$	> 640��6�   ?   BorderStyle$? stylelowered 6�   @   FaceName$@ MS Sans Serif��6�   A   	FontPitch$A variable=�6�   B   PBFontFamily$B swiss=�6�   C   	TextColor$C 33554432 6	  D   TextSize$D -8��6  E   Weight$	E 400��6,  6;    5   
   -   5        $��cbx_wholeword��5      $8 79416533 6.   $9 72��6C   $��17��6Q   $
: 1504��6]   $	��328��6l   $; 40��6x   $< Whole _Word��6�   $	= 571��6�   $	> 532��6�   $? stylelowered 6�   $@ MS Sans Serif��6�   $A variable=�6�   $B swiss=�6�   $C 33554432 6  $D -8��6  $	E 400��6*  69  1	   +Sybase.PowerBuilder.WPF.Controls.StaticText	  5   
   -   5        $��st_searchdirection��5      F 	  	BackColor$F 79416533 65   G 	  PBHeight$G 72��6J   $��17��6X   H 	  PBWidth$	H 526��6d   $	��114��6r   I 	  Text$I _Search��6~   J 	  X$J 32��6�   K 	  Y$	K 304��6�   L 	  EnabledL .  M 	  FaceName$M MS Sans Serif��6�   N 	  FocusRectangleN .  O 	  	FontPitch$O variable=�6�   P 	  PBFontFamily$P swiss=�6�   Q 	  	TextColor$Q 33554432 6  R 	  TextSize$R -8��6  S 	  Weight$	S 400��6)  68    5   
   -	   5        $��ddlb_findwhere��5       $	 101��66   $	 308��6H   $��27��6W   $
" 1056��6c   $	��230��6r    .  $ 10��6�   $	 571��6�   $ 48��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $  variable=�6�   $! swiss=�6�   $# 33554432 6  $$ -8��6  % . $	& 400��6=  6L  	  5   
   -
   5        $��st_searchfor��5      $F 79416533 6/   $G 72��6D   $��17��6R   $	H 526��6^   $	��114��6l   $I 
Fi_nd what��6x   $J 32��6�   $	K 176��6�   L .  $M MS Sans Serif��6�   N .  $O variable=�6�   $P swiss=�6�   $Q 33554432 6  $R -8��6  $	S 400��6&  65  	  5   
   -   5        $��st_findwhere��5      $F 79416533 6/   $G 72��6D   $��17��6R   $	H 526��6^   $	��114��6l   $I Find wher_e��6x   $J 32��6�   $K 48��6�   L .  $M MS Sans Serif��6�   N .  $O variable=�6�   $P swiss=�6�   $Q 33554432 6  $R -8��6  $	S 400��6&  65  5      5      