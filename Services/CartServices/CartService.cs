using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Data;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.CartServices
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceResponse<List<GetItemDto>>> AddItemToCart(int userId, int itemId, byte quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetItemDto>>> DeleteItemFromCart(int userId, int itemId, byte quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetItemDto>>> GetAllItems(int userId)
        {
            throw new NotImplementedException();
        }
    }
}