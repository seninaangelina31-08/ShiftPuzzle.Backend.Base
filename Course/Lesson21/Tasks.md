<<<<<<< HEAD
Привет! Тебе предстоить сделать рефакторинг проекта с предыдшуего урока. 

---
# Практика А:

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
1. Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs] 
>>>>>>> main
=======
1. Создать интерфейс [IProductRepository.cs]
2. Создать методы внутри интерфейса:

```C#
    List<Product> GetAllProducts();
    Product GetProductByName(string name);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(string name);
```
3. Указать что  класс *SQLLiteProductRepository* должен реализовыывать интерфейс *IProductRepository*

```C# 
public class SQLLiteProductRepository : IProductRepository
```

<<<<<<< HEAD
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
1. Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs] 
>>>>>>> 78543e51 (матераилы 21-го урока)


---
# Практика В: 

1. Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs] 
<<<<<<< HEAD
<<<<<<< HEAD

    - Изменить код и указать вместо явной реализации *SQLLiteProductRepository* интерфейс *IProductRepository*

---
# Практика C:

=======
<<<<<<< HEAD
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
---
# Практика C:

1.   Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]
<<<<<<< HEAD
 
=======
    - Изменить код и указать вместо явной реализации *SQLLiteProductRepository* интерфейс *IProductRepository*

---
# Практика C:

>>>>>>> main
1. Создать сервис который пишет и выводи данные в верхнем регистре   [Server/DBModel.cs]
 
> ПОДСКАЗКА

```C#
// Регистрируем ProductRepository
builder.Services.AddSingleton<IProductRepository>(provider =>
{
    // Создаем базу данных и передаем путь к ней
    string connectPath = "Data Source=DataBase.db"; 
    // Создаем экземпляр репозитория и передаем путь к базе данных SQLite которая пишет и вывод в верхнем регистре
    IProductRepository productRepository = new SQLLiteUpperCaseRepository(connectPath);
    return productRepository; // Путь к файлу базы данных SQLite
});

/// ПЕРЕВОД РЕГИСТРА .ToUpper()
Product product = new Product(reader["Name"].ToString().ToUpper(), Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Stock"]));
///

```
<<<<<<< HEAD
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
 
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
