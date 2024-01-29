namespace PracticeA.Controller;
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

    [HttpGet ("store/add")]
    public string add(string element)
    {
        Store store_list = RWF.ReadJson(path);
        store_list.store.Add(element);
        RWF.WriteJSON(store_list, path);
        return element + " add.";
    }

    [HttpGet ("store/delete")]
    public string delete(string element)
    {
        Store store_list = RWF.ReadJson(path);
        for (int i = 0; i < store_list.store.Count; i++)
        {
            if (store_list.store[i] == element)
            {
            store_list.store.RemoveAt(i);
            RWF.WriteJSON(store_list, path);
            return element + " delete.";
            }
        }
        return "Продукта нет в каталоге.";
        
    }

    [HttpGet ("store/view")]
    public List<string> view()
    {
        Store store_list = RWF.ReadJson(path);
        return store_list.store;
    }
}

[System.Serializable] public class Store
{
    public List<string> store { get; set; }
    public Store() {}
    public Store(List<string> store_copy)
    {
        this.store = store_copy;
    }

}

public class RWFile
{
    
    public Store ReadJson(string path)
    {
        string jsonFromFile = File.ReadAllText(path);
        Store store_list = JsonSerializer.Deserialize<Store>(jsonFromFile);
        return store_list;
    }
    public void WriteJSON(Store store, string path)
    {
        string json = JsonSerializer.Serialize(store);
        File.WriteAllText(path, json);
        return;
    }
}