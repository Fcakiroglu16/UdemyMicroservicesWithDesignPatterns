using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdocutsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProdocutsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }
    }
}