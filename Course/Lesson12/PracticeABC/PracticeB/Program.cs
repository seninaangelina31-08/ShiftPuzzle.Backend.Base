namespace practiceb;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Product
{
    public string Name;
    public int Price;
    public string Description;

    public Product(string name, int price, string description)
    {
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}

class Electro
{
    public string Category;
    public List<string> Products;

    public Electro(string category, List<string> products)
    {
        this.Category = category;
        this.Products = products;
    }
}

class Order
{
    public int Id;
    public List<string> Items;
    public int Total;

    public Order(int id, List<string> items, int total)
    {
        this.Id = id;
        this.Items = items;
        this.Total = total;
    }
}

class User
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

class Cart
{
    public List<string> Products;

    public Cart(List<string> products)
    {
        this.Products = products;
    }
}

class Shipping
{
    public string Method;
    public int Price;
    public int Estimated_days;

    public Shipping(string method, int price, int estimated_days)
    {
        this.Method = method;
        this.Price = price;
        this.Estimated_days = estimated_days;
    }
}

class Payment
{
    public string Method;
    public string Status;

    public Payment(string method, string status)
    {
        this.Method = method;
        this.Status = status;
    }
}

class Reviews
{
    public string Product;
    public int Rating;
    public string Comment;

    public Reviews(string product, int rating, string comment)
    {
        this.Product = product;
        this.Rating = rating;
        this.Comment = comment;
    }
}

class Discounts
{
    public string Product;
    public string Discount;

    public Discounts(string product, string discount)
    {
        this.Product = product;
        this.Discount = discount;
    }
}

class Addresses
{
    public string Type;
    public string Address;

    public Addresses(string type, string address)
    {
        this.Type = type;
        this.Address = address;
    }
}
