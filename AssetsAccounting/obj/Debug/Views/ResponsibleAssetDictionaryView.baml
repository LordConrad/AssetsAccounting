   M S B A M L   `   `   `  ����  AssetsAccounting;    5AssetsAccounting.Views.ResponsibleAssetDictionaryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� 
TargetType   
LabelStyle �� Property �� Value��%�   &	        �� 5	   
   " ��6   .�5
      ��  � ��$ 18(�6)   66   �� 5       � ��$ Center=�64   6E   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� #���   6   ��65   �� *
HeaderText+6V   �� 5   
   $��1��6   $	��300��6"   $��0 0 0 10q�6.   .+�5   
   �� .��6   $"Мат. ответственный6%   �� 5   
    �� DisplayMemberPath$
 Name��6�   ��6   �� *Responsibles+ �� SelectedItem 68   �� *SelectedResponsible+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�6�   5      �� 5   
   $��3��6   ��6    �� *ResponsibleAssets+	 �� View	 5      �� 5      .P�5      �� $��Материал��6%   
 �� DisplayMemberBinding
 67   �� *
Asset.Name+6e   �� 5      $��Количество��6%   
 69   �� *
Quantity+6e   �� 5      $!��Дата получения��6%   
 6=   �� *Date+6e   �� 5       $0��*Номер акта перемещения��6%   
 6E   �� *	DocNumber+6r   5!      5#      5$      5%      