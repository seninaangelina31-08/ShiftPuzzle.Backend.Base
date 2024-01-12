using System.Runtime.InteropServices.Marshalling;

namespace Praice_B;

public class Product1 {
    string Name = "Laptop";
    int Price = 1200;
    string Description = "High performance laptop";

    public Product1(string name, int price, string description) {
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}

public class Electronics2 {
    string category = "Elecronics";
    List<string> products = [
        "TV",
        "Radio",
        "Camera"
    ];
    public Electronics2(string category, List<string> products) {
        this.category = category;
        this.products = products;
    }
}

public class Order3 {
    int id = 12345;
    List<string> items = [
        "Laptop",
        "Camera"
    ];
    int total = 1700;
    public Order3(int id, List<string> items, int total) {
        this.id = id;
        this.items = items;
        this.total = total;
    }
}

public class User4 {
    string name = "John Doe";
    string email = "john@example.com";
    int purchases = 5;

    public User4(string name, string email, int purchases) {
        this.name = name;
        this.email = email;
        this.purchases = purchases;
    }

}

class Cart5 {

    List<string> cart = [
        "Product1",
        "Product2",
        "Product3",
        "Product4"
    ];

    public Cart5(List<string> cart) {
        this.cart = cart;
    }
}

public class Shpping6 {
    string method = "Standard";
    int price = 20;
    int estimated_days = 3;

    public Shpping6(string method, int price, int estimated_days) {
        this.method = method;
        this.price = price;
        this.estimated_days = estimated_days;
    }

}

public class Payment7 {

    string method = "Credit Card";
    string status = "Pending";

    public Payment7(string method, string status) {
        this.method = method;
        this.status = status;
    }
}

public class Reviews8 {

    string product = "";
    string rating = "";
    string coment = "";

    public Reviews8(string product, string rating, string coment) {
        this.product = product;
        this.rating = rating;
        this.coment = coment;
    }
}

public class Discounts9 {

    string product  = "";
    string discount = "";

    public Discounts9(string product, string discount) {
        this.product = product;
        this.discount = discount;
    }
}

public class Addresses10 {

    string type = "";
    string address = "";
    
    public Addresses10(string type, string address) {
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
