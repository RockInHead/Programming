using OOP.Model;
using OOP.Model.Discounts;
using OOP.Model.Orders;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

using System.Text.RegularExpressions;
using System.Xml.Linq;

/// <summary>
/// Хранит данные о покупателе:Уникальный айди,Полное ФИО,Адрес.
/// </summary>
public class Customer
{
    //Поля
    /// <summary>
    /// Уникальный айди покупателя .
    /// </summary>
    private int _id;
    /// <summary>
    /// Статическое значение количества всех экзепляров покупателей.
    /// </summary>
    private static int _allCustomersCount;
    /// <summary>
    /// Полное ФИО покупателя.
    /// </summary>
    private string _fullname;
    /// <summary>
    /// Адрес покупателя.
    /// </summary>
    private Address _address;

    private Cart _cart;

    private List<Order> _orders;

    private List<IDiscount> _discounts;
    //Свойства  автосвойства

    /// <summary>
    /// Возвращает значение о кол-ве всех экземплярах класса.
    /// </summary>
    public int AllCustomersCount
    {
        get
        {
            return _allCustomersCount;
        }
    }
    /// <summary>
    /// Возвращает уникальный айди товара.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Возвращает и задает полное ФИО покупателя.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, FullName);
            _fullname = value;
        }
    }

    /// <summary>
    /// Возвращает и задает адресс покупателя.
    /// </summary>
    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {
            /*ValueValidator.AssertStringOnLength(value, 500, Address);*/
            _address = value;
        }
    }

    public Cart Cart { get; set; }
    public List<Order> Orders { get; set; }

    /// <summary>
    /// Возвращает или меняет приоритет клиента.
    /// </summary>
    public bool IsPriority { get; set; }

    public List<IDiscount> Discounts{get;set;}

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Customer()
    {
        FullName = "None";
        Address = new Address();
        Cart = new Cart();
        Orders= new List<Order>();
        Discounts = new List<IDiscount>();
        Discounts.Add(new PointsDiscount());

        _allCustomersCount += 1;
        _id = _allCustomersCount;
    }

    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="fullname">Полное ФИО покупателя. Не более 200 символов</param>
    /// <param name="address">Адрес покупателя. Не более 500 символов</param>
    public Customer(string fullname)
    {
        FullName = fullname;
        Address = new Address();
        Cart = new Cart();
        Orders = new List<Order>();
        Discounts= new List<IDiscount>();
        Discounts.Add(new PointsDiscount());

        _allCustomersCount += 1;
        _id = _allCustomersCount;

    }
    public override string ToString()
    {
        return FullName;
    }
}

