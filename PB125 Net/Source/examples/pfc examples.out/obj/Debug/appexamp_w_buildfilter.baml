   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_buildfilter   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1748��6     PBTitle$. (PFC Example:  Dynamic Filter Expressions��6     PBWidth$
 2715��6J     	Resizable .     TitleBar .    X$	 105��6{     Y$ 4��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_1��5         	BackColor$ 79741120 6%      PBHeight$	 816��6:   $	��203��6I      PBWidth$
 1294��6V   $	��282��6e      TabOrder$ 0��6q      Text$< 6Build Filter from DataWindow Row/Column Specification:��6~      X$ 32��6�      Y$ 24��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6     	TextColor$ 33554432 6(     TextSize$ -8��6=     Weight$	 400��6K  .��5      �� 6   5        5   
   -   5        $
��gb_2��5      $ 79741120 6%   $	 816��6:   $	��203��6I   $
 1253��6V   $	��273��6e   $ 0��6q   $* $Build Filter From Supplied Criteria:��6~   $
 1417��6�   $ 28��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6-  $	 400��6;  .��5      �� 6   5      6   0Sybase.PowerBuilder.WPF.Controls.DropDownListBox  5	   
   -   5        $��ddlb_dwoperator��5	          PBHeight$	 284��67   $��27��6F      PBWidth$	 347��6R   $��75��6`      Sorted .     TabOrder$ 20��6z      X$	 878��6�      Y$	 196��6�      BorderStyle$ stylelowered 6�       FaceName$  MS Sans Serif��6�   !   	FontPitch$! variable=�6�   "   PBFontFamily$" swiss=�6�   #   	TextColor$# 33554432 6�   $   TextSize$$ -8��6  %   
VScrollBar% . &   Weight$	& 400��6+  .@�5
      :   4Sybase.PowerBuilder.WPF.Controls.DropDownListBoxItem  '   Item$' =��6(   63     5      $' >��6(   66     5      $' <��6(   66     5      $' <>��6(   6:     5      $' >=��6(   67     5      $' <=��6(   67   5      1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      (   
DataObject$( d_employeereadonly��6'   )   PBHeight$	) 376��6G   $��93��6V   *   PBWidth$
* 2450��6b   $	��535��6q   +   TabOrder$+ 0��6}   ,   X$	, 114��6�   -   Y$
- 1104��6�   .   BorderStyle$. stylelowered 6�   /   
LiveScroll/ . 0   PBVScrollBar0 . 6�   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5      1   
BringToTop1 . 2   Cancel2 . 3   TabOrder$	3 100��6N   4   Text$4 Close��6]   5   X$
5 2295��6j   6   Y$
6 1544��6s   7   FaceName$7 MS Sans Serif��6|   8   	FontPitch$8 variable=�6�   9   PBFontFamily$9 swiss=�6�   :   PBHeight$: 92��6�   $��22��6�   ;   PBWidth$	; 352��6�   $��76��6�   <   TextSize$< -8��6�   =   Weight$	= 400��6   6  5	   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit	  5   
   -   5        $��	sle_value��5      > 	  	BackColor$> 
1090519039 60   ? 	  
BringToTop? . @ 	  PBWidth$	@ 370��6Y   $��80��6g   A 	  TabOrder$A 60��6r   B 	  X$
B 2249��6�   C 	  Y$	C 196��6�   D 	  AutoHScrollD .  E 	  BorderStyle$E stylelowered 6�   F 	  FaceName$F MS Sans Serif��6�   G 	  	FontPitch$G variable=�6�   H 	  PBFontFamily$H swiss=�6�   I 	  PBHeight$I 77��6  $��19��6  J 	  	TextColor$J 33554432 6  K 	  TextSize$K -8��62  L 	  Weight$	L 400��6@  6O  1
   +Sybase.PowerBuilder.WPF.Controls.StaticText
  5   
   -   5        $
��st_4��5      M 
  
BringToTopM . N 
  Text$N Enter a Value:��69   O 
  X$
O 2249��6O   P 
  Y$	P 112��6X   Q 
  	BackColor$Q 80263581 6`   R 
  EnabledR .  S 
  FaceName$S MS Sans Serif��6�   T 
  FocusRectangleT .  U 
  	FontPitch$U variable=�6�   V 
  PBFontFamily$V swiss=�6�   W 
  PBHeight$W 64��6�   $��15��6�   X 
  PBWidth$	X 344��6�   $��75��6  Y 
  	TextColor$Y 33554432 6  Z 
  TextSize$Z -8��6'  [ 
  Weight$	[ 400��65  6D  
  5   
   -   5        $
��st_5��5      M . $	X 361��69   $��78��6G   $N Select Operator:��6R   $
O 1874��6j   $	P 112��6s   $Q 80263581 6{   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6�   $W 64��6�   $��15��6  $Y 33554432 6  $Z -8��6)  $	[ 400��67  6F    5   
   -	   5        $��cb_dwbuildexpr��5      1 . $	; 425��6F   $��92��6T   $3 30��6_   $4 _Build Expression��6m   $	5 434��6�   $	6 344��6�   $7 MS Sans Serif��6�   $8 variable=�6�   $9 swiss=�6�   $: 92��6�   $��22��6�   $< -8��6�   $	= 400��6  6  	  5   
   -
   5        $��sle_showexpr��5      $> 77633680 63   ? . \ 	  DisplayOnly\ . $
@ 1166��6m   $	��254��6|   $A 0��6�   $	B 814��6�   $	C 972��6�   D .  $E stylelowered 6�   $F MS Sans Serif��6�   $G variable=�6�   $H swiss=�6  $I 77��6  $��19��6%  $J 33554432 61  $K -8��6F  $	L 400��6T  6c  
  5   
   -   5        $
��st_2��5      M . $N Select Column:��69   $	O 421��6O   $	P 112��6W   $Q 80263581 6_   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6�   $W 64��6�   $��15��6�   $	X 344��6�   $��75��6  $Y 33554432 6  $Z -8��6&  $	[ 400��64  6C  
  5   
   -   5        $
��st_3��5      M . $	X 361��69   $��78��6G   $N Select Operator:��6R   $	O 878��6j   $	P 112��6r   $Q 80263581 6z   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6�   $W 64��6�   $��15��6  $Y 33554432 6  $Z -8��6(  $	[ 400��66  6E    5   
   -   5        $��cb_buildexpr��5      1 . $	; 425��6D   $��92��6R   $3 70��6]   $4 Build _Expression��6k   $
5 1838��6�   $	6 344��6�   $7 MS Sans Serif��6�   $8 variable=�6�   $9 swiss=�6�   $: 92��6�   $��22��6�   $< -8��6�   $	= 400��6   6    5   
   -   5        $��ddlb_operator��5       ]   
BringToTop] . $	 264��6G   $��27��6V   $	 347��6b   $��75��6p    .  $ 50��6�   $
 1874��6�   $	 196��6�   $ stylelowered 6�   $  MS Sans Serif��6�   $! variable=�6�   $" swiss=�6�   $# 33554432 6  $$ -8��6  % . $	& 400��6<  .@�5        $' =��6(   63     5      $' >��6(   66     5      $' <��6(   66     5      $' <>��6(   6:     5       $' >=��6(   67     5!      $' <=��6(   67   5"      
  5#   
   -   5        $
��st_1��5#      M . $	X 265��69   $��57��6G   $
N Row:��6R   $O 96��6^   $	P 112��6e   $Q 80263581 6m   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6�   $W 64��6�   $��15��6�   $Y 33554432 6  $Z -8��6  $	[ 400��6)  68    5$   
   -   5        $��cb_reset��5$      1 . $3 90��6@   $4 _Clear Filter��6N   $
5 1920��6c   $
6 1544��6l   $7 MS Sans Serif��6u   $8 variable=�6�   $9 swiss=�6�   $: 92��6�   $��22��6�   $	; 352��6�   $��76��6�   $< -8��6�   $	= 400��6�   6  
  5%   
   -   5        $
��st_6��5%      M . $W 76��69   $��18��6G   $N Select Column:��6S   $
O 1440��6i   $	P 112��6r   $Q 80263581 6z   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6�   $	X 344��6�   $��75��6  $Y 33554432 6  $Z -8��6'  $	[ 400��65  6D    5&   
   -   5        $��ddlb_dwcolumn��5&       ] . $	 264��6G   $��27��6V   $	 407��6b   $��88��6p    .  $ 10��6�   $	 421��6�   $	 196��6�   $ stylelowered 6�   $  MS Sans Serif��6�   $! variable=�6�   $" swiss=�6�   $# 33554432 6  $$ -8��6  % . $	& 400��6;  6J  
  5'   
   -   5        $
��st_7��5'      $Q 77633680 6'   M . $
X 1317��6N   $	��287��6]   $BN <This is the expression built by the base DataWindow service:��6i   $	O 736��6�   $	P 896��6�   R .  $S MS Sans Serif��6�   T .  $U variable=�6�   $V swiss=�6  $W 64��6'  $��15��65  $Y 33554432 6A  $Z -8��6V  $	[ 400��6d  6s  4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5(   
   -   5        $��mle_2��5(      ^   AutoVScroll^ .  _   	BackColor$_ 79741120 6?   `   Border` .  a   BorderStyle$a stylebox 6c   b   
BringToTopb . c   DisplayOnlyc . d   PBHeight$	d 288��6�   $��71��6�   e   PBWidth$
e 1134��6�   $	��247��6�   f   TabOrder$f 0��6�   g   Text$�g �You can also build a dynamic filter expression around a value stored in a script variable by simply calling the "of_BuildExpression" function and supplying it with a column, operator and value.��6�   h   X$
h 1477��6�  i   Y$	i 492��6�  j   FaceName$j MS Sans Serif��6�  k   	FontPitch$k variable=�6�  l   PBFontFamily$l swiss=�6�  m   	TextColor$m 33554432 6	  n   TextSize$n -8��6  o   Weight$	o 400��6,  6;    5)   
   -   5        $��mle_1��5)      ^ .  $_ 79741120 6?   ` .  $a stylebox 6c   b . c . $	d 328��6�   $��81��6�   $
e 1138��6�   $	��248��6�   $f 0��6�   $�g �You can use the base DataWindow service to dynamically build a DataWindow filter expression around the data in a selected row and column.  Select a row from the DataWindow below, then select a column and operator.   Click the "Build Expression" button.��6�   $	h 119��6�  $	i 492��6�  $j MS Sans Serif��6   $k variable=�6  $l swiss=�6.  $m 33554432 6C  $n -8��6X  $	o 400��6f  6u  
  5*   
   -   5        $��st_dwrow��5*      p 
  	Alignment$p right=�6+   $Q 79741120 6=   q 
  Borderq . r 
  BorderStyle$r stylelowered 6`   M . $W 80��6�   $��19��6�   $	X 279��6�   $��60��6�   $N  ��6�   $O 96��6�   $	P 196��6�   R .  $S MS Sans Serif��6�   T .  $U variable=�6  $V swiss=�6,  $Y 33554432 6A  $Z -8��6V  $	[ 400��6d  6s    5+   
   -   5        $��ddlb_column��5+       ] . $	 389��6E   $��84��6S    .  $ 40��6m   $
 1445��6{   $	 196��6�   $ stylelowered 6�   $  MS Sans Serif��6�   $! variable=�6�   $" swiss=�6�   $	 248��6�   $��27��6�   $# 33554432 6  $$ -8��6  % . $	& 400��6:  6I    5,   
   -   5        $��cb_apply��5,      1 . s   Defaults . $3 80��6O   $4 _Apply Filter��6]   $
5 1545��6r   $
6 1544��6{   $7 MS Sans Serif��6�   $8 variable=�6�   $9 swiss=�6�   $: 92��6�   $��22��6�   $	; 352��6�   $��76��6�   $< -8��6�   $	= 400��6  6  5-      5.      