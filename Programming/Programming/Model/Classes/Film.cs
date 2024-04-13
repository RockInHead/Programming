using System.Xml.Linq;
/// <summary>
/// Хранит данные о фильме: Название,Продолжительность в мин,Год выпуска,Жанр,Рейтинг.
/// </summary>
public class Film
{
    //Поля
    /// <summary>
    /// Название фильма.
    /// </summary>
    private string _name;
    /// <summary>
    /// Продолжительность в мин.
    /// </summary>
    private int _durationMinutes;
    /// <summary>
    /// Год выпуска.
    /// </summary>
    private int _releaseYear;
    /// <summary>
    /// Жанр фильма.
    /// </summary>
    private string _genre;
    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    private double _rating;

    //Свойства и автосвойства
    /// <summary>
    /// Возвращает и задает название фильма.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Возвращает и задает продолжительность фильма в мин.Должно быть положительным.
    /// </summary>
    public int DurationMinutes
    {
        get
        {
            return _durationMinutes;
        }
        set
        {
           
            Validator.AssertOnPositiveValue(value);
            _durationMinutes = value;
        }
    }
    /// <summary>
    /// Возвращает и задает год выпуска фильма. Должен быть от 1900 до 2024 включительно.
    /// </summary>
    public int ReleaseYear
    {
        get
        {
            return _releaseYear;
        }
        set
        {
            /*if (1900 > value | value > 2024)
            {
                throw new ArgumentException("Год от 1900 до 2024!");
            }*/
            Validator.AssertValueInRange(value,1900,2024);
            _releaseYear= value;
        }
    }
    /// <summary>
    /// Возвращает и задает жанр фильма.
    /// </summary>
    public string Genre { get; set; }
    /// <summary>
    /// Возвращает и задает рейтинг фильма.Должен быть положительным.
    /// </summary>
    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            /*if(0>value | value > 10)
            {
                throw new ArgumentException("Рейтинг от 0 до 10!");
            }*/
            Validator.AssertValueInRange(value, 0, 10);

            _rating = value;
        }
    }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Film()
    {
        Name = "None";
        DurationMinutes = 0;
        ReleaseYear = 2020;
        Genre = "None";
        Rating = 0;

    }
    /// <summary>
    /// Содает экземпляр класса.
    /// </summary>
    /// <param name="name">Название.</param>
    /// <param name="durationMinutes">Продолжительность в мин.Должно быть положительным.</param>
    /// <param name="releaseYear">Год выпуска фильма.От 1900 до 2024 включительно.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.Должен быть положительным</param>
    public Film(string name,int durationMinutes,int releaseYear,string genre,double rating)
    {
        Name = name;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
}
