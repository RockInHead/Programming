using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Discounts
{
    public class PointsDiscount : IDiscount,IComparable<PointsDiscount>
    {
        private int _accumulatedPoints;
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
        /// Возврщает доступную скидку для данных товаров, при этом списывая баллы с общего кол-ва.
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
        /// <inheritdoc/>
        public int CompareTo(PointsDiscount? discount2)
        {

            if (object.ReferenceEquals(this, discount2))
                return 0;
            if (AccumulatedPoints > discount2.AccumulatedPoints)
            {
                return 1;
            }
            if (AccumulatedPoints < discount2.AccumulatedPoints)
            {
                return -1;
            }
            else if (AccumulatedPoints == discount2.AccumulatedPoints)
            {
                return 0;
            }
            return 1;
        }
    }
}
