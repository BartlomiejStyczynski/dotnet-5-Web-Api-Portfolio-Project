using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_5_Web_Api_Portfolio_Project.Dtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.UserDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // user maps

             CreateMap<User, GetUserDto>();
             CreateMap<GetUserDto, User>();
             CreateMap<UserRegisterDto, User>();
             CreateMap<UserLoginDto, User>();
             CreateMap<User, UserRegisterDto>();
             CreateMap<User, UserCartDto>();

             //cart maps

             CreateMap<CreateNewCartDto, Cart>();
             CreateMap<Cart, NewlyCreatedCartDto>();
             CreateMap<Cart, GetCartDetailsDto>();
             CreateMap<UpdateCartDetailsDto, Cart>();
             
             // product maps

            CreateMap<Product, Item>().ForMember(rec => rec.Id, opt => opt.Ignore());

            // item MapControllers

            CreateMap<Item, GetItemDto>();

        }
    }
}