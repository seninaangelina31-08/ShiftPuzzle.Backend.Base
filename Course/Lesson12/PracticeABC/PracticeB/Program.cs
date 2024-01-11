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
    public Product(string name, int price, string description){
        Name = name;
        Price = price;
        Description = description;
    }
}

// 2
class Category
{
    public Category(string category, List<string> products){
        Category_name = category;
        Products = products;
    }
    string category;
    List<string> products;
}

// 3
class Order{
    public Order(int id, List<string> items, int total){
        Id = id;
        Items = items;
        Total = total;
    }
}

// 4
class User
{
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
    public Cart(List<string> cart)
    {
        Cart = cart;
    }
}

// 6
class Shipping
{
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
    public Addresses(List<Address10> addresses)
    {
        Addresses = addresses;
    }
}
