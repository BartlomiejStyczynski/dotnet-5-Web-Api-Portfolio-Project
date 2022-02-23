using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Dtos.CartDtos
{
    public class AddCartItemDto
    {
        public int CartId { get; set; }
        public int ItemId { get; set; }

        public int Quantity { get; set; }

    }
}