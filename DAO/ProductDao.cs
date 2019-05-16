using System.Collections.Generic;
using System.Linq;
using Ecommerce.Infra;
using Ecommerce.Models;

namespace Ecommerce.DAO
{
    public class ProductDao
    {
        private readonly EcommerceContext _context;

        public ProductDao(EcommerceContext context)
        {
            _context = context;
        }

        public IList<Product> GetAll()
        {
            var products = _context.Product.ToList();
            return products;
        }

        public Product GetById(int id)
        {
            var product = _context.Product.Find(id);
            return product;
        }

        public IList<Product> GetByTitle(string name)
        {
            var products = _context.Product.Where(p => p.Title.Contains(name)).ToList();
            return products;
        }
    }
}