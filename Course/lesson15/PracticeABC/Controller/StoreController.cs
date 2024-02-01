using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace PracticeABC.Controller;

[ApiController]
[Route("api/")]
public class StoreController : ControllerBase
{
    public List<string> goods = new();

    [HttpGet("store/Add")]
    public IActionResult Add(string good)
    {
        goods.Add(good);
        return Ok(new {status = $"{good} добавлен в базу данных успешно!"});
    }

    [HttpGet("store/Delete")]
    public IActionResult Delete(string good)
    {
        if (goods.Contains(good))
        {
            goods.Remove(good);
            return Ok(new {status = $"{good} успешно удалён из базы данных!"});
        }
        return NotFound(new {status = "Товара нет в базе данных"});
    }

    [HttpGet("store/ShowGoods")]
    public IActionResult ShowGoods()
    {
        if (goods.Count > 0)
        {
            return Ok(new {goods = $"Список товаров: \n{string.Join(", ", goods)}"});
        }
        return NotFound(new {status = "Список товаров пуст ! :( :( :("});
    }
}
