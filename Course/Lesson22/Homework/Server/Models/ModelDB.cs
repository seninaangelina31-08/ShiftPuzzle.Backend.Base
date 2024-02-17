namespace Homework;

using System.Data.SQLite;
using System.Collections.Generic;

public class SQLiteOrderRepository : IOrderRepository
{
    private string _connectionString;
    private List<Order> orders = new List<Order>();
    private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Orders (
            Id TEXT PRIMARY KEY,
            Item TEXT NOT NULL,
            Price REAL NOT NULL
        )";

    public SQLiteOrderRepository(string connectionString){
        _connectionString = connectionString;
        InitializeDatabase();
        ReadDataFromDatabase();
    }

    private void ReadDataFromDatabase()
    {
        orders = GetAllOrders();
    }

    private void InitializeDatabase()
    {
        SQLiteConnection connection = new SQLiteConnection(_connectionString); 
        Console.WriteLine("База данных :  " + _connectionString + " создана");
        connection.Open();
        SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
        command.ExecuteNonQuery(); 
    }

    public List<Order> GetAllOrders()
    {
        List<Order> orders = new List<Order>();
        using(SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Orders";
            using(SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Order order = new Order(reader["Item"].ToString(), Convert.ToDouble(reader["Price"]), reader["Id"].ToString());
                        orders.Add(order);
                    }
                }
            }
        }
        return orders;
    }

    public void AddOrder(Order order)
    {
        using(SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Orders (Item, Price, Id) VALUES (@Item, @Price, @Id)";
            using(SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Item", order.Item);
                command.Parameters.AddWithValue("@Price", order.Price);
                command.Parameters.AddWithValue("@Id", order.Id);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteOrder(string id)
    {
        using(SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Orders Where Id = @Id";
            using(SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}