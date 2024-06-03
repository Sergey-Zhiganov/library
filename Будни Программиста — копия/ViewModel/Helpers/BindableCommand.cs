using System.Windows.Input;
using Будни_Программиста.Model;

namespace Будни_Программиста.ViewModel.Helpers
{
    internal class BindableCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool>? _canExecute;
        private Action<string, List<Language>?> saveDay;

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public BindableCommand(Action<object> execute, Func<object, bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public BindableCommand(Action<string, List<Language>?> saveDay)
        {
            this.saveDay = saveDay;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter!);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter!);
        }
    }
}