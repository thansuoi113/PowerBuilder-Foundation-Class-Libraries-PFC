   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_rowselection   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  77571519 6  ���	#fff0f0f0   PBHeight$
 1404��64     PBTitle$) #PFC Example - Row Selection Service��6D     PBWidth$
 2885��6r     	Resizable .     TitleBar .    X$ 0��6�     Y$ 4��6�     ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $��	rb_single��5         	BackColor$ 82889382 6-      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6B      FaceName$ MS Sans Serif��6]      	FontPitch$ variable=�6v      	PBChecked .    PBFontFamily$ swiss=�6�      PBHeight$ 67��6�   $��16��6�      PBWidth$	 417��6�   $��91��6�      TabOrder$ 20��6�      Text$ _Single Select��6�      	TextColor$ 41943040 6     TextSize$ -8��6     Weight$	 400��6+     X$
 2062��68     Y$	 188��6A  6K  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��	cb_invert��5         TabOrder$ 50��6/      Text$ _Invert��6=      X$
 2071��6L      Y$
 1164��6U      FaceName$ MS Sans Serif��6^      	FontPitch$ variable=�6w       PBFontFamily$  swiss=�6�   !   PBHeight$! 92��6�   $��22��6�   "   PBWidth$	" 352��6�   $��76��6�   #   TextSize$# -8��6�   $   Weight$	$ 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $
��st_3��5      %   	BackColor$% 82889382 6'   &   PBHeight$	& 160��6<   $��39��6K   '   PBWidth$	' 727��6W   $	��158��6e   (   Text$J( DSelect/Highlight the clicked row and do not deselect any other rows.��6q   )   	TextColor$) 41943040 6�   *   X$
* 2062��6�   +   Y$	+ 364��6�   ,   Enabled, .  -   FaceName$- MS Sans Serif��6�   .   FocusRectangle. .  /   	FontPitch$/ variable=�6#  0   PBFontFamily$0 swiss=�68  1   TextSize$1 -8��6M  2   Weight$	2 400��6[  6j  1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      3   
DataObject$3 d_customerlistreadonly��6'   4   PBHScrollBar4 . 5   PBHeight$
5 1228��6_   $	��306��6o   6   PBWidth$
6 1984��6|   $	��433��6�   7   TabOrder$7 10��6�   8   X$8 37��6�   9   Y$9 28��6�   :   BorderStyle$: stylelowered 6�   ;   
LiveScroll; . <   PBVScrollBar< . 6�     5   
   -   5        $
��st_2��5      $% 82889382 6'   $	& 172��6<   $��42��6K   $	' 727��6W   $	��158��6e   $f( `Extended supports Shift/Click, Cntl/Click, and Shift/Cntl/Click  "File Manager"-style selection.��6q   $) 41943040 6�   $
* 2062��6�   $	+ 716��6  , .  $- MS Sans Serif��6  . .  $/ variable=�6I  $0 swiss=�6^  $1 -8��6s  $	2 400��6�  6�    5   
   -   5        $
��st_1��5      $% 82889382 6'   $	& 132��6<   $��32��6K   $	' 727��6W   $	��158��6e   $C( =Select/Highlight the clicked row and deselect all other rows.��6q   $) 33554687 6�   $
* 2062��6�   $+ 28��6�   , .  $- MS Sans Serif��6�   . .  $/ variable=�6  $0 swiss=�60  $1 -8��6E  $	2 400��6S  6b    5	   
   -   5        $��cb_close��5	      =   
BringToTop= . >   Cancel> . $ 60��6N   $ Close��6\   $
 2446��6i   $
 1164��6r   $ MS Sans Serif��6{   $ variable=�6�   $  swiss=�6�   $! 92��6�   $��22��6�   $	" 352��6�   $��76��6�   $# -8��6�   $	$ 400��6�   6    5
   
   -   5        $��rb_multiselect��5
      $ 82889382 62   $ stylelowered 6G   ?   
BringToTop? . $ MS Sans Serif��6t   $ variable=�6�   $ swiss=�6�   $ 67��6�   $��16��6�   $	 417��6�   $��91��6�   $ 30��6�   $ _Multi-Select��6�   $ 41943040 6  $ -8��6"  $	 400��60  $
 2062��6=  $	 536��6F  6P    5   
   -	   5        $��rb_extended��5      $ 82889382 6/   $ stylelowered 6D   ? . $ MS Sans Serif��6q   $ variable=�6�   $ swiss=�6�   $ 67��6�   $��16��6�   $	 485��6�   $	��105��6�   $ 40��6�   $ _Extended Select��6�   $ 41943040 6  $ -8��6#  $	 400��61  $
 2062��6>  $	 892��6G  6Q  5      5      