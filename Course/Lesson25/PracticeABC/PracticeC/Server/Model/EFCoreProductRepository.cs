using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
         private event Action OnProductAdded;
         private event Action OnProductUpdated;
         private event Action OnProductDeleted;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  += SendNotificationToStatDepartment;  
            OnProductUpdated += SendNotificationProductUpdated;
            OnProductDeleted += SendNotificationProductDeleted;
        }

        private void SendNotificationToStatDepartment()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...\nПродукт добавлен");
        }

        private void SendNotificationProductUpdated()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...\nПродукт обновлен");
        }       

        private void SendNotificationProductDeleted()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...\nПродукт удален");
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
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
