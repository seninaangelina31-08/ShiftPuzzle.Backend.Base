//EFCoreProductRepository
namespace PracticeABC;
using System.Linq;
public class EFCoreProductRepository : IProductRepository
{
    private readonly PoductContext _context; //Что это?
    puЬlic EFCoreProductRepository(ProductContext context)
    {
        context = context; // DI. Инъекция продукт контекста. А можно по-русски откуда эта зависимость и зачем она?
    }
    puЬlic List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }
    puЬlic Product GetProductByName(string name)
    {
        return _context.Products.FirstOrDefault(p => p.Name);
    }
    puЬlic void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
    public void UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }
    puЫic void DeleteProduct(string name)
    {
        var product = _context.Products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}