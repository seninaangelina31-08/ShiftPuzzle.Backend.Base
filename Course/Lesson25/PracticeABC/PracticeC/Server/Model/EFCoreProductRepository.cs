using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

        private event Action OnProductAdded;
        private event Action OnProductDelete;
        private event Action OnProductUpdate;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  += SendNotificationToStatDepartmetn;
            OnProductDelete += SendNotificationAboutDelete;
            OnProductUpdate += SendNotificationAboutUpdate;
        }

        private void SendNotificationToStatDepartmetn()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
        }

        private void SendNotificationAboutDelete()
        {
           Console.WriteLine("Отправляю уведомление об удалении товара...");
        }

        private void SendNotificationAboutUpdate()
        {
           Console.WriteLine("Срочно изменяем все сметы...");
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
            OnProductAdded?.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            OnProductUpdate?.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                OnProductDelete?.Invoke();
            }
        }
    }
}
