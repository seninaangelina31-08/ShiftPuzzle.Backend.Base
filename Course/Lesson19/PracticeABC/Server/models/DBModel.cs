using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;
using namespace Server;



class DBModel {
    private List<Product> Items = new List<Product>();
    private readonly string _jsonFilePath = "DataBase.json";

    private List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json);
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
    public void BackupDB() {
        ReadDataFromFile();

        string json = ConvertDBtoJson();

        string backupFilePath = "BackupDB.json";
        System.IO.File.WriteAllText(backupFilePath, json);
        Console.WriteLine("Database backup created successfully.");
    }

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