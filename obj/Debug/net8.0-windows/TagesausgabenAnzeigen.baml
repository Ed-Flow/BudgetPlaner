   M S B A M L   `   `   `  ����  BudgetPlaner(    "BudgetPlaner.TagesausgabenAnzeigen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Tagesausgaben Anzeigen��5   	   $	��400��6(   $	��400��65   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Monat:��6   $��Center=�6&   $��5q�6A   �� 5      -   5         ��Name$ MonatFilter��5      $	��100��6,   $��5q�68   6C   �� 5      $��Jahr:��6   $��Center=�6%   $��5q�6@   �� 5      -   5        $ 
JahrFilter��5      $	��100��6+   $��5q�67   6B   5      �� 5   
   -   5         ��Name$ TagesausgabenListe��5      $��1��6.   $��10q�6;   �� 5   
   -   5         ��Name$ GesamtausgabenTextBlock��5      $��2��5      $��14(�5      $
��Bold"�5      $��10q�5      $��Center=�5      5      5       