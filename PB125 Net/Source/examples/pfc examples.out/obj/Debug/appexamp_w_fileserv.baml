   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   
w_fileserv   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1916��6     PBTitle$) #PFC Example - File Services Example��6     PBWidth$
 2482��6B     TitleBar .    X$ 5��6a     Y$ 4��6g     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6m  ���	#fff0f0f0   ControlMenu .    MaxBox . 	   MinBox	 . 
   	Resizable
 . .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��cb_list��5         PBWidth$	 361��6-   $��78��6;      TabOrder$ 60��6F      Text$
 List��6T      X$
 2030��6`      Y$	 544��6i      FaceName$ MS Sans Serif��6q      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      PBHeight$ 92��6�   $��22��6�      TextSize$ -8��6�      Weight$	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $��
dw_dirlist��5         
DataObject$ 	d_dirlist��6-      PBHeight$
 1188��6D   $	��296��6T      PBWidth$
 1920��6a   $	��419��6p      TabOrder$ 50��6|      X$ 59��6�      Y$	 540��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      
LiveScroll .    PBVScrollBar . 6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_sort��5         	BackColor$ 79219928 6(       PBHeight$	  148��6=   $��36��6L   !   PBWidth$
! 1435��6X   $	��313��6g   "   TabOrder$" 40��6s   #   Text$
# Sort��6�   $   	TextColor$$ 41943040 6�   %   X$	% 475��6�   &   Y$	& 364��6�   '   BorderStyle$' stylelowered 6�   (   FaceName$( MS Sans Serif��6�   )   	FontPitch$) variable=�6�   *   PBFontFamily$* swiss=�6�   +   TextSize$+ -8��6  ,   Weight$	, 400��6  .��5      �� .+�5      2   ,Sybase.PowerBuilder.WPF.Controls.RadioButton  -   5        $��rb_filename��5   $   -   	BackColor$- 79219928 67   .   BorderStyle$. stylelowered 6L   /   
BringToTop/ . 0   FaceName$0 MS Sans Serif��6y   1   	FontPitch$1 variable=�6�   2   	PBChecked2 . 3   PBFontFamily$3 swiss=�6�   4   PBHeight$4 67��6�   $��16��6�   5   PBWidth$	5 315��6�   $��68��6�   6   Text$6 	File Name��6   7   	TextColor$7 41943040 6  8   TextSize$8 -8��6&  9   Weight$	9 400��64  :   X$: 83��6A  ;   Y$; 9��6H  6P    5      -   5        $��
rb_fileext��5   $   $- 79219928 66   $. stylelowered 6K   / . $0 MS Sans Serif��6x   $1 variable=�6�   $3 swiss=�6�   $4 67��6�   $��16��6�   $	5 315��6�   $��68��6�   $6 	File Ext.��6�   $7 41943040 6�   $8 -8��6  $	9 400��6"  $	: 430��6/  $; 9��67  6?    5	      -   5        $��rb_datetime��5	   $   $- 79219928 67   $. stylelowered 6L   / . $0 MS Sans Serif��6y   $1 variable=�6�   $3 swiss=�6�   $4 67��6�   $��16��6�   $	5 315��6�   $��68��6�   $6 	Date/Time��6�   $7 41943040 6   $8 -8��6  $	9 400��6#  $	: 773��60  $; 9��68  6@    5
      -   5        $��rb_size��5
   $   $- 79219928 63   $. stylelowered 6H   / . $0 MS Sans Serif��6u   $1 variable=�6�   $3 swiss=�6�   $4 67��6�   $��16��6�   $	5 174��6�   $��37��6�   $
6 Size��6�   $7 41943040 6�   $8 -8��6  $	9 400��6  $
: 1120��6'  $; 9��60  68  5      5      5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_dir��5      <   	BackColor$< 
1080593568 6.   =   PBHeight$= 80��6E   $��19��6S   >   PBWidth$	> 878��6_   $	��191��6m   ?   TabOrder$? 10��6y   @   	TextColor$@ 41943040 6�   A   X$	A 475��6�   B   Y$B 56��6�   C   AutoHScrollC .  D   BorderStyle$D stylelowered 6�   E   FaceName$E MS Sans Serif��6�   F   	FontPitch$F variable=�6�   G   PBFontFamily$G swiss=�6  H   TextSize$H -8��6  I   Weight$	I 400��6+  6:  1	   +Sybase.PowerBuilder.WPF.Controls.StaticText	  5   
   -	   5        $��st_dir��5      J 	  	BackColor$J 79219928 6)   K 	  PBWidth$	K 402��6>   $��87��6L   L 	  Text$L Current Directory:��6W   M 	  	TextColor$M 41943040 6q   N 	  X$N 64��6�   O 	  Y$O 56��6�   P 	  EnabledP .  Q 	  FaceName$Q MS Sans Serif��6�   R 	  FocusRectangleR .  S 	  	FontPitch$S variable=�6�   T 	  PBFontFamily$T swiss=�6�   U 	  PBHeight$U 64��6�   $��15��6  V 	  TextSize$V -8��6  W 	  Weight$	W 400��6&  65  	  5   
   -
   5        $��st_filespec��5      X 	  	Alignment$X right=�6.   $J 79219928 6@   Y 	  
BringToTopY . $	K 238��6g   $��51��6u   $L 
File Spec:��6�   $M 41943040 6�   $	N 224��6�   $	O 152��6�   P .  $Q MS Sans Serif��6�   R .  $S variable=�6�   $T swiss=�6  $U 64��6!  $��15��6/  $V -8��6;  $	W 400��6I  6X  	  5   
   -   5        $��st_filetype��5      $X right=�6.   $J 79219928 6@   Y . $	K 151��6g   $��32��6u   $L Type:��6�   $M 41943040 6�   $	N 315��6�   $	O 248��6�   P .  $Q MS Sans Serif��6�   R .  $S variable=�6�   $T swiss=�6  $U 64��6  $��15��6*  $V -8��66  $	W 400��6D  6S    5   
   -   5        $��sle_filespec��5      $< 
1080593568 63   Z   
BringToTopZ . $= 80��6\   $��19��6j   $? 20��6v   $@ 41943040 6�   $	A 475��6�   $	B 152��6�   C .  $D stylelowered 6�   $E MS Sans Serif��6�   $F variable=�6�   $G swiss=�6  $	> 453��6  $��98��6)  $H -8��64  $	I 400��6B  6Q    5   
   -   5        $��sle_type��5      $< 
1080593568 6/   Z . $= 80��6X   $��19��6f   $	> 270��6r   $��58��6�   $? 30��6�   $@ 41943040 6�   $	A 475��6�   $	B 248��6�   C .  $D stylelowered 6�   $E MS Sans Serif��6�   $F variable=�6  $G swiss=�6  $H -8��60  $	I 400��6>  6M    5   
   -   5        $��cb_driveinfo��5      [   
BringToTop[ . $	 361��6D   $��78��6R   $ 70��6]   $ 
Drive Info��6k   $
 2030��6}   $	 652��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��cb_createdir��5      [ . $	 361��6D   $��78��6R   $ 80��6]   $ Create Dir.��6k   $
 2030��6~   $	 760��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6	    5   
   -   5        $��cb_removedir��5      [ . $	 361��6D   $��78��6R   $ 90��6]   $ Remove Dir.��6k   $
 2030��6~   $	 868��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6	    5   
   -   5        $��cb_deletetree��5      [ . $	 361��6E   $��78��6S   $	 100��6^   $ Delete Tree��6m   $
 2030��6�   $	 980��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��	cb_rename��5      [ . $	 361��6A   $��78��6O   $	 110��6Z   $ Rename��6i   $
 2030��6w   $
 1088��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��cb_copyfile��5      [ . $	 361��6C   $��78��6Q   $	 120��6\   $ 	Copy File��6k   $
 2030��6|   $
 1196��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��cb_deletefile��5      [ . $	 361��6E   $��78��6S   $	 130��6^   $ Delete File��6m   $
 2030��6�   $
 1304��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��cb_datetime��5      [ . $	 361��6C   $��78��6Q   $	 140��6\   $ Set Date/Time��6k   $
 2030��6�   $
 1412��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6    5   
   -   5        $��	cb_attrib��5      [ . $	 361��6A   $��78��6O   $	 150��6Z   $ Set Attribute��6i   $
 2030��6~   $
 1524��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6
    5   
   -   5        $��cb_close��5      [ . \   Default\ . $	 361��6O   $��78��6]   $	 160��6h   $ Close��6w   $
 2030��6�   $
 1632��6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6  6  5      5      