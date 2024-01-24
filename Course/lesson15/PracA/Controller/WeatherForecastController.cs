using Microsoft.AspNetCore.Mvc;


namespace PracABC;

[Route("store/")]
[ApiController] 
public class StoreController : ControllerBase
{
    public List<Prod> shop_list = new List<Prod>{new Prod { name="milk", cost = 79, in = true}};

    [HttpGet("add-product")]
    public string add(string product)
    {
        shop_list.Add(product);
        return shop_list[4];
        return "OK";
    }

    [HttpGet("delete-product")]
    public string delete(Prod product)
    {
        shop_list.Remove(product);
        return "OK";
    }

    [HttpGet("view-product")]
    public List<Prod> view()
    {
        return shop_list;
    }
}

[System.Serializable] public class Prod
{
    public string name { get; set; }
    public int cost { get; set; }
    public bool in { get; set; }
    
    
    public Prod() { }
    
    public Prod(string name, int cost, bool in)
    {
        this.name = name;
        this.cost = cost;
        this.in = in;
    }
}
