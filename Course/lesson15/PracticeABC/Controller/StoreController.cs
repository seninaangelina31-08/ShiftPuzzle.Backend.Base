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
    public List<Good> goods = new();

    [HttpGet("store/Add")]
    public IActionResult Add(string name, float price)
    {
        goods.Add(new Good(name, price));
        return Ok(new {status = $"{name} добавлен в базу данных успешно!"});
    }

    [HttpGet("store/Delete")]
    public IActionResult Delete(string name)
    {
        var good = goods.FirstOrDefault(p => p.Name == name);
        
        if (good is not null)
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
            return Ok(new {goods = $"Список товаров: \n{string.Join(", ", goods.Select(x => x.Name).ToArray())}"});
        }
        return NotFound(new {status = "Список товаров пуст ! :( :( :("});
    }


    [HttpGet("store/ChangePrice")]
    public IActionResult ChangePrice(int newPrice, string name)
    {
        var good = goods.FirstOrDefault(p => p.Name == name);
        if (good is not null)
        {
            goods.Remove(good);
            return Ok(new {status = $"Цена {name} успешно изменена"});
        }
        return NotFound(new {status = "Товара нет в базе данных"});
    }

    [HttpGet("store/ChangeName")]
    public IActionResult ChangeName(string newName, string oldName)
    {
        var good = goods.FirstOrDefault(p => p.Name == oldName);
        if (good is not null)
        {
            goods.Remove(good);
            return Ok(new {status = $"Название {oldName} успешно изменено на {newName}"});
        }
        return NotFound(new {status = "Товара нет в базе данных"});
    }

    [HttpGet("store/ShowNotAvailableGoods")]
    public IActionResult ShowNotAvailableGoods()
    {
        if (goods.Count != 0)
        {

            var notAvailable = goods.Where(p => p.IsAvailable = true);
            return Ok(new {status = $"В наличии нет: {string.Join("\n", notAvailable.Select(x => x.Name).ToArray())}"});
        }
        return NotFound(new {status = "Все товары в наличии"});
    }
}
