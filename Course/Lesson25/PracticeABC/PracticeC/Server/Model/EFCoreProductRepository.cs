using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

         // событие добавления продукта
        private readonly ProductContext _context;
        public event Action OnProductAdded;
        public event Action OnProductDeleted;
        public event Action OnProductChanged;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;  
            OnProductAdded  +=   SendNotificationAdd;
            OnProductDeleted  +=   SendNotificationDelete;  
            OnProductChanged  +=   SendNotificationChange;    
        }

        private void SendNotificationAdd()
        {
           Console.WriteLine("The product was added");
        }

        private void SendNotificationDelete()
        {
           Console.WriteLine("The product was deleted");
        }

        private void SendNotificationChange()
        {
           Console.WriteLine("The product was changed");
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
            _context.SaveChanges();  
            OnProductAdded?.Invoke();

            // вызов события добавления продукта
        }

        public void UpdateProduct(Product product)
        {
            _context.SaveChanges();
            OnProductChanged?.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.SaveChanges();
                OnProductDeleted?.Invoke();
            }
        }
    }
}
