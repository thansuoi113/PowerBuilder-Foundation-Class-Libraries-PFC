   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    peat   w_sortdragdrop   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$	 952��64     PBTitle$
 Sort��6C     PBWidth$
 2176��6R     X$
 1280��6a     Y$	 780��6j     MaxBox .     MinBox .     	Resizable .  	   
WindowType$	 response=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 375��60   $��81��6>      TabOrder$ 30��6I      Text$ _Help��6W      X$
 1742��6d      Y$	 748��6m      FaceName$ MS Sans Serif��6u      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�     5   
   -   5        $��cb_ok��5         Default . $	 375��6:   $��81��6H   $ 10��6S   $ OK��6a   $	 960��6k   $	 748��6s   $ MS Sans Serif��6{   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_sortcolumns��5         
DataObject$ d_sortdragdrop��61      DragIcon$ 
arrowr.ico��6M      Icon$ 
arrowr.ico��6c      PBHScrollBar .    PBHeight$	 612��6�   $	��152��6�      PBWidth$	 955��6�   $	��208��6�      TabOrder$ 0��6�      X$ 37��6�       Y$	  108��6�   !   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$! stylelowered 6�   "   
LiveScroll" . #   PBVScrollBar# . 6  1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $
��st_2��5      $   	BackColor$$ 82889382 6'   %   PBHeight$% 60��6<   $��14��6J   &   PBWidth$	& 942��6V   $	��205��6d   '   Text$#' Columns Available for Sorting��6p   (   	TextColor$( 33554687 6�   )   X$) 46��6�   *   Y$* 44��6�   +   Enabled+ .  ,   FaceName$, MS Sans Serif��6�   -   FocusRectangle- .  .   	FontPitch$. variable=�6�   /   PBFontFamily$/ swiss=�6  0   TextSize$0 -8��6"  1   Weight$	1 400��60  6?    5   
   -   5        $
��st_4��5      2   	Alignment$2 center=�6'   $$ 82889382 6:   $% 60��6O   $��14��6]   $	& 379��6i   $��82��6w   $' 	Ascending��6�   $( 33554687 6�   $
) 1783��6�   $* 44��6�   + .  $, MS Sans Serif��6�   - .  $. variable=�6�   $/ swiss=�6  $0 -8��6"  $	1 400��60  6?    5   
   -   5        $
��st_3��5      $$ 82889382 6'   $% 60��6<   $��14��6J   $	& 759��6V   $	��165��6d   $' Sort Columns��6p   $( 33554687 6�   $
) 1010��6�   $* 44��6�   + .  $, MS Sans Serif��6�   - .  $. variable=�6�   $/ swiss=�6�   $0 -8��6  $	1 400��6!  60    5	   
   -   5        $��	dw_sorted��5	      $ d_sortdragdrop��6,   $ 
arrowl.ico��6H   $	 612��6^   $	��152��6m   $
 1111��6z   $	��242��6�   $ 0��6�   $
 1006��6�   $	  108��6�   $! stylelowered 6�   " . # . 6�     5
   
   -   5        $��	cb_cancel��5
      3   
BringToTop3 . 4   Cancel4 . $	 375��6O   $��81��6]   $ 20��6h   $ Cancel��6v   $
 1353��6�   $	 748��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6   6  5      5      