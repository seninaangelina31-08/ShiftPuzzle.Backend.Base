namespace PracticeA;

public class ModelDB
{
    private List<Product> Items = new List<Product>();

    private readonly string _jsonFilePath = "DataBase.json";

    public ModelDB()
    {
        ReadDataFromFile();
    }

    private List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json)
    }

    private string ReadDB()
    {
        return System.IO.File.ReadAllText(_jsonFilePath);
    }

    private bool DBExist()
    {
        return System.IO.File.Exists(_jsonFilePath);
    }

    private void ReadDataFromFile()
    {
        if (DBExist())
        { 
            Items =  ConvertTextDBToList(ReadDB());
        }
    }

    #endregion
 

    private string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        retunr JsonSerializer.Serialize(Items, options);
    }

    private void WriteTiDB(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    private void WriteDataToFile()
    { 
        WriteTiDB(ConvertDBtoJson());
    }
 



}