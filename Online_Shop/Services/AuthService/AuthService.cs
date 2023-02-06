using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Online_Shop.Data;
using Online_Shop.Dtos.User;
using Online_Shop.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Online_Shop.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthService(AppDbContext dbContext, IMapper mapper, IConfiguration configuration) {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration=configuration;
        }

        public async Task<Response<string>> Login(UserLoginDto userLoginDto) {
            var response = new Response<string>();

            var user = await _dbContext.Users.FirstOrDefaultAsync(
               user => user.Username.ToLower() == userLoginDto.Username.ToLower() && user.Password == userLoginDto.Password);

            if (user == null)
            {
                response.Success = false;
                response.Message = "Wrong Username or password!";
            } else
            {
                response.Success = true;
                response.Message = "Loggend in successfully";
                response.Data = GenerateToken(user);
            }
            return response;
        }

        public async Task<Response<int>> Register(UserRegistrationDto userRegistrationDto) {
            var response = new Response<int>();
            if (await UserExists(userRegistrationDto.Username))
            {
                response.Success = false;
                response.Message = "User already registered";
            } else
            {
                var newUser = _mapper.Map<User>(userRegistrationDto);
                await _dbContext.Users.AddAsync(newUser);
                await _dbContext.SaveChangesAsync();
                response.Data = newUser.Id;
            }
            return response;
        }

        public async Task<bool> UserExists(string username) {
            return await _dbContext.Users.AnyAsync(u => u.Username == username);
        }

        private string GenerateToken(User user){
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Token").Value));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var token = new JwtSecurityToken(null, null, claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
