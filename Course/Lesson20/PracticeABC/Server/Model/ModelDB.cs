using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.Json;

namespace PracticeABC
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class ProductRepository
    {
        private List<Product> _products;
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
            ReadDataFromDB();
        }

        private void ReadDataFromDB()
        {
            _products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Products", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _products.Add(new Product
                            {
                                Name = reader["Name"].ToString(),
                                Price = decimal.Parse(reader["Price"].ToString()),
                                Stock = int.Parse(reader["Stock"].ToString())
                            });
                        }
                    }
                }
            }
        }

        public void InsertProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)", connection))
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Products SET Price = @Price, Stock = @Stock WHERE Name = @Name", connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Name = @Name", connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
