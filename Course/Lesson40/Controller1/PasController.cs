using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
public class CarpoolController : ControllerBase
{
    private static List<Carpool> carpools = new List<Carpool>();
    
    [HttpGet("/api/carpool/search")]
    [Authorize]
    public IActionResult Search(string origin, string destination)
    {
        var matchingCarpools = carpools.Where(c => c.Origin == origin && c.Destination == destination).ToList();
        return Ok(matchingCarpools);
    }

    [HttpPost("/api/carpool/add")]
    [Authorize]
    public IActionResult Add(Carpool carpool)
    {   
        carpools.Add(carpool);
        return Ok("Carpool added successfully");
    }

    [HttpDelete("/api/carpool/{id}")]
    [Authorize]
    public IActionResult Delete(int id)
    {
        var carpoolToRemove = carpools.FirstOrDefault(c => c.Id == id);
        if (carpoolToRemove != null)
        {
            carpools.Remove(carpoolToRemove);
            return Ok("Carpool deleted successfully");
        }
        return NotFound();
    }
}