   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_filterdialogs   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1408��6	     PBTitle$* $PFC Example - Filter Service Dialogs��6     PBWidth$
 2107��6H     	Resizable .     X$	 375��6i     Y$ 80��6q     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6x  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   TitleBar
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $
��cb_1��5         TabOrder$ 20��6*      Text$ Set _Filter��68      X$	 951��6K      Y$
 1188��6S      FaceName$ MS Sans Serif��6\      	FontPitch$ variable=�6u      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      PBWidth$	 352��6�   $��76��6�      TextSize$ -8��6�      Weight$	 400��6�   6�     5   
   -   5        $��cb_retrieve��5      $ 30��61   $ _Reset Filter��6?   $
 1326��6T   $
 1188��6]   $ MS Sans Serif��6f   $ variable=�6   $ swiss=�6�   $ 92��6�   $��22��6�   $	 352��6�   $��76��6�   $ -8��6�   $	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $
��gb_3��5         	BackColor$ 79219928 6%      PBHeight$	 160��6:   $��39��6I      PBWidth$
 2011��6U   $	��439��6d      TabOrder$ 10��6p      Text$  Select Filter Dialog Style��6~      	TextColor$ 41943040 6�      X$ 37��6�      Y$ 32��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�       	FontPitch$  variable=�6�   !   PBFontFamily$! swiss=�6  "   TextSize$" -8��6!  #   Weight$	# 400��6/  .��5      �� .+�5      2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $
��rb_1��5   $   $   	BackColor$$ 80263581 60   %   BorderStyle$% stylelowered 6E   &   
BringToTop& . '   FaceName$' MS Sans Serif��6r   (   	FontPitch$( variable=�6�   )   	PBChecked) . *   PBFontFamily$* swiss=�6�   +   PBHeight$+ 67��6�   $��16��6�   ,   PBWidth$	, 480��6�   $	��104��6�   -   Text$- _Simple (a=b) Style��6�   .   	TextColor$. 33554432 6  /   TextSize$/ -8��6*  0   Weight$	0 400��68  1   X$1 41��6E  2   Y$2 21��6L  6U    5      -   5        $
��rb_2��5   $   $$ 80263581 60   $% stylelowered 6E   & . $' MS Sans Serif��6r   $( variable=�6�   $* swiss=�6�   $+ 67��6�   $��16��6�   $	, 581��6�   $	��126��6�   $- PFC _Extended Wizard��6�   $. 33554432 6  $/ -8��6  $	0 400��6(  $	1 685��65  $2 21��6=  6F    5	      -   5        $
��rb_3��5	   $   $$ 80263581 60   $% stylelowered 6E   & . $' MS Sans Serif��6r   $( variable=�6�   $* swiss=�6�   $+ 67��6�   $��16��6�   $	, 558��6�   $	��121��6�   $- _PowerBuilder Default��6�   $. 33554432 6  $/ -8��6  $	0 400��6)  $
1 1426��66  $2 21��6?  6H  5
      5        5   
   -   5        $��cb_close��5      3   Cancel3 . $ 40��6<   $ Close��6J   $
 1696��6W   $
 1188��6`   $ MS Sans Serif��6i   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $	 352��6�   $��76��6�   $ -8��6�   $	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      4   
DataObject$4 d_customerlist��6'   5   PBHeight$	5 900��6C   $	��224��6R   6   PBWidth$
6 2011��6_   $	��439��6n   7   TabOrder$7 0��6z   8   X$8 37��6�   9   Y$	9 244��6�   :   BorderStyle$: stylelowered 6�   ;   
LiveScroll; . <   PBVScrollBar< . 6�   5      5      