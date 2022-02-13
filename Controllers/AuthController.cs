using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_5_Web_Api_Portfolio_Project.Data;
using dotnet_5_Web_Api_Portfolio_Project.Dtos.UserDtos;
using dotnet_5_Web_Api_Portfolio_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_5_Web_Api_Portfolio_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        private readonly IMapper _mapper;
        public AuthController(IAuthRepository authRepo, IMapper mapper)
        {
            _mapper = mapper;
            _authRepo = authRepo;
            
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var serviceResponse = await _authRepo.Register(
                _mapper.Map<User>(request), request.Password
            );

            if(!serviceResponse.Success)
            {
                return BadRequest();
            }

            return Ok(serviceResponse);
        }

        [HttpPost("Login")]

        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var serviceResponse = await _authRepo.Login(request.Username, request.Password);

            if(!serviceResponse.Success)
            {
                return BadRequest();
            }               
            return Ok(serviceResponse);
        }
    }
}