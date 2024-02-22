public class Song
{
    //Поля
    private string _name;
    private string _author;
    private int _durationsSeconds;
    //Свойства и автосвойства
    public string Name { get; set; }
    public string Author { get; set; }
    public int DurationSeconds
    {
        get
        {
            return _durationsSeconds;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Положительное значение!");
            }
            _durationsSeconds = value;
        }
    }
    //Конструктор
    public Song(string name, string author,int durationSeconds)
    {
        Name = name;
        Author = author;
        DurationSeconds = durationSeconds;
    }
}