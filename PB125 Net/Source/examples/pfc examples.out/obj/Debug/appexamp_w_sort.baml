   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_sort   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1636��6      PBTitle$( "PFC Example - Sort Service Dialogs��6     PBWidth$
 2117��6=     	Resizable .     TitleBar .    X$	 421��6n     Y$ 68��6v     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6}  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_1��5         	BackColor$ 82889382 6%      PBHeight$	 284��6:   $��70��6I      PBWidth$
 2030��6U   $	��443��6d      TabOrder$ 10��6p      Text$  Select a Sort Dialog Style��6~      	TextColor$ 33554687 6�      X$ 27��6�      Y$ 32��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6     TextSize$ -8��6!     Weight$	 400��6/  .��5      �� .+�5      2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $
��rb_1��5   $      	BackColor$ 80263581 60      BorderStyle$ stylelowered 6E      FaceName$ MS Sans Serif��6`      	FontPitch$ variable=�6y      	PBChecked .    PBFontFamily$ swiss=�6�      PBHeight$ 67��6�   $��16��6�       PBWidth$	  731��6�   $	��159��6�   !   Text$! Drag/Drop _Columns Style��6�   "   	TextColor$" 33554432 6  #   TextSize$# -8��6  $   Weight$	$ 400��6+  %   X$% 32��68  &   Y$& 29��6?  6H    5      -   5        $
��rb_3��5   $   $ 80263581 60   $ stylelowered 6E   '   
BringToTop' . $ MS Sans Serif��6r   $ variable=�6�   $ swiss=�6�   $ 67��6�   $��16��6�   $	  731��6�   $	��159��6�   $! _Drop-down List Box Style��6�   $" 33554432 6
  $# -8��6  $	$ 400��6-  $% 32��6:  $	& 117��6A  6K    5      -   5        $
��rb_2��5   $   $ 80263581 60   $ stylelowered 6E   ' . $ MS Sans Serif��6r   $ variable=�6�   $ swiss=�6�   $ 67��6�   $��16��6�   $	  731��6�   $	��159��6�   $!! Si_mple Single Column Style��6�   $" 33554432 6  $# -8��6!  $	$ 400��6/  $	% 805��6<  $& 29��6D  6M    5      -   5        $
��rb_4��5   $   $ 80263581 60   $ stylelowered 6E   ' . $ MS Sans Serif��6r   $ variable=�6�   $ swiss=�6�   $ 67��6�   $��16��6�   $	  731��6�   $	��159��6�   $!! _PowerBuilder Default Style��6�   $" 33554432 6  $# -8��6!  $	$ 400��6/  $	% 805��6<  $	& 117��6D  6N  5	      5
      4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5      (   Cancel( . )   TabOrder$) 30��6<   *   Text$* Close��6J   +   X$
+ 1696��6W   ,   Y$
, 1424��6`   -   FaceName$- MS Sans Serif��6i   .   	FontPitch$. variable=�6�   /   PBFontFamily$/ swiss=�6�   0   PBHeight$0 92��6�   $��22��6�   1   PBWidth$	1 352��6�   $��76��6�   2   TextSize$2 -8��6�   3   Weight$	3 400��6�   6�     5   
   -   5        $��cb_sort��5      $) 20��6-   $* 	_Set Sort��6;   $
+ 1321��6L   $
, 1424��6U   $- MS Sans Serif��6^   $. variable=�6w   $/ swiss=�6�   $0 92��6�   $��22��6�   $	1 352��6�   $��76��6�   $2 -8��6�   $	3 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      4   
DataObject$4 d_customerlist��6'   5   PBHScrollBar5 . 6   PBHeight$
6 1008��6W   $	��251��6g   7   PBWidth$
7 2030��6t   $	��443��6�   8   TabOrder$8 0��6�   9   X$9 27��6�   :   Y$	: 372��6�   ;   BorderStyle$; stylelowered 6�   <   
LiveScroll< . =   PBVScrollBar= . 6�   5      5      