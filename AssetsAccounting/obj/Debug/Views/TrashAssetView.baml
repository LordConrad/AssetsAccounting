   M S B A M L   `   `   `  ����  AssetsAccounting+    %AssetsAccounting.Views.TrashAssetView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        � 	Resources  5	       �� 
TargetType   
LabelStyle �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��$ 18(�6)   66   �� 5       � ��$ Center=�64   6E   5      5      .��5      � $	��300��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   #���   6   ��6B   �� *
HeaderText+6c   �� 5   
   $��1��6   .��6   Материал6'   �� 5   
   $��2��6    �� DisplayMemberPath$ 
Asset.Name��6?   ��6    �� *Assets+ �� SelectedItem 6^   �� *SelectedAsset+6�   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $ Vertical=�6   .+�5      �� .��6   ,*Количество на списание60   %  Xceed.Wpf.Toolkit.IntegerUpDown  5      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�6z   	   Value	 6%   �� *
Quantity+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ OneWayToSource=�   Maximum 6�   �� *QuantityMax+6�   5       �� 5!      $ Vertical=�6   .+�5"      �� .��6   " Остаток на складе6+   �� 5#      ��6   �� *OveralQuantity+$ OneWay=�$
 PropertyChanged=�6o   5$      5%      �� 5&   
   $��4��6   .��6   +)Номер акта на списание65   �� 5'   
   $��5��6   ��6   �� *	DocNumber+$
 PropertyChanged=�6a   �� 5(   
   $��6��6   $	��100��6D   $
��0 20q�6P   ��6   �� *TrashAssetCommand+.��6^   Списать6g   5)      5*      