using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using dotnet_5_Web_Api_Portfolio_Project.Services.CartServices;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("Get all users cart items{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> GetAllItems(int id)
        {
                return Ok(await _cartService.GetAllItemsInCart(id));          
        }
        [Authorize]
        [HttpPost("remove item from cart")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> RemoveItemFromCart(RemoveCartItemDto request)
        {
            return Ok(await _cartService.RemoveItemFromCart(request));
        }
        [Authorize]
        [HttpPost("Add item to cart")]
        public async Task<ActionResult<ServiceResponse<List<GetItemDto>>>> AddItemToCart(AddCartItemDto request)
        {
            return Ok(await _cartService.AddItemToCart(request));
        }
        [Authorize]
        [HttpPost("CreateNewCart")]
        public async Task<ActionResult<ServiceResponse<NewlyCreatedCartDto>>> CreateNewCart(CreateNewCartDto cart)
        {
            return Ok(await _cartService.CreateNewCart(cart));
        }

        [Authorize]
        [HttpDelete("DeleteCart{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCartDetailsDto>>>> DeleteCart(int id)
        {
            return Ok(await _cartService.DeleteCart(id));    
        }

        [Authorize]
        [HttpGet("GetCartDetails{id}")]
        public async Task<ActionResult<List<GetCartDetailsDto>>> GetCartDetails(int id)
        {
            return Ok(await _cartService.GetCartDetails(id));
        }

        [Authorize]
        [HttpPost("UpdateCartDetails{id}")]
        public async Task<ActionResult<List<GetCartDetailsDto>>> UpdateCartDetails(UpdateCartDetailsDto request)
        {
            return Ok(await _cartService.UpdateCartDetails(request));
        }
        

    }
}