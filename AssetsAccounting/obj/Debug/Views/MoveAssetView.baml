   M S B A M L   `   `   `  ����  AssetsAccounting*    $AssetsAccounting.Views.MoveAssetView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xckg)http://schemas.xceed.com/wpf/xaml/toolkit  5        � 	Resources  5	       �� 
TargetType   
LabelStyle �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��$ 18(�6)   66   �� 5       � ��$ Center=�64   6E   5      5      .��5      � $	��300��6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� #���   6   ��65   �� *
HeaderText+6V   �� 5   
   $��1��6   .��6   -+Мат. ответственное лицо66   �� 5   
   $��2��6    �� DisplayMemberPath$
 Name��6�   ��6    �� *Responsibles+ �� SelectedItem 6E   �� *SelectedResponsible+ �� Mode$ OneWayToSource=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��3��6   .��6   Материал6'   �� 5    
   $��4��6   $ 
Asset.Name��6�   ��6    �� *StoredAssets+ 6E   �� *SelectedAsset+$ OneWayToSource=�$ PropertyChanged=�6�   �� 5!   
   $��5��6   .��6   Количество6)   %  Xceed.Wpf.Toolkit.IntegerUpDown  5"   
   $��6��6   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Minimum$	 0X�6*   
   Maximum
 66   �� *MaxQuantity+   Value 6V   �� *
Quantity+$ PropertyChanged=�6�   �� 5#   
   $��7��6   .��6   /-Номер акта о перемещении67   �� 5$   
   $��8��6   ��6   �� *	DocNumber+$ PropertyChanged=�6a   �� 5%   
   $��9��6   $
��0 20q�6C   $	��200��6Q   ��6   �� *MoveAssetCommand+.��6]   Переместить6j   5&      5'      