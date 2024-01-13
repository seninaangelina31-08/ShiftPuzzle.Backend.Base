using System;
using System.Collections.Generic;

class Product
{
  string name { get; set; }
  int price { get; set; }
  string description { get; set; }
}

class Category
{
  string category { get; set; }
  List<string> products { get; set; }
}

public class Order
{
  int id { get; set; }
  List<string> items { get; set; }
  int total { get; set; }
}

class User
{
  string name { get; set; }
  string email { get; set; }
  int purchases { get; set; }
}

class Cart
{
  Dictionary<string, object> Products { get; set; }
}

 class Shipping
{
  string method { get; set; }
  int price { get; set; }
  int estimated_days { get; set; }
}

class Payment
{
  string method { get; set; }
  string status { get; set; }
}

class Review
{
  string product { get; set; }
  int rating { get; set; }
  string comment { get; set; }
}

class Discount
{
  string product { get; set; }
  public string discount { get; set; }
}

class Address
{
  string type { get; set; }
  string address { get; set; }
}