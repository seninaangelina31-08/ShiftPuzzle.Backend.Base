﻿using System.Runtime.InteropServices.Marshalling;

namespace Praice_B;

public class Pr1 {
    string Name = "Laptop";
    int Price = 1200;
    string Description = "High performance laptop";

    public Pr1(string name, int price, string description) {
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}

public class Pr2 {
    string category = "Elecronics";
    List<string> products = [
        "TV",
        "Radio",
        "Camera"
    ];
    public Pr2(string category, List<string> products) {
        this.category = category;
        this.products = products;
    }
}

public class Pr3 {
    int id = 12345;
    List<string> items = [
        "Laptop",
        "Camera"
    ];
    int total = 1700;
    public Pr3(int id, List<string> items, int total) {
        this.id = id;
        this.items = items;
        this.total = total;
    }
}

public class Pr4 {
    string name = "John Doe";
    string email = "john@example.com";
    int purchases = 5;

    public Pr4(string name, string email, int purchases) {
        this.name = name;
        this.email = email;
        this.purchases = purchases;
    }

}

class Pr5 {

    List<string> cart = [
        "Product1",
        "Product2",
        "Product3",
        "Product4"
    ];

    public Pr5(List<string> cart) {
        this.cart = cart;
    }
}

public class Pr6 {
    string method = "Standard";
    int price = 20;
    int estimated_days = 3;

    public Pr6(string method, int price, int estimated_days) {
        this.method = method;
        this.price = price;
        this.estimated_days = estimated_days;
    }

}

public class Pr7 {

    string method = "Credit Card";
    string status = "Pending";

    public Pr7(string method, string status) {
        this.method = method;
        this.status = status;
    }
}

public class Pr8 {

    string product = "";
    string rating = "";
    string coment = "";

    public Pr88(string product, string rating, string coment) {
        this.product = product;
        this.rating = rating;
        this.coment = coment;
    }
}

public class Pr9 {

    string product  = "";
    string discount = "";

    public Pr9(string product, string discount) {
        this.product = product;
        this.discount = discount;
    }
}

public class Pr10 {

    string type = "";
    string address = "";
    
    public Pr10(string type, string address) {
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