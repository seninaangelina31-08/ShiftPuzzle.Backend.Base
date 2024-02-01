using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PracticeABC.Controller;

[ApiController]
[Route("api/")]
public class StoreController : ControllerBase
{
    public List<string> goods = new();

    [HttpGet("store/Add")]
    public void Add(string good)
    {
        goods.Add(good);
    }

    [HttpGet("store/Delete")]
    public void Delete(string good)
    {
        goods.Remove(good);
    }

    [HttpGet("store/ShowGoods")]
    public string ShowGoods()
    {
        return $"Список продуктов:\n{goods}";
    }
}
