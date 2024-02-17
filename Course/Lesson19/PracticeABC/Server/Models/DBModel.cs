namespace PracticeABC; 
using System.Text.Json; 
using System.Collections.Generic; 

public class ProductRepository
{
    // Список продуктов
    private List<Product> _products;
    // Путь к БД
    private readonly string _jsonFilePath;
    
    public ProductRepository(string jsonFilePath)
    {
        _jsonFilePath = jsonFilePath;
        ReadDataFromFile();
    }

    // Получаем список всех продуктов
    public List<Product> GetAllProducts()
    {
        return _products;
    }

    // Получаем продукт по его названию
    public Product GetProductByName(string name)
    {
        return _products.FirstOrDefault(p => p.Name == name);
    }

    // Добавляем продукт
    public void AddProduct(Product product)
    {
        _products.Add(product);
        WriteDataToFile();
    }

    // Обновление данных о продукте
    public void UpdateProduct(Product product)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
        if (existingProduct != null)
        {
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;
            WriteDataToFile();
        }
    }

    // Удаление продукта
    public void DeleteProduct(string name)
    {
        var product = _products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            _products.Remove(product);
            WriteDataToFile();
        }
    }

    // Перезапиь данных БД
    public void WriteDataToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(_products, options);
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    // Бэкап
    public void SaveBackup()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(_products, options);
        System.IO.File.WriteAllText("./BackupDB.json", json);
    }

    // Читаем данные из БД
    private void ReadDataFromFile()
    {
        if (DBExist())
        {
            // Читаем данные из БД, выаолняем десериализвцию и сохраняем в переменную
            var json = ReadDB();
            _products = JsonSerializer.Deserialize<List<Product>>(json);
        }
        else
        {
            // Если нет БД по указанному пути то спсико продуктов устанавливаем как пустой
            _products = new List<Product>();
        }
    }

    // Считываем данные из БД
    private string ReadDB()
    {
        return System.IO.File.ReadAllText(_jsonFilePath);
    }

    // Проверяем есть ли БД по указанному пути
    private bool DBExist()
    {
        return System.IO.File.Exists(_jsonFilePath);
    }
}