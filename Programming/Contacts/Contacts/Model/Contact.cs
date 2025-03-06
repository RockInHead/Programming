using System.ComponentModel;

/// <summary>
/// Класс контакта пользователя, хранящий имя, номер телефон и почту контакта.
/// </summary>
public class Contact : INotifyPropertyChanged
{
    /// <summary>
    /// Конструктор класса Contact. 
    /// Инициализирует поля значениями по умолчанию.
    /// </summary>
    public Contact()
    {
        Name = "";
        PhoneNumber = "";
        Email = "";
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
    public string Name { get; set; }

    /// <summary>
    /// Задает и возвращает номер телефона контакта.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Задает и возвращает почту контакта.
    /// </summary>
    public string Email { get; set; }

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

