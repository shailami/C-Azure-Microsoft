using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceMVCWebApplication.Startup))]
namespace EcommerceMVCWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
