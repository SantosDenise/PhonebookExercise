   M S B A M L   `   `   `  ����I  EPhoneDirectory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PhoneDirectoryPhoneDirectory  5   	       PhoneDirectory.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PhoneDirectory     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��400* �6   �� 5      $
��400* �6   .+�5   
   �� -   5         ��Name$ lblWellcome��5      $��
Welcome ! ��6%   $
��Left=�6:   $��
345,37,0,0q�6U   $	��Top=�6i   $��Corbel)�6�   $��20(�6�   $	��110��6�   $��1��6�   $��34��6�   $��2��6�   �� 5   
   $
��Left=�6   $	��232��6+   $��	10,42,0,0q�68   $	��Top=�6K   $	��279��6c   $��/Image/PhDir-logo_w.png��6o   $��1��6�   �� 5   
   -   5         ��Name$ 	btnLookup��5      $��Look up Phone No.��6$   $
��Left=�6@   $��
10,172,0,0q�6[   $	��Top=�6o   $��30��6�   $	��112��6�    J� RenderTransformOrigin$ -0.169,4.21&�6�   $��2��6�   6�   �� 5   
   -   5        $ 
btnAddPhNo��5      $��1��6%   $��Add Phone No.��65   $
��Left=�6M   $��244,172,0,0q�6h   $	��Top=�6}   $��30��6�   $	��111��6�   6�   �� 5   
   -   5        $ btnEdit��5      $��2��6"   $��Edit Number��62   $
��Left=�6H   $��
66,381,0,0q�6c   $	��Top=�6w   $��43��6�   $	��111��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgPhoneDirectory��5      $��3��6-   $	��148��6l   $	��Top=�6y   $��80,224,80,0q�6�   �� 5   
   $��	Full Name��6   $
��Left=�6$   $��	20,99,0,0q�6?   $	��Top=�6R   $��26��6j   $��92��6v   $��2��6�   �� 5   
   $��Phone Number��6   $
��Left=�6'   $��
20,134,0,0q�6B   $	��Top=�6V   $��30��6n   $��92��6z   $��2��6�   �� 5   
   -   5         ��Name$ txtFullName��5      $
��Left=�6'   $��200,103,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��2��6�   �� 5   
   -   5        $ 
txtPhoneNo��5      $
��Left=�6&   $��200,134,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��2��6�   �� 5   
   -	   5        $ 	btnUpdate��5      $��2��6$   $��Update��64   $
��Left=�6E   $��224,381,0,0q�6`   $	��Top=�6u   $��41��6�   $��67��6�   6�   �� 5   
   -
   5        $ btnView��5      $��2��6"   $��View all Contacts��62   $
��Left=�6N   $��200,172,0,0q�6i   $	��Top=�6~   $��30��6�   $	��102��6�   6�   �� 5   
   $��New Phone Number��6   $
��Left=�6+   $��
81,385,0,0q�6F   $	��Top=�6Z   $��30��6r   $��92��6~   $��1��6�   �� 5   
   -   5        $ txtPhoneNo_Copy��5      $
��Left=�6+   $��200,391,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��1��6�   5      5      