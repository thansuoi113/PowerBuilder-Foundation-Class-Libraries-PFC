   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcsecurity_admin   w_pfcsecurity_infomgmt   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   MenuName$ m_pfcsecurity_info_mgmt��6<     PBHeight$
 1632��6_     PBTitle$ User/Object Management��6o     PBWidth$
 2926��6�     TitleBar .    X$ 37��6�     Y$	 212��6�     ControlMenu . 	   MaxBox	 . 
   MinBox
 .    	Resizable . .��5      �� .+�5   
   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  -   5        $��st_bar��5         PBHeight$
 1428��6)   $	��356��69      PBWidth$ 9��6F   $��1��6R      X$	 617��6\      Y$ 4��6d      	BackColor$ 8421504 6j      Enabled .    Text$  ��6�      FaceName$ MS Sans Serif��6�      FocusRectangle .     	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6�      TextSize$ -8��6     Weight$	 400��6  6!    5   
   -   5        $��st_users��5      $ 77956459 6+   $ 52��6@   $��12��6N   $	 169��6Z   $��36��6h   $ _Users :��6s   $ 33554432 6�   $	 663��6�   $ 20��6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6�   $ -8��6  $	 400��6  6.  =   7Sybase.PowerBuilder.WPF.Controls.DropDownPictureListBox  5   
   -   5        $��ddplb_users��5   '   6   0Sybase.PowerBuilder.WPF.Controls.DropDownListBox   Accelerator$	 117��6:      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6L      FaceName$ MS Sans Serif��6g      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$
 1076��6�       PBWidth$	  910��6�   !   PictureMaskColor$! 12632256 6�   "   Sorted" .  #   	TextColor$# 33554432 6�   $   TextSize$$ -8��6  %   
VScrollBar% . &   Weight$	& 400��6(  '   X$	' 823��65  (   Y$( 28��6=  6F  /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��
gb_display��5      )   	BackColor$) 77956459 6+   *   PBHeight$	* 132��6@   $��32��6O   +   PBWidth$	+ 631��6[   $	��137��6i   ,   TabOrder$, 30��6u   -   Text$- _Display Controls��6�   .   X$
. 1797��6�   /   Y$/ 0��6�   0   BorderStyle$0 stylelowered 6�   1   FaceName$1 MS Sans Serif��6�   2   	FontPitch$2 variable=�6�   3   PBFontFamily$3 swiss=�6�   4   	TextColor$4 33554432 6	  5   TextSize$5 -8��6  6   Weight$	6 400��6,  .��5      �� .+�5      2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $��rb_all��5   $   7   	BackColor$7 77956459 62   8   BorderStyle$8 stylelowered 6G   9   FaceName$9 MS Sans Serif��6b   :   	FontPitch$: variable=�6{   ;   PBFontFamily$; swiss=�6�   <   PBHeight$< 52��6�   $��12��6�   =   PBWidth$	= 169��6�   $��36��6�   >   Text$
> _All��6�   ?   	TextColor$? 33554432 6�   @   TextSize$@ -8��6�   A   Weight$	A 400��6  B   X$	B 429��6  C   Y$C 9��6  6$    5	      -   5        $��	rb_active��5	   $   $7 77956459 65   $8 stylelowered 6J   $9 MS Sans Serif��6e   $: variable=�6~   D   	PBCheckedD . $; swiss=�6�   $< 52��6�   $��12��6�   $	= 384��6�   $��83��6�   $> Active _Only��6�   $? 33554432 6   $@ -8��6  $	A 400��6#  $B 36��60  $C 9��67  6?  5
      5      1	   +Sybase.PowerBuilder.WPF.Controls.DataWindow	  5   
   -   5        $��dw_controls��5      E 	  
DataObject$E d_pfcsecurity_info_update��6.   F 	  PBHScrollBarF . G 	  PBHeight$
G 1268��6i   $	��316��6y   H 	  PBWidth$
H 2226��6�   $	��486��6�   I 	  TabOrder$I 20��6�   J 	  X$	J 626��6�   K 	  Y$	K 152��6�   L 	  BorderStyle$L stylelowered 6�   M 	  
LiveScrollM . N 	  PBVScrollBarN . 6  /
   )Sybase.PowerBuilder.WPF.Controls.TreeView
  5   
   -   5        $��tv_apps��5      O 
  	BackColor$O 
1090519039 6(   P 
  FontCharSet$
P ansi=�6?   Q 
  HideSelectionQ .  R 
  LinesAtRootR . S 
  PBHeight$
S 1428��6{   $	��356��6�   T 
  PBWidth$	T 613��6�   $	��133��6�   U 
  PictureMaskColor$U 12632256 6�   V 
  PictureName$>V 8Application5!,Application!,ArrangeTables5!,SelectObject!��6�   W 
  StatePictureHeight$W 16��6  X 
  StatePictureMaskColor$X 12632256 6-  Y 
  StatePictureWidth$Y 16��6N  Z 
  TabOrder$Z 10��6e  [ 
  X$[ 0��6s  \ 
  Y$\ 0��6y  ] 
  BorderStyle$] stylelowered 6  ^ 
  FaceName$^ MS Sans Serif��6�  _ 
  	FontPitch$_ variable=�6�  ` 
  PBFontFamily$` swiss=�6�  a 
  	TextColor$a 33554432 6�  b 
  TextSize$b -8��6�  c 
  Weight$	c 400��6   6  5      5      