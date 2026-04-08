using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManager.DAO;
using TaskManager.DTO;

namespace TaskManager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class authController : ControllerBase
    {
        IConfiguration _configuration;
        public authController(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        private string GenerationToken(string username, string role)
        {
            var claim = new []
               {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };
            var jwt = _configuration.GetSection("Jwt");
            var key =  Encoding.UTF8.GetBytes(jwt["Key"]);
            var token = new JwtSecurityToken(
                issuer: jwt["Issuer"],
                audience: jwt["Issuer"],
                claims: claim,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost("login")]
        public IActionResult Login(loginDTO dto)
        {
            userDAO dao = new userDAO();

            var user = dao.GetUserByNameUser(dto.username);

            
            if (user == null)
                return Unauthorized("Sai tài khoản");

            if(dto.password != user.PasswordHash)
                return Unauthorized("Sai mật khẩu");
            var chuoitoken = GenerationToken(user.UserName, user.Role);
           
            return Ok(new
            {
                chuoitoken = chuoitoken
            });
        }
    }
}
