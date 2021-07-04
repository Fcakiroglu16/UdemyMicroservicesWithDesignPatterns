using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class PaymentCompletedEvent
    {
        public int orderId { get; set; }

        public string BuyerId { get; set; }
    }
}