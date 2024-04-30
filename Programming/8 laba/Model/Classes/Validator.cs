using System.Diagnostics;
using System.Text.RegularExpressions;
/// <summary>
/// Осуществляет проверку/валидацию определенных данных.
/// </summary>
class Validator
{
    //Проверка положительности числа
    /// <summary>
    /// Проверяет, что значение типа int положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Длина в свойстве класса {new StackTrace().GetFrame(1).GetMethod().Name} должна быть положительной");
        }

    }
    /// <summary>
    /// Проверяет, что значение типа double положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Длина в свойстве класса {new StackTrace().GetFrame(1).GetMethod().Name} должна быть положительной");
        }

    }
    
    //Проверка что число входит в указаный диапазон
    /// <summary>
    /// Проверяет, что значение типа int входит диапазон от min до max.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значние диапазона.</param>
    /// <param name="max">Максимальное значение диапазона.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertValueInRange(int value, int min, int max)
    {
        if(value < min | value > max)
        {
           throw new ArgumentException($"Диапазон для свойства класса {new StackTrace().GetFrame(1).GetMethod().Name} от {min} до {max}");
        }
    }
    /// <summary>
    /// Проверяет, что значение типа double входит диапазон от min до max.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значние диапазона.</param>
    /// <param name="max">Максимальное значение диапазона.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertValueInRange(double value, int min, int max)
    {
        if (value < min | value > max)
        {
            throw new ArgumentException($"Диапазон для свойства класса {new StackTrace().GetFrame(1).GetMethod().Name} от {min} до {max}");
        }
    }

    public static void AssertStringContainsSymbolsForCities(string value)
    {

        if (!Regex.IsMatch(value, "^[a-zA-Zа-яА-Я-_ ]*$"))
        {

            throw new ArgumentException($"Без цифр! {new StackTrace().GetFrame(1).GetMethod().Name}");
        }
      
    }
}