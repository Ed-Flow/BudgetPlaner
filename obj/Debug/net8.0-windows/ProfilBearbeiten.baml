   M S B A M L   `   `   `  ����  BudgetPlaner#    BudgetPlaner.ProfilBearbeiten   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Profil Bearbeiten��5   	   $	��350��6#   $	��400��60   ���	#FFF8F8F8 � WindowStartupLocation$ CenterScreen=�5       .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Profil Bearbeiten��6!   $��22(�6:   $
��Bold"�6H   ���	#FF333333$��0,0,0,15q�6q   $��Center=�6�   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� $��Name:��6   $��16(�6%   $��SemiBold"�63   ���	#FF3333336I   �� 5      -   5         ��Name$ NameTextBox��5      $��30��6+   $��14(�67   5      �� 5   
   $��2��6   $ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� $��Monatliches Gehalt:��6   $��16(�63   $��SemiBold"�6A   ���	#FF3333336W   �� 5      -   5        $ GehaltTextBox��5      $��30��6-   $��14(�69   5      �� 5"   
   $��3��6   $ Vertical=�6"   $��0,0,0,20q�69   .+�5#      �� $��16(�6   $��SemiBold"�6&   ���	#FF333333�� 6U    � Language$ de-de�6Y   $�Monatliche ��6j   �� 6   $�
Fixkosten:��6�   6�   �� 5$      -   5        $ FixkostenTextBox��5$      $��30��60   $��14(�6<   5%      �� 5(   
   $��4��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5)      �� -   5        $��	Speichern��5)      $	��100��6)   $��35��65   $��14(�6A   $
��Bold"�6O   ���	#FFFF7043
�������$��	10,0,10,0q�6�   6�   �� 5*      -   5        $��	Abbrechen��5*      $	��100��6)   $��35��65   $��14(�6A   $
��Bold"�6O   ���	#FFFF7043
�������6�   5+      5,      5-      