   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5      !    Expenselt.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Expenselt     5      -   5          N�Name$  	Expenselt��5       N� Title$ ExpenseIt - View Expense��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��1��6    J� RenderTransformOrigin$ 1.385,0.228&�6    � RowDefinitions 5      �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��60 �6    �� 5      $��* �6    .+�5      �� $��36(�6   $
��Bold"�6"   $��
0,16,42,49q�64   
����  �$��2��6Z   .��6k   Expense Report For:6�   � 5      $��3��6   $��
0,0,0,-0.4q�6     5      �� 5      $
��Auto �6$   $��56��62   �� 5       5      �� 5      $��* �6'   �� 5       $��* �6'   5"      �� 5#      $��26(�6   $
��Bold"�6"   $��0,15,0,0q�64   
���   �$��Name: ��6Y   $��1��6j   $��44��6w   �� 5$      $��26(�65   $
��Left=�6C   $��
200,15,0,0q�6^   $��1��6r   $	��Top=�6   $	��190��6�   $��44��6�   $ 0.922,0.646&�6�   ��6   ��  �� XPath$ @Name��6�   �� 5%      $��26(�6   $
��Bold"�6"   $��
0,11,228,5q�64   
���   �$��Department: ��6[   $��2��6r   �� 5&      $��26(�6;   $
��Left=�6I   $��
200,11,0,0q�6d   $��2��6x   $	��Top=�6�   $	��190��6�   $��44��6�   $ 0.922,0.646&�6�   ��6   �� $ @Department��6�   &   System.Windows.Controls.DataGrid  5(      $��3��6      AutoGenerateColumns .     RowHeaderWidth$ 0Q�5)   )   $��0,0,0,209.6q�6<   ��5(   %   �� $ Expense��   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      	   FontSize$	 26Q�6)   ,  &System.Windows.Controls.DataGridColumn
   Header$
 ExpenseType��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� $ @ExpenseType��  5,      $	 26Q�6)   $
 Amount��67    6G   �� $ @ExpenseAmount��5.      5/      ��50   
   �� 51       �� ImageSource$U OD:\Projects\Visual Studio Projects\PS_50_Svetoslav\Expenselt\watermark.png.jpeg��6   53      54      