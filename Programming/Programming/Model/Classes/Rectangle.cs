public class Rectangle
{
    //Поля
    private double _length;
    private double _widtht;
    private string _color;

    //Свойства и автосвойства
    public double Length
    {
        get
        {
            return _length;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Длина положительна!");
            }
            _length = value;
        }
    }
    public double Widtht
    {
        get
        {
            return _widtht;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Длина положительна!");
            }
            _widtht = value;
        }
    }
    public string Color { get; set; }

    //Конструктор
    public Rectangle(double length, double widtht, string color)
    {
        Length = length;
        Widtht = widtht;
        Color = color;
    }
}