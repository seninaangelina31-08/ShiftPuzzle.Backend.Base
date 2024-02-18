using System.Collections.Generic;

namespace Client
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductByName(string name);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string name);
    }
    public class SQLLiteProductRepository : IProductRepository
    {
        return null;
    }
}