using System.Xml.Linq;
/// <summary>
/// Хранит данные о песне: Название,Автора,Продолжительность в сек.
/// </summary>
public class Song
{
    //Поля
    /// <summary>
    /// Название песни.
    /// </summary>
    private string _name;
    /// <summary>
    /// Автор песни.
    /// </summary>
    private string _author;
    /// <summary>
    /// Продолжительность в сек.
    /// </summary>
    private int _durationsSeconds;
    //Свойства и автосвойства
    /// <summary>
    /// Возваращает и задает название песни.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Возвращает и задает автора песни.
    /// </summary>
    public string Author { get; set; }
    /// <summary>
    /// Возвращает и задает продолжительность пенсни в сек. Должна быть положительной.
    /// </summary>
    public int DurationSeconds
    {
        get
        {
            return _durationsSeconds;
        }
        set
        {
            /*if (value < 0)
            {
                throw new ArgumentException("Положительное значение!");
            }*/
            Validator.AssertOnPositiveValue(value);
            _durationsSeconds = value;
        }
    }
    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Song()
    {
        Name = "None";
        Author = "None";
        DurationSeconds = 0;
    }
    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="name">Название песни.</param>
    /// <param name="author">Автор песни.</param>
    /// <param name="durationSeconds">Продолжительность песни в сек. Должна быть положительной.</param>
    public Song(string name, string author,int durationSeconds)
    {
        Name = name;
        Author = author;
        DurationSeconds = durationSeconds;
    }
}