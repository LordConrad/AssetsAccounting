   M S B A M L   `   `   `  ����K  GAssetsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetsAccounting.ViewModelsAssetsAccounting.ViewModels  5      7    1AssetsAccounting.Views.ResponsiblesDictionaryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @
viewModels)clr-namespace:AssetsAccounting.ViewModels     5        � 	Resources  5	       �� 
TargetType   
LabelStyle �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��$ 18(�6)   66   �� 5       � ��$ Center=�64   6E   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   #���   6   ��6B   �� *
HeaderText+6c   �� 5   
   $��1��6    �� DisplayMemberPath$
 Name��6E   ��6    �� *Responsibles+6`   �� 5   
   $��2��6   .+�5      �� $	��100��6�   $
��0 20q�6�   ��6   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" � �� Path$+ %DataContext.AddResponsibleViewCommand�.��6�   Добавить6�   5      5      5      