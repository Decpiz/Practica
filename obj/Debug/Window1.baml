   M S B A M L   `   `   `  ����W  SПрактика(ТРЗБД), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Практика_ТРЗБД_Практика_ТРЗБД_  5   	   *    $Практика_ТРЗБД_.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Практика_ТРЗБД_     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dtg_Reisi��5
         AutoGenerateColumns .  $��	0,0,0,251q�6m      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID_Reisa��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   "   ��  �� Path$ ID_Reisa�6F     5      $ ID_Avtobysa��6%    5   "   �� $ ID_Avtobysa�6I     5      $ ID_Sotrydnika��6%    5   "   �� $ ID_Sotrydnika�6K     5      $ Vremia_v_pyti��6%    5   "   �� $ Vremia_v_pyti� �� StringFormat$ {0:hh}:{0:mm}:{0:ss}��6o     5      $ 	Distancia��6%    5   "   �� $ 	Distancia�6G   5      �� 5   
   -   5         ��Name$ btn_add��5      $��Добавить��6"   $
��Left=�65   $��169,321,0,0q�6P   $	��Top=�6e   $��55��6}   $	��111��6�   6�   �� 5   
   -   5        $ 
btn_delete��5      $��Удалить��6%   $
��Left=�67   $��332,321,0,0q�6R   $	��Top=�6g   $��55��6   $	��112��6�   6�   �� 5   
   -   5        $ btn_red��5      $��Изменить��6"   $
��Left=�65   $��483,321,0,0q�6P   $	��Top=�6e   $	��111��6}   $��55��6�   6�   �� 5   
   -   5        	 ��Name$	 tb_Vremia_v_pyti��5      $
��Left=�6,   $��248,286,0,0q�6G   
 �� TextWrapping$

 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $	 tb_Distancia��5      $
��Left=�6(   $��396,286,0,0q�6C   $

 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $	 tb_ID_Avtobysa��5      $
��Left=�6*   $��248,219,0,0q�6E   $

 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 5    
   -   5        $	 tb_ID_Sotrydnika��5       $
��Left=�6,   $��396,219,0,0q�6G   $

 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5"   
   $��ID Автобуса��6   $
��Left=�6&   $��267,188,0,0q�6A   $	��Top=�6V   �� 5#   
   $��ID Сотрудника��6   $
��Left=�6(   $��421,188,0,0q�6C   $	��Top=�6X   �� 5$   
   $��Время в пути��6   $
��Left=�6'   $��274,255,0,0q�6B   $	��Top=�6W   �� 5%   
   $��Дистанция��6   $
��Left=�6$   $��427,255,0,0q�6?   $	��Top=�6T   5&      5'      