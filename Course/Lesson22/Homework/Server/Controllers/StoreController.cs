namespace Homework;

using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


[ApiController]
public class StoreController : ControllerBase
{
    private readonly IOrderRepository _orderRepository;

    public StoreController(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Order order)
    {
        _orderRepository.AddOrder(order);
        return Ok(_orderRepository.GetAllOrders());
    }

    [HttpPost]
    [Route("/store/remove")]
    public IActionResult Remove([FromBody] string id)
    {
        _orderRepository.DeleteOrder(id);
        return Ok(_orderRepository.GetAllOrders());
    }

    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(_orderRepository.GetAllOrders());
    }


} 
