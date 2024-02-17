namespace Homework;
using System;
using System.ComponentModel.DataAnnotations;

public class Order
{
    public string Item { get; set; }
    public double Price { get; set; }
    public string Id { get; set; }

    public Order() { }

    public Order(string item, double price, string id)
    {
        Item = item;
        Price = price;
        Id = id;
    }
}