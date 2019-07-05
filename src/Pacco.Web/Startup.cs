using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Pacco.Web.Areas;
using Pacco.Web.Clients;

namespace Pacco.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(new HttpClientOptions
            {
                ApiUrl = "http://localhost:5000",
                Retries = 1
            });
            services.AddTransient<IHttpClient, CustomHttpClient>();
            services.RegisterIdentityArea();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
