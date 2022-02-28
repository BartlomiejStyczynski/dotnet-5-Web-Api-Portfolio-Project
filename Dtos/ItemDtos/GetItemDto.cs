using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Dtos.ItemDtos
{
    public class GetItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Ratting { get; set; }
        public int Price { get; set; }
    }
}