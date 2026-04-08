using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManager.DAO;
using TaskManager.DTO;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly userDAO _dao;

    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration;
        _dao = new userDAO();
    }

    private string GenerateToken(string username, string role)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.Role, role)
        };

        var jwt = _configuration.GetSection("Jwt");
        var key = Encoding.UTF8.GetBytes(jwt["Key"]);

        var token = new JwtSecurityToken(
            issuer: jwt["Issuer"],
            audience: jwt["Issuer"],
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    [HttpPost("login")]
    public IActionResult Login(loginDTO dto)
    {
        var user = _dao.GetUserByNameUser(dto.username);

        if (user == null)
            return Unauthorized("Invalid username");

        if (dto.password != user.PasswordHash)
            return Unauthorized("Invalid password");

        var token = GenerateToken(user.UserName, user.Role);

        return Ok(new
        {
            success = true,
            token
        });
    }
}