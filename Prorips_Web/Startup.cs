using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prorips_Web.Startup))]
namespace Prorips_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
