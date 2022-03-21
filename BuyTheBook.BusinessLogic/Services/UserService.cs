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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public UserService(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public Task<UserDto> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponseDto> Login(LoginDto request)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, request.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);



                var authClaims = new List<Claim>
{
new Claim(ClaimTypes.Name, user.UserName),
new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
};



                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }



                //var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));



                //var token = new JwtSecurityToken(
                //issuer: _configuration[],
                //audience: _configuration["JWT:ValidAudience"],
                //expires: DateTime.Now.AddHours(3),
                //claims: authClaims,
                //signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                //);



                //return (new LoginResponseDto()
                //{
                //    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                //    FullName = user.Name + " " + user.Surname,
                //    Id = user.Id,
                //    UserType = user.Type,
                //    Number = user.Number
                //});
            }
            return new LoginResponseDto();
        }

        public Task<bool> Register(RegisterDto request)
        {
            throw new NotImplementedException();
        }
    }
}
