   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_filtersimple   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$
 1160��64     PBTitle$ Filter��6D     PBWidth$
 2510��6U     MaxBox .     MinBox .     	Resizable .     
WindowType$ response=�6�     X$	 214��6�  	   Y$		 221��6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 375��60   $��81��6>      TabOrder$ 60��6I      Text$ _Help��6W      X$
 2034��6d      Y$	 936��6m      FaceName$ MS Sans Serif��6u      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�     5   
   -   5        $��cb_ok��5         Default . $	 375��6:   $��81��6H   $ 40��6S   $ OK��6a   $
 1248��6k   $	 936��6t   $ MS Sans Serif��6|   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_newfilter��5         	BackColor$ 82889382 6-      PBHeight$	 568��6B   $	��141��6Q      PBWidth$
 2432��6^   $	��531��6m      TabOrder$ 0��6y      Text$ New Filter Criteria��6�      	TextColor$ 33554687 6�      X$ 14��6�      Y$	 340��6�       BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$  stylelowered 6�   !   FaceName$! MS Sans Serif��6�   "   	FontPitch$" variable=�6�   #   PBFontFamily$# swiss=�6  $   TextSize$$ -8��6#  %   Weight$	% 400��61  .��5      �� 6   5        5   
   -   5        $��cb_add��5      $	 375��6,   $��81��6:   $ 20��6E   $
 _Add��6S   $
 2034��6_   $	 452��6h   $ MS Sans Serif��6p   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5	   
   -   5        $��gb_originalfilter��5	      $ 82889382 62   $	 276��6G   $��68��6V   $
 2432��6b   $	��531��6q   $ 0��6}   $ Original Filter Criteria��6�   $ 33554687 6�   $ 14��6�   $ 4��6�   $  stylelowered 6�   $! MS Sans Serif��6�   $" variable=�6   $# swiss=�6  $$ -8��6*  $	% 400��68  .��5
      �� 6   5      4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5   
   -   5        $��mle_originalfilter��5      &   	BackColor$& 80263581 68   '   Border' .  (   BorderStyle$( stylebox 6\   )   DisplayOnly) . *   PBHeight$	* 180��6�   $��44��6�   +   PBWidth$
+ 2350��6�   $	��513��6�   ,   TabOrder$, 0��6�   -   
VScrollBar- . .   X$. 59��6�   /   Y$/ 64��6�   0   AutoVScroll0 . 1   FaceName$1 MS Sans Serif��6�   2   	FontPitch$2 variable=�6  3   PBFontFamily$3 swiss=�6*  4   	TextColor$4 33554432 6?  5   TextSize$5 -8��6T  6   Weight$	6 400��6b  6q  1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��	dw_filter��5      7   Border7 .  8   BorderStyle$8 stylebox 6;   9   
DataObject$9 d_filtersimple��6R   :   PBHeight$	: 500��6n   $	��124��6}   ;   PBWidth$
; 1952��6�   $	��426��6�   <   TabOrder$< 10��6�   =   X$= 59��6�   >   Y$	> 388��6�   ?   
LiveScroll? . @   PBVScrollBar@ . 6�     5   
   -   5        $��	cb_cancel��5      A   CancelA . $	 375��6=   $��81��6K   $ 50��6V   $ Cancel��6d   $
 1641��6r   $	 936��6{   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -	   5        $��	cb_delete��5      $	 375��6/   $��81��6=   $ 30��6H   $ _Delete��6V   $
 2034��6e   $	 552��6n   $ MS Sans Serif��6v   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   5      5      