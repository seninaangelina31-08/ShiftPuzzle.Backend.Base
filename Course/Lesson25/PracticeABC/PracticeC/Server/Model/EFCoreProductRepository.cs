using System.Collections.Generic;
using System.Linq;

namespace PracticeABC
{

    public class EFCoreProductRepository : IProductRepository
    {

        // событие добавления продукта
        private readonly ProductContext _context;
        private event Action OnProductAdd;
        private event Action OnDeleteProduct;
        private event Action OnUpdateProduct;

        public EFCoreProductRepository(ProductContext context)
        {
            _context = context;
            OnProductAdd += SendNotificationToStatDepartment;
            OnProductAdd += SendNotificationToAdminDepartment;
            OnProductAdd += SendNotificationToTeacherDepartment;

            OnDeleteProduct += SendNotificationToStatDepartment;
            OnDeleteProduct += SendNotificationToAdminDepartment;
            OnDeleteProduct += SendNotificationToTeacherDepartment;

            OnUpdateProduct += SendNotificationToStatDepartment;
            OnUpdateProduct += SendNotificationToAdminDepartment;
            OnUpdateProduct += SendNotificationToTeacherDepartment;


        }

        private static void SendNotificationToStatDepartment()
        {
            Console.WriteLine("Отчет в отдел статистики отправлен!!!");
        }

        private static void SendNotificationToAdminDepartment()
        {
            Console.WriteLine("Отчет системным администраторам отправлен!!!");
        }

        private static void SendNotificationToTeacherDepartment()
        {
            Console.WriteLine("Отправляю отчет Акшину..... Тому самому........");
        }



        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductByName(string name)
        {
            return _context.Products?.FirstOrDefault(p => p.Name == name);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            OnProductAdd.Invoke();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            OnUpdateProduct.Invoke();
        }

        public void DeleteProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

                OnDeleteProduct.Invoke();
            }
        }
    }
}
