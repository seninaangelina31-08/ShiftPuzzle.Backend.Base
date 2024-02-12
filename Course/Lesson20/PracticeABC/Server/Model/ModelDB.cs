namespace PracticeABC; 
using System.Text.Json; 
using System.Data.SQLite;
using System.Collections.Generic; 

public class ProductRepository
    {

        
        private List<Product> _products = new List<Product>{};
        private readonly string _connectionstring;

        public ProductRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
            ReadDataFromDB();
        }

        // Вывод списка продуктов
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>{};
            using (SQLiteConnection connection = new SQLiteConnection(_connectionstring))
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product prod = new Product(reader["Name"].ToString(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                            products.Add(prod);
                        }
                    }
                }
            }

            return products;
        }
        
        // Получение по имени
        public Product GetProductByName(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionstring))
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
                            Product prod = new Product(reader["Name"].ToString(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                            return prod;
                        }
                        return null;
                    }
                }
            }
        }

        // Добавление продукта
        public void AddProduct(Product product)
        {
            _products.Add(product);
            using (SQLiteConnection connection = new SQLiteConnection(_connectionstring))
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
                //SaveChanges();
            }
        }

        // Удаление продукта
        public void DeleteProduct(string name)
        {
            var deleteProduct = _products.FirstOrDefault(p => p.Name == name);
            _products.Remove(deleteProduct);
            using (SQLiteConnection connection = new SQLiteConnection(_connectionstring))
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

        //public void SaveChanges()
        //{
        //    var options = new JsonSerializerOptions { WriteIndented = true };
        //    var json = JsonSerializer.Serialize(_products, options);
        //    System.IO.File.WriteAllText(_jsonFilePath, json);
        //}

        private void ReadDataFromDB()
        {
            _products = GetAllProducts();
        }

        //private string ReadDB()
        //{
        //    return System.IO.File.ReadAllText(_jsonFilePath);
        //}

        //private bool DBExist()
        //{
        //    return System.IO.File.Exists(_jsonFilePath);
        //}
    }