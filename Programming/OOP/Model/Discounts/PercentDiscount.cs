using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Discounts
{
    /// <summary>
    /// Хранит данные о процентной скидке: текущий процент,
    /// категории для скидок и сумму стоимости всех товаров конкретной категории товаров.
    /// </summary>
    public class PercentDiscount : IDiscount,IComparable<PercentDiscount>
    {

        /// <summary>
        /// Текущая скидка в процентах
        /// </summary>
        private int _currentDiscountPercent;
        /// <summary>
        /// Категория товаров, на которую предоставляется скидка.
        /// </summary>
        private Category _discountCategory;
        /// <summary>
        /// Сумма стоимости всех товаров конкретной категории.
        /// </summary>
        private double _accumulatedAmount;

        /// <summary>
        /// Свойство, представляющее текущий процент скидки.
        /// </summary>
        public int CurrentDiscountPercent 
        {
            get {
                return _currentDiscountPercent;
                    }
            set {
                if (value <= 10)
                {
                    _currentDiscountPercent = value;
                }
            
            } 
        }

        /// <summary>
        /// Свойство, представляющее категорию скидки.
        /// </summary>
        public Category DiscountCategory {
            get {
            return _discountCategory;
            }
             set{
                _discountCategory = value;
            }
        }

        /// <summary>
        /// Свойство, представляющее накопленную сумму.
        /// </summary>
        public double AccumulatedAmount
        {
            get
            {
                return _accumulatedAmount;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value);
                _accumulatedAmount = value;
            }
        }

        /// <summary>
        /// Свойство, представляющее информацию о скидке в строковом формате.
        /// </summary>
        /// <returns>Строка с информацией о категории скидки и проценте.</returns>
        public string Info
        {
            get
            {
                return $"Процентная {DiscountCategory.ToString()} - {CurrentDiscountPercent}%";
            }
        }

        /// <summary>
        /// Считает и возвращает общую стоимость товаров конретной категории. 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private double GetAmount(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                if (item.Category == _discountCategory)
                {
                    sum += item.Cost;
                }
            }
            return Math.Round(sum, 2);

        }

        /// <summary>
        /// Вычисляет сумму скидки на основе предоставленного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров, для которых нужно рассчитать скидку.</param>
        /// <returns>Вычисленная сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);

            double res= amount * (CurrentDiscountPercent / 100.0);
            return res;

        }

        /// <summary>
        /// Применяет скидку и возвращает общую сумму товаров.
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка.</param>
        /// <returns>Общая сумма товаров.</returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = GetAmount(items);
            return discountAmount;
        }

        /// <summary>
        /// Обновляет текущий процент скидки на основе общей суммы товаров.
        /// Скидка увеличивается на 1% за каждые 1000 единиц общей суммы.
        /// </summary>
        /// <param name="items">Список товаров, для которых обновляется скидка.</param>
        public void Update(List<Item> items)
        {
            int updateRes= (int)(GetAmount(items) / 1000);
            for(int percent=0;percent<updateRes;percent++)
            { 
                CurrentDiscountPercent += 1;
            }

        }
        /// <summary>
        /// Инициализирует новый экземпляр класса PercentDiscount с начальным процентом скидки.
        /// </summary>
        public PercentDiscount()
        {
            CurrentDiscountPercent = 1;
        }

        /// <summary>
        /// Сравнивает текущую скидку с другой скидкой по проценту.
        /// </summary>
        /// <param name="discount2">Скидка, с которой производится сравнение.</param>
        /// <returns>
        /// Возвращает 0, если текущая скидка равна discount2; 
        /// 1, если текущая скидка больше discount2; 
        /// -1, если текущая скидка меньше discount2.
        /// </returns>
        public int CompareTo(PercentDiscount? discount2)
        {
            if (object.ReferenceEquals(this, discount2))
                return 0;
            if (CurrentDiscountPercent > discount2.CurrentDiscountPercent)
            {
                return 1;
            }
            if (CurrentDiscountPercent < discount2.CurrentDiscountPercent)
            {
                return -1;
            }
            else if (CurrentDiscountPercent == discount2.CurrentDiscountPercent)
            {
                return 0;
            }
            return 1;
        }
    }
}
