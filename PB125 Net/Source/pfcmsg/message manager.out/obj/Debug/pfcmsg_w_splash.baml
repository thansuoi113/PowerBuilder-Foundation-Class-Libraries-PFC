   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �   
 pfcmsg   w_splash   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1224��6     PBWidth$
 2208��6     X$	 416��6!     Y$	 464��6)     Border .     ControlMenu .     Enabled .     MaxBox .     MinBox .  	   	Resizable	 .  
   TitleBar
 .     
WindowType$ popup=�6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0.��5      �� .+�5   
   +   %Sybase.PowerBuilder.WPF.Controls.Line  -   5        $
��ln_1��5         BeginY$ 4��6!      EndX$
 2359��6,      EndY$ 4��68   1   +Sybase.PowerBuilder.WPF.Controls.DrawObject   	LineColor$ 16777215 6A      LineThickness$ 4��6V   6j     5   
   -   5        $
��ln_2��5      $	 908��6!   $
 2354��6.   $	 908��6:   $ 8421504 6E   $ 4��6Y   6m     5   
   -   5        $
��ln_3��5         BeginX$
 2139��6!   $
 2139��6/   $
 1096��6;   $ 8421504 6G   $ 4��6[   6o     5   
   -   5        $
��ln_4��5      $
 1096��6!   $ 16777215 6-   $ 4��6B   $ 0��6T   6_   .   (Sybase.PowerBuilder.WPF.Controls.Picture  5   
   -   5        $��p_powerbuilder��5         PBHeight$
 1224��6.   $	��305��6>      PBWidth$
 2213��6K   $	��483��6Z      PictureName$ 
splash.bmp��6f      X$ 0��6      Y$ 0��6�      FocusRectangle .  6�     5   
   -   5        $��p_splash��5         Visible .     OriginalSize . $ 87��6L   $ 84��6S    .  $	 144��6q   $��35��6�   $	 160��6�   $��34��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5	   
   -   5        $��gb_allaround��5	         Visible .     	BackColor$ 79741120 6=      PBHeight$	 836��6R   $	��208��6a      PBWidth$
 2048��6n   $	��447��6}      TabOrder$ 0��6�       Text$   ��6�   !   X$! 46��6�   "   Y$" 20��6�   #   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$# stylelowered 6�   $   FaceName$$ MS Sans Serif��6�   %   	FontPitch$% variable=�6�   &   PBFontFamily$& swiss=�6�   '   	TextColor$' 33554432 6
  (   TextSize$( -8��6  )   Weight$	) 400��6-  .��5
      �� 6   5      1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $��st_application��5      *   X$* 27��61   +   Y$
+ 1236��68   ,   	BackColor$, 79741120 6A   -   PBHeight$	- 128��6V   $��31��6e   .   PBWidth$
. 1472��6q   $	��321��6�   /   Text$/ Application name...��6�   0   TextSize$	0 -19��6�   1   Weight$	1 700��6�   2   Enabled2 .  3   FaceName$3 MS Sans Serif��6�   4   FocusRectangle4 .  5   	FontPitch$5 variable=�6  6   PBFontFamily$6 swiss=�6  7   	TextColor$7 33554432 6-  6D    5   
   -	   5        $��
st_version��5      8   Visible8 .  $, 79741120 6=   $- 80��6R   $��19��6`   $
. 1472��6l   $	��321��6{   $/ version message...��6�   $	* 603��6�   $	+ 416��6�   2 .  $3 MS Sans Serif��6�   4 .  $5 variable=�6�   $6 swiss=�6  $7 33554432 6  $0 -8��60  $	1 400��6>  6M    5   
   -
   5        $��st_copyright��5      8 .  9   	Alignment$9 right=�6?   $, 79741120 6Q   $- 72��6f   $��17��6t   $
. 1952��6�   $	��426��6�   $/ Copyright message...��6�   $0 -6��6�   $	* 114��6�   $	+ 776��6�   2 .  $3 MS Sans Serif��6�   4 .  $5 variable=�6  $6 swiss=�6*  $7 33554432 6?  $	1 400��6T  6c  5      5      