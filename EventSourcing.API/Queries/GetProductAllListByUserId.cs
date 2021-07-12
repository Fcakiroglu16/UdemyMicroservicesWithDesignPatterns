using EventSourcing.API.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSourcing.API.Queries
{
    public class GetProductAllListByUserId : IRequest<List<ProductDto>>
    {
        public int UserId { get; set; }
    }
}