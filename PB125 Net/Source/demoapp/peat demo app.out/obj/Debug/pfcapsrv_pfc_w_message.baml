   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    peat   pfc_w_message   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   ControlMenu .     PBHeight$
 1072��6G     PBWidth$
 2702��6W     ToolbarAlignment$ alignatleft=�6f     X$ 0��6�     Y$	 804��6�     MaxBox .     MinBox .  	   	Resizable	 .  
   
WindowType$
 response=�6�     TitleBar . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.ListView  -   5        $��lv_bmp��5         	BackColor$ 
1090519039 6'      Border .     BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylebox 6M      Enabled .     LargePictureHeight$ 0��6t      LargePictureMaskColor$ 12632256��6�      LargePictureName$* $info.bmp,stop.bmp,excl.bmp,quest.bmp��6�      LargePictureWidth$ 0��6�      PBHeight$	 164��6�   $��40��6	     PBWidth$	 251��6  $��54��6#     	Scrolling .     TabOrder$ 0��6@     	TextColor$ 33554432 6M     X$ 73��6b     Y$ 52��6i     FaceName$ MS Sans Serif��6p     	FontPitch$ variable=�6�     PBFontFamily$ swiss=�6�     SmallPictureHeight$ 16��6�     SmallPictureMaskColor$ 	553648127��6�      SmallPictureWidth$  16��6�  !   StatePictureMaskColor$! 	553648127��6  "   TextSize$" -8��6&  #   Weight$	# 400��64  6C  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $
��cb_1��5      $   TabOrder$$ 10��6*   %   Text$% 1��68   &   X$	& 581��6A   '   Y$	' 404��6I   (   FaceName$( MS Sans Serif��6Q   )   	FontPitch$) variable=�6j   *   PBFontFamily$* swiss=�6   +   PBHeight$+ 92��6�   $��22��6�   ,   PBWidth$	, 352��6�   $��76��6�   -   TextSize$- -8��6�   .   Weight$	. 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $��st_userinput��5      /   PBWidth$
/ 1984��6/   $	��433��6>   0   Text$0 User Input:��6J   1   X$	1 261��6]   2   Y$	2 576��6e   3   	BackColor$3 80263581 6m   4   Enabled4 .  5   FaceName$5 MS Sans Serif��6�   6   FocusRectangle6 .  7   	FontPitch$7 variable=�6�   8   PBFontFamily$8 swiss=�6�   9   PBHeight$9 64��6�   $��15��6�   :   	TextColor$: 33554432 6  ;   TextSize$; -8��6  <   Weight$	< 400��6)  68  4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5   
   -   5        $��mle_userinput��5      =   AutoVScroll= .  >   HideSelection> .  ?   PBHeight$	? 288��6]   $��71��6l   @   PBWidth$
@ 1984��6x   $	��433��6�   A   TabOrder$A 60��6�   B   
VScrollBarB . C   X$	C 261��6�   D   Y$	D 644��6�   E   	BackColor$E 
1090519039 6�   F   BorderStyle$F stylelowered 6�   G   FaceName$G MS Sans Serif��6�   H   	FontPitch$H variable=�6  I   PBFontFamily$I swiss=�6#  J   	TextColor$J 33554432 68  K   TextSize$K -8��6M  L   Weight$	L 400��6[  6j  /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_userinput��5      M   PBHeight$M 36��6-   $��8��6;   N   PBWidth$
N 1984��6F   $	��433��6U   O   TabOrder$O 0��6a   P   Text$P  ��6n   Q   X$	Q 261��6v   R   Y$	R 500��6~   S   	BackColor$S 80263581 6�   T   BorderStyle$T stylelowered 6�   U   FaceName$U MS Sans Serif��6�   V   	FontPitch$V variable=�6�   W   PBFontFamily$W swiss=�6�   X   	TextColor$X 33554432 6�   Y   TextSize$Y -8��6  Z   Weight$	Z 400��6  .��5      �� 6   5	        5
   
   -   5        $
��cb_2��5
      [   
BringToTop[ . $$ 20��6<   $% 2��6J   $	& 960��6S   $	' 404��6[   $( MS Sans Serif��6c   $) variable=�6|   $* swiss=�6�   $+ 92��6�   $��22��6�   $	, 352��6�   $��76��6�   $- -8��6�   $	. 400��6�   6�     5   
   -   5        $
��cb_3��5      [ . $$ 30��6<   $% 3��6J   $
& 1344��6S   $	' 404��6\   $( MS Sans Serif��6d   $) variable=�6}   $* swiss=�6�   $+ 92��6�   $��22��6�   $	, 352��6�   $��76��6�   $- -8��6�   $	. 400��6�   6�     5   
   -   5        $��cb_print��5      [ . $	, 453��6@   $��98��6N   $$ 40��6Y   $% _Print��6g   $
& 2213��6u   $' 52��6~   $( MS Sans Serif��6�   $) variable=�6�   $* swiss=�6�   $+ 92��6�   $��22��6�   $- -8��6�   $	. 400��6�   6�     5   
   -	   5        $��cb_userinput��5      [ . $	, 453��6D   $��98��6R   $$ 50��6]   $% 	_Input >>��6k   $
& 2213��6�   $	' 164��6�   $( MS Sans Serif��6�   $) variable=�6�   $* swiss=�6�   $+ 92��6�   $��22��6�   $- -8��6�   $	. 400��6�   6    5   
   -
   5        $��mle_message��5      = .  $E 80263581 6E   \   Border\ .  $F stylebox 6i   ]   
BringToTop] . ^   DisplayOnly^ . > .  $	? 288��6�   $��71��6�   $
@ 1810��6�   $	��395��6�   $A 0��6�   $	C 334��6�   $D 52��6  $G MS Sans Serif��6  $H variable=�6&  $I swiss=�6;  $J 33554432 6P  $K -8��6e  $	L 400��6s  6�  5      5      