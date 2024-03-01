namespace ServerL24
{
    public interface IProductRepository
    { 
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByNameAsync(string name);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(string name);
    }
}