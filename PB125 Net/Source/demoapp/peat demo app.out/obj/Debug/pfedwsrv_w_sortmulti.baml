   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    peat   w_sortmulti   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$	 956��61     PBTitle$
 Sort��6@     PBWidth$
 2021��6O     MaxBox .     MinBox .     	Resizable .     
WindowType$ response=�6�     X$	 214��6�  	   Y$		 221��6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 375��60   $��81��6>      TabOrder$ 70��6I      Text$ _Help��6W      X$
 1582��6d      Y$	 724��6m      FaceName$ MS Sans Serif��6u      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_sort��5         	BackColor$ 82889382 6(      PBHeight$	 664��6=   $	��165��6L      PBWidth$
 1934��6Y   $	��422��6h      TabOrder$ 0��6t      Text$ Sort items by��6�      	TextColor$ 33554687 6�      X$ 23��6�      Y$ 20��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�       FaceName$  MS Sans Serif��6�   !   	FontPitch$! variable=�6�   "   PBFontFamily$" swiss=�6  #   TextSize$# -8��6  $   Weight$	$ 400��6%  .��5      �� 6   5        5   
   -   5        $��cb_ok��5      %   Default% . $	 375��6:   $��81��6H   $ 50��6S   $ OK��6a   $	 795��6k   $	 724��6s   $ MS Sans Serif��6{   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��	cb_insert��5      $	 375��6/   $��81��6=   $ 20��6H   $ _Insert��6V   $
 1504��6e   $	 112��6n   $ MS Sans Serif��6v   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5	   
   -   5        $��	cb_delete��5	      $	 375��6/   $��81��6=   $ 40��6H   $ _Delete��6V   $
 1504��6e   $	 344��6n   $ MS Sans Serif��6v   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5
   
   -   5        $��cb_add��5
      $	 375��6,   $��81��6:   $ 30��6E   $
 _Add��6S   $
 1504��6_   $	 228��6h   $ MS Sans Serif��6p   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_sort��5      &   Border& .  '   BorderStyle$' stylebox 69   (   
DataObject$( d_sortmulti��6P   )   PBHeight$	) 552��6i   $	��137��6x   *   PBWidth$
* 1413��6�   $	��308��6�   +   TabOrder$+ 10��6�   ,   X$, 73��6�   -   Y$	- 100��6�   .   
LiveScroll. . /   PBVScrollBar/ . 6�     5   
   -   5        $��	cb_cancel��5      0   
BringToTop0 . 1   Cancel1 . $	 375��6O   $��81��6]   $ 60��6h   $ Cancel��6v   $
 1189��6�   $	 724��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6   6  5      5      