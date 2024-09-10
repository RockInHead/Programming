using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

using System.Text.RegularExpressions;

/// <summary>
/// Хранит данные о товаре:Уникальный айди,Имя товара,Имя товара,Описание товара, Стоимость товара.
/// </summary>
public class Item
{
    //Поля
    /// <summary>
    /// Уникальный айди товара.
    /// </summary>
    private int _id;
    /// <summary>
    /// Статическое значение количества всех экзепляров товаров.
    /// </summary>
    private static int _allItemsCount;
    /// <summary>
    /// Имя товара.
    /// </summary>
    private string _name;
    /// <summary>
    /// Описание товара.
    /// </summary>
    private string _info;
    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private  double _cost;



    //Свойства  автосвойства

    /// <summary>
    /// Возвращает значение о кол-ве всех экземплярах класса.
    /// </summary>
    public int AllItemsCount
    {
        get
        {
            return _allItemsCount;
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
    /// Возвращает и задает имя товара.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, Name);
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает описание товара.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, Info);
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задает стоимость товара.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            if(value<100000 && value > 0)
            {
                _cost = value;

            }
            else
            {
                throw new Exception("Cost должно быть от 0 до 100000");
            }
        }
    }

    

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Item()
    {
        Name = "None";
        Info = "None";
        Cost = 0;

    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name">Имя товара. Не более 200 символов</param>
    /// <param name="info">Описание товара. Не более 1000 символов</param>
    /// <param name="cost">Стоимость товара. От 0 до 100000</param>
    public Item(string name, string info, double cost)
    {
        Name= name;
        Info = info;
        Cost = cost;

        _allItemsCount += 1;
        _id = _allItemsCount;

    }
}

