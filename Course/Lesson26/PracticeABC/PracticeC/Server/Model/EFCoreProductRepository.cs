using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

        private event Action OnProductAdded;
        private event Action<Product> OnProductUpdated;
        private event Action<Product> OnProductDeleted;

        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  +=   SendNotificationToStatDepartmetn;
            OnProductUpdated += SendNotificationProductUpdated;
            OnProductDeleted += SendNotificationProductDeleted;  
        }

        private void SendNotificationToStatDepartmetn()
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Добавлен товар : {product.Name}")
        }
        private void SendNotificationProductUpdated(Product product)
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Обновлны данные о товаре : {product.Name}")
        }

        private void SendNotificationProductDeleted(Product product)
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Товар удалён : {product.Name}")
 

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
