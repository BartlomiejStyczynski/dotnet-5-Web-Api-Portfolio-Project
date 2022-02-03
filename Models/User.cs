using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_5_Web_Api_Portfolio_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PassowrdSalt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public UserRole Role { get; set; }
        public bool IsSubcribed { get; set; } = false;
        public bool IsGolden { get; set; } = false;
    }
}