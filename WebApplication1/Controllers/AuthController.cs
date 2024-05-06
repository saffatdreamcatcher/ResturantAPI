using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        private readonly UserManager<User> userManager;

        public AuthController(IConfiguration config, UserManager<User> userManager)
        {
            _config = config;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<string> Login([FromBody] UserLogIn userLogIn)
        {
            var user = await userManager.FindByNameAsync(userLogIn.UserName) ?? throw new Exception("User not found");
            var result = await userManager.CheckPasswordAsync(user, userLogIn.Password);
            if (result)
            {
                return await Generate(user);
            }
            throw new Exception("User not found"); 
        }

        private async Task<string> Generate(User? user)
        {
            if (user == null)
            {
                return string.Empty;
            }

            var loginUser = await userManager.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Email == user.Email);

            if (loginUser == null)
            {
                return string.Empty; 
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            string userToken = tokenHandler.WriteToken(token);
            return userToken;
        }

    }
}

