namespace PracticeA

public class DBModel
{
    private string _jsonFilePath;
    public DBModel(string jsonfilepath)
    {
        _jsonFilePath = jsonfilepath;
        ReadDataFromFile();
    }
    private BackUp()
    {
        private string _backupBD = "BackupDB.json";
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
            Items = ConvertTextDBToList(ReadDB());
        }
    }

    #endregion
 

    private string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(Items, options);
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