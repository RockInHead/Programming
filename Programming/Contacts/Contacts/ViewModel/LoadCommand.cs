using System.Windows.Input;

/// <summary>
/// Команда для загрузки контакта из файла.
/// </summary>
public class LoadCommand : ICommand
{
    /// <summary>
    /// Делегат, который устанавливает загруженный контакт в ViewModel.
    /// Используется для обновления состояния объекта Contact.
    /// </summary>
    private readonly Action<Contact> _setContact;

    /// <summary>
    /// Инициализирует новый экземпляр команды <see cref="LoadCommand"/>.
    /// </summary>
    /// <param name="setContact">Делегат для передачи загруженного контакта в ViewModel.</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если передан null.</exception>
    public LoadCommand(Action<Contact> setContact)
    {
        _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
    }

    /// <summary>
    /// Событие, вызываемое при изменении состояния выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

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
        var contact = ContactSerializer.LoadContact();
        if (contact != null)
        {
            _setContact(contact);
        }
    }
}


