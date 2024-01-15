public class Product {
    string Name = "Laptop";
    int Price = 1200;
    string Description = "High performance laptop";

    public Product(string name, int price, string description) {
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}public class Electronics {
    string category = "Elecronics";
    List<string> products = 
    [
        "TV",
        "Radio",
        "Camera"
    ];
    public Electronics(string category, List<string> products) {
        this.category = category;
        this.products = products;
    }
}

public class Order 
{
    int id = 12345;
    List<string> items = 
    [
        "Laptop",
        "Camera"
    ];
    int total = 1700;
    public Order(int id, List<string> items, int total) {
        this.id = id;
        this.items = items;
        this.total = total;
    }
}

public class User {
    string name = "John Doe";
    string email = "john@example.com";
    int purchases = 5;

    public User(string name, string email, int purchases) {
        this.name = name;
        this.email = email;
        this.purchases = purchases;
    }

}

public class Cart
{

    List<string> cart = [
        "Product1",
        "Product2",
        "Product3",
        "Product4"
    ];

    public Cart(List<string> cart) {
        this.cart = cart;
    }
}

public class Shpping
{
    string method = "Standard";
    int price = 20;
    int estimated_days = 3;

    public Shpping(string method, int price, int estimated_days) {
        this.method = method;
        this.price = price;
        this.estimated_days = estimated_days;
    }

}

public class Payment
{

    string method = "Credit Card";
    string status = "Pending";

    public Payment(string method, string status) {
        this.method = method;
        this.status = status;
    }
}

public class Reviews
{

    string product = "";
    string rating = "";
    string coment = "";

    public Reviews(string product, string rating, string coment) {
        this.product = product;
        this.rating = rating;
        this.coment = coment;
    }
}

public class Discounts
{

    string product  = "";
    string discount = "";

    public Discounts(string product, string discount) {
        this.product = product;
        this.discount = discount;
    }
}

public class Addresses
{

    string type = "";
    string address = "";
    
    public Addresses(string type, string address) {
        this.type = type;
        this.address = address;
    }
}




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}