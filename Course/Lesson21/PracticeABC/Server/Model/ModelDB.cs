namespace PracticeABC;

using System.Data.SQLite; 
using System.Collections.Generic; 

<<<<<<< HEAD
<<<<<<< HEAD
public class SqlLiteProductRepository : IProductRepository
{
    private readonly string _connectionString;
    private List<Product> products = new List<Product>();
    private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Products (
            Id INTEGER PRIMARY KEY,
            Name TEXT NOT NULL,
            Price REAL NOT NULL,
            Stock INTEGER NOT NULL
        )";
    public SqlLiteProductRepository(string connectionString)
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
public class ProductRepository
{
    private readonly string _connectionString;
    private const string CreateTableQuery = "CREATE TABLE IF NOT EXISTS Products (Name TEXT PRIMARY KEY, Price REAL, Stock INTEGER)";

    public ProductRepository(string connectionString)
<<<<<<< HEAD
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
=======
public class SqlLiteProductRepository
{
    private readonly string _connectionString;
    private List<Product> products = new List<Product>();
    private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Products (
            Id INTEGER PRIMARY KEY,
            Name TEXT NOT NULL,
            Price REAL NOT NULL,
            Stock INTEGER NOT NULL
        )";
    public SqlLiteProductRepository(string connectionString)
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
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
<<<<<<< HEAD
<<<<<<< HEAD
        SQLiteConnection connection = new SQLiteConnection(_connectionString); 
        Console.WriteLine("База данных :  " + _connectionString + " создана");
        connection.Open();
        SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
        command.ExecuteNonQuery();
             
        
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
<<<<<<< HEAD
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
=======
        SQLiteConnection connection = new SQLiteConnection(_connectionString); 
        Console.WriteLine("База данных :  " + _connectionString + " создана");
        connection.Open();
        SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
        command.ExecuteNonQuery();
             
        
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
    }

    public List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Products";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"])); 
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
                        Product product = new Product
                        {
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDouble(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        };
<<<<<<< HEAD
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
=======
                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"])); 
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
                        products.Add(product);
                    }
                }
            }
        }
        return products;
    }
<<<<<<< HEAD
=======

    public Product GetProductByName(string name)
    {
>>>>>>> 78543e51 (матераилы 21-го урока)
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
<<<<<<< HEAD
<<<<<<< HEAD

                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"]));
                        return  product;
                    }
                }
            
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
                        return new Product
                        {
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDouble(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        };
=======

                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"]));
                        return  product;
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
                    }
                    return null;
                }
            }
>>>>>>> 78543e51 (матераилы 21-го урока)
        }
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
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "UPDATE Products SET Price = @Price, Stock = @Stock WHERE Name = @Name";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
<<<<<<< HEAD
}
=======
}

>>>>>>> 78543e51 (матераилы 21-го урока)
