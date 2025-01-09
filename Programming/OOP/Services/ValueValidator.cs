using System.Diagnostics;
using System.Text.RegularExpressions;
/// <summary>
/// Осуществляет проверку/валидацию определенных данных.
/// </summary>
class ValueValidator
{
    //Проверка положительности числа
    /// <summary>
    /// Проверяет, что значение типа int положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertStringOnLength(string value, int MaxLength, string propertyName)
    {
        if (value.Length>MaxLength)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {MaxLength} символов!");
        }

    }

    /// <summary>
    /// Проверяет, что длина строки, представленной числом, не превышает максимальную длину.
    /// </summary>
    /// <param name="value">Значение, длина которого будет проверяться.</param>
    /// <param name="MaxLength">Максимально допустимая длина.</param>
    /// <param name="propertyName">Имя свойства для вывода в сообщении об исключении.</param>
    /// <exception cref="ArgumentException">Генерируется, если длина значения превышает максимальную длину.</exception>
    public static void AssertStringOnLength(int value, int MaxLength, string propertyName)
    {
        if (value.ToString().Length > MaxLength)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {MaxLength} символов!");
        }

    }

    /// <summary>
    /// Проверяет, что значение является положительным.
    /// </summary>
    /// <param name="value">Значение для проверки.</param>
    /// <exception cref="ArgumentException">Генерируется, если значение меньше нуля.</exception>
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Значение должно быть положительным!");
        }
    }

    /// <summary>
    /// Проверяет, что значение является положительным.
    /// </summary>
    /// <param name="value">Значение для проверки.</param>
    /// <exception cref="ArgumentException">Генерируется, если значение меньше нуля.</exception>
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Значение должно быть положительным!");
        }
    }

}