namespace PracticeA;

public class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public bool haveInStore { get; set; }

    public Product(string Name, int Price, bool HaveInStore)
    {
        this.name = Name;
        this.price = Price; 
        this.haveInStore = HaveInStore;
    }
}