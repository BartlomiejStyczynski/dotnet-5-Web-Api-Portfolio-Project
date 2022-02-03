using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.CartServices
{
    public class CartService : ICartService
    {
        public Task<ServiceResponse<List<GetItemDto>>> AddItemToCart(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetItemDto>>> DeleteItemFromCart(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetItemDto>>> GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
}