using System.Xml.Linq;

public class Contact
{
    //Поля
    private string _name;
    private int _phoneNumber;
    private string _desription;
    //Свойства и автосвойства
    public string Name { get; set; }
    public int PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
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
    public Contact(string name, int phoneNumber,string description)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Desription = description;
    }
}