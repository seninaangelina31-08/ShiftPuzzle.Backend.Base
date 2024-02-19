namespace Homework
{
    public interface IProductRepository
    { 
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void DeleteProduct(string name);
        Product GetProductByName(string name);
    }
}