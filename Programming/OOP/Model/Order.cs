using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный айди заказа.
        /// </summary>
        private int _id;
        private static int _allOrdersCount;
        private string _dateOfCreation;
        private Address _deliveryAddress;
        private Item[] _items;
        private double _totalCost;



        public int Id { get; }
        public string DateOfCreation { get; }
        public Address DeliveryAddress { get; set; }

        public Item[] Items { get; set; }
        public double TotalCost
        {
            get
            {
                double summ = 0;
                foreach (Item cost in _items)
                {
                    summ += cost.Cost;
                }
                if (summ > 0)
                {
                    return _totalCost = summ;
                }
                else
                {
                    return _totalCost = 0;
                }
            }
        }

        public Order()
        {
            DateOfCreation = "01.01.2000";
            DeliveryAddress = new Address();
            Items = new Item[0];
            _allOrdersCount += 1;
            _id = _allOrdersCount;
        }
        public Order(string dateOfCreation, Item[] items)
        {
            DateOfCreation = dateOfCreation;
            Items = items;
        }
    }
}
