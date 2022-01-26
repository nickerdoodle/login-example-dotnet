using backend.Models;

namespace backend.Interfaces
{
    public interface ILoginService
    {
        LoginCredentials CreateAccount();
    }
}
