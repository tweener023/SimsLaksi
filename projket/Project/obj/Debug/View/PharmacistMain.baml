   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Project.ViewProject.View  5   	   !    Project.View.PharmacistMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Project.View     5   	     � Title$  Apotekar��5   	   $��786.4��6   $��802.4��6)   .��5	      � $��0,0,0,16q�6    � RowDefinitions 5
   
   �� 5      $	��92* �6   �� 5      $	��13* �6   .+�5   
   �� $
��Left=�6   $	��749��60   $	��Top=�6=   $	��792��6U   $��
0,0,0,-329q�6a   $��2��6u   .@�5      �� $��Lekovi��6   ���	#FF8585B1.��5      � ���	#FFAEAEEA � ColumnDefinitions 5      �� 5      $	��12* �6+   �� 5      $	��23* �6+   �� 5      $
��227* �6+   .+�5      �� $��3��6!   .+�5      ]� $��5q�6$   .+�5      �� $	��150��6$   .��60   Pretrazi po sifri:6D   �� 5      -   5         ��Name$ searchByCode��5   &   $	��150��6<   $
��Left=�6H   $��5,0,0,0q�6c   .��6t   54526z   �� 5      -   5        $	��100��5   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5      ]� 5      $��5q�6$   .+�5      �� $	��150��6$   .��60   Pretrazi po imenu:6D   �� 5      -   5        $ searchByName��5   &   $	��150��6<   $
��Left=�6H   $��5,0,0,0q�6c   .��6t   Brufen6|   �� 5      -   5        $	��100��5   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5       ]� 5!      $��5q�6$   .+�5"      �� $	��150��6$   .��60   Pretraga po proizvodjacu:6K   �� 5#      -   5        $ searchByManufacturer��5#   &   $	��150��6D   $
��Left=�6P   $��5,0,0,0q�6k   $��Hemofarm��6|   �� 5$      -   5        $	��100��5$   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5%      ]� 5&      $��5q�6$   .+�5'      �� $	��150��6$   .��60   Pretraga po ceni:6C   �� 5(      -   5        $ searchByPriceFrom��5(   &   $��72��6A   $
��Left=�6L   $��5,0,0,0q�6g   $��3��6x   �� 5)      -   5        $ searchByPriceTo��5)   &   $��72��6?   $
��Left=�6J   $��5,0,0,0q�6e   $��10��6v   �� 5*      -	   5        $	��100��5*   %   $
��Left=�61   $��6,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5+      ]� 5,      $��5q�6$   .+�5-      �� $	��150��6$   .��60   Pretraga po kolicini:6G   �� 5.      -
   5        $ searchByAmount��5.   &   $	��150��6>   $
��Left=�6J   $��5,0,0,0q�6e   .��6v   156z   �� 5/      -   5        $	��100��5/   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   50      ]� 51      $��5q�6$   .+�52      �� $	��150��6$   .��60   Pretraga po sastojcima:6I   �� 53      -   5        $ searchByIngredient��53   &   $	��150��6B   $
��Left=�6N   $��5,0,0,0q�6i   $��sicilijum-dioksid��6z   �� 54      -   5        $	��100��54   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   �� 55      -   5        ���	#FF8585B1$��
Obrisi lek��55   <   $��Right=�6Q   $	��111��6m   6y   56      57      &   System.Windows.Controls.DataGrid  58      -   5          Name$ medicineDataGrid��58         AutoGenerateColumns .     
IsReadOnly . $��10,232,0,20q�5:   /   $	��766��6D   $
��Left=�6P   $��3��6k   ���	#FF8585B1   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Sifra��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5=      �� *Code+  5>      $	 Ime��61   	 5?      �� *Name+  5@      $ Proizvodjac��61   	 5A      �� *Manufacturer+  5B      $
 Cena��61   	 5C      �� *Price+  5D      $ Kolicina��61   	 5E      �� *Amount+  5F      $ Obrisan��61   	 5G      �� *	Deleted+4  .System.Windows.Controls.DataGridTemplateColumn  5H      $ Sastojci��65   
   CellTemplate
 5I   "   �� 5J   &   .R�5K   *   ��  �� DisplayMemberPath$
 Name��6[   ��67   �� *Ingredients+6[   5L   '   5N      5P      5Q      5R      �� 5T      $��Sastojci��6   ���	#FF8585B1.��5U      � ���	#FFAEAEEA 5V      �� 5W      .+�5Y      �� .+�5Z      ]� $��5q�6$   .+�5[      �� $	��130��6$   .��60   Pretraga po imenu:6D   �� 5\      -   5        $ searchIngredientByName��5\   &   $	��150��6F   $
��Left=�6R   $��5,0,0,0q�6m   .��6~   kofein6�   �� 5]      -   5        $	��100��5]   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5^      ]� 5_      $��5q�6$   .+�5`      �� $	��130��6$   .��60   Pretraga po opisu:6D   �� 5a      -   5        $# searchIngredientByDescription��5a   &   $	��150��6M   $
��Left=�6Y   $��5,0,0,0q�6t   .��6�   Some description idk6�   �� 5b      -   5        $	��100��5b   %   $
��Left=�61   $��5,0,0,0q�6L   $��Pretrazi��6]   ���	#FF8585B16�   5c      ]� 5d      $��5q�6$   .+�5e      �� $	��130��6$   .��60   Pretraga po leku:6C   �� 5f      -   5         ��Name$ medicineCombo��5f   D   $	��150��6'   $��5,0,0,0q�63   ��5g   "   �� 5h   &   .R�5i   *   ��  �� Orientation$ 
Horizontal=�65   .+�5j   .   �� ��68   ��  �� Path$
 Name�6U   5k   +   5l   '   5n      �� 5o      -   5        $	��100��5o   %   $
��Left=�61   $��5,0,0,0q�6L   $��Search��6]   ���	#FF8585B16�   5p      5q        5r      -   5        $ ingredientsDataGrid��5r       .   . $��10,130,0,122q�5t   /   $	��388��6E   $
��Left=�6Q   ���	#FF8585B1 5u        5v      $	 Ime��61   	 5w      �� *Name+  5x      $
 Opis��61   	 5y      �� *Description+  5z      $ Kolicina��61   	 5{      �� *CountInMedicines+5}      5~      5      �� 5�      $��	Dodaj lek��6   ���	#FF8585B1.��5�      � ���	#FFAEAEEA.+�5�      �� .+�5�      ]� $��5q�6$   .+�5�      �� $��90��6$   .��6/   Sifra:67   �� 5�      -   5        $ registerCodeBox��5�   &   $	��150��6@   $
��Left=�6L   $��5,0,0,0q�6g   5�      ]� 5�      $��5q�6$   .+�5�      �� $��90��6$   .��6/   Ime:65   �� 5�      -   5        $ registerNameBox��5�   &   $	��150��6@   $
��Left=�6L   $��5,0,0,0q�6g   5�      ]� 5�      $��5q�6$   .+�5�      �� $��90��6$   .��6/   Proizvodjac:6=   �� 5�      -   5        $ registerManufacturerBox��5�   &   $	��150��6H   $
��Left=�6T   $��5,0,0,0q�6o   5�      ]� 5�      $��5q�6$   .+�5�      �� $��90��6$   .��6/   Cena:66   �� 5�      -   5        $ registerPriceBox��5�   &   $	��150��6A   $
��Left=�6M   $��5,0,0,0q�6h   5�      ]� 5�      $��5q�6$   .+�5�      �� $��90��6$   .��6/   	Kolicina:6:   �� 5�      -   5        $ registerAmountBox��5�   &   $	��150��6B   $
��Left=�6N   $��5,0,0,0q�6i   5�      ]� 5�      $��5q�6$   .+�5�      �� $��90��6$   .��6/   	Sastojci:6:   �� 5�      -   5        $ registerIngredientsBox��5�   &   $��prvi,drugi,treci��6F   $	��150��6^   $
��Left=�6j   $��5,0,0,0q�6�   5�      �� 5�      -   5        $��Dodaj��5�   !   $��70��61   $
��Left=�6<   ���	#FF8585B1$��5q�6n   6y   5�      5�      5�      �� 5�      $ ��Prihvaceni/odbijeni lekovi��6   ���	#FF8585B1.��5�      � ���	#FFAEAEEA.+�5�      �� .+�5�      �� $��Prihvaceni lekovi��6      5�      -   5        $ acceptedMedicineDataGrid��5�   #   $
��Left=�6E    .  $	��400��5�   =    . $��3��5�   3   $	��106��6G   ���	#FF8585B1 5�        5�   "   $ Sifra��65   	 5�   !   �� *Code+  5�   "   $	 Ime��65   	 5�   !   �� *Name+  5�   "   $ Proizvodjac��65   	 5�   !   �� *Manufacturer+  5�   "   $
 Cena��65   	 5�   !   �� *Price+  5�   "   $ Kolicina��65   	 5�   !   �� *Amount+  5�   "   $ Obrisan��65   	 5�   !   �� *	Deleted+  5�   "   $ Sasrojci��69   
 5�   &   �� 5�   *   .R�5�   .   �� $
 Name��6_   ��6;   �� *Ingredients+6_   5�   +   5�   #   5�      �� 5�      $��Odbijeni lekovi��6      5�      -   5        $ rejectedMedicineDataGrid��5�   #    .  $
��Left=�5�   =   $	��400��6X    . $��3��5�   3   $	��121��6G   ���	#FF8585B1 5�        5�   "   $ Sifra��65   	 5�   !   �� *Code+  5�   "   $	 Ime��65   	 5�   !   �� *Name+  5�   "   $ Proizvodjac��65   	 5�   !   �� *Manufacturer+  5�   "   $
 Cena��65   	 5�   !   �� *Price+  5�   "   $ Kolicina��65   	 5�   !   �� *Amount+  5�   "   $ Obrisan��65   	 5�   !   �� *	Deleted+  5�   "   $ Sastojci��69   
 5�   &   �� 5�   *   .R�5�   .   �� $
 Name��6_   ��6;   �� *Ingredients+6_   5�   +   5�   #   5�      5�      �� 5�      $��Right=�6!   $	��373��6=   .+�5�      ]� .+�5�      	� -    5         	�Name$ acceptedRadio��5�   *    	� 	GroupName$ searchRadio��6A   $��Pretrazi odobrene��6Y    d� 	IsChecked$
 TrueY�6u   	� 5�      -!   5        $ rejectedRadio��5�   *   $ searchRadio��6A   $��Pretrazi odbijene��6Y   $��15,0,0,0q�6u   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po sifri:6D   �� 5�      -"   5        $ searchByCodeRA��5�   &   $	��100��6>   $
��Left=�6J   $��5,0,0,0q�6e   .��6v   54526|   �� 5�      -#   5        $��65��5�   %   $
��Left=�60   $��5,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po imenu:6D   �� 5�      -$   5        $ searchByNameRA��5�   &   $	��100��6>   $
��Left=�6J   $��5,0,0,0q�6e   .��6v   Brufen6~   �� 5�      -%   5        $��65��5�   %   $
��Left=�60   $��5,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po proizvodjacu:6K   �� 5�      -&   5        $ searchByManufacturerRA��5�   &   $	��100��6F   $
��Left=�6R   $��5,0,0,0q�6m   .��6~   Idk6�   �� 5�      -'   5        $��65��5�   %   $
��Left=�60   $��5,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po ceni:6C   �� 5�      -(   5        $ searchByPriceFromRA��5�   &   $��47��6C   $
��Left=�6N   $��5,0,0,0q�6i   .��6z   From6�   �� 5�      -)   5        $ searchByPriceToRA��5�   &   $��47��6A   $
��Left=�6L   $��5,0,0,0q�6g   .��6x   To6|   �� 5�      -*   5        $��65��5�   %   $
��Left=�60   $��6,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po kolicini:6G   �� 5�      -+   5        $ searchByAmountRA��5�   &   $	��100��6@   $
��Left=�6L   $��5,0,0,0q�6g   .��6x   156|   �� 5�      -,   5        $��65��5�   %   $
��Left=�60   $��5,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      ]� 5�      $��5q�6$   .+�5�      �� $	��150��6$   .��60   Pretraga po sastojcima:6I   �� 5�      --   5        $ searchByIngredientRA��5�   &   $	��100��6D   $
��Left=�6P   $��5,0,0,0q�6k   $��sicilijum-dioksid��6|   �� 5�      -.   5        $��65��5�   %   $
��Left=�60   $��5,0,0,0q�6K   $��Pretrazi��6\   ���	#FF8585B16�   5�      5�      5�      5      5     5     5     