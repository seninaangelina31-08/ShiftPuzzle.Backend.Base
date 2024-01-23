namespace App_new.Controllers;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }
    
    public Product(){}
    public Product(string name, double price, bool isAvailable)
    {
        this.Name = name;
        this.Price = price;
        this.IsAvailable = isAvailable;
    }

}

public class ProductList
{
    public List<Product> List { get; set; }
    
    public ProductList(){}
    public ProductList(List<Product> list)
    {
        this.List = list;
    }

    public void Add(Product x)
    {
        this.List.Add(x);
    }
    public void RePrice(string name, double new_price)
    {
        foreach (var el in this.List)
        {
            if (el.Name  == name)
            {
                el.Price = new_price;
            }
        }
    }

    public void Rename(string old_name, string new_name)
    {
        foreach (var el in this.List)
        {
            if (el.Name == old_name)
            {
                el.Name = new_name;
            }
        }
    }

    public List<Product> NonAvailable()
    {
        List<Product> non_available = [];

        foreach(var el in this.List)
        {
            if (el.IsAvailable == false)
            {
                non_available.Add(el);
            }
        }

        return non_available;
    }
}