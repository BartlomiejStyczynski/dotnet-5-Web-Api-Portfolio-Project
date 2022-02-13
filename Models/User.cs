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
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public UserRole Role { get; set; } = UserRole.Default;
        public bool IsSubcribed { get; set; } = false;
        public bool IsGolden { get; set; } = false;
    }
}