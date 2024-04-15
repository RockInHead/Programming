/// <summary>
/// Осуществляет рандомную генерацию прямоугольника.
/// </summary>
static public class RectangleFactory
{
    /// <summary>
    /// Генерирует прямоугольник с рандомными полями.
    /// </summary>
    /// <returns>Возвращает рандомно сгенерируемый прямоугольник.</returns>
    static public Rectangle Randomize()
    {
        Random random = new Random();
        string[] Colors = Enum.GetValues(typeof(Color)).Cast<Genre>().Select(x => x.ToString()).ToArray();
        int length = random.Next(10,200);
        int width = random.Next(10, 200);
        string color = Colors[random.Next(Colors.Length)];

        return new Rectangle(length,width,color);
    }
}
