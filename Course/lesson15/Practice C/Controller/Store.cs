namespace PracticeC.Controller;
[System.Serializable] public class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public string description { get; set; }
    public int count { get; set; }
    public Product() {}
    public Product(string name_copy, int price_copy, string description_copy, int count_copy)
    {
        this.name = name_copy;
        this.price = price_copy;
        this.description = description_copy;
        this.count = count_copy;
    }
}