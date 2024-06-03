using Будни_Программиста.ViewModel;

namespace Будни_Программиста.View
{
    public partial class DayCardView
    {
        public DayCardView()
        {
            InitializeComponent();
            DataContext = new DayCardViewModel();
        }

        private void CurrentDayImage_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectLanguagesWindowViewModel.date = $"{CurrentDayText.Text}.{MainWindowViewModel.selectedMonth.Month}." +
            $"{MainWindowViewModel.selectedMonth.Year}";
        }
    }
}