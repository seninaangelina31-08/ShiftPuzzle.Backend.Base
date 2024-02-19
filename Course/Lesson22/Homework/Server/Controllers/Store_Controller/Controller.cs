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
public class StoreController : ControllerBase
{
    
    private readonly IProductRepository _productRepository;

    public StoreController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }




        [HttpPost]
        [Route("/store/add")]
        public IActionResult Add([FromBody] Product newProduct)
        { 
            _productRepository.AddProduct(newProduct);
            return Ok(_productRepository.GetAllProducts());
        }

        [HttpPost]
        [Route("/store/remove")]
        public IActionResult Delete(string name)
        {
            var product = _productRepository.GetProductByName(name);
            if (product != null)
            {
                _productRepository.DeleteProduct(name);
                return Ok($"{name} удален навсегда");
            }
            else
            {
                return NotFound($"{name} не найден, но можете добавить");
            }
        }

        [HttpGet]
        [Route("/store/show")]
        public IActionResult Show()
        {
            return Ok(_productRepository.GetAllProducts());
        }
      
}

