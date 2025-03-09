using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{ 
    /// <summary>
    /// Конвертер, преобразующий значение типа <see cref="bool"/>
    /// в значение перечисления <see cref="Visibility"/>.
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует значение типа <see cref="bool"/>
        /// в значение перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение типа <see cref="bool"/>,
        /// которое необходимо преобразовать.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns>
        /// Возвращает <see cref="Visibility.Visible"/>,
        /// если значение <paramref name="value"/> равно <c>true</c>,
        /// и <see cref="Visibility.Collapsed"/> в противном случае.
        /// </returns>
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        /// <summary>
        /// Преобразует значение обратно из <see cref="Visibility"/> в <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Значение типа <see cref="Visibility"/>,
        /// которое необходимо преобразовать обратно.</param>
        /// <param name="targetType">Тип целевого свойства (не используется).</param>
        /// <param name="parameter">Дополнительный параметр (не используется).</param>
        /// <param name="culture">Культура (не используется).</param>
        /// <returns>
        /// Метод не реализован и всегда выбрасывает исключение
        /// <see cref="NotImplementedException"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">Метод не реализован.</exception>
        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}