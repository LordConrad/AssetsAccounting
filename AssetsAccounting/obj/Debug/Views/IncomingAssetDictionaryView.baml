   M S B A M L   `   `   `  ����K  GAssetsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetsAccounting.ConvertersAssetsAccounting.Converters  5      8    2AssetsAccounting.Views.IncomingAssetDictionaryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @
converters)clr-namespace:AssetsAccounting.Converters     5        � 	Resources  5	      9   3AssetsAccounting.Converters.DateTimeToDateConverter   DateConverter��%   &	          5
   
   6E   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   ��   
LabelStyle#���  6   ��65   �� *
HeaderText+6V   �� 5   
   $��1��68   ��6   �� *StoredAssets+ �� View 5      �� 5      P�5      �� 5      $��Материал��6)    �� DisplayMemberBinding 6;   �� *
Asset.Name+6i   �� 5      $��Поставщик��6)    6<   �� *Provider.Name+6m   �� 5      $%��Дата поступления��6)    6C   �� *Date+ �� 	Converter# [  6�   �� 5      $��Количество��6)    6=   �� *
Quantity+6i   �� 5      $��Цена��6)    67   �� *Price+6`   �� 5      $��Субсчет��6)    6:   �� *	Invoice+6e   �� 5      $#��Номер накладной��6)    6B   �� *	DocNumber+6o   5      5       5!      5"      