using Api_Task.DTOs;
using Api_Task.IRepositery;
using Api_Task.Repositery;
using Demo_api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        I_ProductRepositery productRepositery =new ProductRepositery();
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext context)
        {
            this.context = context;

        }

        [HttpPost]

        public IActionResult Create(ProductDTO product)
        {
            productRepositery.Create(product);
            //var products = context.products.ToList();
            return Ok(product);
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var product = productRepositery.Read();
            //var products = context.products.ToList();
            return Ok(product);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var product = productRepositery.GetById(id);
            //var products = context.products.ToList();
            if (product != null){
                return Ok(product);
            }
            return BadRequest();
           
        }
        [HttpPut]

        public IActionResult Update(Models.Product product)
        {
           productRepositery.edit(product);
            //var products = context.products.ToList();
            return Ok(product);
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            productRepositery.delete(id);
            //var products = context.products.ToList();
            return Ok();
        }



    }
}
