using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_5_Web_Api_Portfolio_Project.Dtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using Microsoft.AspNetCore.Mvc;
using dotnet_5_Web_Api_Portfolio_Project.Services.UserServices;

namespace dotnet_5_Web_Api_Portfolio_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
   
        }   

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> GetAllGetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<User>>> GetSingleUser(int Id)
        {
            return Ok(await _userService.GetSingleUserById(Id));
        }

        [HttpPost("CreateUser")]

        public async Task<ActionResult<ServiceResponse<User>>> CreateUser(CreateUserDto user)
        {
            return Ok(await _userService.CreateUser(user));
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> UpdateUser(UpdateUserDto updatedUser)
        {
            return Ok(await _userService.UpdateUser(updatedUser));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetUserDto>>>> DeleteUser(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        }


    }
}