   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          Expenselt.ExpenseltHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Expenselt     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  Expenselt - Home��5
      $��
10,0,10,10q�6    .��5      �  � 	Resources 5   
      ExpenseDataSource � XPath��%�  &	        � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                            <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                            <Expense ExpenseType="Gift" ExpenseAmount="125" />
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                            <Expense ExpenseType="New machine" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="Theo" Department="Marketing">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="James" Department="Management">
                            <Expense ExpenseType="Office stuff" ExpenseAmount="70" />
                            <Expense ExpenseType="Laptop" ExpenseAmount="1000" />
                        </Person>
                        <Person Name="David" Department="Business">
                            <Expense ExpenseType="Meetings" ExpenseAmount="340" />
                            <Expense ExpenseType="Hotel" ExpenseAmount="90" />
                        </Person>
                    </Expenses>        5.      5/       � ColumnDefinitions 50   
   �� 51      $��* �6   �� 52      $��* �6    � RowDefinitions 56   
   �� 57      $
��Auto �6   �� 58      �� 59      $
��Auto �6   �� 5:      ��5=   
   �� 5>       �� ImageSource$U OD:\Projects\Visual Studio Projects\PS_50_Svetoslav\Expenselt\watermark.png.jpeg��6   .+�5@   
   �� $��1��6   .��6    View Expense Report65   �� 5A   
   $��1��6   $��1��6!   $��Center=�6.   $��35��6I    �� Padding$ 5q�6U   ���#4E87D4._�5B      ��   listHeaderTextStyle#��[ 6   
�������.��6T   Names6[   5C      �� 5E   
   -   5        $��peopleListBox��5E   �   $��1��6�   $��2��6�   ��6G   ��  �� Source# [   �� XPath$ Person����5F      �� 5G      .R�5H      �� ��6   �� $ @Name��5I      5K      �� 5L   
   -   5        $��3��5L   c   $��2��6p   $	��125��6�   $��25��6�   $��Right=�6�   $��0,10,0,0q�6�   ��6   �� 	 �� ElementName$	 peopleListBox��
 �� Path$#
 SelectedItem.Attributes[Name]�6�   �� 5M   
   -   5        $��3��5M      $��2��6   $	��125��6.   $��25��6:   $
��Left=�6F   $��0,10,0,0q�6a   .��6�   
Greeting6�   �� 5N   
   $��0��6?   $��2��6O   ��6   �� $
 PersonsChecked�6^   �� 5O   
   $
��Left=�65   $��
10,9.6,0,0q�6P   $��3��6d   $	��Top=�6q   $��34��6�   $	��140��6�   ��6   �� $
 LastChecked�6�   5P       5Q        strTitle��%5   &	       ��5R   
   View Expense Report��6<   5S      5T      