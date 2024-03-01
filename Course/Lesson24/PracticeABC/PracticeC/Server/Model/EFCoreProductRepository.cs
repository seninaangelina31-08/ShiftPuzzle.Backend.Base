using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServerL24
{

    public class EFCoreProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
        }

        async public Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        async public Task<Product> GetProductByNameAsync(string name)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Name == name);
        }

        async public Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        async public Task UpdateProductAsync(Product product)
        {
            await _context.Products.Where(u => u.Name == product.Name)
                .ExecuteUpdateAsync(s => s
                        .SetProperty(p => p.Price, p => product.Price)
                        .SetProperty(p => p.Stock, p => product.Stock));
            await _context.SaveChangesAsync();
        }

        async public Task DeleteProductAsync(string name)
        {
            await _context.Products.Where(p => p.Name == name).ExecuteDeleteAsync();
        }
    }
}
