   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   
w_dw3types   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    PBHeight$
  1728��6     PBTitle$2 ,PFC Example - Save Process: All DW Scenarios��6     PBWidth$
 2921��6K     	Resizable .     ToolbarVisible .     X$ 5��6�     Y$ 68��6�     	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$ 79741120 6�  ���	#fff0f0f0   ControlMenu . 	   MaxBox	 . 
   MinBox
 .    TitleBar . .��5      �� .+�5   
   .   (Sybase.PowerBuilder.WPF.Controls.Picture  -   5        $	��p_1��5         OriginalSize .    PBHeight$ 64��67   $��15��6E      PBWidth$ 73��6Q   $��15��6^      PictureName$ 
rowind.bmp��6i      X$
 3269��6�      Y$	 312��6�      FocusRectangle .  6�   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $
��cb_1��5         TabOrder$ 2��6*      X$
 1335��67      Y$
 1508��6@      PBHeight$ 72��6I   $��17��6W      PBWidth$	 320��6c   $��69��6q      Text$ _SQL Spy��6|      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      TextSize$ -8��6�      Weight$	 400��6�   6�   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  5   
   -   5        $��gb_unlinkedpfcdw��5         	BackColor$ 79741120 61      FaceName$ MS Sans Serif��6F       	FontPitch$  variable=�6_   !   PBFontFamily$! swiss=�6t   "   PBHeight$	" 728��6�   #   PBWidth$
# 1326��6�   $   Text$$ Unlinked PFC DataWindow��6�   %   TextSize$% -8��6�   &   Weight$	& 400��6�   '   X$
' 1531��6�   (   Y$( 16��6�   .��5      �� 6   5        5   
   -   5        $��gb_nonpfcdw��5      $ 79741120 6,   $ MS Sans Serif��6A   $  variable=�6Z   $! swiss=�6o   $	" 668��6�   $
# 1326��6�   $$ Non-PFC DataWindow��6�   $% -8��6�   $	& 400��6�   $
' 1531��6�   $	( 800��6�   .��5	      �� 6   5
        5   
   -   5        $��gb_linkedpfcdw��5      $ 79741120 6/   $ MS Sans Serif��6D   $  variable=�6]   $! swiss=�6r   $
" 1452��6�   $
# 1458��6�   $-$ 'Linked PFC DataWindows with Auto-update��6�   $% -8��6�   $	& 400��6�   $' 18��6�   $( 16��6�   .��5      �� 6   5        5   
   -   5        $��cb_close��5      )   Cancel) . $	 370��6<   $��80��6J   $ 80��6U   $ Close��6c   $
 2487��6p   $
 1508��6y   $ MS Sans Serif��6�   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��cb_retrieve��5      $	 370��61   $��80��6?   $ 60��6J   $ 	_Retrieve��6X   $
 1719��6i   $
 1508��6r   $ MS Sans Serif��6{   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�     5   
   -   5        $��	cb_update��5      $	 370��6/   $��80��6=   $ 70��6H   $ _Update��6V   $
 2103��6e   $
 1508��6n   $ MS Sans Serif��6w   $ variable=�6�   $ swiss=�6�   $ 92��6�   $��22��6�   $ -8��6�   $	 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -	   5        $��	dw_nonpfc��5      *   BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$* stylelowered 6,   +   
DataObject$+ d_deptsfreeform��6G   ,   
LiveScroll, . -   PBHeight$	- 528��6v   .   PBTag$. 	regulardw��6�   /   PBVScrollBar/ . 0   PBWidth$
0 1266��6�   1   TabOrder$1 50��6�   2   X$
2 1559��6�   3   Y$	3 912��6�   6�     5   
   -
   5        $��dw_pfc_nolink��5      $+ d_empnamesupdateable��60   , .  4   PBHScrollBar4 . $	- 604��6y   $	��150��6�   $. unlinkedpfc��6�   $
0 1266��6�   $	��276��6�   $1 40��6�   $
2 1559��6�   $3 96��6�   $* stylelowered 6�   / . 6    5   
   -   5        $��dw_link3��5      $+ d_lineitemsupdatable2��6+   , .  $	- 348��6a   $��86��6p   $. linkedchild2��6|   $
0 1399��6�   $	��305��6�   $1 30��6�   $2 46��6�   $
3 1092��6�   $* stylelowered 6�   / . 6�     5   
   -   5        $��dw_link2��5      $#+ d_salesforcustomersupdatable2��6+   , .  $	- 452��6i   $	��112��6x   $. linkedchild1��6�   $
0 1399��6�   $	��305��6�   $1 20��6�   $2 46��6�   $	3 628��6�   $* stylelowered 6�   / . 6    5   
   -   5        $��dw_link1��5      $+ d_customerdetailupdatable��6+   , .  $	- 512��6e   $	��127��6t   $. linkedmaster��6�   $
0 1399��6�   $	��305��6�   $1 10��6�   $2 46��6�   $	3 100��6�   $* stylelowered 6�   / . 6�   5      5      