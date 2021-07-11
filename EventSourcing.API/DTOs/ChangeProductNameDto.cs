using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSourcing.API.DTOs
{
    public class ChangeProductNameDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}