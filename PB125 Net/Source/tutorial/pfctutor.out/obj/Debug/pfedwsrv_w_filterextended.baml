   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfctutor   w_filterextended   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6
  ���	#fff0f0f0   PBHeight$
 1652��66     PBTitle$ Filter��6F     PBWidth$
 2135��6W     X$	 768��6f     Y$	 404��6n     MaxBox .     MinBox .     	Resizable .  	   
WindowType$	 response=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��
cb_dlghelp��5         PBWidth$	 375��60   $��81��6>      TabOrder$ 60��6I      Text$ _Help��6W      X$
 1691��6d      Y$
 1444��6m      FaceName$ MS Sans Serif��6v      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $
��gb_1��5         PBHeight$	 368��6%   $��91��64      PBWidth$
 2039��6@   $	��445��6O      TabOrder$ 0��6[      Text$ _Filter expression��6h      X$ 27��6�      Y$ 16��6�      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�       	FontPitch$  variable=�6�   !   PBFontFamily$! swiss=�6�   "   	TextColor$" 33554432 6  #   TextSize$# -8��6  $   Weight$	$ 400��6&  .��5      �� 6   5        5   
   -   5        $
��gb_2��5      $	 992��6%   $	��247��64   $
 2039��6A   $	��445��6P   $ 0��6\   $ Build filter with��6i   $ 27��6�   $	 428��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $  variable=�6�   $! swiss=�6�   $" 33554432 6  $# -8��6  $	$ 400��6'  .��5      �� 6   5	      4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5
   
   -   5        $��
mle_filter��5
      %   Accelerator$	% 102��60   &   	BackColor$& 
1086381248 6B   '   HideSelection' .  (   PBHeight$	( 244��6o   $��60��6~   )   PBWidth$
) 1518��6�   $	��331��6�   *   TabOrder$* 10��6�   +   	TextColor$+ 33554687 6�   ,   X$, 82��6�   -   Y$- 96��6�   .   AutoVScroll. . /   BorderStyle$/ stylelowered 6�   0   FaceName$0 MS Sans Serif��6  1   	FontPitch$1 variable=�6  2   PBFontFamily$2 swiss=�62  3   TextSize$3 -8��6G  4   Weight$	4 400��6U  6d    5   
   -   5        $��	cb_verify��5      5   Cancel5 . $	 375��6=   $��81��6K   $ 20��6V   $ _Verify��6d   $
 1637��6s   $ 96��6|   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��	cb_cancel��5      5 . $	 375��6=   $��81��6K   $ 50��6V   $ Cancel��6d   $
 1303��6r   $
 1444��6{   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��cb_ok��5      6   Default6 . $	 375��6:   $��81��6H   $ 40��6S   $ OK��6a   $	 914��6k   $
 1444��6s   $ MS Sans Serif��6|   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   *   $Sybase.PowerBuilder.WPF.Controls.Tab  5   
   -   5        $��tab_1��5      7   	BackColor$7 79741120 6!   8   
BringToTop8 . 9   FaceName$9 MS Sans Serif��6H   :   	FontPitch$: variable=�6a   ;   PBFontFamily$; swiss=�6v   <   PBHeight$	< 884��6�   =   PBWidth$
= 1943��6�   >   RaggedRight> . ?   SelectedTab$? 1��6�   @   ShowPicture@ .  A   TabOrder$A 30��6�   B   TextSize$B -8��6�   C   Weight$	C 400��6�   D   X$D 64��6	  E   Y$	E 508��6  .@�5      .   (Sybase.PowerBuilder.WPF.Controls.TabPage  -	   5        $��tabpg_functions��5      F   	BackColor$F 79741120 63   G   PBHeight$	G 768��6H   H   PBWidth$
H 1906��6W   I   PictureMaskColor$I 	536870912 6f   J   TabBackColor$J 79741120 6�   K   TabTextColor$K 33554432 6�   L   Text$L 	Functions��6�   M   X$M 18��6�   N   Y$	N 100��6�   .��5      �� .+�5      1	   +Sybase.PowerBuilder.WPF.Controls.StaticText	  -
   5        $��	st_syntax��5   '   O 	  	BackColor$O 79741120 68   P 	  PBWidth$
P 1765��6M   $	��385��6\   Q 	  Weight$	Q 700��6h   R 	  X$R 46��6u   S 	  Y$	S 508��6|   T 	  EnabledT .  U 	  FaceName$U MS Sans Serif��6�   V 	  FocusRectangleV .  W 	  	FontPitch$W variable=�6�   X 	  PBFontFamily$X swiss=�6�   Y 	  PBHeight$Y 64��6�   $��15��6�   Z 	  Text$
Z none��6  [ 	  	TextColor$[ 33554432 6  \ 	  TextSize$\ -8��6)  69    5      -   5        $
��gb_3��5   %   $	 308��61   $��76��6@   $
 1847��6L   $	��403��6[   $ 2��6g   $ Syntax��6t   $ 18��6�   $	 448��6�   $ 80263581 6�   $ stylelowered 6�   $ MS Sans Serif��6�   $  variable=�6�   $! swiss=�6�   $" 33554432 6  $# -8��6  $	$ 400��6'  .��5      �� 6#   5      1
   +Sybase.PowerBuilder.WPF.Controls.DataWindow
  5      -   5        $��dw_function��5   '   ] 
  
DataObject$] d_dwfunction��6:   ^ 
  PBHeight$	^ 412��6T   $	��102��6c   _ 
  PBWidth$
_ 1152��6p   $	��251��6   ` 
  TabOrder$` 2��6�   a 
  X$	a 713��6�   b 
  Y$b 28��6�   c 
  BorderStyle$c stylelowered 6�   d 
  
LiveScrolld . e 
  PBVScrollBare . 6�   
  5      -   5        $��dw_functioncategory��5   '   $] d_dwfunctioncategory��6B   d .  $	^ 408��6w   $	��101��6�   e .  $	_ 677��6�   $	��147��6�   $` 2��6�   $a 18��6�   $b 28��6�   $c stylelowered 6�   6�   	  5      -   5        $��st_help��5   '   f 	  
BringToTopf . $	Y 156��6H   $��38��6W   $
P 1792��6c   $	��391��6r   $R 46��6~   $	S 584��6�   $O 80263581 6�   T .  $U MS Sans Serif��6�   V .  $W variable=�6�   $X swiss=�6�   $
Z none��6  $[ 33554432 6  $\ -8��6-  $	Q 400��6;  6J  5      5        5      -   5        $��tabpg_columns��5      $F 79741120 61   $	G 768��6F   $
H 1906��6U   $I 	536870912 6d   $J 79741120 6�   $K 33554432 6�   $L Columns��6�   $M 18��6�   $	N 100��6�   .��5      �� .+�5      
  -   5        $��
dw_columns��5   '   $] d_columnnames��69   $	^ 684��6T   $	��170��6c   $
_ 1838��6p   $	��401��6   $` 2��6�   $a 32��6�   $b 56��6�   $c stylelowered 6�   d . e . 6�   5      5        5      -   5        $��tabpg_operators��5      $F 79741120 63   $	G 768��6H   $
H 1906��6W   $I 	536870912 6f   $J 79741120 6�   $K 33554432 6�   $L 	Operators��6�   $M 18��6�   $	N 100��6�   .��5       �� .+�5!      .   (Sybase.PowerBuilder.WPF.Controls.ListBox  -   5        $
��lb_1��5!   $   g   PBHeight$	g 684��60   $	��170��6?   h   PBWidth$
h 1838��6L   $	��401��6[   i   TabOrder$i 2��6g   j   X$j 32��6t   k   Y$k 56��6{   l   	BackColor$l 
1090519039 6�   m   BorderStyle$m stylelowered 6�   n   FaceName$n MS Sans Serif��6�   o   	FontPitch$o variable=�6�   p   PBFontFamily$p swiss=�6�   q   	TextColor$q 33554432 6�   r   TextSize$r -8��6  s   
VScrollBars . t   Weight$	t 400��6,  .@�5"      2   ,Sybase.PowerBuilder.WPF.Controls.ListBoxItem  u   Item$u =��6,     5#      $u <��6,     5$      $u >��6,     5%      $u <=��6,     5&      $u >=��6,     5'      $	u and��6,     5(      $u or��6,     5)      $	u not��6,     5*      $u (��6,     5+      $u )��6,   5,      5-      5.        5/      -   5        $��tabpg_values��5/      $F 79741120 60   $	G 768��6E   $
H 1906��6T   $I 	536870912 6c   $J 79741120 6�   $K 33554432 6�   $L Values��6�   $M 18��6�   $	N 100��6�   .��50      �� .+�51      
  -   5        $��	dw_values��51   '   $	^ 684��68   $	��170��6G   $
_ 1838��6T   $	��401��6c   $` 2��6o   $a 32��6|   $b 56��6�   $c stylelowered 6�   d . e . 6�   52      53      54      55      56      