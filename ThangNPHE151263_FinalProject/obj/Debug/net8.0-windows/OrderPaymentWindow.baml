   M S B A M L   `   `   `  ����   ThangNPHE151263_FinalProject5    /ThangNPHE151263_FinalProject.OrderPaymentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Order Payment��5   	   $	��438��6   $	��807��6,   .��5      � $��0,0,0,31q�6   .+�5   
   �� $��Order Information��6   $
��Left=�6,   $��	53,24,0,0q�6G   $	��Top=�6Z   $��30(�6r   �� 5   
   -   5         ��Name$ ListViewOrderDetails��5      $��53,70,53,120q�61    �� View 5      �� 5	      .P�5
      �� $
��Name��6%    �� Width$
 Auto��63    �� DisplayMemberBinding 6@   �� *IdProductNavigation.Name+�� 5      $��Price��6%   $
 Auto��64    6A   �� *	UnitPrice+�� 5      $��Quantity��6%   $
 Auto��67    6D   �� *
Quantity+�� 5      $��Total��6%   $
 Auto��64    6A   �� *	IntoMoney+�� 5      $��Description��6%   $
 Auto��6:    6G   �� *Description+5      5      �� 5   
   -   5         ��Name$ TotalAmountTextBlock��5      $��Total Amount: ��62   $
��Left=�6H   $��
53,332,0,0q�6c   $	��Top=�6w   $��20(�6�   �� 5   
   -   5         ��Name$ CancelButton��5      $��Cancel��6'   $
��Left=�68   $��554,332,0,0q�6S   $	��Top=�6h   $��77��6�   $��48��6�   6�   �� 5   
   -   5        $ ConfirmButton��5      $��Confirm��6(   $
��Left=�6:   $��664,332,0,0q�6U   $	��Top=�6j   $��77��6�   $��48��6�   6�   5      5      