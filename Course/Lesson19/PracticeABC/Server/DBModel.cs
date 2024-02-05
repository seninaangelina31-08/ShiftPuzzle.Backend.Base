using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;
using PracticeA;
namespace PracticeA;


class DBModel {
    private List<StoreController.Product> Items = new List<StoreController.Product>();
    private readonly string _jsonFilePath = "DataBase.json";

    private List<StoreController.Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<StoreController.Product>>(json);
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