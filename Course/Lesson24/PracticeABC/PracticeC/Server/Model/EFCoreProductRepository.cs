using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task GetAllProducts()
        {
            await _context.Products.ToListAsync();
        }

        public async Task GetProductByName(string name)
        {
            await _context.Products.FirstOrDefaultAsync(p => p.Name == name);
        }

        public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();  
        }

        public async Task UpdateProduct(Product product)
        {
            await _context.Products.UpdateAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                await _context.Products.RemoveAsync(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
