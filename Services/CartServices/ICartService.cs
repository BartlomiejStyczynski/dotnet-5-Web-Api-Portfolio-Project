using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.CartServices
{
    public interface ICartService
    {
        Task<ServiceResponse<List<GetItemDto>>> GetAllItems(int id);
        Task<ServiceResponse<List<GetItemDto>>> DeleteItemFromCart(int itemId, long quantity);
        Task<ServiceResponse<GetCartDetailsDto>> AddItemToCart(AddCartItemDto request);

        Task<ServiceResponse<NewlyCreatedCartDto>> CreateNewCart(CreateNewCartDto newCart);

        Task<ServiceResponse<List<GetCartDetailsDto>>> DeleteCart(int id);
        Task<ServiceResponse<GetCartDetailsDto>> GetCartDetails(int id);
        Task<ServiceResponse<List<GetCartDetailsDto>>> UpdateCartDetails(UpdateCartDetailsDto request);
    }
}