public class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value <0 |value > 23 )
            {
                throw new ArgumentException("Часы от 0 до 23!");
            }
            _hours = value;
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value<0 | value > 60)
            {
                throw new ArgumentException("Минуты от 0 до 60");
            }
            _minutes = value;
        }
    }
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            if (value < 0 | value > 60)
            {
                throw new ArgumentException("Секунды от 0 до 60");
            }
            _seconds = value;
        }
    }
}