   M S B A M L   `   `   `  ����W  SThangNPHE151263_FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ThangNPHE151263_FinalProjectThangNPHE151263_FinalProject  5   	   1    +ThangNPHE151263_FinalProject.ProductChoosed   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ThangNPHE151263_FinalProject     5   	     � Title$  ProductChoosed��5   	   $	��450��6    $	��800��6-   .��5	      � $��	0,0,-45,0q�6   $	��410��6   $	��Top=�6+    � ColumnDefinitions 5
   
   �� 5      $
��394* �6   �� 5      $
��451* �6   .+�5   
   �� $��Information��6   $
��Left=�6&   $��	53,24,0,0q�6A   $	��Top=�6T   $��30(�6l   �� 5   
   $��Name:��6   $
��Left=�6    $��
53,110,0,0q�6;   $	��Top=�6O   $��20(�6g   �� 5   
   $��Price:��6   $
��Left=�6!   $��
53,166,0,0q�6<   $	��Top=�6P   $��20(�6h   �� 5   
   $��	Quantity:��6   $
��Left=�6$   $��
53,217,0,0q�6?   $	��Top=�6S   $��20(�6k   �� 5   
   $��Description:��6   $
��Left=�6'   $��
53,275,0,0q�6B   $	��Top=�6V   $��20(�6n   �� 5   
   -   5         ��Name$ DescriptionTextBox��5      $
��Left=�6.   $��212,275,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��493��6�   $��37��6�   $��2��6�   �� 5   
   $!��(Ví dụ: ít đường..)��6   $
��Left=�6.   $��
53,315,0,0q�6I   $	��Top=�6]   �� 5   
   -   5         ��Name$ CancelButton��5      $��Cancel��6'   $
��Left=�68   $��184,328,0,0q�6S   $	��Top=�6h   $��48��6�   $��80��6�   $��1��6�   �� 5   
   -   5        $ ConfirmButton��5      $��Confirm��6(   $
��Left=�6:   $��286,328,0,0q�6U   $	��Top=�6j   $��80��6�   $��48��6�   $��1��6�   �� 5   
   -   5         ��Name$ ProductNameLabel��5      $
��Left=�6+   $��212,110,0,0q�6F   $	��Top=�6[   $��20(�6s   �� 5   
   -   5        $ ProductPriceLabel��5      $
��Left=�6,   $��212,166,0,0q�6G   $	��Top=�6\   $��20(�6t   �� 5   
   -   5        $ QuantityTextBox��5      $��1��6+   $
��Left=�64   $��282,220,0,0q�6O   $	��Top=�6d   $	��334��6|   $��32��6�   $��20(�6�   $��2��6�   �� 5   
   -   5        $ DecrementButton��5      $��-��6*   $
��Left=�66   $��212,221,0,0q�6Q   $	��Top=�6f   $��44��6~   $��32��6�   $��20(�6�   6�   �� 5   
   -   5        $ IncrementButton��5      $��+��6*   $
��Left=�66   $��242,221,0,0q�6Q   $	��Top=�6f   $��44��6~   $��32��6�   $��20(�6�   $��1��6�   5      5      