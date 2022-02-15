using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Dtos.UserDtos
{
    public class UserCartDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public bool IsSubcribed { get; set; }
        public bool IsGolden { get; set; }
    }
}