   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_linkautoupdate   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1712��6
     PBTitle$/ )PFC Example - Retrieval with Auto-updates��6     PBWidth$
 1659��6N     	Resizable .     TitleBar .    ToolbarVisible .     X$	 457��6�     Y$	 148��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0	   ControlMenu	 . 
   MaxBox
 .    MinBox . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_2��5         	BackColor$ 79741120 6%      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6:      FaceName$ MS Sans Serif��6U      	FontPitch$ variable=�6n      PBFontFamily$ swiss=�6�      PBHeight$	 188��6�      PBWidth$
 1559��6�      TabOrder$ 20��6�      Text$ Example Options��6�      	TextColor$ 33554432 6�      TextSize$ -8��6�      Weight$	 400��6�      X$ 41��6     Y$ 32��6  .��5      �� 6   5      .   (Sybase.PowerBuilder.WPF.Controls.Picture  5   
   -   5        $	��p_1��5         OriginalSize .    PBHeight$ 64��67   $��15��6E      PBWidth$ 73��6Q   $��15��6^      PictureName$ 
rowind.bmp��6i      X$
 2121��6�      Y$	 360��6�       FocusRectangle  .  6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_lineitem��5      !   
DataObject$! d_lineitemsupdatable��6.   "   
LiveScroll" .  #   PBHeight$	# 420��6c   $	��104��6r   $   PBTag$$ linetag��6   %   PBWidth$
% 1573��6�   $	��343��6�   &   TabOrder$& 40��6�   '   X$' 37��6�   (   Y$
( 1060��6�   )   BorderStyle$) stylelowered 6�   *   PBVScrollBar* . 6�     5   
   -   5        $��dw_sales��5      $"! d_salesforcustomersupdatable��6+   " .  $	# 424��6h   $	��105��6w   $$ salestag��6�   $
% 1573��6�   $	��343��6�   $& 30��6�   $' 37��6�   $	( 616��6�   $) stylelowered 6�   * . 6�     5	   
   -   5        $��dw_cust��5	      $! d_customerdetailupdatable��6*   " .  $	# 364��6d   $��90��6s   $$ custtag��6   $
% 1573��6�   $	��343��6�   $& 10��6�   $' 37��6�   $	( 236��6�   $) stylelowered 6�   * . 6�   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5
   
   -   5        $��cb_close��5
      +   Cancel+ . ,   PBHeight$, 80��6<   $��19��6J   -   PBWidth$	- 311��6V   $��67��6d   .   TabOrder$. 60��6o   /   Text$/ Close��6}   0   X$
0 1303��6�   1   Y$
1 1516��6�   2   FaceName$2 MS Sans Serif��6�   3   	FontPitch$3 variable=�6�   4   PBFontFamily$4 swiss=�6�   5   TextSize$5 -8��6�   6   Weight$	6 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $!��cbx_confirmationonrowchange��5      7   	BackColor$7 77571519 6<   8   
BringToTop8 . 9   	PBChecked9 . :   PBHeight$: 80��6t   $��19��6�   ;   PBWidth$	; 754��6�   $	��164��6�   <   Text$!< Confirmation on _Row change��6�   =   X$	= 128��6�   >   Y$	> 100��6�   ?   BorderStyle$? stylelowered 6�   @   FaceName$@ MS Sans Serif��6�   A   	FontPitch$A variable=�6  B   PBFontFamily$B swiss=�6$  C   	TextColor$C 33554432 69  D   TextSize$D -8��6N  E   Weight$	E 400��6\  6k    5   
   -   5        $
��cb_1��5      F   
BringToTopF . $, 80��6<   $��19��6J   $	- 311��6V   $��67��6d   $. 50��6o   $/ SQL Spy��6}   $	0 969��6�   $
1 1516��6�   $2 MS Sans Serif��6�   $3 variable=�6�   $4 swiss=�6�   $5 -8��6�   $	6 400��6�   6�   5      5      