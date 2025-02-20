using System.Windows.Input;

/// <summary>
/// Команда для загрузки контакта из файла.
/// </summary>
public class LoadCommand : ICommand
{
    /// <summary>
    /// Объект для загрузки контакта из файла.
    /// </summary>
    private readonly ContactSerializer _serializer;

    /// <summary>
    /// Делегат, который устанавливает загруженный контакт в ViewModel.
    /// Используется для обновления состояния объекта Contact.
    /// </summary>
    private readonly Action<Contact> _setContact;

    /// <summary>
    /// Инициализирует новый экземпляр команды <see cref="LoadCommand"/>.
    /// </summary>
    /// <param name="serializer">Объект для десериализации контакта.</param>
    /// <param name="setContact">Делегат для передачи загруженного контакта в ViewModel.</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если передан null.</exception>
    public LoadCommand(ContactSerializer serializer, Action<Contact> setContact)
    {
        _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
    }

    /// <summary>
    /// Определяет, можно ли выполнить команду загрузки.
    /// </summary>
    /// <param name="parameter">Не используется.</param>
    /// <returns>Всегда возвращает true.</returns>
    public bool CanExecute(object parameter) => true;

    /// <summary>
    /// Выполняет команду загрузки контакта из файла.
    /// </summary>
    /// <param name="parameter">Не используется.</param>
    public void Execute(object parameter)
    {
        var contact = _serializer.LoadContact();
        if (contact != null)
        {
            _setContact(contact);
        }
    }

    /// <summary>
    /// Событие, вызываемое при изменении состояния выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;
}


