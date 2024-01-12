namespace PracticeB;

class Product
{
    string name;
    int price;
    string description;

    public Product(string Name, int Price, string Description)
    {
        name = Name;
        price = Price;
        description = Description;
    }
}

class Category
{
    string category;
    List<string> products;

    public Category(string Category, List<string> Products)
    {
        category = Category;
        products = Products;
    }
}

class Order
{
    int id;
    List<string> items;
    int total;

    public Order(int Id, List<string> Items, int Total)
    {
        id =  Id;
        items = Items;
        total = Total;
    }
}

class User
{
    string name;
    string email;
    int purchases;

    public User(string Name, string Email, int Purchases)
    {
        name = Name;
        email = Email;
        purchases = Purchases;
    }
}

class Cart
{
    List<string> cart;
    
    public Cart(List<string> items)//Cart)
    {
        cart = items; //Cart;
    }
}

class Shipping
{
    string method;
    int price;
    int estimated_days;

    public Shipping(string Method, int Price, int Estimated_days)
    {
        method = Method;
        price = Price;
        estimated_days = Estimated_days;
    }
}

class Payment
{
    string method;
    string status;

    public Payment(string Method, string Status)
    {
        method = Method;
        status = Status;
    }
}

class Reviews
{
    string product;
    int rating;
    string comment;

    public Reviews(string Product, int Rating, string Comment)
    {
        product = Product;
        rating = Rating;
        comment = Comment;
    }
}

class Discounts
{
    string product;
    string discount;

    public Discounts(string Product, string Discount)
    {
        product = Product;
        discount = Discount;
    }
}

class Addresses
{
    string type;
    string address;

    public Addresses(string Type, string Address)
    {
        type = Type;
        address = Address;
    }
}

class Program
{
    
}
