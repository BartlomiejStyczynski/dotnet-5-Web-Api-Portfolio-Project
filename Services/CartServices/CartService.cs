using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_5_Web_Api_Portfolio_Project.Data;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.CartServices
{
    public class CartService : ICartService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public CartService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;

        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public Task<ServiceResponse<List<GetItemDto>>> AddItemToCart(int itemId, byte quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetItemDto>>> DeleteItemFromCart(int itemId, byte quantity)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetItemDto>>> GetAllItems()
        {
            var serviceResponse = new ServiceResponse<List<GetItemDto>>();
            try
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(c => c.User.Id == GetUserId());


                serviceResponse.Data = cart.ItemList.Select(item => _mapper.Map<GetItemDto>(item)).ToList();
            }
            catch (System.Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<NewlyCreatedCartDto>> CreateNewCart(CreateNewCartDto newCart)
        {
            var serviceResponse = new ServiceResponse<NewlyCreatedCartDto>();
            
            try
            {
                var cart = _mapper.Map<Cart>(newCart);
                cart.User = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId());
                cart.IsMainCart = false;

                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();

                var newlyCreatedCart = await _context.Carts.FirstOrDefaultAsync(c => c.Id == cart.Id);
                serviceResponse.Data = _mapper.Map<NewlyCreatedCartDto>(newlyCreatedCart);
            }

            catch (System.Exception e)
            {               
               serviceResponse.Success = false;
               serviceResponse.Message = e.Message;
            }


            return serviceResponse;
        }

    }
}