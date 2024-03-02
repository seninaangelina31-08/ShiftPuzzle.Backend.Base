namespace PracticeA.Models;
public class Product
{
[Required]
[StringLength(100, MinimumLength = 3)]
public string Name { get; set; }
[Range(0.01, 10000)]
public double Price { get; set; }
[Range(0, 10000)]
public int Stock { get; set; }
    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}

public class UserCredentials
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string User { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Pass { get; set; }
}

public class DBModel
{
    public List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json);
    }

    public string ReadDB()
    {
        return System.IO.File.ReadAllText(_jsonFilePath);
    }

    public bool DBExist()
    {
        return System.IO.File.Exists(_jsonFilePath);
    }

    public void ReadDataFromFile()
    {
        if (DBExist())
        { 
            Items =  ConvertTextDBToList(ReadDB());
        }
    }

    public string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(Items, options);
    }

    public void WriteTiDB(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    public void WriteDataToFile()
    { 
        WriteTiDB(ConvertDBtoJson());
    }

    public void BackApp()
    {
        System.IO.File.WriteAllText("DataBase.json", ConvertDBtoJson());
    }
}