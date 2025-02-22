using System.ComponentModel;

/// <summary>
/// Основная ViewModel для управления контактами и их сохранением/загрузкой.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Объект текущего контакта.
    /// </summary>
    private Contact _contact;

    /// <summary>
    /// Текущий контакт.
    /// </summary>
    public Contact Contact
    {
        get => _contact;
        set
        {
            _contact = value;
            OnPropertyChanged(nameof(Contact));
        }
    }

    /// <summary>
    /// Свойство для имени контакта с уведомлением об изменении.
    /// </summary>
    public string Name
    {
        get => _contact.Name;
        set
        {
            _contact.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Свойство для номера телефона контакта с уведомлением об изменении.
    /// </summary>
    public string PhoneNumber
    {
        get => _contact.PhoneNumber;
        set
        {
            _contact.PhoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
        }
    }

    /// <summary>
    /// Свойство для email контакта с уведомлением об изменении.
    /// </summary>
    public string Email
    {
        get => _contact.Email;
        set
        {
            _contact.Email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Команда для сохранения контакта.
    /// </summary>
    public SaveCommand SaveCommand { get; }

    /// <summary>
    /// Команда для загрузки контакта.
    /// </summary>
    public LoadCommand LoadCommand { get; }

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _contact = new Contact();

        SaveCommand = new SaveCommand(() => Contact);
        LoadCommand = new LoadCommand(loadedContact => UpdateContact(loadedContact));
    }

    /// <summary>
    /// Обновляет текущий контакт новыми данными и уведомляет интерфейс об изменениях.
    /// </summary>
    /// <param name="contact">Загруженный контакт.</param>
    private void UpdateContact(Contact contact)
    {
        if (contact != null)
        {
            Contact = contact;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Событие, уведомляющее об изменениях в свойствах.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для обновления интерфейса.
    /// </summary>
    /// <param name="propertyName">Имя измененного свойства.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

