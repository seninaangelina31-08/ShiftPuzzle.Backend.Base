using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public async Task AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();  
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
               await _context.SaveChangesAsync();
            }
        }
    }
}
