   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_linkagefilter   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1392��6	     PBTitle$! PFC Example - Basic Filters��6     PBWidth$
 1659��6?     	Resizable .     X$	 329��6`     Y$	 100��6h     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6p  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   TitleBar
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��	cb_update��5         PBHeight$ 80��6/   $��19��6=      PBWidth$	 320��6I   $��69��6W      TabOrder$ 50��6b      Text$ _Update��6p      X$	 955��6      Y$
 1196��6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      TextSize$ -8��6�      Weight$	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_lineitem��5         
DataObject$ d_lineitemsall��6.      PBHeight$	 368��6J   $��91��6Y      PBTag$ 	lineitems��6e      PBWidth$
 1586��6w   $	��346��6�      TabOrder$ 30��6�      X$ 27��6�      Y$	 792��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      
LiveScroll .    PBVScrollBar . 6�     5   
   -   5        $��dw_sales��5      $ d_salesforcustomersall��6+   $	 368��6O   $��91��6^   $ sales��6j   $
 1586��6x   $	��346��6�   $ 20��6�   $ 27��6�   $	 392��6�   $ stylelowered 6�    .  . 6�     5   
   -   5        $��dw_cust��5      $ d_customerdetailupdatable��6*       PBHScrollBar  . $	 344��6e   $��85��6t   $ 	customers��6�   $
 1586��6�   $	��346��6�   $ 10��6�   $ 27��6�   $ 24��6�   $ stylelowered 6�    .  . 6    5   
   -   5        $��cb_close��5      !   Cancel! . $ 80��6<   $��19��6J   $	 320��6V   $��69��6d   $ 60��6o   $ Close��6}   $
 1298��6�   $
 1196��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��cb_retrieve��5      $ 80��61   $��19��6?   $	 320��6K   $��69��6Y   $ 40��6d   $ 	_Retrieve��6r   $	 613��6�   $
 1196��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ -8��6�   $	 400��6�   6�   .   (Sybase.PowerBuilder.WPF.Controls.Picture  5	   
   -   5        $	��p_1��5	      "   
BringToTop" . #   OriginalSize# . $   PBHeight$$ 64��6I   $��15��6W   %   PBWidth$% 73��6c   $��15��6p   &   PictureName$& 
rowind.bmp��6{   '   X$
' 2062��6�   (   Y$	( 292��6�   )   FocusRectangle) .  6�   5
      5      