using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе: айди заказа, количество всех заказов,
    /// статус заказа, дата заказа,
    /// адресс доставки, товары,
    /// сумма стоимости всех товаров, скидка на заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный айди заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Количество всех заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Дата заказа.
        /// </summary>
        private string _dateOfCreation;

        /// <summary>
        /// Адресс доставки.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Сумма стоимости всех товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Скидка на заказ.
        /// </summary>
        private double _discountAmount;


        public int Id { get; }
        public OrderStatus Status { get; set; }
        public string DateOfCreation { get; }
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Размер примененной скидки
        /// </summary>
        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }
            set
            {
                ValueValidator.AssertOnPositiveValue(value);
                _discountAmount = value;
            }
        }

        /// <summary>
        /// Итоговая стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        public List<Item> Items { get; set; }

        /// <summary>
        /// Сумма всех товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double summ = 0;
                foreach (Item cost in Items)
                {
                    summ += cost.Cost;
                }
                if (summ > 0)
                {
                    return _amount = summ;
                }
                else
                {
                    return _amount = 0;
                }
            }
        }
        /// <summary>
        /// Констуктор по умолчанию.
        /// </summary>
        public Order()
        {
            Status = OrderStatus.New;
            DateOfCreation = "01.01.2000";
            DeliveryAddress = new Address();
            Items = [];

            _allOrdersCount += 1;
            Id = _allOrdersCount;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="dateOfCreation">Дата создания заказа.</param>
        /// <param name="items">Список предметов заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="discountAmount">Сумма скидки.</param>
        public Order(OrderStatus status, string dateOfCreation, List<Item> items, Address address,double discountAmount)
        {
            Status = status;
            DateOfCreation = dateOfCreation;
            Items = new List<Item>(items);
            DeliveryAddress = address;
            DiscountAmount= discountAmount;

            _allOrdersCount += 1;
            Id = _allOrdersCount;
        }

        /// <summary>
        /// Объекты равны тогда, когда у них равны все поля кроме ID.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other is not Order)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            Order order = (Order)other;
            return (this.Status == order.Status && this.DateOfCreation == order.DateOfCreation && this.Items == order.Items && this.DeliveryAddress == order.DeliveryAddress && this.DiscountAmount==order.DiscountAmount);
        }
    }
}
