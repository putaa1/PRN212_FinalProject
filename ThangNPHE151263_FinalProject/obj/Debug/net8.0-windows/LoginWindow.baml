   M S B A M L   `   `   `  ����W  SThangNPHE151263_FinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ThangNPHE151263_FinalProjectThangNPHE151263_FinalProject  5   	   .    (ThangNPHE151263_FinalProject.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ThangNPHE151263_FinalProject     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  LoginWindow��5	   	   $	��450��6   $	��800��6*   .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��50��6*   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��MilkTea Management System��6   $��0��65   $��0,0,0,20q�6B   $��Center=�5      $��Center=�61   $��20(�5      $
��Bold"�6"   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��Center=�69   .+�5      �� $��Enter your username��6   $��0,0,0,5q�63   
�������6D   �� 5      $ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��Center=�69   $��0 0 10 0q�6T   �� 5      -   5         ��Name$ UsernameTextBox��5      $	��200��63   $��Center=�5      $��Stretch=�65   6S   5      5       �� 5#   
   $��2��6   $ Vertical=�6"   $��Center=�69   .+�5$      �� $��Enter your password��6   $��0,0,0,5q�63   
�������6D   �� 5%      $ 
Horizontal=�6   .+�5&        $	 Key=�6*   $��Center=�65   $��0 0 10 0q�6P   G� 5'      -   5         G�Name$ PasswordTextBox��5'      $	��200��67   $��Center=�5(      $��Stretch=�69   5)      5*      �� 5,   
   -   5         ��Name$ LoginButton��5,      $��Login��6&   $��3��66   $��
287,20,0,0q�6C   $
��Left=�5-   2   $��72��6M   ��6   �� *LoginCommand+6X   �� 5/   
   -   5        $ 
QuitButton��5/      $
��Quit��6%   $��3��64   $��
380,20,0,0q�6A   $
��Left=�50   1   $��74��6L   ��6   �� *QuitCommand+6W   51      52      