   M S B A M L   `   `   `  ����h  dSybase.PowerBuilder.WPF.Controls, Version=12.0.0.0, Culture=neutral, PublicKeyToken=598c7456a83d557a}Xclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls Sybase.PowerBuilder.WPF.Controls  5   �    pfcsecurity_scanner#   w_pfcsecurity_targetselection   6   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=598c7456a83d557aW SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    6Q   hpbwpfXclr-namespace:Sybase.PowerBuilder.WPF.Controls;assembly=Sybase.PowerBuilder.WPF.Controls    6�   -   'Sybase.PowerBuilder.WPF.Controls.Window    	BackColor:   4Sybase.PowerBuilder.WPF.Controls.PBWPFColorConverter$  80921269 6  ���	#fff0f0f0   Center .    ControlMenu .    MaxBox .    MinBox .    PBHeight$
 2064��6�     PBTitle$ Select Application��6�     PBWidth$
 1961��6�     	Resizable . 	   TitleBar	 . 
   X$

 1074��6�     Y$	 484��6�  .��5      �� .+�5   
   4   .Sybase.PowerBuilder.WPF.Controls.CommandButton  -   5        $��cb_exit��5         Cancel .    FaceName$ MS Sans Serif��6;      	FontPitch$ variable=�6T      PBFontFamily$ swiss=�6i      PBHeight$ 92��6~      PBWidth$	 343��6�      TabOrder$ 30��6�      Text$ Cancel��6�      TextSize$ -8��6�      Weight$	 400��6�      X$
 1472��6�      Y$
 1836��6�   6�     5   
   -   5        $��	cb_select��5      61   5   /Sybase.PowerBuilder.WPF.Controls.SingleLineEdit  5   
   -   5        $��sle_targetfile��5         BorderStyle=   7Sybase.PowerBuilder.WPF.Controls.PBBorderStyleConverter$ stylelowered 65      FaceName$ MS Sans Serif��6P      FontCharSet$
 ansi=�6i      	FontPitch$ variable=�6|      PBFontFamily$ swiss=�6�      PBHeight$ 84��6�      PBWidth$
 1783��6�      TabOrder$ 30��6�       	TextColor$  33554432 6�   !   TextSize$! -8��6�   "   Weight$	" 400��6�   #   X$# 32��6  $   Y$	$ 132��6  6    5   
   -   5        $��	cb_browse��5      $ MS Sans Serif��6/   %   FontCharSet$
% ansi=�6H   $ variable=�6[   $ swiss=�6p   $ 84��6�   $ 73��6�   $ 40��6�   $
 _...��6�   $ -8��6�   $	 400��6�   $
 1815��6�   $	 132��6�   6�   4   .Sybase.PowerBuilder.WPF.Controls.MultiLineEdit  5   
   -   5        $��mle_1��5      &   BorderStyle$& stylelowered 6+   '   FaceName$' MS Sans Serif��6F   (   FontCharSet$
( ansi=�6_   )   	FontPitch$) variable=�6r   *   
HScrollBar* . +   PBFontFamily$+ swiss=�6�   ,   PBHeight$
, 1400��6�   $	��349��6�   -   PBWidth$
- 1783��6�   $	��389��6�   .   TabOrder$. 40��6�   /   	TextColor$/ 33554432 6�   0   TextSize$0 -8��6	  1   
VScrollBar1 . 2   Weight$	2 400��6)  3   X$3 32��66  4   Y$	4 408��6=  5   IgnoreDefaultButton5 . 6b    5   
   -   5        $
��cb_1��5      $ MS Sans Serif��6*   $
% ansi=�6C   $ variable=�6V   $ swiss=�6k   $ 84��6�   $ 73��6�   $ 40��6�   $
 _...��6�   $ -8��6�   $	 400��6�   $
 1815��6�   $	 408��6�   6�     5	   
   -   5        $��cb_ok��5	      6   Default6 . 7   Enabled7 .  $ MS Sans Serif��6J   $
% ansi=�6c   $ variable=�6v   $ swiss=�6�   $ 92��6�   $	 343��6�   $ 50��6�   $ OK��6�   $ -8��6�   $	 400��6�   $
 1111��6�   $
 1836��6�   6  1   +Sybase.PowerBuilder.WPF.Controls.StaticText  5
   
   -   5        $��	st_target��5
      8   	BackColor$8 67108864 6,   9   FaceName$9 MS Sans Serif��6A   :   FocusRectangle: .  ;   FontCharSet$
; ansi=�6q   <   	FontPitch$< variable=�6�   =   PBFontFamily$= swiss=�6�   >   PBHeight$> 76��6�   ?   PBWidth$
? 1472��6�   @   Text$L@ FBrowse for a _target file containing the application you wish to scan.��6�   A   	TextColor$A 33554432 6  B   TextSize$B -8��6.  C   Weight$	C 400��6<  D   X$D 32��6I  E   Y$E 56��6P  6Y    5   
   -	   5        $��
st_liblist��5      $8 67108864 6-   $9 MS Sans Serif��6B   : .  $
; ansi=�6r   $< variable=�6�   $= swiss=�6�   $> 76��6�   $
? 1472��6�   $0@ *Adjust Library _Search Path, if necessary:��6�   $A 33554432 6�   $B -8��6  $	C 400��6!  $D 32��6.  $	E 332��65  6?  5      5      