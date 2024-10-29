using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{

    internal class PriorityOrder : Order
    {
        public DateTime DeliveryDateTime {get; set;}
        public DeliveryTimeRange DeliveryTimeRange { get; set;}


        public PriorityOrder(OrderStatus status, string dateOfCreation, List<Item> items, Address address, DateTime deliveryDateTime, DeliveryTimeRange deliveryTimeRange)
            : base(status,dateOfCreation,items, address)
        {
            DeliveryDateTime = deliveryDateTime;
            DeliveryTimeRange = deliveryTimeRange;
        }

    }
 }

