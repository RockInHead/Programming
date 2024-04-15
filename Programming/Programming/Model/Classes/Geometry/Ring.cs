/// <summary>
/// Хранит данные о кольце:Внутренний радиус кольца, Внешний радиус кольца, Точку центра кольца,Площади кольца.
/// </summary>
public class Ring
{
   /// <summary>
   /// Внешний радиус.
   /// </summary>
    private double _outerRadius;
    /// <summary>
    /// Внутренний радиус.
    /// </summary>
    private double _innerRadius;

    /// <summary>
    /// Задаёт и возвращает внешний диаметр. Должен быть положительным и больше внутреннего диаметра.
    /// </summary>
    public double OuterRaduis
    {
        get
        {
            return _outerRadius;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value < InnerRadius)
            {
                throw new ArgumentException();
            }
            _outerRadius = value;
        }
    }

    /// <summary>
    /// Задаёт и возвращает внутренний диаметр. Должен быть положительным и меньше внешнего диаметра.
    /// </summary>
    public double InnerRadius
    {
        get
        {
            return _innerRadius;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value > OuterRaduis)
            {
                throw new ArgumentException();
            }
            _innerRadius = value;
        }
    }
    /// <summary>
    /// Считает и возвращает точку центра кольца.
    /// </summary>
    public Point2D Center
    {
        get
        {
            return new Point2D((OuterRaduis / 2.0), (InnerRadius / 2.0));
        }
    }
    /// <summary>
    /// Считает и возвращает площадь кольца.
    /// </summary>
    public double Area
    {
        get
        {
            return Math.PI * (Math.Pow(OuterRaduis, 2) -  Math.Pow(InnerRadius,2));
        }
    }
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Ring()
    {
        OuterRaduis = 0;
        InnerRadius=0;
    }
    /// <summary>
    /// Создает экземпляр класса.
    /// </summary>
    /// <param name="outerRadius">Внешний диаметр.Должен быть положительным и больше внутреннего диаметра.</param>
    /// <param name="innerRadius">Внутренний диаметр.Должен быть положительным и меньше внешнего диаметра.</param>
    public Ring(double  outerRadius, double innerRadius)
    {
        OuterRaduis = outerRadius;
        InnerRadius = innerRadius;
    }
    }

