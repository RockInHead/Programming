using System.Windows.Input;

/// <summary>
/// Команда для сохранения контакта в файл.
/// </summary>
public class SaveCommand : ICommand
{

    /// <summary>
    /// Объект для сериализации и сохранения контакта в файл.
    /// </summary>
    private readonly ContactSerializer _serializer;

    /// <summary>
    /// Делегат, возвращающий текущий контакт для сохранения.
    /// Используется для получения актуального состояния объекта Contact из ViewModel.
    /// </summary>
    private readonly Func<Contact> _getContact;

    /// <summary>
    /// Инициализирует новый экземпляр команды <see cref="SaveCommand"/>.
    /// </summary>
    /// <param name="serializer">Объект для сериализации контакта.</param>
    /// <param name="getContact">Функция, возвращающая текущий контакт.</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если передан null.</exception>
    public SaveCommand(ContactSerializer serializer, Func<Contact> getContact)
    {
        _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
    }

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
            _serializer.SaveContact(contact);
        }
    }

    /// <summary>
    /// Событие, вызываемое при изменении состояния выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

}

