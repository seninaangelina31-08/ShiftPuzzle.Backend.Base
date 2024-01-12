namespace PracticeC;
using System;
using System.Collections.Generic;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
}

public class Order
{
    public int user_id { get; set; }
    public int product_id { get; set; }
}

public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public int money { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
