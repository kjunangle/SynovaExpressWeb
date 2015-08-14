using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SynovaExpressWeb.Startup))]
namespace SynovaExpressWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
