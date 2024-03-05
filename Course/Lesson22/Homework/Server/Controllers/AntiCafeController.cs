namespace Homework;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;


[ApiController]
public class AntiCafeController : ControllerBase
{
    
    private readonly IToadRepository _toadRepository;

    public AntiCafeController(IToadRepository toadRepository)
    {
        _toadRepository = toadRepository;
    }

    [HttpPost]
    [Route("/anticafe/add")]
    public IActionResult Add([FromBody] Toad newToad)
    { 
        _toadRepository.AddToad(newToad);
        return Ok(_toadRepository.GetAllToads());
    }

    [HttpPost]
    [Route("/anticafe/delete")]
    public IActionResult Delete(string name)
    {
        var toad = _toadRepository.GetToadByName(name);
        if (toad != null)
        {
            _toadRepository.DeleteToad(name);
            return Ok($"{name} удален");
        }
        else
        {
            return NotFound($"{name} не найден");
        }
    }

    [HttpGet]
    [Route("/anticafe/show")]
    public IActionResult Show()
    {
        return Ok(_toadRepository.GetAllToads());
    }
      

}