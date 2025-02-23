using System.ComponentModel;

/// <summary>
/// Основная модель представления для управления контактами и их сохранением/загрузкой.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Объект текущего контакта.
    /// </summary>
    private Contact _currentContact;

    /// <summary>
    /// Возвращает и задает текущий контакт.
    /// </summary>
    public Contact Contact
    {
        get => _currentContact;
        set
        {
            if (_currentContact == value)
            {
                return;
            }

            _currentContact = value;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Возвращает и задает текущее имя контакта.
    /// </summary>
    public string Name
    {
        get => _currentContact.Name;
        set
        {
            if (_currentContact.Name == value)
            {
                return;
            }

            _currentContact.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Возвращает и задает текущий номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get => _currentContact.PhoneNumber;
        set
        {
            if (_currentContact.PhoneNumber == value)
            {
                return;
            }

            _currentContact.PhoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
        }
    }

    /// <summary>
    /// Возвращает и задает текущцю почту контакта.
    /// </summary>
    public string Email
    {
        get => _currentContact.Email;
        set
        {
            if (_currentContact.Email == value)
            {
                return;
            }

            _currentContact.Email = value;
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
        _currentContact = new Contact();

        SaveCommand = new SaveCommand(() => Contact);
        LoadCommand = new LoadCommand(loadedContact => UpdateContact(loadedContact));
    }

    /// <summary>
    /// Обновляет текущий контакт новыми данными.
    /// </summary>
    /// <param name="contact">Загруженный контакт.</param>
    private void UpdateContact(Contact contact)
    {
        if (contact == null)
        {
            return;
        }

        Contact = contact;
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

