   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcsecurity_admin   w_sqlspy   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$
 1556��6.     PBTitle$ SQLSpy��6>     PBWidth$
 1998��6O     X$	 640��6^     Y$	 364��6f     ControlMenu .    MaxBox .    MinBox . 	   	Resizable	 . 
   TitleBar
 . .��5      �� .+�5   
   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  -   5        $��
st_history��5         PBWidth$	 343��6-   $��74��6;      Text$ st__history��6F      Visible .     X$ 23��6i      Y$	 136��6p      	BackColor$ 80263581 6x      Enabled .     FaceName$ MS Sans Serif��6�      FocusRectangle .     	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 64��6�   $��15��6     	TextColor$ 33554432 6     TextSize$ -8��6&     Weight$	 400��64  6C  /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_sqlhistory��5         PBHeight$
 1140��6.   $	��284��6>      PBWidth$
 1920��6K   $	��419��6Z      TabOrder$ 0��6f      Text$ SQL History��6s      X$ 14��6�      Y$	 136��6�       	BackColor$  80263581 6�   !   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$! stylelowered 6�   "   FaceName$" MS Sans Serif��6�   #   	FontPitch$# variable=�6�   $   PBFontFamily$$ swiss=�6�   %   	TextColor$% 33554432 6  &   TextSize$& -8��6  '   Weight$	' 400��6+  .��5      �� 6   5      4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5      (   Cancel( . )   PBWidth$	) 375��6<   $��81��6J   *   TabOrder$* 60��6U   +   Text$+ _Close��6c   ,   X$
, 1111��6q   -   Y$
- 1312��6z   .   FaceName$. MS Sans Serif��6�   /   	FontPitch$/ variable=�6�   0   PBFontFamily$0 swiss=�6�   1   PBHeight$1 92��6�   $��22��6�   2   TextSize$2 -8��6�   3   Weight$	3 400��6�   6�     5   
   -   5        $��
cb_dlghelp��5      $	) 375��60   $��81��6>   $* 70��6I   $+ _Help��6W   $
, 1499��6d   $
- 1312��6m   $. MS Sans Serif��6v   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�     5	   
   -   5        $��cb_clear��5	      $	) 375��6.   $��81��6<   $* 30��6G   $+ C_lear��6U   $	, 722��6c   $
- 1144��6k   $. MS Sans Serif��6t   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�   4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5
   
   -   5        $��mle_history��5
      4   DisplayOnly4 . 5   PBHeight$	5 904��6D   $	��225��6S   6   PBWidth$
6 1806��6`   $	��394��6o   7   TabOrder$7 20��6{   8   
VScrollBar8 . 9   X$9 69��6�   :   Y$	: 212��6�   ;   AutoVScroll; . <   	BackColor$< 
1090519039 6�   =   BorderStyle$= stylelowered 6�   >   FaceName$> MS Sans Serif��6�   ?   	FontPitch$? variable=�6  @   PBFontFamily$@ swiss=�6  A   	TextColor$A 33554432 62  B   TextSize$B -8��6G  C   Weight$	C 400��6U  6d  /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_batchmode��5      D   PBHeight$D 68��6.   $��16��6<   E   PBWidth$
E 1856��6H   $	��405��6W   F   TabOrder$F 10��6c   G   Text$7G 1_Inspect each SQL statement before it is executed��6q   H   X$H 73��6�   I   Y$I 36��6�   J   	BackColor$J 80263581 6�   K   BorderStyle$K stylelowered 6�   L   FaceName$L MS Sans Serif��6�   M   	FontPitch$M variable=�6  N   PBFontFamily$N swiss=�6  O   	TextColor$O 33554432 6+  P   TextSize$P -8��6@  Q   Weight$	Q 400��6N  6]    5   
   -   5        $��cb_save��5      $	) 375��6-   $��81��6;   $* 40��6F   $+ _Save��6T   $
, 1111��6a   $
- 1144��6j   $. MS Sans Serif��6s   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�     5   
   -	   5        $��cb_print��5      $	) 375��6.   $��81��6<   $* 50��6G   $+ _Print��6U   $
, 1499��6c   $
- 1144��6l   $. MS Sans Serif��6u   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�   5      5      