using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeA
{
    public class DBModel
    {
        private readonly string _jsonFilePath;
        private readonly string _backupJsonFilePath;

        public DBModel(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
            
        }

        public List<Product> ReadDataFromFile()
        {
            if (DBExist())
            {
                return ConvertTextDBToList(ReadDB());
            }
            return new List<Product>();
        }

        public void WriteDataToFile(List<Product> items)
        {
            WriteToDB(ConvertDBtoJson(items));
        }

        private List<Product> ConvertTextDBToList(string json)
        {
            return JsonSerializer.Deserialize<List<Product>>(json);
        }

        private string ReadDB()
        {
            return File.ReadAllText(_jsonFilePath);
        }

        private bool DBExist()
        {
            return File.Exists(_jsonFilePath);
        }

        private string ConvertDBtoJson(List<Product> items)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(items, options);
        }

        private void WriteToDB(string json)
        {
            File.WriteAllText(_jsonFilePath, json);
        }

                public void CreateBackup()
        {
            {
                var backupItems = ReadDataFromFile();
                WriteToBackup(ConvertDBtoJson(backupItems));
                Console.WriteLine("Бэкап успешно не создан ).");
            }
        }

        private void WriteToBackup(string json)
        {
            File.WriteAllText(_backupJsonFilePath, json);
        }
    }
}
