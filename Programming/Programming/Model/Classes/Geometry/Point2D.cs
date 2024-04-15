/// <summary>
/// Хранит данные о точке:Координату X, Координату Y.
/// </summary>
public class Point2D
{
    //Поля
    /// <summary>
    /// Координата X.
    /// </summary>
    private double _coordinateX;
    /// <summary>
    /// Координата Y.
    /// </summary>
    private double _coordinateY;

    //Свойства
    /// <summary>
    /// Задаёт и возвращает коордтнату X. Должна быть положительной.
    /// </summary>
    public double CoordinateX
    {
        get
        {
            return _coordinateX;
        }
         private set
        {
            Validator.AssertOnPositiveValue(value);

            _coordinateX= value;
        }
    }
    /// <summary>
    /// Задаёт и возвращает коордтнату Y. Должна быть положительной.
    /// </summary>
    public double CoordinateY
    {
        get
        {
            return _coordinateY;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _coordinateY = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса.
    /// </summary>
    /// <param name="coordinateX">Координата X. Должна быть положительной.</param>
    /// <param name="coordinateY">Координата X. Должна быть положительной.</param>
    public Point2D(double coordinateX,double coordinateY)
    {
        CoordinateX = coordinateX;
        CoordinateY= coordinateY;
    }
}