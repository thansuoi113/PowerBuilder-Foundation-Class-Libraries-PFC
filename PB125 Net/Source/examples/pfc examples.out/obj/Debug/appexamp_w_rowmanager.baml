   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcexamp   w_rowmanager   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557a^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  77571519 6  ���	#fff0f0f0   PBHeight$
 1336��62     PBTitle$' !PFC Example - Row Manager Service��6B     PBWidth$
 2373��6n     	Resizable .     TitleBar .    X$	 283��6�     Y$	 108��6�     ControlMenu . 	   MaxBox	 . 
   MinBox
 . .��5      �� .+�5   
   /   )Sybase.PowerBuilder.WPF.Controls.GroupBox  -   5        $
��gb_1��5         PBHeight$
 1056��6%   $	��263��65      PBWidth$
 2286��6B   $	��499��6Q      TabOrder$ 2��6]      Text$  ��6j      X$ 23��6r      Y$ 20��6y      	BackColor$ 80263581 6�      BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 6�      FaceName$ MS Sans Serif��6�      	FontPitch$ variable=�6�      PBFontFamily$ swiss=�6�      	TextColor$ 33554432 6�      TextSize$ -8��6     Weight$	 400��6  .��5      �� 6   5      /   )Sybase.PowerBuilder.WPF.Controls.CheckBox  5   
   -   5        $��cbx_confirmdeletes��5         	PBChecked .    PBWidth$	 453��6D   $��98��6R      TabOrder$ 20��6]      Text$ Con_firm Deletes��6k      	TextColor$ 41943040 6�      X$
 1792��6�      Y$	 812��6�       	BackColor$  80263581 6�   !   BorderStyle$! stylelowered 6�   "   FaceName$" MS Sans Serif��6�   #   	FontPitch$# variable=�6�   $   PBFontFamily$$ swiss=�6  %   PBHeight$% 67��6  $��16��6*  &   TextSize$& -8��66  '   Weight$	' 400��6D  6S  4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  5   
   -   5        $��cb_close��5      (   Cancel( . )   PBWidth$	) 517��6<   $	��112��6J   *   TabOrder$* 80��6V   +   Text$+ Close��6d   ,   X$
, 1787��6q   -   Y$
- 1108��6z   .   FaceName$. MS Sans Serif��6�   /   	FontPitch$/ variable=�6�   0   PBFontFamily$0 swiss=�6�   1   PBHeight$1 92��6�   $��22��6�   2   TextSize$2 -8��6�   3   Weight$	3 400��6�   6�     5   
   -   5        $��cb_deleteall��5      $	) 517��62   $	��112��6@   $* 70��6L   $+ Delete all _Selected��6Z   $
, 1760��6v   $	- 540��6   $. MS Sans Serif��6�   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6    5	   
   -   5        $��cb_deletecurr��5	      $	) 517��63   $	��112��6A   $* 60��6M   $+ _Delete Current��6[   $
, 1760��6r   $	- 424��6{   $. MS Sans Serif��6�   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�     5
   
   -   5        $��cb_insertbeforecurr��5
      $	) 517��69   $	��112��6G   $* 50��6S   $+ _Insert Before Current��6a   $
, 1760��6   $	- 308��6�   $. MS Sans Serif��6�   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6
    5   
   -   5        $��cb_addtoend��5      $	) 517��61   $	��112��6?   $* 40��6K   $+ Add to _End��6Y   $
, 1760��6l   $	- 192��6u   $. MS Sans Serif��6}   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6�   1   +Sybase.PowerBuilder.WPF.Controls.DataWindow  5   
   -   5        $
��dw_1��5      4   
DataObject$4 d_empall��6'   5   PBHScrollBar5 . 6   PBHeight$	6 968��6Q   $	��241��6`   7   PBWidth$
7 1627��6m   $	��355��6|   8   TabOrder$8 10��6�   9   X$9 55��6�   :   Y$: 76��6�   ;   BorderStyle$; stylelowered 6�   <   
LiveScroll< . =   PBVScrollBar= . 6�     5   
   -	   5        $��cb_retrieve��5      >   
BringToTop> . $	) 517��6C   $	��112��6Q   $* 30��6]   $+ 	_Retrieve��6k   $
, 1760��6|   $- 76��6�   $. MS Sans Serif��6�   $/ variable=�6�   $0 swiss=�6�   $1 92��6�   $��22��6�   $2 -8��6�   $	3 400��6�   6  5      5      