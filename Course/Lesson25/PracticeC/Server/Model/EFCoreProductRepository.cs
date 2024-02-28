using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  +=   SendNotificationToStatDepartmentAdd;  
            OnProductUpdated  +=   SendNotificationToStatDepartmentUpdate;  
            OnProductDeleted  +=   SendNotificationToStatDepartmentDelete;  
        }

        private void SendNotificationToStatDepartmentAdd()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики о добавлении продукта...");
        }

        private void SendNotificationToStatDepartmentUpdate()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики об обновлении продукта...");
        }

        private void SendNotificationToStatDepartmentDelete()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики об удалении продукта...");
        }
 

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public event Action OnProductAdded;

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();  
            
            // вызов события добавления продукта
            OnProductAdded?.Invoke();
        }

        public event Action OnProductUpdated;

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            OnProductUpdated?.Invoke();
        }

        public event Action OnProductDeleted;

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
    }
}
