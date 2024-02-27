using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        public event Action OnProductAdded;
        public event Action OnProductDeleted;
        public event Action OnProductUpdated;
        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded += SendNotificationAdd;
            OnProductUpdated += SendNotificationUpdate;
            OnProductDeleted += SendNotificationDelete;  
        }

        private void SendNotificationAdd()
        {
           Console.WriteLine("Новый продукт добавлен");
        }
        private void SendNotificationUpdate()
        {
           Console.WriteLine("Один продукт изменён");
        }
        private void SendNotificationDelete()
        {
           Console.WriteLine("Один продукт удалён");
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
    }
}
