   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_resizedwsyntax   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1292��6
     PBTitle$/ )PFC Example - Weighted Resize of a Window��6     PBWidth$
 2555��6N     TitleBar .    X$ 5��6m     Y$ 4��6s     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6y  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   	Resizable
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $��gb_notes��5         PBHeight$ 36��6)   $��8��67      PBWidth$
 2464��6B   $	��538��6Q      TabOrder$ 2��6]      Text$  ��6j      X$ 32��6r      Y$	 560��6y      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6�      TextSize$ -8��6	     Weight$	 400��6  .��5      �� 6   5      1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5   
   -   5        $��	st_object��5         Text$ Object:��6,      X$ 32��6;      Y$ 36��6B      	BackColor$ 80263581 6I      Enabled .     FaceName$ MS Sans Serif��6n      FocusRectangle .      	FontPitch$  variable=�6�   !   PBFontFamily$! swiss=�6�   "   PBHeight$" 64��6�   $��15��6�   #   PBWidth$	# 344��6�   $��75��6�   $   	TextColor$$ 33554432 6�   %   TextSize$% -8��6  &   Weight$	& 400��6  6-  4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5   
   -   5        $��mle_describe��5      '   PBHeight$	' 180��62   $��44��6A   (   PBWidth$
( 2469��6M   $	��539��6\   )   TabOrder$) 20��6h   *   Text$-* '<DW Control Name>.Describe("DataWindow.��6v   +   X$+ 32��6�   ,   Y$	, 700��6�   -   AutoVScroll- . .   	BackColor$. 
1090519039 6�   /   BorderStyle$/ stylelowered 6�   0   FaceName$0 MS Sans Serif��6  1   	FontPitch$1 variable=�6  2   PBFontFamily$2 swiss=�62  3   	TextColor$3 33554432 6G  4   TextSize$4 -8��6\  5   Weight$	5 400��6j  6y  .   (Sybase.PowerBuilder.WPF.Controls.ListBox  5   
   -   5        $��lb_attributes��5      6   PBHeight$	6 372��6-   $��92��6<   7   PBWidth$
7 1211��6H   $	��264��6W   8   TabOrder$8 40��6c   9   X$
9 1280��6q   :   Y$	: 104��6z   ;   	BackColor$; 
1090519039 6�   <   BorderStyle$< stylelowered 6�   =   FaceName$= MS Sans Serif��6�   >   	FontPitch$> variable=�6�   ?   PBFontFamily$? swiss=�6�   @   	TextColor$@ 33554432 6�   A   TextSize$A -8��6  B   
VScrollBarB . C   Weight$	C 400��6,  .@�5	      2   ,Sybase.PowerBuilder.WPF.Controls.ListBoxItem  D   Item$D 
Attributes��6    64     5
      $
D Band��6    6.     5      $D Color��6    6/     5      $D Column.Count��6    66     5      $D Crosstab.Columns��6    6:     5      $D Crosstab.Rows��6    67     5      $D Crosstab.SourceNames��6    6>     5      $D Crosstab.StaticMode��6    6=   5      =	   7Sybase.PowerBuilder.WPF.Controls.DropDownPictureListBox	  5   
   -   5        $��ddplb_object��5   '   6
   0Sybase.PowerBuilder.WPF.Controls.DropDownListBoxE 
  PBWidth$	E 969��6;   $	��211��6I   F 	  PictureName$F DataWindow5!��6U   G 
  TabOrder$G 30��6p   H 
  X$H 32��6~   I 
  Y$	I 104��6�   J 
  BorderStyle$J stylelowered 6�   K 
  FaceName$K MS Sans Serif��6�   L 
  	FontPitch$L variable=�6�   M 
  PBFontFamily$M swiss=�6�   N 
  PBHeight$	N 248��6�   $��27��6�   O 	  PictureMaskColor$O 	553648127 6  P 
  	TextColor$P 33554432 6#  Q 
  TextSize$Q -8��68  R 
  
VScrollBarR . S 
  Weight$	S 400��6X  .@�5      A   ;Sybase.PowerBuilder.WPF.Controls.DropDownPictureListBoxItem  :   4Sybase.PowerBuilder.WPF.Controls.DropDownListBoxItemT   Item$T 
DataWindow��6/   U   PictureIndex$U 1��6A   6T   5        5   
   -   5        $��mle_dotnotation��5      V   
BringToTopV . $	' 180��6G   $��44��6V   $
( 2469��6b   $	��539��6q   $) 10��6}   $** $<DW Control Name>.Object.DataWindow.��6�   $+ 32��6�   $	, 976��6�   - . $. 
1090519039 6�   $/ stylelowered 6�   $0 MS Sans Serif��6  $1 variable=�6*  $2 swiss=�6?  $3 33554432 6T  $4 -8��6i  $	5 400��6w  6�    5   
   -   5        $��st_describe��5      W   
BringToTopW . $	# 416��6@   $��90��6N   $ Describe Function:��6Y   $ 32��6s   $	 632��6z   $ 80263581 6�    .  $ MS Sans Serif��6�    .  $  variable=�6�   $! swiss=�6�   $" 64��6  $��15��6  $$ 33554432 6  $% -8��60  $	& 400��6>  6M    5   
   -   5        $��st_dotnotation��5      W . $ Dot Notation:��6C   $ 32��6X   $	 912��6_   $ 80263581 6g    .  $ MS Sans Serif��6�    .  $  variable=�6�   $! swiss=�6�   $" 64��6�   $��15��6�   $	# 344��6   $��75��6  $$ 33554432 6  $% -8��6.  $	& 400��6<  6K    5   
   -	   5        $��st_note��5      W . $ Notes:��6<   $ 32��6J   $	 504��6Q   $ 80263581 6Y    .  $ MS Sans Serif��6~    .  $  variable=�6�   $! swiss=�6�   $" 64��6�   $��15��6�   $	# 344��6�   $��75��6   $$ 33554432 6  $% -8��6   $	& 400��6.  6=    5   
   -
   5        $��st_attributes��5      W . $ Attributes:��6B   $
 1280��6U   $ 36��6^   $ 80263581 6e    .  $ MS Sans Serif��6�    .  $  variable=�6�   $! swiss=�6�   $" 64��6�   $��15��6�   $	# 344��6�   $��75��6  $$ 33554432 6  $% -8��6,  $	& 400��6:  6I  5      5      