using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;

namespace PracticeB
{

    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
    public class CategoryandProducts
    {
        public string category { get; set; }
        public List<string> products { get; set; }
    }
    public class Orders
    {

        public class Order
        {
            public int id { get; set; }
            public List<string> items { get; set; }
            public int total { get; set; }
        }
        
        public Order order { get; set; }
    }
    public class UserData
    {
        public class User
        {
            public string name { get; set; }
            public string email { get; set; }
            public int purchases { get; set; }
        }
        
        public User user { get; set; }
    }
    public class Cart
    {
        public List<string> cart { get; set; }
    }

    public class Shipping
    {
        public string method { get; set; }
        public int price { get; set; }
        public int estimated_days { get; set; }
    }
    public class Payment
    {
        public string method { get; set; }
        public string status { get; set; }
    }
     public class Review
    {
        public class Rev
        {
            public string product { get; set; }
            public int rating { get; set; }
            public string comment { get; set; }
        }
        public List<Review> reviews { get; set; }
    }

    public class Discounts
    {
        public class Dis
        {
            public string product { get; set; }
            public string discount { get; set; }
        }
        public List<Discount> discounts { get; set; }
    }

    public class Address
    {
        public class Add
        {
            public string type { get; set; }
            public string address { get; set; }
        }
        public List<Address> addresses { get; set; }
    }
}
