   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   O KBlendWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BlendWpfApplication1BlendWpfApplication1 5   	   #   BlendWpfApplication1.rankBang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7core&clr-namespace:System;assembly=mscorlib     5   	   4local"clr-namespace:BlendWpfApplication1     5   	     � Title$
  bang��5   	   $	��800��6   $
��1280��6#    � WindowStartupLocation$ CenterScreen=�61    � 	Resources 5         
SexualEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� Type&   BlendWpfApplication1.sexual_enum  
DepualEnum#  BlendWpfApplication1.dep_enum  DateTemplate �� StringFormat  EditingDateTemplate(  "System.Windows.Controls.DatePicker   SelectedDate&   System.Windows.Controls.DataGrid	 �� 
TargetType
 �� Property �� Value �� Color=  7System.Windows.Controls.Primitives.DataGridColumnHeader:  4System.Windows.Controls.Primitives.DataGridRowHeader)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value*	  $System.Windows.Controls.DataGridCell �� 
TargetType �� TextAlignment��%�
  &	        &	 [     &	 �     &	 S    '  �    '      '  �    '  '    '	  H    '�� l	    S� 5
   
   $ 	GetValues��60   "  6G    5      M� 5      "  6   5      S� 5   
   $ 	GetValues��60   "  6G    5      M� 5      "  6   5      �� 5   
   .R�5      �� $��40��6   $��30��6$   .+�5      �� 
��� ���
���   �$��1q�6A   ._�5      �� $��10(�5      $��Center=�6&   ��5       �� *
ExamDate+$ 	{0:MM-dd}��5   &   5      �� 5      
�������
���   �$��1q�6@   ._�5      �� $��10(�5      $��Center=�6&   ��5       �� *
ExamDate+$ {0:yyyy}��5   &   5      5      5       �� 5"   
   .R�5#         6   �� *
ExamDate+5$      �� 5'   
   "	  6   .�5(      �� 
 �@ CanUserResizeColumns .  65   �� 5)      
 � ��
 ��ح�6+   �� 5*      
 � ��
 ���� 6,   �� 5,       
 �@ HorizontalGridLinesBrush 5-      �� 5.      $ Transparent��6&   50      �� 52      
 �@ VerticalGridLinesBrush 53      �� 54      $ Transparent��6&   56      57      �� 5:   
   "	  6   .�5;      �� 
 �@J�SnapsToDevicePixels . 64   �� 5<      
 � ��$	 112��6)   �� 5=      
 � ��$ 50��6*   �� 5@      
 � ��
 � ���6+   �� 5A      
 � ��$ Center=�6:   �� 5B      
 � ��$ Center=�6;   �� 5C      
 � ��$ 16(�6)   �� 5D      
 �@�Cursor$
 Hand��6'   66   �� 5E      
 � ��$ Agency FB Regular)�6+   6G   �� 5F      
 � ��$ Light"�6+   5H      �� 5J   
   "	  6   .�5K      �� 
 � ��
 ���� 6+   5L      �� 5P   
   "	  6   .�5R      �� 
 � ��$ 45��6'   �� 5S      
 � �� �#3336+   �� 5T      
 � ��$ 15(�6)    5W      P� 5X       �@ AlternationIndex$ 0��66   . �5Y      �� 
 � ��
 �����63   5Z      P� 5[       �@ AlternationIndex$ 1��66   . �5\      �� 
 � ��
 �����63   5]      P� 5`       �@J�IsMouseOver . . �5a      �� 
 � ��
 ����63   5b      P� 5d       �@ 
IsSelected . . �5e      �� 
 � ��
 ��·�63   5f      5h      �� 5j   
   "	 	 6   .�5l      �� 
 � �� 5m      �� 5n      " 	 6&   .R�5o      �� $ Center=�6$   $��Center=�6;   �� 5p      5q      5r      5t       5v      P� 5w       �@	 
IsSelected . . �5x      �� 
 � ��
 �  ��63   5y      5{      �� 5|   
   "	 ��6   .�5}      �� 
 � �� �#5556:   �� 5~      
 �@�Cursor$
 Hand��6'    5      P� 5�       � �� . . �5�      �� 
 � ��
 ��·�63   5�      5�      5�      .��5�      �  � RowDefinitions 5�   
   �� 5�      $	��29* �6   �� 5�      $
��371* �6   .+�5�   
   � 5�      � 5�   
   $��1��6   
������� � ColumnDefinitions 5�      �� 5�      $
��407* �6#   �� 5�      $	��17* �6#   .+�5�      �� $��0,0,0,0q�6   ���#ccc$��
20,20,0,20q�6B   ._�5�      �� ���#fff �� CornerRadius$ 15��6+   $
��1100��6=   ._�5�      �� .+�5�      �� $��0,0,0,1q�6!   ���#ccc$��60��6N   $
��0,20q�6Z   $��Center=�6h   ._�5�      ��  �� Orientation$ 
Horizontal=�6)   $	��0,5q�6B   .+�5�   "   �� $��img1/people.png��6(   6C   �� 5�   "   $��培洛科技员工表��6,   $��28(�6;   $��楷体)�6I   $��Center=�6Y   $��15,0,0,0q�6t   6�   5�      5�        5�      -   5        $��	datagrid1��5�   #   $
��1000��65      AutoGenerateColumns .     CanUserSortColumns .     CanUserResizeColumns .     CanUserResizeRows .     SelectionMode$ Single=�5�   v      CanUserReorderColumns .   �� AlternationCount$ 2��5�   A   ��5�   �   ��    Columns 5�      4
  .System.Windows.Controls.DataGridTemplateColumn
  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Photo��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6H     
  CellTemplate  5�   &   �� 5�   *   .R�5�   .   �� 5�   +   5�   #   0  *System.Windows.Controls.DataGridTextColumn  5�   "   $
 Name��65   $	 150 6C   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6O   �� *Name+6j   4  .System.Windows.Controls.DataGridComboBoxColumn  5�   "   $	 150 69   $	 Sex��6E   "   SelectedItemBinding" 6R   �� *sexual+#   ItemsSource# 6y   �� $ �� Source#$ [  6�     5�   "   $	 150 69   $ 
Department��6E   " 6Y   �� *dep+# 6}   �� #$ [ 6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5�   "   $ Married��69   $	 150 6J   ! 6V   �� *mar+6p   5  /System.Windows.Controls.DataGridHyperlinkColumn  5�   "   $ Email��6:   $	 220 6I   ! 6U   �� *Email+6q   5�      5�      5�      5�      5�      5�      5�      