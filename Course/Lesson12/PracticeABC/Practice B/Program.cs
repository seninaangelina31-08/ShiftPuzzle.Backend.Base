namespace Practice_B;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}



class Product
{
    string name;
    decimal price;
    string description;
}

class Type
{
    string category;
    List<string> products;
}

class Order
{
    int id;
    List<string> items;
    decimal total;
}

class User
{
    string name;
    string email;
    int purchases;
}

class Cart
{
    List<string> cart;
}

class Shipping
{
    string method;
    decimal price;
    int estimated_days;
}

class Payment
{
    string method;
    string status;
}

class Review
{
    string product;
    decimal rating;
    string comment;
}

class Discount
{
    string product;
    string discount;
}

class Address
{
    string type;
    string address;
}
