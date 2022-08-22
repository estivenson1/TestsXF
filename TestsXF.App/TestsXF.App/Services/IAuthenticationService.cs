using System.Threading.Tasks;

namespace TestsXF.App.Services
{
    public interface IAuthenticationService
    {
        Task<bool> SignInWithUserNameAndPasswordAsync(string userName, string password);
        
    }
}
