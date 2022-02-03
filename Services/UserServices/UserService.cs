using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_5_Web_Api_Portfolio_Project.Data;
using dotnet_5_Web_Api_Portfolio_Project.Dtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_5_Web_Api_Portfolio_Project.Services.UserServices
{
 public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public UserService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetUserDto>> CreateUser(CreateUserDto newUser)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var createdUser = _mapper.Map<User>(newUser);
            createdUser.DateCreated = DateTime.Now;
            createdUser.Role = UserRole.Default;

            _context.Users.Add(createdUser);
            await _context.SaveChangesAsync();

            serviceResponse.Data = _mapper.Map<GetUserDto>(createdUser);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserDto>>> DeleteUser(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            try
            {
                var userInDb = await _context.Users.FirstAsync(u => u.Id == id);
                var deletedUserName = userInDb.Nickname;
                _context.Users.Remove(userInDb);
                await _context.SaveChangesAsync();

                serviceResponse.Massage = $"Susccessfully deleted {deletedUserName} from database.";
            }
            catch (System.Exception e)
            {
                
                serviceResponse.Massage = e.Message;
            }
            
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            var dbUsers = await _context.Users.ToListAsync();

            serviceResponse.Data = dbUsers.Select(u => _mapper.Map<GetUserDto>(u)).ToList();
            return serviceResponse;
        }
        public async Task<ServiceResponse<GetUserDto>> GetSingleUserById(int id)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var dbUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            serviceResponse.Data = _mapper.Map<GetUserDto>(dbUser);
            return serviceResponse;

        }

        public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updatedUser)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            try
            {
                var userInDb = await _context.Users.FirstOrDefaultAsync(u => u.Id == updatedUser.Id);

                userInDb = _mapper.Map<User>(updatedUser);

                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetUserDto>(userInDb);
                
            }
            catch (System.Exception)
            {

            }

            return serviceResponse;
        }
    }
}