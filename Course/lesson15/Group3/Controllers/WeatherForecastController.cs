using Microsoft.AspNetCore.Mvc;

namespace Group3.Controllers;

[ApiController]
[Route("api/")]
public class WeatherForecastController : ControllerBase
{
    public string value = "example3";
    public List<string> items = new List<string>{"item1", "item2", "item3", "item4"};

    [HttpGet("get-str")]
    public string get_str()
    {
        return value;
    }

    [HttpGet("get-item")]
    public string get_item(string item)
    {
        return item + " added";
    }

    [HttpGet("get-multiple-values")]
    public int sum(int a, int b)
    {
        Console.WriteLine("Function worked successfully!");
        return a + b;
    }

    [HttpGet("view-list")]
    public List<string> view()
    {
        return items;
    }

    [HttpGet("add-tolist")]
    public List<string> add(string item)
    {
        items.Add(item);
        Console.WriteLine("Function worked successfully!");
        return items;
    }
}
