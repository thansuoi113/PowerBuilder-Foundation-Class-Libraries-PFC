   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_refreshdddws   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1740��6     PBTitle$1 +PFC Example - Refresh Drop-down DataWindows��6     PBWidth$
 2665��6N     	Resizable .     TitleBar .    X$	 146��6     Y$ 80��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $
��cb_6��5         PBWidth$	 439��6*   $��95��68      TabOrder$ 10��6C      X$
 2149��6Q      Y$	 444��6Z      PBHeight$ 72��6b   $��17��6p      Text$ _SQL Spy��6|      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      TextSize$ -8��6�      Weight$	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $
��gb_1��5         PBHeight$	 568��6%   $	��141��64      PBWidth$
 2583��6A   $	��564��6P      TabOrder$ 0��6\      Text$ Edit a State Record��6i      X$ 37��6�      Y$ 32��6�      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�       PBFontFamily$  swiss=�6�   !   	TextColor$! 33554432 6  "   TextSize$" -8��6  #   Weight$	# 400��6(  .��5      �� 6   5        5   
   -   5        $
��gb_2��5      $	 832��6%   $	��207��64   $
 2583��6A   $	��564��6P   $ 0��6\   $I CView your changes in the city and state Drop-down DataWindows below��6i   $ 37��6�   $	 652��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6  $  swiss=�6!  $! 33554432 66  $" -8��6K  $	# 400��6Y  .��5      �� 6   5	      1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5
   
   -   5        $
��dw_1��5
      $   
DataObject$$ d_states��6'   %   PBHeight$	% 456��6=   $	��113��6L   &   PBWidth$
& 2002��6Y   $	��437��6h   '   TabOrder$' 30��6t   (   X$( 73��6�   )   Y$	) 108��6�   *   BorderStyle$* stylelowered 6�   +   
LiveScroll+ . ,   PBVScrollBar, . 6�     5   
   -   5        $
��dw_2��5      -   
BringToTop- . $$ d_custdddws��69   $	% 712��6R   $	��177��6a   $
& 2002��6n   $	��437��6}   $' 60��6�   $( 73��6�   $	) 732��6�   $* stylelowered 6�   + . , . 6�     5   
   -   5        $
��cb_1��5      .   
BringToTop. . $	 439��6<   $��95��6J   $ 40��6U   $ _Update��6c   $
 2149��6r   $	 116��6{   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $
��cb_2��5      . . $	 439��6<   $��95��6J   $ 50��6U   $ Refresh _DDDWs��6c   $
 2149��6y   $	 732��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $
��cb_3��5      . . /   Cancel/ . $	 439��6J   $��95��6X   $ 70��6c   $ Close��6q   $
 2176��6~   $
 1516��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6
    5   
   -	   5        $
��cb_5��5      . . $	 439��6<   $��95��6J   $ 20��6U   $ 	_Retrieve��6c   $
 2149��6t   $	 224��6}   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   5      5      