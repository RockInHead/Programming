namespace OOP.Model.Discounts
{
    /// <summary>
    /// Хранит данные о накопительной скидке: накопленные баллы.
    /// </summary>
    public class PointsDiscount : IDiscount,IComparable<PointsDiscount>
    {
        /// <summary>
        /// Содержит количество накопленных баллов пользователя.
        /// </summary>
        private int _accumulatedPoints;

        /// <summary>
        /// Получает накопленные баллы.
        /// </summary>
        /// <value>Текущее число накопленных баллов.</value>
        public int AccumulatedPoints
        {
            get
            {
                return _accumulatedPoints;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value);
                _accumulatedPoints = value;
            }
        }

        /// <summary>
        /// Получает информацию о накопленных баллах в формате строки.
        /// </summary>
        /// <value>Строка, содержащая информацию о накопительных баллах.</value>
        public string Info
        {
            get
            {
                return $"Накопительная - {AccumulatedPoints} баллов";
            }
        }

        /// <summary>
        /// Считает и возвращает общую стоимость товаров. 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private double GetAmount(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }

            return Math.Round(sum, 2);
        }

        /// <summary>
        /// Считает доступную скидку. Если кол-во баллов больше 30% от общей стоимости товаров, 
        /// то возвращает скидку в 30% от стоимости товаров. Иначе возвращает все доступыне баллы.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            if (AccumulatedPoints > amount * 0.3)
            {
                return Math.Floor(amount * 0.3);
            }
            else
            {
                return AccumulatedPoints;
            }
        }

        /// <summary>
        /// Возврщает доступную скидку для данных товаров,
        /// при этом списывая баллы с общего количества.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);

            AccumulatedPoints -= (int)discountAmount;
            return discountAmount;
        }

        /// <summary>
        /// Добавляет 10% от стоимости всех товаров в общее количество скидочных баллов. 
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            AccumulatedPoints += (int)Math.Ceiling(amount * 0.1);
        }

        /// <summary>
        /// Сравнивает текущую скидку на основе накопленных баллов с другой скидкой.
        /// </summary>
        /// <param name="other">Скидка, с которой производится сравнение.</param>
        /// <returns>
        /// Возвращает 0, если накопленные баллы равны; 
        /// 1, если текущие накопленные баллы больше;
        /// -1, если текущие накопленные баллы меньше.
        /// </returns>
        public int CompareTo(PointsDiscount? other)
        {

            if (object.ReferenceEquals(this, other)) 
            {
                return 0;
            }

            return AccumulatedPoints.CompareTo(other.AccumulatedPoints);
        }
    }
}
