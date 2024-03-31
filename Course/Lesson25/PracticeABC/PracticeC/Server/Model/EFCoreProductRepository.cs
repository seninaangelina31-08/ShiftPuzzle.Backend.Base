using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
         private event ProductAdding;
         private event ProductDeleting;
         private event ProductUpdating;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            ProductAdding += SendNotificationToStatDepartmetn;       
            ProductUpdating += SendNotificationToStatDepartmetn;
            ProductDeleting += SendNotificationToStatDepartmetn;

        }

        private void SendNotificationToStatDepartmetn()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
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
            ProductAdding.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            ProductUpdating.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                ProductDeleting.Invoke();
            }
        }
    }
}
