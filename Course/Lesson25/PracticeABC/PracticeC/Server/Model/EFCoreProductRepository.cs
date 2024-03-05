using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        private readonly ProductContext _context;
        
        private event Action OnProductAdded;
        private event Action OnProductDeleted;
        private event Action OnProductUpdated;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  += SendNotificationToStatDepartmetn;

            OnProductAdded += SendProductAdded;
            OnProductDeleted += SendNotificationToStatDepartmetn;
            OnProductDeleted += SendProductDeleted;
            OnProductUpdated += SendNotificationToStatDepartmetn;
            OnProductUpdated += SendProductUpdated;
        }

        private void SendNotificationToStatDepartmetn()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
        }

        private void SendProductAdded()
        {
            Console.WriteLine("Продукт добавлен...");
        }

        private void SendProductDeleted()
        {
            Console.WriteLine("Продукт удален...");
        }

        private void SendProductUpdated()
        {
            Console.WriteLine("Продукт обновлен...");
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

            // вызов события добавления продукта
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
            }
            OnProductDeleted.Invoke();
        }
    }
}