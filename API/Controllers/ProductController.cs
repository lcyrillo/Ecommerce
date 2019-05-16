using System.Collections.Generic;
using Ecommerce.DAO;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDao _dao;

        public ProductController(ProductDao dao)
        {
            _dao = dao;
        }

        [Route("list")]
        [HttpGet]
        public IActionResult Get()
        {
            IList<Product> products = _dao.GetAll();
            return Ok(products);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            Product product = _dao.GetById(id);
            return Ok(product);
        }

        [Route("list/{title}")]
        [HttpGet]
        public IActionResult Get(string title)
        {
            IList<Product> products = _dao.GetByTitle(title);
            return Ok(products);
        }
    }
}