public class Flight
{
    //Поля
    private string _departurePoint;
    private string _destinationPoint;
    private int _flightTimeMinutes;

    //Свойства  автосвойства
    public string DeparturePoint { get; set; }
    public string DestinationPoint { get; set; }
    public int FlightTimeMinutes 
    { 
        get { 
            return _flightTimeMinutes;
        }
        set
        {
            /*if(value < 0)
            {
                throw new ArgumentException("Минуты положительны!");
            }*/
            Validator.AssertOnPositiveValue(value);
            _flightTimeMinutes = value;
        }
    }

    //Конструктор
    public Flight()
    {
        DeparturePoint = "None";
        DestinationPoint = "None";
        FlightTimeMinutes = 0;
    }
    public Flight(string departurePoint,string destinationPoint,int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightTimeMinutes = flightTimeMinutes;
    }
}
