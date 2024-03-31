using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

        private event Action OnProductAdded;
        private event Action OnProductUpdated;
        private event Action OnProductDeleted;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  +=   SendNotificationToStatDepartmetn;  
            OnProductUpdated += SendNotificationToStatDepartmetn;
            OnProductDeleted += SendNotificationToStatDepartmetn;
        }

        private void SendNotificationToStatDepartmetn(Product product)
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Продукт {product.Name} добавлен");
        }
        private void SendNotificationToProductUpdated(Product product)
        {
            Console.WriteLine("Отправляю отчет в отдел статистики...");
            Console.WriteLine($"Продукт {product.Name} обновлен");
        }
        private void SendNotificationToStatDepartmetn(Poduct product)
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Продукт {product.Name} удален");

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

            OnProductAdded.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            OnProductUpdated.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                
                OnProductDeleted.Invoke();
            }
        }
    }
}
