   M S B A M L   `   `   `  ����  AssetsAccounting8    2AssetsAccounting.Views.TrashedAssetsDictionaryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� 
TargetType   
LabelStyle �� Property �� Value��%�   &	        �� 5	   
   " ��6   .�5
      ��  � ��$ 18(�6)   66   �� 5       � ��$ Center=�64   6E   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   #���   6   ��6B   �� *
HeaderText+6c   �� 5   
   $��1��6   ��6    �� *TrashedAssets+ �� View 5      �� 5      P�5      �� 5      $��Материал��6)    �� DisplayMemberBinding 6;   �� *
Asset.Name+6i   �� 5      $��Поставщик��6)    6<   �� *Provider.Name+6m   �� 5      $%��Дата поступления��6)    6C   �� *Date+6k   �� 5      $��Дата списания��6)    6@   �� *TrashedDate+6o   �� 5      $��Количество��6)    6=   �� *
Quantity+6i   �� 5      $-��'Номер акта о списании��6)    6H   �� *	DocNumber+6u   5      5!      5"      5#      