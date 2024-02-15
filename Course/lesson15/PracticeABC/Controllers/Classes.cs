namespace PracticeABC.Controllers;

// Класс продукта
public class Product
{
    // Название
    public string Name { get; set; }
    // Цена
    public double Price { get; set; }
    // В наличии или нет
    public bool IsAvailable { get; set; }
    
    public Product(){}

    public Product(string name, double price, bool isAvailable)
    {
        this.Name = name;
        this.Price = price;
        this.IsAvailable = isAvailable;
    }

}

// Класс списка продуктов
public class ProductList
{
    public List<Product> Items { get; set; }
    
    public ProductList(){}

    public ProductList(List<Product> items)
    {
        this.Items = items;
    }

    public void Add(Product product)
    {
        // Добавлем продукт в список продуктов
        this.Items.Add(product);
    }

    public void Reprice(string name, double newPrice)
    {
        foreach (var item in this.Items)
        {
            // Ищем продукт с заданным названием
            if (item.Name == name)
            {
                // Меняем цену на новую
                item.Price = newPrice;
            }
        }
    }

    public void Rename(string oldName, string newName)
    {
        foreach (var item in this.Items)
        {
            // Ищем продукт с заданным названием
            if (item.Name == oldName)
            {
                // Меняем название на новое
                item.Name = newName;
            }
        }
    }

    public List<Product> GetNonAvailableProducts()
    {  
        // Список продуктов, которых нет на складе
        List<Product> nonAvailable = [];

        foreach(var item in this.Items)
        {
            // Проверяем, есть ли продукт на складе
            if (item.IsAvailable == false)
            {
                // Если есть, то добавляем его в список продуктов
                nonAvailable.Add(item);
            }
        }

        return nonAvailable;
    }
}