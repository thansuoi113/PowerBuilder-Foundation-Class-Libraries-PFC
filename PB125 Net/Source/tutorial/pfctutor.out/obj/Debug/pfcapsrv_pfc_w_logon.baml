   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfctutor   pfc_w_logon   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80263328 6  ���	#fff0f0f0   PBHeight$	 520��61     PBTitle$ Logon��6@     PBWidth$
 2249��6P     X$	 704��6_     Y$	 516��6g     MaxBox .     MinBox .     	Resizable .  	   
WindowType$	 response=�6�  
   ControlMenu
 .    TitleBar . .��5      �� .+�5   
   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  -   5        $
��st_3��5         	Alignment$ right=�6'      PBHeight$ 72��69   $��17��6G      PBWidth$	 571��6S   $	��124��6a      Text$ 	Password:��6m      X$ 82��6~      Y$	 308��6�      	BackColor$ 80263581 6�      Enabled .     FaceName$ MS Sans Serif��6�      FocusRectangle .     	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6     TextSize$ -8��6!     Weight$	 400��6/  6>    5   
   -   5        $
��st_2��5      $ right=�6'   $ 72��69   $��17��6G   $	 571��6S   $	��124��6a   $ User ID:��6m   $ 82��6}   $	 208��6�   $ 80263581 6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6�   $ 33554432 6  $ -8��6   $	 400��6.  6=  5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_password��5         AutoHScroll .    PBHeight$ 76��6F   $��18��6T      PBWidth$
 1088��6`   $	��237��6o      Password .    TabOrder$ 20��6�       X$	  681��6�   !   Y$	! 304��6�   "   	BackColor$" 
1090519039 6�   #   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$# stylelowered 6�   $   FaceName$$ MS Sans Serif��6�   %   	FontPitch$% variable=�6�   &   PBFontFamily$& swiss=�6	  '   	TextColor$' 33554432 6  (   TextSize$( -8��63  )   Weight$	) 400��6A  6P    5   
   -   5        $��
sle_userid��5       . $ 76��6D   $��18��6R   $
 1088��6^   $	��237��6m   $ 10��6y   $	  681��6�   $	! 200��6�   $" 
1090519039 6�   $# stylelowered 6�   $$ MS Sans Serif��6�   $% variable=�6�   $& swiss=�6�   $' 33554432 6  $( -8��6!  $	) 400��6/  6>  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��	cb_cancel��5      *   Cancel* . +   TabOrder$+ 40��6=   ,   Text$, Cancel��6K   -   X$
- 1842��6Y   .   Y$	. 140��6b   /   FaceName$/ MS Sans Serif��6j   0   	FontPitch$0 variable=�6�   1   PBFontFamily$1 swiss=�6�   2   PBHeight$2 92��6�   $��22��6�   3   PBWidth$	3 352��6�   $��76��6�   4   TextSize$4 -8��6�   5   Weight$	5 400��6�   6�     5   
   -   5        $��cb_ok��5      6   Default6 . $+ 30��6:   $, OK��6H   $
- 1842��6R   $. 28��6[   $/ MS Sans Serif��6b   $0 variable=�6{   $1 swiss=�6�   $2 92��6�   $��22��6�   $	3 352��6�   $��76��6�   $4 -8��6�   $	5 400��6�   6�     5	   
   -   5        $��st_help��5	      $ 79741120 6*   $	 120��6?   $��29��6N   $
 1522��6Z   $	��332��6i   $/ )Enter a User ID and password to log onto ��6u   $	 256��6�   $ 44��6�    .  $ MS Sans Serif��6�    .  $ variable=�6�   $ swiss=�6
  $ 33554432 6  $ -8��64  $	 400��6B  6Q  .   (Sybase.PowerBuilder.WPF.Controls.Picture  5
   
   -   5        $��p_logo��5
      7   OriginalSize7 . 8   X$8 37��6:   9   Y$9 44��6A   :   FocusRectangle: .  ;   PBHeight$	; 144��6_   $��35��6n   <   PBWidth$	< 160��6z   $��34��6�   6�   5      5      