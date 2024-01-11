using System;
using System.Collections.Generic;

// Класс для Product
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public Product(string name, decimal price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
    }
}

// Класс для Category
public class Category
{
    public string CategoryName { get; set; }
    public List<string> Products { get; set; }

    public Category(string categoryName, List<string> products)
    {
        CategoryName = categoryName;
        Products = products;
    }
}

// Класс для Order
public class Order
{
    public int Id { get; set; }
    public List<string> Items { get; set; }
    public decimal Total { get; set; }

    public Order(int id, List<string> items, decimal total)
    {
        Id = id;
        Items = items;
        Total = total;
    }
}

// Класс для User
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Purchases { get; set; }

    public User(string name, string email, int purchases)
    {
        Name = name;
        Email = email;
        Purchases = purchases;
    }
}

// Класс для Cart
public class Cart
{
    public List<string> Products { get; set; }

    public Cart(List<string> products)
    {
        Products = products;
    }
}

// Класс для Shipping
public class Shipping
{
    public string Method { get; set; }
    public decimal Price { get; set; }
    public int EstimatedDays { get; set; }

    public Shipping(string method, decimal price, int estimatedDays)
    {
        Method = method;
        Price = price;
        EstimatedDays = estimatedDays;
    }
}

// Класс для Payment
public class Payment
{
    public string Method { get; set; }
    public string Status { get; set; }

    public Payment(string method, string status)
    {
        Method = method;
        Status = status;
    }
}

// Класс для Review
public class Review
{
    public string Product { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }

    public Review(string product, int rating, string comment)
    {
        Product = product;
        Rating = rating;
        Comment = comment;
    }
}

// Класс для Discount
public class Discount
{
    public string Product { get; set; }
    public string DiscountPercentage { get; set; }

    public Discount(string product, string discountPercentage)
    {
        Product = product;
        DiscountPercentage = discountPercentage;
    }
}

// Класс для Address
public class Address
{
    public string Type { get; set; }
    public string AddressText { get; set; }

    public Address(string type, string addressText)
    {
        Type = type;
        AddressText = addressText;
    }
}
