using API_Vinted.Models;
using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_Vinted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private PasswordManager passwordManager;
        private VintedDBContext _dbContext;
        private List<User> appUsers = new List<User>
        {
            new User { UserName = "simon", Password = "1234", UserRole = "Admin" },
            new User { UserName = "tanguy", Password = "1234", UserRole = "User" }
        };
        public LoginController(IConfiguration config, VintedDBContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
            foreach (Client client in _dbContext.Clients)
            {
                appUsers.Add(new User {  UserName = client.Pseudo, Password = client.MotDePasse, UserRole = "User" ,IDClient = client.IDClient});
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User login)
        {
            IActionResult response = Unauthorized();
            User user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = GenerateJwtToken(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }
            return response;
        }
        private User AuthenticateUser(User user)
        {
            return appUsers.SingleOrDefault(x => x.UserName.ToUpper() == user.UserName.ToUpper() && PasswordManager.VerifyPassword(user.Password, x.Password));
        }

        private string GenerateJwtToken(User userInfo)
        {
            var securityKey = new
            SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim("userName", userInfo.UserName.ToString()),
                new Claim("role",userInfo.UserRole),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
