   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	   $    WpfApp1.AddArticleDialogWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	ViewModelclr-namespace:WpfApp1.ViewModel     5   	   -   5        $��
ThisWindow��5	   A     � Title$  AddArticleDialogWindow��6	   $	��300��6(   $	��300��65    � DataContext 5
      ,   &WpfApp1.ViewModel.ApplicationViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   6,   .+�5   
   ]� .+�5      �� -   5        $��Title��5      $��5q�6"   .��6-   Tytuł64   �� 5      $
��Auto��6   $��5q�6#   $��Stretch=�6.   ��6J   �� *NewArticleTitle+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5   
   $��10q�6   $��1��6    ��6-   �� *NewArticleText+$ PropertyChanged=�6t   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5        $��AnulujA��5      $	��120��6$   $��10q�60   .��6X   Anuluj6`   �� 5      -   5        $��DodajA��5      $	��120��6#   $��10q�6/   ��6;   �� *AddArticleCommand+��6a   ��  �� ElementName$ 
ThisWindow��.��6�   Dodaj6�   5      5      5      