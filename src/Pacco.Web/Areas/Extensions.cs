using Microsoft.Extensions.DependencyInjection;
using Pacco.Web.Areas.Identity.Components;
using Pacco.Web.Areas.Identity.Services;
using Pacco.Web.Shared;

namespace Pacco.Web.Areas
{
    public static class Extensions
    {
        public static IServiceCollection RegisterIdentityArea(this  IServiceCollection services)
        {
            services.AddTransient<IIdentityServiceClient, IdentityServiceClient>();
            services.AddSingleton<IdentityComponent>();
            services.AddSingleton<MenuComponent>();
            
            return services;
        }
    }
}