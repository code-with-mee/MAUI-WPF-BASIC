   M S B A M L   `   `   `  ����I  EDemoSystemTray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DemoSystemTrayDemoSystemTray  5   	       DemoSystemTray.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DemoSystemTray     5   	   _ [Hardcodet.NotifyIcon.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=682384a853a08aad.taskbar http://www.hardcodet.net/taskbar  64     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��btnHide��5
      $
��Hide��6    $��60��6/   $��30��6:   6F   3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  5   
   -   5          Name$ taskbarIcon��5         
IconSource$ Resources/app.ico��63      ToolTipText$ WPF System Tray��6R   $y�Hidden=�6p    � ContextMenu 5      �� 5      .@�5      m� -   5        $��menuShow��5      $
��Show��6/   6=   m� 5      -   5        $��menuExit��5      $
��Exit��6/   6=   5      5      5      5      