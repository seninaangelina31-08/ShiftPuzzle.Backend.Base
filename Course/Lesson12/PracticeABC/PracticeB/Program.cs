namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// 1
class Product
{
    string Name;
    int Price;
    string Description;

    public Product(string name, int price, string description){
        Name = name;
        Price = price;
        Description = description;
    }
}

// 2
class Category
{
    string Category_name;
    List<string> Products;

    public Category(string category, List<string> products){
        Category_name = category;
        Products = products;
    }
    string category;
    List<string> products;
}

// 3
class Order
{
    int Id;
    List<string> Items;
    int Total;

    public Order(int id, List<string> items, int total){
        Id = id;
        Items = items;
        Total = total;
    }
}

// 4
class User
{
    string Name;
    string Email;
    int Purchases;
    public User(string name, string email, int purchases)
    {
        Name = name;
        Email = email;
        Purchases = purchases;
    }
}

// 5
class Cart
{
    List<string> Cart;

    public Cart(List<string> cart)
    {
        Cart = cart;
    }
}

// 6
class Shipping
{
    string Method;
    int Price;
    int Estimalted_days;

    public Shipping(string method, int price, int estimalted_days)
    {
        Method = method;
        Price = price;
        Estimalted_days = estimalted_days;
    }
}

// 7
class Payment
{
    string Methos;
    string Status;

    public Payment(string methos, string status)
    {
        Method = method;
        Status = status;
    }
}

// 8
class Product8
{
    string product;
    int rating;
    string comment;
}
class Reviews
{
    List<Product8> Reviews;

    public Reviews(List<Product8> reviews)
    {
        Reviews = reviews;
    }
}

// 9
class Product9
{
    string product;
    string discount;
}
class Discounts
{
    List<Product9> Discounts;

    public Student(List<Product9> discounts)
    {
        Discounts = discounts;
    }
}

// 10
class Address10
{
    string type;
    string address;
}
class Addresses
{
    List<Address10> Addresses;

    public Addresses(List<Address10> addresses)
    {
        Addresses = addresses;
    }
}
