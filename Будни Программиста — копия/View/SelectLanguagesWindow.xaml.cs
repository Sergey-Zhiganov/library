using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Будни_Программиста.ViewModel;
using System.Windows.Controls;
using Будни_Программиста.Model;

namespace Будни_Программиста.View;

public partial class SelectLanguagesWindow : Window
{

    public SelectLanguagesWindow()
    {
        InitializeComponent();
        List<CheckBox> buttons = [Cpp, Java, Python, JS, Cs, Asm];
        DataContext = new SelectLanguagesWindowViewModel();
        List<object> list = MainWindowViewModel.GetChoiceByDate(SelectLanguagesWindowViewModel.date);
        if (list.Count > 0)
        {
            List<Language> languages = (List<Language>)list[1];
            foreach (Language language in languages)
            {
                foreach (CheckBox button in buttons)
                {
                    if (button.Content.ToString() == language.Name || button.Name == "Cpp" && language.Name == "C++")
                    {
                        button.IsChecked = language.IsSelected;
                    }
                }
            }
        }
    }

    public void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}