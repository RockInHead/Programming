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
    /// Продолжительноость полета в мин.
    /// </summary>
    private int _flightTimeMinutes;

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
    /// Возвращает и задает продолжительность полета в мин. Должно быть положительным.
    /// </summary>
    public int FlightTimeMinutes 
    { 
        get { 
            return _flightTimeMinutes;
        }
        set
        {
            
            Validator.AssertOnPositiveValue(value);
            _flightTimeMinutes = value;
        }
    }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "None";
        DestinationPoint = "None";
        FlightTimeMinutes = 0;
    }
    /// <summary>
    /// Создает экземпляр класса
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destinationPoint">Пункт следования.</param>
    /// <param name="flightTimeMinutes">Прдолжительность полета в мин. Должна быть положительной.</param>
    public Flight(string departurePoint,string destinationPoint,int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightTimeMinutes = flightTimeMinutes;
    }
}
