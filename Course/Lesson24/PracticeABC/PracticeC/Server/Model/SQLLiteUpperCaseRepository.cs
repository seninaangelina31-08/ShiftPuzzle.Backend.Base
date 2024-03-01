namespace PracticeABC;  
using System.Data.SQLite;
using System.Collections.Generic;

public class SQLLiteUpperCaseRepository : IProductRepository
{

    private string _connectionString;
    private List<Product> products = new List<Product>();
    private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Products (
            Id INTEGER PRIMARY KEY,
            Name TEXT NOT NULL,
            Price REAL NOT NULL,
            Stock INTEGER NOT NULL
        )";
    public SQLLiteUpperCaseRepository(string connectionString)
    {
        _connectionString = connectionString;
        InitializeDatabase();
        ReadDataFromDatabase();
    }




    private void ReadDataFromDatabase()
    {
        products = GetAllProducts();
    }

    private void InitializeDatabase()
    {
        SQLiteConnection connection = new SQLiteConnection(_connectionString);
        Console.WriteLine("База данных :  " + _connectionString + " создана");
        connection.Open();
        SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
        command.ExecuteNonQuery();


    }

   public async Task<List<Product>> GetAllProducts()
       {
           List<Product> products = new List<Product>();
           using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
           {
               await connection.OpenAsync();
               string query = "SELECT * FROM Products";
               using (SQLiteCommand command = new SQLiteCommand(query, connection))
               {
                   using (SQLiteDataReader reader = await command.ExecuteReaderAsync())
                   {
                       while (await reader.ReadAsync())
                       {
                           Product product = new Product(reader["Name"].ToString().ToUpper(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                           products.Add(product);
                       }
                   }
               }
           }
           return products;
       }
   
    public async Task<Product> GetProductByName(string name)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
           await connection.OpenAsync();
           string query = "SELECT * FROM Products WHERE Name = @Name";
           using (SQLiteCommand command = new SQLiteCommand(query, connection))
           {
               command.Parameters.AddWithValue("@Name", name);
               using (SQLiteDataReader reader = await command.ExecuteReaderAsync())
               {
                   if (await reader.ReadAsync())
                   {
                       Product product = new Product(reader["Name"].ToString().ToUpper(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
                       return product;
                   }
                   return null;
               }
           }
        }
    }
   
    public async Task AddProduct(Product product)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
           await connection.OpenAsync();
           string query = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
           {
                command.Parameters.AddWithValue("@Name", product.Name.ToUpper());
               command.Parameters.AddWithValue("@Price", product.Price);
               command.Parameters.AddWithValue("@Stock", product.Stock);
               await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task UpdateProduct(Product product)
    {
       using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
           await connection.OpenAsync();
           string query = "UPDATE Products SET Price = @Price, Stock = @Stock WHERE Name = @Name";
           using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
               command.Parameters.AddWithValue("@Name", product.Name.ToUpper());
               command.Parameters.AddWithValue("@Price", product.Price);
               command.Parameters.AddWithValue("@Stock", product.Stock);
               await command.ExecuteNonQueryAsync();
           }
        }
    }
   
    public async Task DeleteProduct(string name)
    {
       using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
       {
           await connection.OpenAsync();
           string query = "DELETE FROM Products WHERE Name = @Name";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
           {
               command.Parameters.AddWithValue("@Name", name.ToUpper());
               await command.ExecuteNonQueryAsync();
           }
       }
    }
}