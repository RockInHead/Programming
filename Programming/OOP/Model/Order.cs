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
        private OrderStatus _status;
        private string _dateOfCreation;
        private Address _deliveryAddress;
        private List<Item> _items;
        private double _totalCost;



        public int Id { get; }
        public OrderStatus Status { get; set; }
        public string DateOfCreation { get; }
        public Address DeliveryAddress { get; set; }

        public List<Item> Items { get; set; }
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
            Status = OrderStatus.New;
            DateOfCreation = "01.01.2000";
            DeliveryAddress = new Address();
            Items = [];
            _allOrdersCount += 1;
            _id = _allOrdersCount;
        }
        public Order(OrderStatus status,string dateOfCreation, List<Item> items)
        {
            Status = status;
            DateOfCreation = dateOfCreation;
            Items = items;
        }
    }
}
