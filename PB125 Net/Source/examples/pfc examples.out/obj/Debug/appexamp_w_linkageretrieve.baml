   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_linkageretrieve   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1496��6     PBTitle$- 'PFC Example - Basic Retrieval Arguments��6     PBWidth$
 1650��6M     	Resizable .     TitleBar .    ToolbarVisible .     X$	 457��6�     Y$	 148��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0	   ControlMenu	 . 
   MaxBox
 .    MinBox . .��5      �� .+�5   
   .   (Sybase.PowerBuilder.WPF.Controls.Picture  -   5        $	��p_1��5         OriginalSize .    PBHeight$ 64��67   $��15��6E      PBWidth$ 73��6Q   $��15��6^      PictureName$ 
rowind.bmp��6i      X$
 2121��6�      Y$	 360��6�      FocusRectangle .  6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_lineitem��5         
DataObject$ d_lineitems��6.      
LiveScroll .     PBHeight$	 420��6Z   $	��104��6i      PBTag$ linetag��6v      PBWidth$
 1573��6�   $	��343��6�      TabOrder$ 30��6�      X$ 32��6�      Y$	 852��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      PBVScrollBar . 6�     5   
   -   5        $��dw_sales��5      $ d_salesforcustomers��6+    .  $	 424��6_   $	��105��6n   $ salestag��6{   $
 1573��6�   $	��343��6�   $ 20��6�   $ 32��6�   $	 408��6�   $ stylelowered 6�    . 6�     5   
   -   5        $��dw_cust��5      $ d_customerdetail��6*    .  $	 364��6[   $��90��6j   $ custtag��6v   $
 1573��6�   $	��343��6�   $ 10��6�   $ 32��6�   $ 28��6�   $ stylelowered 6�    . 6�   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5         Cancel .    PBHeight$ 80��6<   $��19��6J      PBWidth$	 311��6V   $��67��6d       TabOrder$  40��6o   !   Text$! Close��6}   "   X$
" 1298��6�   #   Y$
# 1308��6�   $   FaceName$$ MS Sans Serif��6�   %   	FontPitch$% variable=�6�   &   PBFontFamily$& swiss=�6�   '   TextSize$' -8��6�   (   Weight$	( 400��6�   6�   5      5	      