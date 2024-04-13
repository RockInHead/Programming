using System.Xml.Linq;
/// <summary>
/// Хранит данные о дисциплине:Название,Общее кол-во часов,Оценку,Фамилию учителя.
/// </summary>
public class Discipline
{
    //Поля
    /// <summary>
    /// Название дисциплины - string.
    /// </summary>
    private string _name;
    /// <summary>
    /// Общее кол-во часов на дисциплину - int.
    /// </summary>
    private int _hoursInGeneral;
    /// <summary>
    /// Оценка за дисциплину - int.
    /// </summary>
    private int _assessment;
    /// <summary>
    /// Фамилия учителя по дисциплне - string.
    /// </summary>
    private string _teacherSurname;

    //Свойства и автосвойства
    /// <summary>
    /// Возвращает и задает название дисциплины.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Возвращает и задает общее кол-во часов на дисциплину.Должно быть положительным числом.
    /// </summary>
    public int HoursInGeneral
    {
        get
        {
            return _hoursInGeneral;
        }
        set
        {
         
            Validator.AssertOnPositiveValue(value);
            _hoursInGeneral = value;
        }
    }
    /// <summary>
    /// Возвращает и задает оценку за дисциплину.Должно быть положительным числом.
    /// </summary>
    public int Assessment
    {
        get
        {
            return _assessment;
        }
        set
        {
            /*if(value<2 | value > 5)
            {
                throw new ArgumentException("Оценка от 2 до 5!");
            }*/
            Validator.AssertOnPositiveValue(value);
            _assessment = value;
        }
    }
    /// <summary>
    /// Возвращает и задает фамилию учителя по дисциплине.
    /// </summary>
    public string TeacherSurname { get; set; }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Discipline()
    {
        Name = "None";
        HoursInGeneral = 0;
        Assessment = 0;
        TeacherSurname = "None";
    }
    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="name">Название дисциплины</param>
    /// <param name="hoursInGeneral">Общее кол-во часов на дисциплину.Должно быть положительным.</param>
    /// <param name="assessment">Оценка.Должна быть положительной.</param>
    /// <param name="teacherSurname">Фамилия учителя по дисциплине.</param>
    public Discipline(string name, int hoursInGeneral, int assessment,string teacherSurname)
    {
        Name = name;
        HoursInGeneral = hoursInGeneral;
        Assessment = assessment;
        TeacherSurname = teacherSurname;
    }
}