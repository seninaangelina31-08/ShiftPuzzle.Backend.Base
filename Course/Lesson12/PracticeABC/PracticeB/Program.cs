namespace PracticeB;

public class Product
{
    public string Name;
    public double Price;
    public string Description;

    public Product(string name, double price, string description)
    {
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}

public class ProductCategory
{
    public string Category;
    public List<string> Products;

    public ProductCategory(string category, List<string> products)
    {
        this.Category = category;
        this.Products = products;
    }
}

public class Order
{
    public int Id;
    public List<string> Items;
    public float Total;

    public Order(int id, List<string> items, float total)
    {
        this.Id = id;
        this.Items = items;
        this.Total = total;
    }
}   

public class User
{
    public string Name;
    public string Email;
    public int Purchases;

    public User(string name, string email, int purchases)
    {
        this.Name = name;
        this.Email = email;
        this.Purchases = purchases;
    }
}

public class BuyPage
{
    public List<string> Cart;

    public BuyPage(List<string> cart)
    {
        this.Cart = cart;
    }
}

public class Shipping
{
    public string Method;
    public double Price;
    public int EstimatedDays;

    public Shipping(string method, double price, int estimated_days)
    {
        this.Method = method;
        this.Price = price;
        this.EstimatedDays = estimated_days;
    }

}

public class Payment
{
    public string Method;
    public string Status;
    public Payment(string method, string status)
    {
        this.Method = method;
        this.Status = status;
    }
}

public class Review
{
    public string Product;
    public double Rating;
    public string Comment;

    public Review(string product, double rating, string comment)
    {
        this.Product = product;
        this.Rating = rating;
        this.Comment = comment;
    }
}

public class Discount
{
    public string Product;
    public stinrg  Discount;

    public Discount(string product, string discount)
    {
        this.Product = product;
        this.Discount = discount;
    }
}

public class Address
{
    public string Type;
    public string DeliveryAddress;
    public Address(string type, string delivery_address)
    {
        this.Type = type;
        this.DeliveryAddress = delivery_address;
    }
}


class Program
{
    static void Main(string[] args)
    {
        
    }
}
