namespace PracticeABC
{
    public interface IProductRepository
    { 
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByName(string name);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string name);
    }
}