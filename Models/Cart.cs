using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Models
{
    public class Cart
    {
        public int Id {get ; set; }
        public string Name { get; set; }
        public bool IsMainCart { get; set; } = false;
        public List<Item> Items { get; set; }
        public User User { get; set; }


    }
}