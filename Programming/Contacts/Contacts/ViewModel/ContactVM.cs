using System.ComponentModel;

/// <summary>
/// Представляет модель представления для контакта, реализующую интерфейс <see cref="INotifyPropertyChanged"/>.
/// Обеспечивает привязку данных и уведомление об изменениях свойств контакта.
/// </summary>
public class ContactVM : INotifyPropertyChanged
{
    /// <summary>
    /// Объект контакта.
    /// </summary>
    private Contact _contact;

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ContactVM"/> с новым контактом.
    /// </summary>
    public ContactVM()
    {
        _contact = new Contact();
    }

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="ContactVM"/> с заданным контактом.
    /// </summary>
    /// <param name="contact">Контакт, который будет использован для инициализации.</param>
    public ContactVM(Contact contact)
    {
        _contact = contact;
    }

    /// <summary>
    /// Возвращает или задает имя контакта.
    /// </summary>
    public string Name
    {
        get => _contact.Name;
        set
        {
            if (_contact.Name == value)
            {
                return;
            }

            _contact.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Возвращает или задает номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get => _contact.PhoneNumber;
        set
        {
            if (_contact.PhoneNumber == value)
            {
                return;
            }

            _contact.PhoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
        }
    }

    /// <summary>
    /// Возвращает или задает почту контакта.
    /// </summary>
    public string Email
    {
        get => _contact.Email;
        set
        {
            if (_contact.Email == value)
            {
                return;
            }

            _contact.Email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
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