   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_errormsgservice   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1780��6     PBTitle$) #PFC Example:  Error Service Example��6     PBWidth$
 2094��6I     	Resizable .     ToolbarAlignment$ alignatleft=�6j     X$	 443��6�     Y$ 8��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 .    TitleBar . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $��gb_sendmessage��5         	BackColor$ 79741120 6/      PBHeight$	 252��6D   $��62��6S      PBWidth$
 2011��6_   $	��439��6n      TabOrder$ 0��6z      Text$6 0View your message box and check the return code.��6�      	TextColor$ 0 6�      X$ 32��6�      Y$
 1276��6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6     PBFontFamily$ swiss=�6&     TextSize$ -8��6;     Weight$	 400��6I  .��5      �� 6   5        5   
   -   5        $��gb_createmessage��5      $ 79741120 61   $
 1200��6F   $	��299��6V   $
 2011��6c   $	��439��6r   $ 0��6~   $ Example Options��6�   $ 32��6�   $ 32��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 33554432 6  $ -8��6#  $	 400��61  .��5      �� 6   5      1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5	   
   -   5        $��st_rc��5	         PBWidth$	 325��6(   $��70��66      Text$ Return Code:��6A      X$	 974��6U      Y$
 1388��6]      	BackColor$ 80263581 6f      Enabled .      FaceName$  MS Sans Serif��6�   !   FocusRectangle! .  "   	FontPitch$" variable=�6�   #   PBFontFamily$# swiss=�6�   $   PBHeight$$ 64��6�   $��15��6�   %   	TextColor$% 33554432 6�   &   TextSize$& -8��6  '   Weight$	' 400��6"  61    5
   
   -   5        $��st_title��5
      $ 79741120 6+   $	 626��6@   $	��136��6N   $&  Enter a Title for the Title Bar.��6Z   $ 87��6�   $	 128��6�    .  $  MS Sans Serif��6�   ! .  $" variable=�6�   $# swiss=�6�   $$ 64��6�   $��15��6	  $% 33554432 6  $& -8��6*  $	' 400��68  6G    5   
   -   5        $��st_text��5      $ 79741120 6*   $
 1303��6?   $	��284��6N   $C =Enter the text that you would like to see in the message box.��6Z   $ 87��6�   $	 320��6�    .  $  MS Sans Serif��6�   ! .  $" variable=�6�   $# swiss=�6  $$ 64��6  $��15��6&  $% 33554432 62  $& -8��6G  $	' 400��6U  6d    5   
   -   5        $��gb_other��5      $ 79741120 6)   $	 468��6>   $	��116��6M   $	 704��6Z   $	��153��6h   $ 0��6t   $# Specify Other Characteristics��6�   $ 0 6�   $
 1285��6�   $	 684��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6  $ -8��6#  $	 400��61  .��5      �� 6   5      /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_msg_userinput��5      (   	BackColor$( 79220952 62   )   PBWidth$	) 334��6G   $��72��6U   *   TabOrder$* 80��6`   +   Text$+ 
User Input��6n   ,   	TextColor$, 41943040 6�   -   X$
- 1353��6�   .   Y$
. 1012��6�   /   BorderStyle$/ stylelowered 6�   0   FaceName$0 MS Sans Serif��6�   1   	FontPitch$1 variable=�6�   2   PBFontFamily$2 swiss=�6�   3   PBHeight$3 67��6  $��16��6  4   TextSize$4 -8��6  5   Weight$	5 400��6-  6<    5   
   -   5        $��cbx_msg_print��5      $( 79220952 6.   $* 70��6C   $+ Print��6Q   $, 41943040 6^   $
- 1353��6s   $	. 932��6|   $/ stylelowered 6�   $0 MS Sans Serif��6�   $1 variable=�6�   $2 swiss=�6�   $3 67��6�   $��16��6�   $	) 234��6�   $��51��6
  $4 -8��6  $	5 400��6#  62  5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -	   5        $��sle_msg_severity��5      6   AutoHScroll6 .  7   BorderStyle$7 stylelowered 6K   8   FaceName$8 Arial��6f   9   	FontPitch$9 variable=�6w   :   PBFontFamily$: swiss=�6�   ;   PBHeight$; 76��6�   <   PBWidth$	< 192��6�   =   TabOrder$= 60��6�   >   Text$> 1��6�   ?   	TextColor$? 41943040 6�   @   TextSize$	@ -10��6�   A   Weight$	A 400��6�   B   X$
B 1737��6  C   Y$	C 860��6  6    5   
   -
   5        $��st_severity��5      $ 79220952 6.   $ 	Severity:��6C   $% 41943040 6T   $
 1353��6i   $	 860��6r    .  $  MS Sans Serif��6�   ! .  $" variable=�6�   $# swiss=�6�   $$ 64��6�   $��15��6�   $	 344��6�   $��75��6  $& -8��6  $	' 400��6%  64    5   
   -   5        $��sle_msg_default��5      6 .  $7 stylelowered 6J   $8 Arial��6e   $9 variable=�6v   $: swiss=�6�   $; 76��6�   $	< 192��6�   $= 50��6�   $> 1��6�   $? 41943040 6�   $	@ -10��6�   $	A 400��6�   $
B 1737��6  $	C 780��6  6    5   
   -   5        $��
st_default��5      $ 79220952 6-   $ Default Button:��6B   $% 41943040 6Y   $
 1353��6n   $	 780��6w    .  $  MS Sans Serif��6�   ! .  $" variable=�6�   $# swiss=�6�   $$ 64��6�   $��15��6�   $	 344��6  $��75��6  $& -8��6  $	' 400��6*  69  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_sendmessage��5      D   DefaultD . E   TabOrder$E 90��6C   F   Text$
F _Run��6Q   G   X$	G 535��6]   H   Y$
H 1368��6e   I   FaceName$I MS Sans Serif��6n   J   	FontPitch$J variable=�6�   K   PBFontFamily$K swiss=�6�   L   PBHeight$L 92��6�   $��22��6�   M   PBWidth$	M 352��6�   $��76��6�   N   TextSize$N -8��6�   O   Weight$	O 400��6�   6    5   
   -   5        $��gb_icon��5      $ 79741120 6(   $	 468��6=   $	��116��6L   $	 512��6Y   $	��111��6g   $ 30��6s   $ Select an Icon��6�   $ 0 6�   $ 91��6�   $	 684��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ -8��6  $	 400��6   .��5      �� .+�5      2	   ,Sybase.PowerBuilder.WPF.Controls.RadioButton	  -   5        $��rb_none��5   $   P 	  	BackColor$P 79220952 63   Q 	  BorderStyle$Q stylelowered 6H   R 	  FaceName$R MS Sans Serif��6c   S 	  	FontPitch$S variable=�6|   T 	  PBFontFamily$T swiss=�6�   U 	  PBHeight$U 67��6�   $��16��6�   V 	  PBWidth$	V 417��6�   $��91��6�   W 	  Text$W None!��6�   X 	  	TextColor$X 41943040 6�   Y 	  TextSize$Y -8��6�   Z 	  Weight$	Z 400��6	  [ 	  X$[ 37��6  \ 	  Y$	\ 273��6  6'  	  5      -   5        $��rb_exclamation��5   $   $P 79220952 6:   $Q stylelowered 6O   $R MS Sans Serif��6j   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 417��6�   $��91��6�   $W Exclamation!��6�   $X 41943040 6�   $Y -8��6	  $	Z 400��6  $[ 37��6$  $	\ 209��6+  65  	  5      -   5        $��rb_question��5   $   $P 79220952 67   $Q stylelowered 6L   $R MS Sans Serif��6g   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 417��6�   $��91��6�   $W 	Question!��6�   $X 41943040 6�   $Y -8��6  $	Z 400��6  $[ 37��6  $	\ 145��6%  6/  	  5      -   5        $��rb_information��5   $   $P 79220952 6:   $Q stylelowered 6O   $R MS Sans Serif��6j   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 417��6�   $��91��6�   $W Information!��6�   $X 41943040 6�   $Y -8��6	  $	Z 400��6  $[ 37��6$  $\ 77��6+  64  	  5      -   5        $��rb_stop��5   $   $P 79220952 63   $Q stylelowered 6H   $R MS Sans Serif��6c   $S variable=�6|   ] 	  	PBChecked] . $T swiss=�6�   $U 67��6�   $��16��6�   $	V 417��6�   $��91��6�   $W 	StopSign!��6�   $X 41943040 6�   $Y -8��6  $	Z 400��6  $[ 37��6+  $\ 9��62  6:  5      5        5   
   -   5        $��	gb_button��5      $ 79741120 6*   $	 468��6?   $	��116��6N   $	 544��6[   $	��118��6i   $ 40��6u   $ Select a ButtonStyle��6�   $ 0 6�   $	 672��6�   $	 684��6�   $ stylelowered 6�   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6  $ -8��6  $	 400��6)  .��5       �� .+�5!      	  -   5        $��rb_abortretryignore��5!   $   $P 79220952 6?   $Q stylelowered 6T   $R MS Sans Serif��6o   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $W AbortRetryIgnore!��6�   $X 41943040 6�   $Y -8��6  $	Z 400��6"  $[ 37��6/  $	\ 329��66  6@  	  5"      -   5        $��rb_yesnocancel��5"   $   $P 79220952 6:   $Q stylelowered 6O   $R MS Sans Serif��6j   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $W YesNoCancel!��6�   $X 41943040 6�   $Y -8��6
  $	Z 400��6  $[ 37��6%  $	\ 265��6,  66  	  5#      -   5        $��rb_okcancel��5#   $   $P 79220952 67   $Q stylelowered 6L   $R MS Sans Serif��6g   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $W 	OkCancel!��6�   $X 41943040 6�   $Y -8��6  $	Z 400��6  $[ 37��6  $	\ 201��6&  60  	  5$      -   5        $��rb_retrycancel��5$   $   $P 79220952 6:   $Q stylelowered 6O   $R MS Sans Serif��6j   $S variable=�6�   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $W RetryCancel!��6�   $X 41943040 6�   $Y -8��6
  $	Z 400��6  $[ 37��6%  $	\ 137��6,  66  	  5%      -   5        $��rb_yesno��5%   $   $P 79220952 64   $Q stylelowered 6I   $R MS Sans Serif��6d   $S variable=�6}   $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $W YesNo!��6�   $X 41943040 6�   $Y -8��6�   $	Z 400��6  $[ 37��6  $\ 73��6   6)  	  5&      -   5        $��rb_ok��5&   $   $P 79220952 61   $Q stylelowered 6F   $R MS Sans Serif��6a   $S variable=�6z   ] . $T swiss=�6�   $U 67��6�   $��16��6�   $	V 480��6�   $	��104��6�   $	W OK!��6�   $X 41943040 6�   $Y -8��6	  $	Z 400��6  $[ 37��6$  $\ 9��6+  63  5'      5(      4
   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit
  5)   
   -   5        $��
mle_errmsg��5)      ^ 
  	BackColor$^ 
1080593568 60   _ 
  PBWidth$
_ 1879��6G   $	��410��6V   ` 
  TabOrder$` 20��6b   a 
  Text$a Invalid Data Entered.��6p   b 
  	TextColor$b 41943040 6�   c 
  
VScrollBarc . d 
  X$d 87��6�   e 
  Y$	e 368��6�   f 
  AutoVScrollf . g 
  BorderStyle$g stylelowered 6�   h 
  FaceName$h MS Sans Serif��6�   i 
  	FontPitch$i variable=�6
  j 
  PBFontFamily$j swiss=�6  k 
  PBHeight$	k 250��64  $��62��6C  l 
  TextSize$l -8��6O  m 
  Weight$	m 400��6]  6l    5*   
   -   5        $��	sle_title��5*      n   	BackColor$n 
1080593568 60   $
< 1879��6G   $	��410��6V   $= 10��6b   $> Application Name��6p   $? 41943040 6�   $B 87��6�   $	C 188��6�   6 .  $7 stylelowered 6�   $8 MS Sans Serif��6�   $9 variable=�6�   $: swiss=�6	  $; 77��6  $��19��6,  $@ -8��68  $	A 400��6F  6U    5+   
   -   5        $��cb_close��5+      $	E 100��6.   $F Close��6=   $
G 1687��6J   $
H 1564��6S   $I MS Sans Serif��6\   $J variable=�6u   $K swiss=�6�   $L 92��6�   $��22��6�   $	M 352��6�   $��76��6�   $N -8��6�   $	O 400��6�   6�     5,   
   -   5        $��sle_msg_clickedbutton��5,      $n 79741120 6<   o   
BringToTopo . p   DisplayOnlyp . $	< 270��6v   $��58��6�   $= 0��6�   $? 33554432 6�   $
B 1312��6�   $
C 1380��6�   6 .  $7 stylelowered 6�   $8 MS Sans Serif��6�   $9 variable=�6  $: swiss=�6   $; 77��65  $��19��6C  $@ -8��6O  $	A 400��6]  6l  5-      5.      