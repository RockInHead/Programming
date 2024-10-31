using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class PointsDiscount
    {
        private int _accumulatedPoints;
        public int AccumulatedPoints {
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
            return Math.Round(sum,2);
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
        /// Возврщает достпуную скидку для данных товаров, при этом списывая баллы с общего кол-ва.
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
    }
}
