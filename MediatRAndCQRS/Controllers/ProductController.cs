using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRAndCQRS.Command;
using MediatRAndCQRS.Models;
using MediatRAndCQRS.Queries;
using MediatRAndCQRS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRAndCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var query = new GetAllProductsQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("{productId}", Name = "GetProducts")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var query = new GetProductByIdQuery(productId);
            var response = await _mediator.Send(query);
            return Ok(response);
        }


        [HttpPost("")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand model)
        {
            var response = await _mediator.Send(model);
            return Ok(response);
        }
    }
}