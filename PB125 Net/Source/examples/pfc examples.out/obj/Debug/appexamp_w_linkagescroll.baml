   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_linkagescroll   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1188��6	     PBTitle$# PFC Example - Basic Scrolling��6     PBWidth$
 2373��6A     	Resizable .     TitleBar .    X$	 233��6r     Y$	 248��6z     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��	cb_update��5         TabOrder$ 40��6/      Text$ _Update��6=      X$
 1979��6L      Y$	 148��6U      FaceName$ MS Sans Serif��6]      	FontPitch$ variable=�6v      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      PBWidth$	 352��6�   $��76��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��	dw_detail��5         
DataObject$ d_empfreeform��6,      PBHeight$	 732��6G   $	��182��6V      PBVScrollBar .     PBWidth$
 1906��6x   $	��416��6�      TabOrder$ 20��6�      X$ 32��6�      Y$	 348��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      
LiveScroll . 6�     5   
   -   5        $��dw_emp��5      $ 
d_empnames��6)   $	 300��6A   $��74��6P   $
 1906��6\   $	��416��6k   $ 10��6w   $ 32��6�   $ 28��6�   $ stylelowered 6�    .  . 6�     5   
   -   5        $��cb_close��5         Cancel . $ 50��6<   $ Close��6J   $
 1979��6W   $	 264��6`   $ MS Sans Serif��6h   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $	 352��6�   $��76��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��cb_retrieve��5      $ 30��61   $ 	_Retrieve��6?   $
 1979��6P   $ 28��6Y   $ MS Sans Serif��6`   $ variable=�6y   $ swiss=�6�   $ 92��6�   $��22��6�   $	 352��6�   $��76��6�   $ -8��6�   $	 400��6�   6�   .   (Sybase.PowerBuilder.WPF.Controls.Picture  5   
   -   5        $	��p_1��5          
BringToTop  . !   OriginalSize! . "   PBHeight$" 64��6I   $��15��6W   #   PBWidth$# 73��6c   $��15��6p   $   PictureName$$ 
rowind.bmp��6{   %   Visible% .  &   X$
& 1801��6�   '   Y$	' 412��6�   (   FocusRectangle( .  6�   5	      5
      