   M S B A M L   `   `   `  ����C  ?Tea_Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Tea_ShopTea_Shop  5   	       Tea_Shop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tea_Shop     5   	     � Title$  Tea Shop��5   	   $	��640��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��145 �6   �� 5      $	��106 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5!   
   �� -   5         ��Name$ 	Login_btn��5!   Q   $��5��6   $��1��6!   $��2��6/   $��18(�6C   $��Login��6d   $��Maiandra GD)�6t   $��	106,0,0,0q�6�   ���	#FF99D4A4 J� Opacity$ 1Q�6�   $��26��6�   $	��Top=�6�   �� 5$   
   $��1��6   $��2��6    $��2��6-   $	��250��6B   $	��200��6N   $��black_tea.jpg��6[   �� 5&   
   $��3��6   $��2��6    $��2��6-   $	��250��6B   $	��200��6N   $��green_tea.jpg��6[   �� 5(   
   $��5��6   $��2��6    $��2��6-   $	��250��6B   $	��200��6N   $��milk_tea.jpg��6[   �� 5*   
   $��1��6   $��5��6    $��2��6-   $	��250��6B   $	��200��6N   $��espresso.png��6[   �� 5,   
   $��3��6   $��5��6    $��2��6-   $	��250��6B   $	��200��6N   $��americano.jpg��6[   �� 5.   
   $��5��6   $��5��6    $��2��6-   $	��250��6B   $	��200��6N   $��cappuccino.png��6[   �� 51   
   -   5        $��btn_buy1��51      $��1��6!   $��4��61   $��2��6>   $	��Buy��6R   $	��200��6`   $��40��6l   $��20(�6x   $
��Bold"�6�   $	 0.8Q�6�      btnBlue#��[  6�   53      �� 55   
   -   5        $��btn_buy2��55      $��3��6!   $��4��61   $��2��6>   $	��Buy��6R   $��40��6`   $��20(�6l   $
��Bold"�6z   $	��200��6�   $	 0.8Q�6�   #��[  6�   57      �� 59   
   -   5        $��btn_buy3��59      $��5��6!   $��4��61   $��2��6>   $	��Buy��6R   $	��200��6`   $��20(�6l   $
��Bold"�6z   $��40��6�   $	 0.8Q�6�   #��[  6�   5;      �� 5=   
   $��3��6   $��1��6"   $��20(�62   $��Center=�6@   $��Center=�6]   	Black tea6�   �� 5>   
   $��3��6   $��2��6"   $��20(�62   1.80$6I   �� 5?   
   $��3��6   $��3��6"   $��20(�62   $��Center=�6@   $��Center=�6]   	Green tea6�   �� 5@   
   $��3��6   $��4��6"   $��20(�62   1.80$6I   �� 5A   
   $��3��6   $��5��6"   $��20(�62   $��Center=�6@   $��Center=�6]   
Milk tea6�   �� 5B   
   $��3��6   $��6��6"   $��20(�62   1.95$6I   �� 5D   
   $��6��6   $��1��6"   $��20(�62   $��Center=�6@   $��Center=�6]   
Espresso6�   �� 5E   
   $��6��6   $��2��6"   $��20(�62   2.30$6I   �� 5F   
   $��6��6   $��3��6"   $��20(�62   $��Center=�6@   $��Center=�6]   	Americano6�   �� 5G   
   $��6��6   $��4��6"   $��20(�62   2.35$6I   �� 5H   
   $��6��6   $��5��6"   $��20(�62   $��Center=�6@   $��Center=�6]   
Cappuccino6�   �� 5I   
   $��6��6   $��6��6"   $��20(�62   2.75$6I   �� 5L   
   -   5        $��btn_buy4��5L      $��7��6!   $��1��6.   $��2��6>   $	��Buy��6R   $��40��6`   $	��200��6l   $��20(�6x   $
��Bold"�6�   $	 0.8Q�6�   #��[  6�   5N      �� 5P   
   -   5        $��btn_buy5��5P      $��7��6!   $��3��6.   $��2��6>   $	��Buy��6R   $��40��6`   $��20(�6l   $
��Bold"�6z   $	��200��6�   $	 0.8Q�6�   #��[  6�   5R      �� 5T   
   -   5        $��btn_buy6��5T      $��7��6!   $��5��6.   $��2��6>   $	��Buy��6R   $	��200��6`   $��40��6l   $��20(�6x   $
��Bold"�6�   $	 0.8Q�6�   #��[  6�   5V      5Z      5[      