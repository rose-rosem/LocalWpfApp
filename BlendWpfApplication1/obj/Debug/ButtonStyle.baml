   M S B A M L   `   `   `  ����  BlendWpfApplication1%    BlendWpfApplication1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  按钮控件��5   	   $	��350��6   $	��525��6#    � 	Resources 5         BtnStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� RadiusY �� RadiusX	 ��Name
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5      " ��6   .�5      ��  � �� 5      �� 5	      " ��6   .R�5
      � .+�5   	   �� $ 	rectangle��6   ���	#FFB1B1FF$ 5��67   $ 5��6C   �� 5   	   $	 contentPresenter��6   #��z��64   ��. #
 z
 6�   #��z��6�   5   	    5      P� 5   	    �@J�	IsFocused . . �5   
   �� $ 	rectangle��6!    � �� �	#FFFFFBB168   �� 5   
   $ contentPresenter��6$    � ��$ Focus��6B   5   
   P� 5   	    �@��IsDefaulted . . �5   
   �� $ 	rectangle��6!    � �� �	#FFFF9B9B68   �� 5   
   $ contentPresenter��6$    � ��$ IsDefaulted = True��6B   5   
   P� 5   	    �@J�IsMouseOver . . �5   
   �� $ contentPresenter��6$    � ��$ 	MouseOver��6B   �� 5   
   $ 	rectangle��6!    � �� �	#FF91FB8168   5   
   P� 5   	    � �� . . �5    
   �� $ 	rectangle��6!    � �� �	#FFB1FFFF68   �� 5!   
   $ contentPresenter��6$    � ��$ Press��6B   5"   
   P� 5$   	    � {� .  . �5%   
   �� $ contentPresenter��6$    � ��$ 失活��6B   �� 5&   
   $ 	rectangle��6!    � �� �	#FF72727268   5'   
   5)      5+      5,      5-      .��5/      � .+�50      �� $��Button��6   $
��Left=�6   $
��45.5��6:   $��37,53.5,0,0q�6H   #���   6]   $	��Top=�6�   $	��151��6�   52      53      