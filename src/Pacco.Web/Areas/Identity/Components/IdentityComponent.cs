using System.Threading.Tasks;
using Pacco.Web.Areas.Identity.Services;
using Pacco.Web.DTO;

namespace Pacco.Web.Areas.Identity.Components
{
    public class IdentityComponent
    {
        private readonly IIdentityServiceClient _identityServiceClient;

        public IdentityComponent(IIdentityServiceClient identityServiceClient)
        {
            _identityServiceClient = identityServiceClient;
        }

        public Task OnInit()
        {
            return Task.CompletedTask;
        }

        public Task SignUpAsync(string email, string password, string role = "user")
            => _identityServiceClient.SignUpAsync(email, password, role);
        
        public Task<JwtDto> SignInAsync(string email, string password)
            => _identityServiceClient.SignInAsync(email, password);
        
        public Task<UserDto> GetAccount(string jwt)
            => _identityServiceClient.GetAccountAsync(jwt);
    }
}