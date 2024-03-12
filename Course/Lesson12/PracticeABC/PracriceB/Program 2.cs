namespace PracriceB;
using System;
using System.Collections.Generic;

public class Json1
{
    public string name { get; set; }
    public int price { get; set; }
    public string description { get; set; }
}

public class Json2
{
    public string category { get; set; }
    public List<string> products { get; set; }
}

public class Order
{
    public int id { get; set; }
    public List<string> items { get; set; }
    public int total { get; set; }
}

public class Json3
{
    public Dictionary<string, Order> order { get; set; }
}

public class User
{
    public string name { get; set; }
    public string email { get; set; }
    public int purchases { get; set; }
}

public class Json4
{
    public Dictionary<string, User> user { get; set; }
}

public class Json5
{
    public List<string> cart { get; set; }
}

public class Shipping
{
    public string method { get; set; }
    public int price { get; set; }
    public int estimated_days { get; set; }
}

public class Json6
{
    public Dictionary<string, Shipping> shipping { get; set; }
}

public class Payment
{
    public string method { get; set; }
    public string status { get; set; }
}

public class Json7
{
    public Dictionary<string, Payment> payment { get; set; }
}

public class Obj8
{
    public string product { get; set; }
    public int rating { get; set; }
    public string comment { get; set; }
}

public class Json8
{
    public List<Obj8> reviews { get; set; }
}

public class Obj9
{
    public string product { get; set; }
    public string discount { get; set; }
}

public class Json9
{
    public List<Obj9> discounts { get; set; }
}

public class Obj10
{
    public string type { get; set; }
    public string address { get; set; }
}

public class Json10
{
    public List<Obj10> addresses { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
