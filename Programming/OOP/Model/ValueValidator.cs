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
   
   
   
}