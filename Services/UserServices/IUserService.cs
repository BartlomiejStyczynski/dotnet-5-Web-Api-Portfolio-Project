using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.UserServices
{
    public interface IUserService
    {
        Task<ServiceResponse<List<GetUserDto>>> GetAllUsers();
        Task<ServiceResponse<GetUserDto>> GetSingleUserById(int id);
        Task<ServiceResponse<GetUserDto>> CreateUser(CreateUserDto newUser);

        Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updatedDto);

        Task<ServiceResponse<List<GetUserDto>>> DeleteUser(int id);
    }
}