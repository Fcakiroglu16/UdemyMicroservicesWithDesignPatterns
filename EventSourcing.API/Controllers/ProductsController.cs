using EventSourcing.API.Commands;
using EventSourcing.API.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSourcing.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            await _mediator.Send(new CreateProductCommand() { CreateProductDto = createProductDto });
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> ChangeName(ChangeProductNameDto changeProductNameDto)
        {
            await _mediator.Send(new ChangeProducNameCommand { ChangeProductNameDto = changeProductNameDto });
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> ChangePrice(ChangeProductPriceDto changeProductPriceDto)
        {
            await _mediator.Send(new ChangeProductPriceCommand { ChangeProductPriceDto = changeProductPriceDto });

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommand { Id = id });
            return NoContent();
        }
    }
}