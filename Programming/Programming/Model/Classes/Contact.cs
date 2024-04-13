using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

/// <summary>
/// Хранит данные о контакте: Имя, Фамилию, Телефонный номер, Описание контакта.
/// </summary>
public class Contact
{
    //Поля
    /// <summary>
    /// Имя человека - string.
    /// </summary>
    private string _name;
    /// <summary>
    /// Фамилия человека - string.
    /// </summary>
    private string _surname;
    /// <summary>
    /// Телефонный номер - int.
    /// </summary>
    private int _phoneNumber;
    /// <summary>
    /// Описание контакта - string.
    /// </summary>
    private string _desription;

    //Свойства и автосвойства
    /// <summary>
    /// Возвращает и задает имя человека. Должно состоять только из букв.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;

        }
        set
        {
            if (AssertStringContainsOnlyLetters(value))
            {
                _name = value;

            }
            
        }
    }
    /// <summary>
    /// Возвращает и задает фамилию человека. Должно состоять только из букв.
    /// </summary>
    public string Surname
    {
        get
        {
            return _surname;

        }
        set
        {
            if (AssertStringContainsOnlyLetters(value))
            {
                _surname = value;

            }

        }
    }
    /// <summary>
    /// Возвращает и задает телефонный номер человека. Должно состоять только из положительных чисел.
    /// </summary>
    public int PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _phoneNumber = value;
        }
    }
    /// <summary>
    /// Возвращает и задает описание человека.
    /// </summary>
    public string Desription { get; set; }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Contact()
    {
        Name = "None";
        PhoneNumber = 0;
        Desription = "None";
    }
    /// <summary>
    /// Создаёт экземпляр класса.
    /// </summary>
    /// <param name="name">Имя.Должно состоять только из букв.</param>
    /// <param name="surname">Фамилия.Должно состоять только из букв.</param>
    /// <param name="phoneNumber">Телефонный номер.Должен состоять только из положительных чисел.</param>
    /// <param name="description">Описание.Ограничений нет</param>
    public Contact(string name,string surname, int phoneNumber,string description)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Desription = description;
    }

    //Методы
    /// <summary>
    /// Проверяет,что строка состоит только из букв.
    /// </summary>
    /// <param name="value">Проверяемая строка</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private bool AssertStringContainsOnlyLetters(string value)
    {

        if (Regex.IsMatch(value, "^[a-zA-Z]*$"))
        {

            return true;
        }
        else
        {
            throw new ArgumentException($"Только латинские символы! Без цифр! {new StackTrace().GetFrame(1).GetMethod().Name}");
        }
    }
}