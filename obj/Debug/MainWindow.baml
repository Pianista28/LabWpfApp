   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ViewModelWpfApp1.ViewModel  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	ViewModelclr-namespace:WpfApp1.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � DataContext 5
      ,   &WpfApp1.ViewModel.ApplicationViewModel  5   
   .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��Articles��5      $��2q�6#    �� DisplayMemberPath$ Title��6y    �� Text$ Select Option��6�   ��6.   ��  �� Path$ Articles� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedArticle+	 �� Mode$	 TwoWay=�6�   �� 5   
   $��1��6   $��2q�6%   
 �� Orientation$
 
Horizontal=�61   $��Center=�6J   .+�5      �� -   5        $��ArticleButton��5      $��0,0,10,0q�6*   .��6Y   Dodaj Artykuł6h   �� 5      -   5        $��CommentButton��5      $��10,0,0,0q�6*   .��6Y   Dodaj Komentarz6j   5      �� 5   
   $��1��6   $
��Wrap=�6J   ��6!   �� *SelectedArticle.Content+6`   �� 5   
   -   5        $��CommentList��5      $ Content��6   $��1��6�   $��1��6�   $��Stretch=�6�   $��Visible=�6�   ��6'   �� $ Comments�$ PropertyChanged=�$	 TwoWay=�6  5      5      