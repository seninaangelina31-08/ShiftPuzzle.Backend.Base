namespace PracticeABC;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Product
{

    [Required]

    public int Id { get; set; }

    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [Range(0.01, 10000)]
    public double Price { get; set; }

    [Range(0, 10000)]
    public int Stock { get; set; }

    public Product(int id, string name, double price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
}
