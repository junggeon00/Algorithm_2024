   M S B A M L   `   `   `  ����D  @Fibonacci, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Fibonacci	Fibonacci  5   	       Fibonacci.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Fibonacci     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��669��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��44* �6   �� 5      $
��505* �6   �� 5      $
��251* �6   .+�5   
   �� $
��Left=�6   $��	24,54,0,0q�6/   $
��Wrap=�6B   $8��2다음 항 까지의 피보나치 수열을 계산��6V   $	��Top=�6r   $��1��6�   �� 5   
   -   5         ��Name$ txtInput��5      $��Center=�6$   $
��Left=�5      $��
22,103,0,0q�6(    �� TextWrapping$
 Wrap=�6<   $	��Top=�6P   $	��120��6h   $��1��6�   �� 5   
   -   5        $��계산��5      $
��Left=�6   $��172,102,0,0q�69   $	��Top=�6N   $��55��6f   $��1��6�   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�5      $	��234��6(   $��
22,158,0,0q�65   $	��Top=�6I   $	��205��6a   $��1��6�   5      5      