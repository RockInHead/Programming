using System.Drawing;

public class Rectangle
{
    //Поля
    private int _length;
    private int _width;
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

    //Конструкторы
    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "None";
        //Center= new Point2D(Length/2,Width/2);
        //Center = new Point2D();
    }
    
    public Rectangle(int length, int width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
        
        //Center = new Point2D((Length / 2.0), (Width / 2.0));

    }


}