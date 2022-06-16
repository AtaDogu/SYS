using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll ()
        {
            var result = _productService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbycategoryid")]
        public IActionResult GetAllByCategoryId (int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
