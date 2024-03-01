public class Time
{
    //Поля
    private int _hours;
    private int _minutes;
    private int _seconds;
    //Свойства и автосвойства
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            /*if (value <0 |value > 23 )
            {
                throw new ArgumentException("Часы от 0 до 23!");
            }*/
            Validator.AssertValueInRange(value, 0, 23);
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
            /*if (value<0 | value > 60)
            {
                throw new ArgumentException("Минуты от 0 до 60");
            }*/
            Validator.AssertValueInRange(value, 0, 60);
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
            /*if (value < 0 | value > 60)
            {
                throw new ArgumentException("Секунды от 0 до 60");
            }*/
            Validator.AssertValueInRange(value, 0, 60);
            _seconds = value;
        }
    }

    //Конструктор
    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds =0;
    }
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}