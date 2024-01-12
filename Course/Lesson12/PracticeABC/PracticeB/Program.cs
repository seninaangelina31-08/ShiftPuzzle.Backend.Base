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
