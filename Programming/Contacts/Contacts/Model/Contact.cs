/// <summary>
/// Класс контакта пользователя, хранящий имя, номер телефон и почту контакта.
/// </summary>
public class Contact
{
    /// <summary>
    /// Задает и возвращет имя контакта.
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

    /// <summary>
    /// Конструктор класса Contact. 
    /// Инициализирует поля значениями по умолчанию.
    /// </summary>
    public Contact()
    {
        Name = "Илья Шутов";
        PhoneNumber = "8-800-555-35-35";
        Email = "tusurthechampion36.gmail";
    }

    /// <summary>
    /// Конструктор Contact c параметрами.
    /// Инициализиурет новый класс с указанными значениями.
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
}

