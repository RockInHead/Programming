using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Orders
{
    /// <summary>
    /// Хранит данные о приоритетном заказе: Дата доставки заказа, время доставки заказа.
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставвки заказа.
        /// </summary>
        public DateTime DeliveryDateTime {get; set;}

        /// <summary>
        /// Время доставки заказа.
        /// </summary>
        public DeliveryTimeRange DeliveryTimeRange { get; set;}

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="dateOfCreation">Дата создания заказа.</param>
        /// <param name="items">Список предметов заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="discountAmount">Сумма скидки.</param>
        /// <param name="deliveryDateTime">Дата и время доставки.</param>
        /// <param name="deliveryTimeRange">Временной диапазон доставки.</param>
        public PriorityOrder(OrderStatus status,
            string dateOfCreation, List<Item> items,
            Address address,
            double discountAmount,DateTime deliveryDateTime,
            DeliveryTimeRange deliveryTimeRange)
            :base(status,dateOfCreation,items, address,discountAmount)
        {
            DeliveryDateTime = deliveryDateTime;
            DeliveryTimeRange = deliveryTimeRange;
        }

    }
 }

