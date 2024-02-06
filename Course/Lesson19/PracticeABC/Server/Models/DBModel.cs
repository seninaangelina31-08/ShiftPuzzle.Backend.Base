namespace PracticeA;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;

public class DBModel
{

    private List<Product> _items = new List<Product>();

    private string _jsonFilePath;

    private string _jsonFilePathBackUp;

    public DBModel(string jsonFilePath, string jsonFilePathBackUp)
    {
        _jsonFilePath = jsonFilePath;
        _jsonFilePathBackUp = jsonFilePathBackUp;
        ReadDataFromFile();
    }


    private List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json);
    }


    public Product GetProductName(string name)
    {
        return _items.FirstOrDefault(p => p.Name == name);
    }
    public List<Product> GetOutOfStock()
    {
        return _items.Where(p => p.Stock == 0).ToList();
    }
    public List<Product> ItemsAdd(Product newProduct)
    {
        _items.Add(newProduct);
        return _items;
    }
    public List<Product> ItemsRemove(Product product)
    {
        _items.Remove(product);
        return _items;
    }
    public List<Product> GetItems()
    {
        return _items;
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
            _items =  ConvertTextDBToList(ReadDB());
        }
    }

 

    private string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(_items, options);
    }

    private void WriteTiDB(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    public void WriteDataToFile()
    {
        WriteTiDB(ConvertDBtoJson());
    }


    private void WriteTiDBBackUp(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePathBackUp, json);
    }

    public void SaveFilesInBackUp()
    {
        WriteTiDBBackUp(ConvertDBtoJson());
    }
}