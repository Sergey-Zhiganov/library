using System.Windows;
using Будни_Программиста.ViewModel;

namespace Будни_Программиста.View
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var lightTheme = new ResourceDictionary { Source = new Uri("Themes/Light.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Add(lightTheme);
            var viewModel = new MainWindowViewModel();
            DataContext = viewModel;
            MainWindowViewModel.GetData();
            MainWindowViewModel.framePage.Content = new DaysPage()
            {
                DataContext = viewModel
            };
        }
        private void SwitchToLightTheme_Click(object sender, RoutedEventArgs e)
        {
            var darkTheme = new ResourceDictionary { Source = new Uri("Themes/Dark.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Remove(darkTheme);
            var lightTheme = new ResourceDictionary { Source = new Uri("Themes/Light.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Add(lightTheme);
        }

        private void SwitchToDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            var lightTheme = new ResourceDictionary { Source = new Uri("Themes/Light.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Remove(lightTheme);
            var darkTheme = new ResourceDictionary { Source = new Uri("Themes/Dark.xaml", UriKind.Relative) };
            Application.Current.Resources.MergedDictionaries.Add(darkTheme);
        }
    }
}