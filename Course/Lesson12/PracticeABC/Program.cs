using System;

class Program
{
    class product
    {
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public product(string name, int price, string description)
        {
            this.name = name;  
            this.price = price;
            this.description = description;
        }
    }

    class j2
    {
        public string category { get; set; }
        public string[] products { get; set; }
        public j2(string a, string[]b)
        {
            this.category = a;
            this.products = b;
        }

    }
    class order
    {
        public int id { get; set; }
        public string[] items { get; set; }
        public int total { get; set; }
        public order(int id, string[] items, int total) 
        {
            this.id = id;
            this.items = items;
            this.total= total;
        }
    }
    class user
    {
        public string name { get; set; }
        public string email { get; set; }
        public int purchases { get; set; }
        public user(string name, string email, int purchases)
        {
            this.name = name;
            this.email = email;
            this.purchases = purchases;
        }
    }
    class j5
    {
        public string[] cart { get; set; }
        public j5(string[]a) 
        { 
            this.cart = a;
        }
    }
    class shipping
    {
        public string method { get; set; }
        public int price { get; set; }
        public int estimated_days { get; set; }
        public shipping(string method, int price, int estimated_days)
        {
            this.method = method;
            this.price = price;
            this.estimated_days = estimated_days;
        }
    }
    class payment
    {
        public string method { get; set; }
        public string status { get; set; }
        public payment(string method, string status)
        {
            this.method = method;
            this.status = status;
        }
    }
    class reviews
    {
        public string product { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        public reviews(string product, int rating, string comment)
        {
            this.product = product;
            this.rating = rating;
            this.comment = comment;
        }
    }
    class discounts
    {
        public string product { get; set; }
        public string discount { get; set; }
        public discounts(string product, string discount)
        {
            this.product = product;
            this.discount = discount;
        }
    }
    class addresses
    {
        public string type { get; set; }
        public string address { get; set; }
        public addresses(string type, string address)
        {
            this.type = type;
            this.address = address;
        }
    }
    static void Main()
    {

    }
}
