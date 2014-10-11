using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseErrorPage();

            app.UsePerRequestServices(services =>
            {
                services.AddMvc();
            });

            app.UseMvc();

            app.UseWelcomePage();
        }       
    }
}
