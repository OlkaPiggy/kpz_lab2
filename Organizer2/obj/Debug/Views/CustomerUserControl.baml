   M S B A M L   `   `   `  ????E  AOrganizer2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Organizer2.ViewsOrganizer2.Views  5      ;"clr-namespace:Organizer2.ConvertorOrganizer2.Convertor  6;   *    $Organizer2.Views.CustomerUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Organizer2.Views     5      8	Converter"clr-namespace:Organizer2.Convertor     6;     ? 	Resources  5	      .   (Organizer2.Convertor.ImagesPathConvertor   my:ImagesPathConvertor??%   &	          5
   
   6(   5      .??5      ? $
??auto??6    ? RowDefinitions 5   
   ?? 5      $??* ?6   6)   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,   .+?5   
   ?? $??0??6   .+?5      &   System.Windows.Controls.DataGrid  -   5        $??dataGrid??5   \      AutoGenerateColumns .  $
??auto??63   $
??Left=?6A   $	??Top=?6l   $
??auto??6?   ??6?   ??  ?? Path$ 	Customers? ?? SelectedItem 6?   ?? $ SelectedCustomer? ?? Mode$ TwoWay=?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Email??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ?? $ Email?$ TwoWay=?  5      $
 Name??6)    67   ?? $
 Name?$ TwoWay=?  5      $ Surname??6)    6:   ?? $ Surname?$ TwoWay=?4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 age??6-   	   CellTemplate	 5      ?? 5      .R?5   "   ?? $??48??6(   $??48??63   ??6?   ?? *age+
 ?? 	Converter#
 [   ?? ConverterParameter$	 age??5      5!      5$      5%      ?? 5'   
   $??1??6    ?? Orientation$ 
Horizontal=?6"   .+?5(      ?? $
??baby??6   $??50??6N   $	??100??6Z   $??5q?6f   ??6$   ?? $ ChangeAgeToChild?6f   ?? 5)      $??young??6   $??50??6O   $	??100??6[   $??5q?6g   ??6%   ?? $ ChangeAgeToYoung?6g   ?? 5*      $??adult??6   $??50??6P   $	??100??6\   $??5q?6h   ??6%   ?? $ ChangeAgeToMidAge?6h   ?? 5+      $	??old??6   $??50??6K   $	??100??6W   $??5q?6c   ??6#   ?? $ ChangeAgeToOld?6c   5,      5=      5>      