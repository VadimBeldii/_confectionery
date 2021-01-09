﻿using Confectionery.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;
using Confectionery.BLL.Services;
using System.Text.Json;


namespace Confectionery_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerController : Controller
    {
        private readonly IProductService productService;
        private readonly IOrderService orderService;

        public SellerController(IProductService productService, IOrderService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
        }

        [HttpGet("getcategories")]
        public IActionResult GetCategories()
        {
            return Ok(JsonSerializer.Serialize(productService.GetCategories()));
        }

        [HttpGet("getproducts")]
        public IActionResult GetProducts()
        {
            return Ok(JsonSerializer.Serialize(productService.GetProducts()));
        }

        [HttpGet("getorders")]
        public IActionResult GetOrders()
        {
            return Ok(JsonSerializer.Serialize(orderService.GetOrders()));
        }

        [HttpPost("addorder")]
        public IActionResult AddOrder([FromBody] OrderDTO order)
        {
            orderService.AddOrder(order);
            return Ok();
        }
        [HttpPost("executeorder")]
        public IActionResult ExecuteOrder([FromBody] OrderDTO order)
        {
            orderService.Execute(order);
            return Ok();
        }
    }
}
