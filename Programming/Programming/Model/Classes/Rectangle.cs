using System.Drawing;

public class Rectangle
{
    //Поля
    private int _length;
    private int _width;
    public string Color { get; set; }

    //Свойства и автосвойства
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            if (value < 0) throw new ArgumentException("Длина положительна!");
            _length = value;
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
            if (value < 0)
            {
                throw new ArgumentException("Длина положительна!");
            }
            _width = value;
        }
    }

    //Конструкторы
    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "None";

    }
    public Rectangle(int length, int width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }
}