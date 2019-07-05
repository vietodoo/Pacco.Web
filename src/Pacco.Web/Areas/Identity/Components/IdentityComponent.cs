using System.Threading.Tasks;
using Pacco.Web.Areas.Identity.Services;

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

        public Task SignUpAsync(string email, string password, string role)
            => _identityServiceClient.SignUpAsync(email, password, role);
    }
}