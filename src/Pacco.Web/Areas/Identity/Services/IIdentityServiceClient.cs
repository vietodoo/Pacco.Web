using System.Threading.Tasks;
using Pacco.Web.DTO;

namespace Pacco.Web.Areas.Identity.Services
{
    public interface IIdentityServiceClient
    {
        Task<UserDto> GetAccountAsync(string jwt);
        Task SignUpAsync(string email, string password, string role = "user");
        Task<JwtDto> SignInAsync(string email, string password);
    }
}