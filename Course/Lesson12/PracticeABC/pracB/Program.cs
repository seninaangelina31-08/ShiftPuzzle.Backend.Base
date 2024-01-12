/*1*/
public class Product
    {
        string name;
        int price;
        string description;
    }

public class Json1
{
    public Dictionary<string, Product> product
}

/*2*/
public class Catalog
    {
        string category;
        List<int> products;
    }

/*3*/
public class Order
    {
        int id;
        List<string> items;
        int total;
    }

public class Json3
{
    public Dictionary<string, Order> order
}

/*4*/
public class User
    {
        string name;
        string email;
        int total;
    }

public class Json4
{
    public Dictionary<string, User> user
}

/*5*/
public class Carts
    {
        List<string> cart;
    }

public class Json5
{
    public Dictionary<string, Carts> сarts
}

/*6*/
public class Shipping
    {
        string method;
        int price;
        int estimated_days;
    }

public class Json6
{
    public Dictionary<string, Shipping> shipping
}

/*7*/
public class Payment
    {
        string method;
        string status;
    }

public class Json7
{
    public Dictionary<string, Payment> payment
}

/*8*/

public class Review
    {
        string product
        int rating 
        string comment 
    }

public class Json8
{
    public List<Review> reviews
}

/*9*/

public class Discount
    {
        string product
        string discount
    }

public class Json9
{
    public List<Discount> discounts
}

/*10*/

public class Address
    {
        string type
        string address
    }

public class Json10
{
    public List<Address> addresses
}
