   M S B A M L   `   `   `  ����K  GDemoSharedDialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DemoSharedDialogDemoSharedDialog  5   	   !    DemoSharedDialog.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DemoSharedDialog     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��30q�6    � RowDefinitions 5
   
   �� 5      $
��.15* �6   �� 5      $	��.1* �6   �� 5      $��* �6   �� 5      $	��.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      $��* �6#   �� 5      $
��0.3* �6#   .+�5      �� $��Path : ��6   $��25(�6'   $��0��65   �� 5      -   5        $��	txtBrowse��5      $��25(�6'   $��1��65   �� 5      -   5        $��	btnBrowse��5   4   $��Browse��6   $��25(�6&   $��2��6E   $��5,0,0,0q�6m   5      �� 5   
   -   5        $��	tbDisplay��5      $��25(�6#   $��2��61   �� 5   
   -   5        $��btnSave��5   .   $
��Save��6   $��25(�6    $��3��6=   $	��120��6J   $��Right=�6V   $��0,5,0,0q�6r   6�   5      5       