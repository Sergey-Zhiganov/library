   M S B A M L   `   `   `  ����'  #Будни Программиста7    1Будни_Программиста.View.DaysPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  DaysPage��5       � 	Resources 5	       
  FadeIn �� TargetProperty W� From	 W� To g� Duration  FadeOut��%�   &	        &	 f     �� 5
   
   .��5      W� $ Opacity�6    0.06B    1.06M   $ 0:0:1D�6V   5      �� 5   
   .��5      W� $ Opacity�6    1.06B    0.06M   $ 0:0:1D�6V   5      5      .��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6"   5      .+�5   
   � -   5         �Name$
 Days��5      	 � Orientation$	 
Horizontal=�6"   6=   5      5      