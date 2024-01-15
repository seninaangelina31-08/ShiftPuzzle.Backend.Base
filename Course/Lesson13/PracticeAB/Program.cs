// Практика А,Б

// Задание 1
string json = @"{
    'id': 12345,
    'name': 'Иван Иванов',
    'email': 'ivanov@example.com',
    'isVerified': true
}";

User user = JsonConvert.DeserializeObject<User>(json);

if (user.Name == "Иван Иванов")
{
    Console.WriteLine($"Email: {user.Email}");
    Console.WriteLine($"ID: {user.Id}");
}

// Задание 2
string json = @"{
    'orderId': 'ORD10245',
    'customerName': 'Анна Петрова',
    'totalPrice': 5600,
    'items': ['Ноутбук', 'Мышь']
}";

Order order = JsonConvert.DeserializeObject<Order>(json);

if (order.CustomerName == "Анна Петрова")
{
    Console.WriteLine($"Список товаров, которые купила Анна Петрова:");
    foreach (var item in order.Items)
    {
        Console.WriteLine(item);
    }

    double discount = order.TotalPrice * 0.10;
    double priceAfterDiscount = order.TotalPrice - discount;

    Console.WriteLine($"Общая стоимость заказа со скидкой 10%: {priceAfterDiscount}");
}


// Задание 4
string json = @"{
    'orderId': 'ORD10245',
    'customerName': 'Анна Петрова',
    'totalPrice': 5600,
    'items': ['Ноутбук', 'Мышь']
}";

Order order = JsonConvert.DeserializeObject<Order>(json);

if (order.CustomerName == "Анна Петрова")
{
    // Добавляем салфетки для мониторов в список покупок
    order.Items.Add("Салфетки для мониторов");
    order.TotalPrice += 1550;

    Console.WriteLine($"Список товаров, которые купила Анна Петрова:");
    foreach (var item in order.Items)
    {
        Console.WriteLine(item);
    }

    // Применяем скидку 2%
    double discount = order.TotalPrice * 0.02;
    double priceAfterDiscount = order.TotalPrice - discount;

    Console.WriteLine($"Общая стоимость заказа со скидкой 2%: {priceAfterDiscount}");
}
// Задание 5
string json = @"{
    'libraryName': 'Городская библиотека',
    'books': [
        {
            'title': 'Война и мир',
            'author': 'Лев Толстой',
            'year': 1869
        },
        {
            'title': 'Мастер и Маргарита',
            'author': 'Михаил Булгаков',
            'year': 1967
        }
    ]
}";

Library library = JsonConvert.DeserializeObject<Library>(json);

// Добавляем книгу Пушкина в список книг
Book pushkinBook = new Book { Title = "Евгений Онегин", Author = "Александр Пушкин", Year = 1833 };
library.Books.Add(pushkinBook);

Console.WriteLine($"Список книг в библиотеке '{library.LibraryName}':");
foreach (var book in library.Books)
{
    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
}
