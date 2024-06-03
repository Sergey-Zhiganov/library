using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Будни_Программиста.Model;
using Будни_Программиста.View;
using Будни_Программиста.ViewModel.Helpers;
using DeSerializeFile;

namespace Будни_Программиста.ViewModel
{
    internal class MainWindowViewModel : BindingHelper
    {
        public static List<DatesChoice> datesChoices = [];
        public static List<Language> default_languages
        {
            get
            {
                return
                [
                Language.Create("C++", "cpp.png"),
                Language.Create("Java", "java.png"),
                Language.Create("Python", "python.png"),
                Language.Create("JavaScript", "js.png"),
                Language.Create("C#", "csharp.png"),
                Language.Create("Assembler", "asm.png"),
                Language.Create("None", "none.jpg", true)
                ];
            }
            set { return; }
        }
        public static DateTime selectedMonth = DateTime.Today;
        public static Frame framePage = new();
        private const string Path = "data.json";

        public DateTime SelectedMonth
        {
            get { return selectedMonth; }
            set
            {
                if (selectedMonth != value)
                {
                    selectedMonth = value;
                    OnPropertyChanged();
                }
            }
        }
        public Frame FramePage
        {
            get { return framePage; }
            set
            {
                if (framePage != value)
                {
                    framePage = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand PreviousMonthCommand { get; private set; }
        public ICommand NextMonthCommand { get; private set; }


        public MainWindowViewModel()
        {
            PreviousMonthCommand = new BindableCommand(ExecutePreviousMonth);
            NextMonthCommand = new BindableCommand(ExecuteNextMonth);
        }

        private void ExecutePreviousMonth(object parameter)
        {
            SelectedMonth = SelectedMonth.AddMonths(-1);
            MainWindowViewModel.framePage.Content = new DaysPage()
            {
                DataContext = new MainWindowViewModel()
            };
        }

        private void ExecuteNextMonth(object parameter)
        {
            SelectedMonth = SelectedMonth.AddMonths(1);
            MainWindowViewModel.framePage.Content = new DaysPage()
            {
                DataContext = new MainWindowViewModel()
            };
        }

        public static void GetData()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
            datesChoices = Files.Deserialize<List<DatesChoice>>(Path);
            datesChoices ??= [];
        }

        public static List<object> GetChoiceByDate(string date)
        {
            for (int i = 0; i < datesChoices.Count; i++)
            {
                if (datesChoices[i].Date == date)
                {
                    return [i, datesChoices[i].Languages];
                }
            }
            return [];
        }

        public static List<Language>? GetCurrentDay(string date)
        {
            List<object> choices = GetChoiceByDate(date);
            if (choices.Count > 0) return datesChoices[Convert.ToInt32(choices[0])].Languages;
            return default_languages;
        }

        public static void SaveDay(string date, List<Language>? languages)
        {
            List<object> choices = GetChoiceByDate(date);
            if (choices.Count > 0)
            {
                datesChoices[Convert.ToInt32(choices[0])].Languages = languages;
            }
            else
            {
                datesChoices.Add(DatesChoice.Create(date, languages));
            }
            Files.Serialize(datesChoices, Path);
        }
        public static void ClearDay(string date)
        {
            List<object> choices = GetChoiceByDate(date);
            if (choices.Count > 0) datesChoices.RemoveAt(Convert.ToInt32(choices[0]));
            Files.Serialize(datesChoices, Path);
        }
    }
}
