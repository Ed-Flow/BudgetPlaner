   M S B A M L   `   `   `  ����  BudgetPlaner"    BudgetPlaner.ProfilErstellen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Neues Profil erstellen��5   	   $	��300��6(   $	��400��65    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Profil erstellen��6   $��16(�6,   $
��Bold"�6:   $��Center=�6L   $��0��6i   $��0,0,0,20q�6v   � 5   
   $��1��6   $��0,0,0,20q�6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��Name:��6   $��0��6%   $��0��62   $��Center=�6B   $��	0,0,10,10q�6]   �� 5!      -   5         ��Name$ NameTextBox��5!      $��0��6+   $��1��68   $��0,0,0,10q�6H   $��30��6Z   $��Center=�6f   �� 5$      $��Monatsgehalt:��6   $��1��6-   $��0��6:   $��Center=�6J   $��	0,0,10,10q�6e   �� 5%      -   5        $ MonatsgehaltTextBox��5%      $��1��63   $��1��6@   $��0,0,0,10q�6P   $��30��6b   $��Center=�6n   �� 5(      $��2��6   $��0��6%   $��Center=�65   $��0,0,10,0q�6P   �� 6d   $�Monatliche Fixkosten��6h   �� 6�    � Language$ de-de�6�   $� ��6�   �� 6�   $�:��6�   6�   �� 5)      -   5        $ FixkostenTextBox��5)      $��2��60   $��1��6=   $��30��6M   $��Center=�6Y   5*      �� 5-   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5.      �� -   5        $��	Erstellen��5.      $��10q�6A   $	��120��6M   �� 5/      -   5        $��	Abbrechen��5/      $��10q�6A   $	��120��6M   50      51      52      