public class Point2D
{
    //Поля
    private double _coordinateX;
    private double _coordinateY;

    //Свойства
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

    public  Point2D(double coordinateX,double coordinateY)
    {
        CoordinateX = coordinateX;
        CoordinateY= coordinateY;
    }
}