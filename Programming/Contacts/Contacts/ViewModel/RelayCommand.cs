using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute; // Делегат для выполнения команды
    private readonly Predicate<object> _canExecute; // Делегат для проверки возможности выполнения команды

    /// <summary>
    /// Конструктор команды.
    /// </summary>
    /// <param name="execute">Метод, который будет выполнен при вызове команды.</param>
    /// <param name="canExecute">Метод, который проверяет, можно ли выполнить команду.</param>
    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute)); // Проверка на null
        _canExecute = canExecute;
    }

    /// <summary>
    /// Проверяет, можно ли выполнить команду.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>True, если команду можно выполнить, иначе False.</returns>
    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    /// <summary>
    /// Выполняет команду.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    /// <summary>
    /// Событие, которое вызывается при изменении возможности выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}