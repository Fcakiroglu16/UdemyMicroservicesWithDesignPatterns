using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class PaymentMessage
    {
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
        public decimal TotalPrice { get; set; }
    }
}