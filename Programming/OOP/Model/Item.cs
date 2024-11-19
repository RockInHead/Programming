using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

using System.Text.RegularExpressions;

/// <summary>
/// Хранит данные о товаре:Уникальный айди,Имя товара,Имя товара,Описание товара, Стоимость товара, Категорию товара.
/// </summary>
public class Item : ICloneable ,IComparable<Item>/*, IEquatable<Item>*/
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

    /// <summary>
    /// Категория товара.
    /// </summary>
    private Category _category;


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
    /// Событие изменения названия товара.
    /// </summary>
    public event EventHandler<EventArgs> NameChanged;
    /// <summary>
    /// Событие изменения описания товара.
    /// </summary>
    public event EventHandler<EventArgs> InfoChanged;
    /// <summary>
    /// Событие изменения стоимости товара.
    /// </summary>
    public event EventHandler<EventArgs> CostChanged;

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
            NameChanged?.Invoke(this, EventArgs.Empty);
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
            InfoChanged?.Invoke(this, EventArgs.Empty);
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
            if(value<100000 && value >= 0)
            {
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                throw new Exception("Cost должно быть от 0 до 100000");
            }
        }
    }

    public Category Category { get; set; }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Item()
    {
        Name = "None";
        Info = "None";
        Cost = 0;

        _allItemsCount += 1;
        _id = _allItemsCount;
    }

    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="name">Имя товара. Не более 200 символов</param>
    /// <param name="info">Описание товара. Не более 1000 символов</param>
    /// <param name="cost">Стоимость товара. От 0 до 100000</param>
    /// <param name="category">Категория товара. Одна из 7</param>
    /// 
    public Item(string name, string info, double cost, Category category)
    {
        Name = name;
        Info = info;
        Cost = cost;
        Category = category;

        _allItemsCount += 1;
        _id = _allItemsCount;
    }

    public override string ToString()
    {
        return Name;
    }
    /// <summary>
    /// Делает копию объекта по всем полям, кроме Id.
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        return new Item(this.Name, this.Info, this.Cost, this.Category);
    }
    /// <summary>
    /// Объекты равны тогда, когда у них равны все поля кроме ID.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public override bool Equals(object other)
    {
        if (other == null)
            return false;
        if (other is not Item)
            return false;
        if (object.ReferenceEquals(this, other))
            return true;
        Item item = (Item)other;
        return (this.Name == item.Name && this.Info == item.Info && this.Cost == item.Cost && this.Category==item.Category);
    }
    /// <inheritdoc/>
    public int CompareTo(Item? item2)
    {

        if (object.ReferenceEquals(this, item2))
            return 0;
        if (Cost > item2.Cost)
        {
            return 1;
        }
        if (Cost < item2.Cost)
        {
            return -1;
        }
        else if (Cost == item2.Cost)
        {
            return 0;
        }
        return 1;
    }
}

