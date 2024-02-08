namespace PracticeABC; 

using System.Data.SQLite;
using System.Collections.Generic; 

public class DBModel
    {

        private readonly string _connectionString;
        private List<Product> products = new List<Product>();
        private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Products (
            Id INTEGET PRIMARY KEY,
            Name TEXT NOT NULL,
            Price REAL NOT NULL,
            Stock INTEGER NOT NULL
        )";

        public DBModel(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDatabase();
            ReadDataFromFile();
        }

        private void ReadDataFromDatabase()
        {
            products = GetAllProducts();
        }

        private void InitializeDatabase()
        {
            SQLiteConnection connection = new SQLiteConnection(_connectionString);
            Console.WriteLine($"База данных: {_connectionString} успешно создана");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
            command.ExecuteNonQuery();
        }


        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductByName(string name)
        {
            return _products.FirstOrDefault(p => p.Name == name);
        }

        public void AddProduct(Product product)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
                SaveChanges();
            }
        }

        public void DeleteProduct(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Products WHERE Name = @Name";
                
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

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