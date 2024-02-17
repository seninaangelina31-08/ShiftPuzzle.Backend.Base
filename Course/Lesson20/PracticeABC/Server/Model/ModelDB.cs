namespace PracticeABC;

using System.Data.SQLite;
using System.Collections.Generic;

public class ProductRepository
{
    // Путь для подключения к БД
    private readonly string _connectionString;
    // Список продуктов
    private List<Product> products = new List<Product>();
    // Если табличка не создана, то создаём
    private const string CreateTableQuery = @"
        CREATE TABLE IF NOT EXISTS Products (
            Id INTEGER PRIMARY KEY,
            Name TEXT NOT NULL,
            Price REAL NOT NULL,
            Stock INTEGER NOT NULL
        )";

    public ProductRepository(string connectionString)
    {
        _connectionString = connectionString;
        InitializeDatabase();
        ReadDataFromDatabase();
    }

    // Чтение данных из БД
    private void ReadDataFromDatabase()
    {
        // Получаем список продуктов из БД и сохраняем в переменную
        products = GetAllProducts();
    }

    private void InitializeDatabase()
    {
        // Подключение к БД
        SQLiteConnection connection = new SQLiteConnection(_connectionString);
        Console.WriteLine($"База данных: {_connectionString} успешно создана!");
        // Создаем табличку
        connection.Open();
        SQLiteCommand command = new SQLiteCommand(CreateTableQuery, connection);
        command.ExecuteNonQuery();
    }

    // Получение спсика продуктов
    public List<Product> GetAllProducts()
    {
        // Создаем пустой список продуктов
        List<Product> products = new List<Product>();

        // Подключаемся к БД
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            // Запрос к БД на получение всез данных из колонки продуктов
            string query = "SELECT * FROM Products";

            // Выполняем запрос на получение всех продуктов
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Считываем полученные данные
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Создаем объект продукта
                        Product product = new Product(
                            reader["Name"].ToString(),
                            Convert.ToDouble(reader["Price"]),
                            Convert.ToInt32(reader["Stock"])
                        );
                        // Добавляем его в список
                        products.Add(product);
                    }
                }
            }
        }

        // Возвращаем список всех продуктов
        return products;
    }

    // Получение продукта по его имени
    public Product GetProductByName(string name)
    {
        // Подключаемся к БД
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            // Запрос на получение тех продуктов, у которых имя совпадает с указанным
            string query = "SELECT * FROM Products WHERE Name = @Name";

            // Выполняем запрос
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Добавляем параметр - имяЮ по которому происходит поиск
                command.Parameters.AddWithValue("@Name", name);

                // Считываем полученные данные
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Создаем объект продукта
                        Product product = new Product(
                            reader["Name"].ToString(),
                            Convert.ToDouble(reader["Price"]),
                            Convert.ToInt32(reader["Stock"])
                        );
                        // Возвращаем его
                        return product;
                    }
                    // Если ничего не нашлось
                    return null;
                }
            }
        }
    }

    // Добавить продукт
    public void AddProduct(Product product)
    {
        // Подключаемся к БД
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            // Запрос на добавление данных о новом продукте
            string query = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";

            // Выполняем запрос
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Добавляем параметры - данные о добавляемом продукте
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                // Выполняем команду по добавлению
                command.ExecuteNonQuery();
            }
        }
    }

    // Обновить информацию о продукте
    public void UpdateProduct(Product product)
    {
        // Подключаемся к БД
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            // Запрос на Обновление парметров продукта
            string query = "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Name = @Name";

            // Выполняем запрос
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Добавляем параметры - новые значения информации о продукте
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                // Выполнем команду по обновлению параметров
                command.ExecuteNonQuery();
            }
        }
    }

    // Удалить продукт
    public void DeleteProduct(string name)
    {
        // Подключаемся к БД
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            // Запрос на удаление продукта
            string query = "DELETE FROM Products WHERE Name = @Name";

            // Выполняем запрос
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Добавляем параметр - название продукта, который нужно удалить
                command.Parameters.AddWithValue("@Name", name);
                // Выполняем команду
                command.ExecuteNonQuery();
            }
        }
    }
}