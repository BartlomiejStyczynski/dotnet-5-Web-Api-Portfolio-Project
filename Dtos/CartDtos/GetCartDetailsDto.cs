using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos
{
    public class GetCartDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GetItemDto> Items { get; set; }
        
    }
}