   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_linkcascadekeys   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1544��6     PBTitle$. (PFC Example - Filter with Cascading Keys��6     PBWidth$
 1687��6N     	Resizable .     X$	 329��6o     Y$	 100��6w     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   TitleBar
 . .��5      �� .+�5   
   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  -   5        $��dw_lineitem��5         
DataObject$ d_lineitemscascadekey��6.      PBHeight$	 368��6Q   $��91��6`      PBTag$ 	lineitems��6l      PBWidth$
 1586��6~   $	��346��6�      TabOrder$ 40��6�      X$ 37��6�      Y$	 932��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      
LiveScroll .    PBVScrollBar . 6�     5   
   -   5        $��dw_sales��5      $# d_salesforcustomerscascadekey��6+   $	 368��6V   $��91��6e   $ sales��6q   $
 1586��6   $	��346��6�   $ 30��6�   $ 37��6�   $	 532��6�   $ stylelowered 6�    .  . 6�     5   
   -   5        $��dw_cust��5      $ d_customercascadekey��6*      PBHScrollBar . $	 344��6`   $��85��6o   $ 	customers��6{   $
 1586��6�   $	��346��6�   $ 10��6�   $ 37��6�   $	 164��6�   $ stylelowered 6�    .  . 6  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5         Cancel .    PBHeight$ 80��6<   $��19��6J      PBWidth$	 320��6V   $��69��6d      TabOrder$ 60��6o      Text$ Close��6}      X$
 1307��6�      Y$
 1332��6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�       TextSize$  -8��6�   !   Weight$	! 400��6�   6�     5   
   -   5        $��cb_retrieve��5      $ 80��61   $��19��6?   $	 320��6K   $��69��6Y   $ 50��6d   $ 	_Retrieve��6r   $	 960��6�   $
 1332��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $  -8��6�   $	! 400��6�   6�   .   (Sybase.PowerBuilder.WPF.Controls.Picture  5   
   -   5        $	��p_1��5      "   
BringToTop" . #   OriginalSize# . $   PBHeight$$ 64��6I   $��15��6W   %   PBWidth$% 73��6c   $��15��6p   &   PictureName$& 
rowind.bmp��6{   '   X$
' 2062��6�   (   Y$	( 292��6�   )   FocusRectangle) .  6�   4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5	   
   -   5        $��mle_note��5	      *   	BackColor$* 80263328 6.   +   Border+ .  ,   BorderStyle$, stylebox 6R   -   
BringToTop- . .   PBHeight$	. 140��6{   $��34��6�   /   PBWidth$
/ 1527��6�   $	��333��6�   0   TabOrder$0 20��6�   1   Text$\1 VThe example uses   inv_linkage.of_SetSyncOnKeyChange(true).     Key fields are bolded.��6�   2   X$2 37��6  3   Y$3 16��6$  4   AutoVScroll4 . 5   FaceName$5 MS Sans Serif��6>  6   	FontPitch$6 variable=�6W  7   PBFontFamily$7 swiss=�6l  8   	TextColor$8 33554432 6�  9   TextSize$9 -8��6�  :   Weight$	: 400��6�  6�  5
      5      