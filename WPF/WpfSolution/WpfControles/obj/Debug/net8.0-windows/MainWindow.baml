   M S B A M L   `   `   `  ����G  CWpfControles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfControlesWpfControles  5   	       WpfControles.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfControles     5   	   -   5          � Title$  
MainWindow��5   	   $	��366��6   $	��454��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%R  '��       �� 5
   
   " ��6   .�5      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� �� 5      ��6+   �� ��5   "   �� 5   &   .R�5   *   �� 
���  ��$��5q�6u   ��64   �� * (ValidationError.ErrorContent)+6u   5   '   5      5      5      5      5      5      .��5      � .+�5   
   �� $	��Nom��6   $
��Left=�6   $��	10,26,0,0q�69   $	��Top=�6L   �� 5   
   $
��Left=�6R   $��	88,30,0,0q�6m    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��149��6�   ��6   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5    
   $
��Date��6   $
��Left=�6   $��	10,77,0,0q�6:   $	��Top=�6M   �� 5!   
   $��Montant��6   $
��Left=�6"   $��
10,128,0,0q�6=   $	��Top=�6Q   �� 5"   
   $
��Left=�6U   $��
88,132,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��101��6�   ��6   �� $ Amount�$ PropertyChanged=�6�   �� 5#   
   $��Code Postal��6   $
��Left=�6&   $��
10,178,0,0q�6A   $	��Top=�6U   �� 5$   
   $
��Left=�6U   $��
88,182,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $��78��6�   ��6   �� $ ZipCode�$ PropertyChanged=�6�   �� 5%   
   -   5        $��Valider��5%   =   $
��Left=�6O   $��190,245,0,0q�6j   $	��Top=�6   $��61��6�   {�6   �� *ButtonValidateEnabled+6�   �� 5&   
   -   5        $��Effacer��5&      $
��Left=�6#   $��190,270,0,0q�6>   $	��Top=�6S   $��61��6k   6v   (  "System.Windows.Controls.DatePicker  5'   
   $
��Left=�6]   $��	88,78,0,0q�6x   $	��Top=�6�      SelectedDate 6   �� $
 Date�$ PropertyChanged=�6�   5)      5*      