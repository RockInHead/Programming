﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class PercentDiscount
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
        public int CurrentDiscountPercent { get; set; }
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
                return $"Процентная {_discountCategory.ToString()} - {_currentDiscountPercent}%";
            }
        }
        /// <summary>
        /// Считает и возвращает общую стоимость товаров конретной категории. 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private double GetAmount(List<Item> items)
        {
            
            /*double sum = 0;*/
            foreach (Item item in items)
            {
                if(item.Category == _discountCategory)
                {
                    AccumulatedAmount += item.Cost;
                }
            }
            return Math.Round(AccumulatedAmount, 2);
            /*double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }
            return Math.Round(sum, 2);*/
        }

        public int Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            if (CurrentDiscountPercent<10)
            {
                return CurrentDiscountPercent;
            }
            else
            {
                return 10;
            }
            
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
            double amount = GetAmount(items);

            int discountPercent = Calculate(items);
            double discountAmount = AccumulatedAmount * discountPercent;
            CurrentDiscountPercent -=discountPercent;
            /*AccumulatedPoints -= (int)discountAmount;*/
            return discountAmount;
        }
  
        public void Update(List<Item> items)
        {
            CurrentDiscountPercent +=(int)Math.Floor((AccumulatedAmount / 1000));
            /*double amount = GetAmount(items);
            AccumulatedPoints += (int)Math.Ceiling(amount * 0.1)*/;
        }
    }
}
