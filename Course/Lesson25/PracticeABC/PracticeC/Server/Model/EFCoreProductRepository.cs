using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        public event Action<Product> ProductAdded;
        public event Action<Product> ProductDeleted;
        public event Action<Product> ProductUpdated;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  +=   SendNotificationToStatDepartmetn;  
        }

        private void SendNotificationToStatDepartmetn()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
        }
 

        public List<Product> GetAllProducts()
        {
            
            return _context.Products.ToList();
        }

        public Product GetProductByName(string name)
        {
             
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public void AddProduct(Product product)
        {
            
            _context.Products.Add(product);
            _context.SaveChanges();  
            ProductAdded?.Invoke(product);

            // вызов события добавления продукта
        }

        public void UpdateProduct(Product product)
        {
            
            _context.Products.Update(product);
            _context.SaveChanges();
            ProductUpdated?.Invoke(product);
        }

        public void DeleteProduct(string name)
        {
           
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                ProductDelated?.Invoke(product);
            }
        }
    }
}
