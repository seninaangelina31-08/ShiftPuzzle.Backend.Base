namespace PracticeC.Controller;
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
    public string delete(string name)
    {
        List<Product> store_list = RWF.ReadJson(path);
        for (int i = 0; i < store_list.Count; i++)
        {
            if (store_list[i].name == name)
            {
            store_list.RemoveAt(i);
            RWF.WriteJSON(store_list, path);
            return name + " delete.";
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

    [HttpGet ("store/changeprice")]
    public string change_price(string name, int price)
    {
        List<Product> store_list = RWF.ReadJson(path);
        for (int i = 0; i < store_list.Count; i++)
        {
            if (store_list[i].name == name)
            {
            store_list[i].price = price;
            RWF.WriteJSON(store_list, path);
            return "Price changed.";
            }
        }
        return "Продукта нет в каталоге.";
    }
    
    [HttpGet ("store/changename")]
    public string change_name(string name, string name_change)
    {
        List<Product> store_list = RWF.ReadJson(path);
        for (int i = 0; i < store_list.Count; i++)
        {
            if (store_list[i].name == name)
            {
            store_list[i].name = name_change;
            RWF.WriteJSON(store_list, path);
            return "Name changed.";
            }
        }
        return "Продукта нет в каталоге.";
    }
    
    [HttpGet ("store/viewnullcount")]
    public List<Product> view_null_count()
    {
        List<Product> store_list = RWF.ReadJson(path);
        List<Product> null_product = new List<Product>();
        for (int i = 0; i < store_list.Count; i++)
        {
            if (store_list[i].count <= 0)
            {
            null_product.Add(store_list[i]);
            return null_product;
            }
        }
        return null_product;
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