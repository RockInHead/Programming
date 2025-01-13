namespace OOP.Model
{
    /// <summary>
    /// Интерфейс для скидок. 
    /// Имеет функции расчета, применения и обновления скидки.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет сумму скидки для списка предметов.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Сумма скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к списку предметов и возвращает общую сумму после применения скидки.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Общая сумма после применения скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет информацию о скидке на основе переданного списка предметов.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        void Update(List<Item> items);
    }
}
