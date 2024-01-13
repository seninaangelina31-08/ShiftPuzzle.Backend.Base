namespace B;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
class product
{
    string name;
    int price;
    string description;
}

class BJ1
{
    string category;
    string[] products;
}

class order
{
    double id;
    string[] items;
    int total;
}

class user
{
    string name;
    string email;
    int purchases;
}

class card
{
    string[] cart;
}

class shipping
{
    string method;
    int price;
    int estimated_days;
}
class payment
{
    string method;
    string status;
}

class reviews
{
    string product;
    int rating;
    string comment;
}

class discounts
{
    string product;
    string discount;
}

class addresses
{
    string type;
    string address;
}
