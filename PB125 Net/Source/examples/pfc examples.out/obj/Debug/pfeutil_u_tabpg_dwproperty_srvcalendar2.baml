   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp%   u_tabpg_dwproperty_srvcalendar2   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6U   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   1   +Sybase.PowerBuilder.WPF.Controls.UserObject    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6     PBHeight$
 1384��62  $	��345��6B     PBWidth$
 1765��6O  $	��385��6^     PictureMaskColor$ 	553648127 6j     TabBackColor$ 79741120 6�     TabTextColor$ 33554432 6�  .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $��	gb_sunday��5         PBHeight$	 340��6*   $��84��69      PBWidth$	 814��6E   $	��177��6S      TabOrder$ 0��6_   	   Text$	 Sunday��6l   
   X$
 27��6z      Y$ 36��6�      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6�      TextSize$ -8��6     Weight$	 400��6  .��5      �� 6   5        5   
   -   5        $��gb_saturday��5      $	 340��6,   $��84��6;   $	 814��6G   $	��177��6U   $ 0��6a   $	 Saturday��6n   $	
 887��6~   $ 36��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 33554432 6   $ -8��6  $	 400��6#  .��5      �� 6   5        5	   
   -   5        $��gb_markedday��5	      $	 904��6-   $	��225��6<   $	 814��6I   $	��177��6W   $ 0��6c   $	 Other��6p   $	
 887��6}   $	 424��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 33554432 6   $ -8��6  $	 400��6#  .��5
      �� 6   5        5   
   -   5        $��
gb_holiday��5      $	 904��6+   $	��225��6:   $	 814��6G   $	��177��6U   $ 0��6a   $	 Holiday��6n   $
 27��6}   $	 424��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 33554432 6�   $ -8��6  $	 400��6"  .��5      �� 6   5      1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $��st_colorsaturdary��5         	Alignment$ center=�64      PBWidth$	 379��6G   $��82��6U      Text$ Color��6`      X$	 914��6m      Y$	 220��6u      	BackColor$ 80263581 6}      Enabled .     FaceName$ MS Sans Serif��6�      FocusRectangle .     	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 64��6�   $��15��6
      	TextColor$  33554432 6  !   TextSize$! -8��6+  "   Weight$	" 400��69  6H  /   )Sybase.PowerBuilder.WPF.Controls.EditMask  5   
   -   5        $��em_colorsaturday��5      _ [Sybase.DataWindow.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cc0f66dd9541b3da.  (Sybase.DataWindow.Shared.EditMaskControl#   DisplayData$#  ��61   $   	Increment$$ 0��6@   %   Mask$% ########��6N   &   MinMax$&  ��6^   '   PBHeight$' 76��6h   $��18��6v   (   PBWidth$	( 320��6�   $��69��6�   )   TabOrder$) 40��6�   *   TextAlignment$* right=�6�   +   X$
+ 1321��6�   ,   Y$	, 212��6�   -   	BackColor$- 
1090519039 6�   .   BorderStyle$. stylelowered 6�   $��MS Sans Serif)�6  /   	FontPitch$/ variable=�6  0   PBFontFamily$0 swiss=�62  1   	TextColor$1 33554432 6G  2   TextSize$2 -8��6\  3   Weight$	3 400��6j  6y  1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_holidays��5      4   Border4 .  5   BorderStyle$5 stylebox 6=   6   
DataObject$6 d_dwproperty_dates��6T   7   PBHeight$	7 572��6t   $	��142��6�   8   PBWidth$	8 530��6�   $	��115��6�   9   TabOrder$9 70��6�   :   X$	: 206��6�   ;   Y$	; 728��6�   <   
LiveScroll< . =   PBVScrollBar= . 6�   /	   )Sybase.PowerBuilder.WPF.Controls.CheckBox	  5   
   -   5        $��cbx_boldsaturdays��5      > 	  
BringToTop> . ? 	  PBHeight$? 68��6D   $��16��6R   @ 	  PBWidth$	@ 594��6^   $	��129��6l   A 	  TabOrder$A 30��6x   B 	  Text$
B Bold��6�   C 	  X$
C 1047��6�   D 	  Y$	D 116��6�   E 	  	BackColor$E 80263581 6�   F 	  BorderStyle$F stylelowered 6�   G 	  FaceName$G MS Sans Serif��6�   H 	  	FontPitch$H variable=�6�   I 	  PBFontFamily$I swiss=�6  J 	  	TextColor$J 33554432 6  K 	  TextSize$K -8��6+  L 	  Weight$	L 400��69  6H  	  5   
   -	   5        $��cbx_boldsundays��5      > . $? 68��6B   $��16��6P   $	@ 594��6\   $	��129��6j   $A 10��6v   $
B Bold��6�   $	C 210��6�   $	D 120��6�   $E 80263581 6�   $F stylelowered 6�   $G MS Sans Serif��6�   $H variable=�6�   $I swiss=�6�   $J 33554432 6  $K -8��6(  $	L 400��66  6E  	  5   
   -
   5        $��cbx_boldholidays��5      > . $? 68��6C   $��16��6Q   $	@ 594��6]   $	��129��6k   $A 50��6w   $
B Bold��6�   $	C 210��6�   $	D 520��6�   $E 80263581 6�   $F stylelowered 6�   $G MS Sans Serif��6�   $H variable=�6�   $I swiss=�6�   $J 33554432 6  $K -8��6)  $	L 400��67  6F  	  5   
   -   5        $��cbx_boldmarkeddays��5      > . $? 68��6E   $��16��6S   $	@ 594��6_   $	��129��6m   $A 80��6y   $
B Bold��6�   $
C 1047��6�   $	D 520��6�   $E 80263581 6�   $F stylelowered 6�   $G MS Sans Serif��6�   $H variable=�6�   $I swiss=�6  $J 33554432 6  $K -8��6,  $	L 400��6:  6I    5   
   -   5        $��dw_markeddays��5      4 .  $5 stylebox 6?   M   
BringToTopM . $6 d_dwproperty_dates��6h   $	7 572��6�   $	��142��6�   $	8 530��6�   $	��115��6�   $	9 100��6�   $
: 1047��6�   $	; 728��6�   < . = . 6    5   
   -   5        $��em_colorsunday��5      N   
BringToTopN . $#  ��6A   $$ 0��6P   $% ########��6^   $&  ��6n   $' 76��6x   $��18��6�   $	( 320��6�   $��69��6�   $) 20��6�   $* right=�6�   $	+ 480��6�   $	, 212��6�   $- 
1090519039 6�   $. stylelowered 6�   $��MS Sans Serif)�6  $/ variable=�6,  $0 swiss=�6A  $1 33554432 6V  $2 -8��6k  $	3 400��6y  6�    5   
   -   5        $��st_colorsunday��5      $ center=�61   O   
BringToTopO . $	 379��6V   $��82��6d   $ Color��6o   $ 78��6|   $	 220��6�   $ 80263581 6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6�   $ 64��6
  $��15��6  $  33554432 6$  $! -8��69  $	" 400��6G  6V    5   
   -   5        $��em_colorholiday��5      N . $#  ��6B   $$ 0��6Q   $% ########��6_   $&  ��6o   $' 76��6y   $��18��6�   $	( 320��6�   $��69��6�   $) 60��6�   $* right=�6�   $	+ 480��6�   $	, 612��6�   $- 
1090519039 6�   $. stylelowered 6�   $��MS Sans Serif)�6  $/ variable=�6-  $0 swiss=�6B  $1 33554432 6W  $2 -8��6l  $	3 400��6z  6�    5   
   -   5        $��st_colorholiday��5      $ center=�62   O . $	 379��6W   $��82��6e   $ Color��6p   $ 73��6}   $	 620��6�   $ 80263581 6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6�   $ 64��6  $��15��6  $  33554432 6%  $! -8��6:  $	" 400��6H  6W    5   
   -   5        $��em_colormarkedday��5      N . $#  ��6D   $$ 0��6S   $% ########��6a   $&  ��6q   $' 76��6{   $��18��6�   $	( 320��6�   $��69��6�   $) 90��6�   $* right=�6�   $
+ 1321��6�   $	, 604��6�   $- 
1090519039 6�   $. stylelowered 6�   $��MS Sans Serif)�6  $/ variable=�60  $0 swiss=�6E  $1 33554432 6Z  $2 -8��6o  $	3 400��6}  6�    5   
   -   5        $��st_colormarkedday��5      $ center=�64   O . $	 379��6Y   $��82��6g   $ Color��6r   $	 914��6   $	 624��6�   $ 80263581 6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6�   $ 64��6  $��15��6  $  33554432 6(  $! -8��6=  $	" 400��6K  6Z  5      5      