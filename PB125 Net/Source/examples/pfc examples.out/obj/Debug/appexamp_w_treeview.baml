   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   
w_treeview   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  67108864 6  ���	#fff0f0f0   PBHeight$
 1044��60     PBTitle$) #PFC Example - (5.x) Basic Tree View��6@     PBWidth$
 2921��6n     X$ 5��6}     Y$ 4��6�     ControlMenu .    MaxBox .    MinBox . 	   	Resizable	 . 
   TitleBar
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��cb_refreshlevel��5         PBWidth$	 325��65   $��70��6C      TabOrder$ 40��6N      Text$ Refresh Level��6\      X$
 2514��6q      Y$	 148��6z      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��	sle_level��5         	BackColor$ 79219928 60      PBHeight$ 64��6E   $��15��6S      PBWidth$ 82��6_   $��17��6l      TabOrder$ 30��6w      Text$ 1��6�      	TextColor$ 41943040 6�      X$
 2697��6�      Y$ 60��6�      AutoHScroll .     BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�       FaceName$  MS Sans Serif��6�   !   	FontPitch$! variable=�6�   "   PBFontFamily$" swiss=�6  #   TextSize$# -8��6%  $   Weight$	$ 400��63  6B  1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $��st_level��5      %   	BackColor$% 79219928 6+   &   PBWidth$	& 142��6@   $��30��6N   '   Text$' Level:��6Y   (   	TextColor$( 41943040 6g   )   X$
) 2537��6|   *   Y$* 60��6�   +   Enabled+ .  ,   FaceName$, MS Sans Serif��6�   -   FocusRectangle- .  .   	FontPitch$. variable=�6�   /   PBFontFamily$/ swiss=�6�   0   PBHeight$0 64��6�   $��15��6  1   TextSize$1 -8��6  2   Weight$	2 400��6  6-  1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      3   PBHScrollBar3 . 4   PBHeight$	4 812��6;   $	��202��6J   5   PBWidth$
5 1550��6W   $	��338��6f   6   TabOrder$6 20��6r   7   X$	7 919��6�   8   Y$8 56��6�   9   BorderStyle$9 stylelowered 6�   :   
LiveScroll: . ;   PBVScrollBar; . 6�   /   )Sybase.PowerBuilder.WPF.Controls.TreeView  5   
   -   5        $
��tv_1��5      <   	BackColor$< 
1080593568 6%   =   HideSelection= .  >   LinesAtRoot> . ?   PBHeight$	? 812��6e   $	��202��6t   @   PBWidth$	@ 827��6�   $	��180��6�   A   PictureMaskColor$A 12632256 6�   B   StatePictureMaskColor$B 12632256 6�   C   TabOrder$C 10��6�   D   	TextColor$D 41943040 6�   E   X$E 64��6�   F   Y$F 56��6  G   BorderStyle$G stylelowered 6	  H   FaceName$H MS Sans Serif��6$  I   	FontPitch$I variable=�6=  J   PBFontFamily$J swiss=�6R  K   TextSize$K -8��6g  L   Weight$	L 400��6u  6�    5   
   -   5        $��cb_refreshitem��5      M   
BringToTopM . $	 325��6F   $��70��6T   $ 50��6_   $ Refresh Item��6m   $
 2514��6�   $	 252��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5	   
   -   5        $��cb_refreshtree��5	      M . $	 325��6F   $��70��6T   $ 60��6_   $ Refresh Tree��6m   $
 2514��6�   $	 356��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5
   
   -   5        $��cb_insertrow��5
      M . $	 325��6D   $��70��6R   $ 70��6]   $ 
Insert Row��6k   $
 2514��6}   $	 464��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -	   5        $��cb_deleteitem��5      M . $	 325��6E   $��70��6S   $ 80��6^   $ Delete Item��6l   $
 2514��6   $	 568��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6
    5   
   -
   5        $��cb_updatetree��5      M . $	 325��6E   $��70��6S   $ 90��6^   $ Update Tree��6l   $
 2514��6   $	 676��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6
    5   
   -   5        $��cb_close��5      M . $	 325��6@   $��70��6N   $	 100��6Y   $ Close��6h   $
 2514��6u   $	 780��6~   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6   5      5      