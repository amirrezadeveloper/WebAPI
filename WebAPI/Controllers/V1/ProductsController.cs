using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using WebAPI.Business;
using WebAPI.Contracts;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Controllers.V1
{

    public class ProductsController : BaseController
    {

        private readonly IProductBusiness _productBusiness;
        private readonly IMapper _mapper;
        public ProductsController(IProductBusiness productBusiness, IMapper mapper)
        {
            _productBusiness = productBusiness;
            _mapper = mapper;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] int id)
        {

            Product product = _productBusiness.GetProductById(id);
            if (product is null)
                return NotFound();


            ProductDto productDto = new ProductDto() {

                Id = product.Id,
                Name = product.Name,
                Price = product.Price
                
            };

            return Ok(productDto);

        }
        [Route("")]
        [HttpDelete]
        public async Task<bool> Delete()
        {
            return true;
        }
        [Route("")]
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add([FromBody]AddProductDto productDto)
        {
            if (string.IsNullOrEmpty(productDto.Name) || productDto.Price <= 0)
                return BadRequest();
            var product = new Product()
            {
                Price = productDto.Price,
                Name = productDto.Name,
                Id = 1,
                CreatedAt = DateTime.Now
            };

            _productBusiness.AddProduct(product);
            return Created();
        }

        [Route("")]
        [HttpPut]
        public bool Update(Product product)
        {
            return true;
        }
    }
}
