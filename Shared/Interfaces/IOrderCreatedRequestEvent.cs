using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IOrderCreatedRequestEvent
    {
        public int OrderId { get; set; }
        public string BuyerId { get; set; }
        public List<OrderItemMessage> OrderItems { get; set; }

        public PaymentMessage Payment { get; set; }
    }
}