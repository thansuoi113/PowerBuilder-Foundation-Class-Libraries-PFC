   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_dwprintpreview   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1508��6
     PBTitle$) #PFC Example - Print Preview Service��6     PBWidth$
 2080��6H     	Resizable .     TitleBar .    X$	 402��6y     Y$	 128��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_1��5         PBHeight$	 188��6%   $��46��64      PBWidth$
 1984��6@   $	��433��6O      TabOrder$ 0��6[      Text$ Example Options��6h      X$ 41��6      Y$ 32��6�      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6      TextSize$ -8��6     Weight$	 400��6#  .��5      �� 6   5      /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_printpreview��5         PBWidth$	 384��61   $��83��6?      TabOrder$ 10��6J      Text$ Print _Preview��6X      X$ 73��6n      Y$	 116��6u      	BackColor$ 80263581 6}      BorderStyle$ stylelowered 6�       FaceName$  MS Sans Serif��6�   !   	FontPitch$! variable=�6�   "   PBFontFamily$" swiss=�6�   #   PBHeight$# 67��6�   $��16��6�   $   	TextColor$$ 33554432 6
  %   TextSize$% -8��6  &   Weight$	& 400��6-  6<  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��
cb_setzoom��5      '   TabOrder$' 30��60   (   Text$( 	Set _Zoom��6>   )   X$
) 1294��6O   *   Y$
* 1276��6X   +   FaceName$+ MS Sans Serif��6a   ,   	FontPitch$, variable=�6z   -   PBFontFamily$- swiss=�6�   .   PBHeight$. 92��6�   $��22��6�   /   PBWidth$	/ 352��6�   $��76��6�   0   TextSize$0 -8��6�   1   Weight$	1 400��6�   6�     5   
   -   5        $��cb_close��5      2   Cancel2 . $' 40��6<   $( Close��6J   $
) 1669��6W   $
* 1276��6`   $+ MS Sans Serif��6i   $, variable=�6�   $- swiss=�6�   $. 92��6�   $��22��6�   $	/ 352��6�   $��76��6�   $0 -8��6�   $	1 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5	   
   -   5        $
��dw_1��5	      3   
DataObject$3 d_customerlist��6'   4   PBHScrollBar4 . 5   PBHeight$	5 960��6W   $	��239��6f   6   PBWidth$
6 1989��6s   $	��434��6�   7   TabOrder$7 0��6�   8   X$8 32��6�   9   Y$	9 272��6�   :   BorderStyle$: stylelowered 6�   ;   
LiveScroll; . <   PBVScrollBar< . 6�     5
   
   -   5        $��cbx_1��5
      =   
BringToTop= . $	 366��68   $��79��6F   $ 20��6Q   $ _Show Ruler��6_   $	 608��6r   $	 116��6z   $ 80263581 6�   $ stylelowered 6�   $  MS Sans Serif��6�   $! variable=�6�   $" swiss=�6�   $# 67��6�   $��16��6  $$ 33554432 6  $% -8��6$  $	& 400��62  6A  5      5      