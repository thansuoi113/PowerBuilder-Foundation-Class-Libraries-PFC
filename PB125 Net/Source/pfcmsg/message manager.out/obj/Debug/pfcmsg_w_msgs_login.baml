   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �   
 pfcmsg   w_msgs_login   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    Center  .    PBHeight$
 1040��6     PBTitle$ Database Login��6$     PBWidth$
 1655��6=     	Resizable .    X$
 1010��6]     Y$	 664��6f     MaxBox .     MinBox .  	   
WindowType$	 response=�6�  
   	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$
 79741120 6�  ���	#fff0f0f0   ControlMenu .    TitleBar . .��5      �� .+�5   
   1   +Sybase.PowerBuilder.WPF.Controls.StaticText  -   5        $��st_dbms��5         	Alignment$ right=�6*      FaceName$ Arial��6<      PBHeight$ 76��6M   $��18��6[      PBWidth$	 343��6g   $��74��6u      Text$ _DBMS :��6�      X$ 46��6�      Y$ 28��6�      	BackColor$ 80263581 6�      Enabled .     FocusRectangle .     	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6     TextSize$ -8��6     Weight$	 400��6&  65  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��	cb_cancel��5         Cancel .    TabOrder$	 110��6=      Text$ Cancel��6L      X$
 1234��6Z       Y$	  816��6c   !   FaceName$! MS Sans Serif��6k   "   	FontPitch$" variable=�6�   #   PBFontFamily$# swiss=�6�   $   PBHeight$$ 92��6�   $��22��6�   %   PBWidth$	% 352��6�   $��76��6�   &   TextSize$& -8��6�   '   Weight$	' 400��6�   6�     5   
   -   5        $��cb_ok��5      (   Default( . $	 100��6:   $ OK��6I   $	 855��6S   $	  816��6[   $! MS Sans Serif��6c   $" variable=�6|   $# swiss=�6�   $$ 92��6�   $��22��6�   $	% 352��6�   $��76��6�   $& -8��6�   $	' 400��6�   6�     5   
   -   5        $��st_database��5      $ right=�6.   )   
BringToTop) . $ Arial��6R   $ 76��6c   $��18��6q   $	 343��6}   $��74��6�   $ Data_base : ��6�   $ 46��6�   $	 108��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6
  $ 33554432 6  $ -8��64  $	 400��6B  6Q    5   
   -   5        $��st_logid��5      $ right=�6+   ) . $ Arial��6O   $ 76��6`   $��18��6n   $	 343��6z   $��74��6�   $ Lo_gid :��6�   $ 46��6�   $	 192��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6-  $	 400��6;  6J    5   
   -   5        $��
st_logpass��5      $ right=�6-   ) . $ Arial��6Q   $ 76��6b   $��18��6p   $	 343��6|   $��74��6�   $ 
Log_pass :��6�   $ 46��6�   $	 276��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��61  $	 400��6?  6N    5	   
   -   5        $��st_servername��5	      $ right=�60   ) . $ Arial��6T   $ 76��6e   $��18��6s   $	 384��6   $��83��6�   $ Server_name :��6�   $ 5��6�   $	 360��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6!  $ -8��66  $	 400��6D  6S    5
   
   -   5        $��	st_userid��5
      $ right=�6,   ) . $ Arial��6P   $ 76��6a   $��18��6o   $	 343��6{   $��74��6�   $ 	_Userid :��6�   $ 46��6�   $	 444��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6/  $	 400��6=  6L    5   
   -	   5        $��	st_dbpass��5      $ right=�6,   ) . $ Arial��6P   $ 76��6a   $��18��6o   $	 343��6{   $��74��6�   $ 	Dbpa_ss :��6�   $ 46��6�   $	 528��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6/  $	 400��6=  6L    5   
   -
   5        $��st_lock��5      $ right=�6*   ) . $ Arial��6N   $ 76��6_   $��18��6m   $	 343��6y   $��74��6�   $ Loc_k :��6�   $ 46��6�   $	 612��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6+  $	 400��69  6H    5   
   -   5        $��	st_dbparm��5      $ right=�6,   ) . $ Arial��6P   $ 76��6a   $��18��6o   $	 343��6{   $��74��6�   $ 	Dbpar_m :��6�   $ 46��6�   $	 696��6�   $ 80263581 6�    .   .  $ variable=�6�   $ swiss=�6  $ 33554432 6  $ -8��6/  $	 400��6=  6L  5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_database��5      *   AutoHScroll* . +   
BringToTop+ . ,   PBHeight$, 76��6X   $��18��6f   -   PBWidth$
- 1175��6r   $	��256��6�   .   TabOrder$. 20��6�   /   X$	/ 402��6�   0   Y$	0 108��6�   1   	BackColor$1 
1090519039 6�   2   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$2 stylelowered 6�   3   FaceName$3 MS Sans Serif��6�   4   	FontPitch$4 variable=�6�   5   PBFontFamily$5 swiss=�6  6   	TextColor$6 33554432 6   7   TextSize$7 -8��65  8   Weight$	8 400��6C  6R    5   
   -   5        $��	sle_logid��5      * . + . $, 76��6U   $��18��6c   $
- 1175��6o   $	��256��6~   $. 30��6�   $	/ 402��6�   $	0 192��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6  $6 33554432 6  $7 -8��62  $	8 400��6@  6O    5   
   -   5        $��sle_logpass��5      * . + . $, 76��6W   $��18��6e   $
- 1175��6q   $	��256��6�   9   Password9 . $. 40��6�   $	/ 402��6�   $	0 276��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6  $5 swiss=�6  $6 33554432 6/  $7 -8��6D  $	8 400��6R  6a    5   
   -   5        $��sle_servername��5      * . + . $, 76��6Z   $��18��6h   $
- 1175��6t   $	��256��6�   $. 50��6�   $	/ 402��6�   $	0 360��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6  $6 33554432 6"  $7 -8��67  $	8 400��6E  6T    5   
   -   5        $��
sle_userid��5      * . + . $, 76��6V   $��18��6d   $
- 1175��6p   $	��256��6   $. 60��6�   $	/ 402��6�   $	0 444��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6	  $6 33554432 6  $7 -8��63  $	8 400��6A  6P    5   
   -   5        $��
sle_dbpass��5      * . + . $, 76��6V   $��18��6d   $
- 1175��6p   $	��256��6   9 . $. 70��6�   $	/ 402��6�   $	0 528��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6  $5 swiss=�6  $6 33554432 6.  $7 -8��6C  $	8 400��6Q  6`    5   
   -   5        $��sle_lock��5      + . $, 76��6A   $��18��6O   $
- 1175��6[   $	��256��6j   $. 80��6v   $	/ 402��6�   $	0 612��6�   * .  $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6  $6 33554432 6  $7 -8��62  $	8 400��6@  6O    5   
   -   5        $��
sle_dbparm��5      * . + . $, 76��6V   $��18��6d   $
- 1175��6p   $	��256��6   $. 90��6�   $	/ 402��6�   $	0 696��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6	  $6 33554432 6  $7 -8��63  $	8 400��6A  6P    5   
   -   5        $��sle_dbms��5      * . + . $, 76��6T   $��18��6b   $
- 1175��6n   $	��256��6}   $. 10��6�   $	/ 402��6�   $0 24��6�   $1 
1090519039 6�   $2 stylelowered 6�   $3 MS Sans Serif��6�   $4 variable=�6�   $5 swiss=�6  $6 33554432 6  $7 -8��60  $	8 400��6>  6M  5      5      