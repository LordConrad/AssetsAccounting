   M S B A M L   `   `   `  ����K  GAssetsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetsAccounting.ConvertersAssetsAccounting.Converters  5	      ;    5AssetsAccounting.Views.IncomingAssetsRegistrationView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      4conv)clr-namespace:AssetsAccounting.Converters  5	        � 	Resources  5
      6   0AssetsAccounting.Converters.StringToIntConverter   StringToIntConverter��%   &	          5   
   6C   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   ��   
LabelStyle#���  6   ��65   �� *
HeaderText+6V   �� 5   
   $��1��6   $	��300��6"   .+�5      �� .��6   -+Наименование материала6,   �� 5       �� DisplayMemberPath$
 Name��6�   ��6   �� *Assets+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6[   �� *SelectedAsset+ �� Mode$ OneWayToSource=�6�   �� 5      .��6   Поставщик6   �� 5      $
 Name��6�   ��6   �� *	Providers+$ PropertyChanged=� 6^   �� *SelectedProvider+$ OneWayToSource=�6�   �� 5      .��6   Количество6    %  Xceed.Wpf.Toolkit.IntegerUpDown  5      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 1X�6a      Maximum$ 99999X�6m      Value 6!   �� *
Quantity+$ PropertyChanged=�6   �� 5      .��6   Номер накладной6%   �� 5      ��6   �� *	DocNumber+$ PropertyChanged=�6X   �� 5      .��6   
Цена6   �� 5      -   5        	 ��Name$	 PriceBox��5      ��6(   �� *Price+$ PropertyChanged=�
 �� 	Converter#
 [   �� ConverterParameter$ PriceBox.Text��6�   �� 5      .��6   Субсчет6   �� 5       ��6   �� *	Invoice+$ PropertyChanged=�6V   �� 5!      .��6   !Дата поступления6&   (  "System.Windows.Controls.DatePicker  5"         SelectedDate 6   �� *Date+$ PropertyChanged=�6^   5#      �� 5$   
   $��2��6   $
��0 20q�6J   $	��100��6X   ��6   �� *AddIncomingAssetCommand+.��6d   Сохранить6o   5%      5&      