using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Messages
{
    public interface IStockRollBackMessage
    {
        public List<OrderItemMessage> OrderItems { get; set; }
    }
}