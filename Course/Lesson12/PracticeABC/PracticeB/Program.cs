public class Product
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

public class Shop
{
    public string Category;
    public List<string> Products;

    public Shop(string category, List<string> products)
    {
        this.Category = category;
        this.Products = products;
    }
}

public class Order
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

public class Cart
{
    public List<string> Cart_List;

    public Cart(List<string> cart_List)
    {
        this.Cart_List = cart_List;
    }
}

public class Shipping
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

public class Reviews
{
    public string Laptop;
    public int Rating;
    public string Comment;

    public Reviews(string laptop, int rating, string comment)
    {
        this.Laptop = laptop;
        this.Rating = rating;
        this.Comment = comment;
    }
}

public class Discounts
{
    public string Product;
    public string Discount;

    public Discounts(string product, string discount)
    {
        this.Product = product;
        this.Discount = discount;
    }
}

public class Addresses
{
    public string Type;
    public string Addres;

    public Addresses(string type, string addres)
    {
        this.Type = type;
        this.Addres = addres;
    }
}