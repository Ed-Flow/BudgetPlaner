   M S B A M L   `   `   `  ����  BudgetPlaner     BudgetPlaner.ProfilAuswahl   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Profil Auswahl��5   	   $	��400��6    $	��450��6-   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� $��Profile��6   $��16(�6#   $
��Bold"�61   $��10q�6C   �� 5   
   -   5         ��Name$ ProfileListe��5      $��1��6(   $��10q�65    �� DisplayMemberPath$
 Name��6A   � 5   
   $��2��6   $��10q�6   $��Center=�6(    � Cursor$  ��6E    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� -   5         ��Name$ ProfilAuswaehlenButton��5      $��Profil auswählen��65   $��5q�6t   $��0��5      $��0��6   �� 5!      -   5        $ ProfilBearbeitenButton��5!      $��Profil bearbeiten��65   $��5q�6p   $��0��5"      $��1��6   �� 5%      -   5        $ ProfilLoeschenButton��5%      $��Profil löschen��63   $��5q�6n   $��1��5&      $��0��6   �� 5)      -   5        $ NeuesProfilButton��5)      $��Neues Profil erstellen��60   $��5q�6t   $��1��5*      $��1��6   5+      5,      5-      