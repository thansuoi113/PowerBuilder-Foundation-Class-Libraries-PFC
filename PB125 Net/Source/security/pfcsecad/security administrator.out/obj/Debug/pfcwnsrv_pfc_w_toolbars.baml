   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcsecurity_admin   pfc_w_toolbars   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$
 1380��64     PBTitle$ Customize Toolbars��6D     PBWidth$
 1664��6a     X$
 1193��6p     Y$	 380��6y     MaxBox .     MinBox .     	Resizable .  	   
WindowType$	 response=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 375��60   $��81��6>      TabOrder$ 80��6I      Text$ _Help��6W      X$
 1221��6d      Y$
 1160��6m      FaceName$ MS Sans Serif��6v      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_position��5         	BackColor$ 79741120 6,      FaceName$ MS Sans Serif��6A      	FontPitch$ variable=�6Z      PBFontFamily$ swiss=�6o      PBHeight$	 404��6�      PBWidth$
 1559��6�      TabOrder$ 20��6�      Text$ Position��6�      	TextColor$ 33554432 6�       TextSize$  -8��6�   !   Weight$	! 400��6�   "   X$" 37��6�   #   Y$	# 416��6�   .��5      �� .+�5      2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $��rb_floating��5   $   $   	BackColor$$ 80263581 67   %   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$% stylelowered 6L   &   FaceName$& MS Sans Serif��6g   '   	FontPitch$' variable=�6�   (   PBFontFamily$( swiss=�6�   )   PBHeight$) 68��6�   $��16��6�   *   PBWidth$
* 1358��6�   $	��296��6�   +   Text$+ 	_Floating��6�   ,   	TextColor$, 33554432 6�   -   TextSize$- -8��6  .   Weight$	. 400��6  /   X$/ 54��6   0   Y$	0 261��6'  61    5      -   5        $��rb_right��5   $   $$ 80263581 64   $% stylelowered 6I   $& MS Sans Serif��6d   $' variable=�6}   $( swiss=�6�   $) 68��6�   $��16��6�   $
* 1358��6�   $	��296��6�   $+ _Right��6�   $, 33554432 6�   $- -8��6�   $	. 400��6  $/ 54��6  $	0 197��6!  6+    5      -   5        $��rb_left��5   $   $$ 80263581 63   $% stylelowered 6H   $& MS Sans Serif��6c   $' variable=�6|   $( swiss=�6�   $) 68��6�   $��16��6�   $
* 1358��6�   $	��296��6�   $+ L_eft��6�   $, 33554432 6�   $- -8��6�   $	. 400��6  $/ 54��6  $	0 133��6  6)    5	      -   5        $��	rb_bottom��5	   $   $$ 80263581 65   $% stylelowered 6J   $& MS Sans Serif��6e   $' variable=�6~   $( swiss=�6�   $) 68��6�   $��16��6�   $
* 1358��6�   $	��296��6�   $+ _Bottom��6�   $, 33554432 6�   $- -8��6  $	. 400��6  $/ 54��6  $0 69��6#  6,    5
      -   5        $��rb_top��5
   $   $$ 80263581 62   $% stylelowered 6G   $& MS Sans Serif��6b   $' variable=�6{   $( swiss=�6�   $) 68��6�   $��16��6�   $
* 1358��6�   $	��296��6�   $
+ T_op��6�   $, 33554432 6�   $- -8��6�   $	. 400��6	  $/ 54��6  $0 5��6  6%  5      5      1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��dw_toolbars��5      1   
DataObject$1 
d_toolbars��6.   2   PBHeight$	2 312��6F   $��77��6U   3   PBWidth$
3 1559��6a   $	��340��6p   4   TabOrder$4 10��6|   5   X$5 37��6�   6   Y$6 84��6�   7   BorderStyle$7 stylelowered 6�   8   
LiveScroll8 . 9   PBVScrollBar9 . 6�     5   
   -	   5        $��gb_app��5      $ 79741120 6'   $ MS Sans Serif��6<   $ variable=�6U   $ swiss=�6j   $	 268��6   $
 1559��6�   $ Application settings��6�   $ 33554432 6�   $  -8��6�   $	! 400��6�   $" 37��6�   $	# 860��6�   .��5      �� 6   5        5   
   -
   5        $��cb_apply��5      :   Enabled: .  $	 375��6>   $��81��6L   $ 70��6W   $ _Apply��6e   $	 827��6s   $
 1160��6{   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_tips��5      ;   	BackColor$; 79741120 6)   <   PBHeight$< 76��6>   $��18��6L   =   PBWidth$
= 1358��6X   $	��296��6g   >   TabOrder$> 40��6s   ?   Text$? _Show Tooltips��6�   @   X$@ 91��6�   A   Y$
A 1016��6�   B   BorderStyle$B stylelowered 6�   C   FaceName$C MS Sans Serif��6�   D   	FontPitch$D variable=�6�   E   PBFontFamily$E swiss=�6�   F   	TextColor$F 33554432 6  G   TextSize$G -8��6  H   Weight$	H 400��6(  67    5   
   -   5        $��cbx_text��5      $; 79741120 6)   $< 76��6>   $��18��6L   $
= 1358��6X   $	��296��6g   $> 30��6s   $? _Large Buttons��6�   $@ 91��6�   $	A 936��6�   $B stylelowered 6�   $C MS Sans Serif��6�   $D variable=�6�   $E swiss=�6�   $F 33554432 6  $G -8��6  $	H 400��6'  66    5   
   -   5        $��	cb_cancel��5      I   CancelI . $	 375��6=   $��81��6K   $ 60��6V   $ Cancel��6d   $	 434��6r   $
 1160��6z   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��cb_ok��5      J   DefaultJ . $	 375��6:   $��81��6H   $ 50��6S   $ OK��6a   $ 41��6k   $
 1160��6r   $ MS Sans Serif��6{   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   1	   +Sybase.PowerBuilder.WPF.Controls.StaticText	  5   
   -   5        $��st_selecttoolbar��5      K 	  	BackColor$K 79741120 63   L 	  EnabledL . M 	  PBWidth$
M 1454��6W   $	��317��6f   N 	  Text$N 
_Toolbars:��6r   O 	  X$O 37��6�   P 	  Y$P 20��6�   Q 	  FaceName$Q MS Sans Serif��6�   R 	  FocusRectangleR .  S 	  	FontPitch$S variable=�6�   T 	  PBFontFamily$T swiss=�6�   U 	  PBHeight$U 64��6�   $��15��6�   V 	  	TextColor$V 33554432 6  W 	  TextSize$W -8��6  X 	  Weight$	X 400��6)  68  5      5      