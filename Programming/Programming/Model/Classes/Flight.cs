public class Flight
{
    private string _departurePoint;
    private string _destinationPoint;
    private int _flightTimeMinutes;

    public string DeparturePoint { get; set; }
    public string DestinationPoint { get; set; }

    public int FlightTimeMinutes 
    { 
        get { 
            return _flightTimeMinutes;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Минуты положительны!");
            }
            _flightTimeMinutes = value;
        }
    }
}
