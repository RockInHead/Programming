using System.ComponentModel;

/// <summary>
/// Класс контакта пользователя, хранящий имя, номер телефон и почту контакта.
/// </summary>
public class Contact : INotifyPropertyChanged
{
    /// <summary>
    /// Поле, задающее имя контакта.
    /// </summary>
    private string _name;

    /// <summary>
    /// Поле, хранящее почту контакта.
    /// /// </summary>
    private string _email;

    /// <summary>
    /// Поле, хранящее телефонный номер контакта.
    /// /// </summary>
    private string _phoneNumber;

    /// <summary>
    /// Конструктор класса Contact.
    /// Инициализирует поля значениями по умолчанию.
    /// </summary>
    public Contact()
    {

    }

    /// <summary>
    /// Конструктор Contact c параметрами.
    /// Инициализирует новый класс с указанными значениями.
    /// </summary>
    /// <param name="name">Имя контакта</param>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="email">Почта контакта</param>
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    /// <summary>
    /// Задает и возвращает имя контакта.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            if (_name == value)
            {
                return;
            }

            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Задает и возвращает номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (_phoneNumber == value)
            {
                return;
            }

            _phoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
        }
    }

    /// <summary>
    /// Задает и возвращает почту контакта.
    /// </summary>
    public string Email
    {
        get => _email;
        set
        {
            if (_email == value)
            {
                return;
            }

            _email = value;
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

