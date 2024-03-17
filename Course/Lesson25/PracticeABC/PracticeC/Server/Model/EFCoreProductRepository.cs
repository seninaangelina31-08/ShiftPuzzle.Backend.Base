using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        private readonly ProductContext _context;
        private event Action OnProductAdd;
        private event Action OnProductDelete;
        private event Action OnProductUpdate;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
            OnProductAdd += SendNotificationToStatDepartment;
            OnProductAdd += SendProductAdd;

            OnProductDelete += SendNotificationToStatDepartment;
            OnProductDelete += SendProductDelete;

            OnProductUpdate += SendNotificationToStatDepartment;
            OnProductUpdate += SendProductUpdate;
        }

        private static void SendNotificationToStatDepartment()
        {
           Console.WriteLine("Отправляю отчет ...");
        }

        private void SendProductAdd()
        {
            Console.WriteLine("Продукт добавлен...");
        }

        private void SendProductDelete()
        {
            Console.WriteLine("Продукт удален...");
        }

        private void SendProductUpdate()
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
            OnProductAdd.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            OnProductUpdate.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            OnProductDelete.Invoke();
        }
    }
}