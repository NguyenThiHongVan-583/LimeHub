using LimeHub.Data;
using LimeHub.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LimeHub.Models.Services
{
    public class ProductRepository : IProductRepository
    {

        private readonly LimeHubDbContext _context; // Khai báo DbContext

        public ProductRepository(LimeHubDbContext context) // Inject DbContext vào constructor
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.OrderBy(p => p.Name).ToList();
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return _context.Products.Where(p => p.IsTrendingProduct).OrderBy(p => p.Name).ToList();
        }

        public Product? GetProductDetail(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}

