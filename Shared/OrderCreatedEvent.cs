using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class OrderCreatedEvent
    {
        public int OrderId { get; set; }
        public string BuyerId { get; set; }

        public PaymentMessage Payment { get; set; }
        public List<OrderItemMessage> orderItems { get; set; } = new List<OrderItemMessage>();
    }
}