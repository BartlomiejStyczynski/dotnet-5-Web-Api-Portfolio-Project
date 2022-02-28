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
        public async Task<ServiceResponse<GetCartDetailsDto>> AddItemToCart(AddCartItemDto request)
        {
            var serviceResponse = new ServiceResponse<GetCartDetailsDto>();
            try
            {
                var productInDb = await _context.Products.FirstOrDefaultAsync(i => i.Id == request.ItemId);

                if (productInDb == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Product not found.";
                    return serviceResponse;
                }

                if (productInDb.AmountInWarehouse < request.Quantity)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Not enougt product in stock.";
                    return serviceResponse;
                }

                var cartInDb = await _context.Carts.Include(c => c.Items)
                                                 .FirstOrDefaultAsync(i => i.Id == request.CartId && i.User.Id == GetUserId());

                if (cartInDb == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Cart not found.";
                    return serviceResponse;
                }

                var itemInCart = cartInDb.Items.FirstOrDefault(i => i.Name.ToLower() == productInDb.Name.ToLower());
                
                if (itemInCart == null)
                {
                    var item = new Item();
                    item.Name = productInDb.Name;
                    item.Price = productInDb.Price;
                    item.Ratting = productInDb.Ratting;
                    item.Quantity = request.Quantity;

                    _context.Items.Add(item);
                    cartInDb.Items.Add(item);
                    await _context.SaveChangesAsync();
                }

                else
                {
                   itemInCart.Quantity += request.Quantity;
                   itemInCart.Ratting = productInDb.Ratting;
                   await _context.SaveChangesAsync();
                }

                serviceResponse.Data = _mapper.Map<GetCartDetailsDto>(cartInDb);
            }

            catch (System.Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCartDetailsDto>> RemoveItemFromCart(RemoveCartItemDto request)
        {
            var serviceResponse = new ServiceResponse<GetCartDetailsDto>();

            try
            {
                var cartInDb = await _context.Carts.FirstOrDefaultAsync(c => c.Id == request.CartId && c.User.Id == GetUserId());
                if (cartInDb == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Cart not found.";
                }
            }
            catch (System.Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetItemDto>>> GetAllItemsInCart(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetItemDto>>();
            try
            {
                var cart = await _context.Carts.Include(c => c.Items).FirstOrDefaultAsync(c => c.Id == id && c.User.Id == GetUserId());


                serviceResponse.Data = cart.Items.Select(item => _mapper.Map<GetItemDto>(item)).ToList();
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
                var cart = new Cart
                {
                    Items = new List<Item>(),
                    Name = newCart.Name,
                    IsMainCart = false,
                    User = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId())
                };


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

        public async Task<ServiceResponse<List<GetCartDetailsDto>>> DeleteCart(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCartDetailsDto>>();

            try
            {
                var cartInDb = await _context.Carts.Include(u => u.User)
                                                .FirstOrDefaultAsync(c => c.Id == id && c.User.Id == GetUserId());
                if (cartInDb != null)
                {
                    _context.Carts.Remove(cartInDb);
                    await _context.SaveChangesAsync();

                    serviceResponse.Data = _context.Carts
                        .Where(c => c.User.Id == GetUserId())
                        .Select(c => _mapper.Map<GetCartDetailsDto>(c)).ToList();
                }
                else
                {
                    serviceResponse.Message = $"Couldn't find cart(id == {id}) or unauthrized user";
                    serviceResponse.Success = false;
                }
            }
            catch (System.Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCartDetailsDto>> GetCartDetails(int id)
        {
            var serviceResponse = new ServiceResponse<GetCartDetailsDto>();
            try
            {
                var cartInDb = await _context.Carts.Include(c => c.User).FirstOrDefaultAsync(c => c.Id == id && c.User.Id == GetUserId());
                serviceResponse.Data = _mapper.Map<GetCartDetailsDto>(cartInDb);
            }
            catch (System.Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCartDetailsDto>>> UpdateCartDetails(UpdateCartDetailsDto request)
        {
            var serviceResponse = new ServiceResponse<List<GetCartDetailsDto>>();
            try
            {
                var cartInDb = await _context.Carts.FirstOrDefaultAsync(c => c.Id == request.Id && c.User.Id == GetUserId());
                if (cartInDb != null)
                {
                    cartInDb.Name = request.Name;
                    await _context.SaveChangesAsync();

                    serviceResponse.Data = await _context.Carts.Where(c => c.User.Id == GetUserId())
                                                                .Select(c => _mapper.Map<GetCartDetailsDto>(c))
                                                                .ToListAsync();
                }

                else
                {
                    serviceResponse.Message = $"Cart {request.Id} not found or wrong user";
                }
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