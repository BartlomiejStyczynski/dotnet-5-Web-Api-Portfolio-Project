using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.CartServices
{
    public interface ICartService
    {
        Task<ServiceResponse<List<GetItemDto>>> GetAllItems();
        Task<ServiceResponse<List<GetItemDto>>> DeleteItemFromCart(int id);
        Task<ServiceResponse<List<GetItemDto>>> AddItemToCart(int id, int quantity);
    }
}