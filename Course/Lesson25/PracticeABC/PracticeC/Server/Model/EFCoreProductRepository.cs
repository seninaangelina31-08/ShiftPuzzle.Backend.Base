using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{
    public class EFCoreProductRepository : IProductRepository
    {
        // Определение событий для различных действий
        public event Action ProductAdded;
        public event Action ProductDeleted;
        public event Action ProductUpdated;

        private readonly ProductContext _context;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;

            // Подписываемся на события в конструкторе
            ProductAdded += SendNotificationToStatDepartment;
            ProductDeleted += SendNotificationToStatDepartment;
            ProductUpdated += SendNotificationToStatDepartment;
        }

        private void SendNotificationToStatDepartment()
        {
            Console.WriteLine("Отправляю отчет...");
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

            ProductAdded?.Invoke(); // Вызываем событие добавления продукта
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            ProductUpdated?.Invoke(); // Вызываем событие обновления продукта
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

                ProductDeleted?.Invoke(); // Вызываем событие удаления продукта
            }
        }
    }
}
