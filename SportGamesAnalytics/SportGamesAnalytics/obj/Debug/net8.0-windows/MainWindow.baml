   M S B A M L   `   `   `  ����N  JSportGamesAnalytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SportGamesAnalyticsSportGamesAnalytics  5   	   $    SportGamesAnalytics.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SportGamesAnalytics     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6"   $	��920��6/    � WindowStyle$
 None=�5	       � 
ResizeMode$ NoResize=�5
      
������  � AllowsTransparency$
 True��5      .��5      �� -   5        $��
dropBorder��5   
   ���#CACBCD �� CornerRadius$ 20��5   
   ._�5   
   �  � RowDefinitions 5      �� 5      �� 5      $��7* �6    .+�5      � ���#F6F3EE5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
date_games��5      $
��Left=�6-   $��447,161,0,0q�6H   $��1��6]   $	��Top=�6j     5      -   5        $ date_session��5      $
��Left=�6/   $��447,119,0,0q�6J   $��1��6_   $	��Top=�6l      SelectedDateFormat$ Short=�6�   �� 5      -   5         ��Name$ start��5      $��Button��6$   $
��Left=�65   $��447,197,0,0q�6P   $��1��6e   $	��Top=�6r   $	��100��6�   $��28��6�   6�   �� 5      -   5        	 ��Name$	 name_sports��5      $
��Left=�6,   $��
437,23,0,0q�6G   $��1��6[   $	��Top=�6h   $	��120��6�   �� 5       -   5        
 ��Name$
 complexity_sports��5       $
��Left=�61   $��
603,25,0,0q�6L   $��1��6`    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5!      -   5        $
 complexity_theme��5!      $
��Left=�60   $��
603,75,0,0q�6K   $��1��6_   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5"      -	   5        $	 
name_theme��5"      $
��Left=�6+   $��
437,73,0,0q�6F   $��1��6Z   $	��Top=�6g   $	��120��6   �� 5#      -
   5        $
 tect_output��5#      $
��Left=�6+   $��427,285,0,0q�6F   $��1��6[   $
 Wrap=�6h   $	��Top=�6|   $	��189��6�   ${�False��6�   5%      5&      5'      