using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Discounts
{
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
            } }
        public Category DiscountCategory {
            get {
            return _discountCategory;
            }
             set{
                _discountCategory = value;
            }}
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
            /*double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }
            return Math.Round(sum, 2);*/
        }

        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
/*            if (CurrentDiscountPercent < 10)
            {*/
            double res= amount * (CurrentDiscountPercent / 100.0);
            return res;
/*            }
            else
            {
                return 10;
            }
*/
            /*if (AccumulatedPoints > amount * 0.3)
            {
                return Math.Floor(amount * 0.3);
            }
            else
            {
                return AccumulatedPoints;
            }*/
        }

        public double Apply(List<Item> items)
        {
            double discountAmount = GetAmount(items);

/*            int discountPercent = (int)Calculate(items);
            double discountAmount = AccumulatedAmount * discountPercent;
            CurrentDiscountPercent -= discountPercent;*/
            /*AccumulatedPoints -= (int)discountAmount;*/
            return discountAmount;
        }

        public void Update(List<Item> items)
        {
            int updateRes= (int)(GetAmount(items) / 1000);
            for(int percent=0;percent<updateRes;percent++)
            { 
                CurrentDiscountPercent += 1;
            }
            /*CurrentDiscountPercent += (int)Math.Floor(GetAmount(items) / 1000);*/
            /*double amount = GetAmount(items);
            AccumulatedPoints += (int)Math.Ceiling(amount * 0.1)*/

        }
        public PercentDiscount()
        {
/*            DiscountCategory = category;*/
            CurrentDiscountPercent = 1;
        }
        /// <inheritdoc/>
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
