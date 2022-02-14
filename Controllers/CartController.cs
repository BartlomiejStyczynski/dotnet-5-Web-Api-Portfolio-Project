using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using dotnet_5_Web_Api_Portfolio_Project.Services.CartServices;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_5_Web_Api_Portfolio_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        
        public CartController(ICartService cartService)
        {
            _cartService = cartService;           
        }

        [HttpGet("Get all users cart items")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> GetAllItems()
        {
                return Ok(await _cartService.GetAllItems());          
        }
        [HttpPost("delete item")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> DeleteItemFromCart(int userId, int itemId, byte quantity)
        {
            return Ok();
        }

        [HttpPost("Add item to cart")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> AddItemToCart(int userId, int itemId, byte quantity)
        {
            return Ok();
        }

    }
}