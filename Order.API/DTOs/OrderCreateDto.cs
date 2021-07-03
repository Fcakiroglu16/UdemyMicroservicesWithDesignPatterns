using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.DTOs
{
    public class OrderCreateDto
    {
        public string BuyerId { get; set; }
        public List<OrderItemDto> orderItems { get; set; }
        public PaymentDto payment { get; set; }
        public AddressDto Address { get; set; }
    }

    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }

    public class PaymentDto
    {
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
    }

    public class AddressDto
    {
        public string Line { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }
}