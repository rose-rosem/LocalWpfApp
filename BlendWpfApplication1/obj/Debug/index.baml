   M S B A M L   `   `   `  ����  BlendWpfApplication1     BlendWpfApplication1.index   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  index��5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6<    � 
ResizeMode$ NoResize=�6O   $
��1280��6e   $	��800��6r    � AllowsTransparency .  � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $ Dictionary2.xaml?�6%   6A   %    5      .��5      � ��5   
   �� 5       �� ImageSource$ 
img/bg.png��6   .+�5   
   �� 	 �� Orientation$	 
Horizontal=�6   $��996,29,153,735q�6/   $��38��6G   .+�5      � -   5        $��wifiProgressBar��5   7   $��Center=�6      wifi#��[  6O   
 � Maximum$
 35Q�6m   � 5      $��10,0,0,0q�6   .+�5      � -   5        $��batteryPowerProgressBar��5        battery#��[ 6>   $	
 100Q�6`   � 5      $��8,0,0,0q�6   $
��Left=�6(   $	��Top=�6C   .+�5      �� -   5        $��battery��5   B   $��img/battery2.png��6   $��38��66   6T   �� 5      -   5        $��batterypercentage��5   �   $	��20%��6    $��Right=�6+   $��Center=�6H   ���#e2574c$��0,0,18,0q�6x   $
��Bold"�6�   6�   5      5      5      �� 5   
   $��800,19,400,729q�6    � Cursor$
 Hand��6)    J� RenderTransformOrigin$ 0.5,0.5&�67   z�5       �� 5!      -   5        	trans�� �� Angle$ 0Q�5!   1    � Triggers 5#      :� 5$       :� RoutedEvent$ Button.Click��6   .[�5%      �� .��5&      �� .��5'      W�  W� From$ 0X�6.   	 W� To$	 360X�67    g� RepeatBehavior$ 1x��6@    g� Duration$ 0:0:3D�6T    �� 
TargetName$ trans��5(   .    �� TargetProperty$ Angle�5)   .   5*      5+      5,      ��5.      �� 5/      .R�50      � .+�51      �� $��img/xin.png��6    $
��Left=�65   6R   52      53      55      �� 57   
   $��883,19,317,729q�6   ��58      �� 59      .R�5:      � .+�5;      �� ��5<      �� 5=   "   .R�5>   &   �� $��img/xin.png��6,   $
��Left=�6A   6^   5?   #   z�5A      �� 5B   "   	trans��$ 0Q�6A    5D      :� 5E   "   $ Button.Click��6/   .[�5F   &   �� .��5G   *   �� .��5H   .   W� $ 0X�6>   $	 360X�6G   $ 1x��6P   $ 0:0:3D�6d   $ trans��5I   .   $ Angle�5J   .   5K   +   5L   '   5M   #   5O      �� 5P      $��刷新��6$   ���#d4237a$��16(�6C   $��Right=�6Q   $��0,2,2,0q�6m   6�   5Q      5R      5T      5U      5V      