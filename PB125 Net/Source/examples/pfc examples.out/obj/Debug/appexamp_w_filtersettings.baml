   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_filtersettings   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1488��6
     PBTitle$+ %PFC Example - Filter Service Settings��6     PBWidth$
 2089��6J     	Resizable .     TitleBar .    X$	 402��6{     Y$	 120��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_1��5         PBHeight$	 540��6%   $	��134��64      PBWidth$
 1998��6A   $	��436��6P      TabOrder$ 0��6\      Text$ Example Options��6i      X$ 37��6�      Y$ 32��6�      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6     TextSize$ -8��6     Weight$	 400��6$  .��5      �� 6   5      .   (Sybase.PowerBuilder.WPF.Controls.ListBox  5   
   -   5        $
��lb_1��5         Accelerator$	 115��6$      MultiSelect .    PBHeight$	 332��6I   $��82��6X      PBWidth$
 1120��6d   $	��244��6s      Sorted .     TabOrder$ 10��6�      X$ 82��6�       Y$	  196��6�   !   	BackColor$! 
1090519039 6�   "   BorderStyle$" stylelowered 6�   #   FaceName$# MS Sans Serif��6�   $   	FontPitch$$ variable=�6�   %   PBFontFamily$% swiss=�6  &   	TextColor$& 33554432 6   '   TextSize$' -8��65  (   
VScrollBar( . )   Weight$	) 400��6U  .@�5      2   ,Sybase.PowerBuilder.WPF.Controls.ListBoxItem  *   Item$* cust_id��6    61     5      $* 
first_name��6    64     5	      $* 	last_name��6    63     5
      $* address��6    61     5      $
* city��6    6.     5      $* state��6    6/     5      $	* zip��6    6-     5      $* phone��6    6/     5      $* company_name��6    66   5      1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $
��st_1��5      +   PBWidth$	+ 617��6'   $	��134��65   ,   Text$!, _Select columns to exclude:��6A   -   X$- 87��6d   .   Y$	. 124��6k   /   	BackColor$/ 80263581 6s   0   Enabled0 .  1   FaceName$1 MS Sans Serif��6�   2   FocusRectangle2 .  3   	FontPitch$3 variable=�6�   4   PBFontFamily$4 swiss=�6�   5   PBHeight$5 64��6�   $��15��6   6   	TextColor$6 33554432 6  7   TextSize$7 -8��6!  8   Weight$	8 400��6/  6>  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��	cb_filter��5      9   Default9 . :   PBWidth$	: 311��6>   $��67��6L   ;   TabOrder$; 30��6W   <   Text$< _Filter��6e   =   X$
= 1056��6t   >   Y$
> 1268��6}   ?   FaceName$? MS Sans Serif��6�   @   	FontPitch$@ variable=�6�   A   PBFontFamily$A swiss=�6�   B   PBHeight$B 92��6�   $��22��6�   C   TextSize$C -8��6�   D   Weight$	D 400��6�   6   1	   +Sybase.PowerBuilder.WPF.Controls.DataWindow	  5   
   -   5        $
��dw_1��5      E 	  
DataObject$E d_customerlist��6'   F 	  PBHeight$	F 600��6C   $	��149��6R   G 	  PBWidth$
G 1998��6_   $	��436��6n   H 	  TabOrder$H 0��6z   I 	  X$I 37��6�   J 	  Y$	J 612��6�   K 	  BorderStyle$K stylelowered 6�   L 	  
LiveScrollL . M 	  PBVScrollBarM . 6�     5   
   -   5        $��cb_reset��5      N   
BringToTopN . $	: 311��6@   $��67��6N   $; 40��6Y   $< _Reset��6g   $
= 1394��6u   $
> 1268��6~   $? MS Sans Serif��6�   $@ variable=�6�   $A swiss=�6�   $B 92��6�   $��22��6�   $C -8��6�   $	D 400��6�   6    5   
   -   5        $��cb_close��5      N . O   CancelO . $	: 311��6N   $��67��6\   $; 50��6g   $< Close��6u   $
= 1733��6�   $
> 1268��6�   $? MS Sans Serif��6�   $@ variable=�6�   $A swiss=�6�   $B 92��6�   $��22��6�   $C -8��6�   $	D 400��6�   6  /
   )Sybase.PowerBuilder.WPF.Controls.CheckBox
  5   
   -   5        $��cbx_visible��5      P 
  
BringToTopP . Q 
  PBWidth$	Q 512��6>   $	��111��6L   R 
  TabOrder$R 20��6X   S 
  Text$S List _visible columns��6f   T 
  X$
T 1321��6�   U 
  Y$	U 196��6�   V 
  	BackColor$V 80263581 6�   W 
  BorderStyle$W stylelowered 6�   X 
  FaceName$X MS Sans Serif��6�   Y 
  	FontPitch$Y variable=�6�   Z 
  PBFontFamily$Z swiss=�6�   [ 
  PBHeight$[ 67��6  $��16��6  \ 
  	TextColor$\ 33554432 6!  ] 
  TextSize$] -8��66  ^ 
  Weight$	^ 400��6D  6S  5      5      