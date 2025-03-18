using System.ComponentModel;
using System.Text.RegularExpressions;

/// <summary>
/// Класс контакта пользователя, хранящий имя, номер телефон и почту контакта.
/// </summary>
public class Contact : INotifyPropertyChanged, IDataErrorInfo, ICloneable
{
    /// <summary>
    /// Максимальное количество символов для текстового блока.
    /// </summary>
    private const int MaxTextBoxSymbols = 100;

    /// <summary>
    /// Максимальное количество символов для номера телефона.
    /// </summary>
    private const int MaxPhoneNumberTextBoxSymbols = 11;

    /// <summary>
    /// Поле, хранящее имя контакта.
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

    /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
    public event PropertyChangedEventHandler PropertyChanged;

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

    /// <inheritdoc cref="IDataErrorInfo.Error"/>
    public string Error => null;

    /// <summary>
    /// Создает копию текущего объекта Contact.
    /// </summary>
    /// <returns>Новый объект Contact с такими же значениями свойств.</returns>
    public object Clone() => new Contact(this.Name, this.PhoneNumber, this.Email);

    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для обновления интерфейса.
    /// </summary>
    /// <param name="propertyName">Имя измененного свойства.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Индексатор для валидации свойств контакта.
    /// Возвращает сообщение об ошибке, если данные некорректны.
    /// </summary>
    /// <param name="columnName">Имя свойства, для которого требуется валидация.</param>
    /// <returns>Сообщение об ошибке или null, если ошибок нет.</returns>
    public string this[string columnName]
    {
        get
        {
            switch (columnName)
            {
                case "Name":
                {
                    if (string.IsNullOrWhiteSpace(Name) || Name.Length > MaxTextBoxSymbols)
                    {
                        return "Имя должно содержать хотя бы 2 символа и не более 100";
                    }

                    break;
                }

                case "PhoneNumber":
                {
                    if (string.IsNullOrWhiteSpace(PhoneNumber) 
                                    || PhoneNumber.Length > MaxPhoneNumberTextBoxSymbols
                                    || !Regex.IsMatch(PhoneNumber, @"^[\d+\-()\s]+$"))
                    {
                        return "Номер телефона может содержать только цифры и символы '+()-'.";
                    }

                    break;
                }

                case "Email":
                {
                    if (string.IsNullOrWhiteSpace(Email) || Email.Length > MaxTextBoxSymbols || !Email.Contains("@"))
                    {
                        return "Почта должна содержать символ '@'.";
                    }

                    break;
                }
            }

            return null;
        }
    }
}

