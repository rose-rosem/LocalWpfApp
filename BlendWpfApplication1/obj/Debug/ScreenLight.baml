   M S B A M L   `   `   `  ����  BlendWpfApplication1&     BlendWpfApplication1.ScreenLight   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ScreenLight��5   	   $	��800��6   $
��1280��6*    � WindowStyle$
 None=�67    � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`    � AllowsTransparency . 
������  � 	Resources 5         SliderBackground �� 
StartPoint �� EndPoint � Offset	 � Color  Slider_RepeatButtonLeft
 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius  Slider_RepeatButtonRight  Slider_Thumb  SliderStyle ]�Name ]� IncreaseRepeatButton �� IncreaseLarge ]� DecreaseRepeatButton �� DecreaseLarge ]� Thumb��%r  &	        &	 �     7   &	 $    &	 �    &	 }    7  7  7  �� 5   
   $	 0,0&�68   $	 1,0&�6I   .��5      � $ 0Q�6   $	 #539105��6&   � 5	      $
 0.33Q�6   $	 #7eb23c��6)   � 5
      $
 0.61Q�6   $	 #30bde5��6)   � 5      $ 1Q�6   $	 #73d9f6��6&   5      �� 5   
   "
 ��60   .�5      ��  � ��$	 8.5��6'   �� 5       � ��$	 336��6&   �� 5       � ��$ 13,0,0,0q�6'   �� 5       � ��
 ���� 6,   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 8��  $ 5��6P   5      5      5      �� 5   
   "
 ��6   .�5      ��  � �� 5      �� 5       .R�5!      �� 
������ 6$   5"      5$      5%      �� 5'   
   "
 n�6%   .�5(      ��  � |� .  6*   �� 5)       � �� 5*      �� 5+      " n�6&   .R�5-      �� $��img/slider.png��6    $��50��68   6E   5.      50      51      �� 53   
   "
 ��6   .�54      ��  � �� 55      �� 56      .R�57      � .+�58      �� $��img/sliderbg.png��6$   $��29��6>   6L   �� 59      $��img/sliderbg2.png��6$   $��11��6?   6M   ]� 5:      $ 
PART_Track��6%    5;   "   �� 5<   &   #��Z 63   8��  6]    5>   "   �� 5?   &   #��Z 63   8�� 6]    5A   "   n� 5B   &   8�� 6,   5D      5E      5F      5H      5I      5J      .��5K      � .+�5L   
   �� ���#111 J� Opacity$ .4Q�6    6/   �� 5M   
   $��Center=�6   $��Center=�60   .+�5N      �� ���#fd5958$��60��6*   $	��Top=�66   $ 	20,20,0,0��6N   $	��600��6g   ._�5O      �� $��平板设置��6   $��22(�6'   ���#fff$��Center=�6G   $
��Left=�6b   $��30,0,0,0q�6}   6�   5P      �� 5Q      $��Center=�6   $��Center=�62   $	��600��6N   $	��440��6Z   $ 	0,0,20,20��6g   ���#fff._�5R      �� $��40,20q�6   .+�5S      ��  �� Orientation$ 
Horizontal=�6!   $��0,20,0,0q�6:   .+�5T      �� $��img/light.png��6    $��45��67   6E   �� 5U      $��屏幕亮度��6    $��22(�6/   ���#fd5958$��Center=�6R   $��5,0,0,0q�6m   6�   5V      �� 5W      $ 
Horizontal=�6!   $��
50,20,0,50q�6:   .+�5X      �� -   5        $��brightnessSlider��5X   `   #��[ 6"   $	��362��6H   $��54��6T   6`   �� 5Y      -   5        $��brightnessLabel��5Y   �   $��Center=�6\   $��Center=�6w   $��22(�6�   ���#fd5958$��10,0,0,0q�6�   ��6    ��  �� ElementName$ brightnessSlider�� �� Path$ Value�6�   5Z      �� 5\      $ 
Horizontal=�6!   .+�5]      �� $��img/voice.png��6    $��40��67   $	��2,0q�6C   6R   �� 5^      $��音量调节��6    $��22(�6/   ���#fd5958$��Center=�6R   $��5,0,0,0q�6m   6�   5_      �� 5a      $ 
Horizontal=�6!   $��
50,20,0,30q�6;   .+�5b      �� -   5        $��volumeSlider��5b   `   #��[ 6"   $	��362��6H   $��54��6T   6`   �� 5c      -   5        $��volumeLabel��5c   �   $��Center=�6X   $��Center=�6s   $��22(�6�   ���#fd5958$��10,0,0,0q�6�   ��6    �� $ volumeSlider��$ Value�6�   5d      5f      5g      5h      �� 5j   
   $	��Top=�6    � Cursor$
 Hand��6)   $��Right=�67   $��0,166,360,0q�6S   ��5k      �� 5l      .R�5m      �� $��img/close1.png��6   $��33��64   6B   5n      5p      5s      5t      