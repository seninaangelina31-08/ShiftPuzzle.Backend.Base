using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

        private readonly ProductContext _context;
        private event Action<Product> OnProductAdd;
        private event Action<Product> OnDeleteProduct;
        private event Action<Product> OnUpdateProduct;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
            OnProductAdd += SendNotificationToStatDepartmentOnProductAddAsync;
            OnProductAdd += SendNotificationToAdminDepartmentOnProductAddAsync;
            OnProductAdd += SendNotificationToTeacherDepartmentOnProductAddAsync;

            OnDeleteProduct += SendNotificationToStatDepartmentOnDeleteProductAsync;
            OnDeleteProduct += SendNotificationToAdminDepartmentOnDeleteProductAsync;
            OnDeleteProduct += SendNotificationToTeacherDepartmentOnDeleteProductAsync;

            OnUpdateProduct += SendNotificationToStatDepartmentOnUpdateProductAsync;
            OnUpdateProduct += SendNotificationToAdminDepartmentOnUpdateProductAsync;
            OnUpdateProduct += SendNotificationToTeacherDepartmentOnUpdateProductAsync;

        }



        private static async void SendNotificationToStatDepartmentOnProductAddAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} добавлен на склад"));
            Console.WriteLine("Отчет в отдел статистики отправлен!!!\n");
        }

        private static async void SendNotificationToAdminDepartmentOnProductAddAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} добавлен на склад"));
            Console.WriteLine("Отчет системным администраторам отправлен!!!\n");
        }

        private static async void SendNotificationToTeacherDepartmentOnProductAddAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine("Отправляю отчет Акшину..... Тому самому........"));
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} добавлен на склад"));
            await Task.Run(() => Console.WriteLine("Отчёт отправлен!!!\n"));
        }


        private static async void SendNotificationToStatDepartmentOnDeleteProductAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} удален из базы данных"));
            Console.WriteLine("Отчет в отдел статистики отправлен!!!\n");
        }

        private static async void SendNotificationToAdminDepartmentOnDeleteProductAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} удален из базы данных"));
            Console.WriteLine("Отчет системным администраторам отправлен!!!\n");
        }

        private static async void SendNotificationToTeacherDepartmentOnDeleteProductAsync(Product product)
        {
            await Task.Run(() => Console.WriteLine("Отправляю отчет Акшину..... Тому самому........"));
            await Task.Run(() => Console.WriteLine($"Продукт '{product.Name}' с ценой {product.Price} в количестве {product.Stock} удален из базы данных"));
            await Task.Run(() => Console.WriteLine("Отчёт отправлен!!!\n"));
        }


        private static async void SendNotificationToStatDepartmentOnUpdateProductAsync(Product newProduct)
        {
            await Task.Run(() => Console.WriteLine($"В базе данных у продукта изменилось название на {newProduct.Name}"));
            Console.WriteLine("Отчет в отдел статистики отправлен!!!\n");
        }

        private static async void SendNotificationToAdminDepartmentOnUpdateProductAsync(Product newProduct)
        {
            await Task.Run(() => Console.WriteLine($"В базе данных у продукта изменилось название на {newProduct.Name}"));
            Console.WriteLine("Отчет системным администраторам отправлен!!!\n");
        }

        private static async void SendNotificationToTeacherDepartmentOnUpdateProductAsync(Product newProduct)
        {
            await Task.Run(() => Console.WriteLine("Отправляю отчет Акшину..... Тому самому........"));
            await Task.Run(() => Console.WriteLine($"В базе данных у продукта изменилось название на {newProduct.Name}"));;
            await Task.Run(() => Console.WriteLine("Отчёт отправлен!!!\n"));
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

            OnProductAdd.Invoke(product);
        }

        public void UpdateProduct(Product newProduct)
        {
            _context.Products.Update(newProduct);
            _context.SaveChanges();
            OnUpdateProduct.Invoke(newProduct);
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

                OnDeleteProduct(product);
            }
        }
    }
}
