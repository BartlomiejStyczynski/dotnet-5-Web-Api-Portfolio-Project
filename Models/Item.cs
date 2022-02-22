using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Ratting { get; set; }
        public long AmountInWarhouse { get; set; }

        public List<Cart> Carts { get; set; }
    }
}