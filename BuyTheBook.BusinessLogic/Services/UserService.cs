using BuyTheBook.BusinessLogic.Abstract;
using BuyTheBook.Models.Entities.Identitty;
using BuyTheBook.Shared.DTOs.Identity;
using Castle.Core.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        public Task<UserDto> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDto> Login(LoginDto request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(RegisterDto request)
        {
            throw new NotImplementedException();
        }
    }
}
