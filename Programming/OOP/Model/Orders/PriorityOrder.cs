using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Orders
{

    internal class PriorityOrder : Order
    {
        public DateTime DeliveryDateTime {get; set;}
        public DeliveryTimeRange DeliveryTimeRange { get; set;}


        public PriorityOrder(OrderStatus status, string dateOfCreation, List<Item> items, Address address,double discountAmount,DateTime deliveryDateTime, DeliveryTimeRange deliveryTimeRange)
            : base(status,dateOfCreation,items, address,discountAmount)
        {
            DeliveryDateTime = deliveryDateTime;
            DeliveryTimeRange = deliveryTimeRange;
        }

    }
 }

