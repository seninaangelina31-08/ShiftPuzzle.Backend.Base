namespace PracticeABC; 
using System.Text.Json; 
using System.Collections.Generic;
using System.Data.SQLite;

public class ProductRepository
    {

        
        private List<Product> products = new List<Product>();
        private readonly string _jsonFilePath;
        private string _connectionString;
        private const string CreateTableQuery = "CREATR TABLE IF NOT EXISTS Products (Id INTEGER PRIMARY KEY, Name TEXT NOT NULL, Price REAL NOT NULL, Stock INTEGER NOT NULL)";

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDatabase();
            ReadDataFromFile();
        }

        private void InitializeDatabase()
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                Console.WriteLine($"База данных: {_connectionString} создана.");
                conntction.Open();
                SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
                command.ExecuteNonQuery();
            }

        }

        private void ReadDataFromFile()
        {
            products = GetAllProducts();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> _product = new List<Product>();
            using(SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Priducts";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteCommand reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product(reader["Name"].ToString(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                            _products.Add(product);
                        }
                    }
                }
            }
            return _products;
        }

        public Product GetProductByName(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Products WHERE Name = @Name";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product(reader["Name"].ToString(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                            return product;
                        }
                        Console.WriteLine("Извинете товар отсутствует!");
                        return null;
                    }
                }
            }
        }

        public void AddProduct(Product product)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Products (Name, Price, Srock) VALUES (@Name, @Price, @Stock)";

                using (SQLiteCommand command = new SQLiteCommand(querym connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command,ExecuteNonQuery();
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

    }