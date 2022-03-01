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
        public int Quantity { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public int Ratting { get; set; }
        public float Price { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
