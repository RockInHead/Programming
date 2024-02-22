using System.Xml.Linq;

public class Film
{
    //Поля
    private string _name;
    private int _durationMinutes;
    private int _releaseYear;
    private string _genre;
    private double _rating;

    //Свойства и автосвойства
    public string Name { get; set; }
    public int DurationMinutes
    {
        get
        {
            return _durationMinutes;
        }
        set
        {
            if( value < 0 ) 
            { 
            throw new ArgumentException( "Не может быть отрицательным!" );
             }
            _durationMinutes = value;
        }
    }
    public int ReleaseYear
    {
        get
        {
            return _releaseYear;
        }
        set
        {
            if (1900 > value | value > 2024)
            {
                throw new ArgumentException("Год от 1900 до 2024!");
            }
            _releaseYear= value;
        }
    }
    public string Genre { get; set; }
    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if(0>value | value > 10)
            {
                throw new ArgumentException("Рейтинг от 0 до 10!");
            }
            _rating= value;
        }
    }

    //Конструктор
    public Film()
    {
        Name = "None";
        DurationMinutes = 0;
        ReleaseYear = 2020;
        Genre = "None";
        Rating = 0;

    }
    public Film(string name,int durationMinutes,int releaseYear,string genre,double rating)
    {
        Name = name;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
}
