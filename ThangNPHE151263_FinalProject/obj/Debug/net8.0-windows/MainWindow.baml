   M S B A M L   `   `   `  ����W  SThangNPHE151263_FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ThangNPHE151263_FinalProjectThangNPHE151263_FinalProject  5   	   -    'ThangNPHE151263_FinalProject.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ThangNPHE151263_FinalProject     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��540��5      $
��1080��6'   
�������  � 
ResizeMode$  NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]    � WindowStyle$
 None=�6�   .��5	      � ���	#FFDEDEDE.+�5
   
   � -   5         �Name$ GridMain��5
      $
��Left=�6!   $��Center=�6<   $	��520��6W   $
��1010��6d   $��70,0,0,0q�6q   � 5   
   $��60��6   $	��Top=�6   ���	#FF5C99D6.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ LoginEmpNameTextBox��5      $��Center=�6W   $��14(�6r   ��69   �� *EmployeeName+6r   �� 5      -   5         ��Name$ LogoutButton��5      $��Logout��6/   $	��105��6[   $��27��6g   5      �� 5      $��Center=�6   $��Center=�65   $��22(�6P   
Checkout6h   5      � 5   
   -   5        $ GridContent��5      $��Right=�6$   $��Bottom=�6@   $	��465��6[   $
��1005��6h   $��0,0,0,10q�6u   .+�5      � -   5        $ GridProductOrder��5      $��
10,10,10,0q�6-    J� RenderTransformOrigin$ 0.732,0.805&�6A    � ColumnDefinitions 5      �� 5      $	��61* �6'   �� 5      $
��515* �6'   �� 5      $
��434* �6'   .+�5      �� ���#EAEAEA$��0,0,0,10q�6.   	 �� Padding$	 10q�6@   $��Center=�6M   $	��542��6j   $��2��6v   ._�5      �� $��Center=�6!   $	��522��6>   .+�5      �� $��Product��6$   $��20(�63   $��Center=�6A   $��0 0 0 10q�6^   
���   �6p   �� 5      $
��Auto=�6'   $��Disabled=�6J   .��5      �� -   5        
 ��Name$
 ListViewProduct��5   '   
�������$	��400��5   '   $��Stretch=�64   ��5    "   �� 5!   &   .R�5"   *   A�  A� Columns$ 4��66   5#   '   ��5%   "   �� 5&   &   .R�5'   *   �� ���#CCCCCC$��1q�6G   $��5q�6[   ._�5(   .   �� .+�5)   2   �� $	��100��68   $	��100��6D   $��UniformToFill=�6h   ��6Q   �� *Img+6h   �� 5*   2   $	��5 3q�6R   $��Center=�6_   ��6<   �� *Name+6_   �� 5+   2   $	��5 3q�6W   $��Center=�6d   ��6<   �� *	UnitPrice+6d   5,   /   5-   +   5.   '   ��50   "   �� 51   &    �� 
TargetType" ��6,   .�52   *   ��  �� Property � �� �� Value$ Stretch=�6W   �� 53   *    � ��$ Center=�6U   54   '   56      57      58      59      �� 5<      $��2��6   ���#EAEAEA$��	10,0,10,0q�6>   $	 10q�6Q   ._�5=      �� .+�5>      �� -   5         ��Name$ TableChoosedTextBlock��5>       $��20(�6?   $��Center=�6M   $��0 0 0 10q�6j   �� 5?      $
��Auto=�6'   .��5@      �� -	   5        $
 ListViewOrder��5@   '   ���#FFFFFF �� View 5A   "   �� 5B   &   .P�5C   *   �� $
��Name��69    �� Width$
 Auto��6G    �� DisplayMemberBinding 6T   �� *IdProductNavigation.Name+�� 5D   *   $��Price��69   $
 Auto��6H    6U   �� *	UnitPrice+�� 5E   *   $��Quantity��69   $
 Auto��6K    6X   �� *
Quantity+�� 5F   *   $��Total��69   $
 Auto��6H    6U   �� *	IntoMoney+�� 5G   *   $��Description��69   $
 Auto��6N    6[   �� *Description+�� 5H   *   $��Action��69   $
 Auto��6I    �� CellTemplate 5I   .   �� 5J   2   .R�5K   6   �� -
   5        $��Delete��5K   =   6N   5L   3   5N   +   5O   '   5Q      5R      �� 5T      -   5        $��Checkout��5T   !   $��Right=�64   $��Bottom=�6P   $��0,10,0,0q�6k   6}   5U      5V      5X      5Y      � 5Z   
   -   5        $ GridMenu��5Z      $��70��6!   $
��Left=�6,   ���	#FF31577E J� Effect 5[      3  -System.Windows.Media.Effects.DropShadowEffect  5\         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFAEAEAE��6B   5^      5_      5`      