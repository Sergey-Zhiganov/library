using System.Windows;
using System.Windows.Input;
using Будни_Программиста.Model;
using Будни_Программиста.View;
using Будни_Программиста.ViewModel.Helpers;

namespace Будни_Программиста.ViewModel;

internal class DayCardViewModel : BindingHelper
{
    public ICommand SelectLanguagesCommand { get; private set; }
    public ICommand ClearDayCommand { get; private set; }

    public DayCardViewModel()
    {
        SelectLanguagesCommand = new BindableCommand(ExecuteSelectLanguages);
        ClearDayCommand = new BindableCommand(ClearDay);
    }

    private void ExecuteSelectLanguages(object parameter)
    {
        var selectLanguages = new SelectLanguagesWindow();
        selectLanguages.ShowDialog();
    }
    private void ClearDay(object parametr)
    {
        MainWindowViewModel.ClearDay(SelectLanguagesWindowViewModel.date);
        MainWindowViewModel.framePage.Content = new DaysPage()
        {
            DataContext = new MainWindowViewModel()
        };
    }
}