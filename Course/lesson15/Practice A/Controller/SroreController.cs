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
    public List<string> products = new List<string>{"Apple", "Ananas", "Bananas"};

    [HttpGet ("store/add")]
    public string add(string element)
    {
        products.Add(element);
        return element + " add.";
    }

    [HttpGet ("store/delete")]
    public List<string> delete()
    {
        products.RemoveAt(products.Count - 1);
        return products;
    }

    [HttpGet ("store/view")]
    public List<string> view()
    {
    return products;
    }
}


