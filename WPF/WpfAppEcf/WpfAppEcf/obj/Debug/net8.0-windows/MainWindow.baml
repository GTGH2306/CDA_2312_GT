   M S B A M L   `   `   `  ����D  @WpfAppEcf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfAppEcf	WpfAppEcf  5   	       WpfAppEcf.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfAppEcf     5   	     � Title$  InscriptionStagiaireForm��5   	   $	��258��6*   $	��476��67    � 
ResizeMode$ NoResize=�6C   .��5	      � .+�5
   
   � $��10,10,10,10q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��150px �6#   �� 5       � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $
��Nom:��6   $
��Left=�6#   $	��Top=�6>   �� 5      $��1��6   $
��Left=�6&    �� TextWrapping$
 Wrap=�6A   $��Center=�6�   $	��120��6�   ��6U   �� *
LastName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��Prénom:��6   $
��Left=�6&   $	��Top=�6A   $��1��6Y   �� 5      $��1��6   $
��Left=�6&   $
 Wrap=�6A   $��Center=�6�   $	��120��6�   $��1��6�   ��6U   �� *	FirstName+$ PropertyChanged=�6�   �� 5      $��Début de la formation:��6   $
��Left=�65   $	��Top=�6P   $��2��6h   (  "System.Windows.Controls.DatePicker  5       $
��Left=�6j   $	��Top=�6�   $��2��6�   $��1��6�      SelectedDate 6   ��  �� Path$ TrainingBegin�$ PropertyChanged=�6�   �� 5"      $��Fin de la formation:��6   $
��Left=�63   $	��Top=�6N   $��3��6f     5#      $
��Left=�6h   $	��Top=�6�   $��3��6�   $��1��6�    6   �� $ TrainingEnd�$ PropertyChanged=�6�   �� 5%      $��	Formation��6   $
��Left=�6(   $	��Top=�6C   $��4��6[   �� 5'      -   5         ��Name$ trainingsList��5'      $��5��6-   $��2��6e   6y   �� 5)      -   5        $��2��5)   3   $��Valider��6C   $��Center=�6U   $	��Top=�6r   $��50��6�   {�6   �� *	IsValid+6�   5+      5,      5-      