using System.Security.Cryptography;

namespace DevFreela.Core.Services
{
    public interface IAuthService
    {
        string GenereteJwtToken(string email, string role);
    }
}
