   M S B A M L   `   `   `  ����^  ZБудни Программиста, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:Будни_Программиста.ViewModel-Будни_Программиста.ViewModel  5   P   9    3Будни_Программиста.View.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Q	viewmodel;clr-namespace:Будни_Программиста.ViewModel     6P     � Title$)  #Будни Программиста��5   	   $	��350��6$   $	��350��61    � 	Resources 5       
  FadeIn �� TargetProperty W� From	 W� To g� Duration  FadeOut  
PageFadeIn �� 
TargetName  PageFadeOut��%�  &	        &	 f     &	 �     &	 C    �� 5	   
   .��5
      W� $ Opacity�6    0.06B    1.06M   $ 0:0:1D�6V   5      �� 5   
   .��5      W� $ Opacity�6    1.06B    0.06M   $ 0:0:1D�6V   5      �� 5   
   .��5      W� $ 	FramePage��6   $ Opacity�6@    06d    16m   $ 0:0:1D�6t   5      �� 5   
   .��5      W� $ 	FramePage��6   $ Opacity�6@    16d    06m   $ 0:0:1D�6t   5      5      .��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6"   5      	 � ColumnDefinitions	 5   
   �� 5      �� 5      �� 5      
 � RowDefinitions
 5!   
   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      .+�5&   
   �� -   5        $��Switch to Light Theme��5&      61   �� 5'      -   5        $��Switch to Dark Theme��5'      $��2��6T   �� 5(      $��
Назад��6   $��1��6O   $
��Left=�5)      $	��Top=�6,   $��10q�6D   ��5(   %   �� *PreviousMonthCommand+5)   D   �� 5*   
   $��1��6   $��1 ��6!   $��Center=�5+      $��Center=�61   $��18(�6L   ��5*   2   �� *SelectedMonth+ �� StringFormat$ 	MMMM yyyy��5+   L   �� 5,   
   $��Вперед��6   $��1��6G   $��2��6T   $��Right=�5-      $	��Top=�6-   $��10q�6E   ��5,   "   �� *NextMonthCommand+5-   E    � 5.   
   -   5          �Name$ 	FramePage��5.      $��2��6A     � NavigationUIVisibility$ Hidden=�6N   $��3��6n   $��0��6�   ��6#   �� *	FramePage+'  !System.Windows.VisualStateManager   VisualStateGroups 5/      %  System.Windows.VisualStateGroup  50         States. 51         System.Windows.VisualState  -   5        
Navigating��   
Storyboard. 52      �� .��53      W� $ Opacity�6.    06R   $ 0:0:1D�6Y   54      55        56      -   5        	Navigated��. 57      �� .��58      W� $ Opacity�6.    16R   $ 0:0:1D�6Y   59      5:      5;      5=      5>      5?      