   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MediaPlayer.ViewModelMediaPlayer.ViewModel  5   	       MediaPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MediaPlayer.ViewModel     5   	   -   5          � Title$  MediaPlayer��5   	   $	��450��6   $	��800��6*    J� 	AllowDrop . .��5	      � ���#222222 � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   r� -   5         r�Name$ mediaElement1��5      $��0��6.    J� OpacityMask
 �   �$��Stretch=�5      $��Stretch=�6-    r� Source 5      �� 5       �� Path$ 	VideoPath�6    �� Mode$ TwoWay=�6+    �� UpdateSourceTrigger$ PropertyChanged=�69   	 � DataContext	 5      %   MediaPlayer.ViewModel.ViewModel  5      5      �� 5   
   $��1��6   
 �� Orientation$
 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5      �� -   5        $
��Play��5      $��80��6$   $��5q�6/   ���#3498DB
�������6d   �� 5      -   5        $��Pause��5      $��80��6%   $��5q�60   ���#3498DB
�������6g   �� 5      -   5        $
��Stop��5      $��80��6$   $��5q�6/   ���#3498DB
�������6f   5      �� 5    
   $��2��6   $
 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5!      �� -   5         ��Name$ slider_seek��5!      $	��600��6*   $��30��66   $��5q�6B   ���#3498DB
������� J� Opacity$	 0.7Q�6u    � Cursor$
 Hand��5"   f    � Value 6   �� *SeekPosition+$ TwoWay=�$ PropertyChanged=�6f   �� 5#      -   5        $ 
slider_vol��5#      $	��150��6)   $��30��65   $��5q�6A    � Minimum$ 0Q�6L    � Maximum$ 1Q�6X   ���#3498DB
�������$	 0.7Q�6�    � LargeChange$	 0.1Q�5$   `    � SmallChange$
 0.01Q�6r   $
 Hand��6�    6   �� *Volume+$ TwoWay=�$ PropertyChanged=�6�   5%      5&      5'      