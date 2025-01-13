namespace OOP.Services
{
    /// <summary>
    /// Статический класс для сортировки и фильтрации товаров.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Делегат для определения критерия сортировки.
        /// </summary>
        /// <param name="item1">Первый элемент для сравнения.</param>
        /// <param name="item2">Второй элемент для сравнения.</param>
        /// <returns>Возвращает <c>true</c>, если первый элемент должен быть перед вторым; в противном случае - <c>false</c>.</returns>
        public delegate bool SortingCriteria(Item item1,Item item2);

        /// <summary>
        /// Фильтрует список элементов по заданному критерию.
        /// </summary>
        /// <param name="items">Список элементов для фильтрации.</param>
        /// <param name="sortingCriteria">Функция, определяющая критерий фильтрации.</param>
        /// <returns>Новый список элементов, соответствующих критериям фильтрации.</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> sortingCriteria)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (sortingCriteria(item))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }

        /// <summary>
        /// Сортирует список элементов по заданному критерию сортировки.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="sortingCriteria">Делегат, определяющий критерий сортировки.</param>
        /// <returns>Отсортированный список элементов.</returns>        
        public static List<Item> SortBy(List<Item> items, SortingCriteria sortingCriteria )
        {
            List<Item> sortedList = new List<Item>(items.Count);
            for(int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
                {
                    if (sortingCriteria(items[j], items[j + 1]))
                    {
                        (items[j], items[j+1]) = (items[j+1], items[j]);
                    }
                }
            }
            return items;
        }
    }
}
