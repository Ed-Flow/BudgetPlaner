   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    BudgetPlaner    BudgetPlaner.Tagesausgaben   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Tagesausgaben Hinzufugen��5   	   $	��400��6*   $	��400��67   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Tagesausgaben Hinzufugen��6   $��22(�64   $
��Bold"�6B   $��0,0,0,20q�6T   $��Center=�6f   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� $��Datum:��6   $��16(�6&   $��SemiBold"�64   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatumPicker��5      
 �� Now   SelectedDate# Z 6.   5      �� 5   
   $��2��6   $ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� $��Betrag:��6   $��16(�6'   $��SemiBold"�65   �� 5      -   5         ��Name$ BetragTextBox��5      5      �� 5   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5      �� -   5        $��	Speichern��5      $	��100��6A   �� 5       -   5        $��	Abbrechen��5       $	��100��6A   $��10,0,0,0q�6M   5!      5"      5#      