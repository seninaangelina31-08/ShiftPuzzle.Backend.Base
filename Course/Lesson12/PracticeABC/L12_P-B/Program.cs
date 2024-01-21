namespace L12_P_B;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Product
    {
        public string name;
        public int price;
        public string description;
    }

    public class JSON2
    {
        public string category;
        public List<string> products;
    }

    public class Order
    {
        public int id;
        public List<string> items;
        public int total;
    }

    public class User
    {
        public string name;
        public string email;
        public int purchases;
    }

    public class JSON5
    {
        public List<string> cart;
    }

    public class Shipping
    {
        public string method;
        public int price;
        public int estimated_days;
    }

    public class Payment
    {
        public string method;
        public string status;
    }

    public class JSON8
    {
        public List<Dictionary<string, string>> reviews;
    }

    public class JSON9
    {
        public List<Dictionary<string, string>> discounts;
    }

    public class JSON10
    {
        public List<Dictionary<string, string>> addresses;
    }

}
