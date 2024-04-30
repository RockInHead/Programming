/// <summary>
/// Хранит данные о рейсе:Пункт отправления, Пункт прибытия Продолжительность полета в мин.
/// </summary>
public class Flight
{
    //Поля
    /// <summary>
    /// Пункт отправления.
    /// </summary>
    private string _departurePoint;
    /// <summary>
    /// Пункт прибытия.
    /// </summary>
    private string _destinationPoint;
    /// <summary>
    /// Время вылета
    /// </summary>
    private DateTime _departureDate;
    /// <summary>
    /// Продолжительноость полета в мин.
    /// </summary>
    private int _flightTimeMinutes;
    /// <summary>
    /// Тип вылета.
    /// </summary>
    private TypesOfFlight _typeOfFlight;

    //Свойства  автосвойства
    /// <summary>
    /// Возвращает и задает пункт отправления.
    /// </summary>
    public string DeparturePoint { get; set; }

    /// <summary>
    /// Возвращает и задает пункт следования.
    /// </summary>
    public string DestinationPoint { get; set; }

    /// <summary>
    /// Возвращает и задает дату вылета. Должна быть не ранее сегодняшней.
    /// </summary>
    public DateTime DepartureDate
    {
        get
        {
            return _departureDate;
        }
        set
        {
            if (value < DateTime.Today)
            {
                throw new ArgumentException("Дата на ранее сегодня!");
            }
            _departureDate = value;
        }
    }

    /// <summary>
    /// Возвращает и задает продолжительность полета в мин. Должно быть положительным.
    /// </summary>
    /// 
    public int FlightTimeMinutes 
    { 
        get 
        { 
            return _flightTimeMinutes;
        }
        set
        {
            
            Validator.AssertOnPositiveValue(value);
            _flightTimeMinutes = value;
        }
    }
    /// <summary>
    /// Возвращает и задает тип перелета.
    /// </summary>
    public TypesOfFlight TypeOfFlight { get; set; }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "None";
        DestinationPoint = "None";
        DepartureDate = DateTime.Today;
        FlightTimeMinutes = 0;
        TypeOfFlight = TypesOfFlight.Внутренний;

    }
    /// <summary>
    /// Создает экземпляр класса
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destinationPoint">Пункт следования.</param>
    /// <param name="flightTimeMinutes">Прдолжительность полета в мин. Должна быть положительной.</param>
    public Flight(string departurePoint,string destinationPoint,DateTime departureDate,int flightTimeMinutes,TypesOfFlight typesOfFlight)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        DepartureDate= departureDate;
        FlightTimeMinutes = flightTimeMinutes;
        TypeOfFlight = typesOfFlight;
    }
}
