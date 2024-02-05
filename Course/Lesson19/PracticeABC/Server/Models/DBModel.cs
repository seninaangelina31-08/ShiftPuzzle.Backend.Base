namespace PracticeA;

[System.Serializable] public class DBModel
{
    private List<Product> Items { get; set; }
    private readonly string _jsonFilePath { get; set; }


    public DBModel(List<Product> items, string jsFP)
    {
        this.Items = Items;
        this._jsonFilePath = jsFP;
    }


    public string ReadDB()
    {
        return System.IO.File.ReadAllText(this._jsonFilePath);
    }
    public bool DBExist()
    {
        return System.IO.File.Exists(this._jsonFilePath);
    }
    public void ReadDataFromFile()
    {
        if (DBExist())
        { 
            this.Items =  ConvertTextDBToList(ReadDB());
        }
    }
     public string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(this.Items, options);
    }

    public void WriteToDB(string json)
    {
        System.IO.File.WriteAllText(this._jsonFilePath, json);
    }

    public void WriteDataToFile()
    { 
        WriteToDB(ConvertDBtoJson());
    }
}