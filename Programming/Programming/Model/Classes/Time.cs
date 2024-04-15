/// <summary>
/// Хранит данные о времени:Часы,Минуты,Секунды.
/// </summary>
public class Time
{
    //Поля
    /// <summary>
    /// Часы.
    /// </summary>
    private int _hours;
    /// <summary>
    /// Минуты.
    /// </summary>
    private int _minutes;
    /// <summary>
    /// Секунды.
    /// </summary>
    private int _seconds;
    //Свойства и автосвойства
    /// <summary>
    /// Возвращает и задает часы.Должно от 0 до 23.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задает минуты.Должно от 0 до 60.
    /// </summary>
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
    /// <summary>
    /// Возвращает и задает секунды.Должно от 0 до 60.
    /// </summary>
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
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds =0;
    }
    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="hours">Часы.Должны быть от 0 до 23.</param>
    /// <param name="minutes">Минуты.Должны быть от 0 до 60.</param>
    /// <param name="seconds">Секунды.Должны быть от 0 до 60.</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}