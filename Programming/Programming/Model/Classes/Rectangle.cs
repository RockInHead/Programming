using System.Drawing;

public class Rectangle
{
    //Поля
    private int _length;
    private int _width;
    private static int _allRectanglesCount;
    private int _id;
    //private Point2D _center;

    //Свойства и автосвойства
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
    public string Color { get; set; }
    public Point2D Center {
        get
        {
            return new Point2D((Length / 2.0), (Width / 2.0));
        }
    }

    public int AllRectanglesCount{
    get
        {
            return _allRectanglesCount;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }
    }
    //Конструкторы
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

    public Rectangle(int length, int width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
        _allRectanglesCount += 1;
        _id = _allRectanglesCount;
        

    }


}