   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   	w_tablink   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1556��6     PBTitle$$ PFC Example - Across Tab Pages��6     PBWidth$
 2729��6<     	Resizable .     X$ 5��6]     Y$ 4��6c     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6i  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   TitleBar
 . .��5      �� .+�5   
   .   (Sybase.PowerBuilder.WPF.Controls.Picture  -   5        $	��p_1��5         OriginalSize .    PBHeight$ 64��67   $��15��6E      PBWidth$ 73��6Q   $��15��6^      PictureName$ 
rowind.bmp��6i      Visible .     X$
 2427��6�      Y$	 540��6�      FocusRectangle .  6�   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $
��cb_2��5         TabOrder$ 2��6*      X$
 2277��67      Y$	 260��6@      PBHeight$ 72��6H   $��17��6V      PBWidth$	 320��6b   $��69��6p      Text$ _SQL Spy��6{      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      TextSize$ -8��6�      Weight$	 400��6�   6�   *   $Sybase.PowerBuilder.WPF.Controls.Tab  5   
   -   5        $��tab_1��5         	BackColor$ 77571519 6!      PBWidth$
 2610��66   $	��570��6E       TabOrder$  20��6Q   !   X$! 32��6_   "   Y$	" 684��6f   #   PBHeight$	# 724��6n   $	��180��6}   $   FaceName$$ MS Sans Serif��6�   %   	FontPitch$% variable=�6�   &   PBFontFamily$& swiss=�6�   '   RaggedRight' . (   SelectedTab$( 1��6�   )   ShowPicture) .  *   TextSize$* -8��6  +   Weight$	+ 400��6  .@�5      .   (Sybase.PowerBuilder.WPF.Controls.TabPage  -   5        $��tab_1_tabpage_1��5      ,   	BackColor$, 80263328 63   -   PBHeight$	- 608��6H   .   PBWidth$
. 2523��6W   /   TabBackColor$/ 80263328 6f   0   Text$0 Customer (by Scroll)��6~   1   X$1 18��6�   2   Y$	2 100��6�   3   PictureMaskColor$3 12632256 6�   4   PictureName$4 picture!��6�   5   PowerTipText$B5 <Scrolls to the customer information for selected sales order��6�   6   TabTextColor$6 33554432 6(  .��5      �� .+�5      1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  -   5        $��tab_1_tabpage_1_dw_1��5   '   7   
DataObject$7 	d_custtab��6C   8   PBHeight$	8 560��6Z   $	��139��6i   9   PBVScrollBar9 .  :   PBWidth$
: 2455��6�   $	��536��6�   ;   X$; 32��6�   <   Y$< 24��6�   =   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$= stylelowered 6�   >   
LiveScroll> . ?   TabOrder$? 1��6�   5	      5
        5      -   5        $��tab_1_tabpage_2��5      $, 80263328 63   $	- 608��6H   $
. 2523��6W   $/ 80263328 6f   $"0 Items Ordered (by Retrieval)��6~   $1 18��6�   $	2 100��6�   $3 12632256 6�   $4 arrangeicons!��6�   $K5 ESelected items ordered by retrieval argument for selected sales order��6�   $6 33554432 6>  .��5      �� .+�5        -   5        $��tab_1_tabpage_2_p_1��5   $    . $ 64��6S   $��15��6a   $ 73��6m   $��15��6z   $ 
rowind.bmp��6�   $
 2674��6�   $	 224��6�    .  6�     5      -   5        $��tab_1_tabpage_2_dw_1��5   '   $7 d_lineitemstab��6C   $	8 560��6_   $	��139��6n   $
: 2455��6{   $	��536��6�   $; 32��6�   $< 24��6�   $= stylelowered 6�   > . 9 . $? 1��6�   5      5        5      -	   5        $��tab_1_tabpage_3��5      $, 80263328 63   $	- 608��6H   $
. 2523��6W   $/ 80263328 6f   $1 18��6~   $	2 100��6�   $3 12632256 6�   $4 editstops5!��6�   $F5 @Filters to the sales representative for the selected sales order��6�   $&0  Sales Representative (by Filter)��6  $6 33554432 6;  .��5      �� .+�5        -
   5        $��tab_1_tabpage_3_p_1��5   $    . $ 64��6S   $��15��6a   $ 73��6m   $��15��6z   $ 
rowind.bmp��6�   $
 2729��6�   $	 328��6�    .  6�     5      -   5        $��tab_1_tabpage_3_dw_1��5   '   $7 d_salesreptab��6C   $	8 560��6^   $	��139��6m   9 .  $
: 2450��6�   $	��535��6�   $; 32��6�   $< 24��6�   $= stylelowered 6�   > . $? 1��6�   5      5      5        5   
   -   5        $
��cb_4��5      $	 370��6*   $��80��68   $ 40��6C   $ 	_Retrieve��6Q   $
 2277��6b   $	 144��6k   $ MS Sans Serif��6s   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $
��cb_3��5      $	 370��6*   $��80��68   $ 30��6C   $ _Update��6Q   $
 2277��6`   $ 32��6i   $ MS Sans Serif��6p   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $
��cb_1��5      @   Cancel@ . $	 370��68   $��80��6F   $ 50��6Q   $ Close��6_   $
 2277��6l   $	 384��6u   $ MS Sans Serif��6}   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $
��dw_1��5      $7 d_salesforcustomersall��6'   $	8 604��6K   $	��150��6Z   $
: 2185��6g   $	��477��6v   $? 10��6�   $; 37��6�   $< 32��6�   $= stylelowered 6�   > . 9 . 6�   5      5      