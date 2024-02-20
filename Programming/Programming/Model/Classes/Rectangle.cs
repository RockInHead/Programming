public class Rectangle
{
    private double _length;
    private double _widtht;
    private string _color;

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
}