namespace PracticeB.Controller;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

[ApiController] 
public class StoreController : ControllerBase
{
    const string path = "store.json";

    
    RWFile RWF = new RWFile();

    [HttpGet ("store/check")]
    public string check()
    {
        return RWF.boolSerialize(path);
    }

    [HttpGet ("store/add")]
    public string add(string name, int price, string description, int count)
    {
        List<Product> store_list = RWF.ReadJson(path);
        Product new_product = new Product(name, price, description, count);
        store_list.Add(new_product);
        RWF.WriteJSON(store_list, path);
        return name + " add.";
    }

    [HttpGet ("store/delete")]
    public string delete(string element)
    {
        List<Product> store_list = RWF.ReadJson(path);
        for (int i = 0; i < store_list.Count; i++)
        {
            if (store_list[i].name == element)
            {
            store_list.RemoveAt(i);
            RWF.WriteJSON(store_list, path);
            return element + " delete.";
            }
        }
        return "Продукта нет в каталоге.";
        
    }

    [HttpGet ("store/view")]
    public List<Product> view()
    {
        List<Product> store_list = RWF.ReadJson(path);
        return store_list;
    }
}

[System.Serializable] public class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public string description { get; set; }
    public int count { get; set; }
    public Product() {}
    public Product(string name_copy, int price_copy, string description_copy, int count_copy)
    {
        this.name = name_copy;
        this.price = price_copy;
        this.description = description_copy;
        this.count = count_copy;
    }
}

public class RWFile
{
    
    public List<Product> ReadJson(string path)
    {
        string jsonFromFile = File.ReadAllText(path);
        List<Product> store_list = JsonSerializer.Deserialize<List<Product>>(jsonFromFile);
        return store_list;
    }

    public void WriteJSON(List<Product> store, string path)
    {
        string json = JsonSerializer.Serialize(store);
        File.WriteAllText(path, json);
        return;
    }

    public string boolSerialize(string path)
    {
        if (File.Exists(path)) return "OK";
        else return "NotFound";
    }
}