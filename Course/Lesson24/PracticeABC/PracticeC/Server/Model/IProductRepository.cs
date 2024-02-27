using System.Threading.Tasks;
namespace PracticeABC
{
    public interface IProductRepository
    { 
        async Task<List<Product>> GetAllProducts();
        async Task<Product> GetProductByName(string name);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string name);
    }
}