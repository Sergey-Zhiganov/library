   M S B A M L   `   `   `  ����^  ZБудни Программиста, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:Будни_Программиста.ViewModel-Будни_Программиста.ViewModel  5   	   D    >Будни_Программиста.View.SelectLanguagesWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Q	viewModel;clr-namespace:Будни_Программиста.ViewModel     5   	     � Title$  SelectLanguagesWindow��5   	   $	��600��6'   $	��450��64    "  SelectLanguagesWindowViewModel � DataContext# [  5	   	    � 	Resources 5
      R  LБудни_Программиста.ViewModel.SelectLanguagesWindowViewModel 
 FadeIn �� TargetProperty W� From	 W� To g� Duration  FadeOut��%�   &	        &	      &	 y       5   
   63   �� 5   
   .��5      W� $ Opacity�6    0.06B    1.06M   $ 0:0:1D�6V   5      �� 5   
   .��5      W� $ Opacity�6    1.06B    0.06M   $ 0:0:1D�6V   5      5      .��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[ 6"   5      	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5        $��
Назад��5      $��0��6<   $
��Left=�5      $	��Top=�6,   $��10q�6D   5       �� 5!   
   $��Сохранить��6   $��0��6H   $��Right=�5"      $	��Top=�6-   $��10q�6E   ��5!   %   �� *SaveDayCommand+5#      � 5$   
   $��1��6   
 � ColumnDefinitions
 5%      �� 5&      �� 5'      	 5)      �� 5*      �� 5+      �� 5,      �� 5-      �� 5.      �� 5/      .+�51      �� -   5         ��Name$	 Cpp��51      $
��С++��6$   $��0��6L   $��0��6\    d� 	IsChecked 62   �� *Cpp+6k   �� 52      -   5        $
 Java��52      $
��Java��6%   $��0��6O   $��1��6_    64   �� *Java+6n   �� 53      -   5        $ Python��53      $��Python��6'   $��0��6U   $��2��6e    68   �� *Python+6t   �� 54      -   5        $ JS��54      $��
JavaScript��6#   $��0��6Q   $��3��6a    68   �� *JS+6p   �� 55      -   5        $ Cs��55      $��C#��6#   $��0��6I   $��4��6Y    60   �� *Cs+6h   �� 56      -   5        $	 Asm��56      $��	Assembler��6$   $��0��6R   $��5��6b    68   �� *Asm+6q   �� 57      $��/cpp.png��6   $��1��6&   $��0��66   �� 58      $��	/java.png��6   $��1��6'   $��1��67   �� 59      $��/python.png��6   $��1��6)   $��2��69   �� 5:      $��/js.png��6   $��1��6%   $��3��65   �� 5;      $��/csharp.png��6   $��1��6)   $��4��69   �� 5<      $��/asm.png��6   $��1��6&   $��5��66   5=      5>      5?      