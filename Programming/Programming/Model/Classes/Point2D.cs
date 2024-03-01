public class Point2D
{
    //Поля
    public int _coordinateX;
    public int _coordinateY;

    //Свойства
    public int CoordinateX
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
    public int CoordinateY
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

    public  Point2D(int coordinateX,int coordinateY)
    {
        CoordinateX = coordinateX;
        CoordinateY= coordinateY;
    }
}