using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Models
{
    public class ServiceResponse <T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Massage { get; set; } = null;
        
    }
}