namespace PracticeABC; 
using System.Text.Json; 
using System.Collections.Generic; 

public class ProductRepository
    {

        
        private List<Product> _products;
        private readonly string _jsonFilePath;

        public ProductRepository(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
            ReadDataFromFile();
        }

        `SELECT * FROM Products;`

        `SELECT * Product WHERE Name = @Nmae`

        -`INSERT INTO Products (Name, Price, Stock,)VALUES(@Name,@Price,@Stock)`

        -`UPDATE Product Set Price = @Price, Stock WHERE Name = @Name`

        -`DELETE FROM Product WHERE Name = @

        public void SaveChanges()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(_products, options);
            System.IO.File.WriteAllText(_jsonFilePath, json);
        }

        private void ReadDataFromFile()
        {
            if (DBExist())
            {
                var json = ReadDB();
                _products = JsonSerializer.Deserialize<List<Product>>(json);
            }
            else
            {
                _products = new List<Product>();
            }
        }

        private string ReadDB()
        {
            return System.IO.File.ReadAllText(_jsonFilePath);
        }

        private bool DBExist()
        {
            return System.IO.File.Exists(_jsonFilePath);
        }
    }