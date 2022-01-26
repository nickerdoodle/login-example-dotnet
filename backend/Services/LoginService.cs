using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class LoginService : ILoginService
    {
        public LoginCredentials CreateAccount()
        {
            return new LoginCredentials { username = "nick", password = "fds" };
        }

    }
}
