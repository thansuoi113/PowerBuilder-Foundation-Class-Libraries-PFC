   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_multiupdate   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1660��6     PBTitle$) #PFC Example - Multiple Table Update��6     PBWidth$
 2843��6E     	Resizable .     TitleBar .    X$ 37��6v     Y$	 128��6}     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_2��5         PBWidth$
 2752��6%   $	��601��64      TabOrder$ 0��6@      Text$  ��6M      X$ 37��6U      Y$ 28��6\      	BackColor$ 80263581 6c      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6x      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$	 250��6�   $��62��6�      	TextColor$ 33554432 6�      TextSize$ -8��6     Weight$	 400��6  .��5      �� 6   5        5   
   -   5        $
��gb_1��5      $	 180��6%   $��44��64   $
 1339��6@   $	��292��6O   $ 0��6[   $ Table Legend��6h   $ 59��6|   $
 1344��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 33554432 6�   $ -8��6  $	 400��6"  .��5      �� 6   5      4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5	   
   -   5        $��cb_retrieve��5	         TabOrder$ 20��61      Text$ 	_Retrieve��6?      X$
 1678��6P      Y$
 1432��6Y      FaceName$ MS Sans Serif��6b      	FontPitch$ variable=�6{      PBFontFamily$ swiss=�6�       PBHeight$  92��6�   $��22��6�   !   PBWidth$	! 352��6�   $��76��6�   "   TextSize$" -8��6�   #   Weight$	# 400��6�   6�     5
   
   -   5        $��	cb_update��5
      $ 30��6/   $ _Update��6=   $
 2057��6L   $
 1432��6U   $ MS Sans Serif��6^   $ variable=�6w   $ swiss=�6�   $  92��6�   $��22��6�   $	! 352��6�   $��76��6�   $" -8��6�   $	# 400��6�   6�     5   
   -   5        $��cb_close��5      $   Cancel$ . $ 40��6<   $ Close��6J   $
 2437��6W   $
 1432��6`   $ MS Sans Serif��6i   $ variable=�6�   $ swiss=�6�   $  92��6�   $��22��6�   $	! 352��6�   $��76��6�   $" -8��6�   $	# 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $
��st_2��5      %   	Alignment$% center=�6'   &   	BackColor$& 82889382 6:   '   PBHeight$' 68��6O   $��16��6]   (   PBWidth$
( 2674��6i   $	��584��6x   )   Text$m) gThis DataWindow joins three tables on "Customer ID".   See the legend below for table reference colors.��6�   *   	TextColor$* 33554432 6�   +   X$+ 78��6  ,   Y$	, 164��6  -   Enabled- .  .   FaceName$. MS Sans Serif��61  /   FocusRectangle/ .  0   	FontPitch$0 variable=�6a  1   PBFontFamily$1 swiss=�6v  2   TextSize$2 -8��6�  3   Weight$	3 400��6�  6�  1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      4   
DataObject$4 d_multiupdate��6'   5   PBHeight$
5 1004��6B   $	��250��6R   6   PBWidth$
6 2761��6_   $	��603��6n   7   TabOrder$7 10��6z   8   X$8 32��6�   9   Y$	9 316��6�   :   BorderStyle$: stylelowered 6�   ;   
LiveScroll; . <   PBVScrollBar< . 6�     5   
   -   5        $
��st_1��5      $	& 128 6'   =   Border= . >   BorderStyle$> stylelowered 6E   ?   
BringToTop? . $' 76��6r   $��18��6�   $( 91��6�   $��19��6�   $)  ��6�   $+ 91��6�   $
, 1408��6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6�   $1 swiss=�6  $* 33554432 6&  $2 -8��6;  $	3 400��6I  6X    5   
   -	   5        $
��st_3��5      ? . $' 76��69   $��18��6G   $	( 233��6S   $��50��6a   $) Customer��6l   $	+ 187��6|   $
, 1420��6�   $& 80263581 6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6�   $1 swiss=�6�   $* 33554432 6  $2 -8��6!  $	3 400��6/  6>    5   
   -
   5        $
��st_4��5      $& 32768 6'   = . $> stylelowered 6G   ? . $' 76��6t   $��18��6�   $( 91��6�   $��19��6�   $)  ��6�   $	+ 434��6�   $
, 1408��6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6�   $1 swiss=�6  $* 33554432 6)  $2 -8��6>  $	3 400��6L  6[    5   
   -   5        $
��st_5��5      ? . $' 76��69   $��18��6G   $	( 434��6S   $��94��6a   $) Sales__Order__Items��6l   $	+ 535��6�   $
, 1420��6�   $& 80263581 6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6�   $1 swiss=�6  $* 33554432 6  $2 -8��6,  $	3 400��6:  6I    5   
   -   5        $
��st_6��5      $& 8388736 6'   = . $> stylelowered 6I   ? . $' 76��6v   $��18��6�   $( 91��6�   $��19��6�   $)  ��6�   $	+ 992��6�   $
, 1408��6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6  $1 swiss=�6  $* 33554432 6+  $2 -8��6@  $	3 400��6N  6]    5   
   -   5        $
��st_7��5      ? . $' 76��69   $��18��6G   $	( 274��6S   $��59��6a   $) Sales__Order��6l   $
+ 1088��6�   $
, 1420��6�   $& 80263581 6�   - .  $. MS Sans Serif��6�   / .  $0 variable=�6�   $1 swiss=�6�   $* 33554432 6  $2 -8��6&  $	3 400��64  6C    5   
   -   5        $
��st_8��5      $% center=�6'   $& 79741120 6:   ? . $
( 2674��6a   $	��584��6p   $h) bThe Multiple Table Update Service will enable you to update several tables through one DataWindow.��6|   $* 33554432 6�   $+ 78��6�   $	, 100��6  - .  $. MS Sans Serif��6  / .  $0 variable=�6J  $1 swiss=�6_  $' 64��6t  $��15��6�  $2 -8��6�  $	3 400��6�  6�  5      5      