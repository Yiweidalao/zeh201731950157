using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zeh201731950157.Startup))]
namespace zeh201731950157
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
