/// <summary>
/// Осуществляет рандомную генерацию рейсов.
/// </summary>
static public class FlightFactory
{
    /// <summary>
    /// Генерирует рейс с рандомными полями.
    /// </summary>
    /// <returns>Возвращает рандомно сгенерируемый рейс.</returns>
    static public Flight Randomize()
    {
        string[] Cities = (string[])Enum.GetNames(typeof(Cities));
        Random random = new Random();

        int cityIndex = random.Next(0, Cities.Length);
        string departute = Cities[cityIndex];
        string destination = Cities[cityIndex == Cities.Length - 1 ? cityIndex - random.Next(0, cityIndex) : cityIndex + 1];

        DateTime start = DateTime.Today;
        DateTime end = new DateTime(2050, 12, 31);
        int range = (end - start).Days;
        DateTime dateTime = start.AddDays(random.Next(range));

        int flightDuration = random.Next(0, 1000);
        TypesOfFlight typesOfFlight = (TypesOfFlight)random.Next(2);

        return new Flight(departute, destination, dateTime, flightDuration, typesOfFlight);

    }
}