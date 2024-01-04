﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using BusinessObjects;

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _repository = new ProductRepository();

        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => _repository.GetProducts();

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _repository.GetProductById(id);
            if (product == null)
            {
                return NotFound(); // Trả về lỗi 404 nếu không tìm thấy sản phẩm
            }

            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]

        public IActionResult PostProduct(Product p)
        {
            try
            {
                /*var context = new MyDbContext();
                context.Products.Add(p);
                context.SaveChanges();*/
                _repository.SaveProduct(p);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product p)
        {
            var temp = _repository.GetProductById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.UpdateProduct(p);
            return NoContent();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = _repository.GetProductById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.DeleteProduct(temp);
            return NoContent();
        }
    }
}
