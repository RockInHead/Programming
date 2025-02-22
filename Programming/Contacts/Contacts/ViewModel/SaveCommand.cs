using System.Windows.Input;

/// <summary>
/// Команда для сохранения контакта в файл.
/// </summary>
public class SaveCommand : ICommand
{
    /// <summary>
    /// Делегат, возвращающий текущий контакт для сохранения.
    /// Используется для получения актуального состояния объекта Contact из модели представления.
    /// </summary>
    private readonly Func<Contact> _getContact;

    /// <summary>
    /// Инициализирует новый экземпляр команды <see cref="SaveCommand"/>.
    /// </summary>
    /// <param name="getContact">Функция, возвращающая текущий контакт.</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если передан null.</exception>
    public SaveCommand(Func<Contact> getContact)
    {
        ContactSerializer.CreateDirectory();
        _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
    }

    /// <summary>
    /// Событие, вызываемое при изменении состояния выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Определяет, можно ли выполнить команду.
    /// </summary>
    /// <param name="parameter">Не используется.</param>
    /// <returns>Всегда возвращает true.</returns>
    public bool CanExecute(object parameter) => true;

    /// <summary>
    /// Выполняет команду сохранения контакта в файл.
    /// </summary>
    /// <param name="parameter">Не используется.</param>
    public void Execute(object parameter)
    {
        var contact = _getContact();
        if (contact != null)
        {
            ContactSerializer.SaveContact(contact);
        }
    }
}

