   M S B A M L   `   `   `  ����C  ?EF40Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:EF40Data;assembly=EF40DataEF40Data  5   �    
WPFBinding   WPFBinding.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   C   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   7my(clr-namespace:EF40Data;assembly=EF40Data     6�   -   5          � Title$  Window2��5   	   $	��300��6   $	��300��6&    � 	Resources 5         salesOrderHeaderViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5	   
   � -   5        $��grid1��5	   x    � DataContext# [  6   $
��Left=�6I   $��
31,217,0,0q�6d   $	��Top=�6�    � ColumnDefinitions 5
      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��Account Number:��6   $��0��6.   $��0��6>   $
��Left=�6K   $��3q�6f   $��Center=�6q   �� 5      -   5        $��accountNumberTextBox��5   e   $��1��6   $��0��6&   $��23��63   $
��Left=�6?   $��3q�6Z   $��Center=�6�   $	��120��6�   ��6�   ��  �� Path$ AccountNumber�6�   5      �� 5   
   -   5        $��listBox1��5   M   $	��191��6   $
��Left=�6   $��	12,12,0,0q�6:   $	��Top=�6]   $	��254��6u   5      5      