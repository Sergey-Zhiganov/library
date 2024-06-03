using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Будни_Программиста.Model;
using Будни_Программиста.View;
using Будни_Программиста.ViewModel.Helpers;

namespace Будни_Программиста.ViewModel;

internal class SelectLanguagesWindowViewModel : BindingHelper
{
    public static string date;
    public ICommand SaveDayCommand { get; private set; }

    private bool cpp = false;
    private bool java = false;
    private bool python = false;
    private bool js = false;
    private bool cs = false;
    private bool asm = false;

    public bool Cpp
    {
        get { return cpp; }
        set { cpp = value; }
    }
    public bool Java
    {
        get => java; set { java = value; OnPropertyChanged(); }
    }
    public bool Python
    {
        get => python; set { python = value; OnPropertyChanged(); }
    }
    public bool JS
    {
        get => js; set { js = value; OnPropertyChanged(); }
    }
    public bool Cs
    {
        get => cs; set { cs = value; OnPropertyChanged(); }
    }
    public bool Asm
    {
        get => asm; set { asm = value; OnPropertyChanged(); }
    }
    public SelectLanguagesWindowViewModel()
    {
        SaveDayCommand = new BindableCommand(SaveDay);
    }

    private void SaveDay(object parameter)
    {
        List<bool> bools = [cpp, java, python, js, cs, asm];
        List<Language> languages = MainWindowViewModel.default_languages;
        for (int i = 0; i < bools.Count; i++)
        {
            languages[i].IsSelected = bools[i];
        }
        MainWindowViewModel.SaveDay(date, languages);
        MainWindowViewModel.framePage.Content = new DaysPage()
        {
            DataContext = new MainWindowViewModel()
        };
        MessageBox.Show("Успешно сохранено");
    }
}