   M S B A M L   `   `   `  ����  BlendWpfApplication1%    BlendWpfApplication1.tabcontrol   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
tabcontrol��5   	   $	��600��6   $	��800��6)    � 	Resources 5       *  &TabControl.ActivedItemHeaderBackground �� Color �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType � RowDefinitions	 �Name
 �� Padding K� IsItemsHost J� OpacityMask !� Visual �� ElementName ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ��Name �� CornerRadius �� RelativeSource �� AncestorType��%�  &	        '�� !     7��7   '��     7���� 5	   
   $ #fc4b4a��6I   �� 5   
   " ��6   8   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5       � �� 5      �� 5      " ��6&   .R�5      �  5      �� 5   "   $
	 ROW0��60   �� 5   "   $
	 ROW1��60   .+�5      �� $
��Mask��68   
��������� 5      $��TP��6:   $
 
25,20,25,0q�6%   ._�5   "   ��  .  5    &   !� 5!   *    66   �� $
 Mask��5#   #   5$      � 5&      $��TC��6#   .+�5'   "   �� $��EB��6)   $��-1q�63   $��0,1,0,0q�6?   8�� 6�   �� 5(   "   $ PART_SelectedContentHost��63   $��SelectedContent��6U   $��10q�6u   # z 6�   5)      5+       5-      P� 5/       �@��TabStripPlacement$	 Top=�6C   . �50   "   �� $
 ROW0��6)    � ��$
 auto �6M   �� 52   "   $
 Mask��6)    � ��$ 0��6O   �� 54   "   $ TP��6)    � ��$ 0��6M   �� 56   "   $ TC��6)    � ��$ 1��6M   �� 58   "   $ EB��6)    � ��$ 0,3,0,0q�6T   59      5=      5?      5@      �� 5C   
   " ��6   8   .�5E      ��  � ��
 �   �65   �� 5F       � ��$ 22(�63   �� 5H       � �� 5I      �� 5J      " ��6&   .R�5K      �� $	 bbb��61   $
 15,10q�6!    . }�. $ 5,5,0,0��6m   $
��10,0q�6�   ._�5M      �� $ contentPresenter��6/   $��Header��5N   /   |�.  #��z��5Q   /   ��. # z 5S   /   ��5P   /   �� *HorizontalContentAlignment+ �� " ����5T   /   �� *VerticalContentAlignment+ �� " ��5U      5V       5X      P� 5Y       �@��
IsSelected . . �5Z   "   �� $	 bbb��6)    � �� �#fc4b4a6P   �� 5[   "    � ��
 �����6I   5]      5`      5b      5d      5e      .��5g      � .+�5i   
   �� .@�5j      �� $��机 构 榜��6   .��5k      &   System.Windows.Controls.DataGrid  -   5        $��dataGridAsc��5k      60   5l      �� 5m      $��江 苏 榜��6   5o      5p      5q      5r      