   M S B A M L   `   `   `  ����O  KInvestment.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulloKclr-namespace:Investment.ViewModel.Converters;assembly=Investment.ViewModelInvestment.ViewModel.Converters  5   	    PracticeProject   Investment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ZvmKclr-namespace:Investment.ViewModel.Converters;assembly=Investment.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��414��6   $
��1080��6)    � 	Resources 5      7   1Investment.ViewModel.Converters.PropertyConverter   PropertyConverter5   /Investment.ViewModel.Converters.RatingConverter  RatingConverter��%:   &	        &	        5   
   6     5	   
   6   5
      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  $��0,0,590,224q�68      AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      ��5      ��  �� Path$ Clients� �� SelectedIndex 5   9   �� $ SelectedClientIndex� �� Mode$ OneWayToSource=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� $ 	FirstName� �� UpdateSourceTrigger$ PropertyChanged=�6z     5      $ Фамилия��6%   $	 * 6}   
 66   �� $ LastName�$ PropertyChanged=�6}     5      $ 
Адрес��6%   $	 * 6z   
 64   �� $ Address�$ PropertyChanged=�6z     5      $  Собственность��6%   
 6<   �� $ Property�$ PropertyChanged=� �� 	Converter# [    5      $ 
Номер��6%   $	 * 6y   
 64   �� $ TelNum�$ PropertyChanged=�6y   5        5   
   $��506,0,114,224q�6    .  ��6*   �� *
Securities+ 5        5      $ Название��6%   $	 * 67   
 6A   �� $
 Info�$ PropertyChanged=�  5      $ Выручка��6%   $	 * 66   
 6@   �� $ Revenue�$ PropertyChanged=�  5      $ Мин.покупка��6%   $	 * 6:   
 6D   �� $ MinTransaction�$ PropertyChanged=�  5      $ Рейтинг��6%   $	 * 66   
 6@   �� $ Rating�$ PropertyChanged=�# [ 5!        5#   
   $��0,168,114,82q�6    .  ��6)   �� $ Clients/Investment� 5$        5%      $ Название��6%   $	 * 67   
 6A   �� $ Security.Info�$ PropertyChanged=�  5&      $ Прибыль��6%   $	 * 66   
 6@   �� $ Security.Revenue�$ PropertyChanged=�  5'      $ Мин.сума��6%   $	 * 67   
 6A   �� $ Security.MinTransaction�$ PropertyChanged=�  5(      $ Рейтинг��6%   $	 * 66   
 6@   �� $ Security.Rating�$ PropertyChanged=�# [   5*      $ Котировка��6%   $	 * 68   
 6B   �� $ Quote�$ PropertyChanged=�  5+      $ Покупка��6%   $	 * 66   
 6@   �� $ PurchaseTime�$ PropertyChanged=�  5,      $ Продажа��6%   $	 * 66   
 6@   �� $ SaleTime�$ PropertyChanged=�5.      5/      50      