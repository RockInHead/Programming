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
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Длина в свойстве класса {new StackTrace().GetFrame(1).GetMethod().Name} должна быть положительной");
        }

    }

    public static void AssertValueInRange(int value, int min, int max)
    {
        if(value < min | value > max)
        {
           throw new ArgumentException($"Диапазон для свойства класса {new StackTrace().GetFrame(1).GetMethod().Name} от {min} до {max}");
        }
    }

    public static void AssertValueInRange(double value, int min, int max)
    {
        if (value < min | value > max)
        {
            throw new ArgumentException($"Диапазон для свойства класса {new StackTrace().GetFrame(1).GetMethod().Name} от {min} до {max}");
        }
    }
}