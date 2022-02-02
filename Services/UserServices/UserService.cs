using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_5_Web_Api_Portfolio_Project.Dtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.UserServices
{
 public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetUserDto>>> CreateUser(CreateUserDto newUser)
        {
            var serviceResponse = new ServiceResponse<List<User>>();
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetUserDto>>> DeleteUser(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            var serviceResponse = new ServiceResponse<List<User>>();
            throw new NotImplementedException();
        }
        public async Task<ServiceResponse<GetUserDto>> GetSingleUserById(int id)
        {
            var serviceResponse = new ServiceResponse<User>();
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updatedDto)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            throw new NotImplementedException();
            
        }
    }
}