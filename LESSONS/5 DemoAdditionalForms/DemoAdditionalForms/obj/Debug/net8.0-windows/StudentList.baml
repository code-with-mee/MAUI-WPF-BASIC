   M S B A M L   `   `   `  ����N  JDemoAdditionalForms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:_27_Databinding_27_Databinding  5   	   !    _27_Databinding.StudentList   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:_27_Databinding     5   	     � Title$  StudentList��5   	   $	��450��6   $	��600��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 dgv��5         AlternatingRowBackground
 ����� �� AlternationCount$ 2��5         AutoGenerateColumns$ False��5      $��2��6/      CanUserAddRows$ False��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.2* 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6H     5      $
 Name��6%   $
	 0.4* 6L   
 63   �� *Name+6L     5      $ Phone��6%   $
	 0.4* 6N   
 64   �� *Phone+6N     5      $ Address��6%   $	 * 6R   
 66   �� *	Address+6R   5      5      5      