using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.UserDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos
{
    public class NewlyCreatedCartDto
    {
        public int Id {get ; set; }
        public List<GetItemDto> ItemList { get; set; }
        public UserCartDto User { get; set; }

        public string CartName { get; set; }
    }
}