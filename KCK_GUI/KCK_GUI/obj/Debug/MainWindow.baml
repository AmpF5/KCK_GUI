   M S B A M L   `   `   `  ����B  >KCK_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:KCK_GUIKCK_GUI  5   	       KCK_GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:KCK_GUI     5   	     � Title$  KCK Projekt 2��5   	   $	��800��6   $	��600��6,   .��5	      � $��
0,0,-8,-31q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0 �6   .+�5   
   �� $��images\background.png��6   $
��Fill=�6/   �� 5   
   $��images\logo.png��6   $��Center=�6)   $��124,0,138,560q�6F   $	��338��6]    J� RenderTransformOrigin$ -0.166,0.504&�6i   �� 5   
   -   5        $
��Play��5      $��Center=�6    $��155,240,155,0q�6=   $	��Top=�6T   $��75��6l   $��20��6�   �� 5   
   -   5        $��Credits��5      $��Center=�6#   $��155,280,155,0q�6@   $	��Top=�6W   $��75��6o   $��20��6�   � 5   
    � 	Resources 5       �� 
TargetType �� Property �� Value �� Color �� 
TargetType	 �� CornerRadius
 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   ShadowDepth��%�  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5   "   $ #FF3131��62   5      �� 5       � �� 5      �� 5   "   " ��62   .R�5   &   �� #��z��6-   $	��0.8q�6Y   $	 3��6o   
 5   *     5   .   $ #FF3131��6?   $ 0Q�6O   ._�5!   *   �� #��z��64   #��z��6_   $��Center=�6�   $��Center=�6�   5"   '   5#   #   5%      5&      5'      .+�5(   
   �� -   5        $
��Exit��5(      $��Center=�6    $��155,320,155,0q�6=   $	��Top=�6T   $��75��6l   $��20��6�   5)      5+      5,      