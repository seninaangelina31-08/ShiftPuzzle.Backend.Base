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
    string name;
    int price;
    string description;
}

// 2
class Category
{
    string category;
    List<string> products;
}

// 3
class Order{
    int id;
    List<string> items;
    int total;
}

// 4
class User
{
    string name;
    string email;
    int purchases;
}

// 5
class Cart
{
    List<string> cart;
}

// 6
class Shipping
{
    string method;
    int price;
    int estimalted_days;
}

// 7
class Payment
{
    string methos;
    string status;
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
    List<Product8> reviews;
}

// 9
class Product9
{
    string product;
    string discount;
}
class Discounts
{
    List<Product9> discounts;
}

// 10
class Address10
{
    string type;
    string address;
}
class Addresses
{
    List<Address10> addresses;
}
