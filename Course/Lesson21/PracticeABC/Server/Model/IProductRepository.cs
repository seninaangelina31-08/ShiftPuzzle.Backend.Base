namespace PracticeABC;

using System.Data.SQLite; 
using System.Collections.Generic; 

public interface IProductRepository {


    List<Product> GetAllProducts();
    Product GetProductByName(string name);
    void AddProduct(Product product);

    void UpdateProduct(Product product);
    void DeleteProduct(string name);

}