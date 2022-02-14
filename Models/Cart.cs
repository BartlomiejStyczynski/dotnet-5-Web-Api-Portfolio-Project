using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Models
{
    public class Cart
    {
        public int Id {get ; set; }
        public List<Item> ItemList { get; set; } = new List<Item>();
        public User User { get; set; }
    }
}