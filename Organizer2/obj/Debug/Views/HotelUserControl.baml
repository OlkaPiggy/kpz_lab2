   M S B A M L   `   `   `  ????E  AOrganizer2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Organizer2.ViewsOrganizer2.Views  5      ;"clr-namespace:Organizer2.ConvertorOrganizer2.Convertor  6;   '    !Organizer2.Views.HotelUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Organizer2.Views     5      8	Converter"clr-namespace:Organizer2.Convertor     6;     ? 	Resources  5	      .   (Organizer2.Convertor.ImagesPathConvertor   my:ImagesPathConvertor??%   &	          5
   
   6(   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   6)   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,   .+?5   
   ?? $??0??6   .+?5      &   System.Windows.Controls.DataGrid  -   5        $??dataGrid??5   \      AutoGenerateColumns .  $
??auto??63   $
??Left=?6A   $	??Top=?6l   $
??auto??6?   ??6?   ??  ?? Path$ Hotels? ?? SelectedItem 6?   ?? $ SelectedHotel? ?? Mode$ TwoWay=?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? $
 Name?$ TwoWay=?  5      $ Address??6)    6:   ?? $ Address?$ TwoWay=?  5      $ Price??6)    68   ?? $ Price?$ TwoWay=?  5      $ 
CountRooms??6)    6=   ?? $ 
CountRooms?$ TwoWay=?4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Type??6-   	   CellTemplate	 5      ?? 5       .R?5!   "   ?? $??48??6(   $??48??63   ??6?   ?? *Type+
 ?? 	Converter#
 [   ?? ConverterParameter$
 Type??5"      5$      5&      5'      ?? 5(   
   $??1??6    ?? Orientation$ 
Horizontal=?6"   .+?5)      ?? $??Hotel??6   $??50??6W   $	??100??6c   $??5q?6o   ??6%   ?? $ ChangeTypeOfHotelToHotel?6o   ?? 5*      $??Hostel??6   $??50??6Y   $	??100??6e   $??5q?6q   ??6&   ?? $ ChangeTypeOfHotelToHostel?6q   ?? 5+      $??Motel??6   $??50??6W   $	??100??6c   $??5q?6o   ??6%   ?? $ ChangeTypeOfHotelToMotel?6o   ?? 5,      $??Cottage??6   $??50??6[   $	??100??6g   $??5q?6s   ??6'   ?? $  ChangeTypeOfHotelToCottage?6s   5-      5.      5/      