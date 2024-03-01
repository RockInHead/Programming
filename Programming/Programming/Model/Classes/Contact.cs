using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

public class Contact
{
    //Поля
    private string _name;
    private string _surname;
    private int _phoneNumber;
    private string _desription;
    //Свойства и автосвойства
    
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

    public int PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            /*  if (value < 0)
              {
                  throw new ArgumentException();
              }*/
            Validator.AssertOnPositiveValue(value);
            _phoneNumber = value;
        }
    }
    public string Desription { get; set; }

    //Конструктор
    public Contact()
    {
        Name = "None";
        PhoneNumber = 0;
        Desription = "None";
    }
    public Contact(string name,string surname, int phoneNumber,string description)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Desription = description;
    }

    //Методы
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