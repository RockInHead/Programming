using System.Diagnostics;

class Validator
{
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Длина в свойстве класса {new StackTrace().GetFrame(1).GetMethod().Name} должна быть положительной");
        }
    }
}