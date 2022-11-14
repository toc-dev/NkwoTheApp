using Microsoft.AspNetCore.Mvc;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Shared.DTOs;
using NLog.LayoutRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Presentation.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _serviceManager.ProductService.GetAllProducts(trackChanges: false);
            return Ok(products);
        }

        [HttpGet("{id:guid}", Name = "ProductById")]
        public IActionResult GetProduct(Guid id)
        {
            var product = _serviceManager.ProductService.GetProduct(id, trackChanges: false);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductCreationDto product)
        {
            if (product == null)
            {
                return BadRequest("Payload is null");
            }
            var createdProduct = _serviceManager.ProductService.CreateProduct(product);
            return CreatedAtRoute("ProductById", new { id = createdProduct.Id }, createdProduct);
        }

        [HttpGet("details")]
        public IActionResult GetProductDetails()
        {
            var productDetails = _serviceManager.ProductService.GetAllProductDetails(trackChanges: false);
            return Ok(productDetails);
        }

        [HttpGet("details/{id:guid}", Name = "ProductDetailById")]
        public IActionResult GetProductDetail(Guid id)
        {
            var productDetail = _serviceManager.ProductService.GetProductDetail(id, trackChanges: false);
            return Ok(productDetail);
        }
        [HttpPost("details")]
        public IActionResult CreateProductDetail([FromBody] ProductDetailCreationDto productDetail)
        {
            if (productDetail == null)
            {
                return BadRequest("Payload is null");
            }
            var createdProductDetail = _serviceManager.ProductService.CreateProductDetail(productDetail);
            return CreatedAtRoute("ProductDetailById", new { id = createdProductDetail.Id }, createdProductDetail);
        }
    }
}
