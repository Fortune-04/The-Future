   M S B A M L   `   `   `  ����  	TheFuture    TheFuture.Pages.Networth   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      -   5          N� Title$  Networth��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��400 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��40 20 45 20q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dvData��5         SelectionMode$ Single=�6#      DataGridRowStyle1   RowStyle# �   6e     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridCellStyle1   	CellStyle# �  6�     DataGridStyle1#���  6     Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6-   	   CanUserResize$	 False��68   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6N     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6[      HeaderTemplate 5      �� 5      .R�5   "   �� #��[ 6+   5      5!      0  *System.Windows.Controls.DataGridTextColumn  52      $ ID��6%      
IsReadOnly$
 True��6K   $
 * 6]      Binding 61   �� *_nwid+6]     53      $
 Name��6%   $
 True��6N   $
 * 6`    63   �� *_names+6`     54      $ Value��6%   $
 True��6P   $
 * 6b    64   �� *	_values+6b     55      $
 Date��6%   $
 True��6M   $
 * 6_    63   �� *_date+6_   4  .System.Windows.Controls.DataGridTemplateColumn  56      $ 
Operations��6)   $
 True��6=   $

 auto 6O      CellTemplate 57      �� 58      .R�59      ��  �� Orientation$ 
Horizontal=�6)   .+�5:   "   �� -   5          gridEditButton#��[ 5:   )   .��5;   &   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ PencilOutline=�6<     gridButtonIcon#��[ 6Q   5<   #   �� 5=   "   $��5 0 0 0q�6)     gridRemoveButton#��[ 6:   .��5>   &     $ DeleteOutline=�6<   #��[ 6Q   5?   #   5@      5A      5C      5E      5P      � 5R   
   $��1��6   .+�5S      �� $ 
Horizontal=�6   $��Center=�62   $��	0 20 0 20q�6O   .+�5T      �� -   5        $	��Add��5T   )     topMenuButton#��[ 67   5U      5V      5W      5X      