using Online_Shop.Dtos.User;
using Online_Shop.Models;

namespace Online_Shop.Services.AuthService
{
    public interface IAuthService
    {
        Task<Response<string>> Login(UserLoginDto userLoginDto);
        Task<Response<int>> Register(UserRegistrationDto userRegistrationDto);
        Task<bool> UserExists(string username);
    }
}
