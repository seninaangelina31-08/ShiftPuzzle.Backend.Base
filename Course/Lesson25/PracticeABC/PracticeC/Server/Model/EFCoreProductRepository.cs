using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public event Action OnProductAdded;
    public event Action OnProductUpdated;
    public event Action OnProductDeleted;
    public class EFCoreProductRepository : IProductRepository
    {

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
            OnProductAdded += SendNotificationToStatDepartmetn;
            OnProductUpdated += SendNotificationToStatDepartmetn;
            OnProductDeleted += SendNotificationToStatDepartmetn;
        }
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
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            OnProductAdded?.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            OnProductUpdated?.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                OnProductDeleted?.Invoke();
            }
        }
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}