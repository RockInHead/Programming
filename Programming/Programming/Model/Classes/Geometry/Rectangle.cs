using System.Drawing;
/// <summary>
/// Хранит данные о прямоугольнике: Длина, Ширина,Цвете ,Кол-во всех экзепляров класса, Уникальный айди номер,Точку центра прямоугольника.
/// </summary>
public class Rectangle
{
    //Поля
    /// <summary>
    /// Длина.
    /// </summary>
    private int _length;
    /// <summary>
    /// Ширина.
    /// </summary>
    private int _width;
    /// <summary>
    /// Статичесое знаечние о кол-ве всех экземплярах класса.
    /// </summary>
    private static int _allRectanglesCount;
    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private int _id;
    /// <summary>
    /// Точка центра прямоугольника.
    /// </summary>
    private Point2D _center;

    //Свойства и автосвойства
    /// <summary>
    /// Задает и возвращает длину прямоугольника. Должна быть положительной.
    /// </summary>
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            //Validator validator = new Validator();
            Validator.AssertOnPositiveValue(value);
            _length = value;
            //if (value < 0) throw new ArgumentException("Длина положительна!");
            //_length = value;
        }
    }
    /// <summary>
    /// Задает и возвращает ширину прямоугольника. Должна быть положительной.
    /// </summary>
    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;

            /*if (value < 0)
            {
                throw new ArgumentException("Длина положительна!");
            }*/
        }
    }
    /// <summary>
    /// Возвращает и задает цвет прямоугольника.
    /// </summary>
    public string Color { get; set; }

    Random random = new Random();
    /// <summary>
    /// Возвращает точку центра прямоугольника.
    /// </summary>
    public Point2D Center
    {
        get
        {
            // return new Point2D((Length / 2.0), (Width / 2.0));
            //return new Point2D(random.Next(0, 300), random.Next(0, 300));
            return _center;
        }
    }
    /// <summary>
    /// Возвращает значение о кол-ве всех экземплярах класса.
    /// </summary>
    public int AllRectanglesCount{
    get
        {
            return _allRectanglesCount;
        }
    }
    /// <summary>
    /// Возвращает уникальный идентификатор.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }
    //Конструкторы
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "None";

        //Не совсем уверен нужно ли +1 каунтер когда создаем пустые экземпляры?
        //Но без нее работает корректно(вроде) ¯\_(ツ)_/¯
        //_allRectanglesCount += 1;
        //_id = _allRectanglesCount;
       
    }
    /// <summary>
    /// Создает экземпляр класса. Считает/Генерирует значение точки центра прямоугольника. При создании нового экземпляра класса добавляет 1 к общему кол-ву прямоугольников. 
    /// </summary>
    /// <param name="length">Длина.Должна быть положительной.</param>
    /// <param name="width">Ширина.Должна быть положительной.</param>
    /// <param name="color">Цвет.</param>
    public Rectangle(int length, int width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
        _allRectanglesCount += 1;
        _id = _allRectanglesCount;
        
        _center= new Point2D(random.Next(0, 500), random.Next(0, 500));
    }


}